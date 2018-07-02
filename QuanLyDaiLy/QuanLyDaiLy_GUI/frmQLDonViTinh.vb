Imports System.Configuration
Imports QuanLyDaiLy_BUS
Imports QuanLyDaiLy_DTO
Imports Utility
Public Class frmQLDonViTinh
    Private dvtBus As DonViTinh_BUS

    Private Sub frmQLDonViTinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dvtBus = New DonViTinh_BUS()
        ' Load DonViTinh list
        loadListDonViTinh()
    End Sub
    Private Sub loadListDonViTinh()
        ' Load LoaiDonViTinh list
        Dim listDonViTinh = New List(Of DonViTinh_DTO)
        Dim result As Result
        result = dvtBus.selectAll(listDonViTinh)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Đơn Vị Tính không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvDanhSachDonViTinh.Columns.Clear()
        dgvDanhSachDonViTinh.DataSource = Nothing

        dgvDanhSachDonViTinh.AutoGenerateColumns = False
        dgvDanhSachDonViTinh.AllowUserToAddRows = False
        dgvDanhSachDonViTinh.DataSource = listDonViTinh

        Dim clMaMH = New DataGridViewTextBoxColumn()
        clMaMH.Name = "MaDonViTinh"
        clMaMH.HeaderText = "Mã Đơn Vị Tính"
        clMaMH.DataPropertyName = "MaDonViTinh"
        dgvDanhSachDonViTinh.Columns.Add(clMaMH)

        Dim clTenMH = New DataGridViewTextBoxColumn()
        clTenMH.Name = "TenDonViTinh"
        clTenMH.HeaderText = "Tên Đơn Vị Tính"
        clTenMH.DataPropertyName = "TenDonViTinh"
        dgvDanhSachDonViTinh.Columns.Add(clTenMH)
    End Sub
    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles bntCapNhat.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachDonViTinh.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachDonViTinh.RowCount) Then
            Try
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
                result = dvtBus.update(dvt)
                If (result.FlagResult = True) Then
                    ' Re-Load DonViTinh list
                    loadListDonViTinh()
                    ' Hightlight the row has been updated on table
                    dgvDanhSachDonViTinh.Rows(currentRowIndex).Selected = True
                    Try
                        dvt = CType(dgvDanhSachDonViTinh.Rows(currentRowIndex).DataBoundItem, DonViTinh_DTO)
                        txtMaDVT.Text = dvt.MaDonViTinh
                        txtTenDVT.Text = dvt.TenDonViTinh
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                    MessageBox.Show("Cập nhật Đơn Vị Tính thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật Đơn Vị Tính không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub
    Private Sub dgvDanhSachDonViTinh_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDanhSachDonViTinh.SelectionChanged

        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachDonViTinh.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvDanhSachDonViTinh.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachDonViTinh.RowCount) Then
            Try
                Dim dvt = CType(dgvDanhSachDonViTinh.Rows(currentRowIndex).DataBoundItem, DonViTinh_DTO)
                txtMaDVT.Text = dvt.MaDonViTinh
                txtTenDVT.Text = dvt.TenDonViTinh
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles bntXoa.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachDonViTinh.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachDonViTinh.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa Đơn Vị Tính có mã: " + txtMaDVT.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try

                        '1. Delete from DB
                        Dim result As Result
                        result = dvtBus.delete(txtMaDVT.Text)
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiHocSinh list
                            loadListDonViTinh()

                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvDanhSachDonViTinh.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvDanhSachDonViTinh.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim dvt = CType(dgvDanhSachDonViTinh.Rows(currentRowIndex).DataBoundItem, DonViTinh_DTO)
                                    txtMaDVT.Text = dvt.MaDonViTinh
                                    txtTenDVT.Text = dvt.TenDonViTinh
                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
                            End If
                            MessageBox.Show("Xóa Đơn Vị Tính thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa Đơn Vị Tính không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
End Class