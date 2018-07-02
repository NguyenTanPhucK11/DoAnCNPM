<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemMatHang
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
        Me.bntNhapDong = New System.Windows.Forms.Button()
        Me.bntNhap = New System.Windows.Forms.Button()
        Me.txtSoLuongTon = New System.Windows.Forms.TextBox()
        Me.txtTenMH = New System.Windows.Forms.TextBox()
        Me.txtMaMH = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
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
        'bntNhap
        '
        Me.bntNhap.Location = New System.Drawing.Point(215, 25)
        Me.bntNhap.Name = "bntNhap"
        Me.bntNhap.Size = New System.Drawing.Size(149, 51)
        Me.bntNhap.TabIndex = 0
        Me.bntNhap.Text = "Nhập"
        Me.bntNhap.UseVisualStyleBackColor = True
        '
        'txtSoLuongTon
        '
        Me.txtSoLuongTon.Location = New System.Drawing.Point(368, 194)
        Me.txtSoLuongTon.Name = "txtSoLuongTon"
        Me.txtSoLuongTon.Size = New System.Drawing.Size(218, 22)
        Me.txtSoLuongTon.TabIndex = 5
        '
        'txtTenMH
        '
        Me.txtTenMH.Location = New System.Drawing.Point(368, 149)
        Me.txtTenMH.Name = "txtTenMH"
        Me.txtTenMH.Size = New System.Drawing.Size(218, 22)
        Me.txtTenMH.TabIndex = 3
        '
        'txtMaMH
        '
        Me.txtMaMH.Location = New System.Drawing.Point(368, 104)
        Me.txtMaMH.Name = "txtMaMH"
        Me.txtMaMH.ReadOnly = True
        Me.txtMaMH.Size = New System.Drawing.Size(218, 22)
        Me.txtMaMH.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(215, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Số Lượng Tồn"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(215, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tên Mặt Hàng"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(215, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Mặt Hàng"
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
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtSoLuongTon)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.txtMaMH)
        Me.GroupBox4.Controls.Add(Me.txtTenMH)
        Me.GroupBox4.Location = New System.Drawing.Point(29, 45)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(800, 323)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Thông Tin Chung"
        '
        'frmThemMatHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(858, 512)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Name = "frmThemMatHang"
        Me.Text = "frmThemMatHang"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bntNhapDong As Button
    Friend WithEvents bntNhap As Button
    Friend WithEvents txtSoLuongTon As TextBox
    Friend WithEvents txtTenMH As TextBox
    Friend WithEvents txtMaMH As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
End Class
