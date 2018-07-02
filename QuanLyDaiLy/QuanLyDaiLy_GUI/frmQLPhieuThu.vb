Imports System.Configuration
Imports QuanLyDaiLy_BUS
Imports QuanLyDaiLy_DTO
Imports Utility
Public Class frmQLPhieuThu
    Private ptBus As PhieuThu_BUS
    Private dlBus As DaiLy_BUS
    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListPT.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListPT.RowCount) Then
            Try
                Dim phieuthu As PhieuThu_DTO
                phieuthu = New PhieuThu_DTO()

                '1. Mapping data from GUI control
                phieuthu.MaPhieuThuTIen = txtMaPT.Text
                phieuthu.NgayThuTien = dtpNgayThuTien.Value
                phieuthu.SoTienThu = txtSoTienThu.Text
                phieuthu.MaDaiLy = Convert.ToInt32(cbxMaDL.SelectedValue)
                '2. Business .....

                '3. Insert to DB
                Dim result As Result
                result = ptBus.update(phieuthu)
                If (result.FlagResult = True) Then
                    ' Re-Load PhieuThu list
                    loadListPhieuThuDL(cbxMaDL.SelectedValue)
                    ' Hightlight the row has been updated on table
                    dgvListPT.Rows(currentRowIndex).Selected = True

                    MessageBox.Show("Cập nhật Phiếu Thu thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật Phiếu Thu không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListPT.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListPT.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa Phiếu Thu có mã số: " + txtMaPT.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try
                        '1. Delete from DB
                        Dim result As Result
                        result = ptBus.delete(txtMaPT.Text)
                        If (result.FlagResult = True) Then

                            ' Re-Load PhieuThu list
                            loadListPhieuThuDL(cbxMaDL.SelectedValue)
                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvListPT.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvListPT.Rows(currentRowIndex).Selected = True
                            End If

                            MessageBox.Show("Xóa Phiếu Thu thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa Phiếu Thu không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
    Private Sub frmQLPhieuThu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ptBus = New PhieuThu_BUS()
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

        cbxMaDL.DataSource = New BindingSource(listdaiLy, String.Empty)
        cbxMaDL.DisplayMember = "TenDaiLy"
        cbxMaDL.ValueMember = "MaDaiLy"

        cbxMaDLCapNhat.DataSource = New BindingSource(listdaiLy, String.Empty)
        cbxMaDLCapNhat.DisplayMember = "TenDaiLy"
        cbxMaDLCapNhat.ValueMember = "MaDaiLy"
    End Sub
    Private Sub loadListPhieuThu()
        Dim listPhieuThu = New List(Of PhieuThu_DTO)
        Dim result As Result
        result = ptBus.selectAll(listPhieuThu)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Phiếu Thu không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListDL.SuspendLayout()
        dgvListPT.Columns.Clear()
        dgvListPT.DataSource = Nothing

        dgvListPT.AutoGenerateColumns = False
        dgvListPT.AllowUserToAddRows = False
        dgvListPT.DataSource = listPhieuThu

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "MaPhieuThu"
        clMa.HeaderText = "Mã Phiếu Thu"
        clMa.DataPropertyName = "MaPhieuThu"
        dgvListPT.Columns.Add(clMa)

        Dim clDL = New DataGridView()

        Dim clNgayThuTien = New DataGridViewTextBoxColumn()
        clNgayThuTien.Name = "NgayThuTien"
        clNgayThuTien.HeaderText = "Ngày Thu Tiền"
        clNgayThuTien.DataPropertyName = "NgayThuTien"
        dgvListPT.Columns.Add(clNgayThuTien)

        Dim clSoTienThu = New DataGridViewTextBoxColumn()
        clSoTienThu.Name = "SoTienThu"
        clSoTienThu.HeaderText = "Số Tiền Thu"
        clSoTienThu.DataPropertyName = "SoTienThu"
        dgvListPT.Columns.Add(clSoTienThu)
        'dgvListDL.ResumeLayout()
    End Sub
    Private Sub loadListPhieuThuDL(madl As Integer)
        Dim listphieuthu = New List(Of PhieuThu_DTO)
        Dim result1 As Result
        result1 = ptBus.selectALL_ByMaDaiLy(madl, listphieuthu)
        If (result1.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Phiếu Thu theo Mã Đại lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result1.SystemMessage)
            Return
        End If

        'dgvListDL.SuspendLayout()
        dgvListPT.Columns.Clear()
        dgvListPT.DataSource = Nothing

        dgvListPT.AutoGenerateColumns = False
        dgvListPT.AllowUserToAddRows = False
        dgvListPT.DataSource = listphieuthu

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "MaPhieuThuTien"
        clMa.HeaderText = "Mã Phiếu Thu"
        clMa.DataPropertyName = "MaPhieuThuTien"
        dgvListPT.Columns.Add(clMa)

        Dim clDL = New DataGridView()

        Dim clNgayThuTien = New DataGridViewTextBoxColumn()
        clNgayThuTien.Name = "NgayThuTien"
        clNgayThuTien.HeaderText = "Ngày Thu Tiền"
        clNgayThuTien.DataPropertyName = "NgayThuTien"
        dgvListPT.Columns.Add(clNgayThuTien)

        Dim clSoTienThu = New DataGridViewTextBoxColumn()
        clSoTienThu.Name = "SoTienThu"
        clSoTienThu.HeaderText = "Số Tiền Thu"
        clSoTienThu.DataPropertyName = "SoTienThu"
        dgvListPT.Columns.Add(clSoTienThu)
        'dgvListDL.ResumeLayout()
    End Sub
    Private Sub cbxMaDL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxMaDL.SelectedIndexChanged
        Try
            Dim maLoai = Convert.ToInt32(cbxMaDL.SelectedValue)
            loadListPhieuThuDL(maLoai)

        Catch ex As Exception

        End Try
    End Sub
    Private Sub dgvListPX_SelectionChanged(sender As Object, e As EventArgs) Handles dgvListPT.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListPT.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvListDL.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListPT.RowCount) Then
            Try
                Dim pt = CType(dgvListPT.Rows(currentRowIndex).DataBoundItem, PhieuThu_DTO)
                txtMaPT.Text = pt.MaPhieuThuTIen
                dtpNgayThuTien.Value = pt.NgayThuTien
                txtSoTienThu.Text = pt.SoTienThu
                cbxMaDLCapNhat.SelectedIndex = cbxMaDL.SelectedIndex
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub
End Class