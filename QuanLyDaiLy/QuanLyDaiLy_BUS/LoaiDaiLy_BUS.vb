Imports QuanLyDaiLy_DAL
Imports QuanLyDaiLy_DTO
Imports Utility
Public Class LoaiDaiLy_BUS
    Private ldlDAL As LoaiDaiLy_DAL
    Public Sub New()
        ldlDAL = New LoaiDaiLy_DAL()
    End Sub
    Public Sub New(connectionString As String)
        ldlDAL = New LoaiDaiLy_DAL(connectionString)
    End Sub
    Public Function isValidName(ldl As LoaiDaiLy_DTO) As Boolean
        If (ldl.TenLoaiDL.Length < 1) Then
            Return False
        End If
        Return True
    End Function
    Public Function isValidCount(ldl As LoaiDaiLy_DTO) As Boolean
        Dim thamsoDTO As New QuiDinh_DTO
        Dim thamsoBUS As New QuiDinh_BUS
        thamsoBUS.selectALL(thamsoDTO)
        If (ldlDAL.count(ldl) >= thamsoDTO.SoLuongLoaiDaiLy) Then
            Return False
        End If
        Return True
    End Function
    Public Function insert(ldl As LoaiDaiLy_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ldlDAL.insert(ldl)
    End Function
    Public Function update(ldl As LoaiDaiLy_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ldlDAL.update(ldl)
    End Function
    Public Function delete(maLoai As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ldlDAL.delete(maLoai)
    End Function
    Public Function selectAll(ByRef listLoaiDL As List(Of LoaiDaiLy_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ldlDAL.selectALL(listLoaiDL)
    End Function
    Public Function selectNo(ByRef LoaiDL As DaiLy_DTO) As Integer
        '1. verify data here!!

        '2. insert to DB
        Return ldlDAL.selectNo(LoaiDL)
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return ldlDAL.buildMaLDL(nextID)
    End Function
End Class
