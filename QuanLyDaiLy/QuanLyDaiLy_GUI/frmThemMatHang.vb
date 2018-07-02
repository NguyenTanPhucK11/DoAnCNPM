Imports QuanLyDaiLy_BUS
Imports QuanLyDaiLy_DTO
Imports Utility
Public Class frmThemMatHang
    Private mhBus As MatHang_BUS
    Private Sub bntNhap_Click(sender As Object, e As EventArgs) Handles bntNhap.Click
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

        If (mhBus.isValidCount(mh) = False) Then
            MessageBox.Show("Vượt quá số lượng mặt hàng cho phép. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = mhBus.insert(mh)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Mặt Hàng thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTenMH.Text = String.Empty
            txtSoLuongTon.Text = String.Empty

            ' Get Next ID
            Dim nextID As Integer
            result = mhBus.getNextID(nextID)
            If (result.FlagResult = True) Then
                txtMaMH.Text = nextID.ToString()
            Else
                MessageBox.Show("Lấy ID kế tiếp của Mặt Hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If

        Else
            MessageBox.Show("Thêm Mặt Hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
    Private Sub bntNhapDong_Click(sender As Object, e As EventArgs) Handles bntNhapDong.Click
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

        If (mhBus.isValidCount(mh) = False) Then
            MessageBox.Show("Vượt quá số lượng mặt hàng cho phép. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = mhBus.insert(mh)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Mặt Hàng thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Thêm Mặt Hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
    Private Sub frmThemMatHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mhBus = New MatHang_BUS()

        ' Get Next ID
        Dim nextID As Integer
        Dim result As Result
        result = mhBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            txtMaMH.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của Mặt Hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
End Class