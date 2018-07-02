<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQLDaiLy
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cbxQuanCapNhat = New System.Windows.Forms.ComboBox()
        Me.cBxLoaiDLCapNhat = New System.Windows.Forms.ComboBox()
        Me.dtpNgayTiepNhan = New System.Windows.Forms.DateTimePicker()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.txtDienThoai = New System.Windows.Forms.TextBox()
        Me.txtTenDL = New System.Windows.Forms.TextBox()
        Me.txtMaDL = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.cbxLoaiDL = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbxQuan = New System.Windows.Forms.ComboBox()
        Me.dgvListDL = New System.Windows.Forms.DataGridView()
        Me.txtNoCuaDaiLy = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvListDL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbxQuanCapNhat
        '
        Me.cbxQuanCapNhat.FormattingEnabled = True
        Me.cbxQuanCapNhat.Location = New System.Drawing.Point(154, 208)
        Me.cbxQuanCapNhat.Name = "cbxQuanCapNhat"
        Me.cbxQuanCapNhat.Size = New System.Drawing.Size(204, 24)
        Me.cbxQuanCapNhat.TabIndex = 15
        '
        'cBxLoaiDLCapNhat
        '
        Me.cBxLoaiDLCapNhat.FormattingEnabled = True
        Me.cBxLoaiDLCapNhat.Location = New System.Drawing.Point(581, 208)
        Me.cBxLoaiDLCapNhat.Name = "cBxLoaiDLCapNhat"
        Me.cBxLoaiDLCapNhat.Size = New System.Drawing.Size(204, 24)
        Me.cBxLoaiDLCapNhat.TabIndex = 17
        '
        'dtpNgayTiepNhan
        '
        Me.dtpNgayTiepNhan.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgayTiepNhan.Location = New System.Drawing.Point(581, 165)
        Me.dtpNgayTiepNhan.Name = "dtpNgayTiepNhan"
        Me.dtpNgayTiepNhan.Size = New System.Drawing.Size(204, 22)
        Me.dtpNgayTiepNhan.TabIndex = 13
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(581, 122)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(204, 22)
        Me.txtEmail.TabIndex = 9
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(581, 79)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(204, 22)
        Me.txtDiaChi.TabIndex = 5
        '
        'txtDienThoai
        '
        Me.txtDienThoai.Location = New System.Drawing.Point(154, 122)
        Me.txtDienThoai.Name = "txtDienThoai"
        Me.txtDienThoai.Size = New System.Drawing.Size(204, 22)
        Me.txtDienThoai.TabIndex = 7
        '
        'txtTenDL
        '
        Me.txtTenDL.Location = New System.Drawing.Point(154, 79)
        Me.txtTenDL.Name = "txtTenDL"
        Me.txtTenDL.Size = New System.Drawing.Size(204, 22)
        Me.txtTenDL.TabIndex = 3
        '
        'txtMaDL
        '
        Me.txtMaDL.Location = New System.Drawing.Point(358, 33)
        Me.txtMaDL.Name = "txtMaDL"
        Me.txtMaDL.ReadOnly = True
        Me.txtMaDL.Size = New System.Drawing.Size(204, 22)
        Me.txtMaDL.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(421, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Email"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(421, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Ngày Tiếp Nhận"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Quận"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(421, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Địa Chỉ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Điện Thoại"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(421, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Loại Đại Lý"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tên Đại Lý"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(238, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Đại Lý"
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
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(437, 16)
        Me.btnXoa.Margin = New System.Windows.Forms.Padding(4)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(149, 51)
        Me.btnXoa.TabIndex = 1
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'cbxLoaiDL
        '
        Me.cbxLoaiDL.FormattingEnabled = True
        Me.cbxLoaiDL.Location = New System.Drawing.Point(186, 33)
        Me.cbxLoaiDL.Name = "cbxLoaiDL"
        Me.cbxLoaiDL.Size = New System.Drawing.Size(204, 24)
        Me.cbxLoaiDL.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(81, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Loại Đại Lý"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(443, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 17)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Quận"
        '
        'cbxQuan
        '
        Me.cbxQuan.FormattingEnabled = True
        Me.cbxQuan.Location = New System.Drawing.Point(516, 33)
        Me.cbxQuan.Name = "cbxQuan"
        Me.cbxQuan.Size = New System.Drawing.Size(204, 24)
        Me.cbxQuan.TabIndex = 3
        '
        'dgvListDL
        '
        Me.dgvListDL.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvListDL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListDL.Location = New System.Drawing.Point(62, 23)
        Me.dgvListDL.MultiSelect = False
        Me.dgvListDL.Name = "dgvListDL"
        Me.dgvListDL.ReadOnly = True
        Me.dgvListDL.RowHeadersVisible = False
        Me.dgvListDL.RowTemplate.Height = 24
        Me.dgvListDL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListDL.Size = New System.Drawing.Size(677, 265)
        Me.dgvListDL.TabIndex = 0
        '
        'txtNoCuaDaiLy
        '
        Me.txtNoCuaDaiLy.Location = New System.Drawing.Point(154, 165)
        Me.txtNoCuaDaiLy.Name = "txtNoCuaDaiLy"
        Me.txtNoCuaDaiLy.Size = New System.Drawing.Size(204, 22)
        Me.txtNoCuaDaiLy.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 168)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 17)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Tiền Nợ"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(82, 1186)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(204, 24)
        Me.ComboBox1.TabIndex = 19
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNoCuaDaiLy)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtMaDL)
        Me.GroupBox1.Controls.Add(Me.txtTenDL)
        Me.GroupBox1.Controls.Add(Me.txtDienThoai)
        Me.GroupBox1.Controls.Add(Me.cbxQuanCapNhat)
        Me.GroupBox1.Controls.Add(Me.cBxLoaiDLCapNhat)
        Me.GroupBox1.Controls.Add(Me.txtDiaChi)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.dtpNgayTiepNhan)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(800, 253)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông Tin Chung"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbxLoaiDL)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.cbxQuan)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(29, 273)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(800, 85)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tìm Kiếm"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvListDL)
        Me.GroupBox3.Location = New System.Drawing.Point(29, 364)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(800, 304)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Kết Quả"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnXoa)
        Me.GroupBox4.Controls.Add(Me.btnCapNhat)
        Me.GroupBox4.Location = New System.Drawing.Point(29, 674)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(800, 77)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'frmQLDaiLy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(858, 764)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "frmQLDaiLy"
        Me.Text = "frmQLDaiLy"
        CType(Me.dgvListDL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbxQuanCapNhat As ComboBox
    Friend WithEvents cBxLoaiDLCapNhat As ComboBox
    Friend WithEvents dtpNgayTiepNhan As DateTimePicker
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents txtDienThoai As TextBox
    Friend WithEvents txtTenDL As TextBox
    Friend WithEvents txtMaDL As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents cbxLoaiDL As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cbxQuan As ComboBox
    Friend WithEvents dgvListDL As DataGridView
    Friend WithEvents txtNoCuaDaiLy As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
End Class
