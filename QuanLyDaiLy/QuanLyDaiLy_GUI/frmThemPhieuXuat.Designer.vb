<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemPhieuXuat
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
        Me.cBxMaDL = New System.Windows.Forms.ComboBox()
        Me.dtpNgayLapPhieu = New System.Windows.Forms.DateTimePicker()
        Me.txtMaPX = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
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
        'cBxMaDL
        '
        Me.cBxMaDL.FormattingEnabled = True
        Me.cBxMaDL.Location = New System.Drawing.Point(363, 148)
        Me.cBxMaDL.Name = "cBxMaDL"
        Me.cBxMaDL.Size = New System.Drawing.Size(227, 24)
        Me.cBxMaDL.TabIndex = 3
        '
        'dtpNgayLapPhieu
        '
        Me.dtpNgayLapPhieu.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgayLapPhieu.Location = New System.Drawing.Point(363, 188)
        Me.dtpNgayLapPhieu.Name = "dtpNgayLapPhieu"
        Me.dtpNgayLapPhieu.Size = New System.Drawing.Size(227, 22)
        Me.dtpNgayLapPhieu.TabIndex = 5
        '
        'txtMaPX
        '
        Me.txtMaPX.Location = New System.Drawing.Point(363, 111)
        Me.txtMaPX.Name = "txtMaPX"
        Me.txtMaPX.ReadOnly = True
        Me.txtMaPX.Size = New System.Drawing.Size(227, 22)
        Me.txtMaPX.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(210, 193)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 17)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Ngày Lập Phiếu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(210, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Đại Lý"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(210, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Phiếu Xuất"
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
        Me.GroupBox4.Controls.Add(Me.dtpNgayLapPhieu)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.cBxMaDL)
        Me.GroupBox4.Controls.Add(Me.txtMaPX)
        Me.GroupBox4.Location = New System.Drawing.Point(29, 45)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(800, 323)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Thông Tin Chung"
        '
        'frmThemPhieuXuat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(858, 512)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Name = "frmThemPhieuXuat"
        Me.Text = "frmThemPhieuXuat"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bntNhapDong As Button
    Friend WithEvents bntNhap As Button
    Friend WithEvents cBxMaDL As ComboBox
    Friend WithEvents dtpNgayLapPhieu As DateTimePicker
    Friend WithEvents txtMaPX As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
End Class
