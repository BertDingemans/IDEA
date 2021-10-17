Imports TEA.DLAFormfactory

Public Class FrmIDEAPackage
    Public oPackage As EA.Package
    Private oTemplates As New HTMLTemplates()
    Private oDef As New IDEADefinitions()
    Private oSearchReplace As New DataTable("SEARCHREPLACE")

    Private Sub FrmIDEAPackage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.oSearchReplace.Columns.Add(New DataColumn("Search"))
        Me.oSearchReplace.Columns.Add(New DataColumn("Replace"))
        Me.DataGridViewSearchReplace.DataSource = Me.oSearchReplace

    End Sub

    Public Property Package() As EA.Package
        Get
            Return oPackage
        End Get
        Set(ByVal value As EA.Package)
            oPackage = value
            Me.LabelPackage.Text = oPackage.Name
        End Set
    End Property

    Private oRepository As EA.Repository
    Public Property Repository() As EA.Repository
        Get
            Return oRepository
        End Get
        Set(ByVal value As EA.Repository)
            oRepository = value
            Me.oPackage = Me.Repository.GetTreeSelectedPackage()
            Me.LabelPackage.Text = oPackage.Name

        End Set
    End Property

    Private Sub ButtonSort_Click(sender As Object, e As EventArgs) Handles ButtonSort.Click
        SortPackage(oPackage)

    End Sub
    Private Sub SortPackage(Package As EA.Package)
        Dim strSql As String = "select object_id FROM t_object where t_object.package_id = {0} order by {1} "
        Try
            oRepository.EnableUIUpdates = False
            If RadioButtonStereotype.Checked Then
                strSql = String.Format(strSql, Package.PackageID, "stereotype, name")
            End If
            If RadioButtonName.Checked Then
                strSql = String.Format(strSql, Package.PackageID, "name")
            End If
            If RadioButtonAlias.Checked Then
                strSql = String.Format(strSql, oPackage.PackageID, "alias")
            End If
            Dim oDT As DataTable
            oDT = DLA2EAHelper.SQL2DataTable(strSql, Me.Repository)
            Dim intTeller As Int32 = 1
            Dim oRow As DataRow
            Dim oElement As EA.Element
            DLA2EAHelper.SetProgressBarInit(Me.ProgressBar1, oDT.Rows.Count)
            For Each oRow In oDT.Rows
                oElement = oRepository.GetElementByID(oRow("object_id"))
                oElement.TreePos = intTeller
                intTeller += 1
                oElement.Update()
                Me.ProgressBar1.PerformStep()
            Next
            oRepository.RefreshModelView(oPackage.PackageID)
            oRepository.EnableUIUpdates = True
            If Me.CheckBoxRecursive.Checked Then
                For Each oSubPack As EA.Package In Package.Packages
                    SortPackage(oSubPack)
                Next
            End If
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
    End Sub

    Private Sub ButtonRemoveNesting_Click(sender As Object, e As EventArgs) Handles ButtonRemoveNesting.Click
        RemoveNesting(Me.oPackage)
    End Sub

    Private Sub RemoveNesting(Package As EA.Package)
        Dim strSql As String = "UPDATE t_object SET parentid = 0 WHERE parentid > 0 AND package_id = " + oPackage.PackageID.ToString()
        Me.Repository.Execute(strSql)
        Me.Repository.RefreshModelView(Package.PackageID)
        If Me.CheckBoxRecursive.Checked Then
            For Each oSubPack As EA.Package In Package.Packages
                RemoveNesting(oSubPack)
            Next
        End If
    End Sub

    Private Sub SearchandReplace(Package As EA.Package)
        Dim intCount As Int32 = 1
        For Each oRow As DataRow In Me.oSearchReplace.Rows
            If CheckBoxReplaceName.Checked Then
                Package.Name = Package.Name.Replace(oRow("Search"), oRow("Replace"))
            End If
            If CheckBoxReplaceAlias.Checked Then
                Package.Alias = Package.Alias.Replace(oRow("Search"), oRow("Replace"))
            End If
            If CheckBoxReplaceNotes.Checked Then
                Package.Notes = Package.Notes.Replace(oRow("Search"), oRow("Replace"))
            End If
            intCount += Package.Elements.Count + Package.Diagrams.Count
            DLA2EAHelper.SetProgressBarInit(Me.ProgressBar1, intCount)
            ProgressBar1.PerformStep()
            For Each Element As EA.Element In Package.Elements
                If CheckBoxReplaceName.Checked Then
                    Element.Name = Element.Name.Replace(oRow("Search"), oRow("Replace"))
                End If
                If CheckBoxReplaceAlias.Checked Then
                    Element.Alias = Element.Alias.Replace(oRow("Search"), oRow("Replace"))
                End If
                If CheckBoxReplaceNotes.Checked Then
                    Element.Notes = Element.Notes.Replace(oRow("Search"), oRow("Replace"))
                End If
                If Not Element.Locked Then
                    Element.Update()
                End If

                ProgressBar1.PerformStep()
            Next
            For Each Diagram As EA.Diagram In Package.Diagrams
                If CheckBoxReplaceName.Checked Then
                    Diagram.Name = Diagram.Name.Replace(oRow("Search"), oRow("Replace"))
                End If

                If CheckBoxReplaceNotes.Checked Then
                    Diagram.Notes = Diagram.Notes.Replace(oRow("Search"), oRow("Replace"))
                End If
                Diagram.Update()
                ProgressBar1.PerformStep()
            Next
        Next
        Package.Update()
        If Me.CheckBoxRecursive.Checked Then
            For Each SubPack As EA.Package In Package.Packages
                SearchandReplace(SubPack)
            Next
        End If
    End Sub

    Private Sub ButtonSearchReplace_Click(sender As Object, e As EventArgs) Handles ButtonSearchReplace.Click
        SearchandReplace(Me.oPackage)
    End Sub
End Class