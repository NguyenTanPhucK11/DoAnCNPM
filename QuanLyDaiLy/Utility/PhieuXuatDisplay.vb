Public Class PhieuXuatDisplay
    Private strMaChiTietPhieuXuat As String
    Private strMaDaiLy As String
    Private strTenDaiLy As String
    Private iMaPhieuXuat As Integer
    Private strTenMatHang As String
    Private strTenDonViTinh As String
    Private iSoLuongXuat As Integer
    Private iDonGia As Integer
    Private iThanhTien As Integer
    Private dateNgayLapPhieu As Date
    Private iTongTriGia As Integer
    Public Sub New()
    End Sub
    Public Sub New(strMaChiTietPhieuXuat As String, strTenDaiLy As String, iMaPhieuXuat As Integer, strTenMatHang As String, strTenDonViTinh As String, iSoLuongXuat As Integer, iDonGia As Integer, iThanhTien As Integer, dateNgayLapPhieu As Date, iTongTriGia As Integer)
        Me.strMaChiTietPhieuXuat = strMaChiTietPhieuXuat
        Me.strTenDaiLy = strTenDaiLy
        Me.iMaPhieuXuat = iMaPhieuXuat
        Me.strTenMatHang = strTenMatHang
        Me.strTenDonViTinh = strTenDonViTinh
        Me.iSoLuongXuat = iSoLuongXuat
        Me.iDonGia = iDonGia
        Me.iThanhTien = iThanhTien
        Me.dateNgayLapPhieu = dateNgayLapPhieu
        Me.iTongTriGia = iTongTriGia
    End Sub
    Public Sub New(strMaChiTietPhieuXuat As String, strMaDaiLy As String, strTenDaiLy As String, iSoLuongXuat As Integer, iDonGia As Integer, iThanhTien As Integer)
        Me.strMaChiTietPhieuXuat = strMaChiTietPhieuXuat
        Me.strMaDaiLy = strMaDaiLy
        Me.strTenDaiLy = strTenDaiLy
        Me.iSoLuongXuat = iSoLuongXuat
        Me.iDonGia = iDonGia
        Me.iThanhTien = iThanhTien
    End Sub
    Public Sub New(strMaChiTietPhieuXuat As String, strMaDaiLy As String, iThanhTien As Integer, iTongTriGia As Integer)
        Me.strMaChiTietPhieuXuat = strMaChiTietPhieuXuat
        Me.strMaDaiLy = strMaDaiLy
        Me.iThanhTien = iThanhTien
        Me.iTongTriGia = iTongTriGia
    End Sub
    Property MaChiTietPhieuXuat() As String
        Get
            Return strMaChiTietPhieuXuat
        End Get
        Set(ByVal Value As String)
            strMaChiTietPhieuXuat = Value
        End Set
    End Property
    Property MaDaiLy() As String
        Get
            Return strMaDaiLy
        End Get
        Set(ByVal Value As String)
            strMaDaiLy = Value
        End Set
    End Property
    Property TenDaiLy() As String
        Get
            Return strTenDaiLy
        End Get
        Set(ByVal Value As String)
            strTenDaiLy = Value
        End Set
    End Property
    Property MaPhieuXuat() As Integer
        Get
            Return iMaPhieuXuat
        End Get
        Set(ByVal Value As Integer)
            iMaPhieuXuat = Value
        End Set
    End Property
    Property TenMatHang() As String
        Get
            Return strTenMatHang
        End Get
        Set(ByVal Value As String)
            strTenMatHang = Value
        End Set
    End Property
    Property TenDonViTinh() As String
        Get
            Return strTenDonViTinh
        End Get
        Set(ByVal Value As String)
            strTenDonViTinh = Value
        End Set
    End Property
    Property SoLuongXuat() As Integer
        Get
            Return iSoLuongXuat
        End Get
        Set(ByVal Value As Integer)
            iSoLuongXuat = Value
        End Set
    End Property
    Property DonGia() As Integer
        Get
            Return iDonGia
        End Get
        Set(ByVal Value As Integer)
            iDonGia = Value
        End Set
    End Property
    Property ThanhTien() As Integer
        Get
            Return iThanhTien
        End Get
        Set(ByVal Value As Integer)
            iThanhTien = Value
        End Set
    End Property
    Property NgayLapPhieu() As Date
        Get
            Return dateNgayLapPhieu
        End Get
        Set(ByVal Value As Date)
            dateNgayLapPhieu = Value
        End Set
    End Property
    Property TongTriGia() As Integer
        Get
            Return iTongTriGia
        End Get
        Set(ByVal Value As Integer)
            iTongTriGia = Value
        End Set
    End Property
End Class
