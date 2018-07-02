Imports System.Configuration
Imports System.Data.SqlClient
Imports QuanLyDaiLy_DTO
Imports Utility
Public Class CongNo_DAL
    Private connectionString As String
    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function selectALL(month As Integer, year As Integer) As List(Of CongNo_DTO)
        Dim listdl = New List(Of DaiLy_DTO)
        Dim dlDAL = New DaiLy_DAL
        dlDAL.selectBaoCaoCongNo(month, year, listdl)
        Dim listThongKe = New List(Of CongNo_DTO)

        For Each dl In listdl
            listThongKe.Add(New CongNo_DTO(dl.TenDaiLy, dl.NoCuaDaiLy, 1000, 0))
        Next

        For Each tk In listThongKe
            tk.NoCuoi = tk.NoDau + tk.PhatSinh
        Next

        Return listThongKe
    End Function
End Class
