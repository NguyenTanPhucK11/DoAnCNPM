Public Class PhieuThu_DTO
    Private strMaPhieuThuTien As String
    Private strMaDaiLy As String
    Private dateNgayThuTien As Date
    Private iSoTienThu As Integer
    Public Sub New()
    End Sub
    Public Sub New(strMaPhieuThuTien As String, strMaDaiLy As String, dateNgayThuTien As Date, iSoTienThu As Integer)
        Me.strMaPhieuThuTien = strMaPhieuThuTien
        Me.strMaDaiLy = strMaDaiLy
        Me.dateNgayThuTien = dateNgayThuTien
        Me.iSoTienThu = iSoTienThu
    End Sub
    Property MaPhieuThuTien() As String
        Get
            Return strMaPhieuThuTien
        End Get
        Set(ByVal Value As String)
            strMaPhieuThuTien = Value
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
    Property NgayThuTien() As Date
        Get
            Return dateNgayThuTien
        End Get
        Set(ByVal Value As Date)
            dateNgayThuTien = Value
        End Set
    End Property
    Property SoTienThu() As Integer
        Get
            Return iSoTienThu
        End Get
        Set(ByVal Value As Integer)
            iSoTienThu = Value
        End Set
    End Property
End Class
