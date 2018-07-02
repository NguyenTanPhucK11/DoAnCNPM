Imports QuanLyDaiLy_BUS
Imports QuanLyDaiLy_DTO
Imports Utility
Public Class frmBaoCaoDoanhSo
    Private dsBus As DoanhSo_BUS
    Dim ilist As List(Of DoanhSo_DTO)
    Private Sub frmBaoCaoDoanhSo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dsBus = New DoanhSo_BUS()
        If (dtpTime.Value <> Nothing) Then
            loadListDoanhSo()
        End If
    End Sub
    Private Sub loadListDoanhSo()
        If dtpTime.Value <> Nothing Then
            Dim listDS = New List(Of DoanhSo_DTO)
            listDS = dsBus.selectALL(dtpTime.Value.Month, dtpTime.Value.Year)
            dgvListDS.DataSource = New BindingSource(listDS, String.Empty)

            dgvListDS.Columns.Clear()
            dgvListDS.DataSource = Nothing

            dgvListDS.AutoGenerateColumns = False
            dgvListDS.AllowUserToAddRows = False
            dgvListDS.AutoResizeColumns()
            dgvListDS.DataSource = listDS

            Dim clDL = New DataGridViewTextBoxColumn()
            clDL.Name = "TenDaiLy"
            clDL.HeaderText = "Tên Đại Lý"
            clDL.DataPropertyName = "TenDaiLy"
            dgvListDS.Columns.Add(clDL)

            Dim clSoPhieuXuat = New DataGridViewTextBoxColumn()
            clSoPhieuXuat.Name = "SoPhieuXuat"
            clSoPhieuXuat.HeaderText = "Số Phiếu Xuất"
            clSoPhieuXuat.DataPropertyName = "SoPhieuXuat"
            dgvListDS.Columns.Add(clSoPhieuXuat)

            Dim clTongTriGia = New DataGridViewTextBoxColumn()
            clTongTriGia.Name = "TongTriGia"
            clTongTriGia.HeaderText = "Tổng Trị Giá"
            clTongTriGia.DataPropertyName = "TongTriGia"
            dgvListDS.Columns.Add(clTongTriGia)

            Dim clTyLe = New DataGridViewTextBoxColumn()
            clTyLe.Name = "TyLe"
            clTyLe.HeaderText = "Tỷ Lệ"
            clTyLe.DataPropertyName = "TyLe"
            dgvListDS.Columns.Add(clTyLe)
        End If
    End Sub
    Private Sub dtpTime_ValueChanged(sender As Object, e As EventArgs) Handles dtpTime.ValueChanged
        loadListDoanhSo()
        dtpTime.CustomFormat = "MM:yyyy"
        dtpTime.Format = DateTimePickerFormat.Custom
        dtpTime.ShowUpDown = True
    End Sub
    Public Function remove(argList As List(Of DoanhSo_DTO)) As List(Of DoanhSo_DTO)
        argList = dsBus.selectALL(dtpTime.Value.Month, dtpTime.Value.Year)
        Dim locallist As New List(Of DoanhSo_DTO)()
        Dim i As Integer
        For i = 0 To argList.Count - 1
            If listContains(locallist, argList(i)) Then
                Continue For
            End If
            locallist.Add(argList(i))
        Next
        Return locallist
    End Function
    Private Shared Function listContains(argList As List(Of DoanhSo_DTO), fi As DoanhSo_DTO) As Boolean
        Dim i As Integer
        For i = 0 To argList.Count - 1
            If argList(i).TenDaiLy = fi.TenDaiLy Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dgvListDS.DataSource = remove(ilist)
    End Sub
End Class