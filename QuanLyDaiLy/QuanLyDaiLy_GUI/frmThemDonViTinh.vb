Imports QuanLyDaiLy_BUS
Imports QuanLyDaiLy_DTO
Imports Utility
Public Class frmThemDonViTinh
    Private dvtBus As DonViTinh_BUS
    Private Sub bntNhap_Click(sender As Object, e As EventArgs) Handles bntNhap.Click

        Dim dvt As DonViTinh_DTO
        dvt = New DonViTinh_DTO()

        '1. Mapping data from GUI control
        dvt.MaDonViTinh = txtMaDVT.Text
        dvt.TenDonViTinh = txtTenDVT.Text

        '2. Business .....
        If (dvtBus.isValidName(dvt) = False) Then
            MessageBox.Show("Tên Đơn Vị Tính không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTenDVT.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = dvtBus.insert(dvt)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Đơn Vị Tính thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim nextMsdvt = "1"
            result = dvtBus.getNextID(nextMsdvt)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh tự động mã Đơn Vị Tính không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
            txtMaDVT.Text = nextMsdvt
            txtTenDVT.Text = String.Empty

        Else
            MessageBox.Show("Thêm Đơn Vị Tính không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
    Private Sub bntNhapDong_Click(sender As Object, e As EventArgs) Handles bntNhapDong.Click
        Dim dvt As DonViTinh_DTO
        dvt = New DonViTinh_DTO()

        '1. Mapping data from GUI control
        dvt.MaDonViTinh = txtMaDVT.Text
        dvt.TenDonViTinh = txtTenDVT.Text

        '2. Business .....
        If (dvtBus.isValidName(dvt) = False) Then
            MessageBox.Show("Tên Đơn Vị Tính không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTenDVT.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = dvtBus.insert(dvt)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Đơn Vị Tính thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Thêm Đơn Vị Tính không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
    Private Sub frmThemDonViTinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dvtBus = New DonViTinh_BUS()

        ' Get Next ID
        Dim nextID As Integer
        Dim result As Result
        result = dvtBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            txtMaDVT.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của Đơn Vị Tính không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
End Class