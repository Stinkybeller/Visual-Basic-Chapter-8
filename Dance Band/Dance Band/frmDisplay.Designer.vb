<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisplay
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
        Me.cboGenres = New System.Windows.Forms.ComboBox()
        Me.lstSongs2 = New System.Windows.Forms.ListBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCurrentOrder = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboGenres
        '
        Me.cboGenres.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGenres.FormattingEnabled = True
        Me.cboGenres.Items.AddRange(New Object() {"Rock", "Country", "Rap", "R&B"})
        Me.cboGenres.Location = New System.Drawing.Point(258, 62)
        Me.cboGenres.Name = "cboGenres"
        Me.cboGenres.Size = New System.Drawing.Size(121, 28)
        Me.cboGenres.TabIndex = 0
        Me.cboGenres.Text = "Select Genre"
        '
        'lstSongs2
        '
        Me.lstSongs2.FormattingEnabled = True
        Me.lstSongs2.Location = New System.Drawing.Point(31, 62)
        Me.lstSongs2.Name = "lstSongs2"
        Me.lstSongs2.Size = New System.Drawing.Size(206, 212)
        Me.lstSongs2.TabIndex = 1
        '
        'btnReturn
        '
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(275, 238)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(94, 38)
        Me.btnReturn.TabIndex = 2
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnSort
        '
        Me.btnSort.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSort.Location = New System.Drawing.Point(275, 150)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(94, 38)
        Me.btnSort.TabIndex = 3
        Me.btnSort.Text = "Sort"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(275, 194)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(94, 38)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCurrentOrder
        '
        Me.btnCurrentOrder.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCurrentOrder.Location = New System.Drawing.Point(275, 106)
        Me.btnCurrentOrder.Name = "btnCurrentOrder"
        Me.btnCurrentOrder.Size = New System.Drawing.Size(94, 38)
        Me.btnCurrentOrder.TabIndex = 5
        Me.btnCurrentOrder.Text = "Current Order"
        Me.btnCurrentOrder.UseVisualStyleBackColor = True
        '
        'frmDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 329)
        Me.Controls.Add(Me.btnCurrentOrder)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.lstSongs2)
        Me.Controls.Add(Me.cboGenres)
        Me.Name = "frmDisplay"
        Me.Text = "Display Song Set"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cboGenres As ComboBox
    Friend WithEvents lstSongs2 As ListBox
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnSort As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCurrentOrder As Button
End Class
