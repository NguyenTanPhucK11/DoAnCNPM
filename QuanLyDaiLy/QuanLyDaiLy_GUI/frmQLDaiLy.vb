Imports QuanLyDaiLy_BUS
Imports QuanLyDaiLy_DTO
Imports Utility
Public Class frmQLDaiLy
    Private dlBus As DaiLy_BUS
    Private ldlBus As LoaiDaiLy_BUS
    Private qBus As Quan_BUS
    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click

        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListDL.CurrentCellAddress.Y 'current row selected

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListDL.RowCount) Then
            Try
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
                daily.MaLoaiDaiLy = Convert.ToInt32(cBxLoaiDLCapNhat.SelectedValue)
                daily.MaQuan = Convert.ToInt32(cbxQuanCapNhat.SelectedValue)
                '2. Business .....
                If (dlBus.isValidName(daily) = False) Then
                    MessageBox.Show("Tên Đại Lý không đúng.")
                    txtTenDL.Focus()
                    Return
                End If
                '3. Insert to DB
                Dim result As Result
                result = dlBus.update(daily)
                If (result.FlagResult = True) Then
                    ' Re-Load DaiLy list
                    loadListDaiLyLoai(cbxLoaiDL.SelectedValue)
                    loadListDaiLyQuan(cbxQuan.SelectedValue)
                    ' Hightlight the row has been updated on table
                    dgvListDL.Rows(currentRowIndex).Selected = True

                    MessageBox.Show("Cập nhật Đại Lý thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật Đại Lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListDL.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListDL.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa Đại Lý có mã số: " + txtMaDL.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try
                        '1. Delete from DB
                        Dim result As Result
                        result = dlBus.delete(txtMaDL.Text)
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiHocSinh list
                            loadListDaiLyLoai(cbxLoaiDL.SelectedValue)
                            loadListDaiLyQuan(cbxQuan.SelectedValue)

                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvListDL.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvListDL.Rows(currentRowIndex).Selected = True
                            End If

                            MessageBox.Show("Xóa Đại Lý thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa Đại Lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
    Private Sub frmQLDaiLy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dlBus = New DaiLy_BUS()
        ldlBus = New LoaiDaiLy_BUS()
        qBus = New Quan_BUS()

        ' Load LoaiDaiLy list
        Dim listloaidaiLy = New List(Of LoaiDaiLy_DTO)
        Dim result As Result

        result = ldlBus.selectAll(listloaidaiLy)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại Đại Lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        cbxLoaiDL.DataSource = New BindingSource(listloaidaiLy, String.Empty)
        cbxLoaiDL.DisplayMember = "TenLoaiDL"
        cbxLoaiDL.ValueMember = "MaLoaiDL"

        cBxLoaiDLCapNhat.DataSource = New BindingSource(listloaidaiLy, String.Empty)
        cBxLoaiDLCapNhat.DisplayMember = "TenLoaiDL"
        cBxLoaiDLCapNhat.ValueMember = "MaLoaiDL"

        'Load Quan List
        Dim listQuan = New List(Of Quan_DTO)
        result = qBus.selectAll(listQuan)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Quận không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        cbxQuan.DataSource = New BindingSource(listQuan, String.Empty)
        cbxQuan.DisplayMember = "TenQuan"
        cbxQuan.ValueMember = "MaQuan"

        cbxQuanCapNhat.DataSource = New BindingSource(listQuan, String.Empty)
        cbxQuanCapNhat.DisplayMember = "TenQuan"
        cbxQuanCapNhat.ValueMember = "MaQuan"
    End Sub
    Private Sub loadListDaiLyQuan(maLoai As Integer)
        Dim listdaily = New List(Of DaiLyDisplay)
        Dim result2 As Result
        result2 = dlBus.selectALL_ByMaQuan(maLoai, listdaily)
        If (result2.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Đại Lý theo Quận không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result2.SystemMessage)
            Return
        End If

        'dgvListDL.SuspendLayout()
        dgvListDL.Columns.Clear()
        dgvListDL.DataSource = Nothing

        dgvListDL.AutoGenerateColumns = False
        dgvListDL.AllowUserToAddRows = False
        dgvListDL.DataSource = listdaily

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "MaDaiLy"
        clMa.HeaderText = "Mã Đại Lý"
        clMa.DataPropertyName = "MaDaiLy"
        dgvListDL.Columns.Add(clMa)

        Dim clTenDaiLy = New DataGridViewTextBoxColumn()
        clTenDaiLy.Name = "TenDaiLy"
        clTenDaiLy.HeaderText = "Tên Đại Lý"
        clTenDaiLy.DataPropertyName = "TenDaiLy"
        dgvListDL.Columns.Add(clTenDaiLy)

        Dim clTenLDL = New DataGridViewTextBoxColumn()
        clTenLDL.Name = "TenLoaiDaiLy"
        clTenLDL.HeaderText = "Tên Loại Đại Lý"
        clTenLDL.DataPropertyName = "TenLoaiDaiLy"
        dgvListDL.Columns.Add(clTenLDL)

        Dim clTenQuan = New DataGridViewTextBoxColumn()
        clTenQuan.Name = "TenQuan"
        clTenQuan.HeaderText = "Tên Quận"
        clTenQuan.DataPropertyName = "TenQuan"
        dgvListDL.Columns.Add(clTenQuan)

        Dim clDienThoai = New DataGridViewTextBoxColumn()
        clDienThoai.Name = "DienThoai"
        clDienThoai.HeaderText = "Điện Thoại"
        clDienThoai.DataPropertyName = "DienThoai"
        dgvListDL.Columns.Add(clDienThoai)

        Dim clDiaChi = New DataGridViewTextBoxColumn()
        clDiaChi.Name = "DiaChi"
        clDiaChi.HeaderText = "Địa Chỉ"
        clDiaChi.DataPropertyName = "DiaChi"
        dgvListDL.Columns.Add(clDiaChi)

        Dim clNgayTiepNhan = New DataGridViewTextBoxColumn()
        clNgayTiepNhan.Name = "NgayTiepNhan"
        clNgayTiepNhan.HeaderText = "Ngày Tiếp Nhận"
        clNgayTiepNhan.DataPropertyName = "NgayTiepNhan"
        dgvListDL.Columns.Add(clNgayTiepNhan)

        Dim clEmail = New DataGridViewTextBoxColumn()
        clEmail.Name = "Email"
        clEmail.HeaderText = "Email"
        clEmail.DataPropertyName = "Email"
        dgvListDL.Columns.Add(clEmail)

        Dim clNoCuaDaiLy = New DataGridViewTextBoxColumn()
        clNoCuaDaiLy.Name = "NoCuaDaiLy"
        clNoCuaDaiLy.HeaderText = "Nợ Của Đại Lý"
        clNoCuaDaiLy.DataPropertyName = "NoCuaDaiLy"
        dgvListDL.Columns.Add(clNoCuaDaiLy)
        'dgvListDL.ResumeLayout()
    End Sub
    Private Sub loadListDaiLyLoai(maLoai As Integer)
        Dim listdaily = New List(Of DaiLyDisplay)
        Dim result2 As Result
        result2 = dlBus.selectALL_ByType(maLoai, listdaily)
        If (result2.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Đại Lý theo Loại không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result2.SystemMessage)
            Return
        End If

        'dgvListDL.SuspendLayout()
        dgvListDL.Columns.Clear()
        dgvListDL.DataSource = Nothing
        dgvListDL.AutoGenerateColumns = False
        dgvListDL.AllowUserToAddRows = False

        dgvListDL.DataSource = listdaily

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "MaDaiLy"
        clMa.HeaderText = "Mã Đại Lý"
        clMa.DataPropertyName = "MaDaiLy"
        dgvListDL.Columns.Add(clMa)

        Dim clTenDaiLy = New DataGridViewTextBoxColumn()
        clTenDaiLy.Name = "TenDaiLy"
        clTenDaiLy.HeaderText = "Tên Đại Lý"
        clTenDaiLy.DataPropertyName = "TenDaiLy"
        dgvListDL.Columns.Add(clTenDaiLy)

        Dim clTenLDL = New DataGridViewTextBoxColumn()
        clTenLDL.Name = "TenLoaiDaiLy"
        clTenLDL.HeaderText = "Tên Loại Đại Lý"
        clTenLDL.DataPropertyName = "TenLoaiDaiLy"
        dgvListDL.Columns.Add(clTenLDL)

        Dim clTenQuan = New DataGridViewTextBoxColumn()
        clTenQuan.Name = "TenQuan"
        clTenQuan.HeaderText = "Tên Quận"
        clTenQuan.DataPropertyName = "TenQuan"
        dgvListDL.Columns.Add(clTenQuan)

        Dim clDienThoai = New DataGridViewTextBoxColumn()
        clDienThoai.Name = "DienThoai"
        clDienThoai.HeaderText = "Điện Thoại"
        clDienThoai.DataPropertyName = "DienThoai"
        dgvListDL.Columns.Add(clDienThoai)

        Dim clDiaChi = New DataGridViewTextBoxColumn()
        clDiaChi.Name = "DiaChi"
        clDiaChi.HeaderText = "Địa Chỉ"
        clDiaChi.DataPropertyName = "DiaChi"
        dgvListDL.Columns.Add(clDiaChi)

        Dim clNgayTiepNhan = New DataGridViewTextBoxColumn()
        clNgayTiepNhan.Name = "NgayTiepNhan"
        clNgayTiepNhan.HeaderText = "Ngày Tiếp Nhận"
        clNgayTiepNhan.DataPropertyName = "NgayTiepNhan"
        dgvListDL.Columns.Add(clNgayTiepNhan)

        Dim clEmail = New DataGridViewTextBoxColumn()
        clEmail.Name = "Email"
        clEmail.HeaderText = "Email"
        clEmail.DataPropertyName = "Email"
        dgvListDL.Columns.Add(clEmail)

        Dim clNoCuaDaiLy = New DataGridViewTextBoxColumn()
        clNoCuaDaiLy.Name = "NoCuaDaiLy"
        clNoCuaDaiLy.HeaderText = "Nợ Của Đại Lý"
        clNoCuaDaiLy.DataPropertyName = "NoCuaDaiLy"
        dgvListDL.Columns.Add(clNoCuaDaiLy)
        'dgvListDL.ResumeLayout()
    End Sub
    Private Sub cbxLoaiDL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged, cbxLoaiDL.SelectedIndexChanged
        Try
            Dim maLoai = Convert.ToInt32(cbxLoaiDL.SelectedValue)
            loadListDaiLyLoai(maLoai)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub cbxQuan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxQuan.SelectedIndexChanged
        Try
            Dim maQuan = Convert.ToInt32(cbxQuan.SelectedValue)
            loadListDaiLyQuan(maQuan)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub dgvListDL_SELECTionChanged(sender As Object, e As EventArgs) Handles dgvListDL.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListDL.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvListDL.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListDL.RowCount) Then
            Try
                Dim dl = CType(dgvListDL.Rows(currentRowIndex).DataBoundItem, DaiLyDisplay)
                txtMaDL.Text = dl.MaDaiLy
                txtTenDL.Text = dl.TenDaiLy
                txtDienThoai.Text = dl.DienThoai
                txtDiaChi.Text = dl.DiaChi
                dtpNgayTiepNhan.Value = dl.NgayTiepNhan
                txtEmail.Text = dl.Email
                txtNoCuaDaiLy.Text = dl.NoCuaDaiLy
                cBxLoaiDLCapNhat.SelectedIndex = cbxLoaiDL.SelectedIndex
                cBxLoaiDLCapNhat.Text = dl.TenLoaiDaiLy
                cbxQuanCapNhat.SelectedIndex = cbxQuan.SelectedIndex
                cbxQuanCapNhat.Text = dl.TenQuan
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub
End Class