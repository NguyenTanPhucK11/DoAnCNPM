Imports System.Configuration
Imports System.Data.SqlClient
Imports QuanLyDaiLy_DTO
Imports Utility
Public Class DoanhSo_DAL
    Private connectionString As String
    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function selectALL(month As Integer, year As Integer) As List(Of DoanhSo_DTO)
        Dim listpx = New List(Of PhieuXuatDisplay)
        Dim pxDAL = New ChiTietPhieuXuat_DAL
        Dim listThongKe = New List(Of DoanhSo_DTO)

        pxDAL.selectBaoCao(month, year, listpx)

        For Each px In listpx
            listThongKe.Add(New DoanhSo_DTO(px.TenDaiLy, pxDAL.demSoPhieuXuat(px.MaDaiLy, px), pxDAL.Sum(px.MaDaiLy), 0.0))
        Next

        Dim tongtrigia As Integer = 0
        For Each dt In listThongKe
            tongtrigia += dt.TongTriGia
        Next

        For Each dt In listThongKe
            dt.TyLe = dt.TongTriGia * 100 / tongtrigia
        Next

        Return listThongKe
    End Function
End Class
