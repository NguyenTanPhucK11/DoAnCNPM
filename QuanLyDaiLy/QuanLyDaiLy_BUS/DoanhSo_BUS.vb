Imports QuanLyDaiLy_DAL
Imports QuanLyDaiLy_DTO
Imports Utility
Public Class DoanhSo_BUS
    Private dsDAL As DoanhSo_DAL
    Public Sub New()
        dsDAL = New DoanhSo_DAL()
    End Sub
    Public Sub New(connectionString As String)
        dsDAL = New DoanhSo_DAL(connectionString)
    End Sub
    Public Function selectALL(month As Integer, year As Integer) As List(Of DoanhSo_DTO)
        Return dsDAL.selectALL(month, year)
    End Function

End Class
