Imports QuanLyDaiLy_DAL
Imports QuanLyDaiLy_DTO
Imports Utility

Public Class DaiLy_BUS
    Private dlDAL As DaiLy_DAL
    Public Sub New()
        dlDAL = New DaiLy_DAL()
    End Sub
    Public Sub New(connectionString As String)
        dlDAL = New DaiLy_DAL(connectionString)
    End Sub
    Public Function isValidName(dl As DaiLy_DTO) As Boolean
        If (dl.TenDaiLy.Length < 1) Then
            Return False
        End If
        Return True
    End Function
    Public Function insert(dl As DaiLy_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dlDAL.insert(dl)
    End Function
    Public Function update(dl As DaiLy_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dlDAL.update(dl)
    End Function
    Public Function delete(maLoai As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dlDAL.delete(maLoai)
    End Function
    Public Function selectAll(ByRef listDL As List(Of DaiLy_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dlDAL.selectALL(listDL)
    End Function
    Public Function selectALL_ByType(maLoai As Integer, ByRef listDL As List(Of DaiLyDisplay)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dlDAL.selectALL_ByType(maLoai, listDL)
    End Function
    Public Function selectALL_ByTenDaiLy(strTenDL As String, ByRef listDL As List(Of DaiLyDisplay)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dlDAL.selectALL_ByTenDL(strTenDL, listDL)
    End Function
    Public Function selectALL_ByMaQuan(iMaQuan As Integer, ByRef listDL As List(Of DaiLyDisplay)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dlDAL.selectALL_ByMaQuan(iMaQuan, listDL)
    End Function
    Public Function selectALL_ByTenQuan(strTenQuan As String, ByRef listDL As List(Of DaiLyDisplay)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dlDAL.selectALL_ByTenQuan(strTenQuan, listDL)
    End Function
    Public Function selectALL_ByTenLoaiDL(strTenLDL As String, ByRef listDL As List(Of DaiLyDisplay)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dlDAL.selectALL_ByTenLoaiDL(strTenLDL, listDL)
    End Function
    Public Function selectALL_ByTienNo(iTien As Integer, ByRef listDL As List(Of DaiLyDisplay)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dlDAL.selectALL_ByTienNo(iTien, listDL)
    End Function
    Public Function selectBaoCaoCongNo(month As Integer, year As Integer, listDL As List(Of DaiLy_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dlDAL.selectBaoCaoCongNo(month, year, listDL)
    End Function
    Public Function buildMaDL(ByRef nextMsdl As String) As Result
        Return dlDAL.buildMaDL(nextMsdl)
    End Function
    Public Function isValidCount(daily As DaiLy_DTO) As Boolean
        Dim thamsoDTO As New QuiDinh_DTO
        Dim thamsoBUS As New QuiDinh_BUS
        thamsoBUS.selectALL(thamsoDTO)
        If (dlDAL.count(daily) >= thamsoDTO.SoLuongDaiLyToiDa) Then
            Return False
        End If
        Return True
    End Function
    Public Function isValidMax(daily As DaiLy_DTO) As Boolean
        Dim loaidlBUS As New LoaiDaiLy_BUS
        If (daily.NoCuaDaiLy > loaidlBUS.selectNo(daily)) Then
            Return False
        End If
        Return True
    End Function
    Public Function selectNo(madl As String) As Integer
        Return dlDAL.selectNo(madl)
    End Function
End Class
