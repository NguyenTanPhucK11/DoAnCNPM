Public Class DoanhSo_DTO
    Private strTenDaiLy As String
    Private iSoPhieuXuat As Integer
    Private iTongTriGia As Integer
    Private douTyLe As Double
    Public Sub New()
    End Sub
    Public Sub New(strTenDaiLy As String, iSoPhieuXuat As Integer, iTongTriGia As Integer, iTyLe As Double)
        Me.strTenDaiLy = strTenDaiLy
        Me.iSoPhieuXuat = iSoPhieuXuat
        Me.iTongTriGia = iTongTriGia
        Me.douTyLe = douTyLe
    End Sub
    Property TenDaiLy() As String
        Get
            Return strTenDaiLy
        End Get
        Set(ByVal Value As String)
            strTenDaiLy = Value
        End Set
    End Property
    Property SoPhieuXuat() As Integer
        Get
            Return iSoPhieuXuat
        End Get
        Set(ByVal Value As Integer)
            iSoPhieuXuat = Value
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
    Property TyLe() As Double
        Get
            Return douTyLe
        End Get
        Set(ByVal Value As Double)
            douTyLe = Value
        End Set
    End Property
End Class
