<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFoodTruck
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
        Me.mnuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDisplayInventory = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.picTruck = New System.Windows.Forms.PictureBox()
        Me.lblFoodTruck = New System.Windows.Forms.Label()
        Me.lstInventoryID = New System.Windows.Forms.ListBox()
        Me.lblSelection = New System.Windows.Forms.Label()
        Me.grpDeprecationType = New System.Windows.Forms.GroupBox()
        Me.radDeclineBalance = New System.Windows.Forms.RadioButton()
        Me.radStraightLine = New System.Windows.Forms.RadioButton()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lstYear = New System.Windows.Forms.ListBox()
        Me.lstPresentValue = New System.Windows.Forms.ListBox()
        Me.lstYearDepreciation = New System.Windows.Forms.ListBox()
        Me.lstTotalDepreciation = New System.Windows.Forms.ListBox()
        Me.lblPresentYear = New System.Windows.Forms.Label()
        Me.lblPresentValue = New System.Windows.Forms.Label()
        Me.lblYearDepreciation = New System.Windows.Forms.Label()
        Me.lblTotalDepreciation = New System.Windows.Forms.Label()
        Me.mnuStrip.SuspendLayout()
        CType(Me.picTruck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDeprecationType.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuStrip
        '
        Me.mnuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.mnuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuStrip.Name = "mnuStrip"
        Me.mnuStrip.Size = New System.Drawing.Size(684, 24)
        Me.mnuStrip.TabIndex = 0
        Me.mnuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDisplayInventory, Me.mnuClear, Me.mnuExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'mnuDisplayInventory
        '
        Me.mnuDisplayInventory.Name = "mnuDisplayInventory"
        Me.mnuDisplayInventory.Size = New System.Drawing.Size(180, 22)
        Me.mnuDisplayInventory.Text = "Display Inventory"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(180, 22)
        Me.mnuClear.Text = "Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(180, 22)
        Me.mnuExit.Text = "Exit"
        '
        'picTruck
        '
        Me.picTruck.Image = Global.Chef_Shack_Burger_Food_Truck.My.Resources.Resources.truck
        Me.picTruck.Location = New System.Drawing.Point(0, 27)
        Me.picTruck.Name = "picTruck"
        Me.picTruck.Size = New System.Drawing.Size(215, 265)
        Me.picTruck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTruck.TabIndex = 1
        Me.picTruck.TabStop = False
        '
        'lblFoodTruck
        '
        Me.lblFoodTruck.AutoSize = True
        Me.lblFoodTruck.Font = New System.Drawing.Font("Myanmar Text", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodTruck.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblFoodTruck.Location = New System.Drawing.Point(221, 27)
        Me.lblFoodTruck.Name = "lblFoodTruck"
        Me.lblFoodTruck.Size = New System.Drawing.Size(436, 51)
        Me.lblFoodTruck.TabIndex = 2
        Me.lblFoodTruck.Text = "Chef Shack Burger Food Truck"
        '
        'lstInventoryID
        '
        Me.lstInventoryID.FormattingEnabled = True
        Me.lstInventoryID.Location = New System.Drawing.Point(230, 94)
        Me.lstInventoryID.Name = "lstInventoryID"
        Me.lstInventoryID.Size = New System.Drawing.Size(134, 121)
        Me.lstInventoryID.TabIndex = 3
        '
        'lblSelection
        '
        Me.lblSelection.AutoSize = True
        Me.lblSelection.Font = New System.Drawing.Font("Myanmar Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelection.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblSelection.Location = New System.Drawing.Point(226, 67)
        Me.lblSelection.Name = "lblSelection"
        Me.lblSelection.Size = New System.Drawing.Size(145, 24)
        Me.lblSelection.TabIndex = 4
        Me.lblSelection.Text = "Select Inventory Item:"
        '
        'grpDeprecationType
        '
        Me.grpDeprecationType.Controls.Add(Me.radDeclineBalance)
        Me.grpDeprecationType.Controls.Add(Me.radStraightLine)
        Me.grpDeprecationType.Font = New System.Drawing.Font("Myanmar Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDeprecationType.ForeColor = System.Drawing.Color.DarkOrange
        Me.grpDeprecationType.Location = New System.Drawing.Point(424, 94)
        Me.grpDeprecationType.Name = "grpDeprecationType"
        Me.grpDeprecationType.Size = New System.Drawing.Size(222, 121)
        Me.grpDeprecationType.TabIndex = 5
        Me.grpDeprecationType.TabStop = False
        Me.grpDeprecationType.Text = "Select Deprecation Method:"
        '
        'radDeclineBalance
        '
        Me.radDeclineBalance.AutoSize = True
        Me.radDeclineBalance.Font = New System.Drawing.Font("Myanmar Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDeclineBalance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radDeclineBalance.Location = New System.Drawing.Point(6, 74)
        Me.radDeclineBalance.Name = "radDeclineBalance"
        Me.radDeclineBalance.Size = New System.Drawing.Size(209, 33)
        Me.radDeclineBalance.TabIndex = 1
        Me.radDeclineBalance.TabStop = True
        Me.radDeclineBalance.Text = "Double-Declining Balance"
        Me.radDeclineBalance.UseVisualStyleBackColor = True
        '
        'radStraightLine
        '
        Me.radStraightLine.AutoSize = True
        Me.radStraightLine.Font = New System.Drawing.Font("Myanmar Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radStraightLine.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radStraightLine.Location = New System.Drawing.Point(6, 31)
        Me.radStraightLine.Name = "radStraightLine"
        Me.radStraightLine.Size = New System.Drawing.Size(121, 33)
        Me.radStraightLine.TabIndex = 0
        Me.radStraightLine.TabStop = True
        Me.radStraightLine.Text = "Straight-Line"
        Me.radStraightLine.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.MistyRose
        Me.btnCalculate.Font = New System.Drawing.Font("Myanmar Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.DarkOrange
        Me.btnCalculate.Location = New System.Drawing.Point(315, 232)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(197, 27)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate Depreciation"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Font = New System.Drawing.Font("Myanmar Text", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItem.Location = New System.Drawing.Point(311, 262)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(208, 23)
        Me.lblItem.TabIndex = 7
        Me.lblItem.Text = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Myanmar Text", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(375, 296)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(62, 23)
        Me.lblQuantity.TabIndex = 8
        Me.lblQuantity.Text = "xxxxxx xx"
        '
        'lstYear
        '
        Me.lstYear.Font = New System.Drawing.Font("Myanmar Text", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstYear.FormattingEnabled = True
        Me.lstYear.ItemHeight = 21
        Me.lstYear.Location = New System.Drawing.Point(26, 367)
        Me.lstYear.Name = "lstYear"
        Me.lstYear.Size = New System.Drawing.Size(134, 109)
        Me.lstYear.TabIndex = 9
        '
        'lstPresentValue
        '
        Me.lstPresentValue.Font = New System.Drawing.Font("Myanmar Text", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPresentValue.FormattingEnabled = True
        Me.lstPresentValue.ItemHeight = 21
        Me.lstPresentValue.Location = New System.Drawing.Point(192, 367)
        Me.lstPresentValue.Name = "lstPresentValue"
        Me.lstPresentValue.Size = New System.Drawing.Size(134, 109)
        Me.lstPresentValue.TabIndex = 10
        '
        'lstYearDepreciation
        '
        Me.lstYearDepreciation.Font = New System.Drawing.Font("Myanmar Text", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstYearDepreciation.FormattingEnabled = True
        Me.lstYearDepreciation.ItemHeight = 21
        Me.lstYearDepreciation.Location = New System.Drawing.Point(358, 367)
        Me.lstYearDepreciation.Name = "lstYearDepreciation"
        Me.lstYearDepreciation.Size = New System.Drawing.Size(134, 109)
        Me.lstYearDepreciation.TabIndex = 11
        '
        'lstTotalDepreciation
        '
        Me.lstTotalDepreciation.Font = New System.Drawing.Font("Myanmar Text", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTotalDepreciation.FormattingEnabled = True
        Me.lstTotalDepreciation.ItemHeight = 21
        Me.lstTotalDepreciation.Location = New System.Drawing.Point(524, 367)
        Me.lstTotalDepreciation.Name = "lstTotalDepreciation"
        Me.lstTotalDepreciation.Size = New System.Drawing.Size(134, 109)
        Me.lstTotalDepreciation.TabIndex = 12
        '
        'lblPresentYear
        '
        Me.lblPresentYear.AutoSize = True
        Me.lblPresentYear.Font = New System.Drawing.Font("Myanmar Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPresentYear.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblPresentYear.Location = New System.Drawing.Point(22, 341)
        Me.lblPresentYear.Name = "lblPresentYear"
        Me.lblPresentYear.Size = New System.Drawing.Size(91, 24)
        Me.lblPresentYear.TabIndex = 13
        Me.lblPresentYear.Text = "Present Year:"
        '
        'lblPresentValue
        '
        Me.lblPresentValue.AutoSize = True
        Me.lblPresentValue.Font = New System.Drawing.Font("Myanmar Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPresentValue.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblPresentValue.Location = New System.Drawing.Point(188, 340)
        Me.lblPresentValue.Name = "lblPresentValue"
        Me.lblPresentValue.Size = New System.Drawing.Size(95, 24)
        Me.lblPresentValue.TabIndex = 14
        Me.lblPresentValue.Text = "Present Value"
        '
        'lblYearDepreciation
        '
        Me.lblYearDepreciation.AutoSize = True
        Me.lblYearDepreciation.Font = New System.Drawing.Font("Myanmar Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearDepreciation.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblYearDepreciation.Location = New System.Drawing.Point(354, 340)
        Me.lblYearDepreciation.Name = "lblYearDepreciation"
        Me.lblYearDepreciation.Size = New System.Drawing.Size(120, 24)
        Me.lblYearDepreciation.TabIndex = 15
        Me.lblYearDepreciation.Text = "Year Depreciation"
        '
        'lblTotalDepreciation
        '
        Me.lblTotalDepreciation.AutoSize = True
        Me.lblTotalDepreciation.Font = New System.Drawing.Font("Myanmar Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDepreciation.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblTotalDepreciation.Location = New System.Drawing.Point(520, 340)
        Me.lblTotalDepreciation.Name = "lblTotalDepreciation"
        Me.lblTotalDepreciation.Size = New System.Drawing.Size(125, 24)
        Me.lblTotalDepreciation.TabIndex = 16
        Me.lblTotalDepreciation.Text = "Total Depreciation"
        '
        'frmFoodTruck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(684, 500)
        Me.Controls.Add(Me.lblTotalDepreciation)
        Me.Controls.Add(Me.lblYearDepreciation)
        Me.Controls.Add(Me.lblPresentValue)
        Me.Controls.Add(Me.lblPresentYear)
        Me.Controls.Add(Me.lstTotalDepreciation)
        Me.Controls.Add(Me.lstYearDepreciation)
        Me.Controls.Add(Me.lstPresentValue)
        Me.Controls.Add(Me.lstYear)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblItem)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpDeprecationType)
        Me.Controls.Add(Me.lblSelection)
        Me.Controls.Add(Me.lstInventoryID)
        Me.Controls.Add(Me.lblFoodTruck)
        Me.Controls.Add(Me.picTruck)
        Me.Controls.Add(Me.mnuStrip)
        Me.MainMenuStrip = Me.mnuStrip
        Me.Name = "frmFoodTruck"
        Me.Text = "Chef Shack Food Truck"
        Me.mnuStrip.ResumeLayout(False)
        Me.mnuStrip.PerformLayout()
        CType(Me.picTruck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDeprecationType.ResumeLayout(False)
        Me.grpDeprecationType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuDisplayInventory As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents picTruck As PictureBox
    Friend WithEvents lblFoodTruck As Label
    Friend WithEvents lstInventoryID As ListBox
    Friend WithEvents lblSelection As Label
    Friend WithEvents grpDeprecationType As GroupBox
    Friend WithEvents radDeclineBalance As RadioButton
    Friend WithEvents radStraightLine As RadioButton
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblItem As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lstYear As ListBox
    Friend WithEvents lstPresentValue As ListBox
    Friend WithEvents lstYearDepreciation As ListBox
    Friend WithEvents lstTotalDepreciation As ListBox
    Friend WithEvents lblPresentYear As Label
    Friend WithEvents lblPresentValue As Label
    Friend WithEvents lblYearDepreciation As Label
    Friend WithEvents lblTotalDepreciation As Label
End Class
