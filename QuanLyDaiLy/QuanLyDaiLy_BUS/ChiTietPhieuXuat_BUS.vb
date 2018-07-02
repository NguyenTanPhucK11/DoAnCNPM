Imports QuanLyDaiLy_DAL
Imports QuanLyDaiLy_DTO
Imports Utility
Public Class ChiTietPhieuXuat_BUS
    Private ctpxDAL As ChiTietPhieuXuat_DAL
    Public Sub New()
        ctpxDAL = New ChiTietPhieuXuat_DAL()
    End Sub
    Public Sub New(connectionString As String)
        ctpxDAL = New ChiTietPhieuXuat_DAL(connectionString)
    End Sub
    Public Function insert(ctpx As ChiTietPhieuXuat_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ctpxDAL.insert(ctpx)
    End Function
    Public Function update(ctpx As ChiTietPhieuXuat_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ctpxDAL.update(ctpx)
    End Function
    Public Function delete(maLoai As String) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ctpxDAL.delete(maLoai)
    End Function
    Public Function selectAll(ByRef listLoaiDL As List(Of ChiTietPhieuXuat_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ctpxDAL.selectALL(listLoaiDL)
    End Function
    Public Function selectALL_ByMaPhieuXuat(iMaPhieuXuat As Integer, ByRef listCTPX As List(Of PhieuXuatDisplay)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ctpxDAL.selectALL_ByMaPhieuXuat(iMaPhieuXuat, listCTPX)
    End Function
    Public Function selectALL_ByMaMatHang(iMaMatHang As Integer, ByRef listCTPX As List(Of PhieuXuatDisplay)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ctpxDAL.selectALL_ByMaMatHang(iMaMatHang, listCTPX)
    End Function
    Public Function selectALL_ByMaDonViTinh(iMaDonViTinh As Integer, ByRef listCTPX As List(Of PhieuXuatDisplay)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ctpxDAL.selectALL_ByMaDonViTinh(iMaDonViTinh, listCTPX)
    End Function
    Public Function buildMaCTPX(ByRef nextMsctpx As String) As Result
        Return ctpxDAL.buildMaCTPX(nextMsctpx)
    End Function
    Public Function demSoPhieuXuat(madl As String, ctpx As PhieuXuatDisplay) As Integer
        Return ctpxDAL.demSoPhieuXuat(madl, ctpx)
    End Function
    Public Function selectBaoCao(month As Integer, year As Integer, listDS As List(Of PhieuXuatDisplay)) As Result
        Return ctpxDAL.selectBaoCao(month, year, listDS)
    End Function
    Public Function Sum(madl As String) As Integer
        Return ctpxDAL.Sum(madl)
    End Function
End Class
