<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQLPhieuXuat
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
        Me.cBxMaDLCapNhat = New System.Windows.Forms.ComboBox()
        Me.dtpNgayLapPhieu = New System.Windows.Forms.DateTimePicker()
        Me.txtMaPX = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvListPX = New System.Windows.Forms.DataGridView()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cBxMaDL = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvListPX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cBxMaDLCapNhat
        '
        Me.cBxMaDLCapNhat.FormattingEnabled = True
        Me.cBxMaDLCapNhat.Location = New System.Drawing.Point(363, 119)
        Me.cBxMaDLCapNhat.Name = "cBxMaDLCapNhat"
        Me.cBxMaDLCapNhat.Size = New System.Drawing.Size(227, 24)
        Me.cBxMaDLCapNhat.TabIndex = 3
        '
        'dtpNgayLapPhieu
        '
        Me.dtpNgayLapPhieu.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgayLapPhieu.Location = New System.Drawing.Point(363, 159)
        Me.dtpNgayLapPhieu.Name = "dtpNgayLapPhieu"
        Me.dtpNgayLapPhieu.Size = New System.Drawing.Size(227, 22)
        Me.dtpNgayLapPhieu.TabIndex = 5
        '
        'txtMaPX
        '
        Me.txtMaPX.Location = New System.Drawing.Point(363, 82)
        Me.txtMaPX.Name = "txtMaPX"
        Me.txtMaPX.ReadOnly = True
        Me.txtMaPX.Size = New System.Drawing.Size(227, 22)
        Me.txtMaPX.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(210, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 17)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Ngày Lập Phiếu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(212, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Đại Lý"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(210, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Phiếu Xuất"
        '
        'dgvListPX
        '
        Me.dgvListPX.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvListPX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListPX.Location = New System.Drawing.Point(62, 23)
        Me.dgvListPX.MultiSelect = False
        Me.dgvListPX.Name = "dgvListPX"
        Me.dgvListPX.ReadOnly = True
        Me.dgvListPX.RowHeadersVisible = False
        Me.dgvListPX.RowTemplate.Height = 24
        Me.dgvListPX.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListPX.Size = New System.Drawing.Size(677, 265)
        Me.dgvListPX.TabIndex = 0
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(245, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Đại Lý"
        '
        'cBxMaDL
        '
        Me.cBxMaDL.FormattingEnabled = True
        Me.cBxMaDL.Location = New System.Drawing.Point(329, 36)
        Me.cBxMaDL.Name = "cBxMaDL"
        Me.cBxMaDL.Size = New System.Drawing.Size(227, 24)
        Me.cBxMaDL.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dtpNgayLapPhieu)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.txtMaPX)
        Me.GroupBox4.Controls.Add(Me.cBxMaDLCapNhat)
        Me.GroupBox4.Location = New System.Drawing.Point(29, 14)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(800, 253)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Thông Tin Chung"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cBxMaDL)
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
        Me.GroupBox2.Controls.Add(Me.dgvListPX)
        Me.GroupBox2.Location = New System.Drawing.Point(29, 364)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(800, 304)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kết Quả"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnCapNhat)
        Me.GroupBox3.Controls.Add(Me.btnXoa)
        Me.GroupBox3.Location = New System.Drawing.Point(29, 674)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(800, 77)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'frmQLPhieuXuat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(858, 764)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Name = "frmQLPhieuXuat"
        Me.Text = "frmQLPhieuXuat"
        CType(Me.dgvListPX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cBxMaDLCapNhat As ComboBox
    Friend WithEvents dtpNgayLapPhieu As DateTimePicker
    Friend WithEvents txtMaPX As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvListPX As DataGridView
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cBxMaDL As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
End Class
