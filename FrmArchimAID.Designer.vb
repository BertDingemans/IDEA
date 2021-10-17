''' <summary>
''' Form for ArchiMate modeling that combines searching and a toolbox to prevent
''' creating duplicates See also the <a href="$diagram://{0B41C36A-B116-4ff7-BABF-
''' 3EF374CBBB16}"><font color="#0000ff"><u>screen description</u></font></a>. This
''' is the definition part generated by the Visual Studio screen painter
''' </summary>
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FrmArchimAID
	Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabArchiMAID = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ButtonImplementation = New System.Windows.Forms.Button()
        Me.ButtonMotivation = New System.Windows.Forms.Button()
        Me.ButtonTechnologyStructure = New System.Windows.Forms.Button()
        Me.ButtonTechnologyBehaviour = New System.Windows.Forms.Button()
        Me.ButtonTechnologyPassive = New System.Windows.Forms.Button()
        Me.ButtonTechnology = New System.Windows.Forms.Button()
        Me.ButtonApplicationStructure = New System.Windows.Forms.Button()
        Me.ButtonApplicationBehaviour = New System.Windows.Forms.Button()
        Me.ButtonApplicationPassive = New System.Windows.Forms.Button()
        Me.ButtonBusinessStructure = New System.Windows.Forms.Button()
        Me.ButtonBusinessBehaviour = New System.Windows.Forms.Button()
        Me.ButtonBusinessPassive = New System.Windows.Forms.Button()
        Me.ButtonApplication = New System.Windows.Forms.Button()
        Me.ButtonBusinessLayer = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ButtonViewBrowser = New System.Windows.Forms.Button()
        Me.ListBoxConcepts = New System.Windows.Forms.ListBox()
        Me.GridviewElements = New System.Windows.Forms.DataGridView()
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.ButtonAddElement = New System.Windows.Forms.Button()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ComboBoxConcept = New System.Windows.Forms.ComboBox()
        Me.ButtonCreateOnDiagram = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxNotes = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.LabelConcept = New System.Windows.Forms.Label()
        Me.TabArchiMAID.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.GridviewElements, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabArchiMAID
        '
        Me.TabArchiMAID.Controls.Add(Me.TabPage1)
        Me.TabArchiMAID.Controls.Add(Me.TabPage2)
        Me.TabArchiMAID.Controls.Add(Me.TabPage3)
        Me.TabArchiMAID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabArchiMAID.Location = New System.Drawing.Point(0, 0)
        Me.TabArchiMAID.Margin = New System.Windows.Forms.Padding(2)
        Me.TabArchiMAID.Multiline = True
        Me.TabArchiMAID.Name = "TabArchiMAID"
        Me.TabArchiMAID.SelectedIndex = 0
        Me.TabArchiMAID.Size = New System.Drawing.Size(292, 421)
        Me.TabArchiMAID.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.LightGray
        Me.TabPage1.Controls.Add(Me.ButtonImplementation)
        Me.TabPage1.Controls.Add(Me.ButtonMotivation)
        Me.TabPage1.Controls.Add(Me.ButtonTechnologyStructure)
        Me.TabPage1.Controls.Add(Me.ButtonTechnologyBehaviour)
        Me.TabPage1.Controls.Add(Me.ButtonTechnologyPassive)
        Me.TabPage1.Controls.Add(Me.ButtonTechnology)
        Me.TabPage1.Controls.Add(Me.ButtonApplicationStructure)
        Me.TabPage1.Controls.Add(Me.ButtonApplicationBehaviour)
        Me.TabPage1.Controls.Add(Me.ButtonApplicationPassive)
        Me.TabPage1.Controls.Add(Me.ButtonBusinessStructure)
        Me.TabPage1.Controls.Add(Me.ButtonBusinessBehaviour)
        Me.TabPage1.Controls.Add(Me.ButtonBusinessPassive)
        Me.TabPage1.Controls.Add(Me.ButtonApplication)
        Me.TabPage1.Controls.Add(Me.ButtonBusinessLayer)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(284, 395)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ArchiMate"
        '
        'ButtonImplementation
        '
        Me.ButtonImplementation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonImplementation.BackColor = System.Drawing.Color.LightPink
        Me.ButtonImplementation.Location = New System.Drawing.Point(6, 346)
        Me.ButtonImplementation.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonImplementation.Name = "ButtonImplementation"
        Me.ButtonImplementation.Size = New System.Drawing.Size(267, 45)
        Me.ButtonImplementation.TabIndex = 13
        Me.ButtonImplementation.Text = "Implementation"
        Me.ButtonImplementation.UseVisualStyleBackColor = False
        '
        'ButtonMotivation
        '
        Me.ButtonMotivation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonMotivation.BackColor = System.Drawing.Color.Violet
        Me.ButtonMotivation.Location = New System.Drawing.Point(6, 298)
        Me.ButtonMotivation.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonMotivation.Name = "ButtonMotivation"
        Me.ButtonMotivation.Size = New System.Drawing.Size(267, 45)
        Me.ButtonMotivation.TabIndex = 12
        Me.ButtonMotivation.Text = "Motivation"
        Me.ButtonMotivation.UseVisualStyleBackColor = False
        '
        'ButtonTechnologyStructure
        '
        Me.ButtonTechnologyStructure.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonTechnologyStructure.BackColor = System.Drawing.Color.PaleGreen
        Me.ButtonTechnologyStructure.Location = New System.Drawing.Point(204, 250)
        Me.ButtonTechnologyStructure.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonTechnologyStructure.Name = "ButtonTechnologyStructure"
        Me.ButtonTechnologyStructure.Size = New System.Drawing.Size(69, 45)
        Me.ButtonTechnologyStructure.TabIndex = 11
        Me.ButtonTechnologyStructure.Text = "Techn. Structure"
        Me.ButtonTechnologyStructure.UseVisualStyleBackColor = False
        '
        'ButtonTechnologyBehaviour
        '
        Me.ButtonTechnologyBehaviour.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ButtonTechnologyBehaviour.BackColor = System.Drawing.Color.PaleGreen
        Me.ButtonTechnologyBehaviour.Location = New System.Drawing.Point(104, 250)
        Me.ButtonTechnologyBehaviour.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonTechnologyBehaviour.Name = "ButtonTechnologyBehaviour"
        Me.ButtonTechnologyBehaviour.Size = New System.Drawing.Size(69, 45)
        Me.ButtonTechnologyBehaviour.TabIndex = 10
        Me.ButtonTechnologyBehaviour.Text = "Techn. Behaviour"
        Me.ButtonTechnologyBehaviour.UseVisualStyleBackColor = False
        '
        'ButtonTechnologyPassive
        '
        Me.ButtonTechnologyPassive.BackColor = System.Drawing.Color.PaleGreen
        Me.ButtonTechnologyPassive.Location = New System.Drawing.Point(6, 250)
        Me.ButtonTechnologyPassive.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonTechnologyPassive.Name = "ButtonTechnologyPassive"
        Me.ButtonTechnologyPassive.Size = New System.Drawing.Size(69, 45)
        Me.ButtonTechnologyPassive.TabIndex = 9
        Me.ButtonTechnologyPassive.Text = "Techn. Passive"
        Me.ButtonTechnologyPassive.UseVisualStyleBackColor = False
        '
        'ButtonTechnology
        '
        Me.ButtonTechnology.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonTechnology.BackColor = System.Drawing.Color.PaleGreen
        Me.ButtonTechnology.Location = New System.Drawing.Point(6, 202)
        Me.ButtonTechnology.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonTechnology.Name = "ButtonTechnology"
        Me.ButtonTechnology.Size = New System.Drawing.Size(267, 45)
        Me.ButtonTechnology.TabIndex = 8
        Me.ButtonTechnology.Text = "Technology Layer"
        Me.ButtonTechnology.UseVisualStyleBackColor = False
        '
        'ButtonApplicationStructure
        '
        Me.ButtonApplicationStructure.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonApplicationStructure.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ButtonApplicationStructure.Location = New System.Drawing.Point(204, 154)
        Me.ButtonApplicationStructure.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonApplicationStructure.Name = "ButtonApplicationStructure"
        Me.ButtonApplicationStructure.Size = New System.Drawing.Size(69, 45)
        Me.ButtonApplicationStructure.TabIndex = 7
        Me.ButtonApplicationStructure.Text = "Application Structure"
        Me.ButtonApplicationStructure.UseVisualStyleBackColor = False
        '
        'ButtonApplicationBehaviour
        '
        Me.ButtonApplicationBehaviour.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ButtonApplicationBehaviour.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ButtonApplicationBehaviour.Location = New System.Drawing.Point(104, 154)
        Me.ButtonApplicationBehaviour.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonApplicationBehaviour.Name = "ButtonApplicationBehaviour"
        Me.ButtonApplicationBehaviour.Size = New System.Drawing.Size(69, 45)
        Me.ButtonApplicationBehaviour.TabIndex = 6
        Me.ButtonApplicationBehaviour.Text = "Application Behaviour"
        Me.ButtonApplicationBehaviour.UseVisualStyleBackColor = False
        '
        'ButtonApplicationPassive
        '
        Me.ButtonApplicationPassive.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ButtonApplicationPassive.Location = New System.Drawing.Point(6, 154)
        Me.ButtonApplicationPassive.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonApplicationPassive.Name = "ButtonApplicationPassive"
        Me.ButtonApplicationPassive.Size = New System.Drawing.Size(69, 45)
        Me.ButtonApplicationPassive.TabIndex = 5
        Me.ButtonApplicationPassive.Text = "Application Passive"
        Me.ButtonApplicationPassive.UseVisualStyleBackColor = False
        '
        'ButtonBusinessStructure
        '
        Me.ButtonBusinessStructure.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonBusinessStructure.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ButtonBusinessStructure.Location = New System.Drawing.Point(204, 58)
        Me.ButtonBusinessStructure.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonBusinessStructure.Name = "ButtonBusinessStructure"
        Me.ButtonBusinessStructure.Size = New System.Drawing.Size(69, 45)
        Me.ButtonBusinessStructure.TabIndex = 4
        Me.ButtonBusinessStructure.Text = "Business Structure"
        Me.ButtonBusinessStructure.UseVisualStyleBackColor = False
        '
        'ButtonBusinessBehaviour
        '
        Me.ButtonBusinessBehaviour.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ButtonBusinessBehaviour.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ButtonBusinessBehaviour.Location = New System.Drawing.Point(104, 58)
        Me.ButtonBusinessBehaviour.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonBusinessBehaviour.Name = "ButtonBusinessBehaviour"
        Me.ButtonBusinessBehaviour.Size = New System.Drawing.Size(69, 45)
        Me.ButtonBusinessBehaviour.TabIndex = 3
        Me.ButtonBusinessBehaviour.Text = "Business Behaviour"
        Me.ButtonBusinessBehaviour.UseVisualStyleBackColor = False
        '
        'ButtonBusinessPassive
        '
        Me.ButtonBusinessPassive.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ButtonBusinessPassive.Location = New System.Drawing.Point(6, 58)
        Me.ButtonBusinessPassive.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonBusinessPassive.Name = "ButtonBusinessPassive"
        Me.ButtonBusinessPassive.Size = New System.Drawing.Size(69, 45)
        Me.ButtonBusinessPassive.TabIndex = 2
        Me.ButtonBusinessPassive.Text = "Business Passive"
        Me.ButtonBusinessPassive.UseVisualStyleBackColor = False
        '
        'ButtonApplication
        '
        Me.ButtonApplication.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonApplication.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ButtonApplication.Location = New System.Drawing.Point(6, 106)
        Me.ButtonApplication.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonApplication.Name = "ButtonApplication"
        Me.ButtonApplication.Size = New System.Drawing.Size(267, 45)
        Me.ButtonApplication.TabIndex = 1
        Me.ButtonApplication.Text = "Application Layer"
        Me.ButtonApplication.UseVisualStyleBackColor = False
        '
        'ButtonBusinessLayer
        '
        Me.ButtonBusinessLayer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonBusinessLayer.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ButtonBusinessLayer.Location = New System.Drawing.Point(6, 11)
        Me.ButtonBusinessLayer.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonBusinessLayer.Name = "ButtonBusinessLayer"
        Me.ButtonBusinessLayer.Size = New System.Drawing.Size(267, 45)
        Me.ButtonBusinessLayer.TabIndex = 0
        Me.ButtonBusinessLayer.Text = "Business Layer"
        Me.ButtonBusinessLayer.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.LightGray
        Me.TabPage2.Controls.Add(Me.ButtonViewBrowser)
        Me.TabPage2.Controls.Add(Me.ListBoxConcepts)
        Me.TabPage2.Controls.Add(Me.GridviewElements)
        Me.TabPage2.Controls.Add(Me.ButtonSearch)
        Me.TabPage2.Controls.Add(Me.ButtonAddElement)
        Me.TabPage2.Controls.Add(Me.TextBoxSearch)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(284, 395)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Select Concepts"
        '
        'ButtonViewBrowser
        '
        Me.ButtonViewBrowser.Location = New System.Drawing.Point(4, 133)
        Me.ButtonViewBrowser.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonViewBrowser.Name = "ButtonViewBrowser"
        Me.ButtonViewBrowser.Size = New System.Drawing.Size(133, 23)
        Me.ButtonViewBrowser.TabIndex = 10
        Me.ButtonViewBrowser.Text = "View in Browser"
        Me.ButtonViewBrowser.UseVisualStyleBackColor = True
        '
        'ListBoxConcepts
        '
        Me.ListBoxConcepts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBoxConcepts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxConcepts.FormattingEnabled = True
        Me.ListBoxConcepts.ItemHeight = 16
        Me.ListBoxConcepts.Location = New System.Drawing.Point(0, 0)
        Me.ListBoxConcepts.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBoxConcepts.Name = "ListBoxConcepts"
        Me.ListBoxConcepts.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBoxConcepts.Size = New System.Drawing.Size(290, 100)
        Me.ListBoxConcepts.TabIndex = 9
        '
        'GridviewElements
        '
        Me.GridviewElements.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridviewElements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridviewElements.Location = New System.Drawing.Point(-3, 160)
        Me.GridviewElements.Margin = New System.Windows.Forms.Padding(2)
        Me.GridviewElements.Name = "GridviewElements"
        Me.GridviewElements.RowHeadersWidth = 70
        Me.GridviewElements.RowTemplate.Height = 24
        Me.GridviewElements.RowTemplate.ReadOnly = True
        Me.GridviewElements.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridviewElements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridviewElements.Size = New System.Drawing.Size(290, 236)
        Me.GridviewElements.TabIndex = 8
        '
        'ButtonSearch
        '
        Me.ButtonSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSearch.Location = New System.Drawing.Point(220, 109)
        Me.ButtonSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(64, 23)
        Me.ButtonSearch.TabIndex = 5
        Me.ButtonSearch.Text = "Search"
        Me.ButtonSearch.UseVisualStyleBackColor = True
        '
        'ButtonAddElement
        '
        Me.ButtonAddElement.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonAddElement.Location = New System.Drawing.Point(154, 133)
        Me.ButtonAddElement.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonAddElement.Name = "ButtonAddElement"
        Me.ButtonAddElement.Size = New System.Drawing.Size(129, 23)
        Me.ButtonAddElement.TabIndex = 7
        Me.ButtonAddElement.Text = "Add 2 Diagram"
        Me.ButtonAddElement.UseVisualStyleBackColor = True
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSearch.BackColor = System.Drawing.SystemColors.Info
        Me.TextBoxSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSearch.Location = New System.Drawing.Point(0, 103)
        Me.TextBoxSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(214, 26)
        Me.TextBoxSearch.TabIndex = 6
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.LightGray
        Me.TabPage3.Controls.Add(Me.ComboBoxConcept)
        Me.TabPage3.Controls.Add(Me.ButtonCreateOnDiagram)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.TextBoxNotes)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.TextBoxName)
        Me.TabPage3.Controls.Add(Me.LabelConcept)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Size = New System.Drawing.Size(284, 395)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Concept creation"
        '
        'ComboBoxConcept
        '
        Me.ComboBoxConcept.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxConcept.FormattingEnabled = True
        Me.ComboBoxConcept.Location = New System.Drawing.Point(2, 24)
        Me.ComboBoxConcept.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxConcept.Name = "ComboBoxConcept"
        Me.ComboBoxConcept.Size = New System.Drawing.Size(198, 21)
        Me.ComboBoxConcept.TabIndex = 9
        '
        'ButtonCreateOnDiagram
        '
        Me.ButtonCreateOnDiagram.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonCreateOnDiagram.Location = New System.Drawing.Point(204, 11)
        Me.ButtonCreateOnDiagram.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonCreateOnDiagram.Name = "ButtonCreateOnDiagram"
        Me.ButtonCreateOnDiagram.Size = New System.Drawing.Size(79, 45)
        Me.ButtonCreateOnDiagram.TabIndex = 8
        Me.ButtonCreateOnDiagram.Text = "Create on Diagram"
        Me.ButtonCreateOnDiagram.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 95)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Note"
        '
        'TextBoxNotes
        '
        Me.TextBoxNotes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxNotes.Location = New System.Drawing.Point(2, 118)
        Me.TextBoxNotes.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxNotes.Multiline = True
        Me.TextBoxNotes.Name = "TextBoxNotes"
        Me.TextBoxNotes.Size = New System.Drawing.Size(282, 280)
        Me.TextBoxNotes.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 50)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name"
        '
        'TextBoxName
        '
        Me.TextBoxName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxName.Location = New System.Drawing.Point(2, 71)
        Me.TextBoxName.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(283, 20)
        Me.TextBoxName.TabIndex = 1
        '
        'LabelConcept
        '
        Me.LabelConcept.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelConcept.AutoSize = True
        Me.LabelConcept.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelConcept.Location = New System.Drawing.Point(2, 2)
        Me.LabelConcept.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelConcept.Name = "LabelConcept"
        Me.LabelConcept.Size = New System.Drawing.Size(60, 17)
        Me.LabelConcept.TabIndex = 0
        Me.LabelConcept.Text = "Concept"
        '
        'FrmArchimAID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(292, 421)
        Me.Controls.Add(Me.TabArchiMAID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmArchimAID"
        Me.Text = "ArchimAID"
        Me.TopMost = True
        Me.TabArchiMAID.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.GridviewElements, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabArchiMAID As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents ButtonMotivation As System.Windows.Forms.Button
    Friend WithEvents ButtonTechnologyStructure As System.Windows.Forms.Button
    Friend WithEvents ButtonTechnologyBehaviour As System.Windows.Forms.Button
    Friend WithEvents ButtonTechnologyPassive As System.Windows.Forms.Button
    Friend WithEvents ButtonTechnology As System.Windows.Forms.Button
    Friend WithEvents ButtonApplicationStructure As System.Windows.Forms.Button
    Friend WithEvents ButtonApplicationBehaviour As System.Windows.Forms.Button
    Friend WithEvents ButtonApplicationPassive As System.Windows.Forms.Button
    Friend WithEvents ButtonBusinessStructure As System.Windows.Forms.Button
    Friend WithEvents ButtonBusinessBehaviour As System.Windows.Forms.Button
    Friend WithEvents ButtonBusinessPassive As System.Windows.Forms.Button
    Friend WithEvents ButtonApplication As System.Windows.Forms.Button
    Friend WithEvents ButtonBusinessLayer As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ButtonImplementation As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents ButtonSearch As System.Windows.Forms.Button
    Friend WithEvents ButtonAddElement As System.Windows.Forms.Button
    Friend WithEvents TextBoxSearch As System.Windows.Forms.TextBox
    Friend WithEvents GridviewElements As System.Windows.Forms.DataGridView
    Friend WithEvents ListBoxConcepts As System.Windows.Forms.ListBox
    Friend WithEvents ButtonCreateOnDiagram As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxNotes As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxName As System.Windows.Forms.TextBox
    Friend WithEvents LabelConcept As System.Windows.Forms.Label
    Friend WithEvents ComboBoxConcept As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonViewBrowser As System.Windows.Forms.Button
End Class