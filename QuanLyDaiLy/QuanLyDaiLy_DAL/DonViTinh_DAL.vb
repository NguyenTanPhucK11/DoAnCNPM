Imports System.Configuration
Imports System.Data.SqlClient
Imports QuanLyDaiLy_DTO
Imports Utility
Public Class DonViTinh_DAL
    Private connectionString As String
    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function buildMaDVT(ByRef nextID As Integer) As Result

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MaDonViTinh] "
        query &= "FROM [tblDonViTinh] "
        query &= "ORDER BY [MaDonViTinh] DESC "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    Dim idOnDB As Integer
                    idOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            idOnDB = reader("MaDonViTinh")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của Loại Đại Lý không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function insert(dvt As DonViTinh_DTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblDonViTinh] ([MaDonViTinh], [TenDonViTinh])"
        query &= "VALUES (@MaDonViTinh,@TenDonViTinh)"

        Dim nextID = 0
        Dim result As Result
        result = buildMaDVT(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        dvt.MaDonViTinh = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaDonViTinh", dvt.MaDonViTinh)
                    .Parameters.AddWithValue("@TenDonViTinh", dvt.TenDonViTinh)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm Đơn Vị Tính không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(dvt As DonViTinh_DTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblDonViTinh] SET"
        query &= " [TenDonViTinh] = @TenDonViTinh "
        query &= "WHERE "
        query &= " [MaDonViTinh] = @MaDonViTinh "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaDonViTinh", dvt.MaDonViTinh)
                    .Parameters.AddWithValue("@TenDonViTinh", dvt.TenDonViTinh)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật Đơn Vị Tính không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL(ByRef listDonViTinh As List(Of DonViTinh_DTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [MaDonViTinh], [TenDonViTinh]"
        query &= " FROM [tblDonViTinh]"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listDonViTinh.Clear()
                        While reader.Read()
                            listDonViTinh.Add(New DonViTinh_DTO(reader("MaDonViTinh"), reader("TenDonViTinh")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả Đơn Vị Tính không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function delete(maDVT As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblDonViTinh] "
        query &= " WHERE "
        query &= " [MaDonViTinh] = @MaDonViTinh "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaDonViTinh", maDVT)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa Đơn Vị Tính không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
