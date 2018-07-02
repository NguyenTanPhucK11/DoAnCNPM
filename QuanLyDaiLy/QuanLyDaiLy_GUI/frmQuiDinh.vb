Imports QuanLyDaiLy_BUS
Imports QuanLyDaiLy_DTO
Public Class frmQuiDinh
    Dim qdBus As QuiDinh_BUS
    Dim qd As QuiDinh_DTO
    Private Sub frmQuiDinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        qdBus = New QuiDinh_BUS()
        Dim result = qdBus.selectALL(qd)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy thông tin Qui Định không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
        End If
        txtSoLuongLoaiDaiLy.Text = qd.SoLuongDaiLyToiDa
        txtSoLuongDaiLyToiDa.Text = qd.SoLuongDaiLyToiDa
        txtSoLuongMatHang.Text = qd.SoLuongMatHang
    End Sub
    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        Try
            qd.SoLuongLoaiDaiLy = Integer.Parse(txtSoLuongLoaiDaiLy.Text)
            qd.SoLuongDaiLyToiDa = Integer.Parse(txtSoLuongDaiLyToiDa.Text)
            qd.SoLuongMatHang = Integer.Parse(txtSoLuongMatHang.Text)

            Dim result = qdBus.update(qd)
            If (result.FlagResult = False) Then
                MessageBox.Show("Cập nhật Qui Định không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If
            MessageBox.Show("Cập nhật Qui Định thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            System.Console.WriteLine(ex.StackTrace)
        End Try
    End Sub
End Class