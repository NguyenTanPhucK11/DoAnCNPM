Imports QuanLyDaiLy_BUS
Imports QuanLyDaiLy_DTO
Imports Utility
Public Class frmThemChiTietPhieuXuat
    Private ctpxBus As ChiTietPhieuXuat_BUS
    Private pxBUS As PhieuXuat_BUS
    Private mhBUS As MatHang_BUS
    Private dvtBus As DonViTinh_BUS
    Private Sub bntNhap_Click(sender As Object, e As EventArgs) Handles bntNhap.Click
        Dim chitietphieuxuat As ChiTietPhieuXuat_DTO
        chitietphieuxuat = New ChiTietPhieuXuat_DTO()
        Dim listchitietphieuxuat As List(Of ChiTietPhieuXuat_DTO)
        listchitietphieuxuat = New List(Of ChiTietPhieuXuat_DTO)

        '1. Mapping data from GUI control
        chitietphieuxuat.MaChiTietPhieuXuat = txtMaCTPX.Text
        chitietphieuxuat.SoLuongXuat = txtSoLuongXuat.Text
        chitietphieuxuat.DonGia = txtDonGia.Text
        chitietphieuxuat.MaPhieuXuat = Convert.ToInt32(cbxMaPX.SelectedValue)
        chitietphieuxuat.MaMatHang = Convert.ToInt32(cbxMaMH.SelectedValue)
        chitietphieuxuat.MaDonViTinh = Convert.ToInt32(cbxMaDVT.SelectedValue)

        '2. Business .....

        '3. Insert to DB
        Dim result As Result
        result = ctpxBus.insert(chitietphieuxuat)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Chi Tiết Phiếu Xuất thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MSDL auto
            Dim nextMsctpx = "1"
            result = ctpxBus.buildMaCTPX(nextMsctpx)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh tự động mã Chi Tiết Phiếu Xuất không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
            txtMaCTPX.Text = nextMsctpx
            txtDonGia.Text = String.Empty
        Else
            MessageBox.Show("Thêm Chi Tiết Phiếu Xuất không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
    Private Sub bntNhapDong_Click(sender As Object, e As EventArgs) Handles bntNhapDong.Click
        Dim chitietphieuxuat As ChiTietPhieuXuat_DTO
        chitietphieuxuat = New ChiTietPhieuXuat_DTO()

        '1. Mapping data from GUI control
        chitietphieuxuat.MaChiTietPhieuXuat = txtMaCTPX.Text
        chitietphieuxuat.SoLuongXuat = txtSoLuongXuat.Text
        chitietphieuxuat.DonGia = txtDonGia.Text
        chitietphieuxuat.MaPhieuXuat = Convert.ToInt32(cbxMaPX.SelectedValue)
        chitietphieuxuat.MaMatHang = Convert.ToInt32(cbxMaMH.SelectedValue)
        chitietphieuxuat.MaDonViTinh = Convert.ToInt32(cbxMaDVT.SelectedValue)

        '2. Business .....

        '3. Insert to DB
        Dim result As Result
        result = ctpxBus.insert(chitietphieuxuat)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Chi Tiết Phiếu Xuất thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Thêm Chi Tiết Phiếu Xuất không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
    Private Sub frmThemChiTietPhieuXuat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ctpxBus = New ChiTietPhieuXuat_BUS()
        pxBUS = New PhieuXuat_BUS()
        mhBUS = New MatHang_BUS()
        dvtBus = New DonViTinh_BUS()

        ' Load PhieuXuat list
        Dim listPhieuXuat = New List(Of PhieuXuat_DTO)
        Dim result1 As Result
        result1 = pxBUS.selectAll(listPhieuXuat)
        If (result1.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Phiếu Xuất không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result1.SystemMessage)
            Me.Close()
            Return
        End If
        cbxMaPX.DataSource = New BindingSource(listPhieuXuat, String.Empty)
        cbxMaPX.DisplayMember = "MaPhieuXuat"
        cbxMaPX.ValueMember = "MaPhieuXuat"

        'set MSPX auto
        Dim nextMsctpx1 = "1"
        result1 = ctpxBus.buildMaCTPX(nextMsctpx1)
        If (result1.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã Chi Tiết Phiếu Xuất không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result1.SystemMessage)
            Me.Close()
            Return
        End If
        txtMaCTPX.Text = nextMsctpx1

        ' Load MatHang list
        Dim listMatHang = New List(Of MatHang_DTO)
        Dim result2 As Result
        result2 = mhBUS.selectAll(listMatHang)
        If (result2.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Mặt Hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result2.SystemMessage)
            Me.Close()
            Return
        End If
        cbxMaMH.DataSource = New BindingSource(listMatHang, String.Empty)
        cbxMaMH.DisplayMember = "TenMatHang"
        cbxMaMH.ValueMember = "MaMatHang"

        'set MSMH auto
        Dim nextMsctpx2 = "1"
        result2 = ctpxBus.buildMaCTPX(nextMsctpx2)
        If (result2.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã Chi Tiết Phiếu Xuất không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result2.SystemMessage)
            Me.Close()
            Return
        End If
        txtMaCTPX.Text = nextMsctpx2

        ' Load DonViTinh list
        Dim listDonViTinh = New List(Of DonViTinh_DTO)
        Dim result3 As Result
        result3 = dvtBus.selectAll(listDonViTinh)
        If (result3.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Đơn Vị Tính không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result3.SystemMessage)
            Me.Close()
            Return
        End If
        cbxMaDVT.DataSource = New BindingSource(listDonViTinh, String.Empty)
        cbxMaDVT.DisplayMember = "TenDonViTinh"
        cbxMaDVT.ValueMember = "MaDonViTinh"

        'set MSDVT auto
        Dim nextMsctpx3 = "1"
        result3 = ctpxBus.buildMaCTPX(nextMsctpx3)
        If (result3.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã Chi Tiết Phiếu Xuất không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result3.SystemMessage)
            Me.Close()
            Return
        End If
        txtMaCTPX.Text = nextMsctpx3
    End Sub
End Class