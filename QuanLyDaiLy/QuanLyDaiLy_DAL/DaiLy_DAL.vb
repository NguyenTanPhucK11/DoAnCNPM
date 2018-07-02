Imports System.Configuration
Imports System.Data.SqlClient
Imports QuanLyDaiLy_DTO
Imports Utility

Public Class DaiLy_DAL
    Private connectionString As String
    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function buildMaDL(ByRef nextMsdl As String) As Result 'ex: 18222229

        nextMsdl = String.Empty
        Dim y = DateTime.Now.Year
        Dim x = y.ToString().Substring(2)
        nextMsdl = x + "000000"

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MaDaiLy] "
        query &= "FROM [tblDaiLy] "
        query &= "ORDER BY [MaDaiLy] DESC "

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
                    Dim msOnDB As String
                    msOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            msOnDB = reader("MaDaiLy")
                        End While
                    End If
                    If (msOnDB <> Nothing And msOnDB.Length >= 8) Then
                        Dim currentYear = DateTime.Now.Year.ToString().Substring(2)
                        Dim iCurrentYear = Integer.Parse(currentYear)
                        Dim currentYearOnDB = msOnDB.Substring(0, 2)
                        Dim icurrentYearOnDB = Integer.Parse(currentYearOnDB)
                        Dim year = iCurrentYear
                        If (year < icurrentYearOnDB) Then
                            year = icurrentYearOnDB
                        End If
                        nextMsdl = year.ToString()
                        Dim v = msOnDB.Substring(2)
                        Dim convertDecimal = Convert.ToDecimal(v)
                        convertDecimal = convertDecimal + 1
                        Dim tmp = convertDecimal.ToString()
                        tmp = tmp.PadLeft(msOnDB.Length - 2, "0")
                        nextMsdl = nextMsdl + tmp
                        System.Console.WriteLine(nextMsdl)
                    End If
                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động Mã Đại Lý kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function insert(dl As DaiLy_DTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblDaiLy] ([MaDaiLy], [MaLoaiDaiLy], [MaQuan], [TenDaiLy], [DienThoai], [DiaChi], [NgayTiepNhan], [Email], [NoCuaDaiLy])"
        query &= "VALUES (@MaDaiLy,@MaLoaiDaiLy,@MaQuan,@TenDaiLy,@DienThoai,@DiaChi,@NgayTiepNhan,@Email,@NoCuaDaiLy)"

        'get MSHS
        Dim nextMadl = "1"
        buildMaDL(nextMadl)
        dl.MaDaiLy = nextMadl

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaDaiLy", dl.MaDaiLy)
                    .Parameters.AddWithValue("@MaLoaiDaiLy", dl.MaLoaiDaiLy)
                    .Parameters.AddWithValue("@MaQuan", dl.MaQuan)
                    .Parameters.AddWithValue("@TenDaiLy", dl.TenDaiLy)
                    .Parameters.AddWithValue("@DienThoai", dl.DienThoai)
                    .Parameters.AddWithValue("@DiaChi", dl.DiaChi)
                    .Parameters.AddWithValue("@NgayTiepNhan", dl.NgayTiepNhan)
                    .Parameters.AddWithValue("@Email", dl.Email)
                    .Parameters.AddWithValue("@NoCuaDaiLy", dl.NoCuaDaiLy)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm Đại Lý không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL(ByRef listDaiLy As List(Of DaiLy_DTO)) As Result
        Dim query As String = String.Empty
        query &= "SELECT [MaDaiLy], [MaLoaiDaiLy], [MaQuan], [TenDaiLy], [DienThoai], [DiaChi], [NgayTiepNhan], [Email], [NoCuaDaiLy] "
        query &= "FROM [tblDaiLy]"

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
                        listDaiLy.Clear()
                        While reader.Read()
                            listDaiLy.Add(New DaiLy_DTO(reader("MaDaiLy"), reader("MaLoaiDaiLy"), reader("MaQuan"), reader("TenDaiLy"), reader("DienThoai"), reader("DiaChi"), reader("NgayTiepNhan"), reader("Email"), reader("NoCuaDaiLy")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Đại Lý không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL_ByType(maLoai As Integer, ByRef listDaiLy As List(Of DaiLyDisplay)) As Result
        Dim query As String = String.Empty
        query &= "SELECT [MaDaiLy], [TenDaiLy], [TenLoaiDaiLy], [TenQuan], [DienThoai], [DiaChi], [NgayTiepNhan], [Email], [NoCuaDaiLy] "
        query &= "FROM [tblDaiLy], [tblLoaiDaiLy], [tblQuan] "
        query &= "WHERE [tblDaiLy].MaLoaiDaiLy = @MaLoaiDaiLy AND [tblDaiLy].MaLoaiDaiLy = [tblLoaiDaiLy].MaLoaiDaiLy AND [tblDaiLy].MaQuan = [tblQuan].MaQuan "

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
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listDaiLy.Clear()
                        While reader.Read()
                            listDaiLy.Add(New DaiLyDisplay(reader("MaDaiLy"), reader("TenDaiLy"), reader("TenLoaiDaiLy"), reader("TenQuan"), reader("DienThoai"), reader("DiaChi"), reader("NgayTiepNhan"), reader("Email"), reader("NoCuaDaiLy")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Đại Lý theo Loại không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL_ByTenDL(tendl As String, ByRef listDaiLy As List(Of DaiLyDisplay)) As Result
        Dim query As String = String.Empty
        query &= "SELECT [MaDaiLy], [TenDaiLy], [TenLoaiDaiLy], [TenQuan], [DienThoai], [DiaChi], [NgayTiepNhan], [Email], [NoCuaDaiLy] "
        query &= "FROM [tblDaiLy], [tblLoaiDaiLy], [tblQuan] "
        query &= "WHERE [TenDaiLy] LIKE N'" & tendl & "%' AND [tblDaiLy].MaLoaiDaiLy = [tblLoaiDaiLy].MaLoaiDaiLy AND [tblDaiLy].MaQuan = [tblQuan].MaQuan "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@TenDaiLy", tendl)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listDaiLy.Clear()
                        While reader.Read()
                            listDaiLy.Add(New DaiLyDisplay(reader("MaDaiLy"), reader("TenDaiLy"), reader("TenLoaiDaiLy"), reader("TenQuan"), reader("DienThoai"), reader("DiaChi"), reader("NgayTiepNhan"), reader("Email"), reader("NoCuaDaiLy")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Đại Lý theo Tên không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL_ByMaQuan(maquan As Integer, ByRef listDaiLy As List(Of DaiLyDisplay)) As Result
        Dim query As String = String.Empty
        query &= "SELECT [MaDaiLy], [TenDaiLy], [TenLoaiDaiLy], [TenQuan], [DienThoai], [DiaChi], [NgayTiepNhan], [Email], [NoCuaDaiLy] "
        query &= "FROM [tblDaiLy], [tblLoaiDaiLy], [tblQuan] "
        query &= "WHERE [tblDaiLy].MaQuan = @MaQuan AND [tblDaiLy].MaLoaiDaiLy = [tblLoaiDaiLy].MaLoaiDaiLy AND [tblDaiLy].MaQuan = [tblQuan].MaQuan "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaQuan", maquan)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listDaiLy.Clear()
                        While reader.Read()
                            listDaiLy.Add(New DaiLyDisplay(reader("MaDaiLy"), reader("TenDaiLy"), reader("TenLoaiDaiLy"), reader("TenQuan"), reader("DienThoai"), reader("DiaChi"), reader("NgayTiepNhan"), reader("Email"), reader("NoCuaDaiLy")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Đại Lý theo Quận không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL_ByTenQuan(tenquan As String, ByRef listDaiLy As List(Of DaiLyDisplay)) As Result
        Dim query As String = String.Empty
        query &= "SELECT [MaDaiLy], [TenDaiLy], [TenLoaiDaiLy], [TenQuan], [DienThoai], [DiaChi], [NgayTiepNhan], [Email], [NoCuaDaiLy] "
        query &= "FROM [tblDaiLy], [tblLoaiDaiLy], [tblQuan] "
        query &= "WHERE [TenQuan] LIKE N'%" & tenquan & "%' AND [tblDaiLy].MaLoaiDaiLy = [tblLoaiDaiLy].MaLoaiDaiLy AND [tblDaiLy].MaQuan = [tblQuan].MaQuan "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@TenQuan", tenquan)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listDaiLy.Clear()
                        While reader.Read()
                            listDaiLy.Add(New DaiLyDisplay(reader("MaDaiLy"), reader("TenDaiLy"), reader("TenLoaiDaiLy"), reader("TenQuan"), reader("DienThoai"), reader("DiaChi"), reader("NgayTiepNhan"), reader("Email"), reader("NoCuaDaiLy")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Đại Lý theo Quan không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL_ByTenLoaiDL(tenldl As String, ByRef listDaiLy As List(Of DaiLyDisplay)) As Result
        Dim query As String = String.Empty
        query &= "SELECT [MaDaiLy], [TenDaiLy], [TenLoaiDaiLy], [TenQuan], [DienThoai], [DiaChi], [NgayTiepNhan], [Email], [NoCuaDaiLy] "
        query &= "FROM [tblDaiLy], [tblLoaiDaiLy], [tblQuan] "
        query &= "WHERE [TenLoaiDaiLy] LIKE N'%" & tenldl & "%' AND [tblDaiLy].MaLoaiDaiLy = [tblLoaiDaiLy].MaLoaiDaiLy AND [tblDaiLy].MaQuan = [tblQuan].MaQuan "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@TenLoaiDaiLy", tenldl)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listDaiLy.Clear()
                        While reader.Read()
                            listDaiLy.Add(New DaiLyDisplay(reader("MaDaiLy"), reader("TenDaiLy"), reader("TenLoaiDaiLy"), reader("TenQuan"), reader("DienThoai"), reader("DiaChi"), reader("NgayTiepNhan"), reader("Email"), reader("NoCuaDaiLy")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Đại Lý theo Loại Đại Lý không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL_ByTienNo(tn As Integer, ByRef listDaiLy As List(Of DaiLyDisplay)) As Result
        Dim query As String = String.Empty
        query &= "SELECT [MaDaiLy], [TenDaiLy], [TenLoaiDaiLy], [TenQuan], [DienThoai], [DiaChi], [NgayTiepNhan], [Email], [NoCuaDaiLy] "
        query &= "FROM [tblDaiLy], [tblLoaiDaiLy], [tblQuan] "
        query &= "WHERE [NoCuaDaiLy] = @NoCuaDaiLy AND [tblDaiLy].MaLoaiDaiLy = [tblLoaiDaiLy].MaLoaiDaiLy AND [tblDaiLy].MaQuan = [tblQuan].MaQuan "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@NoCuaDaiLy", tn)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listDaiLy.Clear()
                        While reader.Read()
                            listDaiLy.Add(New DaiLyDisplay(reader("MaDaiLy"), reader("TenDaiLy"), reader("TenLoaiDaiLy"), reader("TenQuan"), reader("DienThoai"), reader("DiaChi"), reader("NgayTiepNhan"), reader("Email"), reader("NoCuaDaiLy")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Đại Lý theo Tiền Nợ không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(dl As DaiLy_DTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblDaiLy] SET"
        query &= " [MaLoaiDaiLy] = @MaLoaiDaiLy "
        query &= " ,[MaQuan] = @MaQuan "
        query &= " ,[TenDaiLy] = @TenDaiLy "
        query &= " ,[DienThoai] = @DienThoai "
        query &= " ,[DiaChi] = @DiaChi "
        query &= " ,[NgayTiepNhan] = @NgayTiepNhan "
        query &= " ,[Email] = @Email "
        query &= " ,[NoCuaDaiLy] = @NoCuaDaiLy "
        query &= " WHERE "
        query &= " [MaDaiLy] = @MaDaiLy "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaLoaiDaiLy", dl.MaLoaiDaiLy)
                    .Parameters.AddWithValue("@MaQuan", dl.MaQuan)
                    .Parameters.AddWithValue("@TenDaiLy", dl.TenDaiLy)
                    .Parameters.AddWithValue("@DienThoai", dl.DienThoai)
                    .Parameters.AddWithValue("@DiaChi", dl.DiaChi)
                    .Parameters.AddWithValue("@NgayTiepNhan", dl.NgayTiepNhan)
                    .Parameters.AddWithValue("@Email", dl.Email)
                    .Parameters.AddWithValue("@NoCuaDaiLy", dl.NoCuaDaiLy)
                    .Parameters.AddWithValue("@MaDaiLy", dl.MaDaiLy)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Cập nhật Đại Lý không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function delete(maDaiLy As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblDaiLy] "
        query &= " WHERE "
        query &= " [MaDaiLy] = @MaDaiLy "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaDaiLy", maDaiLy)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa Đại Lý không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)  ' thanh cong
    End Function
    Public Function count(daily As DaiLy_DTO) As Integer
        Dim query As String = String.Empty
        Dim maquan As String = daily.MaQuan
        Dim sum As Integer

        query &= " SELECT COUNT(*) As SODAILY "
        query &= " FROM [tblDaiLy]"
        query &= " WHERE [MaQuan] = @MaQuan "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaQuan", maquan)
                End With

                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        'reader.Read()
                        While reader.Read()
                            sum = reader("SODAILY")
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
    Public Function selectBaoCaoCongNo(month As Integer, year As Integer, listCN As List(Of DaiLy_DTO)) As Result
        Dim query As String = String.Empty
        query &= "SELECT [TenDaiLy], [NoCuaDaiLy] "
        query &= "FROM [tblDaiLy] "
        query &= "WHERE MONTH([NgayTiepNhan]) = @Month AND YEAR([NgayTiepNhan]) = @Year"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Month", month)
                    .Parameters.AddWithValue("@Year", year)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listCN.Clear()
                        While reader.Read()
                            listCN.Add(New DaiLy_DTO(reader("TenDaiLy"), reader("NoCuaDaiLy")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Đại Lý không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectNo(madl As String) As Integer
        Dim query As String = String.Empty
        Dim kq As Integer

        query &= " SELECT [NoCuaDaiLy] AS No"
        query &= " FROM [tblDaiLy]"
        query &= " WHERE [MaDaiLy] = @MaDaiLy "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaDaiLy", madl)
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
End Class
