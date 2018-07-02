Imports QuanLyDaiLy_BUS
Imports QuanLyDaiLy_DTO
Imports Utility

Public Class frmThemDaiLy
    Private dlBus As DaiLy_BUS
    Private ldlBUS As LoaiDaiLy_BUS
    Private qBUS As Quan_BUS
    Private qdBUS As QuiDinh_BUS
    Private quidinh As QuiDinh_DTO
    Private Sub bntNhap_Click(sender As Object, e As EventArgs) Handles bntNhap.Click

        Dim daily As DaiLy_DTO
        daily = New DaiLy_DTO()
        Dim listdaiLy As List(Of DaiLy_DTO)
        listdaiLy = New List(Of DaiLy_DTO)

        '1. Mapping data from GUI control
        daily.MaDaiLy = txtMaDL.Text
        daily.TenDaiLy = txtTenDL.Text
        daily.DienThoai = txtDienThoai.Text
        daily.DiaChi = txtDiaChi.Text
        daily.NgayTiepNhan = dtpNgayTiepNhan.Value
        daily.Email = txtEmail.Text
        daily.NoCuaDaiLy = txtNoCuaDaiLy.Text
        daily.MaLoaiDaiLy = Convert.ToInt32(cbxLoaiDL.SelectedValue)
        daily.MaQuan = Convert.ToInt32(cbxQuan.SelectedValue)

        '2. Business .....
        If (dlBus.isValidName(daily) = False) Then
            MessageBox.Show("Tên Đại Lý không đúng")
            txtTenDL.Focus()
            Return
        End If

        If (dlBus.isValidCount(daily) = False) Then
            MessageBox.Show("Quá số lượng Đại Lý")
            Return
        End If

        If (dlBus.isValidMax(daily) = False) Then
            MessageBox.Show("Quá số tiền tối đa của 1 Đại Lý")
            Return
        End If

        '3. Insert to DB
        Dim result As Result
        result = dlBus.insert(daily)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Đại Lý thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MSDL auto
            Dim nextMsdl = "1"
            result = dlBus.buildMaDL(nextMsdl)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh tự động mã Đại Lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
            txtMaDL.Text = nextMsdl
            txtTenDL.Text = String.Empty
            txtDienThoai.Text = String.Empty
            txtDiaChi.Text = String.Empty
            txtEmail.Text = String.Empty
            txtNoCuaDaiLy.Text = String.Empty

        Else
            MessageBox.Show("Thêm Đại Lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
    Private Sub bntNhapDong_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim daily As DaiLy_DTO
        daily = New DaiLy_DTO()

        '1. Mapping data from GUI control
        daily.MaDaiLy = txtMaDL.Text
        daily.TenDaiLy = txtTenDL.Text
        daily.DienThoai = txtDienThoai.Text
        daily.DiaChi = txtDiaChi.Text
        daily.NgayTiepNhan = dtpNgayTiepNhan.Value
        daily.Email = txtEmail.Text
        daily.NoCuaDaiLy = txtNoCuaDaiLy.Text
        daily.MaLoaiDaiLy = Convert.ToInt32(cbxLoaiDL.SelectedValue)
        daily.MaQuan = Convert.ToInt32(cbxQuan.SelectedValue)

        '2. Business .....
        If (dlBus.isValidName(daily) = False) Then
            MessageBox.Show("Tên Đại Lý không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTenDL.Focus()
            Return
        End If

        If (dlBus.isValidCount(daily) = False) Then
            MessageBox.Show("Quá số lượng Đại Lý tối đa trong 1 Quận", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If (dlBus.isValidMax(daily) = False) Then
            MessageBox.Show("Quá số tiền tối đa của 1 Đại Lý")
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = dlBus.insert(daily)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Đại Lý thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Thêm Đại Lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
    Private Sub frmThemDaiLy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dlBus = New DaiLy_BUS()
        ldlBUS = New LoaiDaiLy_BUS()
        qBUS = New Quan_BUS()
        qdBUS = New QuiDinh_BUS()

        ' Load LoaiHocSinh list
        Dim result As Result
        result = qdBUS.selectALL(quidinh)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Qui Định không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If

        ' Load LoaiDaiLy list
        Dim listLoaiDaiLy = New List(Of LoaiDaiLy_DTO)
        Dim result1 As Result
        result1 = ldlBUS.selectAll(listLoaiDaiLy)
        If (result1.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại Đại Lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result1.SystemMessage)
            Me.Close()
            Return
        End If
        cbxLoaiDL.DataSource = New BindingSource(listLoaiDaiLy, String.Empty)
        cbxLoaiDL.DisplayMember = "TenLoaiDL"
        cbxLoaiDL.ValueMember = "MaLoaiDL"

        'set MSDL auto
        Dim nextMsdl1 = "1"
        result1 = dlBus.buildMaDL(nextMsdl1)
        If (result1.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã Đại Lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result1.SystemMessage)
            Me.Close()
            Return
        End If
        txtMaDL.Text = nextMsdl1

        ' Load Quan list
        Dim listQuan = New List(Of Quan_DTO)
        Dim result2 As Result
        result2 = qBUS.selectAll(listQuan)
        If (result2.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Quận không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result2.SystemMessage)
            Me.Close()
            Return
        End If
        cbxQuan.DataSource = New BindingSource(listQuan, String.Empty)
        cbxQuan.DisplayMember = "TenQuan"
        cbxQuan.ValueMember = "MaQuan"

        'set MSDL auto
        Dim nextMsdl2 = "1"
        result2 = dlBus.buildMaDL(nextMsdl2)
        If (result2.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã Đại Lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result2.SystemMessage)
            Me.Close()
            Return
        End If
        txtMaDL.Text = nextMsdl2
    End Sub
End Class