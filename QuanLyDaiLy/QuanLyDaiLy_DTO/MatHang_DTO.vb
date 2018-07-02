Public Class MatHang_DTO
    Private iMaMatHang As Integer
    Private strTenMatHang As String
    Private iSoLuongTon As Integer
    Public Sub New()
    End Sub
    Public Sub New(iMaMatHang As Integer, strTenMatHang As String, iSoLuongTon As Integer)
        Me.iMaMatHang = iMaMatHang
        Me.strTenMatHang = strTenMatHang
        Me.iSoLuongTon = iSoLuongTon
    End Sub
    Property MaMatHang() As Integer
        Get
            Return iMaMatHang
        End Get
        Set(ByVal Value As Integer)
            iMaMatHang = Value
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
    Property SoLuongTon() As Integer
        Get
            Return iSoLuongTon
        End Get
        Set(ByVal Value As Integer)
            iSoLuongTon = Value
        End Set
    End Property
End Class
