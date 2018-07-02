<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQLDonViTinh
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
        Me.dgvDanhSachDonViTinh = New System.Windows.Forms.DataGridView()
        Me.txtTenDVT = New System.Windows.Forms.TextBox()
        Me.txtMaDVT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.bntXoa = New System.Windows.Forms.Button()
        Me.bntCapNhat = New System.Windows.Forms.Button()
        CType(Me.dgvDanhSachDonViTinh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvDanhSachDonViTinh
        '
        Me.dgvDanhSachDonViTinh.AllowUserToAddRows = False
        Me.dgvDanhSachDonViTinh.AllowUserToDeleteRows = False
        Me.dgvDanhSachDonViTinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDanhSachDonViTinh.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDanhSachDonViTinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachDonViTinh.Location = New System.Drawing.Point(62, 23)
        Me.dgvDanhSachDonViTinh.MultiSelect = False
        Me.dgvDanhSachDonViTinh.Name = "dgvDanhSachDonViTinh"
        Me.dgvDanhSachDonViTinh.ReadOnly = True
        Me.dgvDanhSachDonViTinh.RowHeadersVisible = False
        Me.dgvDanhSachDonViTinh.RowTemplate.Height = 24
        Me.dgvDanhSachDonViTinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDanhSachDonViTinh.Size = New System.Drawing.Size(677, 265)
        Me.dgvDanhSachDonViTinh.TabIndex = 0
        '
        'txtTenDVT
        '
        Me.txtTenDVT.Location = New System.Drawing.Point(368, 145)
        Me.txtTenDVT.Name = "txtTenDVT"
        Me.txtTenDVT.Size = New System.Drawing.Size(218, 22)
        Me.txtTenDVT.TabIndex = 3
        '
        'txtMaDVT
        '
        Me.txtMaDVT.Location = New System.Drawing.Point(368, 100)
        Me.txtMaDVT.Name = "txtMaDVT"
        Me.txtMaDVT.ReadOnly = True
        Me.txtMaDVT.Size = New System.Drawing.Size(218, 22)
        Me.txtMaDVT.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(215, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tên Đơn Vị Tính"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(215, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Đơn Vị Tính"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMaDVT)
        Me.GroupBox1.Controls.Add(Me.txtTenDVT)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(800, 253)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông Tin Chung"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvDanhSachDonViTinh)
        Me.GroupBox2.Location = New System.Drawing.Point(29, 317)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(800, 304)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kết Quả"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.bntXoa)
        Me.GroupBox3.Controls.Add(Me.bntCapNhat)
        Me.GroupBox3.Location = New System.Drawing.Point(29, 637)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(800, 77)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'bntXoa
        '
        Me.bntXoa.Location = New System.Drawing.Point(437, 16)
        Me.bntXoa.Margin = New System.Windows.Forms.Padding(4)
        Me.bntXoa.Name = "bntXoa"
        Me.bntXoa.Size = New System.Drawing.Size(147, 51)
        Me.bntXoa.TabIndex = 1
        Me.bntXoa.Text = "Xóa"
        Me.bntXoa.UseVisualStyleBackColor = True
        '
        'bntCapNhat
        '
        Me.bntCapNhat.Location = New System.Drawing.Point(215, 16)
        Me.bntCapNhat.Margin = New System.Windows.Forms.Padding(4)
        Me.bntCapNhat.Name = "bntCapNhat"
        Me.bntCapNhat.Size = New System.Drawing.Size(149, 51)
        Me.bntCapNhat.TabIndex = 0
        Me.bntCapNhat.Text = "Cập nhật"
        Me.bntCapNhat.UseVisualStyleBackColor = True
        '
        'frmQLDonViTinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(858, 764)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmQLDonViTinh"
        Me.Text = "QLDonViTinh"
        CType(Me.dgvDanhSachDonViTinh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvDanhSachDonViTinh As DataGridView
    Friend WithEvents txtTenDVT As TextBox
    Friend WithEvents txtMaDVT As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents bntXoa As Button
    Friend WithEvents bntCapNhat As Button
End Class
