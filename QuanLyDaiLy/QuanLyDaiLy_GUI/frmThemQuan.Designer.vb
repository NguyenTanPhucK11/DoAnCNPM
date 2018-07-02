<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemQuan
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
        Me.txtTenQuan = New System.Windows.Forms.TextBox()
        Me.txtMaQuan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bntNhapDong = New System.Windows.Forms.Button()
        Me.bntNhap = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTenQuan
        '
        Me.txtTenQuan.Location = New System.Drawing.Point(368, 176)
        Me.txtTenQuan.Name = "txtTenQuan"
        Me.txtTenQuan.Size = New System.Drawing.Size(218, 22)
        Me.txtTenQuan.TabIndex = 3
        '
        'txtMaQuan
        '
        Me.txtMaQuan.Location = New System.Drawing.Point(368, 131)
        Me.txtMaQuan.Name = "txtMaQuan"
        Me.txtMaQuan.ReadOnly = True
        Me.txtMaQuan.Size = New System.Drawing.Size(218, 22)
        Me.txtMaQuan.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(215, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tên Quận"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(215, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Quận"
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
        Me.GroupBox4.Controls.Add(Me.txtTenQuan)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.txtMaQuan)
        Me.GroupBox4.Location = New System.Drawing.Point(29, 45)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(800, 323)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Thông Tin Chung"
        '
        'frmThemQuan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(858, 512)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Name = "frmThemQuan"
        Me.Text = "frmThemQuan"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtTenQuan As TextBox
    Friend WithEvents txtMaQuan As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents bntNhapDong As Button
    Friend WithEvents bntNhap As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
End Class
