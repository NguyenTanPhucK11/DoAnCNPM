Public Class DonViTinh_DTO
    Private iMaDonViTinh As Integer
    Private strTenDonViTinh As String
    Public Sub New()
    End Sub
    Public Sub New(MaDonViTinh As Integer, TenDonViTinh As String)
        Me.iMaDonViTinh = MaDonViTinh
        Me.strTenDonViTinh = TenDonViTinh
    End Sub
    Property MaDonViTinh() As Integer
        Get
            Return iMaDonViTinh
        End Get
        Set(ByVal Value As Integer)
            iMaDonViTinh = Value
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
End Class
