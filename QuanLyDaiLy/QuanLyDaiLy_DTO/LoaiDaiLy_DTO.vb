Public Class LoaiDaiLy_DTO
    Private iMaLoaiDaiLy As Integer
    Private strTenLoaiDaiLy As String
    Private iNoToiDa As Integer
    Public Sub New()
    End Sub
    Public Sub New(ml As Integer, tl As String, ntd As Integer)
        Me.iMaLoaiDaiLy = ml
        Me.strTenLoaiDaiLy = tl
        Me.iNoToiDa = ntd
    End Sub
    Property MaLoaiDL() As Integer
        Get
            Return iMaLoaiDaiLy
        End Get
        Set(ByVal Value As Integer)
            iMaLoaiDaiLy = Value
        End Set
    End Property
    Property TenLoaiDL() As String
        Get
            Return strTenLoaiDaiLy
        End Get
        Set(ByVal Value As String)
            strTenLoaiDaiLy = Value
        End Set
    End Property
    Property NoToiDa() As Integer
        Get
            Return iNoToiDa
        End Get
        Set(ByVal Value As Integer)
            iNoToiDa = Value
        End Set
    End Property
End Class
