Imports QuanLyDaiLy_BUS
Imports QuanLyDaiLy_DTO
Imports Utility
Public Class frmThemPhieuThu
    Private ptBus As PhieuThu_BUS
    Private dlBus As DaiLy_BUS
    Private Sub bntNhap_Click(sender As Object, e As EventArgs) Handles bntNhap.Click

        Dim phieuthu As PhieuThu_DTO
        phieuthu = New PhieuThu_DTO()
        Dim listphieuthu As List(Of PhieuThu_DTO)
        listphieuthu = New List(Of PhieuThu_DTO)

        '1. Mapping data from GUI control
        phieuthu.MaPhieuThuTIen = txtMaPT.Text
        phieuthu.NgayThuTien = dtpNgayThuTien.Value
        phieuthu.SoTienThu = txtSoTienThu.Text
        phieuthu.MaDaiLy = Convert.ToInt32(cbxMaDL.SelectedValue)

        '2. Business .....
        If (ptBus.isValidMax(phieuthu) = False) Then
            MessageBox.Show("Quá số tiền tối đa của 1 Đại Lý")
            Return
        End If

        '3. Insert to DB
        Dim result As Result
        result = ptBus.insert(phieuthu)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Phiếu Thu thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MSPX auto
            Dim nextMspt = "1"
            result = ptBus.buildMaCN(nextMspt)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh tự động mã Phiếu Thu không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
            txtMaPT.Text = nextMspt
            txtSoTienThu.Text = String.Empty

        Else
            MessageBox.Show("Thêm Phiếu Thu không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
    Private Sub bntNhapDong_Click(sender As Object, e As EventArgs) Handles bntNhapDong.Click
        Dim phieuthu As PhieuThu_DTO
        phieuthu = New PhieuThu_DTO()

        '1. Mapping data from GUI control
        phieuthu.MaPhieuThuTIen = txtMaPT.Text
        phieuthu.NgayThuTien = dtpNgayThuTien.Value
        phieuthu.SoTienThu = txtSoTienThu.Text
        phieuthu.MaDaiLy = Convert.ToInt32(cbxMaDL.SelectedValue)

        '2. Business .....
        If (ptBus.isValidMax(phieuthu) = False) Then
            MessageBox.Show("Quá số tiền tối đa của 1 Đại Lý")
            Return
        End If

        '3. Insert to DB
        Dim result As Result
        result = ptBus.insert(phieuthu)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Phiếu Thu thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Thêm Phiếu Thu không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
    Private Sub frmThemPhieuThu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ptBus = New PhieuThu_BUS
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
        cbxMaDL.DataSource = New BindingSource(listDaiLy, String.Empty)
        cbxMaDL.DisplayMember = "TenDaiLy"
        cbxMaDL.ValueMember = "MaDaiLy"

        'set MSPT auto
        Dim nextMspt1 = "1"
        result1 = ptBus.buildMaCN(nextMspt1)
        If (result1.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã Phiếu Thu không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result1.SystemMessage)
            Me.Close()
            Return
        End If
        txtMaPT.Text = nextMspt1
    End Sub
End Class