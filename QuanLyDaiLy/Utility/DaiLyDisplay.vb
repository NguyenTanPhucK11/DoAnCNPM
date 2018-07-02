Public Class DaiLyDisplay
    Private strMaDaiLy As String
    Private strTenDaiLy As String
    Private strTenLoaiDaiLy As String
    Private strTenQuan As String
    Private iDienThoai As Integer
    Private strDiaChi As String
    Private dateNgayTiepNhan As Date
    Private strEmail As String
    Private iNoCuaDaiLy As Integer
    Public Sub New(strMaDaiLy As String, strTenDaiLy As String, strTenLoaiDaiLy As String, strTenQuan As String, iDienThoai As Integer, strDiaChi As String, dateNgayTiepNhan As Date, strEmail As String, iNoCuaDaiLy As Integer)
        Me.MaDaiLy = strMaDaiLy
        Me.TenDaiLy = strTenDaiLy
        Me.TenLoaiDaiLy = strTenLoaiDaiLy
        Me.TenQuan = strTenQuan
        Me.DienThoai = iDienThoai
        Me.DiaChi = strDiaChi
        Me.NgayTiepNhan = dateNgayTiepNhan
        Me.Email = strEmail
        Me.NoCuaDaiLy = iNoCuaDaiLy
    End Sub
    Public Sub New()
    End Sub
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
    Property TenLoaiDaiLy() As String
        Get
            Return strTenLoaiDaiLy
        End Get
        Set(ByVal Value As String)
            strTenLoaiDaiLy = Value
        End Set
    End Property
    Property TenQuan() As String
        Get
            Return strTenQuan
        End Get
        Set(ByVal Value As String)
            strTenQuan = Value
        End Set
    End Property

    Property DienThoai() As Integer
        Get
            Return iDienThoai
        End Get
        Set(ByVal Value As Integer)
            iDienThoai = Value
        End Set
    End Property
    Property DiaChi() As String
        Get
            Return strDiaChi
        End Get
        Set(ByVal Value As String)
            strDiaChi = Value
        End Set
    End Property
    Property NgayTiepNhan() As Date
        Get
            Return dateNgayTiepNhan
        End Get
        Set(ByVal Value As Date)
            dateNgayTiepNhan = Value
        End Set
    End Property
    Property Email() As String
        Get
            Return strEmail
        End Get
        Set(ByVal Value As String)
            strEmail = Value
        End Set
    End Property
    Property NoCuaDaiLy() As Integer
        Get
            Return iNoCuaDaiLy
        End Get
        Set(ByVal Value As Integer)
            iNoCuaDaiLy = Value
        End Set
    End Property
End Class
