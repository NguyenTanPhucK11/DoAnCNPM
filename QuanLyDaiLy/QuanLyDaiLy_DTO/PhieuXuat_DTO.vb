Public Class PhieuXuat_DTO
    Private iMaPhieuXuat As Integer
    Private strMaDaiLy As String
    Private dateNgayLapPhieu As Date

    Public Sub New()
    End Sub
    Public Sub New(maP As Integer, maD As String, nlp As Date)
        Me.iMaPhieuXuat = maP
        Me.strMaDaiLy = maD
        Me.dateNgayLapPhieu = nlp
    End Sub
    Property MaPhieuXuat() As Integer
        Get
            Return iMaPhieuXuat
        End Get
        Set(ByVal Value As Integer)
            iMaPhieuXuat = Value
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
    Property NgayLapPhieu() As Date
        Get
            Return dateNgayLapPhieu
        End Get
        Set(ByVal Value As Date)
            dateNgayLapPhieu = Value
        End Set
    End Property
End Class
