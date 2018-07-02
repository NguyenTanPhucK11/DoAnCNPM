Imports QuanLyDaiLy_BUS
Imports QuanLyDaiLy_DTO
Imports Utility
Public Class frmThemLoaiDaiLy
    Private ldlBus As LoaiDaiLy_BUS
    Private Sub bntNhap_Click(sender As Object, e As EventArgs) Handles bntNhap.Click
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

        If (ldlBus.isValidCount(ldl) = False) Then
            MessageBox.Show("Vượt quá số lượng Loại Đại Lý", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        '3. Insert to DB
        Dim result As Result
        result = ldlBus.insert(ldl)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Loại Đại Lý thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTenLoaiDL.Text = String.Empty
            txtNoToiDa.Text = String.Empty

            ' Get Next ID
            Dim nextID As Integer
            result = ldlBus.getNextID(nextID)
            If (result.FlagResult = True) Then
                txtMaLoaiDL.Text = nextID.ToString()
            Else
                MessageBox.Show("Lấy ID kế tiếp của Loại Đại Lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If

        Else
            MessageBox.Show("Thêm Loại Đại Lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
    Private Sub bntNhapDong_Click(sender As Object, e As EventArgs) Handles bntNhapDong.Click
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
        result = ldlBus.insert(ldl)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Loại Đại Lý thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Thêm Loại Đại Lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
    Private Sub frmThemLoaiDaiLy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ldlBus = New LoaiDaiLy_BUS()

        ' Get Next ID
        Dim nextID As Integer
        Dim result As Result
        result = ldlBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            txtMaLoaiDL.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của Loại Đại Lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
End Class