<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatientCholesterolScreening
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.mnuFile = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayPatientInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lblNumberResult = New System.Windows.Forms.Label()
        Me.lblAvg = New System.Windows.Forms.Label()
        Me.lblAvgResult = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.mnuFile.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(11, 49)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(390, 37)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Patient Cholesterol Screening"
        '
        'mnuFile
        '
        Me.mnuFile.BackColor = System.Drawing.Color.LightSteelBlue
        Me.mnuFile.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.mnuFile.Location = New System.Drawing.Point(0, 0)
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(413, 24)
        Me.mnuFile.TabIndex = 1
        Me.mnuFile.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisplayPatientInformationToolStripMenuItem, Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'DisplayPatientInformationToolStripMenuItem
        '
        Me.DisplayPatientInformationToolStripMenuItem.Name = "DisplayPatientInformationToolStripMenuItem"
        Me.DisplayPatientInformationToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.DisplayPatientInformationToolStripMenuItem.Text = "&Display Patient Information"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.ClearToolStripMenuItem.Text = "&Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber.Location = New System.Drawing.Point(65, 94)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(295, 17)
        Me.lblNumber.TabIndex = 2
        Me.lblNumber.Text = "Number of Patients with Cholestorol >= 200:"
        Me.lblNumber.Visible = False
        '
        'lblNumberResult
        '
        Me.lblNumberResult.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberResult.Location = New System.Drawing.Point(0, 122)
        Me.lblNumberResult.Name = "lblNumberResult"
        Me.lblNumberResult.Size = New System.Drawing.Size(413, 22)
        Me.lblNumberResult.TabIndex = 3
        Me.lblNumberResult.Text = "#"
        Me.lblNumberResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNumberResult.Visible = False
        '
        'lblAvg
        '
        Me.lblAvg.AutoSize = True
        Me.lblAvg.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvg.Location = New System.Drawing.Point(114, 163)
        Me.lblAvg.Name = "lblAvg"
        Me.lblAvg.Size = New System.Drawing.Size(189, 17)
        Me.lblAvg.TabIndex = 4
        Me.lblAvg.Text = "Average Cholesterol Levels:"
        Me.lblAvg.Visible = False
        '
        'lblAvgResult
        '
        Me.lblAvgResult.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgResult.Location = New System.Drawing.Point(0, 198)
        Me.lblAvgResult.Name = "lblAvgResult"
        Me.lblAvgResult.Size = New System.Drawing.Size(413, 22)
        Me.lblAvgResult.TabIndex = 5
        Me.lblAvgResult.Text = "#"
        Me.lblAvgResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAvgResult.Visible = False
        '
        'btnDisplay
        '
        Me.btnDisplay.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnDisplay.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.Location = New System.Drawing.Point(165, 242)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(91, 33)
        Me.btnDisplay.TabIndex = 7
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = False
        '
        'frmPatientCholesterolScreening
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(413, 298)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.lblAvgResult)
        Me.Controls.Add(Me.lblAvg)
        Me.Controls.Add(Me.lblNumberResult)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.mnuFile)
        Me.MainMenuStrip = Me.mnuFile
        Me.Name = "frmPatientCholesterolScreening"
        Me.Text = "Patient Cholesterol Screening"
        Me.mnuFile.ResumeLayout(False)
        Me.mnuFile.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents mnuFile As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayPatientInformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblNumber As Label
    Friend WithEvents lblNumberResult As Label
    Friend WithEvents lblAvg As Label
    Friend WithEvents lblAvgResult As Label
    Friend WithEvents btnDisplay As Button
End Class
