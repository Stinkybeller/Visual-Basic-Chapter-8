<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisplayPatientInfo
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
        Me.lstPatientName = New System.Windows.Forms.ListBox()
        Me.lstCholesterolLevel = New System.Windows.Forms.ListBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstPatientName
        '
        Me.lstPatientName.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPatientName.FormattingEnabled = True
        Me.lstPatientName.ItemHeight = 26
        Me.lstPatientName.Location = New System.Drawing.Point(47, 70)
        Me.lstPatientName.Name = "lstPatientName"
        Me.lstPatientName.Size = New System.Drawing.Size(196, 264)
        Me.lstPatientName.TabIndex = 0
        '
        'lstCholesterolLevel
        '
        Me.lstCholesterolLevel.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCholesterolLevel.FormattingEnabled = True
        Me.lstCholesterolLevel.ItemHeight = 26
        Me.lstCholesterolLevel.Location = New System.Drawing.Point(281, 70)
        Me.lstCholesterolLevel.Name = "lstCholesterolLevel"
        Me.lstCholesterolLevel.Size = New System.Drawing.Size(94, 264)
        Me.lstCholesterolLevel.TabIndex = 1
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.Honeydew
        Me.btnReturn.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(116, 374)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(181, 40)
        Me.btnReturn.TabIndex = 2
        Me.btnReturn.Text = "Return to Form"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'frmDisplayPatientInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 446)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.lstCholesterolLevel)
        Me.Controls.Add(Me.lstPatientName)
        Me.Name = "frmDisplayPatientInfo"
        Me.Text = "Patient Information"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstPatientName As ListBox
    Friend WithEvents lstCholesterolLevel As ListBox
    Friend WithEvents btnReturn As Button
End Class
