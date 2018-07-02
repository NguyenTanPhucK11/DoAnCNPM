<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemPhieuThu
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
        Me.cbxMaDL = New System.Windows.Forms.ComboBox()
        Me.txtSoTienThu = New System.Windows.Forms.TextBox()
        Me.txtMaPT = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpNgayThuTien = New System.Windows.Forms.DateTimePicker()
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
        'cbxMaDL
        '
        Me.cbxMaDL.FormattingEnabled = True
        Me.cbxMaDL.Location = New System.Drawing.Point(378, 133)
        Me.cbxMaDL.Name = "cbxMaDL"
        Me.cbxMaDL.Size = New System.Drawing.Size(227, 24)
        Me.cbxMaDL.TabIndex = 3
        '
        'txtSoTienThu
        '
        Me.txtSoTienThu.Location = New System.Drawing.Point(378, 216)
        Me.txtSoTienThu.Name = "txtSoTienThu"
        Me.txtSoTienThu.Size = New System.Drawing.Size(227, 22)
        Me.txtSoTienThu.TabIndex = 7
        '
        'txtMaPT
        '
        Me.txtMaPT.Location = New System.Drawing.Point(378, 90)
        Me.txtMaPT.Name = "txtMaPT"
        Me.txtMaPT.ReadOnly = True
        Me.txtMaPT.Size = New System.Drawing.Size(227, 22)
        Me.txtMaPT.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(196, 216)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Số Tiền Thu"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(196, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Ngày Thu Tiền"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(196, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Đại Lý"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(196, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Phiếu Thu Tiền"
        '
        'dtpNgayThuTien
        '
        Me.dtpNgayThuTien.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgayThuTien.Location = New System.Drawing.Point(378, 176)
        Me.dtpNgayThuTien.Name = "dtpNgayThuTien"
        Me.dtpNgayThuTien.Size = New System.Drawing.Size(227, 22)
        Me.dtpNgayThuTien.TabIndex = 5
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
        Me.GroupBox4.Controls.Add(Me.cbxMaDL)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.dtpNgayThuTien)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txtMaPT)
        Me.GroupBox4.Controls.Add(Me.txtSoTienThu)
        Me.GroupBox4.Location = New System.Drawing.Point(29, 45)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(800, 323)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Thông Tin Chung"
        '
        'frmThemPhieuThu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(858, 512)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Name = "frmThemPhieuThu"
        Me.Text = "frmThemPhieuThu"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bntNhapDong As Button
    Friend WithEvents bntNhap As Button
    Friend WithEvents cbxMaDL As ComboBox
    Friend WithEvents txtSoTienThu As TextBox
    Friend WithEvents txtMaPT As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpNgayThuTien As DateTimePicker
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
End Class
