Imports System.Configuration
Imports QuanLyDaiLy_BUS
Imports QuanLyDaiLy_DTO
Imports Utility
Public Class frmQLChiTietPhieuXuat
    Private ctpxBus As ChiTietPhieuXuat_BUS
    Private pxBUS As PhieuXuat_BUS
    Private mhBUS As MatHang_BUS
    Private dvtBus As DonViTinh_BUS
    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click

        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListCTPX.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListCTPX.RowCount) Then
            Try
                Dim chitietphieuxuat As ChiTietPhieuXuat_DTO
                chitietphieuxuat = New ChiTietPhieuXuat_DTO()

                '1. Mapping data from GUI control
                chitietphieuxuat.MaChiTietPhieuXuat = txtMaCTPX.Text
                chitietphieuxuat.SoLuongXuat = txtSoLuongXuat.Text
                chitietphieuxuat.DonGia = txtDonGia.Text
                chitietphieuxuat.ThanhTien = txtThanhTien.Text
                chitietphieuxuat.MaPhieuXuat = Convert.ToInt32(cbxMaPX.SelectedValue)
                chitietphieuxuat.MaMatHang = Convert.ToInt32(cbxMaMH.SelectedValue)
                chitietphieuxuat.MaDonViTinh = Convert.ToInt32(cbxMaDVT.SelectedValue)
                '2. Business .....

                '3. Insert to DB
                Dim result As Result
                result = ctpxBus.update(chitietphieuxuat)
                If (result.FlagResult = True) Then
                    ' Re-Load ChiTietPhieuXuat list
                    loadListChiTietPhieuXuatPX(cbxMaPX.SelectedValue)
                    loadListChiTietPhieuXuatMH(cbxMaMH.SelectedValue)
                    loadListChiTietPhieuXuatDVT(cbxMaDVT.SelectedValue)
                    ' Hightlight the row has been updated on table
                    dgvListCTPX.Rows(currentRowIndex).Selected = True

                    MessageBox.Show("Cập nhật Chi Tiết Phiếu Xuất thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật Chi Tiết Phiếu Xuất không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListCTPX.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListCTPX.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa Chi Tiết Phiếu Xuất có mã số: " + txtMaCTPX.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try
                        '1. Delete from DB
                        Dim result As Result
                        result = ctpxBus.delete(txtMaCTPX.Text)
                        If (result.FlagResult = True) Then

                            ' Re-Load ChiTietPhieuXuat list
                            loadListChiTietPhieuXuatPX(cbxMaPX.SelectedValue)
                            loadListChiTietPhieuXuatMH(cbxMaMH.SelectedValue)
                            loadListChiTietPhieuXuatDVT(cbxMaDVT.SelectedValue)
                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvListCTPX.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvListCTPX.Rows(currentRowIndex).Selected = True
                            End If

                            MessageBox.Show("Xóa Chi Tiết Phiếu Xuất thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa Chi Tiết Phiếu Xuất không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            System.Console.WriteLine(result.SystemMessage)
                        End If
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                Case MsgBoxResult.No
                    Return
            End Select


        End If
    End Sub
    Private Sub frmQLChiTietPhieuXuat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ctpxBus = New ChiTietPhieuXuat_BUS()
        pxBUS = New PhieuXuat_BUS()
        mhBUS = New MatHang_BUS()
        dvtBus = New DonViTinh_BUS()

        ' Load PhieuXuat list
        Dim listphieuxuat = New List(Of PhieuXuat_DTO)
        Dim result As Result

        result = pxBUS.selectAll(listphieuxuat)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Mã Phiếu Xuất không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        cbxMaPX.DataSource = New BindingSource(listphieuxuat, String.Empty)
        cbxMaPX.DisplayMember = "MaPhieuXuat"
        cbxMaPX.ValueMember = "MaPhieuXuat"

        cbxMaPXCapNhat.DataSource = New BindingSource(listphieuxuat, String.Empty)
        cbxMaPXCapNhat.DisplayMember = "MaPhieuXuat"
        cbxMaPXCapNhat.ValueMember = "MaPhieuXuat"

        'Load MatHang List
        Dim listMatHang = New List(Of MatHang_DTO)

        result = mhBUS.selectAll(listMatHang)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Mặt Hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        cbxMaMH.DataSource = New BindingSource(listMatHang, String.Empty)
        cbxMaMH.DisplayMember = "TenMatHang"
        cbxMaMH.ValueMember = "MaMatHang"

        cbxMaMHCapNhat.DataSource = New BindingSource(listMatHang, String.Empty)
        cbxMaMHCapNhat.DisplayMember = "TenMatHang"
        cbxMaMHCapNhat.ValueMember = "MaMatHang"

        'Load DonViTinh List
        Dim listDonViTinh = New List(Of DonViTinh_DTO)

        result = dvtBus.selectAll(listDonViTinh)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Đơn Vị Tính không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        cbxMaDVT.DataSource = New BindingSource(listDonViTinh, String.Empty)
        cbxMaDVT.DisplayMember = "TenDonViTinh"
        cbxMaDVT.ValueMember = "MaDonViTinh"

        cbxMaDVTCapNhat.DataSource = New BindingSource(listDonViTinh, String.Empty)
        cbxMaDVTCapNhat.DisplayMember = "TenDonViTinh"
        cbxMaDVTCapNhat.ValueMember = "MaDonViTinh"
    End Sub
    Private Sub loadListChiTietPhieuXuatPX(mapx As Integer)
        Dim listchitietphieuxuat = New List(Of PhieuXuatDisplay)
        Dim result As Result
        result = ctpxBus.selectALL_ByMaPhieuXuat(mapx, listchitietphieuxuat)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Chi Tiết Phiếu Xuất theo Mã Phiếu Xuất không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListCTPX.SuspendLayout()
        dgvListCTPX.Columns.Clear()
        dgvListCTPX.DataSource = Nothing

        dgvListCTPX.AutoGenerateColumns = False
        dgvListCTPX.AllowUserToAddRows = False
        dgvListCTPX.DataSource = listchitietphieuxuat

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "MaChiTietPhieuXuat"
        clMa.HeaderText = "Mã Chi Tiết Phiếu Xuất"
        clMa.DataPropertyName = "MaChiTietPhieuXuat"
        dgvListCTPX.Columns.Add(clMa)

        Dim clTenDaiLy = New DataGridViewTextBoxColumn()
        clTenDaiLy.Name = "TenDaiLy"
        clTenDaiLy.HeaderText = "Tên Đại Lý"
        clTenDaiLy.DataPropertyName = "TenDaiLy"
        dgvListCTPX.Columns.Add(clTenDaiLy)

        Dim clMaPhieuXuat = New DataGridViewTextBoxColumn()
        clMaPhieuXuat.Name = "MaPhieuXuat"
        clMaPhieuXuat.HeaderText = "Mã Phiếu Xuất"
        clMaPhieuXuat.DataPropertyName = "MaPhieuXuat"
        dgvListCTPX.Columns.Add(clMaPhieuXuat)

        Dim clTenMatHang = New DataGridViewTextBoxColumn()
        clTenMatHang.Name = "TenMatHang"
        clTenMatHang.HeaderText = "Tên Mặt Hàng"
        clTenMatHang.DataPropertyName = "TenMatHang"
        dgvListCTPX.Columns.Add(clTenMatHang)

        Dim clTenDonViTinh = New DataGridViewTextBoxColumn()
        clTenDonViTinh.Name = "TenDonViTinh"
        clTenDonViTinh.HeaderText = "Tên Đơn Vị Tính"
        clTenDonViTinh.DataPropertyName = "TenDonViTinh"
        dgvListCTPX.Columns.Add(clTenDonViTinh)

        Dim clSoLuongXuat = New DataGridViewTextBoxColumn()
        clSoLuongXuat.Name = "SoLuongXuat"
        clSoLuongXuat.HeaderText = "Số Lượng Xuất"
        clSoLuongXuat.DataPropertyName = "SoLuongXuat"
        dgvListCTPX.Columns.Add(clSoLuongXuat)

        Dim clDonGia = New DataGridViewTextBoxColumn()
        clDonGia.Name = "DonGia"
        clDonGia.HeaderText = "Đơn Giá"
        clDonGia.DataPropertyName = "DonGia"
        dgvListCTPX.Columns.Add(clDonGia)

        Dim clThanhTien = New DataGridViewTextBoxColumn()
        clThanhTien.Name = "ThanhTien"
        clThanhTien.HeaderText = "Thành Tiền"
        clThanhTien.DataPropertyName = "ThanhTien"
        dgvListCTPX.Columns.Add(clThanhTien)

        Dim clNgayLapPhieu = New DataGridViewTextBoxColumn()
        clNgayLapPhieu.Name = "NgayLapPhieu"
        clNgayLapPhieu.HeaderText = "Ngày Lập Phiếu"
        clNgayLapPhieu.DataPropertyName = "NgayLapPhieu"
        dgvListCTPX.Columns.Add(clNgayLapPhieu)

        Dim clTongTriGia = New DataGridViewTextBoxColumn()
        clTongTriGia.Name = "TongTriGia"
        clTongTriGia.HeaderText = "Tổng Trị Giá"
        clTongTriGia.DataPropertyName = "TongTriGia"
        dgvListCTPX.Columns.Add(clTongTriGia)
        'dgvListCTPX.ResumeLayout()
    End Sub
    Private Sub loadListChiTietPhieuXuatMH(mamh As Integer)
        Dim listchitietphieuxuat = New List(Of PhieuXuatDisplay)
        Dim result As Result
        result = ctpxBus.selectALL_ByMaMatHang(mamh, listchitietphieuxuat)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Chi Tiết Phiếu Xuất theo Mã Mặt Hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListCTPX.SuspendLayout()
        dgvListCTPX.Columns.Clear()
        dgvListCTPX.DataSource = Nothing

        dgvListCTPX.AutoGenerateColumns = False
        dgvListCTPX.AllowUserToAddRows = False
        dgvListCTPX.DataSource = listchitietphieuxuat

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "MaChiTietPhieuXuat"
        clMa.HeaderText = "Mã Chi Tiết Phiếu Xuất"
        clMa.DataPropertyName = "MaChiTietPhieuXuat"
        dgvListCTPX.Columns.Add(clMa)

        Dim clTenDaiLy = New DataGridViewTextBoxColumn()
        clTenDaiLy.Name = "TenDaiLy"
        clTenDaiLy.HeaderText = "Tên Đại Lý"
        clTenDaiLy.DataPropertyName = "TenDaiLy"
        dgvListCTPX.Columns.Add(clTenDaiLy)

        Dim clMaPhieuXuat = New DataGridViewTextBoxColumn()
        clMaPhieuXuat.Name = "MaPhieuXuat"
        clMaPhieuXuat.HeaderText = "Mã Phiếu Xuất"
        clMaPhieuXuat.DataPropertyName = "MaPhieuXuat"
        dgvListCTPX.Columns.Add(clMaPhieuXuat)

        Dim clTenMatHang = New DataGridViewTextBoxColumn()
        clTenMatHang.Name = "TenMatHang"
        clTenMatHang.HeaderText = "Tên Mặt Hàng"
        clTenMatHang.DataPropertyName = "TenMatHang"
        dgvListCTPX.Columns.Add(clTenMatHang)

        Dim clTenDonViTinh = New DataGridViewTextBoxColumn()
        clTenDonViTinh.Name = "TenDonViTinh"
        clTenDonViTinh.HeaderText = "Tên Đơn Vị Tính"
        clTenDonViTinh.DataPropertyName = "TenDonViTinh"
        dgvListCTPX.Columns.Add(clTenDonViTinh)

        Dim clSoLuongXuat = New DataGridViewTextBoxColumn()
        clSoLuongXuat.Name = "SoLuongXuat"
        clSoLuongXuat.HeaderText = "Số Lượng Xuất"
        clSoLuongXuat.DataPropertyName = "SoLuongXuat"
        dgvListCTPX.Columns.Add(clSoLuongXuat)

        Dim clDonGia = New DataGridViewTextBoxColumn()
        clDonGia.Name = "DonGia"
        clDonGia.HeaderText = "Đơn Giá"
        clDonGia.DataPropertyName = "DonGia"
        dgvListCTPX.Columns.Add(clDonGia)

        Dim clThanhTien = New DataGridViewTextBoxColumn()
        clThanhTien.Name = "ThanhTien"
        clThanhTien.HeaderText = "Thành Tiền"
        clThanhTien.DataPropertyName = "ThanhTien"
        dgvListCTPX.Columns.Add(clThanhTien)

        Dim clNgayLapPhieu = New DataGridViewTextBoxColumn()
        clNgayLapPhieu.Name = "NgayLapPhieu"
        clNgayLapPhieu.HeaderText = "Ngày Lập Phiếu"
        clNgayLapPhieu.DataPropertyName = "NgayLapPhieu"
        dgvListCTPX.Columns.Add(clNgayLapPhieu)

        Dim clTongTriGia = New DataGridViewTextBoxColumn()
        clTongTriGia.Name = "TongTriGia"
        clTongTriGia.HeaderText = "Tổng Trị Giá"
        clTongTriGia.DataPropertyName = "TongTriGia"
        dgvListCTPX.Columns.Add(clTongTriGia)
        'dgvListCTPX.ResumeLayout()
    End Sub
    Private Sub loadListChiTietPhieuXuatDVT(madvt As Integer)
        Dim listchitietphieuxuat = New List(Of PhieuXuatDisplay)
        Dim result As Result
        result = ctpxBus.selectALL_ByMaDonViTinh(madvt, listchitietphieuxuat)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Chi Tiết Phiếu Xuất theo Mã Đơn Vị Tính không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListCTPX.SuspendLayout()
        dgvListCTPX.Columns.Clear()
        dgvListCTPX.DataSource = Nothing

        dgvListCTPX.AutoGenerateColumns = False
        dgvListCTPX.AllowUserToAddRows = False
        dgvListCTPX.DataSource = listchitietphieuxuat

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "MaChiTietPhieuXuat"
        clMa.HeaderText = "Mã Chi Tiết Phiếu Xuất"
        clMa.DataPropertyName = "MaChiTietPhieuXuat"
        dgvListCTPX.Columns.Add(clMa)

        Dim clTenDaiLy = New DataGridViewTextBoxColumn()
        clTenDaiLy.Name = "TenDaiLy"
        clTenDaiLy.HeaderText = "Tên Đại Lý"
        clTenDaiLy.DataPropertyName = "TenDaiLy"
        dgvListCTPX.Columns.Add(clTenDaiLy)

        Dim clMaPhieuXuat = New DataGridViewTextBoxColumn()
        clMaPhieuXuat.Name = "MaPhieuXuat"
        clMaPhieuXuat.HeaderText = "Mã Phiếu Xuất"
        clMaPhieuXuat.DataPropertyName = "MaPhieuXuat"
        dgvListCTPX.Columns.Add(clMaPhieuXuat)

        Dim clTenMatHang = New DataGridViewTextBoxColumn()
        clTenMatHang.Name = "TenMatHang"
        clTenMatHang.HeaderText = "Tên Mặt Hàng"
        clTenMatHang.DataPropertyName = "TenMatHang"
        dgvListCTPX.Columns.Add(clTenMatHang)

        Dim clTenDonViTinh = New DataGridViewTextBoxColumn()
        clTenDonViTinh.Name = "TenDonViTinh"
        clTenDonViTinh.HeaderText = "Tên Đơn Vị Tính"
        clTenDonViTinh.DataPropertyName = "TenDonViTinh"
        dgvListCTPX.Columns.Add(clTenDonViTinh)

        Dim clSoLuongXuat = New DataGridViewTextBoxColumn()
        clSoLuongXuat.Name = "SoLuongXuat"
        clSoLuongXuat.HeaderText = "Số Lượng Xuất"
        clSoLuongXuat.DataPropertyName = "SoLuongXuat"
        dgvListCTPX.Columns.Add(clSoLuongXuat)

        Dim clDonGia = New DataGridViewTextBoxColumn()
        clDonGia.Name = "DonGia"
        clDonGia.HeaderText = "Đơn Giá"
        clDonGia.DataPropertyName = "DonGia"
        dgvListCTPX.Columns.Add(clDonGia)

        Dim clThanhTien = New DataGridViewTextBoxColumn()
        clThanhTien.Name = "ThanhTien"
        clThanhTien.HeaderText = "Thành Tiền"
        clThanhTien.DataPropertyName = "ThanhTien"
        dgvListCTPX.Columns.Add(clThanhTien)

        Dim clNgayLapPhieu = New DataGridViewTextBoxColumn()
        clNgayLapPhieu.Name = "NgayLapPhieu"
        clNgayLapPhieu.HeaderText = "Ngày Lập Phiếu"
        clNgayLapPhieu.DataPropertyName = "NgayLapPhieu"
        dgvListCTPX.Columns.Add(clNgayLapPhieu)

        Dim clTongTriGia = New DataGridViewTextBoxColumn()
        clTongTriGia.Name = "TongTriGia"
        clTongTriGia.HeaderText = "Tổng Trị Giá"
        clTongTriGia.DataPropertyName = "TongTriGia"
        dgvListCTPX.Columns.Add(clTongTriGia)
        'dgvListCTPX.ResumeLayout()
    End Sub
    Private Sub cbxMaPX_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxMaPX.SelectedIndexChanged
        Try
            Dim mapx = Convert.ToInt32(cbxMaPX.SelectedValue)
            loadListChiTietPhieuXuatPX(mapx)

        Catch ex As Exception

        End Try
    End Sub
    Private Sub cbxMaMH_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxMaMH.SelectedIndexChanged
        Try
            Dim mamh = Convert.ToInt32(cbxMaMH.SelectedValue)
            loadListChiTietPhieuXuatMH(mamh)

        Catch ex As Exception

        End Try
    End Sub
    Private Sub cbxMaDVT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxMaDVT.SelectedIndexChanged
        Try
            Dim madvt = Convert.ToInt32(cbxMaDVT.SelectedValue)
            loadListChiTietPhieuXuatDVT(madvt)

        Catch ex As Exception

        End Try
    End Sub
    Private Sub dgvListCTPX_SELECTionChanged(sender As Object, e As EventArgs) Handles dgvListCTPX.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListCTPX.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvListDL.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListCTPX.RowCount) Then
            Try
                Dim px = CType(dgvListCTPX.Rows(currentRowIndex).DataBoundItem, PhieuXuatDisplay)
                txtMaCTPX.Text = px.MaChiTietPhieuXuat
                txtSoLuongXuat.Text = px.SoLuongXuat
                txtDonGia.Text = px.DonGia
                txtThanhTien.Text = px.ThanhTien
                cbxMaPXCapNhat.SelectedIndex = cbxMaPX.SelectedIndex
                cbxMaPXCapNhat.Text = px.MaPhieuXuat
                cbxMaMHCapNhat.SelectedIndex = cbxMaMH.SelectedIndex
                cbxMaMHCapNhat.Text = px.TenMatHang
                cbxMaDVTCapNhat.SelectedIndex = cbxMaDVT.SelectedIndex
                cbxMaDVTCapNhat.Text = px.TenDonViTinh
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub
End Class