<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDanceBand
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
        Me.picDanceBand = New System.Windows.Forms.PictureBox()
        Me.lstSongs = New System.Windows.Forms.ListBox()
        Me.cboGenre = New System.Windows.Forms.ComboBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.mnuMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplaySongSetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.picDanceBand, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'picDanceBand
        '
        Me.picDanceBand.Image = Global.Dance_Band.My.Resources.Resources.Concerts_and_What_to_Expect
        Me.picDanceBand.Location = New System.Drawing.Point(588, 166)
        Me.picDanceBand.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picDanceBand.Name = "picDanceBand"
        Me.picDanceBand.Size = New System.Drawing.Size(351, 286)
        Me.picDanceBand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDanceBand.TabIndex = 0
        Me.picDanceBand.TabStop = False
        Me.picDanceBand.Visible = False
        '
        'lstSongs
        '
        Me.lstSongs.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSongs.FormattingEnabled = True
        Me.lstSongs.ItemHeight = 21
        Me.lstSongs.Location = New System.Drawing.Point(43, 166)
        Me.lstSongs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstSongs.Name = "lstSongs"
        Me.lstSongs.Size = New System.Drawing.Size(464, 277)
        Me.lstSongs.TabIndex = 1
        Me.lstSongs.Visible = False
        '
        'cboGenre
        '
        Me.cboGenre.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGenre.FormattingEnabled = True
        Me.cboGenre.Location = New System.Drawing.Point(405, 79)
        Me.cboGenre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboGenre.Name = "cboGenre"
        Me.cboGenre.Size = New System.Drawing.Size(180, 39)
        Me.cboGenre.TabIndex = 2
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.GhostWhite
        Me.lblHeading.Location = New System.Drawing.Point(365, 41)
        Me.lblHeading.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(252, 35)
        Me.lblHeading.TabIndex = 3
        Me.lblHeading.Text = "Dance Band Night"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Dance_Band.My.Resources.Resources.images
        Me.PictureBox1.Location = New System.Drawing.Point(-24, 27)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1104, 577)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'mnuMenu
        '
        Me.mnuMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.mnuMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenu.Name = "mnuMenu"
        Me.mnuMenu.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.mnuMenu.Size = New System.Drawing.Size(992, 28)
        Me.mnuMenu.TabIndex = 6
        Me.mnuMenu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem, Me.DisplaySongSetToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(196, 26)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(196, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'DisplaySongSetToolStripMenuItem
        '
        Me.DisplaySongSetToolStripMenuItem.Name = "DisplaySongSetToolStripMenuItem"
        Me.DisplaySongSetToolStripMenuItem.Size = New System.Drawing.Size(196, 26)
        Me.DisplaySongSetToolStripMenuItem.Text = "Display Song Set"
        '
        'frmDanceBand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(992, 569)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.cboGenre)
        Me.Controls.Add(Me.lstSongs)
        Me.Controls.Add(Me.picDanceBand)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.mnuMenu)
        Me.ForeColor = System.Drawing.Color.GhostWhite
        Me.MainMenuStrip = Me.mnuMenu
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmDanceBand"
        Me.Text = "Dance Band"
        CType(Me.picDanceBand, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuMenu.ResumeLayout(False)
        Me.mnuMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picDanceBand As PictureBox
    Friend WithEvents lstSongs As ListBox
    Friend WithEvents cboGenre As ComboBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents mnuMenu As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplaySongSetToolStripMenuItem As ToolStripMenuItem
End Class
