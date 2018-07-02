Imports QuanLyDaiLy_DAL
Imports QuanLyDaiLy_DTO
Imports Utility
Public Class PhieuXuat_BUS
    Private pxDAL As PhieuXuat_DAL
    Public Sub New()
        pxDAL = New PhieuXuat_DAL()
    End Sub
    Public Sub New(connectionString As String)
        pxDAL = New PhieuXuat_DAL(connectionString)
    End Sub
    Public Function insert(px As PhieuXuat_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return pxDAL.insert(px)
    End Function
    Public Function update(px As PhieuXuat_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return pxDAL.update(px)
    End Function
    Public Function delete(maLoai As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return pxDAL.delete(maLoai)
    End Function
    Public Function selectAll(ByRef listLoaiDL As List(Of PhieuXuat_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return pxDAL.selectALL(listLoaiDL)
    End Function
    Public Function selectALL_ByMaDL(maDL As Integer, ByRef listPX As List(Of PhieuXuat_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return pxDAL.selectALL_ByMaDL(maDL, listPX)
    End Function
    Public Function getNextPhieu(ByRef nextMspx As Integer) As Result
        Return pxDAL.getNextPhieu(nextMspx)
    End Function
End Class
