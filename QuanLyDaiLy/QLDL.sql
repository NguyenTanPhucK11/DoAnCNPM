	USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='QLDL')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'QLDL') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [QLDL]
END
GO

/* Collation = SQL_Latin1_General_CP1_CI_AS */
CREATE DATABASE [QLDL]
GO

USE [QLDL]
GO


/****** Object:  Table [dbo].[tblLoaiDaiLy] ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblLoaiDaiLy](
	[MaLoaiDaiLy] [int] NOT NULL,
	[TenLoaiDaiLy] [nvarchar](50) NOT NULL,
	[NoToiDa] [int] NOT NULL,
 CONSTRAINT [PK_tblLoaiDaiLy] PRIMARY KEY CLUSTERED 
(
	[MaLoaiDaiLy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [QLDL]
GO


/****** Object:  Table [dbo].[tblQuan] ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblQuan](
	[MaQuan] [int] NOT NULL,
	[TenQuan] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblQuan] PRIMARY KEY CLUSTERED 
(
	[MaQuan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [QLDL]
GO


/****** Object:  Table [dbo].[tblDaiLy] ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/* Note: */
/* [datetime2](7) = DateTime type in .NET */

CREATE TABLE [dbo].[tblDaiLy](
	[MaDaiLy] [nvarchar](8) NOT NULL,
	[MaLoaiDaiLy] [int] NOT NULL,
	[MaQuan] [int] NOT NULL,
	[TenDaiLy] [nvarchar](50) NOT NULL,
	[DienThoai] [int] NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[NgayTiepNhan] [datetime2](7) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[NoCuaDaiLy] [int] NOT NULL,
 CONSTRAINT [PK_tblDaiLy] PRIMARY KEY CLUSTERED 
(
	[MaDaiLy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [QLDL]
GO

INSERT INTO[dbo].[tblLoaiDaiLy]([MaLoaiDaiLy],[TenLoaiDaiLy],[NoToiDa]) VALUES(1,N'Loại 1',20000)
GO
INSERT INTO[dbo].[tblLoaiDaiLy]([MaLoaiDaiLy],[TenLoaiDaiLy],[NoToiDa]) VALUES(2,N'Loại 2',50)
GO

USE [QLDL]
GO

INSERT INTO[dbo].[tblQuan]([MaQuan],[TenQuan]) VALUES(1,N'Quận 1')
GO
INSERT INTO[dbo].[tblQuan]([MaQuan],[TenQuan]) VALUES(2,N'Thủ Đức')
GO

USE [QLDL]
GO

INSERT INTO[dbo].[tblDaiLy]([MaDaiLy],[MaLoaiDaiLy],[MaQuan],[TenDaiLy],[DienThoai],[DiaChi],[NgayTiepNhan],[Email],[NoCuaDaiLy]) VALUES(N'16000001',1,1,N'Đăng Khoa',0914080804,N'KTX Khu B',convert(datetime,'7/26/2018 00:00:00'),N'Đăng Khoa',10000)
GO
INSERT INTO[dbo].[tblDaiLy]([MaDaiLy],[MaLoaiDaiLy],[MaQuan],[TenDaiLy],[DienThoai],[DiaChi],[NgayTiepNhan],[Email],[NoCuaDaiLy]) VALUES(N'16000002',2,2,N'Tấn Phúc',0914080805,N'KTX Khu A',convert(datetime,'7/28/2018 00:00:00'),N'Tấn Phúc',20)
GO


/****** Object:  Table [dbo].[tblPhieuXuat] ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/* Note: */
/* [datetime2](7) = DateTime type in .NET */

CREATE TABLE [dbo].[tblPhieuXuat](
	[MaPhieuXuat] [int] NOT NULL,
	[MaDaiLy] [nvarchar](8) NOT NULL,	
	[NgayLapPhieu] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_tblPhieuXuat] PRIMARY KEY CLUSTERED 
(
	[MaPhieuXuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [QLDL]
GO

INSERT INTO[dbo].[tblPhieuXuat]([MaPhieuXuat],[MaDaiLy],[NgayLapPhieu]) VALUES(1,N'16000001',convert(datetime,'7/26/2018 00:00:00'))
GO
INSERT INTO[dbo].[tblPhieuXuat]([MaPhieuXuat],[MaDaiLy],[NgayLapPhieu]) VALUES(2,N'16000002',convert(datetime,'7/24/2018 00:00:00'))
GO


/****** Object:  Table [dbo].[tblMatHang] ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblMatHang](
	[MaMatHang] int NOT NULL,
	[TenMatHang] [nvarchar](50) NOT NULL,	
	[SoLuongTon] [int] NOT NULL,
 CONSTRAINT [PK_tblMatHang] PRIMARY KEY CLUSTERED 
(
	[MaMatHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [QLDL]
GO

INSERT INTO[dbo].[tblMatHang]([MaMatHang],[TenMatHang],[SoLuongTon]) VALUES(1,N'Máy tính',1000)
GO
INSERT INTO[dbo].[tblMatHang]([MaMatHang],[TenMatHang],[SoLuongTon]) VALUES(2,N'Bàn',10000)
GO
INSERT INTO[dbo].[tblMatHang]([MaMatHang],[TenMatHang],[SoLuongTon]) VALUES(3,N'Chuột',10000)
GO
INSERT INTO[dbo].[tblMatHang]([MaMatHang],[TenMatHang],[SoLuongTon]) VALUES(4,N'Bánh',10000)
GO
INSERT INTO[dbo].[tblMatHang]([MaMatHang],[TenMatHang],[SoLuongTon]) VALUES(5,N'Nước',10000)
GO


/****** Object:  Table [dbo].[tblDonViTinh] ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblDonViTinh](
	[MaDonViTinh]int NOT NULL,
	[TenDonViTinh] [nvarchar](50) NOT NULL,	
 CONSTRAINT [PK_tblDonViTinh] PRIMARY KEY CLUSTERED 
(
	[MaDonViTinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [QLDL]
GO

INSERT INTO[dbo].[tblDonViTinh]([MaDonViTinh],[TenDonViTinh]) VALUES(1,N'Kg')
GO
INSERT INTO[dbo].[tblDonViTinh]([MaDonViTinh],[TenDonViTinh]) VALUES(2,N'Gam')
GO
INSERT INTO[dbo].[tblDonViTinh]([MaDonViTinh],[TenDonViTinh]) VALUES(3,N'Tấn')
GO


/****** Object:  Table [dbo].[tblChiTietPhieuXuat] ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblChiTietPhieuXuat](
	[MaChiTietPhieuXuat] [nvarchar](8) NOT NULL,
	[MaPhieuXuat] [int] NOT NULL,
	[MaMatHang] [int] NOT NULL,
	[MaDonViTinh] [int] NOT NULL,	
	[SoLuongXuat] [int] NOT NULL,
	[DonGia] [int] NOT NULL,
 CONSTRAINT [PK_tblChiTietPhieuXuat] PRIMARY KEY CLUSTERED 
(
	[MaChiTietPhieuXuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [QLDL]
GO

INSERT INTO[dbo].[tblChiTietPhieuXuat]([MaChiTietPhieuXuat],[MaPhieuXuat],[MaMatHang],[MaDonViTinh],[SoLuongXuat],[DonGia]) VALUES(N'CTPX-001',1,1,1,10,5000)
GO
INSERT INTO[dbo].[tblChiTietPhieuXuat]([MaChiTietPhieuXuat],[MaPhieuXuat],[MaMatHang],[MaDonViTinh],[SoLuongXuat],[DonGia]) VALUES(N'CTPX-002',2,2,2,20,4500)
GO


/****** Object:  Table [dbo].[tblPhieuThuTien] ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblPhieuThuTien](
	[MaPhieuThuTien] [nvarchar](7) NOT NULL,
	[MaDaiLy] [nvarchar](8) NOT NULL,
	[NgayThuTien] [datetime2](7) NOT NULL,
	[SoTienThu] [int] NOT NULL,	
 CONSTRAINT [PK_tblPhieuThuTien] PRIMARY KEY CLUSTERED 
(
	[MaPhieuThuTien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [QLDL]
GO

INSERT INTO[dbo].[tblPhieuThuTien]([MaPhieuThuTien],[MaDaiLy],[NgayThuTien],[SoTienThu]) VALUES(N'PTT-001',N'16000001',convert(datetime,'6/30/2017 00:00:00'), 5000)
GO
INSERT INTO[dbo].[tblPhieuThuTien]([MaPhieuThuTien],[MaDaiLy],[NgayThuTien],[SoTienThu]) VALUES(N'PTT-002',N'16000002',convert(datetime,'7/30/2017 00:00:00'), 10000)
GO 


/****** Object:  Table [dbo].[tblThamSo] ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblThamSo](
	[Id] [int] NOT NULL,
	[SoLuongLoaiDaiLy] [int] NOT NULL,
	[SoLuongDaiLyToiDa] [int] NOT NULL,
	[SoLuongMatHang] [int] NOT NULL,	
CONSTRAINT [PK_tblThamSo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QLDL]
GO

INSERT INTO[dbo].[tblThamSo]([Id],[SoLuongLoaiDaiLy],[SoLuongDaiLyToiDa],[SoLuongMatHang]) VALUES(1,2,4,5)
GO
 
