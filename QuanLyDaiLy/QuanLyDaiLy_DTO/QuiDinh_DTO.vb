Public Class QuiDinh_DTO
    Private iId As Integer
    Private iSoLuongLoaiDaiLy As Integer
    Private iSoLuongDaiLyToiDa As Integer
    Private iSoLuongMatHang As Integer
    Public Sub New()
    End Sub
    Public Sub New(iId As Integer, iSoLuongLoaiDaiLy As Integer, iSoLuongDaiLyToiDa As Integer, iSoLuongMatHang As Integer)
        Me.iId = iId
        Me.iSoLuongLoaiDaiLy = iSoLuongLoaiDaiLy
        Me.iSoLuongDaiLyToiDa = iSoLuongDaiLyToiDa
        Me.iSoLuongMatHang = iSoLuongMatHang
    End Sub
    Public Property ID As Integer
        Get
            Return iId
        End Get
        Set(value As Integer)
            iId = value
        End Set
    End Property
    Public Property SoLuongLoaiDaiLy As Integer
        Get
            Return iSoLuongLoaiDaiLy
        End Get
        Set(value As Integer)
            iSoLuongLoaiDaiLy = value
        End Set
    End Property
    Public Property SoLuongDaiLyToiDa As Integer
        Get
            Return iSoLuongDaiLyToiDa
        End Get
        Set(value As Integer)
            iSoLuongDaiLyToiDa = value
        End Set
    End Property
    Public Property SoLuongMatHang As Integer
        Get
            Return iSoLuongMatHang
        End Get
        Set(value As Integer)
            iSoLuongMatHang = value
        End Set
    End Property
End Class
