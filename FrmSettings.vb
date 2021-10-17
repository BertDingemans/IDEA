Imports System.ComponentModel
Imports System.IO
Imports System.Windows.Forms
Imports TEA.DLAFormfactory

Public Class FrmSettings
    Private _Repository As EA.Repository

    Public Property Repository() As EA.Repository
        Get
            Return _Repository
        End Get
        Set(ByVal value As EA.Repository)
            _Repository = value
        End Set
    End Property
    Private Sub FrmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDefinitions As New IDEADefinitions(Me.Repository)
        If oDefinitions.CheckVersion Then
            Me.DataGridViewSettings.DataSource = oDefinitions.GetTable("SETTINGS")
            DataGridViewSettings.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            DataGridViewSettings.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
            DataGridViewSettings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            Me.DataGridViewStatement.DataSource = oDefinitions.GetTable("SQL-STATEMENT")
            DataGridViewStatement.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            DataGridViewStatement.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
            DataGridViewStatement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            LoadUserSettings()
        Else
            MsgBox("You use an old version of the IDEA AddOn, install a new version")
            Me.Close()
        End If

    End Sub

    Private Sub LoadUserSettings()
        Me.CheckBoxAssistant.Checked = My.Settings.Assistant
        Me.CheckBoxArchimAid.Checked = My.Settings.ArchimAid
        Me.CheckBoxDatAid.Checked = My.Settings.DatAid
        Me.CheckBoxDeduplicator.Checked = My.Settings.Deduplicator
        Me.CheckBoxFormFactory.Checked = My.Settings.FormFactory
        Me.CheckBoxDocumentImport.Checked = My.Settings.DocumentImport
        Me.CheckBoxSolutionWizard.Checked = My.Settings.SolutionWizard
        Me.CheckBoxPackageHelper.Checked = My.Settings.PackageHelper
        Me.CheckBoxDiagramHelper.Checked = My.Settings.DiagramHelper
        Me.CheckBoxClassHelper.Checked = My.Settings.ClassHelper
        Me.CheckBoxTableHelper.Checked = My.Settings.TableHelper
        Me.CheckBoxArchiMateHelper.Checked = My.Settings.ArchiMateHelper
        Me.CheckBoxXSDHelper.Checked = My.Settings.XSDHelper
        Me.CheckBoxShowAidOnDiagramOpen.Checked = My.Settings.ShowAidOnDiagramOpen

    End Sub
    Private Sub SaveUserSettings()
        My.Settings.Assistant = Me.CheckBoxAssistant.Checked
        My.Settings.ArchimAid = Me.CheckBoxArchimAid.Checked
        My.Settings.DatAid = Me.CheckBoxDatAid.Checked
        My.Settings.Deduplicator = Me.CheckBoxDeduplicator.Checked
        My.Settings.FormFactory = Me.CheckBoxFormFactory.Checked
        My.Settings.DocumentImport = Me.CheckBoxDocumentImport.Checked
        My.Settings.PackageHelper = Me.CheckBoxPackageHelper.Checked
        My.Settings.DiagramHelper = Me.CheckBoxDiagramHelper.Checked
        My.Settings.ClassHelper = Me.CheckBoxClassHelper.Checked
        My.Settings.TableHelper = Me.CheckBoxTableHelper.Checked
        My.Settings.ArchiMateHelper = Me.CheckBoxArchiMateHelper.Checked
        My.Settings.XSDHelper = Me.CheckBoxXSDHelper.Checked
        My.Settings.SolutionWizard = Me.CheckBoxSolutionWizard.Checked
        My.Settings.ShowAidOnDiagramOpen = Me.CheckBoxShowAidOnDiagramOpen.Checked
        My.Settings.Save()

    End Sub
    Private Sub FrmSettings_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            SaveUserSettings()
            If MsgBox("Save settings modifications?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim oDefinitionsDT As DataTable
                oDefinitionsDT = Me.DataGridViewSettings.DataSource
                Dim streamsettings As New StringWriter()
                oDefinitionsDT.WriteXml(streamsettings, True)
                Dim oStatements As DataTable
                oStatements = Me.DataGridViewStatement.DataSource
                Dim streamstatements As New StringWriter()
                oStatements.WriteXml(streamstatements, True)
                Dim oDefinitions As New IDEADefinitions()
                oDefinitions.SaveSettings(streamsettings.ToString(), streamstatements.ToString(), Me.Repository)
            End If
        Catch ex As Exception
            DLA2EAHelper.Error2Log(ex)
        End Try
    End Sub

    Private Sub TabPageUser_Click(sender As Object, e As EventArgs) Handles TabPageUser.Click

    End Sub

    Private Sub DataGridViewSettings_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewSettings.CellContentClick

    End Sub
End Class