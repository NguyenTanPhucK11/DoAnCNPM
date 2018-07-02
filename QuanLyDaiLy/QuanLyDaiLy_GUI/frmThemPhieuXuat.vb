Imports QuanLyDaiLy_BUS
Imports QuanLyDaiLy_DTO
Imports Utility
Public Class frmThemPhieuXuat
    Private pxBus As PhieuXuat_BUS
    Private dlBus As DaiLy_BUS
    Private Sub bntNhap_Click(sender As Object, e As EventArgs) Handles bntNhap.Click
        Dim phieuxuat As PhieuXuat_DTO
        phieuxuat = New PhieuXuat_DTO()
        Dim listphieuxuat As List(Of PhieuXuat_DTO)
        listphieuxuat = New List(Of PhieuXuat_DTO)

        '1. Mapping data from GUI control
        phieuxuat.MaPhieuXuat = txtMaPX.Text
        phieuxuat.NgayLapPhieu = dtpNgayLapPhieu.Value
        phieuxuat.MaDaiLy = Convert.ToInt32(cBxMaDL.SelectedValue)

        '2. Business .....

        '3. Insert to DB
        Dim result As Result
        result = pxBus.insert(phieuxuat)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Phiếu Xuất thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MSPX auto
            Dim nextMspx = "1"
            result = pxBus.getNextPhieu(nextMspx)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh tự động mã Phiếu Xuất không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
            txtMaPX.Text = nextMspx
        Else
            MessageBox.Show("Thêm Phiếu Xuất không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
    Private Sub bntNhapDong_Click(sender As Object, e As EventArgs) Handles bntNhapDong.Click
        Dim phieuxuat As PhieuXuat_DTO
        phieuxuat = New PhieuXuat_DTO()

        '1. Mapping data from GUI control
        phieuxuat.MaPhieuXuat = txtMaPX.Text
        phieuxuat.NgayLapPhieu = dtpNgayLapPhieu.Value
        phieuxuat.MaDaiLy = Convert.ToInt32(cBxMaDL.SelectedValue)

        '2. Business .....

        '3. Insert to DB
        Dim result As Result
        result = pxBus.insert(phieuxuat)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Phiếu Xuất thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Thêm Phiếu Xuất không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
    Private Sub frmThemPhieuXuat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pxBus = New PhieuXuat_BUS
        dlBus = New DaiLy_BUS()

        ' Load MaDaiLy list
        Dim listDaiLy = New List(Of DaiLy_DTO)
        Dim result1 As Result
        result1 = dlBus.selectAll(listDaiLy)
        If (result1.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Mã Đại Lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result1.SystemMessage)
            Me.Close()
            Return
        End If
        cBxMaDL.DataSource = New BindingSource(listDaiLy, String.Empty)
        cBxMaDL.DisplayMember = "TenDaiLy"
        cBxMaDL.ValueMember = "MaDaiLy"

        'set MSPX auto
        Dim nextMspx1 = "1"
        result1 = pxBus.getNextPhieu(nextMspx1)
        If (result1.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã Phiếu Xuất không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result1.SystemMessage)
            Me.Close()
            Return
        End If
        txtMaPX.Text = nextMspx1
    End Sub
End Class