Imports QuanLyDaiLy_DAL
Imports QuanLyDaiLy_DTO
Imports Utility
Public Class PhieuThu_BUS
    Private ptDAL As PhieuThu_DAL
    Public Sub New()
        ptDAL = New PhieuThu_DAL()
    End Sub
    Public Sub New(connectionString As String)
        ptDAL = New PhieuThu_DAL(connectionString)
    End Sub
    Public Function insert(pt As PhieuThu_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ptDAL.insert(pt)
    End Function
    Public Function update(pt As PhieuThu_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ptDAL.update(pt)
    End Function
    Public Function delete(maLoai As String) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ptDAL.delete(maLoai)
    End Function
    Public Function selectAll(ByRef listCN As List(Of PhieuThu_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ptDAL.selectALL(listCN)
    End Function
    Public Function selectALL_ByMaDaiLy(iMaDaiLy As Integer, ByRef listPT As List(Of PhieuThu_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ptDAL.selectALL_ByMaDaiLy(iMaDaiLy, listPT)
    End Function
    Public Function buildMaCN(ByRef nextMspt As String) As Result
        Return ptDAL.buildMaPT(nextMspt)
    End Function
    Public Function isValidMax(phieuthu As PhieuThu_DTO) As Boolean
        Dim dailyBUS As New DaiLy_BUS
        If (phieuthu.SoTienThu > dailyBUS.selectNo(phieuthu.MaDaiLy)) Then
            Return False
        End If
        Return True
    End Function
End Class
