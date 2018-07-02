Imports QuanLyDaiLy_DAL
Imports QuanLyDaiLy_DTO
Imports Utility
Public Class DonViTinh_BUS
    Private dvtDAL As DonViTinh_DAL
    Public Sub New()
        dvtDAL = New DonViTinh_DAL()
    End Sub
    Public Sub New(connectionString As String)
        dvtDAL = New DonViTinh_DAL(connectionString)
    End Sub
    Public Function isValidName(dvt As DonViTinh_DTO) As Boolean
        If (dvt.TenDonViTinh.Length < 1) Then
            Return False
        End If

        Return True

    End Function
    Public Function insert(dvt As DonViTinh_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dvtDAL.insert(dvt)
    End Function
    Public Function update(dvt As DonViTinh_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dvtDAL.update(dvt)
    End Function
    Public Function delete(maLoai As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dvtDAL.delete(maLoai)
    End Function
    Public Function selectAll(ByRef listLoaiDL As List(Of DonViTinh_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dvtDAL.selectALL(listLoaiDL)
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return dvtDAL.buildMaDVT(nextID)
    End Function
End Class
