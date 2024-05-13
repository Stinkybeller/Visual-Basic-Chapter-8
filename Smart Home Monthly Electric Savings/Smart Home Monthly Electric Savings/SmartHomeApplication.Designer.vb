<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSmartHomeApplications
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.cboMonths = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.lblSavings = New System.Windows.Forms.Label()
        Me.lblAverageSavings = New System.Windows.Forms.Label()
        Me.lblMostSavings = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Smart_Home_Monthly_Electric_Savings.My.Resources.Resources.smarthome
        Me.PictureBox1.Location = New System.Drawing.Point(0, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(155, 144)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblHeading.Location = New System.Drawing.Point(161, 39)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(286, 23)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Smart Home Electric Savings"
        '
        'cboMonths
        '
        Me.cboMonths.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMonths.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cboMonths.FormattingEnabled = True
        Me.cboMonths.Location = New System.Drawing.Point(224, 78)
        Me.cboMonths.Name = "cboMonths"
        Me.cboMonths.Size = New System.Drawing.Size(160, 31)
        Me.cboMonths.TabIndex = 2
        Me.cboMonths.Text = "Select Month"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(459, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'btnDisplay
        '
        Me.btnDisplay.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDisplay.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnDisplay.Location = New System.Drawing.Point(147, 221)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(165, 42)
        Me.btnDisplay.TabIndex = 5
        Me.btnDisplay.Text = "Disply Statistics"
        Me.btnDisplay.UseVisualStyleBackColor = False
        Me.btnDisplay.Visible = False
        '
        'lblSavings
        '
        Me.lblSavings.AutoSize = True
        Me.lblSavings.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSavings.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblSavings.Location = New System.Drawing.Point(86, 193)
        Me.lblSavings.Name = "lblSavings"
        Me.lblSavings.Size = New System.Drawing.Size(272, 16)
        Me.lblSavings.TabIndex = 6
        Me.lblSavings.Text = "The electric savings for xxxxxxx is xxxxxx"
        Me.lblSavings.Visible = False
        '
        'lblAverageSavings
        '
        Me.lblAverageSavings.AutoSize = True
        Me.lblAverageSavings.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageSavings.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblAverageSavings.Location = New System.Drawing.Point(102, 293)
        Me.lblAverageSavings.Name = "lblAverageSavings"
        Me.lblAverageSavings.Size = New System.Drawing.Size(207, 16)
        Me.lblAverageSavings.TabIndex = 7
        Me.lblAverageSavings.Text = "The average monthly savings: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblAverageSavings.Visible = False
        '
        'lblMostSavings
        '
        Me.lblMostSavings.AutoSize = True
        Me.lblMostSavings.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostSavings.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblMostSavings.Location = New System.Drawing.Point(52, 320)
        Me.lblMostSavings.Name = "lblMostSavings"
        Me.lblMostSavings.Size = New System.Drawing.Size(324, 16)
        Me.lblMostSavings.TabIndex = 8
        Me.lblMostSavings.Text = "xxxxxx had the most signifigant monthly savings."
        Me.lblMostSavings.Visible = False
        '
        'frmSmartHomeApplications
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(459, 387)
        Me.Controls.Add(Me.lblMostSavings)
        Me.Controls.Add(Me.lblAverageSavings)
        Me.Controls.Add(Me.lblSavings)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.cboMonths)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmSmartHomeApplications"
        Me.Text = "Smart Home Application"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents cboMonths As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btnDisplay As Button
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblSavings As Label
    Friend WithEvents lblAverageSavings As Label
    Friend WithEvents lblMostSavings As Label
End Class
