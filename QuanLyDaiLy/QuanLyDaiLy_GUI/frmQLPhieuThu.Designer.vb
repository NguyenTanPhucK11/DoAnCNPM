<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLPhieuThu
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
        Me.dtpNgayThuTien = New System.Windows.Forms.DateTimePicker()
        Me.cbxMaDL = New System.Windows.Forms.ComboBox()
        Me.txtSoTienThu = New System.Windows.Forms.TextBox()
        Me.txtMaPT = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxMaDLCapNhat = New System.Windows.Forms.ComboBox()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.dgvListPT = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvListPT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpNgayThuTien
        '
        Me.dtpNgayThuTien.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgayThuTien.Location = New System.Drawing.Point(378, 141)
        Me.dtpNgayThuTien.Name = "dtpNgayThuTien"
        Me.dtpNgayThuTien.Size = New System.Drawing.Size(227, 22)
        Me.dtpNgayThuTien.TabIndex = 5
        '
        'cbxMaDL
        '
        Me.cbxMaDL.FormattingEnabled = True
        Me.cbxMaDL.Location = New System.Drawing.Point(332, 35)
        Me.cbxMaDL.Name = "cbxMaDL"
        Me.cbxMaDL.Size = New System.Drawing.Size(227, 24)
        Me.cbxMaDL.TabIndex = 1
        '
        'txtSoTienThu
        '
        Me.txtSoTienThu.Location = New System.Drawing.Point(378, 181)
        Me.txtSoTienThu.Name = "txtSoTienThu"
        Me.txtSoTienThu.Size = New System.Drawing.Size(227, 22)
        Me.txtSoTienThu.TabIndex = 7
        '
        'txtMaPT
        '
        Me.txtMaPT.Location = New System.Drawing.Point(378, 55)
        Me.txtMaPT.Name = "txtMaPT"
        Me.txtMaPT.ReadOnly = True
        Me.txtMaPT.Size = New System.Drawing.Size(227, 22)
        Me.txtMaPT.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(196, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Số Tiền Thu"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(196, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Ngày Thu Tiền"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(241, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Đại Lý"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(196, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Phiếu Thu Tiền"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(196, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Đại Lý"
        '
        'cbxMaDLCapNhat
        '
        Me.cbxMaDLCapNhat.FormattingEnabled = True
        Me.cbxMaDLCapNhat.Location = New System.Drawing.Point(378, 97)
        Me.cbxMaDLCapNhat.Name = "cbxMaDLCapNhat"
        Me.cbxMaDLCapNhat.Size = New System.Drawing.Size(227, 24)
        Me.cbxMaDLCapNhat.TabIndex = 3
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
        'dgvListPT
        '
        Me.dgvListPT.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvListPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListPT.Location = New System.Drawing.Point(62, 23)
        Me.dgvListPT.MultiSelect = False
        Me.dgvListPT.Name = "dgvListPT"
        Me.dgvListPT.ReadOnly = True
        Me.dgvListPT.RowHeadersVisible = False
        Me.dgvListPT.RowTemplate.Height = 24
        Me.dgvListPT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListPT.Size = New System.Drawing.Size(677, 265)
        Me.dgvListPT.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtSoTienThu)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txtMaPT)
        Me.GroupBox4.Controls.Add(Me.dtpNgayThuTien)
        Me.GroupBox4.Controls.Add(Me.cbxMaDLCapNhat)
        Me.GroupBox4.Location = New System.Drawing.Point(29, 14)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(800, 253)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Thông Tin Chung"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbxMaDL)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 273)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(800, 85)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tìm Kiếm"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvListPT)
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
        'frmQLPhieuThu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(858, 764)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Name = "frmQLPhieuThu"
        Me.Text = "frmQLPhieuThu"
        CType(Me.dgvListPT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtpNgayThuTien As DateTimePicker
    Friend WithEvents cbxMaDL As ComboBox
    Friend WithEvents txtSoTienThu As TextBox
    Friend WithEvents txtMaPT As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbxMaDLCapNhat As ComboBox
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents dgvListPT As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
End Class
