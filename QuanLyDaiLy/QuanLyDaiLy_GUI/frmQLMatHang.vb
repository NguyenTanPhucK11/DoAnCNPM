Imports System.Configuration
Imports QuanLyDaiLy_BUS
Imports QuanLyDaiLy_DTO
Imports Utility
Public Class frmQLMatHang
    Private mhBus As MatHang_BUS
    Private Sub frmQLMatHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mhBus = New MatHang_BUS()
        ' Load MatHang list
        loadListMatHang()
    End Sub
    Private Sub loadListMatHang()
        ' Load LoaiMatHang list
        Dim listMatHang = New List(Of MatHang_DTO)
        Dim result As Result
        result = mhBus.selectAll(listMatHang)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Mặt Hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvDanhSachMatHang.Columns.Clear()
        dgvDanhSachMatHang.DataSource = Nothing

        dgvDanhSachMatHang.AutoGenerateColumns = False
        dgvDanhSachMatHang.AllowUserToAddRows = False
        dgvDanhSachMatHang.DataSource = listMatHang

        Dim clMaMH = New DataGridViewTextBoxColumn()
        clMaMH.Name = "MaMatHang"
        clMaMH.HeaderText = "Mã Mặt Hàng"
        clMaMH.DataPropertyName = "MaMatHang"
        dgvDanhSachMatHang.Columns.Add(clMaMH)

        Dim clTenMH = New DataGridViewTextBoxColumn()
        clTenMH.Name = "TenMatHang"
        clTenMH.HeaderText = "Tên Mặt Hàng"
        clTenMH.DataPropertyName = "TenMatHang"
        dgvDanhSachMatHang.Columns.Add(clTenMH)

        Dim clSoLuongTon = New DataGridViewTextBoxColumn()
        clSoLuongTon.Name = "SoLuongTon"
        clSoLuongTon.HeaderText = "Số Lượng Tồn"
        clSoLuongTon.DataPropertyName = "SoLuongTon"
        dgvDanhSachMatHang.Columns.Add(clSoLuongTon)
    End Sub
    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles bntCapNhat.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachMatHang.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachMatHang.RowCount) Then
            Try
                Dim mh As MatHang_DTO
                mh = New MatHang_DTO()

                '1. Mapping data from GUI control
                mh.MaMatHang = txtMaMH.Text
                mh.TenMatHang = txtTenMH.Text
                mh.SoLuongTon = txtSoLuongTon.Text

                '2. Business .....
                If (mhBus.isValidName(mh) = False) Then
                    MessageBox.Show("Tên Mặt Hàng không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtTenMH.Focus()
                    Return
                End If

                '3. Insert to DB
                Dim result As Result
                result = mhBus.update(mh)
                If (result.FlagResult = True) Then
                    ' Re-Load MatHang list
                    loadListMatHang()
                    ' Hightlight the row has been updated on table
                    dgvDanhSachMatHang.Rows(currentRowIndex).Selected = True
                    Try
                        mh = CType(dgvDanhSachMatHang.Rows(currentRowIndex).DataBoundItem, MatHang_DTO)
                        txtMaMH.Text = mh.MaMatHang
                        txtTenMH.Text = mh.TenMatHang
                        txtSoLuongTon.Text = mh.SoLuongTon
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                    MessageBox.Show("Cập nhật Mặt Hàng thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật Mặt Hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub
    Private Sub dgvDanhSachMatHang_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDanhSachMatHang.SelectionChanged

        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachMatHang.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvDanhSachMatHang.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachMatHang.RowCount) Then
            Try
                Dim mh = CType(dgvDanhSachMatHang.Rows(currentRowIndex).DataBoundItem, MatHang_DTO)
                txtMaMH.Text = mh.MaMatHang
                txtTenMH.Text = mh.TenMatHang
                txtSoLuongTon.Text = mh.SoLuongTon
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles bntXoa.Click

        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachMatHang.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachMatHang.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa Mặt Hàng có mã: " + txtMaMH.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try

                        '1. Delete from DB
                        Dim result As Result
                        result = mhBus.delete(txtMaMH.Text)
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiHocSinh list
                            loadListMatHang()

                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvDanhSachMatHang.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvDanhSachMatHang.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim mh = CType(dgvDanhSachMatHang.Rows(currentRowIndex).DataBoundItem, MatHang_DTO)
                                    txtMaMH.Text = mh.MaMatHang
                                    txtTenMH.Text = mh.TenMatHang
                                    txtSoLuongTon.Text = mh.SoLuongTon
                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
                            End If
                            MessageBox.Show("Xóa Mặt Hàng thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa Mặt Hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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