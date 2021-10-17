<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmArchitectureWizard
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageTemplate = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxNotes = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxProject = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxInfo = New System.Windows.Forms.TextBox()
        Me.ComboBoxWorkPackage = New System.Windows.Forms.ComboBox()
        Me.ComboBoxTemplatePackage = New System.Windows.Forms.ComboBox()
        Me.TabPageElements = New System.Windows.Forms.TabPage()
        Me.ButtonGenerate = New System.Windows.Forms.Button()
        Me.RadioButtonOther = New System.Windows.Forms.RadioButton()
        Me.RadioButtonInfoProduct = New System.Windows.Forms.RadioButton()
        Me.RadioButtonIBB = New System.Windows.Forms.RadioButton()
        Me.RadioButtonDataObjects = New System.Windows.Forms.RadioButton()
        Me.RadioButtonSourceSystem = New System.Windows.Forms.RadioButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.CheckedListBoxExistingElement = New System.Windows.Forms.CheckedListBox()
        Me.DataGridViewNewElements = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxStereotype = New System.Windows.Forms.ComboBox()
        Me.TextBoxDiagramName = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ButtonPrevious = New System.Windows.Forms.Button()
        Me.ButtonNext = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPageTemplate.SuspendLayout()
        Me.TabPageElements.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridViewNewElements, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPageTemplate)
        Me.TabControl1.Controls.Add(Me.TabPageElements)
        Me.TabControl1.Location = New System.Drawing.Point(0, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(474, 529)
        Me.TabControl1.TabIndex = 0
        '
        'TabPageTemplate
        '
        Me.TabPageTemplate.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageTemplate.Controls.Add(Me.Label4)
        Me.TabPageTemplate.Controls.Add(Me.TextBoxNotes)
        Me.TabPageTemplate.Controls.Add(Me.Label3)
        Me.TabPageTemplate.Controls.Add(Me.TextBoxProject)
        Me.TabPageTemplate.Controls.Add(Me.Label2)
        Me.TabPageTemplate.Controls.Add(Me.Label1)
        Me.TabPageTemplate.Controls.Add(Me.TextBoxInfo)
        Me.TabPageTemplate.Controls.Add(Me.ComboBoxWorkPackage)
        Me.TabPageTemplate.Controls.Add(Me.ComboBoxTemplatePackage)
        Me.TabPageTemplate.Location = New System.Drawing.Point(4, 22)
        Me.TabPageTemplate.Name = "TabPageTemplate"
        Me.TabPageTemplate.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageTemplate.Size = New System.Drawing.Size(466, 503)
        Me.TabPageTemplate.TabIndex = 0
        Me.TabPageTemplate.Text = "Select template and target package"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 245)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Solution Description"
        '
        'TextBoxNotes
        '
        Me.TextBoxNotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxNotes.Location = New System.Drawing.Point(3, 271)
        Me.TextBoxNotes.Multiline = True
        Me.TextBoxNotes.Name = "TextBoxNotes"
        Me.TextBoxNotes.Size = New System.Drawing.Size(463, 226)
        Me.TextBoxNotes.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Solution Name"
        '
        'TextBoxProject
        '
        Me.TextBoxProject.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxProject.Location = New System.Drawing.Point(3, 208)
        Me.TextBoxProject.Name = "TextBoxProject"
        Me.TextBoxProject.Size = New System.Drawing.Size(463, 20)
        Me.TextBoxProject.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Select the working package"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select the template package"
        '
        'TextBoxInfo
        '
        Me.TextBoxInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxInfo.BackColor = System.Drawing.SystemColors.Info
        Me.TextBoxInfo.Location = New System.Drawing.Point(2, 0)
        Me.TextBoxInfo.Multiline = True
        Me.TextBoxInfo.Name = "TextBoxInfo"
        Me.TextBoxInfo.ReadOnly = True
        Me.TextBoxInfo.Size = New System.Drawing.Size(464, 60)
        Me.TextBoxInfo.TabIndex = 2
        Me.TextBoxInfo.Text = "In this wizard you can create a new solution architecture structure based on a te" &
    "mplate. After creating the solution package you can define extra elements for fi" &
    "lling your solution. "
        Me.TextBoxInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ComboBoxWorkPackage
        '
        Me.ComboBoxWorkPackage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxWorkPackage.FormattingEnabled = True
        Me.ComboBoxWorkPackage.Location = New System.Drawing.Point(3, 158)
        Me.ComboBoxWorkPackage.Name = "ComboBoxWorkPackage"
        Me.ComboBoxWorkPackage.Size = New System.Drawing.Size(463, 21)
        Me.ComboBoxWorkPackage.TabIndex = 1
        '
        'ComboBoxTemplatePackage
        '
        Me.ComboBoxTemplatePackage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxTemplatePackage.FormattingEnabled = True
        Me.ComboBoxTemplatePackage.Location = New System.Drawing.Point(3, 107)
        Me.ComboBoxTemplatePackage.Name = "ComboBoxTemplatePackage"
        Me.ComboBoxTemplatePackage.Size = New System.Drawing.Size(463, 21)
        Me.ComboBoxTemplatePackage.TabIndex = 0
        '
        'TabPageElements
        '
        Me.TabPageElements.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageElements.Controls.Add(Me.ButtonGenerate)
        Me.TabPageElements.Controls.Add(Me.RadioButtonOther)
        Me.TabPageElements.Controls.Add(Me.RadioButtonInfoProduct)
        Me.TabPageElements.Controls.Add(Me.RadioButtonIBB)
        Me.TabPageElements.Controls.Add(Me.RadioButtonDataObjects)
        Me.TabPageElements.Controls.Add(Me.RadioButtonSourceSystem)
        Me.TabPageElements.Controls.Add(Me.SplitContainer1)
        Me.TabPageElements.Controls.Add(Me.Label7)
        Me.TabPageElements.Controls.Add(Me.Label6)
        Me.TabPageElements.Controls.Add(Me.Label5)
        Me.TabPageElements.Controls.Add(Me.ComboBoxStereotype)
        Me.TabPageElements.Controls.Add(Me.TextBoxDiagramName)
        Me.TabPageElements.Controls.Add(Me.TextBox1)
        Me.TabPageElements.Location = New System.Drawing.Point(4, 22)
        Me.TabPageElements.Name = "TabPageElements"
        Me.TabPageElements.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageElements.Size = New System.Drawing.Size(466, 503)
        Me.TabPageElements.TabIndex = 1
        Me.TabPageElements.Text = "Select Elements"
        '
        'ButtonGenerate
        '
        Me.ButtonGenerate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonGenerate.Location = New System.Drawing.Point(242, 477)
        Me.ButtonGenerate.Name = "ButtonGenerate"
        Me.ButtonGenerate.Size = New System.Drawing.Size(216, 23)
        Me.ButtonGenerate.TabIndex = 15
        Me.ButtonGenerate.Text = "Generate concepts"
        Me.ButtonGenerate.UseVisualStyleBackColor = True
        '
        'RadioButtonOther
        '
        Me.RadioButtonOther.AutoSize = True
        Me.RadioButtonOther.Location = New System.Drawing.Point(359, 76)
        Me.RadioButtonOther.Name = "RadioButtonOther"
        Me.RadioButtonOther.Size = New System.Drawing.Size(51, 17)
        Me.RadioButtonOther.TabIndex = 14
        Me.RadioButtonOther.TabStop = True
        Me.RadioButtonOther.Text = "Other"
        Me.RadioButtonOther.UseVisualStyleBackColor = True
        '
        'RadioButtonInfoProduct
        '
        Me.RadioButtonInfoProduct.AutoSize = True
        Me.RadioButtonInfoProduct.Location = New System.Drawing.Point(271, 76)
        Me.RadioButtonInfoProduct.Name = "RadioButtonInfoProduct"
        Me.RadioButtonInfoProduct.Size = New System.Drawing.Size(82, 17)
        Me.RadioButtonInfoProduct.TabIndex = 13
        Me.RadioButtonInfoProduct.TabStop = True
        Me.RadioButtonInfoProduct.Text = "Info product"
        Me.RadioButtonInfoProduct.UseVisualStyleBackColor = True
        '
        'RadioButtonIBB
        '
        Me.RadioButtonIBB.AutoSize = True
        Me.RadioButtonIBB.Location = New System.Drawing.Point(204, 76)
        Me.RadioButtonIBB.Name = "RadioButtonIBB"
        Me.RadioButtonIBB.Size = New System.Drawing.Size(61, 17)
        Me.RadioButtonIBB.TabIndex = 12
        Me.RadioButtonIBB.TabStop = True
        Me.RadioButtonIBB.Text = "Impl BB"
        Me.RadioButtonIBB.UseVisualStyleBackColor = True
        '
        'RadioButtonDataObjects
        '
        Me.RadioButtonDataObjects.AutoSize = True
        Me.RadioButtonDataObjects.Location = New System.Drawing.Point(113, 76)
        Me.RadioButtonDataObjects.Name = "RadioButtonDataObjects"
        Me.RadioButtonDataObjects.Size = New System.Drawing.Size(85, 17)
        Me.RadioButtonDataObjects.TabIndex = 11
        Me.RadioButtonDataObjects.TabStop = True
        Me.RadioButtonDataObjects.Text = "Data objects"
        Me.RadioButtonDataObjects.UseVisualStyleBackColor = True
        '
        'RadioButtonSourceSystem
        '
        Me.RadioButtonSourceSystem.AutoSize = True
        Me.RadioButtonSourceSystem.Location = New System.Drawing.Point(8, 76)
        Me.RadioButtonSourceSystem.Name = "RadioButtonSourceSystem"
        Me.RadioButtonSourceSystem.Size = New System.Drawing.Size(99, 17)
        Me.RadioButtonSourceSystem.TabIndex = 10
        Me.RadioButtonSourceSystem.TabStop = True
        Me.RadioButtonSourceSystem.Text = "Source systems"
        Me.RadioButtonSourceSystem.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 183)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.CheckedListBoxExistingElement)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridViewNewElements)
        Me.SplitContainer1.Size = New System.Drawing.Size(464, 288)
        Me.SplitContainer1.SplitterDistance = 233
        Me.SplitContainer1.TabIndex = 9
        '
        'CheckedListBoxExistingElement
        '
        Me.CheckedListBoxExistingElement.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckedListBoxExistingElement.FormattingEnabled = True
        Me.CheckedListBoxExistingElement.Location = New System.Drawing.Point(0, 0)
        Me.CheckedListBoxExistingElement.Name = "CheckedListBoxExistingElement"
        Me.CheckedListBoxExistingElement.Size = New System.Drawing.Size(233, 288)
        Me.CheckedListBoxExistingElement.TabIndex = 0
        '
        'DataGridViewNewElements
        '
        Me.DataGridViewNewElements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewNewElements.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewNewElements.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewNewElements.Name = "DataGridViewNewElements"
        Me.DataGridViewNewElements.Size = New System.Drawing.Size(227, 288)
        Me.DataGridViewNewElements.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(611, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(178, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Select new elements for the diagram"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(288, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Select existing elements or create new items for the diagram"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Select the stereotype"
        '
        'ComboBoxStereotype
        '
        Me.ComboBoxStereotype.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxStereotype.Enabled = False
        Me.ComboBoxStereotype.FormattingEnabled = True
        Me.ComboBoxStereotype.Location = New System.Drawing.Point(5, 135)
        Me.ComboBoxStereotype.Name = "ComboBoxStereotype"
        Me.ComboBoxStereotype.Size = New System.Drawing.Size(463, 21)
        Me.ComboBoxStereotype.TabIndex = 5
        '
        'TextBoxDiagramName
        '
        Me.TextBoxDiagramName.BackColor = System.Drawing.Color.PeachPuff
        Me.TextBoxDiagramName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxDiagramName.Enabled = False
        Me.TextBoxDiagramName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDiagramName.Location = New System.Drawing.Point(3, 41)
        Me.TextBoxDiagramName.Multiline = True
        Me.TextBoxDiagramName.Name = "TextBoxDiagramName"
        Me.TextBoxDiagramName.ReadOnly = True
        Me.TextBoxDiagramName.Size = New System.Drawing.Size(789, 26)
        Me.TextBoxDiagramName.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox1.Location = New System.Drawing.Point(3, 3)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(464, 32)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "Please select ArchiMate elements from the repository or create new ones for the s" &
    "elected stereotype and add them to the diagram"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonPrevious
        '
        Me.ButtonPrevious.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonPrevious.Enabled = False
        Me.ButtonPrevious.Location = New System.Drawing.Point(288, 536)
        Me.ButtonPrevious.Name = "ButtonPrevious"
        Me.ButtonPrevious.Size = New System.Drawing.Size(84, 31)
        Me.ButtonPrevious.TabIndex = 1
        Me.ButtonPrevious.Text = "Previous"
        Me.ButtonPrevious.UseVisualStyleBackColor = True
        '
        'ButtonNext
        '
        Me.ButtonNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonNext.Location = New System.Drawing.Point(384, 536)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(86, 31)
        Me.ButtonNext.TabIndex = 2
        Me.ButtonNext.Text = "Next"
        Me.ButtonNext.UseVisualStyleBackColor = True
        '
        'FrmArchitectureWizard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 579)
        Me.Controls.Add(Me.ButtonNext)
        Me.Controls.Add(Me.ButtonPrevious)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FrmArchitectureWizard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Architecture Wizard"
        Me.TopMost = True
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageTemplate.ResumeLayout(False)
        Me.TabPageTemplate.PerformLayout()
        Me.TabPageElements.ResumeLayout(False)
        Me.TabPageElements.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridViewNewElements, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPageTemplate As System.Windows.Forms.TabPage
    Friend WithEvents TabPageElements As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxNotes As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxProject As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxInfo As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxWorkPackage As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxTemplatePackage As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonPrevious As System.Windows.Forms.Button
    Friend WithEvents ButtonNext As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDiagramName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxStereotype As System.Windows.Forms.ComboBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents CheckedListBoxExistingElement As System.Windows.Forms.CheckedListBox
    Friend WithEvents DataGridViewNewElements As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents RadioButtonOther As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonInfoProduct As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonIBB As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonDataObjects As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonSourceSystem As System.Windows.Forms.RadioButton
    Friend WithEvents ButtonGenerate As System.Windows.Forms.Button
End Class
