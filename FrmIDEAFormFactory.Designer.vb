<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FrmIDEAFormFactory
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
        Me.TabPageDataSet = New System.Windows.Forms.TabPage()
        Me.CheckBoxCreateDirect = New System.Windows.Forms.CheckBox()
        Me.LabelXMLFile = New System.Windows.Forms.Label()
        Me.LabelDatabaseConnection = New System.Windows.Forms.Label()
        Me.ButtonXMLFile = New System.Windows.Forms.Button()
        Me.ButtonDatabaseConnection = New System.Windows.Forms.Button()
        Me.CheckBoxSaveDataSet = New System.Windows.Forms.CheckBox()
        Me.CheckBoxForeignKeys = New System.Windows.Forms.CheckBox()
        Me.CheckBoxModelTables = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSystemTables = New System.Windows.Forms.CheckBox()
        Me.ButtonInspector = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBoxDiagrams = New System.Windows.Forms.CheckedListBox()
        Me.ButtonSimulator = New System.Windows.Forms.Button()
        Me.CheckBoxClipBoard = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxDatasetCode = New System.Windows.Forms.TextBox()
        Me.ButtonGenerateDataSet = New System.Windows.Forms.Button()
        Me.TabPageFormFactory = New System.Windows.Forms.TabPage()
        Me.CheckBoxCreateMenu = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDeleteMenu = New System.Windows.Forms.CheckBox()
        Me.CheckBoxCreateLookup = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDeleteLookup = New System.Windows.Forms.CheckBox()
        Me.CheckBoxCreateClass = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDeleteClass = New System.Windows.Forms.CheckBox()
        Me.CheckBoxCreateEnumeration = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDeleteEnumeration = New System.Windows.Forms.CheckBox()
        Me.CheckBoxClose = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonGenerate = New System.Windows.Forms.Button()
        Me.ButtonToggleAll = New System.Windows.Forms.Button()
        Me.ButtonSelectAll = New System.Windows.Forms.Button()
        Me.ListBoxElements = New System.Windows.Forms.CheckedListBox()
        Me.ButtonUnselectAll = New System.Windows.Forms.Button()
        Me.ButtonLoad = New System.Windows.Forms.Button()
        Me.ComboBoxPackage = New System.Windows.Forms.ComboBox()
        Me.SaveFileDialogDataSet = New System.Windows.Forms.SaveFileDialog()
        Me.FileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.TabControl1.SuspendLayout()
        Me.TabPageDataSet.SuspendLayout()
        Me.TabPageFormFactory.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPageDataSet)
        Me.TabControl1.Controls.Add(Me.TabPageFormFactory)
        Me.TabControl1.Location = New System.Drawing.Point(2, 32)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(776, 372)
        Me.TabControl1.TabIndex = 0
        '
        'TabPageDataSet
        '
        Me.TabPageDataSet.BackColor = System.Drawing.Color.LightGray
        Me.TabPageDataSet.Controls.Add(Me.CheckBoxCreateDirect)
        Me.TabPageDataSet.Controls.Add(Me.LabelXMLFile)
        Me.TabPageDataSet.Controls.Add(Me.LabelDatabaseConnection)
        Me.TabPageDataSet.Controls.Add(Me.ButtonXMLFile)
        Me.TabPageDataSet.Controls.Add(Me.ButtonDatabaseConnection)
        Me.TabPageDataSet.Controls.Add(Me.CheckBoxSaveDataSet)
        Me.TabPageDataSet.Controls.Add(Me.CheckBoxForeignKeys)
        Me.TabPageDataSet.Controls.Add(Me.CheckBoxModelTables)
        Me.TabPageDataSet.Controls.Add(Me.CheckBoxSystemTables)
        Me.TabPageDataSet.Controls.Add(Me.ButtonInspector)
        Me.TabPageDataSet.Controls.Add(Me.Label2)
        Me.TabPageDataSet.Controls.Add(Me.ListBoxDiagrams)
        Me.TabPageDataSet.Controls.Add(Me.ButtonSimulator)
        Me.TabPageDataSet.Controls.Add(Me.CheckBoxClipBoard)
        Me.TabPageDataSet.Controls.Add(Me.Label7)
        Me.TabPageDataSet.Controls.Add(Me.TextBoxDatasetCode)
        Me.TabPageDataSet.Controls.Add(Me.ButtonGenerateDataSet)
        Me.TabPageDataSet.Location = New System.Drawing.Point(4, 22)
        Me.TabPageDataSet.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPageDataSet.Name = "TabPageDataSet"
        Me.TabPageDataSet.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPageDataSet.Size = New System.Drawing.Size(768, 346)
        Me.TabPageDataSet.TabIndex = 2
        Me.TabPageDataSet.Text = "Dataset/Simulator"
        '
        'CheckBoxCreateDirect
        '
        Me.CheckBoxCreateDirect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxCreateDirect.AutoSize = True
        Me.CheckBoxCreateDirect.Location = New System.Drawing.Point(650, 277)
        Me.CheckBoxCreateDirect.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBoxCreateDirect.Name = "CheckBoxCreateDirect"
        Me.CheckBoxCreateDirect.Size = New System.Drawing.Size(88, 17)
        Me.CheckBoxCreateDirect.TabIndex = 34
        Me.CheckBoxCreateDirect.Text = "Create Direct"
        Me.CheckBoxCreateDirect.UseVisualStyleBackColor = True
        '
        'LabelXMLFile
        '
        Me.LabelXMLFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelXMLFile.AutoSize = True
        Me.LabelXMLFile.Location = New System.Drawing.Point(344, 127)
        Me.LabelXMLFile.Name = "LabelXMLFile"
        Me.LabelXMLFile.Size = New System.Drawing.Size(29, 13)
        Me.LabelXMLFile.TabIndex = 33
        Me.LabelXMLFile.Text = "XML"
        '
        'LabelDatabaseConnection
        '
        Me.LabelDatabaseConnection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelDatabaseConnection.AutoSize = True
        Me.LabelDatabaseConnection.Location = New System.Drawing.Point(344, 85)
        Me.LabelDatabaseConnection.Name = "LabelDatabaseConnection"
        Me.LabelDatabaseConnection.Size = New System.Drawing.Size(61, 13)
        Me.LabelDatabaseConnection.TabIndex = 32
        Me.LabelDatabaseConnection.Text = "Connection"
        '
        'ButtonXMLFile
        '
        Me.ButtonXMLFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonXMLFile.Location = New System.Drawing.Point(345, 101)
        Me.ButtonXMLFile.Name = "ButtonXMLFile"
        Me.ButtonXMLFile.Size = New System.Drawing.Size(127, 23)
        Me.ButtonXMLFile.TabIndex = 31
        Me.ButtonXMLFile.Text = "XML File"
        Me.ButtonXMLFile.UseVisualStyleBackColor = True
        '
        'ButtonDatabaseConnection
        '
        Me.ButtonDatabaseConnection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonDatabaseConnection.Location = New System.Drawing.Point(345, 59)
        Me.ButtonDatabaseConnection.Name = "ButtonDatabaseConnection"
        Me.ButtonDatabaseConnection.Size = New System.Drawing.Size(127, 23)
        Me.ButtonDatabaseConnection.TabIndex = 30
        Me.ButtonDatabaseConnection.Text = "Database connection"
        Me.ButtonDatabaseConnection.UseVisualStyleBackColor = True
        '
        'CheckBoxSaveDataSet
        '
        Me.CheckBoxSaveDataSet.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxSaveDataSet.AutoSize = True
        Me.CheckBoxSaveDataSet.Location = New System.Drawing.Point(650, 151)
        Me.CheckBoxSaveDataSet.Name = "CheckBoxSaveDataSet"
        Me.CheckBoxSaveDataSet.Size = New System.Drawing.Size(89, 17)
        Me.CheckBoxSaveDataSet.TabIndex = 29
        Me.CheckBoxSaveDataSet.Text = "Save dataset"
        Me.CheckBoxSaveDataSet.UseVisualStyleBackColor = True
        '
        'CheckBoxForeignKeys
        '
        Me.CheckBoxForeignKeys.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxForeignKeys.AutoSize = True
        Me.CheckBoxForeignKeys.Checked = True
        Me.CheckBoxForeignKeys.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxForeignKeys.Location = New System.Drawing.Point(650, 225)
        Me.CheckBoxForeignKeys.Name = "CheckBoxForeignKeys"
        Me.CheckBoxForeignKeys.Size = New System.Drawing.Size(86, 17)
        Me.CheckBoxForeignKeys.TabIndex = 28
        Me.CheckBoxForeignKeys.Text = "Foreign keys"
        Me.CheckBoxForeignKeys.UseVisualStyleBackColor = True
        '
        'CheckBoxModelTables
        '
        Me.CheckBoxModelTables.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxModelTables.AutoSize = True
        Me.CheckBoxModelTables.Checked = True
        Me.CheckBoxModelTables.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxModelTables.Location = New System.Drawing.Point(650, 200)
        Me.CheckBoxModelTables.Name = "CheckBoxModelTables"
        Me.CheckBoxModelTables.Size = New System.Drawing.Size(86, 17)
        Me.CheckBoxModelTables.TabIndex = 27
        Me.CheckBoxModelTables.Text = "Model tables"
        Me.CheckBoxModelTables.UseVisualStyleBackColor = True
        '
        'CheckBoxSystemTables
        '
        Me.CheckBoxSystemTables.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxSystemTables.AutoSize = True
        Me.CheckBoxSystemTables.Location = New System.Drawing.Point(650, 175)
        Me.CheckBoxSystemTables.Name = "CheckBoxSystemTables"
        Me.CheckBoxSystemTables.Size = New System.Drawing.Size(91, 17)
        Me.CheckBoxSystemTables.TabIndex = 26
        Me.CheckBoxSystemTables.Text = "System tables"
        Me.CheckBoxSystemTables.UseVisualStyleBackColor = True
        '
        'ButtonInspector
        '
        Me.ButtonInspector.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonInspector.Location = New System.Drawing.Point(345, 5)
        Me.ButtonInspector.Name = "ButtonInspector"
        Me.ButtonInspector.Size = New System.Drawing.Size(127, 23)
        Me.ButtonInspector.TabIndex = 25
        Me.ButtonInspector.Text = "Model inspector"
        Me.ButtonInspector.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 5)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Diagrams"
        '
        'ListBoxDiagrams
        '
        Me.ListBoxDiagrams.FormattingEnabled = True
        Me.ListBoxDiagrams.Location = New System.Drawing.Point(80, 5)
        Me.ListBoxDiagrams.Name = "ListBoxDiagrams"
        Me.ListBoxDiagrams.Size = New System.Drawing.Size(259, 124)
        Me.ListBoxDiagrams.TabIndex = 23
        '
        'ButtonSimulator
        '
        Me.ButtonSimulator.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSimulator.Location = New System.Drawing.Point(625, 5)
        Me.ButtonSimulator.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonSimulator.Name = "ButtonSimulator"
        Me.ButtonSimulator.Size = New System.Drawing.Size(136, 54)
        Me.ButtonSimulator.TabIndex = 9
        Me.ButtonSimulator.Text = "Simulator"
        Me.ButtonSimulator.UseVisualStyleBackColor = True
        '
        'CheckBoxClipBoard
        '
        Me.CheckBoxClipBoard.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxClipBoard.AutoSize = True
        Me.CheckBoxClipBoard.Checked = True
        Me.CheckBoxClipBoard.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxClipBoard.Location = New System.Drawing.Point(650, 251)
        Me.CheckBoxClipBoard.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBoxClipBoard.Name = "CheckBoxClipBoard"
        Me.CheckBoxClipBoard.Size = New System.Drawing.Size(86, 17)
        Me.CheckBoxClipBoard.TabIndex = 8
        Me.CheckBoxClipBoard.Text = "To Clipboard"
        Me.CheckBoxClipBoard.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 149)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "SQL code"
        '
        'TextBoxDatasetCode
        '
        Me.TextBoxDatasetCode.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxDatasetCode.Location = New System.Drawing.Point(80, 149)
        Me.TextBoxDatasetCode.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxDatasetCode.Multiline = True
        Me.TextBoxDatasetCode.Name = "TextBoxDatasetCode"
        Me.TextBoxDatasetCode.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxDatasetCode.Size = New System.Drawing.Size(529, 192)
        Me.TextBoxDatasetCode.TabIndex = 6
        '
        'ButtonGenerateDataSet
        '
        Me.ButtonGenerateDataSet.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonGenerateDataSet.Location = New System.Drawing.Point(624, 298)
        Me.ButtonGenerateDataSet.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonGenerateDataSet.Name = "ButtonGenerateDataSet"
        Me.ButtonGenerateDataSet.Size = New System.Drawing.Size(142, 43)
        Me.ButtonGenerateDataSet.TabIndex = 5
        Me.ButtonGenerateDataSet.Text = "Generate SQL from dataset"
        Me.ButtonGenerateDataSet.UseVisualStyleBackColor = True
        '
        'TabPageFormFactory
        '
        Me.TabPageFormFactory.BackColor = System.Drawing.Color.LightGray
        Me.TabPageFormFactory.Controls.Add(Me.CheckBoxCreateMenu)
        Me.TabPageFormFactory.Controls.Add(Me.CheckBoxDeleteMenu)
        Me.TabPageFormFactory.Controls.Add(Me.CheckBoxCreateLookup)
        Me.TabPageFormFactory.Controls.Add(Me.CheckBoxDeleteLookup)
        Me.TabPageFormFactory.Controls.Add(Me.CheckBoxCreateClass)
        Me.TabPageFormFactory.Controls.Add(Me.CheckBoxDeleteClass)
        Me.TabPageFormFactory.Controls.Add(Me.CheckBoxCreateEnumeration)
        Me.TabPageFormFactory.Controls.Add(Me.CheckBoxDeleteEnumeration)
        Me.TabPageFormFactory.Controls.Add(Me.CheckBoxClose)
        Me.TabPageFormFactory.Controls.Add(Me.Label5)
        Me.TabPageFormFactory.Controls.Add(Me.ButtonGenerate)
        Me.TabPageFormFactory.Controls.Add(Me.ButtonToggleAll)
        Me.TabPageFormFactory.Controls.Add(Me.ButtonSelectAll)
        Me.TabPageFormFactory.Controls.Add(Me.ListBoxElements)
        Me.TabPageFormFactory.Controls.Add(Me.ButtonUnselectAll)
        Me.TabPageFormFactory.Location = New System.Drawing.Point(4, 22)
        Me.TabPageFormFactory.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPageFormFactory.Name = "TabPageFormFactory"
        Me.TabPageFormFactory.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPageFormFactory.Size = New System.Drawing.Size(768, 346)
        Me.TabPageFormFactory.TabIndex = 1
        Me.TabPageFormFactory.Text = "FormFactory"
        '
        'CheckBoxCreateMenu
        '
        Me.CheckBoxCreateMenu.AutoSize = True
        Me.CheckBoxCreateMenu.Checked = True
        Me.CheckBoxCreateMenu.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxCreateMenu.Location = New System.Drawing.Point(315, 220)
        Me.CheckBoxCreateMenu.Name = "CheckBoxCreateMenu"
        Me.CheckBoxCreateMenu.Size = New System.Drawing.Size(92, 17)
        Me.CheckBoxCreateMenu.TabIndex = 35
        Me.CheckBoxCreateMenu.Text = "Create Menus"
        Me.CheckBoxCreateMenu.UseVisualStyleBackColor = True
        '
        'CheckBoxDeleteMenu
        '
        Me.CheckBoxDeleteMenu.AutoSize = True
        Me.CheckBoxDeleteMenu.Checked = True
        Me.CheckBoxDeleteMenu.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxDeleteMenu.Location = New System.Drawing.Point(315, 198)
        Me.CheckBoxDeleteMenu.Name = "CheckBoxDeleteMenu"
        Me.CheckBoxDeleteMenu.Size = New System.Drawing.Size(92, 17)
        Me.CheckBoxDeleteMenu.TabIndex = 34
        Me.CheckBoxDeleteMenu.Text = "Delete Menus"
        Me.CheckBoxDeleteMenu.UseVisualStyleBackColor = True
        '
        'CheckBoxCreateLookup
        '
        Me.CheckBoxCreateLookup.AutoSize = True
        Me.CheckBoxCreateLookup.Checked = True
        Me.CheckBoxCreateLookup.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxCreateLookup.Location = New System.Drawing.Point(315, 175)
        Me.CheckBoxCreateLookup.Name = "CheckBoxCreateLookup"
        Me.CheckBoxCreateLookup.Size = New System.Drawing.Size(101, 17)
        Me.CheckBoxCreateLookup.TabIndex = 33
        Me.CheckBoxCreateLookup.Text = "Create Lookups"
        Me.CheckBoxCreateLookup.UseVisualStyleBackColor = True
        '
        'CheckBoxDeleteLookup
        '
        Me.CheckBoxDeleteLookup.AutoSize = True
        Me.CheckBoxDeleteLookup.Checked = True
        Me.CheckBoxDeleteLookup.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxDeleteLookup.Location = New System.Drawing.Point(315, 153)
        Me.CheckBoxDeleteLookup.Name = "CheckBoxDeleteLookup"
        Me.CheckBoxDeleteLookup.Size = New System.Drawing.Size(101, 17)
        Me.CheckBoxDeleteLookup.TabIndex = 32
        Me.CheckBoxDeleteLookup.Text = "Delete Lookups"
        Me.CheckBoxDeleteLookup.UseVisualStyleBackColor = True
        '
        'CheckBoxCreateClass
        '
        Me.CheckBoxCreateClass.AutoSize = True
        Me.CheckBoxCreateClass.Checked = True
        Me.CheckBoxCreateClass.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxCreateClass.Location = New System.Drawing.Point(315, 130)
        Me.CheckBoxCreateClass.Name = "CheckBoxCreateClass"
        Me.CheckBoxCreateClass.Size = New System.Drawing.Size(146, 17)
        Me.CheckBoxCreateClass.TabIndex = 31
        Me.CheckBoxCreateClass.Text = "Create Selected Classess"
        Me.CheckBoxCreateClass.UseVisualStyleBackColor = True
        '
        'CheckBoxDeleteClass
        '
        Me.CheckBoxDeleteClass.AutoSize = True
        Me.CheckBoxDeleteClass.Checked = True
        Me.CheckBoxDeleteClass.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxDeleteClass.Location = New System.Drawing.Point(315, 108)
        Me.CheckBoxDeleteClass.Name = "CheckBoxDeleteClass"
        Me.CheckBoxDeleteClass.Size = New System.Drawing.Size(141, 17)
        Me.CheckBoxDeleteClass.TabIndex = 30
        Me.CheckBoxDeleteClass.Text = "Delete Selected Classes"
        Me.CheckBoxDeleteClass.UseVisualStyleBackColor = True
        '
        'CheckBoxCreateEnumeration
        '
        Me.CheckBoxCreateEnumeration.AutoSize = True
        Me.CheckBoxCreateEnumeration.Checked = True
        Me.CheckBoxCreateEnumeration.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxCreateEnumeration.Location = New System.Drawing.Point(315, 83)
        Me.CheckBoxCreateEnumeration.Name = "CheckBoxCreateEnumeration"
        Me.CheckBoxCreateEnumeration.Size = New System.Drawing.Size(124, 17)
        Me.CheckBoxCreateEnumeration.TabIndex = 29
        Me.CheckBoxCreateEnumeration.Text = "Create Enumerations"
        Me.CheckBoxCreateEnumeration.UseVisualStyleBackColor = True
        '
        'CheckBoxDeleteEnumeration
        '
        Me.CheckBoxDeleteEnumeration.AutoSize = True
        Me.CheckBoxDeleteEnumeration.Checked = True
        Me.CheckBoxDeleteEnumeration.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxDeleteEnumeration.Location = New System.Drawing.Point(315, 61)
        Me.CheckBoxDeleteEnumeration.Name = "CheckBoxDeleteEnumeration"
        Me.CheckBoxDeleteEnumeration.Size = New System.Drawing.Size(124, 17)
        Me.CheckBoxDeleteEnumeration.TabIndex = 28
        Me.CheckBoxDeleteEnumeration.Text = "Delete Enumerations"
        Me.CheckBoxDeleteEnumeration.UseVisualStyleBackColor = True
        '
        'CheckBoxClose
        '
        Me.CheckBoxClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxClose.AutoSize = True
        Me.CheckBoxClose.Checked = True
        Me.CheckBoxClose.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxClose.Location = New System.Drawing.Point(565, 321)
        Me.CheckBoxClose.Name = "CheckBoxClose"
        Me.CheckBoxClose.Size = New System.Drawing.Size(195, 17)
        Me.CheckBoxClose.TabIndex = 3
        Me.CheckBoxClose.Text = "Close window after generating code"
        Me.CheckBoxClose.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(491, 17)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(277, 24)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "FormFactory code generator"
        '
        'ButtonGenerate
        '
        Me.ButtonGenerate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonGenerate.Location = New System.Drawing.Point(590, 265)
        Me.ButtonGenerate.Name = "ButtonGenerate"
        Me.ButtonGenerate.Size = New System.Drawing.Size(170, 50)
        Me.ButtonGenerate.TabIndex = 2
        Me.ButtonGenerate.Text = "Generate"
        Me.ButtonGenerate.UseVisualStyleBackColor = True
        '
        'ButtonToggleAll
        '
        Me.ButtonToggleAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonToggleAll.Location = New System.Drawing.Point(97, 306)
        Me.ButtonToggleAll.Name = "ButtonToggleAll"
        Me.ButtonToggleAll.Size = New System.Drawing.Size(75, 23)
        Me.ButtonToggleAll.TabIndex = 24
        Me.ButtonToggleAll.Text = "Toggle"
        Me.ButtonToggleAll.UseVisualStyleBackColor = True
        '
        'ButtonSelectAll
        '
        Me.ButtonSelectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonSelectAll.Location = New System.Drawing.Point(6, 306)
        Me.ButtonSelectAll.Name = "ButtonSelectAll"
        Me.ButtonSelectAll.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSelectAll.TabIndex = 23
        Me.ButtonSelectAll.Text = "Select All"
        Me.ButtonSelectAll.UseVisualStyleBackColor = True
        '
        'ListBoxElements
        '
        Me.ListBoxElements.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListBoxElements.FormattingEnabled = True
        Me.ListBoxElements.Location = New System.Drawing.Point(6, 17)
        Me.ListBoxElements.Name = "ListBoxElements"
        Me.ListBoxElements.Size = New System.Drawing.Size(259, 259)
        Me.ListBoxElements.TabIndex = 22
        '
        'ButtonUnselectAll
        '
        Me.ButtonUnselectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonUnselectAll.Location = New System.Drawing.Point(190, 306)
        Me.ButtonUnselectAll.Name = "ButtonUnselectAll"
        Me.ButtonUnselectAll.Size = New System.Drawing.Size(75, 23)
        Me.ButtonUnselectAll.TabIndex = 25
        Me.ButtonUnselectAll.Text = "Unselect All"
        Me.ButtonUnselectAll.UseVisualStyleBackColor = True
        '
        'ButtonLoad
        '
        Me.ButtonLoad.Location = New System.Drawing.Point(304, 6)
        Me.ButtonLoad.Name = "ButtonLoad"
        Me.ButtonLoad.Size = New System.Drawing.Size(41, 23)
        Me.ButtonLoad.TabIndex = 23
        Me.ButtonLoad.Text = "Load"
        Me.ButtonLoad.UseVisualStyleBackColor = True
        '
        'ComboBoxPackage
        '
        Me.ComboBoxPackage.FormattingEnabled = True
        Me.ComboBoxPackage.Location = New System.Drawing.Point(10, 6)
        Me.ComboBoxPackage.Name = "ComboBoxPackage"
        Me.ComboBoxPackage.Size = New System.Drawing.Size(290, 21)
        Me.ComboBoxPackage.TabIndex = 22
        '
        'FrmIDEAFormFactory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 404)
        Me.Controls.Add(Me.ButtonLoad)
        Me.Controls.Add(Me.ComboBoxPackage)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FrmIDEAFormFactory"
        Me.Text = "IDEA Code Generator"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageDataSet.ResumeLayout(False)
        Me.TabPageDataSet.PerformLayout()
        Me.TabPageFormFactory.ResumeLayout(False)
        Me.TabPageFormFactory.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPageFormFactory As System.Windows.Forms.TabPage
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxClose As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonGenerate As System.Windows.Forms.Button
    Friend WithEvents ButtonToggleAll As System.Windows.Forms.Button
    Friend WithEvents ButtonSelectAll As System.Windows.Forms.Button
    Friend WithEvents ListBoxElements As System.Windows.Forms.CheckedListBox
    Friend WithEvents ButtonUnselectAll As System.Windows.Forms.Button
    Friend WithEvents ButtonLoad As System.Windows.Forms.Button
    Friend WithEvents ComboBoxPackage As System.Windows.Forms.ComboBox
    Friend WithEvents TabPageDataSet As System.Windows.Forms.TabPage
    Friend WithEvents SaveFileDialogDataSet As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDatasetCode As System.Windows.Forms.TextBox
    Friend WithEvents ButtonGenerateDataSet As System.Windows.Forms.Button
    Friend WithEvents CheckBoxClipBoard As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonSimulator As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListBoxDiagrams As System.Windows.Forms.CheckedListBox
    Friend WithEvents ButtonInspector As System.Windows.Forms.Button
    Friend WithEvents CheckBoxSaveDataSet As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxForeignKeys As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxModelTables As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxSystemTables As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonXMLFile As System.Windows.Forms.Button
    Friend WithEvents ButtonDatabaseConnection As System.Windows.Forms.Button
    Friend WithEvents FileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents LabelXMLFile As System.Windows.Forms.Label
    Friend WithEvents LabelDatabaseConnection As System.Windows.Forms.Label
    Friend WithEvents CheckBoxCreateDirect As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxCreateLookup As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxDeleteLookup As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxCreateClass As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxDeleteClass As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxCreateEnumeration As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxDeleteEnumeration As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxCreateMenu As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxDeleteMenu As System.Windows.Forms.CheckBox
End Class
