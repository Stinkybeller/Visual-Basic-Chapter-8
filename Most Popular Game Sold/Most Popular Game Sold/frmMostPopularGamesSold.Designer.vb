<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMostPopularGamesSold
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
        Me.mnuFile = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplaySortedListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lstGameTitle = New System.Windows.Forms.ListBox()
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.lblTotalNumSold = New System.Windows.Forms.Label()
        Me.lblNumSoldSelected = New System.Windows.Forms.Label()
        Me.lblNumSold = New System.Windows.Forms.Label()
        Me.lblTotalNumSoldHeader = New System.Windows.Forms.Label()
        Me.mnuFile.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuFile
        '
        Me.mnuFile.BackColor = System.Drawing.Color.SteelBlue
        Me.mnuFile.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuFile.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.mnuFile.Location = New System.Drawing.Point(0, 0)
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.mnuFile.Size = New System.Drawing.Size(600, 24)
        Me.mnuFile.TabIndex = 0
        Me.mnuFile.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisplaySortedListToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'DisplaySortedListToolStripMenuItem
        '
        Me.DisplaySortedListToolStripMenuItem.Name = "DisplaySortedListToolStripMenuItem"
        Me.DisplaySortedListToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DisplaySortedListToolStripMenuItem.Text = "Display Sorted List"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Ravie", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblHeading.Location = New System.Drawing.Point(53, 49)
        Me.lblHeading.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(494, 36)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Most Popular Games Sold"
        '
        'lstGameTitle
        '
        Me.lstGameTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstGameTitle.FormattingEnabled = True
        Me.lstGameTitle.ItemHeight = 18
        Me.lstGameTitle.Location = New System.Drawing.Point(320, 125)
        Me.lstGameTitle.Margin = New System.Windows.Forms.Padding(2)
        Me.lstGameTitle.Name = "lstGameTitle"
        Me.lstGameTitle.Size = New System.Drawing.Size(227, 184)
        Me.lstGameTitle.TabIndex = 2
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = True
        Me.lblSelect.Font = New System.Drawing.Font("Ravie", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelect.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblSelect.Location = New System.Drawing.Point(315, 97)
        Me.lblSelect.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(100, 26)
        Me.lblSelect.TabIndex = 3
        Me.lblSelect.Text = "Select:"
        '
        'btnDisplay
        '
        Me.btnDisplay.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.Location = New System.Drawing.Point(59, 273)
        Me.btnDisplay.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(107, 33)
        Me.btnDisplay.TabIndex = 5
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'lblTotalNumSold
        '
        Me.lblTotalNumSold.AutoSize = True
        Me.lblTotalNumSold.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalNumSold.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTotalNumSold.Location = New System.Drawing.Point(55, 221)
        Me.lblTotalNumSold.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalNumSold.Name = "lblTotalNumSold"
        Me.lblTotalNumSold.Size = New System.Drawing.Size(19, 23)
        Me.lblTotalNumSold.TabIndex = 6
        Me.lblTotalNumSold.Text = "#"
        '
        'lblNumSoldSelected
        '
        Me.lblNumSoldSelected.AutoSize = True
        Me.lblNumSoldSelected.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumSoldSelected.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblNumSoldSelected.Location = New System.Drawing.Point(55, 154)
        Me.lblNumSoldSelected.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNumSoldSelected.Name = "lblNumSoldSelected"
        Me.lblNumSoldSelected.Size = New System.Drawing.Size(19, 23)
        Me.lblNumSoldSelected.TabIndex = 7
        Me.lblNumSoldSelected.Text = "#"
        '
        'lblNumSold
        '
        Me.lblNumSold.AutoSize = True
        Me.lblNumSold.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumSold.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblNumSold.Location = New System.Drawing.Point(55, 125)
        Me.lblNumSold.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNumSold.Name = "lblNumSold"
        Me.lblNumSold.Size = New System.Drawing.Size(171, 23)
        Me.lblNumSold.TabIndex = 8
        Me.lblNumSold.Text = "Number of Sold Games: "
        '
        'lblTotalNumSoldHeader
        '
        Me.lblTotalNumSoldHeader.AutoSize = True
        Me.lblTotalNumSoldHeader.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalNumSoldHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTotalNumSoldHeader.Location = New System.Drawing.Point(55, 199)
        Me.lblTotalNumSoldHeader.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalNumSoldHeader.Name = "lblTotalNumSoldHeader"
        Me.lblTotalNumSoldHeader.Size = New System.Drawing.Size(210, 23)
        Me.lblTotalNumSoldHeader.TabIndex = 9
        Me.lblTotalNumSoldHeader.Text = "Total Number of Sold Games: "
        '
        'frmMostPopularGamesSold
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.lblTotalNumSoldHeader)
        Me.Controls.Add(Me.lblNumSold)
        Me.Controls.Add(Me.lblNumSoldSelected)
        Me.Controls.Add(Me.lblTotalNumSold)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.lblSelect)
        Me.Controls.Add(Me.lstGameTitle)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.mnuFile)
        Me.MainMenuStrip = Me.mnuFile
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmMostPopularGamesSold"
        Me.Text = "Most Popular Games Sold"
        Me.mnuFile.ResumeLayout(False)
        Me.mnuFile.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuFile As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplaySortedListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblHeading As Label
    Friend WithEvents lstGameTitle As ListBox
    Friend WithEvents lblSelect As Label
    Friend WithEvents btnDisplay As Button
    Friend WithEvents lblTotalNumSold As Label
    Friend WithEvents lblNumSoldSelected As Label
    Friend WithEvents lblNumSold As Label
    Friend WithEvents lblTotalNumSoldHeader As Label
End Class
