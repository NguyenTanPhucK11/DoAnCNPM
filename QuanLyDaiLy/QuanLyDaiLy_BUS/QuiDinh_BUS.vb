Imports QuanLyDaiLy_DAL
Imports QuanLyDaiLy_DTO
Imports Utility
Public Class QuiDinh_BUS
    Private qdDAL As QuiDinh_DAL
    Public Sub New()
        qdDAL = New QuiDinh_DAL()
    End Sub
    Public Sub New(connnectionString As String)
        qdDAL = New QuiDinh_DAL(connnectionString)
    End Sub
    Public Function update(qd As QuiDinh_DTO) As Result
        Return qdDAL.update(qd)
    End Function
    Public Function selectALL(ByRef qd As QuiDinh_DTO) As Result
        Return qdDAL.selectALL(qd)
    End Function
End Class
