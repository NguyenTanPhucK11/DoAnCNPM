Imports System.Configuration
Imports QuanLyDaiLy_BUS
Imports QuanLyDaiLy_DTO
Imports Utility
Public Class frmQLLoaiDaiLy
    Private ldlBus As LoaiDaiLy_BUS
    Private Sub frmQLLoaiDaiLy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ldlBus = New LoaiDaiLy_BUS()
        ' Load LoaiDaiLy list
        loadListDaiLy()
    End Sub
    Private Sub loadListDaiLy()
        Dim listLoaiDaiLy = New List(Of LoaiDaiLy_DTO)
        Dim result As Result
        result = ldlBus.selectAll(listLoaiDaiLy)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Loại Đại Lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvDanhSachLoaiDaiLy.Columns.Clear()
        dgvDanhSachLoaiDaiLy.DataSource = Nothing

        dgvDanhSachLoaiDaiLy.AutoGenerateColumns = False
        dgvDanhSachLoaiDaiLy.AllowUserToAddRows = False
        dgvDanhSachLoaiDaiLy.DataSource = listLoaiDaiLy

        Dim clMaLoai = New DataGridViewTextBoxColumn()
        clMaLoai.Name = "MaLoaiDL"
        clMaLoai.HeaderText = "Mã Loại Đại Lý"
        clMaLoai.DataPropertyName = "MaLoaiDL"
        dgvDanhSachLoaiDaiLy.Columns.Add(clMaLoai)

        Dim clTenLoai = New DataGridViewTextBoxColumn()
        clTenLoai.Name = "TenLoaiDL"
        clTenLoai.HeaderText = "Tên Loại Đại Lý"
        clTenLoai.DataPropertyName = "TenLoaiDL"
        dgvDanhSachLoaiDaiLy.Columns.Add(clTenLoai)

        Dim clNoToiDa = New DataGridViewTextBoxColumn()
        clNoToiDa.Name = "NoToiDa"
        clNoToiDa.HeaderText = "Nợ Tối Đa"
        clNoToiDa.DataPropertyName = "NoToiDa"
        dgvDanhSachLoaiDaiLy.Columns.Add(clNoToiDa)
    End Sub
    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles bntCapNhat.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachLoaiDaiLy.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachLoaiDaiLy.RowCount) Then
            Try
                Dim ldl As LoaiDaiLy_DTO
                ldl = New LoaiDaiLy_DTO()

                '1. Mapping data from GUI control
                ldl.MaLoaiDL = txtMaLoaiDL.Text
                ldl.TenLoaiDL = txtTenLoaiDL.Text
                ldl.NoToiDa = txtNoToiDa.Text

                '2. Business .....
                If (ldlBus.isValidName(ldl) = False) Then
                    MessageBox.Show("Tên Loại Đại Lý không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtTenLoaiDL.Focus()
                    Return
                End If

                '3. Insert to DB
                Dim result As Result
                result = ldlBus.update(ldl)
                If (result.FlagResult = True) Then
                    ' Re-Load LoaiHocSinh list
                    loadListDaiLy()
                    ' Hightlight the row has been updated on table
                    dgvDanhSachLoaiDaiLy.Rows(currentRowIndex).Selected = True
                    Try
                        ldl = CType(dgvDanhSachLoaiDaiLy.Rows(currentRowIndex).DataBoundItem, LoaiDaiLy_DTO)
                        txtMaLoaiDL.Text = ldl.MaLoaiDL
                        txtTenLoaiDL.Text = ldl.TenLoaiDL
                        txtNoToiDa.Text = ldl.NoToiDa
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                    MessageBox.Show("Cập nhật Loại Đại Lý thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật Loại Đại Lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub
    Private Sub dgvDanhSachLoaiDaiLy_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDanhSachLoaiDaiLy.SelectionChanged

        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachLoaiDaiLy.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvDanhSachLoaiDaiLy.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachLoaiDaiLy.RowCount) Then
            Try
                Dim ldl = CType(dgvDanhSachLoaiDaiLy.Rows(currentRowIndex).DataBoundItem, LoaiDaiLy_DTO)
                txtMaLoaiDL.Text = ldl.MaLoaiDL
                txtTenLoaiDL.Text = ldl.TenLoaiDL
                txtNoToiDa.Text = ldl.NoToiDa
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles bntXoa.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachLoaiDaiLy.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachLoaiDaiLy.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa Loại Đại Lý có mã: " + txtMaLoaiDL.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try

                        '1. Delete from DB
                        Dim result As Result
                        result = ldlBus.delete(txtMaLoaiDL.Text)
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiHocSinh list
                            loadListDaiLy()

                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvDanhSachLoaiDaiLy.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvDanhSachLoaiDaiLy.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim ldl = CType(dgvDanhSachLoaiDaiLy.Rows(currentRowIndex).DataBoundItem, LoaiDaiLy_DTO)
                                    txtMaLoaiDL.Text = ldl.MaLoaiDL
                                    txtTenLoaiDL.Text = ldl.TenLoaiDL
                                    txtNoToiDa.Text = ldl.NoToiDa
                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
                            End If
                            MessageBox.Show("Xóa Loại Đại Lý thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa Loại Đại Lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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