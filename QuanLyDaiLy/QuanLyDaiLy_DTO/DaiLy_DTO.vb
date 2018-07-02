Public Class DaiLy_DTO
    Private strMaDaiLy As String
    Private iMaLoaiDaiLy As Integer
    Private iMaQuan As Integer
    Private strTenDaiLy As String
    Private iDienThoai As Integer
    Private strDiaChi As String
    Private dateNgayTiepNhan As Date
    Private strEmail As String
    Private iNoCuaDaiLy As Integer
    Public Sub New()
    End Sub
    Public Sub New(strMaDaiLy As String, iMaLoaiDaiLy As Integer, iMaQuan As Integer, strTenDaiLy As String, iDienThoai As Integer, strDiaChi As String, dateNgayTiepNhan As Date, strEmail As String, iNoCuaDaiLy As Integer)
        Me.strMaDaiLy = strMaDaiLy
        Me.iMaLoaiDaiLy = iMaLoaiDaiLy
        Me.iMaQuan = iMaQuan
        Me.strTenDaiLy = strTenDaiLy
        Me.iDienThoai = iDienThoai
        Me.strDiaChi = strDiaChi
        Me.dateNgayTiepNhan = dateNgayTiepNhan
        Me.strEmail = strEmail
        Me.iNoCuaDaiLy = iNoCuaDaiLy
    End Sub
    Public Sub New(strTenDaiLy As String, iNoCuaDaiLy As Integer)
        Me.TenDaiLy = strTenDaiLy
        Me.NoCuaDaiLy = iNoCuaDaiLy
    End Sub
    Property MaDaiLy() As String
        Get
            Return strMaDaiLy
        End Get
        Set(ByVal Value As String)
            strMaDaiLy = Value
        End Set
    End Property
    Property MaLoaiDaiLy() As Integer
        Get
            Return iMaLoaiDaiLy
        End Get
        Set(ByVal Value As Integer)
            iMaLoaiDaiLy = Value
        End Set
    End Property
    Property MaQuan() As Integer
        Get
            Return iMaQuan
        End Get
        Set(ByVal Value As Integer)
            iMaQuan = Value
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
