Public Class CongNo_DTO
    Private strTenDaiLy As String
    Private iNoDau As Integer
    Private iPhatSinh As Integer
    Private iNoCuoi As Integer
    Public Sub New()
    End Sub
    Public Sub New(strTenDaiLy As String, iNoDau As Integer, iPhatSinh As Integer, iNoCuoi As Integer)
        Me.strTenDaiLy = strTenDaiLy
        Me.iNoDau = iNoDau
        Me.iPhatSinh = 1000
        Me.iNoCuoi = iNoCuoi
    End Sub
    Public Sub New(strTenDaiLy As String, iNoDau As Integer)
        Me.strTenDaiLy = strTenDaiLy
        Me.iNoDau = iNoDau
    End Sub
    Property TenDaiLy() As String
        Get
            Return strTenDaiLy
        End Get
        Set(ByVal Value As String)
            strTenDaiLy = Value
        End Set
    End Property
    Property NoDau() As Integer
        Get
            Return iNoDau
        End Get
        Set(ByVal Value As Integer)
            iNoDau = Value
        End Set
    End Property
    Property PhatSinh() As Integer
        Get
            Return iPhatSinh
        End Get
        Set(ByVal Value As Integer)
            iPhatSinh = Value
        End Set
    End Property
    Property NoCuoi() As Integer
        Get
            Return iNoCuoi
        End Get
        Set(ByVal Value As Integer)
            iNoCuoi = Value
        End Set
    End Property
End Class
