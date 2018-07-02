<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQLLoaiDaiLy
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
        Me.txtTenLoaiDL = New System.Windows.Forms.TextBox()
        Me.txtMaLoaiDL = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvDanhSachLoaiDaiLy = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNoToiDa = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.bntXoa = New System.Windows.Forms.Button()
        Me.bntCapNhat = New System.Windows.Forms.Button()
        CType(Me.dgvDanhSachLoaiDaiLy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTenLoaiDL
        '
        Me.txtTenLoaiDL.Location = New System.Drawing.Point(368, 118)
        Me.txtTenLoaiDL.Name = "txtTenLoaiDL"
        Me.txtTenLoaiDL.Size = New System.Drawing.Size(218, 22)
        Me.txtTenLoaiDL.TabIndex = 3
        '
        'txtMaLoaiDL
        '
        Me.txtMaLoaiDL.Location = New System.Drawing.Point(368, 73)
        Me.txtMaLoaiDL.Name = "txtMaLoaiDL"
        Me.txtMaLoaiDL.ReadOnly = True
        Me.txtMaLoaiDL.Size = New System.Drawing.Size(218, 22)
        Me.txtMaLoaiDL.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(215, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tên Loại Đại Lý"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(215, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Loại Đại Lý"
        '
        'dgvDanhSachLoaiDaiLy
        '
        Me.dgvDanhSachLoaiDaiLy.AllowUserToAddRows = False
        Me.dgvDanhSachLoaiDaiLy.AllowUserToDeleteRows = False
        Me.dgvDanhSachLoaiDaiLy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDanhSachLoaiDaiLy.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDanhSachLoaiDaiLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachLoaiDaiLy.Location = New System.Drawing.Point(62, 23)
        Me.dgvDanhSachLoaiDaiLy.MultiSelect = False
        Me.dgvDanhSachLoaiDaiLy.Name = "dgvDanhSachLoaiDaiLy"
        Me.dgvDanhSachLoaiDaiLy.ReadOnly = True
        Me.dgvDanhSachLoaiDaiLy.RowHeadersVisible = False
        Me.dgvDanhSachLoaiDaiLy.RowTemplate.Height = 24
        Me.dgvDanhSachLoaiDaiLy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDanhSachLoaiDaiLy.Size = New System.Drawing.Size(677, 265)
        Me.dgvDanhSachLoaiDaiLy.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(215, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nợ Tối Đa"
        '
        'txtNoToiDa
        '
        Me.txtNoToiDa.Location = New System.Drawing.Point(368, 163)
        Me.txtNoToiDa.Name = "txtNoToiDa"
        Me.txtNoToiDa.Size = New System.Drawing.Size(218, 22)
        Me.txtNoToiDa.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNoToiDa)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtTenLoaiDL)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtMaLoaiDL)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(800, 253)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông Tin Chung"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvDanhSachLoaiDaiLy)
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
        'frmQLLoaiDaiLy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(858, 764)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmQLLoaiDaiLy"
        Me.Text = "frmQLLoaiDaiLy"
        CType(Me.dgvDanhSachLoaiDaiLy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtTenLoaiDL As TextBox
    Friend WithEvents txtMaLoaiDL As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDanhSachLoaiDaiLy As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNoToiDa As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents bntXoa As Button
    Friend WithEvents bntCapNhat As Button
End Class
