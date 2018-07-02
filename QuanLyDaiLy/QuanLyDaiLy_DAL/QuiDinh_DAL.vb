Imports System.Configuration
Imports System.Data.SqlClient
Imports QuanLyDaiLy_DTO
Imports Utility
Public Class QuiDinh_DAL
    Private connectionString As String
    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function update(qd As QuiDinh_DTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblThamSo] SET"
        query &= " [SoLuongLoaiDaiLy] = @SoLuongLoaiDaiLy "
        query &= " ,[SoLuongDaiLyToiDa] = @SoLuongDaiLyToiDa "
        query &= " ,[SoLuongMatHang] = @SoLuongMatHang "
        query &= " WHERE "
        query &= " [Id] = @Id "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@SoLuongLoaiDaiLy", qd.SoLuongLoaiDaiLy)
                    .Parameters.AddWithValue("@SoLuongDaiLyToiDa", qd.SoLuongDaiLyToiDa)
                    .Parameters.AddWithValue("@SoLuongMatHang", qd.SoLuongMatHang)
                    .Parameters.AddWithValue("@Id", qd.ID)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật Qui Định không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL(ByRef qd As QuiDinh_DTO) As Result
        Dim query As String = String.Empty
        query &= "SELECT [Id], [SoLuongLoaiDaiLy], [SoLuongDaiLyToiDa], [SoLuongMatHang]"
        query &= "FROM [tblThamSo]"

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
                    While reader.Read()
                        qd = New QuiDinh_DTO(reader("Id"), reader("SoLuongLoaiDaiLy"), reader("SoLuongDaiLyToiDa"), reader("SoLuongMatHang"))
                    End While
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy Qui Định không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
