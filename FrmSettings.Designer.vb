<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridViewSettings = New System.Windows.Forms.DataGridView()
        Me.TabControlSettings = New System.Windows.Forms.TabControl()
        Me.TabPageUser = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxShowAidOnDiagramOpen = New System.Windows.Forms.CheckBox()
        Me.CheckBoxXSDHelper = New System.Windows.Forms.CheckBox()
        Me.CheckBoxArchiMateHelper = New System.Windows.Forms.CheckBox()
        Me.CheckBoxPackageHelper = New System.Windows.Forms.CheckBox()
        Me.CheckBoxTableHelper = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDiagramHelper = New System.Windows.Forms.CheckBox()
        Me.CheckBoxClassHelper = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxSolutionWizard = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDocumentImport = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAssistant = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDeduplicator = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDatAid = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFormFactory = New System.Windows.Forms.CheckBox()
        Me.CheckBoxArchimAid = New System.Windows.Forms.CheckBox()
        Me.TabPageSystem = New System.Windows.Forms.TabPage()
        Me.TabPageStatements = New System.Windows.Forms.TabPage()
        Me.DataGridViewStatement = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridViewSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlSettings.SuspendLayout()
        Me.TabPageUser.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPageSystem.SuspendLayout()
        Me.TabPageStatements.SuspendLayout()
        CType(Me.DataGridViewStatement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewSettings
        '
        Me.DataGridViewSettings.AllowUserToOrderColumns = True
        Me.DataGridViewSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewSettings.Location = New System.Drawing.Point(4, 4)
        Me.DataGridViewSettings.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridViewSettings.Name = "DataGridViewSettings"
        Me.DataGridViewSettings.RowHeadersWidth = 51
        Me.DataGridViewSettings.RowTemplate.Height = 24
        Me.DataGridViewSettings.Size = New System.Drawing.Size(811, 500)
        Me.DataGridViewSettings.TabIndex = 0
        '
        'TabControlSettings
        '
        Me.TabControlSettings.Controls.Add(Me.TabPageUser)
        Me.TabControlSettings.Controls.Add(Me.TabPageSystem)
        Me.TabControlSettings.Controls.Add(Me.TabPageStatements)
        Me.TabControlSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlSettings.Location = New System.Drawing.Point(0, 0)
        Me.TabControlSettings.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControlSettings.Name = "TabControlSettings"
        Me.TabControlSettings.SelectedIndex = 0
        Me.TabControlSettings.Size = New System.Drawing.Size(827, 537)
        Me.TabControlSettings.TabIndex = 1
        '
        'TabPageUser
        '
        Me.TabPageUser.BackColor = System.Drawing.Color.LightGray
        Me.TabPageUser.Controls.Add(Me.TextBox1)
        Me.TabPageUser.Controls.Add(Me.GroupBox2)
        Me.TabPageUser.Controls.Add(Me.GroupBox1)
        Me.TabPageUser.Location = New System.Drawing.Point(4, 25)
        Me.TabPageUser.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPageUser.Name = "TabPageUser"
        Me.TabPageUser.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPageUser.Size = New System.Drawing.Size(819, 508)
        Me.TabPageUser.TabIndex = 1
        Me.TabPageUser.Text = "User"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.No
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(17, 434)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(795, 65)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "Settings in the system tab can be stored in an artifact in the repository named I" &
    "DEAConfig. The items under the usertab are stored in your userspecific data"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBoxShowAidOnDiagramOpen)
        Me.GroupBox2.Controls.Add(Me.CheckBoxXSDHelper)
        Me.GroupBox2.Controls.Add(Me.CheckBoxArchiMateHelper)
        Me.GroupBox2.Controls.Add(Me.CheckBoxPackageHelper)
        Me.GroupBox2.Controls.Add(Me.CheckBoxTableHelper)
        Me.GroupBox2.Controls.Add(Me.CheckBoxDiagramHelper)
        Me.GroupBox2.Controls.Add(Me.CheckBoxClassHelper)
        Me.GroupBox2.Location = New System.Drawing.Point(291, 17)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(265, 329)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Helpers"
        '
        'CheckBoxShowAidOnDiagramOpen
        '
        Me.CheckBoxShowAidOnDiagramOpen.AutoSize = True
        Me.CheckBoxShowAidOnDiagramOpen.Location = New System.Drawing.Point(20, 246)
        Me.CheckBoxShowAidOnDiagramOpen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxShowAidOnDiagramOpen.Name = "CheckBoxShowAidOnDiagramOpen"
        Me.CheckBoxShowAidOnDiagramOpen.Size = New System.Drawing.Size(207, 21)
        Me.CheckBoxShowAidOnDiagramOpen.TabIndex = 6
        Me.CheckBoxShowAidOnDiagramOpen.Text = "Show Aid On Diagram Open"
        Me.CheckBoxShowAidOnDiagramOpen.UseVisualStyleBackColor = True
        '
        'CheckBoxXSDHelper
        '
        Me.CheckBoxXSDHelper.AutoSize = True
        Me.CheckBoxXSDHelper.Location = New System.Drawing.Point(20, 201)
        Me.CheckBoxXSDHelper.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxXSDHelper.Name = "CheckBoxXSDHelper"
        Me.CheckBoxXSDHelper.Size = New System.Drawing.Size(102, 21)
        Me.CheckBoxXSDHelper.TabIndex = 5
        Me.CheckBoxXSDHelper.Text = "XSD helper"
        Me.CheckBoxXSDHelper.UseVisualStyleBackColor = True
        '
        'CheckBoxArchiMateHelper
        '
        Me.CheckBoxArchiMateHelper.AutoSize = True
        Me.CheckBoxArchiMateHelper.Location = New System.Drawing.Point(20, 167)
        Me.CheckBoxArchiMateHelper.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxArchiMateHelper.Name = "CheckBoxArchiMateHelper"
        Me.CheckBoxArchiMateHelper.Size = New System.Drawing.Size(137, 21)
        Me.CheckBoxArchiMateHelper.TabIndex = 4
        Me.CheckBoxArchiMateHelper.Text = "ArchiMate helper"
        Me.CheckBoxArchiMateHelper.UseVisualStyleBackColor = True
        '
        'CheckBoxPackageHelper
        '
        Me.CheckBoxPackageHelper.AutoSize = True
        Me.CheckBoxPackageHelper.Location = New System.Drawing.Point(20, 34)
        Me.CheckBoxPackageHelper.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxPackageHelper.Name = "CheckBoxPackageHelper"
        Me.CheckBoxPackageHelper.Size = New System.Drawing.Size(129, 21)
        Me.CheckBoxPackageHelper.TabIndex = 0
        Me.CheckBoxPackageHelper.Text = "Package helper"
        Me.CheckBoxPackageHelper.UseVisualStyleBackColor = True
        '
        'CheckBoxTableHelper
        '
        Me.CheckBoxTableHelper.AutoSize = True
        Me.CheckBoxTableHelper.Location = New System.Drawing.Point(20, 134)
        Me.CheckBoxTableHelper.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxTableHelper.Name = "CheckBoxTableHelper"
        Me.CheckBoxTableHelper.Size = New System.Drawing.Size(110, 21)
        Me.CheckBoxTableHelper.TabIndex = 3
        Me.CheckBoxTableHelper.Text = "Table helper"
        Me.CheckBoxTableHelper.UseVisualStyleBackColor = True
        '
        'CheckBoxDiagramHelper
        '
        Me.CheckBoxDiagramHelper.AutoSize = True
        Me.CheckBoxDiagramHelper.Location = New System.Drawing.Point(20, 68)
        Me.CheckBoxDiagramHelper.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxDiagramHelper.Name = "CheckBoxDiagramHelper"
        Me.CheckBoxDiagramHelper.Size = New System.Drawing.Size(127, 21)
        Me.CheckBoxDiagramHelper.TabIndex = 1
        Me.CheckBoxDiagramHelper.Text = "Diagram helper"
        Me.CheckBoxDiagramHelper.UseVisualStyleBackColor = True
        '
        'CheckBoxClassHelper
        '
        Me.CheckBoxClassHelper.AutoSize = True
        Me.CheckBoxClassHelper.Location = New System.Drawing.Point(20, 101)
        Me.CheckBoxClassHelper.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxClassHelper.Name = "CheckBoxClassHelper"
        Me.CheckBoxClassHelper.Size = New System.Drawing.Size(108, 21)
        Me.CheckBoxClassHelper.TabIndex = 2
        Me.CheckBoxClassHelper.Text = "Class helper"
        Me.CheckBoxClassHelper.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBoxSolutionWizard)
        Me.GroupBox1.Controls.Add(Me.CheckBoxDocumentImport)
        Me.GroupBox1.Controls.Add(Me.CheckBoxAssistant)
        Me.GroupBox1.Controls.Add(Me.CheckBoxDeduplicator)
        Me.GroupBox1.Controls.Add(Me.CheckBoxDatAid)
        Me.GroupBox1.Controls.Add(Me.CheckBoxFormFactory)
        Me.GroupBox1.Controls.Add(Me.CheckBoxArchimAid)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 17)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(265, 329)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu"
        '
        'CheckBoxSolutionWizard
        '
        Me.CheckBoxSolutionWizard.AutoSize = True
        Me.CheckBoxSolutionWizard.Location = New System.Drawing.Point(21, 218)
        Me.CheckBoxSolutionWizard.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxSolutionWizard.Name = "CheckBoxSolutionWizard"
        Me.CheckBoxSolutionWizard.Size = New System.Drawing.Size(129, 21)
        Me.CheckBoxSolutionWizard.TabIndex = 6
        Me.CheckBoxSolutionWizard.Text = "Solution Wizard"
        Me.CheckBoxSolutionWizard.UseVisualStyleBackColor = True
        '
        'CheckBoxDocumentImport
        '
        Me.CheckBoxDocumentImport.AutoSize = True
        Me.CheckBoxDocumentImport.Location = New System.Drawing.Point(21, 190)
        Me.CheckBoxDocumentImport.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxDocumentImport.Name = "CheckBoxDocumentImport"
        Me.CheckBoxDocumentImport.Size = New System.Drawing.Size(150, 21)
        Me.CheckBoxDocumentImport.TabIndex = 5
        Me.CheckBoxDocumentImport.Text = "Document Importer"
        Me.CheckBoxDocumentImport.UseVisualStyleBackColor = True
        '
        'CheckBoxAssistant
        '
        Me.CheckBoxAssistant.AutoSize = True
        Me.CheckBoxAssistant.Location = New System.Drawing.Point(20, 158)
        Me.CheckBoxAssistant.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxAssistant.Name = "CheckBoxAssistant"
        Me.CheckBoxAssistant.Size = New System.Drawing.Size(87, 21)
        Me.CheckBoxAssistant.TabIndex = 4
        Me.CheckBoxAssistant.Text = "Assistant"
        Me.CheckBoxAssistant.UseVisualStyleBackColor = True
        '
        'CheckBoxDeduplicator
        '
        Me.CheckBoxDeduplicator.AutoSize = True
        Me.CheckBoxDeduplicator.Location = New System.Drawing.Point(20, 34)
        Me.CheckBoxDeduplicator.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxDeduplicator.Name = "CheckBoxDeduplicator"
        Me.CheckBoxDeduplicator.Size = New System.Drawing.Size(110, 21)
        Me.CheckBoxDeduplicator.TabIndex = 0
        Me.CheckBoxDeduplicator.Text = "Deduplicator"
        Me.CheckBoxDeduplicator.UseVisualStyleBackColor = True
        '
        'CheckBoxDatAid
        '
        Me.CheckBoxDatAid.AutoSize = True
        Me.CheckBoxDatAid.Location = New System.Drawing.Point(20, 127)
        Me.CheckBoxDatAid.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxDatAid.Name = "CheckBoxDatAid"
        Me.CheckBoxDatAid.Size = New System.Drawing.Size(74, 21)
        Me.CheckBoxDatAid.TabIndex = 3
        Me.CheckBoxDatAid.Text = "DatAID"
        Me.CheckBoxDatAid.UseVisualStyleBackColor = True
        '
        'CheckBoxFormFactory
        '
        Me.CheckBoxFormFactory.AutoSize = True
        Me.CheckBoxFormFactory.Location = New System.Drawing.Point(20, 65)
        Me.CheckBoxFormFactory.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxFormFactory.Name = "CheckBoxFormFactory"
        Me.CheckBoxFormFactory.Size = New System.Drawing.Size(113, 21)
        Me.CheckBoxFormFactory.TabIndex = 1
        Me.CheckBoxFormFactory.Text = "Form Factory"
        Me.CheckBoxFormFactory.UseVisualStyleBackColor = True
        '
        'CheckBoxArchimAid
        '
        Me.CheckBoxArchimAid.AutoSize = True
        Me.CheckBoxArchimAid.Location = New System.Drawing.Point(20, 96)
        Me.CheckBoxArchimAid.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxArchimAid.Name = "CheckBoxArchimAid"
        Me.CheckBoxArchimAid.Size = New System.Drawing.Size(95, 21)
        Me.CheckBoxArchimAid.TabIndex = 2
        Me.CheckBoxArchimAid.Text = "ArchimAID"
        Me.CheckBoxArchimAid.UseVisualStyleBackColor = True
        '
        'TabPageSystem
        '
        Me.TabPageSystem.Controls.Add(Me.DataGridViewSettings)
        Me.TabPageSystem.Location = New System.Drawing.Point(4, 25)
        Me.TabPageSystem.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPageSystem.Name = "TabPageSystem"
        Me.TabPageSystem.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPageSystem.Size = New System.Drawing.Size(819, 508)
        Me.TabPageSystem.TabIndex = 0
        Me.TabPageSystem.Text = "System"
        Me.TabPageSystem.UseVisualStyleBackColor = True
        '
        'TabPageStatements
        '
        Me.TabPageStatements.Controls.Add(Me.DataGridViewStatement)
        Me.TabPageStatements.Location = New System.Drawing.Point(4, 25)
        Me.TabPageStatements.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPageStatements.Name = "TabPageStatements"
        Me.TabPageStatements.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPageStatements.Size = New System.Drawing.Size(819, 508)
        Me.TabPageStatements.TabIndex = 2
        Me.TabPageStatements.Text = "Statements"
        Me.TabPageStatements.UseVisualStyleBackColor = True
        '
        'DataGridViewStatement
        '
        Me.DataGridViewStatement.AllowUserToOrderColumns = True
        Me.DataGridViewStatement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewStatement.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewStatement.Location = New System.Drawing.Point(4, 4)
        Me.DataGridViewStatement.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridViewStatement.Name = "DataGridViewStatement"
        Me.DataGridViewStatement.RowHeadersWidth = 51
        Me.DataGridViewStatement.RowTemplate.Height = 24
        Me.DataGridViewStatement.Size = New System.Drawing.Size(811, 500)
        Me.DataGridViewStatement.TabIndex = 1
        '
        'FrmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 537)
        Me.Controls.Add(Me.TabControlSettings)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmSettings"
        Me.Text = "IDEA Settings"
        CType(Me.DataGridViewSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlSettings.ResumeLayout(False)
        Me.TabPageUser.ResumeLayout(False)
        Me.TabPageUser.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPageSystem.ResumeLayout(False)
        Me.TabPageStatements.ResumeLayout(False)
        CType(Me.DataGridViewStatement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewSettings As System.Windows.Forms.DataGridView
    Friend WithEvents TabControlSettings As System.Windows.Forms.TabControl
    Friend WithEvents TabPageSystem As System.Windows.Forms.TabPage
    Friend WithEvents TabPageUser As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBoxAssistant As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxDeduplicator As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxDatAid As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxFormFactory As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxArchimAid As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBoxArchiMateHelper As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxPackageHelper As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxTableHelper As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxDiagramHelper As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxClassHelper As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxXSDHelper As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxShowAidOnDiagramOpen As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TabPageStatements As System.Windows.Forms.TabPage
    Friend WithEvents DataGridViewStatement As System.Windows.Forms.DataGridView
    Friend WithEvents CheckBoxDocumentImport As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxSolutionWizard As System.Windows.Forms.CheckBox
End Class
