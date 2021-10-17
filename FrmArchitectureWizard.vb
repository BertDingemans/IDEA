Imports TEA.DLAFormfactory
Public Class FrmArchitectureWizard

    Private oRepository As EA.Repository
    Private oTemplatePackage As EA.Package
    Private oProjectPackage As EA.Package
    Private intDiagramTeller As Int32 = 0
    Private TemplateSQL As String = "select child.package_id, child.name
                                    from t_package parent 
                                    inner join t_package child on child.parent_id = parent.package_id
                                    where parent.ea_guid = '{C44D8B99-E93D-480b-9DC1-D3846F9CEBDF}'
                                    order by child.name"
    Private WorkPackageSQL As String = "select child.package_id, child.name
                                    from t_package parent 
                                    inner join t_package child on child.parent_id = parent.package_id
                                    where parent.ea_guid = '{73E198EC-D755-4003-9F7E-EEBE56C36677}'
                                    order by child.name"
    Private DiagramObjectSQL As String = "UPDATE t_diagramobjects 
                                            SET t_diagramobjects.object_id = WorkObject.Object_id 
                                            FROM t_diagramobjects INNER JOIN  t_object TemplateObject ON  t_diagramobjects.Object_ID = TemplateObject.Object_ID
                                            INNER JOIN t_object WorkObject ON TemplateObject.Name = WorkObject.Name
                                            INNER JOIN t_diagram ON   t_diagramobjects.diagram_id = t_diagram.diagram_id
                                            WHERE t_diagram.package_id = {1}
                                            AND TemplateObject.Package_ID = {0}
                                            AND WorkObject.Package_ID = {1} "

    Private StereotypeSQL As String = "SELECT distinct stereotype
                                        FROM t_object
                                        ORDER BY stereotype"

    Private ExistingElementStereoTypeSQL As String = "SELECT object_id, name
                                                        FROM t_object 
                                                        WHERE t_object.stereotype = '{0}'
                                                        ORDER BY name"

    Private ExistingElementSourceSystemSQL As String = "SELECT t_object.object_id, t_object.name
                                                        FROM t_object 
                                                        INNER JOIN t_package ON t_package.package_id = t_object.package_id
                                                        WHERE t_object.stereotype = 'ArchiMate_ApplicationComponent'
                                                        AND t_package.name LIKE '%bronnen%'
                                                        ORDER BY name"

    Private ExistingElementDataObjectSQL As String = "SELECT object_id, name
                                                        FROM t_object 
                                                        WHERE t_object.stereotype = 'ArchiMate_DataObject'
                                                        ORDER BY name"

    Private ExistingElementInformationProductSQL As String = "SELECT object_id, name
                                                        FROM t_object 
                                                        WHERE t_object.stereotype = 'ArchiMate_DataObject'
                                                        ORDER BY name"

    Private ExistingElementIBBSQL As String = "SELECT object_id, name
                                                FROM t_object 
                                                WHERE t_object.stereotype = 'ArchiMate_ApplicationService'
                                                ORDER BY name"

    Public Property Repository() As EA.Repository
        Get
            Return oRepository
        End Get
        Set(ByVal value As EA.Repository)
            oRepository = value
        End Set
    End Property
    Private newPropertyValue As String
    Private Sub FrmArchitectureWizard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DTTemplate As DataTable = DLA2EAHelper.SQL2DataTable(TemplateSQL, Repository)
        Me.ComboBoxTemplatePackage.DataSource = DTTemplate
        Me.ComboBoxTemplatePackage.DisplayMember = "name"
        Me.ComboBoxTemplatePackage.ValueMember = "package_id"

        Dim DTWorkPackage As DataTable = DLA2EAHelper.SQL2DataTable(WorkPackageSQL, Repository)
        Me.ComboBoxWorkPackage.DataSource = DTWorkPackage
        Me.ComboBoxWorkPackage.DisplayMember = "name"
        Me.ComboBoxWorkPackage.ValueMember = "package_id"

        Dim DTStereotype As DataTable = DLA2EAHelper.SQL2DataTable(StereotypeSQL, Repository)
        ComboBoxStereotype.DataSource = DTStereotype
        Me.ComboBoxStereotype.DisplayMember = "Stereotype"
        Me.ComboBoxStereotype.ValueMember = "Stereotype"
        Me.CheckedListBoxExistingElement.CheckOnClick = True
        InitiateNewElements()
        LoadSQLFromSettings()
    End Sub
    Private Sub LoadSQLFromSettings()
        Dim IDef As New IDEADefinitions()
        Me.TemplateSQL = IDef.GetSettingValue("WizardTemplateSQL")
        Me.WorkPackageSQL = IDef.GetSettingValue("WizardWorkPackageSQL")
        Me.DiagramObjectSQL = IDef.GetSettingValue("WizardDiagramObjectsSQL")
        Me.StereotypeSQL = IDef.GetSettingValue("WizardStereotypeSQL")
        Me.ExistingElementStereoTypeSQL = IDef.GetSettingValue("WizardExistingElementStereoTypeSQL")
        Me.ExistingElementSourceSystemSQL = IDef.GetSettingValue("WizardExistingElementSourceSystemSQL")
        Me.ExistingElementDataObjectSQL = IDef.GetSettingValue("WizardExistingElementDataObjectSQL")
        Me.ExistingElementInformationProductSQL = IDef.GetSettingValue("WizardExistingElementInformationProductSQL")
        Me.ExistingElementIBBSQL = IDef.GetSettingValue("WizardExistingElementIBBSQL")
    End Sub
    Private Function InitiateNewElements() As Boolean
        Dim oNewElement As New DataTable("NewElement")
        oNewElement.Columns.Add(New DataColumn("Name"))
        Me.DataGridViewNewElements.DataSource = oNewElement
        Return True
    End Function
    Private Sub CreateDiagramObject(Diagram As EA.Diagram, Object_id As Int32)
        Dim Generator As System.Random = New System.Random()
        Dim intTop As Int32 = Generator.Next(-200, 0)
        Dim intLeft As Int32 = Generator.Next(0, 200)
        Dim objDON As EA.DiagramObject
        objDON = Diagram.DiagramObjects.AddNew("", "")
        objDON.ElementID = Object_id
        objDON.top = intTop
        objDON.bottom = intTop - 50
        objDON.left = intLeft
        objDON.right = intLeft + 120
        objDON.ShowNotes = False
        objDON.Update()
        Diagram.Update()
    End Sub
    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        Try
            If Me.TabControl1.SelectedIndex = 0 Then
                Me.ButtonPrevious.Enabled = False
            Else
                Me.ButtonPrevious.Enabled = True
            End If

            If Me.TabControl1.SelectedTab.Name = "TabPageTemplate" Then
                Me.oTemplatePackage = Repository.GetPackageByID(Convert.ToInt32(Me.ComboBoxTemplatePackage.SelectedValue))
                Me.oProjectPackage = Me.oTemplatePackage.Clone()
                Me.oProjectPackage.ParentID = Convert.ToInt32(Me.ComboBoxWorkPackage.SelectedValue)
                oProjectPackage.Notes = TextBoxNotes.Text
                Me.oProjectPackage.Update()
                Dim strSQL As String = String.Format(Me.DiagramObjectSQL, oTemplatePackage.PackageID, oProjectPackage.PackageID)
                Me.Repository.Execute(strSQL)
                SearchReplace()
                Me.TabControl1.SelectTab(Me.TabControl1.SelectedIndex + 1)
                Me.ButtonPrevious.Enabled = True
            End If
            If Me.TabControl1.SelectedTab.Name = "TabPageElements" Then
                Dim objDiagram As EA.Diagram
                'verwerken van het openstaande scherm
                If intDiagramTeller >= 0 And intDiagramTeller < oProjectPackage.Diagrams.Count Then
                    objDiagram = oProjectPackage.Diagrams(intDiagramTeller)
                    Me.Repository.OpenDiagram(objDiagram.DiagramID)
                    Me.TextBoxDiagramName.Text = objDiagram.Name
                    intDiagramTeller += 1
                End If
            End If
            If intDiagramTeller = oProjectPackage.Diagrams.Count Then
                Me.ButtonNext.Enabled = False
            End If
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
    End Sub

    Private Sub SearchReplace()
        Try
            Dim oSearchReplace As New DataTable("SEARCHREPLACE")
            oSearchReplace.Columns.Add(New DataColumn("Search"))
            oSearchReplace.Columns.Add(New DataColumn("Replace"))
            Dim TemplateRow As DataRow = oSearchReplace.NewRow()
            TemplateRow("Search") = "Template"
            TemplateRow("Replace") = ""
            oSearchReplace.Rows.Add(TemplateRow)
            Dim ProjectRow As DataRow = oSearchReplace.NewRow()
            ProjectRow("Search") = "[Project]"
            ProjectRow("Replace") = Me.TextBoxProject.Text
            oSearchReplace.Rows.Add(ProjectRow)
            For Each oRow As DataRow In oSearchReplace.Rows
                oProjectPackage.Name = oProjectPackage.Name.Replace(oRow("Search"), oRow("Replace"))
            Next
            oProjectPackage.Update()

            For Each Diagram As EA.Diagram In Me.oProjectPackage.Diagrams
                For Each oRow As DataRow In oSearchReplace.Rows
                    Diagram.Name = Diagram.Name.Replace(oRow("Search"), oRow("Replace"))
                Next
                Diagram.Update()
            Next
            For Each Element As EA.Element In Me.oProjectPackage.Elements
                For Each oRow As DataRow In oSearchReplace.Rows
                    Element.Name = Element.Name.Replace(oRow("Search"), oRow("Replace"))
                Next
                Element.Update()
            Next
            oProjectPackage.Update()
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
    End Sub

    Private Sub ButtonPrevious_Click(sender As Object, e As EventArgs) Handles ButtonPrevious.Click

        If Me.TabControl1.SelectedTab.Name = "TabPageTemplate" Then
            Me.ButtonPrevious.Enabled = False
        End If

        If Me.TabControl1.SelectedTab.Name = "TabPageElements" Then
            If intDiagramTeller >= 0 And intDiagramTeller <= oProjectPackage.Diagrams.Count Then
                Me.ButtonNext.Enabled = True
                intDiagramTeller -= 1
                Dim objDiagram As EA.Diagram
                objDiagram = oProjectPackage.Diagrams(intDiagramTeller)
                Me.TextBoxDiagramName.Text = objDiagram.Name
                Me.Repository.OpenDiagram(objDiagram.DiagramID)
            End If
            If intDiagramTeller = 0 Then
                Me.TabControl1.SelectTab("TabPageTemplate")
            End If
        End If
    End Sub

    Private Sub ComboBoxStereotype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxStereotype.SelectedIndexChanged
        Dim EEDT As DataTable = DLA2EAHelper.SQL2DataTable(String.Format(ExistingElementStereoTypeSQL, Me.ComboBoxStereotype.SelectedValue), Repository)
        SetDataGrid4Table(EEDT)
    End Sub
    Private Sub SetDataGrid4Table(DT As DataTable)
        If DT.Columns.Count > 0 Then
            Me.CheckedListBoxExistingElement.DataSource = DT
            Me.CheckedListBoxExistingElement.DisplayMember = "name"
            Me.CheckedListBoxExistingElement.ValueMember = "object_id"
        End If
    End Sub
    Private Sub RadioButtonOther_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOther.CheckedChanged
        Me.ComboBoxStereotype.Enabled = RadioButtonOther.Checked
    End Sub

    Private Sub RadioButtonInfoProduct_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonInfoProduct.CheckedChanged
        Dim EEDT As DataTable = DLA2EAHelper.SQL2DataTable(String.Format(ExistingElementInformationProductSQL), Repository)
        SetDataGrid4Table(EEDT)
        Me.ComboBoxStereotype.SelectedValue = "ArchiMate_DataObject"
    End Sub

    Private Sub RadioButtonIBB_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonIBB.CheckedChanged
        Dim EEDT As DataTable = DLA2EAHelper.SQL2DataTable(String.Format(ExistingElementIBBSQL), Repository)
        SetDataGrid4Table(EEDT)
        Me.ComboBoxStereotype.SelectedValue = "ArchiMate_ApplicationService"
    End Sub

    Private Sub RadioButtonDataObjects_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonDataObjects.CheckedChanged
        Dim EEDT As DataTable = DLA2EAHelper.SQL2DataTable(String.Format(ExistingElementDataObjectSQL), Repository)
        SetDataGrid4Table(EEDT)
        Me.ComboBoxStereotype.SelectedValue = "ArchiMate_DataObject"

    End Sub

    Private Sub RadioButtonSourceSystem_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonSourceSystem.CheckedChanged
        Dim EEDT As DataTable = DLA2EAHelper.SQL2DataTable(String.Format(ExistingElementSourceSystemSQL), Repository)
        SetDataGrid4Table(EEDT)
        Me.ComboBoxStereotype.SelectedValue = "ArchiMate_ApplicationComponent"
    End Sub

    Private Sub ButtonGenerate_Click(sender As Object, e As EventArgs) Handles ButtonGenerate.Click
        Dim objDiagram As EA.Diagram
        If intDiagramTeller > 0 Then
            objDiagram = Repository.GetCurrentDiagram()
            Dim intTop As Integer = -100
            Dim intLeft As Integer = 100
            Me.Repository.EnableUIUpdates = False
            For Each Item In CheckedListBoxExistingElement.CheckedItems
                CreateDiagramObject(objDiagram, Convert.ToInt32(Item("object_id")))
            Next
            If Me.ComboBoxStereotype.SelectedIndex() >= 0 Then
                For Each Row In Me.DataGridViewNewElements.Rows
                    If Not IsNothing(Row.Cells(0).Value) Then
                        Dim oObject As EA.Element
                        oObject = oProjectPackage.Elements.AddNew(Row.Cells(0).Value.ToString(), DLA2EAHelper.ConvertStereotype2Type(ComboBoxStereotype.SelectedValue))
                        oObject.Stereotype = ComboBoxStereotype.SelectedValue
                        oObject.Update()
                        CreateDiagramObject(objDiagram, oObject.ElementID)
                    End If
                Next
            End If
            Repository.SaveDiagram(objDiagram.DiagramID)
            Me.Repository.EnableUIUpdates = True
            Repository.ReloadDiagram(objDiagram.DiagramID)
            Me.CheckedListBoxExistingElement.DataSource = Nothing
            InitiateNewElements()
        End If
    End Sub
End Class