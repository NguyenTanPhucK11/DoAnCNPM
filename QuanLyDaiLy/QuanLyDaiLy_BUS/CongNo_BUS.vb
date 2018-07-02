Imports QuanLyDaiLy_DAL
Imports QuanLyDaiLy_DTO
Imports Utility
Public Class CongNo_BUS
    Private cnDAL As CongNo_DAL
    Public Sub New()
        cnDAL = New CongNo_DAL()
    End Sub
    Public Sub New(connectionString As String)
        cnDAL = New CongNo_DAL(connectionString)
    End Sub
    Public Function selectAll(month As Integer, year As Integer) As List(Of CongNo_DTO)
        '1. verify data here!!

        '2. insert to DB
        Return cnDAL.selectALL(month, year)
    End Function
End Class
