Imports QuanLyDaiLy_DAL
Imports QuanLyDaiLy_DTO
Imports Utility

Public Class Quan_BUS
    Private qDAL As Quan_DAL
    Public Sub New()
        qDAL = New Quan_DAL()
    End Sub
    Public Sub New(connectionString As String)
        qDAL = New Quan_DAL(connectionString)
    End Sub
    Public Function isValidName(q As Quan_DTO) As Boolean
        If (q.TenQuan.Length < 1) Then
            Return False
        End If
        Return True
    End Function
    Public Function insert(q As Quan_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return qDAL.insert(q)
    End Function
    Public Function update(q As Quan_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return qDAL.update(q)
    End Function
    Public Function delete(maLoai As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return qDAL.delete(maLoai)
    End Function
    Public Function selectAll(ByRef listQuan As List(Of Quan_DTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return qDAL.selectALL(listQuan)
    End Function
    Public Function selectALL_ByTenQuan(maquan As Integer, ByRef tenquan As String) As Result
        '1. verify data here!!

        '2. insert to DB
        Return qDAL.selectALL_ByTenQuan(maquan, tenquan)
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return qDAL.getNextID(nextID)
    End Function
End Class
