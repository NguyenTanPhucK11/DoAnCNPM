Imports System.Configuration
Imports QuanLyDaiLy_BUS
Imports QuanLyDaiLy_DTO
Imports Utility
Public Class frmQLPhieuXuat

    Private pxBus As PhieuXuat_BUS
    Private dlBus As DaiLy_BUS

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListPX.CurrentCellAddress.Y 'current row selected

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListPX.RowCount) Then
            Try
                Dim phieuxuat As PhieuXuat_DTO
                phieuxuat = New PhieuXuat_DTO()

                '1. Mapping data from GUI control
                phieuxuat.MaPhieuXuat = txtMaPX.Text
                phieuxuat.NgayLapPhieu = dtpNgayLapPhieu.Value
                phieuxuat.MaDaiLy = Convert.ToInt32(cBxMaDLCapNhat.SelectedValue)
                '2. Business .....

                '3. Insert to DB
                Dim result As Result
                result = pxBus.update(phieuxuat)
                If (result.FlagResult = True) Then
                    ' Re-Load Phiếu Xuất list
                    loadListPhieuXuat(cBxMaDL.SelectedValue)
                    ' Hightlight the row has been updated on table
                    dgvListPX.Rows(currentRowIndex).Selected = True

                    MessageBox.Show("Cập nhật Phiếu Xuất thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật Phiếu Xuất không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListPX.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListPX.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa Phiếu Xuất có mã số: " + txtMaPX.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try
                        '1. Delete from DB
                        Dim result As Result
                        result = pxBus.delete(txtMaPX.Text)
                        If (result.FlagResult = True) Then

                            ' Re-Load MaDaiLy list
                            loadListPhieuXuat(cBxMaDL.SelectedValue)

                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvListPX.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvListPX.Rows(currentRowIndex).Selected = True
                            End If

                            MessageBox.Show("Xóa Phiếu Xuất thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa Phiếu Xuất không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub frmQLPhieuXuat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        pxBus = New PhieuXuat_BUS()
        dlBus = New DaiLy_BUS()

        ' Load MaDaiLy list
        Dim listdaiLy = New List(Of DaiLy_DTO)
        Dim result1 As Result

        result1 = dlBus.selectAll(listdaiLy)
        If (result1.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Mã Đại Lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result1.SystemMessage)
            Return
        End If

        cBxMaDL.DataSource = New BindingSource(listdaiLy, String.Empty)
        cBxMaDL.DisplayMember = "TenDaiLy"
        cBxMaDL.ValueMember = "MaDaiLy"

        cBxMaDLCapNhat.DataSource = New BindingSource(listdaiLy, String.Empty)
        cBxMaDLCapNhat.DisplayMember = "TenDaiLy"
        cBxMaDLCapNhat.ValueMember = "MaDaiLy"
    End Sub
    Private Sub loadListPhieuXuat()
        Dim listPhieuXuat = New List(Of PhieuXuat_DTO)
        Dim result As Result
        result = pxBus.selectAll(listPhieuXuat)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Phiếu Xuất không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListDL.SuspendLayout()
        dgvListPX.Columns.Clear()
        dgvListPX.DataSource = Nothing

        dgvListPX.AutoGenerateColumns = False
        dgvListPX.AllowUserToAddRows = False
        dgvListPX.DataSource = listPhieuXuat

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "MaPhieuXuat"
        clMa.HeaderText = "Mã Phiếu Xuất"
        clMa.DataPropertyName = "MaPhieuXuat"
        dgvListPX.Columns.Add(clMa)

        Dim clDL = New DataGridView()

        Dim clNgayLapPhieu = New DataGridViewTextBoxColumn()
        clNgayLapPhieu.Name = "NgayLapPhieu"
        clNgayLapPhieu.HeaderText = "Ngày Lập Phiếu"
        clNgayLapPhieu.DataPropertyName = "NgayLapPhieu"
        dgvListPX.Columns.Add(clNgayLapPhieu)
        'dgvListDL.ResumeLayout()
    End Sub
    Private Sub loadListPhieuXuat(maLoai As Integer)

        Dim listphieuxuat = New List(Of PhieuXuat_DTO)
        Dim result1 As Result
        result1 = pxBus.selectALL_ByMaDL(maLoai, listphieuxuat)
        If (result1.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Phiếu Xuất theo Mã Đai lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result1.SystemMessage)
            Return
        End If

        'dgvListDL.SuspendLayout()
        dgvListPX.Columns.Clear()
        dgvListPX.DataSource = Nothing

        dgvListPX.AutoGenerateColumns = False
        dgvListPX.AllowUserToAddRows = False
        dgvListPX.DataSource = listphieuxuat

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "MaPhieuXuat"
        clMa.HeaderText = "Mã Phiếu Xuất"
        clMa.DataPropertyName = "MaPhieuXuat"
        dgvListPX.Columns.Add(clMa)

        Dim clDL = New DataGridView()

        Dim clNgayLapPhieu = New DataGridViewTextBoxColumn()
        clNgayLapPhieu.Name = "NgayLapPhieu"
        clNgayLapPhieu.HeaderText = "Ngày Lập Phiếu"
        clNgayLapPhieu.DataPropertyName = "NgayLapPhieu"
        dgvListPX.Columns.Add(clNgayLapPhieu)
        'dgvListDL.ResumeLayout()
    End Sub

    Private Sub cBxMaDL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cBxMaDL.SelectedIndexChanged
        Try
            Dim maLoai = Convert.ToInt32(cBxMaDL.SelectedValue)
            loadListPhieuXuat(maLoai)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvListPX_SelectionChanged(sender As Object, e As EventArgs) Handles dgvListPX.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListPX.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvListDL.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListPX.RowCount) Then
            Try
                Dim px = CType(dgvListPX.Rows(currentRowIndex).DataBoundItem, PhieuXuat_DTO)
                txtMaPX.Text = px.MaPhieuXuat
                dtpNgayLapPhieu.Value = px.NgayLapPhieu
                cBxMaDLCapNhat.SelectedIndex = cBxMaDL.SelectedIndex
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub
End Class