Imports QuanLyDaiLy_BUS
Imports QuanLyDaiLy_DTO
Imports Utility
Public Class frmBaoCaoCongNo
    Private cnBus As CongNo_BUS
    Private Sub frmQLCongNo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnBus = New CongNo_BUS()
        If dtpTime.Value <> Nothing Then
            loadListCongNo()
        End If
    End Sub
    Private Sub loadListCongNo()
        If dtpTime.Value <> Nothing Then
            Dim listCN = New List(Of CongNo_DTO)
            listCN = cnBus.selectAll(dtpTime.Value.Month, dtpTime.Value.Year)
            dgvListCN.DataSource = New BindingSource(listCN, String.Empty)

            dgvListCN.Columns.Clear()
            dgvListCN.DataSource = Nothing

            dgvListCN.AutoGenerateColumns = False
            dgvListCN.AllowUserToAddRows = False
            dgvListCN.AutoResizeColumns()
            dgvListCN.DataSource = listCN

            Dim clDL = New DataGridViewTextBoxColumn()
            clDL.Name = "TenDaiLy"
            clDL.HeaderText = "Tên Đại Lý"
            clDL.DataPropertyName = "TenDaiLy"
            dgvListCN.Columns.Add(clDL)

            Dim clNoDau = New DataGridViewTextBoxColumn()
            clNoDau.Name = "NoDau"
            clNoDau.HeaderText = "Nợ Đầu"
            clNoDau.DataPropertyName = "NoDau"
            dgvListCN.Columns.Add(clNoDau)

            Dim clPhatSinh = New DataGridViewTextBoxColumn()
            clPhatSinh.Name = "PhatSinh"
            clPhatSinh.HeaderText = "Phát Sinh"
            clPhatSinh.DataPropertyName = "PhatSinh"
            dgvListCN.Columns.Add(clPhatSinh)

            Dim clNoCuoi = New DataGridViewTextBoxColumn()
            clNoCuoi.Name = "NoCuoi"
            clNoCuoi.HeaderText = "Nợ Cuối"
            clNoCuoi.DataPropertyName = "NoCuoi"
            dgvListCN.Columns.Add(clNoCuoi)
        End If
    End Sub
    Private Sub dtpTime_ValueChanged(sender As Object, e As EventArgs) Handles dtpTime.ValueChanged
        loadListCongNo()
        dtpTime.CustomFormat = "MM:yyyy"
        dtpTime.Format = DateTimePickerFormat.Custom
        dtpTime.ShowUpDown = True
    End Sub
End Class