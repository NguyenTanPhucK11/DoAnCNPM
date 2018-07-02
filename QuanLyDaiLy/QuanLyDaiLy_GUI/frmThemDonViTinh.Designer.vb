<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemDonViTinh
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
        Me.bntNhap = New System.Windows.Forms.Button()
        Me.txtTenDVT = New System.Windows.Forms.TextBox()
        Me.txtMaDVT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.bntNhapDong = New System.Windows.Forms.Button()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'bntNhap
        '
        Me.bntNhap.Location = New System.Drawing.Point(215, 25)
        Me.bntNhap.Name = "bntNhap"
        Me.bntNhap.Size = New System.Drawing.Size(149, 51)
        Me.bntNhap.TabIndex = 0
        Me.bntNhap.Text = "Nhập"
        Me.bntNhap.UseVisualStyleBackColor = True
        '
        'txtTenDVT
        '
        Me.txtTenDVT.Location = New System.Drawing.Point(368, 180)
        Me.txtTenDVT.Name = "txtTenDVT"
        Me.txtTenDVT.Size = New System.Drawing.Size(218, 22)
        Me.txtTenDVT.TabIndex = 3
        '
        'txtMaDVT
        '
        Me.txtMaDVT.Location = New System.Drawing.Point(368, 135)
        Me.txtMaDVT.Name = "txtMaDVT"
        Me.txtMaDVT.ReadOnly = True
        Me.txtMaDVT.Size = New System.Drawing.Size(218, 22)
        Me.txtMaDVT.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(215, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tên Đơn Vị Tính"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(215, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Đơn Vị Tính"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtTenDVT)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.txtMaDVT)
        Me.GroupBox4.Location = New System.Drawing.Point(29, 45)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(800, 323)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Thông Tin Chung"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.bntNhapDong)
        Me.GroupBox3.Controls.Add(Me.bntNhap)
        Me.GroupBox3.Location = New System.Drawing.Point(29, 374)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(800, 93)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'bntNhapDong
        '
        Me.bntNhapDong.Location = New System.Drawing.Point(437, 25)
        Me.bntNhapDong.Name = "bntNhapDong"
        Me.bntNhapDong.Size = New System.Drawing.Size(149, 51)
        Me.bntNhapDong.TabIndex = 1
        Me.bntNhapDong.Text = "Nhập và Đóng"
        Me.bntNhapDong.UseVisualStyleBackColor = True
        '
        'frmThemDonViTinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(858, 512)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Name = "frmThemDonViTinh"
        Me.Text = "frmThemDonViTinh"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bntNhap As Button
    Friend WithEvents txtTenDVT As TextBox
    Friend WithEvents txtMaDVT As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents bntNhapDong As Button
End Class
