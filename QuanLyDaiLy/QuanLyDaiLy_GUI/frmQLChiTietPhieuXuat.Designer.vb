<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLChiTietPhieuXuat
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
        Me.cbxMaDVT = New System.Windows.Forms.ComboBox()
        Me.cbxMaPX = New System.Windows.Forms.ComboBox()
        Me.cbxMaMH = New System.Windows.Forms.ComboBox()
        Me.txtThanhTien = New System.Windows.Forms.TextBox()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.txtSoLuongXuat = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtMaCTPX = New System.Windows.Forms.TextBox()
        Me.cbxMaMHCapNhat = New System.Windows.Forms.ComboBox()
        Me.cbxMaPXCapNhat = New System.Windows.Forms.ComboBox()
        Me.cbxMaDVTCapNhat = New System.Windows.Forms.ComboBox()
        Me.dgvListCTPX = New System.Windows.Forms.DataGridView()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvListCTPX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbxMaDVT
        '
        Me.cbxMaDVT.FormattingEnabled = True
        Me.cbxMaDVT.Location = New System.Drawing.Point(381, 36)
        Me.cbxMaDVT.Name = "cbxMaDVT"
        Me.cbxMaDVT.Size = New System.Drawing.Size(161, 24)
        Me.cbxMaDVT.TabIndex = 3
        '
        'cbxMaPX
        '
        Me.cbxMaPX.FormattingEnabled = True
        Me.cbxMaPX.Location = New System.Drawing.Point(125, 36)
        Me.cbxMaPX.Name = "cbxMaPX"
        Me.cbxMaPX.Size = New System.Drawing.Size(161, 24)
        Me.cbxMaPX.TabIndex = 1
        '
        'cbxMaMH
        '
        Me.cbxMaMH.FormattingEnabled = True
        Me.cbxMaMH.Location = New System.Drawing.Point(623, 36)
        Me.cbxMaMH.Name = "cbxMaMH"
        Me.cbxMaMH.Size = New System.Drawing.Size(159, 24)
        Me.cbxMaMH.TabIndex = 5
        '
        'txtThanhTien
        '
        Me.txtThanhTien.Location = New System.Drawing.Point(411, 161)
        Me.txtThanhTien.Name = "txtThanhTien"
        Me.txtThanhTien.Size = New System.Drawing.Size(161, 22)
        Me.txtThanhTien.TabIndex = 8
        '
        'txtDonGia
        '
        Me.txtDonGia.Location = New System.Drawing.Point(411, 119)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(161, 22)
        Me.txtDonGia.TabIndex = 6
        '
        'txtSoLuongXuat
        '
        Me.txtSoLuongXuat.Location = New System.Drawing.Point(411, 78)
        Me.txtSoLuongXuat.Name = "txtSoLuongXuat"
        Me.txtSoLuongXuat.Size = New System.Drawing.Size(161, 22)
        Me.txtSoLuongXuat.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(229, 161)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Thành Tiền"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(229, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Đơn Giá"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(229, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Số Lượng Xuất"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(293, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Đơn Vị Tính"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(548, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Mặt Hàng"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mã Phiếu Xuất"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(229, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Mã Chi Tiết Phiếu Xuất"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 209)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 17)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Mã Phiếu Xuất"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(549, 209)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 17)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Mặt Hàng"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(294, 209)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 17)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Đơn Vị Tính"
        '
        'txtMaCTPX
        '
        Me.txtMaCTPX.Location = New System.Drawing.Point(411, 33)
        Me.txtMaCTPX.Name = "txtMaCTPX"
        Me.txtMaCTPX.ReadOnly = True
        Me.txtMaCTPX.Size = New System.Drawing.Size(161, 22)
        Me.txtMaCTPX.TabIndex = 2
        '
        'cbxMaMHCapNhat
        '
        Me.cbxMaMHCapNhat.FormattingEnabled = True
        Me.cbxMaMHCapNhat.Location = New System.Drawing.Point(624, 206)
        Me.cbxMaMHCapNhat.Name = "cbxMaMHCapNhat"
        Me.cbxMaMHCapNhat.Size = New System.Drawing.Size(161, 24)
        Me.cbxMaMHCapNhat.TabIndex = 13
        '
        'cbxMaPXCapNhat
        '
        Me.cbxMaPXCapNhat.FormattingEnabled = True
        Me.cbxMaPXCapNhat.Location = New System.Drawing.Point(121, 206)
        Me.cbxMaPXCapNhat.Name = "cbxMaPXCapNhat"
        Me.cbxMaPXCapNhat.Size = New System.Drawing.Size(161, 24)
        Me.cbxMaPXCapNhat.TabIndex = 10
        '
        'cbxMaDVTCapNhat
        '
        Me.cbxMaDVTCapNhat.FormattingEnabled = True
        Me.cbxMaDVTCapNhat.Location = New System.Drawing.Point(382, 206)
        Me.cbxMaDVTCapNhat.Name = "cbxMaDVTCapNhat"
        Me.cbxMaDVTCapNhat.Size = New System.Drawing.Size(161, 24)
        Me.cbxMaDVTCapNhat.TabIndex = 12
        '
        'dgvListCTPX
        '
        Me.dgvListCTPX.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvListCTPX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListCTPX.Location = New System.Drawing.Point(62, 23)
        Me.dgvListCTPX.MultiSelect = False
        Me.dgvListCTPX.Name = "dgvListCTPX"
        Me.dgvListCTPX.ReadOnly = True
        Me.dgvListCTPX.RowHeadersVisible = False
        Me.dgvListCTPX.RowTemplate.Height = 24
        Me.dgvListCTPX.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListCTPX.Size = New System.Drawing.Size(677, 265)
        Me.dgvListCTPX.TabIndex = 0
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(437, 16)
        Me.btnXoa.Margin = New System.Windows.Forms.Padding(4)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(147, 51)
        Me.btnXoa.TabIndex = 1
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(215, 16)
        Me.btnCapNhat.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(149, 51)
        Me.btnCapNhat.TabIndex = 0
        Me.btnCapNhat.Text = "Cập nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbxMaDVT)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbxMaMH)
        Me.GroupBox1.Controls.Add(Me.cbxMaPX)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 273)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(800, 85)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tìm Kiếm"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvListCTPX)
        Me.GroupBox2.Location = New System.Drawing.Point(29, 364)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(800, 304)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kết Quả"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnXoa)
        Me.GroupBox3.Controls.Add(Me.btnCapNhat)
        Me.GroupBox3.Location = New System.Drawing.Point(29, 674)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(800, 77)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.cbxMaDVTCapNhat)
        Me.GroupBox4.Controls.Add(Me.cbxMaPXCapNhat)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.cbxMaMHCapNhat)
        Me.GroupBox4.Controls.Add(Me.txtSoLuongXuat)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.txtMaCTPX)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txtThanhTien)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.txtDonGia)
        Me.GroupBox4.Location = New System.Drawing.Point(29, 14)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(800, 253)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Thông Tin Chung"
        '
        'frmQLChiTietPhieuXuat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(858, 764)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmQLChiTietPhieuXuat"
        CType(Me.dgvListCTPX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbxMaDVT As ComboBox
    Friend WithEvents cbxMaPX As ComboBox
    Friend WithEvents cbxMaMH As ComboBox
    Friend WithEvents txtThanhTien As TextBox
    Friend WithEvents txtDonGia As TextBox
    Friend WithEvents txtSoLuongXuat As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtMaCTPX As TextBox
    Friend WithEvents cbxMaMHCapNhat As ComboBox
    Friend WithEvents cbxMaPXCapNhat As ComboBox
    Friend WithEvents cbxMaDVTCapNhat As ComboBox
    Friend WithEvents dgvListCTPX As DataGridView
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
End Class
