Imports System.Configuration
Imports System.Data.SqlClient
Imports QuanLyDaiLy_DTO
Imports Utility

Public Class MatHang_DAL
    Private connectionString As String
    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function getNextMH(ByRef nextID As Integer) As Result

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MaMatHang] "
        query &= "FROM [tblMatHang] "
        query &= "ORDER BY [MaMatHang] DESC "

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
                    Dim idOnDB As String
                    idOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            idOnDB = reader("MaMatHang")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của Mặt Hàng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function insert(mh As MatHang_DTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblMatHang] ([MaMatHang], [TenMatHang], [SoLuongTon])"
        query &= "VALUES (@MaMatHang,@TenMatHang,@SoLuongTon)"

        Dim nextID = 0
        Dim result As Result
        result = getNextMH(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        mh.MaMatHang = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaMatHang", mh.MaMatHang)
                    .Parameters.AddWithValue("@TenMatHang", mh.TenMatHang)
                    .Parameters.AddWithValue("@SoLuongTon", mh.SoLuongTon)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm Mặt Hàng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(mh As MatHang_DTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblMatHang] SET"
        query &= " [TenMatHang] = @TenMatHang "
        query &= " ,[SoLuongTon] = @SoLuongTon "
        query &= "WHERE "
        query &= " [MaMatHang] = @MaMatHang "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaMatHang", mh.MaMatHang)
                    .Parameters.AddWithValue("@TenMatHang", mh.TenMatHang)
                    .Parameters.AddWithValue("@SoLuongTon", mh.SoLuongTon)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật Mặt Hàng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL(ByRef listMatHang As List(Of MatHang_DTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaMatHang], [TenMatHang], [SoLuongTon]"
        query &= "FROM [tblMatHang]"


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
                        listMatHang.Clear()
                        While reader.Read()
                            listMatHang.Add(New MatHang_DTO(reader("MaMatHang"), reader("TenMatHang"), reader("SoLuongTon")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Mặt Hàng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function delete(maMatHang As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblMatHang] "
        query &= " WHERE "
        query &= " [MaMatHang] = @MaMatHang "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaMatHang", maMatHang)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa Mặt Hàng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)  ' thanh cong
    End Function
    Public Function count() As Integer
        Dim query As String = String.Empty
        Dim sum As Integer

        query &= " SELECT COUNT(*) As somathang "
        query &= " FROM [tblMatHang]"

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
                        'reader.Read()
                        While reader.Read()
                            sum = reader("somathang")
                        End While
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
