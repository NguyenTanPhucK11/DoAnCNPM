Imports QuanLyDaiLy_BUS
Imports QuanLyDaiLy_DTO
Imports Utility
Public Class frmThemQuan
    Private qBus As Quan_BUS
    Private Sub bntNhap_Click(sender As Object, e As EventArgs) Handles bntNhap.Click
        Dim q As Quan_DTO
        q = New Quan_DTO()

        '1. Mapping data from GUI control
        q.MaQuan = txtMaQuan.Text
        q.TenQuan = txtTenQuan.Text

        '2. Business .....
        If (qBus.isValidName(q) = False) Then
            MessageBox.Show("Tên Quận không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTenQuan.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = qBus.insert(q)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Quận thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTenQuan.Text = String.Empty

            ' Get Next ID
            Dim nextID As Integer
            result = qBus.getNextID(nextID)
            If (result.FlagResult = True) Then
                txtMaQuan.Text = nextID.ToString()
            Else
                MessageBox.Show("Lấy ID kế tiếp của Quận không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If

        Else
            MessageBox.Show("Thêm Quận không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
    Private Sub bntNhapDong_Click(sender As Object, e As EventArgs) Handles bntNhapDong.Click
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
        result = qBus.insert(q)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Quận thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Thêm Quận không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
    Private Sub frmThemQuan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        qBus = New Quan_BUS()

        ' Get Next ID
        Dim nextID As Integer
        Dim result1 As Result
        result1 = qBus.getNextID(nextID)
        If (result1.FlagResult = True) Then
            txtMaQuan.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của Quận không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result1.SystemMessage)
        End If
    End Sub
End Class