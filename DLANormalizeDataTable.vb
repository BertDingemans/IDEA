Public Class DLANormalizeDataTable
    Private _DataTable As DataTable
    Private _ResultDT As DataTable
    Public Percentage As Int32 = 20
    Public Optimize As Boolean = True
    Public Repository As EA.Repository
    Private oRoot As EA.Element
    Private RootFieldNames As List(Of String)

    Public Property DataTable() As DataTable
        Get
            Return _DataTable
        End Get
        Set(ByVal value As DataTable)
            _DataTable = value
        End Set
    End Property

    Sub New()
        Me._ResultDT = New DataTable("NormalizerResult")
        Me._ResultDT.Columns.Add(New DataColumn("EntityName", System.Type.GetType("System.String")))
        Me._ResultDT.Columns.Add(New DataColumn("Active", System.Type.GetType("System.Boolean")))
        Me._ResultDT.Columns.Add(New DataColumn("NormalizerType", System.Type.GetType("System.String")))
        Me._ResultDT.Columns.Add(New DataColumn("FieldNames", System.Type.GetType("System.String")))
        Me._ResultDT.Columns.Add(New DataColumn("Result", System.Type.GetType("System.Int32")))
    End Sub

    Private Sub AddResult(Type As String, Name As String, Count As Int32)
        Dim DRow As DataRow
        DRow = Me._ResultDT.NewRow()
        DRow("NormalizerType") = Type
        DRow("FieldNames") = Name
        DRow("Result") = Count
        DRow("EntityName") = IIf(Type = "Enumeration", "Enum_" + Name, Name.Replace(",", ""))
        Me._ResultDT.Rows.Add(DRow)
    End Sub

    Private Function CheckExist(Fields As List(Of String)) As Boolean
        Dim blnReturn As Boolean = True
        For Each FieldName As String In Fields
            Dim DV As New DataView(Me._ResultDT)
            DV.RowFilter = "FieldNames LIKE '%" + FieldName + "%' "
            Dim DT As DataTable = DV.ToTable()
            If DT.Rows.Count = 0 Then
                blnReturn = False
                Exit For
            End If
        Next
        Return blnReturn
    End Function
    Public Function EvaluateDataTable(Bar As System.Windows.Forms.ProgressBar) As DataTable
        Dim FieldPosRoot, FieldPosWalker
        Bar.Value = 0
        Bar.Minimum = 0
        Bar.Maximum = Me.DataTable.Columns.Count - 1
        Bar.Step = 1
        FieldPosRoot = 0
        FieldPosWalker = 1
        While FieldPosRoot < Me.DataTable.Columns.Count - 1
            Dim Velden As New List(Of String)
            Velden.Add(Me.DataTable.Columns(FieldPosRoot).ColumnName)
            'calculate enumarators
            Me.EvaluateEnumeration(Velden)
            'Calculate normal form entities
            FieldPosWalker = FieldPosRoot + 1
            While FieldPosWalker < Me.DataTable.Columns.Count
                If Me.EvaluateCombination(Velden, FieldPosWalker) Then
                End If
                FieldPosWalker += 1
            End While
            FieldPosRoot += 1
            Bar.PerformStep()
        End While
        Return _ResultDT
    End Function

    Public Function EvaluateCombination(Fields As List(Of String), FieldPosWalker As Int32) As Boolean
        Dim blnFoundChild As Boolean = False
        Dim intBorderValue As Int32 = Convert.ToInt32((Me.DataTable.Rows.Count * (Me.Percentage / 100)))
        While FieldPosWalker < Me.DataTable.Columns.Count
            If Not Fields.Contains(Me.DataTable.Columns(FieldPosWalker).ColumnName) Then
                Fields.Add(Me.DataTable.Columns(FieldPosWalker).ColumnName)
                Dim strResult As String = FieldsToString(Fields)
                Dim DV As New DataView(Me._DataTable)
                Dim DistinctDT As DataTable
                DistinctDT = DV.ToTable(True, Fields.ToArray())
                If DistinctDT.Rows.Count < intBorderValue Then
                    Dim blnNextFound As Boolean = False
                    Dim FieldPosNextWalker As Int32 = FieldPosWalker + 1
                    blnNextFound = Me.EvaluateCombination(Fields, FieldPosNextWalker)
                    'when the combination is already found or when we want to see all the combinations
                    If Not Me.CheckExist(Fields) Or Me.Optimize = False Then
                        Me.AddResult("FieldCombination", strResult, DistinctDT.Rows.Count)
                        blnFoundChild = True
                    End If
                End If
                Fields.Remove(Me.DataTable.Columns(FieldPosWalker).ColumnName)
            End If
            FieldPosWalker += 1
        End While
        Return blnFoundChild
    End Function
    Public Shared Function FieldsToString(Fields As List(Of String)) As String
        Dim strResult As String = ""
        For Each s As String In Fields
            strResult += IIf(strResult.Length = 0, "", ",") + s
        Next
        Return strResult
    End Function
    Function EvaluateEnumeration(Fields As List(Of String)) As Boolean
        Dim DV As New DataView(Me.DataTable)
        Dim DistinctDT As DataTable
        DistinctDT = DV.ToTable(True, Fields.ToArray())
        If DistinctDT.Rows.Count < (Me.DataTable.Rows.Count * (Me.Percentage / 100)) Then
            Me.AddResult("Enumeration", FieldsToString(Fields), DistinctDT.Rows.Count)
            Return True
        End If
        Return False
    End Function

    Function CreateEnumerations() As Boolean
        Dim DV As New DataView(Me._ResultDT)
        Dim DS2Rep As DLAFormfactory.DataSet2Repository
        DS2Rep = Me.GetRepositoryConnector()
        DV.RowFilter = " NormalizerType = 'Enumeration' And Active = True "
        Dim oDT As DataTable = DV.ToTable()
        For Each oDR As DataRow In oDT.Rows
            Dim oEnum As EA.Element
            oEnum = DS2Rep.AddUMLElement(oDR("EntityName"), "Enumeration")
            Dim DistinctDV As New DataView(Me.DataTable)
            Dim DistinctDT As DataTable
            DistinctDT = DistinctDV.ToTable(True, oDR("FieldNames").ToString().ToArray())
            For Each DistinctRow In DistinctDT.Rows
                DS2Rep.AddAttribute(oEnum, DistinctRow(0).ToString(), "String")
            Next
        Next
        Return True
    End Function
    Function CreateFieldCombinations() As Boolean
        Try
            Dim DV As New DataView(Me._ResultDT)
            Dim DS2Rep As DLAFormfactory.DataSet2Repository
            DS2Rep = Me.GetRepositoryConnector()
            DV.RowFilter = " NormalizerType = 'FieldCombination' And Active = True "
            Dim oDT As DataTable = DV.ToTable()
            For Each oDR As DataRow In oDT.Rows
                Dim oClass As EA.Element
                oClass = DS2Rep.AddUMLElement(oDR("EntityName"), "Class")
                Dim Fields As String() = oDR("FieldNames").ToString().Split(",")
                For Each FieldName In Fields
                    DS2Rep.AddAttribute(oClass, FieldName, "String")
                    If Me.RootFieldNames.Contains(FieldName) Then
                        Me.RootFieldNames.Remove(FieldName)
                    End If
                Next
                Dim oCon As EA.Connector
                oCon = DS2Rep.AddConnector(Me.oRoot, oClass, "")
                oCon.SupplierEnd.Cardinality = "0..*"
                oCon.ClientEnd.Cardinality = "1"
                oCon.Update()
            Next
            Return True
        Catch ex As Exception
            DLAFormfactory.DLA2EAHelper.Error2Log(ex)
        End Try
        Return False
    End Function

    Function CreateRootElement(Name As String) As Boolean
        Try
            If Name.Length = 0 Then
                MsgBox("Class name is necessary to creat a root element")
                Return False
            Else
                Dim DS2Rep As DLAFormfactory.DataSet2Repository
                DS2Rep = Me.GetRepositoryConnector()
                Me.RootFieldNames = New List(Of String)
                oRoot = DS2Rep.AddUMLElement(Name, "Class")
                For Each oDC As DataColumn In Me.DataTable.Columns
                    Me.RootFieldNames.Add(oDC.ColumnName)
                Next
            End If
            Return True
        Catch ex As Exception
            DLAFormfactory.DLA2EAHelper.Error2Log(ex)
        End Try
        Return False
    End Function

    Function CreateRootAttributes()
        Try
            For Each Field As String In Me.RootFieldNames
                Dim DS2Rep As DLAFormfactory.DataSet2Repository
                DS2Rep = Me.GetRepositoryConnector()
                DS2Rep.AddAttribute(Me.oRoot, Field, "String")
            Next
            Return True
        Catch ex As Exception
            DLAFormfactory.DLA2EAHelper.Error2Log(ex)
        End Try
        Return False
    End Function

    Private Function GetRepositoryConnector() As DLAFormfactory.DataSet2Repository
        Dim DS2Rep As New DLAFormfactory.DataSet2Repository()
        DS2Rep.Repository = Me.Repository
        DS2Rep.Package_Id = Me.Repository.GetTreeSelectedPackage().PackageID.ToString()
        Return DS2Rep
    End Function
End Class
