Imports System.Configuration
Imports QuanLyDaiLy_BUS
Imports QuanLyDaiLy_DTO
Imports Utility
Public Class frmQLQuan
    Private qBus As Quan_BUS
    Private Sub frmQLQuan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        qBus = New Quan_BUS()
        ' Load Quan list
        loadListDaiLy()
    End Sub
    Private Sub loadListDaiLy()
        ' Load LoaiHocSinh list
        Dim listQuan = New List(Of Quan_DTO)
        Dim result As Result
        result = qBus.selectAll(listQuan)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Quận không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvDanhSachQuan.Columns.Clear()
        dgvDanhSachQuan.DataSource = Nothing

        dgvDanhSachQuan.AutoGenerateColumns = False
        dgvDanhSachQuan.AllowUserToAddRows = False
        dgvDanhSachQuan.DataSource = listQuan

        Dim clMaQuan = New DataGridViewTextBoxColumn()
        clMaQuan.Name = "MaQuan"
        clMaQuan.HeaderText = "Mã Quận"
        clMaQuan.DataPropertyName = "MaQuan"
        dgvDanhSachQuan.Columns.Add(clMaQuan)

        Dim clTenQuan = New DataGridViewTextBoxColumn()
        clTenQuan.Name = "TenQuan"
        clTenQuan.HeaderText = "Tên Quận"
        clTenQuan.DataPropertyName = "TenQuan"
        dgvDanhSachQuan.Columns.Add(clTenQuan)
    End Sub
    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachQuan.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachQuan.RowCount) Then
            Try
                Dim q As Quan_DTO
                q = New Quan_DTO()

                '1. Mapping data from GUI control
                q.MaQuan = Convert.ToInt32(txtMaQuan.Text)
                q.TenQuan = txtTenQuan.Text

                '2. Business .....
                If (qBus.isValidName(q) = False) Then
                    MessageBox.Show("Tên Quận không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtTenQuan.Focus()
                    Return
                End If

                '3. Insert to DB

                Dim result As Result
                result = qBus.update(q)
                If (result.FlagResult = True) Then
                    ' Re-Load LoaiHocSinh list
                    loadListDaiLy()
                    ' Hightlight the row has been updated on table
                    dgvDanhSachQuan.Rows(currentRowIndex).Selected = True
                    Try
                        q = CType(dgvDanhSachQuan.Rows(currentRowIndex).DataBoundItem, Quan_DTO)
                        txtMaQuan.Text = q.MaQuan
                        txtTenQuan.Text = q.TenQuan
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                    MessageBox.Show("Cập nhật Quận thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật Quận không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub
    Private Sub dgvDanhSachQuan_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDanhSachQuan.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachQuan.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvDanhSachLoaiDaiLy.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachQuan.RowCount) Then
            Try
                Dim q = CType(dgvDanhSachQuan.Rows(currentRowIndex).DataBoundItem, Quan_DTO)
                txtMaQuan.Text = q.MaQuan
                txtTenQuan.Text = q.TenQuan
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachQuan.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachQuan.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa Quận có mã: " + txtMaQuan.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try

                        '1. Delete from DB
                        Dim result As Result
                        result = qBus.delete(Convert.ToInt32(txtMaQuan.Text))
                        If (result.FlagResult = True) Then

                            ' Re-Load Quạn list
                            loadListDaiLy()

                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvDanhSachQuan.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvDanhSachQuan.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim q = CType(dgvDanhSachQuan.Rows(currentRowIndex).DataBoundItem, Quan_DTO)
                                    txtMaQuan.Text = q.MaQuan
                                    txtTenQuan.Text = q.TenQuan
                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
                            End If
                            MessageBox.Show("Xóa Quận thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa Quận không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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