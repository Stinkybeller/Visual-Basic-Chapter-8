<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisplayInventory
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
        Me.picTruck = New System.Windows.Forms.PictureBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        CType(Me.picTruck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picTruck
        '
        Me.picTruck.Image = Global.Chef_Shack_Burger_Food_Truck.My.Resources.Resources.truck
        Me.picTruck.Location = New System.Drawing.Point(12, 12)
        Me.picTruck.Name = "picTruck"
        Me.picTruck.Size = New System.Drawing.Size(83, 63)
        Me.picTruck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTruck.TabIndex = 0
        Me.picTruck.TabStop = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Myanmar Text", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblHeading.Location = New System.Drawing.Point(97, 12)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(227, 37)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Chef Shack Inventory"
        '
        'lstDisplay
        '
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.Location = New System.Drawing.Point(87, 91)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(196, 212)
        Me.lstDisplay.TabIndex = 2
        '
        'btnReturn
        '
        Me.btnReturn.Font = New System.Drawing.Font("Myanmar Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ForeColor = System.Drawing.Color.DarkOrange
        Me.btnReturn.Location = New System.Drawing.Point(104, 318)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(162, 35)
        Me.btnReturn.TabIndex = 3
        Me.btnReturn.Text = "Return to Application"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'frmDisplayInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(371, 380)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.picTruck)
        Me.Name = "frmDisplayInventory"
        Me.Text = "Sorted Inventory Listing"
        CType(Me.picTruck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picTruck As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents lstDisplay As ListBox
    Friend WithEvents btnReturn As Button
End Class
