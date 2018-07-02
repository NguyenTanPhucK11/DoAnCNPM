Imports System.Data.SqlClient
Imports QuanLyDaiLy_BUS
Imports QuanLyDaiLy_DTO
Imports Utility
Public Class frmTraCuuDaiLy
    Private dlBus As DaiLy_BUS
    Private Sub LoadListTenDaiLy(tendl As String)
        Dim listDaiLy = New List(Of DaiLyDisplay)
        Dim result As Result
        result = dlBus.selectALL_ByTenDaiLy(tendl, listDaiLy)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Đại Lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListDL.SuspendLayout()
        dgvListDL.Columns.Clear()
        dgvListDL.DataSource = Nothing

        dgvListDL.AutoGenerateColumns = False
        dgvListDL.AllowUserToAddRows = False
        dgvListDL.DataSource = listDaiLy

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "MaDaiLy"
        clMa.HeaderText = "Mã Đại Lý"
        clMa.DataPropertyName = "MaDaiLy"
        dgvListDL.Columns.Add(clMa)

        Dim clTenDaiLy = New DataGridViewTextBoxColumn()
        clTenDaiLy.Name = "TenDaiLy"
        clTenDaiLy.HeaderText = "Tên Đại Lý"
        clTenDaiLy.DataPropertyName = "TenDaiLy"
        dgvListDL.Columns.Add(clTenDaiLy)

        Dim clTenLDL = New DataGridViewTextBoxColumn()
        clTenLDL.Name = "TenLoaiDaiLy"
        clTenLDL.HeaderText = "Tên Loại Đại Lý"
        clTenLDL.DataPropertyName = "TenLoaiDaiLy"
        dgvListDL.Columns.Add(clTenLDL)

        Dim clTenQuan = New DataGridViewTextBoxColumn()
        clTenQuan.Name = "TenQuan"
        clTenQuan.HeaderText = "Tên Quận"
        clTenQuan.DataPropertyName = "TenQuan"
        dgvListDL.Columns.Add(clTenQuan)

        Dim clDienThoai = New DataGridViewTextBoxColumn()
        clDienThoai.Name = "DienThoai"
        clDienThoai.HeaderText = "Điện Thoại"
        clDienThoai.DataPropertyName = "DienThoai"
        dgvListDL.Columns.Add(clDienThoai)

        Dim clDiaChi = New DataGridViewTextBoxColumn()
        clDiaChi.Name = "DiaChi"
        clDiaChi.HeaderText = "Địa Chỉ"
        clDiaChi.DataPropertyName = "DiaChi"
        dgvListDL.Columns.Add(clDiaChi)

        Dim clNgayTiepNhan = New DataGridViewTextBoxColumn()
        clNgayTiepNhan.Name = "NgayTiepNhan"
        clNgayTiepNhan.HeaderText = "Ngày Tiếp Nhận"
        clNgayTiepNhan.DataPropertyName = "NgayTiepNhan"
        dgvListDL.Columns.Add(clNgayTiepNhan)

        Dim clEmail = New DataGridViewTextBoxColumn()
        clEmail.Name = "Email"
        clEmail.HeaderText = "Email"
        clEmail.DataPropertyName = "Email"
        dgvListDL.Columns.Add(clEmail)

        Dim clNoCuaDaiLy = New DataGridViewTextBoxColumn()
        clNoCuaDaiLy.Name = "NoCuaDaiLy"
        clNoCuaDaiLy.HeaderText = "Nợ Của Đại Lý"
        clNoCuaDaiLy.DataPropertyName = "NoCuaDaiLy"
        dgvListDL.Columns.Add(clNoCuaDaiLy)
        'dgvListDL.ResumeLayout()
    End Sub
    Private Sub LoadListTenQuan(tenq As String)
        Dim listDaiLy = New List(Of DaiLyDisplay)
        Dim result As Result
        result = dlBus.selectALL_ByTenQuan(tenq, listDaiLy)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Đại Lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListDL.SuspendLayout()
        dgvListDL.Columns.Clear()
        dgvListDL.DataSource = Nothing

        dgvListDL.AutoGenerateColumns = False
        dgvListDL.AllowUserToAddRows = False
        dgvListDL.DataSource = listDaiLy

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "MaDaiLy"
        clMa.HeaderText = "Mã Đại Lý"
        clMa.DataPropertyName = "MaDaiLy"
        dgvListDL.Columns.Add(clMa)

        Dim clTenDaiLy = New DataGridViewTextBoxColumn()
        clTenDaiLy.Name = "TenDaiLy"
        clTenDaiLy.HeaderText = "Tên Đại Lý"
        clTenDaiLy.DataPropertyName = "TenDaiLy"
        dgvListDL.Columns.Add(clTenDaiLy)

        Dim clTenLDL = New DataGridViewTextBoxColumn()
        clTenLDL.Name = "TenLoaiDaiLy"
        clTenLDL.HeaderText = "Tên Loại Đại Lý"
        clTenLDL.DataPropertyName = "TenLoaiDaiLy"
        dgvListDL.Columns.Add(clTenLDL)

        Dim clTenQuan = New DataGridViewTextBoxColumn()
        clTenQuan.Name = "TenQuan"
        clTenQuan.HeaderText = "Tên Quận"
        clTenQuan.DataPropertyName = "TenQuan"
        dgvListDL.Columns.Add(clTenQuan)

        Dim clDienThoai = New DataGridViewTextBoxColumn()
        clDienThoai.Name = "DienThoai"
        clDienThoai.HeaderText = "Điện Thoại"
        clDienThoai.DataPropertyName = "DienThoai"
        dgvListDL.Columns.Add(clDienThoai)

        Dim clDiaChi = New DataGridViewTextBoxColumn()
        clDiaChi.Name = "DiaChi"
        clDiaChi.HeaderText = "Địa Chỉ"
        clDiaChi.DataPropertyName = "DiaChi"
        dgvListDL.Columns.Add(clDiaChi)

        Dim clNgayTiepNhan = New DataGridViewTextBoxColumn()
        clNgayTiepNhan.Name = "NgayTiepNhan"
        clNgayTiepNhan.HeaderText = "Ngày Tiếp Nhận"
        clNgayTiepNhan.DataPropertyName = "NgayTiepNhan"
        dgvListDL.Columns.Add(clNgayTiepNhan)

        Dim clEmail = New DataGridViewTextBoxColumn()
        clEmail.Name = "Email"
        clEmail.HeaderText = "Email"
        clEmail.DataPropertyName = "Email"
        dgvListDL.Columns.Add(clEmail)

        Dim clNoCuaDaiLy = New DataGridViewTextBoxColumn()
        clNoCuaDaiLy.Name = "NoCuaDaiLy"
        clNoCuaDaiLy.HeaderText = "Nợ Của Đại Lý"
        clNoCuaDaiLy.DataPropertyName = "NoCuaDaiLy"
        dgvListDL.Columns.Add(clNoCuaDaiLy)
        'dgvListDL.ResumeLayout()
    End Sub
    Private Sub LoadListTenLDL(tenldl As String)
        Dim listDaiLy = New List(Of DaiLyDisplay)
        Dim result As Result
        result = dlBus.selectALL_ByTenLoaiDL(tenldl, listDaiLy)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Đại Lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListDL.SuspendLayout()
        dgvListDL.Columns.Clear()
        dgvListDL.DataSource = Nothing

        dgvListDL.AutoGenerateColumns = False
        dgvListDL.AllowUserToAddRows = False
        dgvListDL.DataSource = listDaiLy

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "MaDaiLy"
        clMa.HeaderText = "Mã Đại Lý"
        clMa.DataPropertyName = "MaDaiLy"
        dgvListDL.Columns.Add(clMa)

        Dim clTenDaiLy = New DataGridViewTextBoxColumn()
        clTenDaiLy.Name = "TenDaiLy"
        clTenDaiLy.HeaderText = "Tên Đại Lý"
        clTenDaiLy.DataPropertyName = "TenDaiLy"
        dgvListDL.Columns.Add(clTenDaiLy)

        Dim clTenLDL = New DataGridViewTextBoxColumn()
        clTenLDL.Name = "TenLoaiDaiLy"
        clTenLDL.HeaderText = "Tên Loại Đại Lý"
        clTenLDL.DataPropertyName = "TenLoaiDaiLy"
        dgvListDL.Columns.Add(clTenLDL)

        Dim clTenQuan = New DataGridViewTextBoxColumn()
        clTenQuan.Name = "TenQuan"
        clTenQuan.HeaderText = "Tên Quận"
        clTenQuan.DataPropertyName = "TenQuan"
        dgvListDL.Columns.Add(clTenQuan)

        Dim clDienThoai = New DataGridViewTextBoxColumn()
        clDienThoai.Name = "DienThoai"
        clDienThoai.HeaderText = "Điện Thoại"
        clDienThoai.DataPropertyName = "DienThoai"
        dgvListDL.Columns.Add(clDienThoai)

        Dim clDiaChi = New DataGridViewTextBoxColumn()
        clDiaChi.Name = "DiaChi"
        clDiaChi.HeaderText = "Địa Chỉ"
        clDiaChi.DataPropertyName = "DiaChi"
        dgvListDL.Columns.Add(clDiaChi)

        Dim clNgayTiepNhan = New DataGridViewTextBoxColumn()
        clNgayTiepNhan.Name = "NgayTiepNhan"
        clNgayTiepNhan.HeaderText = "Ngày Tiếp Nhận"
        clNgayTiepNhan.DataPropertyName = "NgayTiepNhan"
        dgvListDL.Columns.Add(clNgayTiepNhan)

        Dim clEmail = New DataGridViewTextBoxColumn()
        clEmail.Name = "Email"
        clEmail.HeaderText = "Email"
        clEmail.DataPropertyName = "Email"
        dgvListDL.Columns.Add(clEmail)

        Dim clNoCuaDaiLy = New DataGridViewTextBoxColumn()
        clNoCuaDaiLy.Name = "NoCuaDaiLy"
        clNoCuaDaiLy.HeaderText = "Nợ Của Đại Lý"
        clNoCuaDaiLy.DataPropertyName = "NoCuaDaiLy"
        dgvListDL.Columns.Add(clNoCuaDaiLy)
        'dgvListDL.ResumeLayout()
    End Sub
    Private Sub LoadListTienNo(tien As Integer)
        Dim listDaiLy = New List(Of DaiLyDisplay)
        Dim result As Result
        result = dlBus.selectALL_ByTienNo(tien, listDaiLy)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Đại Lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListDL.SuspendLayout()
        dgvListDL.Columns.Clear()
        dgvListDL.DataSource = Nothing

        dgvListDL.AutoGenerateColumns = False
        dgvListDL.AllowUserToAddRows = False
        dgvListDL.DataSource = listDaiLy

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "MaDaiLy"
        clMa.HeaderText = "Mã Đại Lý"
        clMa.DataPropertyName = "MaDaiLy"
        dgvListDL.Columns.Add(clMa)

        Dim clTenDaiLy = New DataGridViewTextBoxColumn()
        clTenDaiLy.Name = "TenDaiLy"
        clTenDaiLy.HeaderText = "Tên Đại Lý"
        clTenDaiLy.DataPropertyName = "TenDaiLy"
        dgvListDL.Columns.Add(clTenDaiLy)

        Dim clTenLDL = New DataGridViewTextBoxColumn()
        clTenLDL.Name = "TenLoaiDaiLy"
        clTenLDL.HeaderText = "Tên Loại Đại Lý"
        clTenLDL.DataPropertyName = "TenLoaiDaiLy"
        dgvListDL.Columns.Add(clTenLDL)

        Dim clTenQuan = New DataGridViewTextBoxColumn()
        clTenQuan.Name = "TenQuan"
        clTenQuan.HeaderText = "Tên Quận"
        clTenQuan.DataPropertyName = "TenQuan"
        dgvListDL.Columns.Add(clTenQuan)

        Dim clDienThoai = New DataGridViewTextBoxColumn()
        clDienThoai.Name = "DienThoai"
        clDienThoai.HeaderText = "Điện Thoại"
        clDienThoai.DataPropertyName = "DienThoai"
        dgvListDL.Columns.Add(clDienThoai)

        Dim clDiaChi = New DataGridViewTextBoxColumn()
        clDiaChi.Name = "DiaChi"
        clDiaChi.HeaderText = "Địa Chỉ"
        clDiaChi.DataPropertyName = "DiaChi"
        dgvListDL.Columns.Add(clDiaChi)

        Dim clNgayTiepNhan = New DataGridViewTextBoxColumn()
        clNgayTiepNhan.Name = "NgayTiepNhan"
        clNgayTiepNhan.HeaderText = "Ngày Tiếp Nhận"
        clNgayTiepNhan.DataPropertyName = "NgayTiepNhan"
        dgvListDL.Columns.Add(clNgayTiepNhan)

        Dim clEmail = New DataGridViewTextBoxColumn()
        clEmail.Name = "Email"
        clEmail.HeaderText = "Email"
        clEmail.DataPropertyName = "Email"
        dgvListDL.Columns.Add(clEmail)

        Dim clNoCuaDaiLy = New DataGridViewTextBoxColumn()
        clNoCuaDaiLy.Name = "NoCuaDaiLy"
        clNoCuaDaiLy.HeaderText = "Nợ Của Đại Lý"
        clNoCuaDaiLy.DataPropertyName = "NoCuaDaiLy"
        dgvListDL.Columns.Add(clNoCuaDaiLy)
    End Sub
    Private Sub frmTraCuuDaiLy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dlBus = New DaiLy_BUS()
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If (cbxSearch.Text = "Tên Đại Lý") Then
            LoadListTenDaiLy(txtSearch.Text)
        End If
        If (cbxSearch.Text = "Tên Quận") Then
            LoadListTenQuan(txtSearch.Text)
        End If
        If (cbxSearch.Text = "Tên Loại Đại Lý") Then
            LoadListTenLDL(txtSearch.Text)
        End If
        If (cbxSearch.Text = "Tiền Nợ") Then
            LoadListTienNo(txtSearch.Text)
        End If
    End Sub
End Class