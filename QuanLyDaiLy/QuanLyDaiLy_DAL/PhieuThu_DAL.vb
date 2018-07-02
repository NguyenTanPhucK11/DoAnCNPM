Imports System.Configuration
Imports System.Data.SqlClient
Imports QuanLyDaiLy_DTO
Imports Utility
Public Class PhieuThu_DAL
    Private connectionString As String
    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function buildMaPT(ByRef nextMspt As String) As Result

        Dim x As String = "PTT-"
        nextMspt = String.Empty
        nextMspt = x + ""

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MaPhieuThuTien] "
        query &= "FROM [tblPhieuThuTien] "
        query &= "ORDER BY [MaPhieuThuTien] DESC "

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
                            idOnDB = reader("MaPhieuThuTien")
                        End While
                    End If
                    ' new ID = current ID + 1
                    Dim v = idOnDB.Substring(5)
                    Dim convertDecimal = Convert.ToDecimal(v)
                    convertDecimal = convertDecimal + 1
                    Dim tmp = convertDecimal.ToString()
                    tmp = tmp.PadLeft(idOnDB.Length - 4, "0")
                    nextMspt = nextMspt + tmp
                    System.Console.WriteLine(nextMspt)
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextMspt = 1
                    Return New Result(False, "Lấy ID kế tiếp của Phiếu Thu Tiền không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function insert(pt As PhieuThu_DTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblPhieuThuTien] ([MaPhieuThuTien], [MaDaiLy], [NgayThuTien], [SoTienThu])"
        query &= "VALUES (@MaPhieuThuTien,@MaDaiLy,@NgayThuTien,@SoTienThu)"

        'get MSHS
        Dim nextMapt = "1"
        buildMaPT(nextMapt)
        pt.MaPhieuThuTien = nextMapt

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaPhieuThuTien", pt.MaPhieuThuTien)
                    .Parameters.AddWithValue("@MaDaiLy", pt.MaDaiLy)
                    .Parameters.AddWithValue("@NgayThuTien", pt.NgayThuTien)
                    .Parameters.AddWithValue("@SoTienThu", pt.SoTienThu)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm Phiếu Thu Tiền không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL(ByRef listPhieuThu As List(Of PhieuThu_DTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaPhieuThuTien], [MaDaiLy],  [NgayThuTien], [SoTienThu]"
        query &= "FROM [tblPhieuThuTien]"


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
                        listPhieuThu.Clear()
                        While reader.Read()
                            listPhieuThu.Add(New PhieuThu_DTO(reader("MaPhieuThuien"), reader("MaDaiLy"), reader("NgayThuTien"), reader("SoTienThu")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Phiếu Thu Tiền không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL_ByMaDaiLy(madaily As Integer, ByRef listPhieuThu As List(Of PhieuThu_DTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaPhieuThuTien], [MaDaiLy], [NgayThuTien], [SoTienThu]"
        query &= "FROM [tblPhieuThuTien]"
        query &= "WHERE [MaDaiLy] = @MaDaiLy"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaDaiLy", madaily)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listPhieuThu.Clear()
                        While reader.Read()
                            listPhieuThu.Add(New PhieuThu_DTO(reader("MaPhieuThuTien"), reader("MaDaiLy"), reader("NgayThuTien"), reader("SoTienThu")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Phiếu Thu Tiền theo Mã Đại Lý không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(pt As PhieuThu_DTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblPhieuThuTien] SET"
        query &= " [MaDaiLy] = @MaDaiLy "
        query &= " ,[NgayThuTien] = @NgayThuTien "
        query &= " ,[SoTienThu] = @SoTienThu "
        query &= " WHERE "
        query &= " [MaPhieuThuTien] = @MaPhieuThuTien "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaDaiLy", pt.MaDaiLy)
                    .Parameters.AddWithValue("@NgayThuTien", pt.NgayThuTien)
                    .Parameters.AddWithValue("@SoTienThu", pt.SoTienThu)
                    .Parameters.AddWithValue("@MaPhieuThuTien", pt.MaPhieuThuTien)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Cập nhật Phiếu Thu Tiền không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function delete(maPhieuThu As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblPhieuThuTien] "
        query &= " WHERE "
        query &= " [MaPhieuThuTien] = @MaPhieuThuTien "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaPhieuThuTien", maPhieuThu)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa Phiếu Thu Tiền không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)  ' thanh cong
    End Function
End Class
