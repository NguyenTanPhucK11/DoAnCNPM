Public Class Quan_DTO
    Private iMaQuan As Integer
    Private strTenQuan As String
    Public Sub New()
    End Sub
    Public Sub New(mq As Integer, tq As String)
        iMaQuan = mq
        strTenQuan = tq
    End Sub
    Property MaQuan() As Integer
        Get
            Return iMaQuan
        End Get
        Set(ByVal Value As Integer)
            iMaQuan = Value
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
End Class
