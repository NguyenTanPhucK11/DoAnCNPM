Imports System.Configuration
Imports System.Data.SqlClient
Imports QuanLyDaiLy_DTO
Imports Utility
Public Class LoaiDaiLy_DAL
    Private connectionString As String
    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function buildMaLDL(ByRef nextID As Integer) As Result

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MaLoaiDaiLy] "
        query &= "FROM [tblLoaiDaiLy] "
        query &= "ORDER BY [MaLoaiDaiLy] DESC "

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
                            idOnDB = reader("MaLoaiDaiLy")
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
    Public Function insert(ldl As LoaiDaiLy_DTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblLoaiDaiLy] ([MaLoaiDaiLy], [TenLoaiDaiLy], [NoToiDa])"
        query &= "VALUES (@MaLoaiDaiLy,@TenLoaiDaiLy,@NoToiDa)"

        Dim nextID = 0
        Dim result As Result
        result = buildMaLDL(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        ldl.MaLoaiDL = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaLoaiDaiLy", ldl.MaLoaiDL)
                    .Parameters.AddWithValue("@TenLoaiDaiLy", ldl.TenLoaiDL)
                    .Parameters.AddWithValue("@NoToiDa", ldl.NoToiDa)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm Đại Lý không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(ldl As LoaiDaiLy_DTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblLoaiDaiLy] SET"
        query &= " [TenLoaiDaiLy] = @TenLoaiDaiLy "
        query &= " ,[NoToiDa] = @NoToiDa "
        query &= "WHERE "
        query &= " [MaLoaiDaiLy] = @MaLoaiDaiLy "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaLoaiDaiLy", ldl.MaLoaiDL)
                    .Parameters.AddWithValue("@TenLoaiDaiLy", ldl.TenLoaiDL)
                    .Parameters.AddWithValue("@NoToiDa", ldl.NoToiDa)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật Đại Lý không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL(ByRef listLoaiDL As List(Of LoaiDaiLy_DTO)) As Result
        Dim query As String = String.Empty
        query &= " SELECT [MaLoaiDaiLy], [TenLoaiDaiLy], [NoToiDa]"
        query &= " FROM [tblLoaiDaiLy]"


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
                        listLoaiDL.Clear()
                        While reader.Read()
                            listLoaiDL.Add(New LoaiDaiLy_DTO(reader("MaLoaiDaiLy"), reader("TenLoaiDaiLy"), reader("NoToiDa")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả Loại Đại Lý không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectNo(LoaiDL As DaiLy_DTO) As Integer
        Dim query As String = String.Empty
        Dim maldl As String = LoaiDL.MaLoaiDaiLy
        Dim kq As Integer

        query &= " SELECT [NoToiDa] AS No"
        query &= " FROM [tblLoaiDaiLy]"
        query &= " WHERE [MaLoaiDaiLy] = @MaLoaiDaiLy "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaLoaiDaiLy", maldl)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            kq = reader("No")
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                End Try
            End Using
        End Using
        Return kq
    End Function
    Public Function delete(maLoai As Integer) As Result
        Dim query As String = String.Empty
        query &= " DELETE FROM [tblLoaiDaiLy] "
        query &= " WHERE "
        query &= " [MaLoaiDaiLy] = @MaLoaiDaiLy "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaLoaiDaiLy", maLoai)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa Đại Lý không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function count(loai As LoaiDaiLy_DTO) As Integer
        Dim query As String = String.Empty
        Dim loaidl As String = loai.MaLoaiDL
        Dim sum As Integer

        query &= " SELECT COUNT(*) As SOLOAIDAILY "
        query &= " FROM [tblLoaiDaiLy]"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand
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
                        reader.Read()
                        sum = reader("SOLOAIDAILY")
                    End If
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return 0
                Finally
                    conn.Close()
                End Try
            End Using
        End Using
        Return sum
    End Function
End Class
