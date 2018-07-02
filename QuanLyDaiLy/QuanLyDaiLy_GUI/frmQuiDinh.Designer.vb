<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuiDinh
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
        Me.txtSoLuongLoaiDaiLy = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSoLuongDaiLyToiDa = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSoLuongMatHang = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSoLuongLoaiDaiLy
        '
        Me.txtSoLuongLoaiDaiLy.Location = New System.Drawing.Point(382, 74)
        Me.txtSoLuongLoaiDaiLy.Name = "txtSoLuongLoaiDaiLy"
        Me.txtSoLuongLoaiDaiLy.Size = New System.Drawing.Size(218, 22)
        Me.txtSoLuongLoaiDaiLy.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(201, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Số Lượng Loại Đại Lý"
        '
        'txtSoLuongDaiLyToiDa
        '
        Me.txtSoLuongDaiLyToiDa.Location = New System.Drawing.Point(382, 121)
        Me.txtSoLuongDaiLyToiDa.Name = "txtSoLuongDaiLyToiDa"
        Me.txtSoLuongDaiLyToiDa.Size = New System.Drawing.Size(218, 22)
        Me.txtSoLuongDaiLyToiDa.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(201, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Số Lượng Đại Lý Tối Đa"
        '
        'txtSoLuongMatHang
        '
        Me.txtSoLuongMatHang.Location = New System.Drawing.Point(382, 168)
        Me.txtSoLuongMatHang.Name = "txtSoLuongMatHang"
        Me.txtSoLuongMatHang.Size = New System.Drawing.Size(218, 22)
        Me.txtSoLuongMatHang.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(201, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Số Lượng Mặt Hàng"
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(326, 42)
        Me.btnCapNhat.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(149, 51)
        Me.btnCapNhat.TabIndex = 0
        Me.btnCapNhat.Text = "Cập Nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtSoLuongDaiLyToiDa)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.txtSoLuongMatHang)
        Me.GroupBox4.Controls.Add(Me.txtSoLuongLoaiDaiLy)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Location = New System.Drawing.Point(29, 179)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(800, 253)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Thông Tin Chung"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnCapNhat)
        Me.GroupBox3.Location = New System.Drawing.Point(29, 455)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(800, 131)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'frmQuiDinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(858, 764)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Name = "frmQuiDinh"
        Me.Text = "frmQuiDinh"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtSoLuongLoaiDaiLy As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSoLuongDaiLyToiDa As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSoLuongMatHang As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
End Class
