<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIDEAPackage
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
        Me.DataGridViewSearchReplace = New System.Windows.Forms.DataGridView()
        Me.ButtonSort = New System.Windows.Forms.Button()
        Me.CheckBoxRecursive = New System.Windows.Forms.CheckBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.RadioButtonStereotype = New System.Windows.Forms.RadioButton()
        Me.RadioButtonName = New System.Windows.Forms.RadioButton()
        Me.RadioButtonAlias = New System.Windows.Forms.RadioButton()
        Me.ButtonRemoveNesting = New System.Windows.Forms.Button()
        Me.CheckBoxReplaceName = New System.Windows.Forms.CheckBox()
        Me.CheckBoxReplaceAlias = New System.Windows.Forms.CheckBox()
        Me.CheckBoxReplaceNotes = New System.Windows.Forms.CheckBox()
        Me.ButtonSearchReplace = New System.Windows.Forms.Button()
        Me.LabelPackage = New System.Windows.Forms.Label()
        CType(Me.DataGridViewSearchReplace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewSearchReplace
        '
        Me.DataGridViewSearchReplace.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewSearchReplace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSearchReplace.Location = New System.Drawing.Point(235, 26)
        Me.DataGridViewSearchReplace.Name = "DataGridViewSearchReplace"
        Me.DataGridViewSearchReplace.Size = New System.Drawing.Size(282, 179)
        Me.DataGridViewSearchReplace.TabIndex = 0
        '
        'ButtonSort
        '
        Me.ButtonSort.Location = New System.Drawing.Point(34, 207)
        Me.ButtonSort.Name = "ButtonSort"
        Me.ButtonSort.Size = New System.Drawing.Size(177, 23)
        Me.ButtonSort.TabIndex = 1
        Me.ButtonSort.Text = "Sort Package"
        Me.ButtonSort.UseVisualStyleBackColor = True
        '
        'CheckBoxRecursive
        '
        Me.CheckBoxRecursive.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxRecursive.AutoSize = True
        Me.CheckBoxRecursive.Checked = True
        Me.CheckBoxRecursive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxRecursive.Location = New System.Drawing.Point(34, 303)
        Me.CheckBoxRecursive.Name = "CheckBoxRecursive"
        Me.CheckBoxRecursive.Size = New System.Drawing.Size(74, 17)
        Me.CheckBoxRecursive.TabIndex = 2
        Me.CheckBoxRecursive.Text = "Recursive"
        Me.CheckBoxRecursive.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(-2, 340)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(531, 23)
        Me.ProgressBar1.TabIndex = 3
        '
        'RadioButtonStereotype
        '
        Me.RadioButtonStereotype.AutoSize = True
        Me.RadioButtonStereotype.Checked = True
        Me.RadioButtonStereotype.Location = New System.Drawing.Point(34, 53)
        Me.RadioButtonStereotype.Name = "RadioButtonStereotype"
        Me.RadioButtonStereotype.Size = New System.Drawing.Size(126, 17)
        Me.RadioButtonStereotype.TabIndex = 4
        Me.RadioButtonStereotype.TabStop = True
        Me.RadioButtonStereotype.Text = "Stereotype and name"
        Me.RadioButtonStereotype.UseVisualStyleBackColor = True
        '
        'RadioButtonName
        '
        Me.RadioButtonName.AutoSize = True
        Me.RadioButtonName.Location = New System.Drawing.Point(34, 87)
        Me.RadioButtonName.Name = "RadioButtonName"
        Me.RadioButtonName.Size = New System.Drawing.Size(51, 17)
        Me.RadioButtonName.TabIndex = 5
        Me.RadioButtonName.Text = "name"
        Me.RadioButtonName.UseVisualStyleBackColor = True
        '
        'RadioButtonAlias
        '
        Me.RadioButtonAlias.AutoSize = True
        Me.RadioButtonAlias.Location = New System.Drawing.Point(34, 125)
        Me.RadioButtonAlias.Name = "RadioButtonAlias"
        Me.RadioButtonAlias.Size = New System.Drawing.Size(47, 17)
        Me.RadioButtonAlias.TabIndex = 6
        Me.RadioButtonAlias.Text = "Alias"
        Me.RadioButtonAlias.UseVisualStyleBackColor = True
        '
        'ButtonRemoveNesting
        '
        Me.ButtonRemoveNesting.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonRemoveNesting.Location = New System.Drawing.Point(34, 252)
        Me.ButtonRemoveNesting.Name = "ButtonRemoveNesting"
        Me.ButtonRemoveNesting.Size = New System.Drawing.Size(177, 23)
        Me.ButtonRemoveNesting.TabIndex = 7
        Me.ButtonRemoveNesting.Text = "Remove Nesting"
        Me.ButtonRemoveNesting.UseVisualStyleBackColor = True
        '
        'CheckBoxReplaceName
        '
        Me.CheckBoxReplaceName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxReplaceName.AutoSize = True
        Me.CheckBoxReplaceName.Checked = True
        Me.CheckBoxReplaceName.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxReplaceName.Location = New System.Drawing.Point(235, 211)
        Me.CheckBoxReplaceName.Name = "CheckBoxReplaceName"
        Me.CheckBoxReplaceName.Size = New System.Drawing.Size(54, 17)
        Me.CheckBoxReplaceName.TabIndex = 8
        Me.CheckBoxReplaceName.Text = "Name"
        Me.CheckBoxReplaceName.UseVisualStyleBackColor = True
        '
        'CheckBoxReplaceAlias
        '
        Me.CheckBoxReplaceAlias.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxReplaceAlias.AutoSize = True
        Me.CheckBoxReplaceAlias.Checked = True
        Me.CheckBoxReplaceAlias.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxReplaceAlias.Location = New System.Drawing.Point(348, 211)
        Me.CheckBoxReplaceAlias.Name = "CheckBoxReplaceAlias"
        Me.CheckBoxReplaceAlias.Size = New System.Drawing.Size(48, 17)
        Me.CheckBoxReplaceAlias.TabIndex = 9
        Me.CheckBoxReplaceAlias.Text = "Alias"
        Me.CheckBoxReplaceAlias.UseVisualStyleBackColor = True
        '
        'CheckBoxReplaceNotes
        '
        Me.CheckBoxReplaceNotes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxReplaceNotes.AutoSize = True
        Me.CheckBoxReplaceNotes.Checked = True
        Me.CheckBoxReplaceNotes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxReplaceNotes.Location = New System.Drawing.Point(456, 211)
        Me.CheckBoxReplaceNotes.Name = "CheckBoxReplaceNotes"
        Me.CheckBoxReplaceNotes.Size = New System.Drawing.Size(54, 17)
        Me.CheckBoxReplaceNotes.TabIndex = 10
        Me.CheckBoxReplaceNotes.Text = "Notes"
        Me.CheckBoxReplaceNotes.UseVisualStyleBackColor = True
        '
        'ButtonSearchReplace
        '
        Me.ButtonSearchReplace.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSearchReplace.Location = New System.Drawing.Point(270, 252)
        Me.ButtonSearchReplace.Name = "ButtonSearchReplace"
        Me.ButtonSearchReplace.Size = New System.Drawing.Size(240, 23)
        Me.ButtonSearchReplace.TabIndex = 11
        Me.ButtonSearchReplace.Text = "Search and replace"
        Me.ButtonSearchReplace.UseVisualStyleBackColor = True
        '
        'LabelPackage
        '
        Me.LabelPackage.AutoSize = True
        Me.LabelPackage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPackage.Location = New System.Drawing.Point(35, 10)
        Me.LabelPackage.Name = "LabelPackage"
        Me.LabelPackage.Size = New System.Drawing.Size(18, 16)
        Me.LabelPackage.TabIndex = 12
        Me.LabelPackage.Text = "--"
        '
        'FrmIDEAPackage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 362)
        Me.Controls.Add(Me.LabelPackage)
        Me.Controls.Add(Me.ButtonSearchReplace)
        Me.Controls.Add(Me.CheckBoxReplaceNotes)
        Me.Controls.Add(Me.CheckBoxReplaceAlias)
        Me.Controls.Add(Me.CheckBoxReplaceName)
        Me.Controls.Add(Me.ButtonRemoveNesting)
        Me.Controls.Add(Me.RadioButtonAlias)
        Me.Controls.Add(Me.RadioButtonName)
        Me.Controls.Add(Me.RadioButtonStereotype)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.CheckBoxRecursive)
        Me.Controls.Add(Me.ButtonSort)
        Me.Controls.Add(Me.DataGridViewSearchReplace)
        Me.Name = "FrmIDEAPackage"
        Me.Text = "Package Helper"
        CType(Me.DataGridViewSearchReplace, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewSearchReplace As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonSort As System.Windows.Forms.Button
    Friend WithEvents CheckBoxRecursive As System.Windows.Forms.CheckBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents RadioButtonStereotype As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonName As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonAlias As System.Windows.Forms.RadioButton
    Friend WithEvents ButtonRemoveNesting As System.Windows.Forms.Button
    Friend WithEvents CheckBoxReplaceName As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxReplaceAlias As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxReplaceNotes As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonSearchReplace As System.Windows.Forms.Button
    Friend WithEvents LabelPackage As System.Windows.Forms.Label
End Class
