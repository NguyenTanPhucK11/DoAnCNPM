Imports System.Configuration
Public Class frmMain

    Private ConnectionString As String
    Dim count As Integer
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Read ConnectionString value from App.config file
        ConnectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Cursor.Position.X > 1203 And Cursor.Position.X < 1336 Then
            If Cursor.Position.Y > 53 And Cursor.Position.Y < 103 Then
                count = 1
            ElseIf Cursor.Position.Y > 129 And Cursor.Position.Y < 179 Then
                count = 2
            ElseIf Cursor.Position.Y > 215 And Cursor.Position.Y < 264 Then
                count = 3
            ElseIf Cursor.Position.Y > 293 And Cursor.Position.Y < 341 Then
                count = 4
            Else
                count = 0
            End If
        End If
        Select Case count
            Case 0
                tThoat.Hide()
                tThemPX.Hide()
                tQLPX.Hide()
                tThemMH.Hide()
                tQLMH.Hide()
                tThemDVT.Hide()
                tQLDVT.Hide()
                tThemCTPX.Hide()
                tQLCTPX.Hide()
                tThemLDL.Hide()
                tQLLDL.Hide()
                tThemQ.Hide()
                tQLQ.Hide()
                tThemDL.Hide()
                tQLDL.Hide()
                tThemPT.Hide()
                tQLPT.Hide()
            Case 1
                tThoat.Show()
                tThemPX.Hide()
                tQLPX.Hide()
                tThemMH.Hide()
                tQLMH.Hide()
                tThemDVT.Hide()
                tQLDVT.Hide()
                tThemCTPX.Hide()
                tQLCTPX.Hide()
                tThemLDL.Hide()
                tQLLDL.Hide()
                tThemQ.Hide()
                tQLQ.Hide()
                tThemDL.Hide()
                tQLDL.Hide()
                tThemPT.Hide()
                tQLPT.Hide()
            Case 2
                tThoat.Hide()
                tThemPX.Show()
                tQLPX.Show()
                tThemMH.Show()
                tQLMH.Show()
                tThemDVT.Show()
                tQLDVT.Show()
                tThemCTPX.Show()
                tQLCTPX.Show()
                tThemLDL.Hide()
                tQLLDL.Hide()
                tThemQ.Hide()
                tQLQ.Hide()
                tThemDL.Hide()
                tQLDL.Hide()
                tThemPT.Hide()
                tQLPT.Hide()
            Case 3
                tThoat.Hide()
                tThemPX.Hide()
                tQLPX.Hide()
                tThemMH.Hide()
                tQLMH.Hide()
                tThemDVT.Hide()
                tQLDVT.Hide()
                tThemCTPX.Hide()
                tQLCTPX.Hide()
                tThemLDL.Show()
                tQLLDL.Show()
                tThemQ.Show()
                tQLQ.Show()
                tThemDL.Show()
                tQLDL.Show()
                tThemPT.Hide()
                tQLPT.Hide()
            Case 4
                tThoat.Hide()
                tThemPX.Hide()
                tQLPX.Hide()
                tThemMH.Hide()
                tQLMH.Hide()
                tThemDVT.Hide()
                tQLDVT.Hide()
                tThemCTPX.Hide()
                tQLCTPX.Hide()
                tThemLDL.Hide()
                tQLLDL.Hide()
                tThemQ.Hide()
                tQLQ.Hide()
                tThemDL.Hide()
                tQLDL.Hide()
                tThemPT.Show()
                tQLPT.Show()
        End Select
    End Sub
    Private Sub tThemPX_Click(sender As Object, e As EventArgs) Handles tThemPX.Click
        Dim frm As frmThemPhieuXuat = New frmThemPhieuXuat()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub tQLPX_Click(sender As Object, e As EventArgs) Handles tQLPX.Click
        Dim frm As frmQLPhieuXuat = New frmQLPhieuXuat()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub tThemLDL_Click(sender As Object, e As EventArgs) Handles tThemLDL.Click
        Dim frm As frmThemLoaiDaiLy = New frmThemLoaiDaiLy()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub tQLLDL_Click(sender As Object, e As EventArgs) Handles tQLLDL.Click
        Dim frm As frmQLLoaiDaiLy = New frmQLLoaiDaiLy()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub tThemQ_Click(sender As Object, e As EventArgs) Handles tThemQ.Click
        Dim frm As frmThemQuan = New frmThemQuan()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub tQLQ_Click(sender As Object, e As EventArgs) Handles tQLQ.Click
        Dim frm As frmQLQuan = New frmQLQuan()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub tThemDL_Click(sender As Object, e As EventArgs) Handles tThemDL.Click
        Dim frm As frmThemDaiLy = New frmThemDaiLy()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub tQLDL_Click(sender As Object, e As EventArgs) Handles tQLDL.Click
        Dim frm As frmQLDaiLy = New frmQLDaiLy()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub tThemMH_Click(sender As Object, e As EventArgs) Handles tThemMH.Click
        Dim frm As frmThemMatHang = New frmThemMatHang()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub tQLMH_Click(sender As Object, e As EventArgs) Handles tQLMH.Click
        Dim frm As frmQLMatHang = New frmQLMatHang()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub tThemDVT_Click(sender As Object, e As EventArgs) Handles tThemDVT.Click
        Dim frm As frmThemDonViTinh = New frmThemDonViTinh()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub tQLDVT_Click(sender As Object, e As EventArgs) Handles tQLDVT.Click
        Dim frm As frmQLDonViTinh = New frmQLDonViTinh()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub tThemCTPX_Click(sender As Object, e As EventArgs) Handles tThemCTPX.Click
        Dim frm As frmThemChiTietPhieuXuat = New frmThemChiTietPhieuXuat()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub tQLCTPX_Click(sender As Object, e As EventArgs) Handles tQLCTPX.Click
        Dim frm As frmQLChiTietPhieuXuat = New frmQLChiTietPhieuXuat()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub tThemPT_Click(sender As Object, e As EventArgs) Handles tThemPT.Click
        Dim frm As frmThemPhieuThu = New frmThemPhieuThu()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub tQLPT_Click(sender As Object, e As EventArgs) Handles tQLPT.Click
        Dim frm As frmQLPhieuThu = New frmQLPhieuThu()
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub tQuydinh_Click(sender As Object, e As EventArgs) Handles tQuydinh.Click
        Dim frm As frmQuiDinh = New frmQuiDinh()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub tBCCongno_Click(sender As Object, e As EventArgs) Handles tBCCongno.Click
        Dim frm As frmBaoCaoCongNo = New frmBaoCaoCongNo()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub tBCDoanhSo_Click(sender As Object, e As EventArgs) Handles tBCDoanhSo.Click
        Dim frm As frmBaoCaoDoanhSo = New frmBaoCaoDoanhSo()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub tTraCuu_Click(sender As Object, e As EventArgs) Handles tTraCuu.Click
        Dim frm As frmTraCuuDaiLy = New frmTraCuuDaiLy()
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class
