Public Class ChiTietPhieuXuat_DTO
    Private strMaChiTietPhieuXuat As String
    Private iMaPhieuXuat As Integer
    Private iMaMatHang As Integer
    Private iMaDonViTinh As Integer
    Private iSoLuongXuat As Integer
    Private iDonGia As Integer
    Private iThanhTien As Integer
    Public Sub New()
    End Sub
    Public Sub New(strMaChiTietPhieuXuat As String, iMaPhieuXuat As Integer, iMaMatHang As Integer, iMaDonViTinh As Integer, iSoLuongXuat As Integer, iDonGia As Integer, iThanhTien As Integer)
        Me.strMaChiTietPhieuXuat = strMaChiTietPhieuXuat
        Me.iMaPhieuXuat = iMaPhieuXuat
        Me.iMaMatHang = iMaMatHang
        Me.iMaDonViTinh = iMaDonViTinh
        Me.iSoLuongXuat = iSoLuongXuat
        Me.iDonGia = iDonGia
        Me.iThanhTien = iThanhTien
    End Sub
    Public Sub New(strMaChiTietPhieuXuat As String)
        Me.strMaChiTietPhieuXuat = strMaChiTietPhieuXuat
    End Sub
    Property MaChiTietPhieuXuat() As String
        Get
            Return strMaChiTietPhieuXuat
        End Get
        Set(ByVal Value As String)
            strMaChiTietPhieuXuat = Value
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
    Property MaMatHang() As Integer
        Get
            Return iMaMatHang
        End Get
        Set(ByVal Value As Integer)
            iMaMatHang = Value
        End Set
    End Property
    Property MaDonViTinh() As Integer
        Get
            Return iMaDonViTinh
        End Get
        Set(ByVal Value As Integer)
            iMaDonViTinh = Value
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
End Class
