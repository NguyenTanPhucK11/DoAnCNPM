Imports System.Configuration
Imports System.Data.SqlClient
Imports QuanLyDaiLy_DTO
Imports Utility
Public Class PhieuXuat_DAL
    Private connectionString As String
    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function getNextPhieu(ByRef nextID As Integer) As Result
        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MaPhieuXuat] "
        query &= "FROM [tblPhieuXuat] "
        query &= "ORDER BY [MaPhieuXuat] DESC "

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
                            idOnDB = reader("MaPhieuXuat")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của Phiếu Xuất không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function insert(px As PhieuXuat_DTO) As Result
        Dim query As String = String.Empty
        query &= "INSERT INTO [tblPhieuXuat] ([MaPhieuXuat], [MaDaiLy], [NgayLapPhieu])"
        query &= "VALUES (@MaPhieuXuat,@MaDaiLy,@NgayLapPhieu)"

        Dim nextID = 0
        Dim result As Result
        result = getNextPhieu(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        px.MaPhieuXuat = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaPhieuXuat", px.MaPhieuXuat)
                    .Parameters.AddWithValue("@MaDaiLy", px.MaDaiLy)
                    .Parameters.AddWithValue("@NgayLapPhieu", px.NgayLapPhieu)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm Phiếu Xuất không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(px As PhieuXuat_DTO) As Result
        Dim query As String = String.Empty
        query &= " UPDATE [tblPhieuXuat] SET"
        query &= " [MaDaiLy] = @MaDaiLy "
        query &= " ,[NgayLapPhieu] = @NgayLapPhieu "
        query &= "WHERE "
        query &= " [MaPhieuXuat] = @MaPhieuXuat "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaPhieuXuat", px.MaPhieuXuat)
                    .Parameters.AddWithValue("@MaDaiLy", px.MaDaiLy)
                    .Parameters.AddWithValue("@NgayLapPhieu", px.NgayLapPhieu)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật Phiếu Xuất không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL(ByRef listPhieuxuat As List(Of PhieuXuat_DTO)) As Result
        Dim query As String = String.Empty
        query &= "SELECT [MaPhieuXuat], [MaDaiLy], [NgayLapPhieu]"
        query &= "FROM [tblPhieuXuat]"


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
                        listPhieuxuat.Clear()
                        While reader.Read()
                            listPhieuxuat.Add(New PhieuXuat_DTO(reader("MaPhieuXuat"), reader("MaDaiLy"), reader("NgayLapPhieu")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Phiếu Xuất không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL_ByMaDL(maDL As Integer, ByRef listPhieuXuat As List(Of PhieuXuat_DTO)) As Result
        Dim query As String = String.Empty
        query &= "SELECT [MaPhieuXuat], [MaDaiLy], [NgayLapPhieu]"
        query &= "FROM [tblPhieuXuat]"
        query &= "WHERE [MaDaiLy] = @MaDaiLy"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaDaiLy", maDL)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listPhieuXuat.Clear()
                        While reader.Read()
                            listPhieuXuat.Add(New PhieuXuat_DTO(reader("MaPhieuXuat"), reader("MaDaiLy"), reader("NgayLapPhieu")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Phiếu Xuất theo Mã Đại Lý không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function delete(maPhieuXuat As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblPhieuXuat] "
        query &= " WHERE "
        query &= " [MaPhieuXuat] = @MaPhieuXuat "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaPhieuXuat", maPhieuXuat)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa Phiếu Xuất không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)  ' thanh cong
    End Function
End Class
