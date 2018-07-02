Imports QuanLyDaiLy_DAL
Imports QuanLyDaiLy_DTO
Imports Utility
Public Class MatHang_BUS
    Private mhDAL As MatHang_DAL
    Public Sub New()
        mhDAL = New MatHang_DAL()
    End Sub
    Public Sub New(connectionString As String)
        mhDAL = New MatHang_DAL(connectionString)
    End Sub
    Public Function isValidName(mh As MatHang_DTO) As Boolean
        If (mh.TenMatHang.Length < 1) Then
            Return False
        End If
        Return True
    End Function
    Public Function insert(mh As MatHang_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return mhDAL.insert(mh)
    End Function
    Public Function update(mh As MatHang_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return mhDAL.update(mh)
    End Function
    Public Function delete(maLoai As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return mhDAL.delete(maLoai)
    End Function
    Public Function selectAll(ByRef listLoaiDL As List(Of MatHang_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return mhDAL.selectALL(listLoaiDL)
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return mhDAL.getNextMH(nextID)
    End Function
    Public Function isValidCount(mh As MatHang_DTO) As Boolean
        Dim thamsoDTO As New QuiDinh_DTO
        Dim thamsoBUS As New QuiDinh_BUS
        thamsoBUS.selectALL(thamsoDTO)
        If (mhDAL.count() >= thamsoDTO.SoLuongMatHang) Then
            Return False
        End If
        Return True
    End Function
End Class
