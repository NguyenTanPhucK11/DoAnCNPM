Imports System.Configuration
Imports System.Data.SqlClient
Imports QuanLyDaiLy_DTO
Imports Utility
Public Class ChiTietPhieuXuat_DAL
    Private connectionString As String
    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function buildMaCTPX(ByRef nextMsctpx As String) As Result

        Dim x As String = "CTPX-"
        nextMsctpx = String.Empty
        nextMsctpx = x + ""

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MaChiTietPhieuXuat] "
        query &= "FROM [tblChiTietPhieuXuat] "
        query &= "ORDER BY [MaChiTietPhieuXuat] DESC "

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
                            msOnDB = reader("MaChiTietPhieuXuat")
                        End While
                    End If
                    ' new ID = current ID + 1
                    Dim v = msOnDB.Substring(5)
                    Dim convertDecimal = Convert.ToDecimal(v)
                    convertDecimal = convertDecimal + 1
                    Dim tmp = convertDecimal.ToString()
                    tmp = tmp.PadLeft(msOnDB.Length - 5, "0")
                    nextMsctpx = nextMsctpx + tmp
                    System.Console.WriteLine(nextMsctpx)

                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextMsctpx = 1
                    Return New Result(False, "Lấy ID kế tiếp của Chi Tiết Phiếu Xuất không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function insert(ctpx As ChiTietPhieuXuat_DTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblChiTietPhieuXuat] ([MaChiTietPhieuXuat], [MaPhieuXuat], [MaMatHang], [MaDonViTinh], [SoLuongXuat], [DonGia])"
        query &= "VALUES (@MaChiTietPhieuXuat,@MaPhieuXuat,@MaMatHang,@MaDonViTinh,@SoLuongXuat,@DonGia)"

        'get MSHS
        Dim nextMactpx = "1"
        buildMaCTPX(nextMactpx)
        ctpx.MaChiTietPhieuXuat = nextMactpx

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaChiTietPhieuXuat", ctpx.MaChiTietPhieuXuat)
                    .Parameters.AddWithValue("@MaPhieuXuat", ctpx.MaPhieuXuat)
                    .Parameters.AddWithValue("@MaMatHang", ctpx.MaMatHang)
                    .Parameters.AddWithValue("@MaDonViTinh", ctpx.MaDonViTinh)
                    .Parameters.AddWithValue("@SoLuongXuat", ctpx.SoLuongXuat)
                    .Parameters.AddWithValue("@DonGia", ctpx.DonGia)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm Chi Tiết Phiếu Xuất không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL(ByRef listChiTietPhieuXuat As List(Of ChiTietPhieuXuat_DTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaChiTietPhieuXuat], [MaPhieuXuat], [MaMatHang], [MaDonViTinh], [SoLuongXuat], [DonGia] "
        query &= "FROM [tblChiTietPhieuXuat]"

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
                        listChiTietPhieuXuat.Clear()
                        While reader.Read()
                            listChiTietPhieuXuat.Add(New ChiTietPhieuXuat_DTO(reader("MaChiTietPhieuXuat"), reader("MaPhieuXuat"), reader("MaMatHang"), reader("MaDonViTinh"), reader("SoLuongXuat"), reader("DonGia"), Tinh(reader("SoLuongXuat"), reader("DonGia"))))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Chi Tiết Phiếu Xuất không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL_ByMaMatHang(mamathang As Integer, ByRef listChiTietPhieuXuat As List(Of PhieuXuatDisplay)) As Result
        Dim query As String = String.Empty
        query &= "SELECT [MaChiTietPhieuXuat], [tblDaiLy].MaDaiLy, [TenDaiLy], [tblChiTietPhieuXuat].[MaPhieuXuat], [TenMatHang], [TenDonViTinh], [SoLuongXuat], [DonGia], [NgayLapPhieu] "
        query &= "FROM [tblChiTietPhieuXuat], [tblPhieuXuat], [tblMatHang], [tblDonViTinh], [tblDaiLy] "
        query &= "WHERE [tblChiTietPhieuXuat].MaMatHang = @MaMatHang AND [tblDaiLy].MaDaiLy = [tblPhieuXuat].MaDaiLy AND [tblChiTietPhieuXuat].MaPhieuXuat = [tblPhieuXuat].MaPhieuXuat AND [tblChiTietPhieuXuat].MaMatHang = [tblMatHang].MaMatHang AND [tblChiTietPhieuXuat].MaDonViTinh = [tblDonViTinh].MaDonViTinh "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaMatHang", mamathang)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listChiTietPhieuXuat.Clear()
                        While reader.Read()
                            listChiTietPhieuXuat.Add(New PhieuXuatDisplay(reader("MaChiTietPhieuXuat"), reader("TenDaiLy"), reader("MaPhieuXuat"), reader("TenMathang"), reader("TenDonViTinh"), reader("SoLuongXuat"), reader("DonGia"), Tinh(reader("SoLuongXuat"), reader("DonGia")), reader("NgayLapPhieu"), Sum(reader("MaDaiLy"))))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Chi Tiết Phiếu Xuất theo Mã Mặt Hàng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL_ByMaPhieuXuat(maphieuxuat As Integer, ByRef listChiTietPhieuXuat As List(Of PhieuXuatDisplay)) As Result
        Dim query As String = String.Empty
        query &= "SELECT [MaChiTietPhieuXuat], [tblDaiLy].MaDaiLy, [TenDaiLy], [tblChiTietPhieuXuat].[MaPhieuXuat], [TenMatHang], [TenDonViTinh], [SoLuongXuat], [DonGia], [NgayLapPhieu] "
        query &= "FROM [tblChiTietPhieuXuat], [tblPhieuXuat], [tblMatHang], [tblDonViTinh], [tblDaiLy] "
        query &= "WHERE [tblChiTietPhieuXuat].MaPhieuXuat = @MaPhieuXuat AND [tblDaiLy].MaDaiLy = [tblPhieuXuat].MaDaiLy AND [tblChiTietPhieuXuat].MaPhieuXuat = [tblPhieuXuat].MaPhieuXuat AND [tblChiTietPhieuXuat].MaMatHang = [tblMatHang].MaMatHang AND [tblChiTietPhieuXuat].MaDonViTinh = [tblDonViTinh].MaDonViTinh "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaPhieuXuat", maphieuxuat)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listChiTietPhieuXuat.Clear()
                        While reader.Read()
                            listChiTietPhieuXuat.Add(New PhieuXuatDisplay(reader("MaChiTietPhieuXuat"), reader("TenDaiLy"), reader("MaPhieuXuat"), reader("TenMathang"), reader("TenDonViTinh"), reader("SoLuongXuat"), reader("DonGia"), Tinh(reader("SoLuongXuat"), reader("DonGia")), reader("NgayLapPhieu"), Sum(reader("MaDaiLy"))))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Chi Tiết Phiếu Xuất theo Mã Phiếu Xuất không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL_ByMaDonViTinh(madonvitinh As Integer, ByRef listChiTietPhieuXuat As List(Of PhieuXuatDisplay)) As Result
        Dim query As String = String.Empty
        query &= "SELECT [MaChiTietPhieuXuat], [tblDaiLy].MaDaiLy, [TenDaiLy], [tblChiTietPhieuXuat].[MaPhieuXuat], [TenMatHang], [TenDonViTinh], [SoLuongXuat], [DonGia], [NgayLapPhieu]"
        query &= "FROM [tblChiTietPhieuXuat], [tblPhieuXuat], [tblMatHang], [tblDonViTinh], [tblDaiLy] "
        query &= "WHERE [tblChiTietPhieuXuat].MaDonViTinh = @MaDonViTinh AND [tblDaiLy].MaDaiLy = [tblPhieuXuat].MaDaiLy AND [tblChiTietPhieuXuat].MaPhieuXuat = [tblPhieuXuat].MaPhieuXuat AND [tblChiTietPhieuXuat].MaMatHang = [tblMatHang].MaMatHang AND [tblChiTietPhieuXuat].MaDonViTinh = [tblDonViTinh].MaDonViTinh "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaDonViTinh", madonvitinh)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listChiTietPhieuXuat.Clear()
                        While reader.Read()
                            listChiTietPhieuXuat.Add(New PhieuXuatDisplay(reader("MaChiTietPhieuXuat"), reader("TenDaiLy"), reader("MaPhieuXuat"), reader("TenMathang"), reader("TenDonViTinh"), reader("SoLuongXuat"), reader("DonGia"), Tinh(reader("SoLuongXuat"), reader("DonGia")), reader("NgayLapPhieu"), Sum(reader("MaDaiLy"))))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Chi Tiết Phiếu Xuất theo Mã Đơn Vị Tính không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(ctpx As ChiTietPhieuXuat_DTO) As Result
        Dim query As String = String.Empty
        query &= " UPDATE [tblChiTietPhieuXuat] SET"
        query &= " [MaPhieuXuat] = @MaPhieuXuat "
        query &= " ,[MaMatHang] = @MaMatHang "
        query &= " ,[MaDonViTinh] = @MaDonViTinh "
        query &= " ,[SoLuongXuat] = @SoLuongXuat "
        query &= " ,[DonGia] = @DonGia "
        query &= " WHERE "
        query &= " [MaChiTietPhieuXuat] = @MaChiTietPhieuXuat "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaPhieuXuat", ctpx.MaPhieuXuat)
                    .Parameters.AddWithValue("@MaMatHang", ctpx.MaMatHang)
                    .Parameters.AddWithValue("@MaDonViTinh", ctpx.MaDonViTinh)
                    .Parameters.AddWithValue("@SoLuongXuat", ctpx.SoLuongXuat)
                    .Parameters.AddWithValue("@DonGia", ctpx.DonGia)
                    .Parameters.AddWithValue("@MaChiTietPhieuXuat", ctpx.MaChiTietPhieuXuat)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Cập nhật Chi Tiết Phiếu Xuất không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function delete(maChiTietPhieuXuat As String) As Result
        Dim query As String = String.Empty
        query &= " DELETE FROM [tblChiTietPhieuXuat] "
        query &= " WHERE "
        query &= " [MaChiTietPhieuXuat] = @MaChiTietPhieuXuat "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaChiTietPhieuXuat", maChiTietPhieuXuat)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa Chi Tiết Phiếu Xuất không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)  ' thanh cong
    End Function
    Public Function demSoPhieuXuat(madl As String, ctpx As PhieuXuatDisplay) As Integer
        Dim soluongxuat As Integer
        Dim query As String = String.Empty
        query &= "SELECT COUNT(DISTINCT [MaChiTietPhieuXuat]) AS soluong "
        query &= "FROM [tblChiTietPhieuXuat], [tblDaiLy], [tblPhieuXuat] "
        query &= "WHERE [tblDaiLy].MaDaiLy = @MadaiLy 
                    AND [tblDaily].MaDaiLy = [tblPhieuXuat].MaDaiLy 
                    And [tblPhieuXuat].MaPhieuXuat = [tblChiTietPhieuXuat].MaPhieuXuat "

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
                            soluongxuat = reader("soluong")
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
        Return soluongxuat
    End Function
    Public Function selectBaoCao(month As Integer, year As Integer, listDS As List(Of PhieuXuatDisplay)) As Result
        Dim query As String = String.Empty
        query &= "SELECT DISTINCT [MaChiTietPhieuXuat], [tblDaiLy].MaDaiLy, [TenDaiLy], [SoLuongXuat], [DonGia] "
        query &= "FROM [tblDaiLy], [tblPhieuXuat], [tblChiTietPhieuXuat] "
        query &= "WHERE [tblPhieuXuat].MaDaiLy = [tblDaiLy].MaDaiLy AND [tblPhieuXuat].MaPhieuXuat = [tblChiTietPhieuXuat].MaPhieuXuat
                        AND MONTH([NgayLapPhieu]) = @Month AND YEAR([NgayLapPhieu]) = @Year "

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
                        listDS.Clear()
                        While reader.Read()
                            listDS.Add(New PhieuXuatDisplay(reader("MaChiTietPhieuXuat"), reader("MaDaiLy"), reader("TenDaiLy"), reader("SoLuongXuat"), reader("DonGia"), Tinh(reader("SoLuongXuat"), reader("DonGia"))))
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
    Public Function Tinh(soluongxuat As Integer, dongia As Integer) As Integer
        Dim thanhtien As Integer = soluongxuat * dongia
        Return thanhtien
    End Function
    Public Function Sum(madl As String) As Integer
        Dim tongtrigia As Integer
        Dim query As String = String.Empty
        query &= "SELECT SUM([tblChiTietPhieuXuat].DonGia * [tblChiTietPhieuXuat].SoLuongXuat) AS Tong "
        query &= "FROM [tblChiTietPhieuXuat], [tblDaiLy], [tblPhieuXuat] "
        query &= "WHERE [tblDaiLy].MaDaiLy = @MadaiLy 
                    AND [tblDaily].MaDaiLy = [tblPhieuXuat].MaDaiLy 
                    And [tblPhieuXuat].MaPhieuXuat = [tblChiTietPhieuXuat].MaPhieuXuat "

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
                            tongtrigia = reader("Tong")
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
        Return tongtrigia
    End Function
End Class
