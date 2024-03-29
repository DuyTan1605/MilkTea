USE [master]
GO
/****** Object:  Database [QuanLiTraSua]    Script Date: 12/14/2019 10:25:00 AM ******/
CREATE DATABASE [QuanLiTraSua]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLiTraSua', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QuanLiTraSua.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLiTraSua_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QuanLiTraSua_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLiTraSua] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLiTraSua].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLiTraSua] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLiTraSua] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLiTraSua] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLiTraSua] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLiTraSua] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLiTraSua] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLiTraSua] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLiTraSua] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLiTraSua] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLiTraSua] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLiTraSua] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLiTraSua] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLiTraSua] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLiTraSua] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLiTraSua] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLiTraSua] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLiTraSua] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLiTraSua] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLiTraSua] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLiTraSua] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLiTraSua] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLiTraSua] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLiTraSua] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLiTraSua] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLiTraSua] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLiTraSua] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLiTraSua] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLiTraSua] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QuanLiTraSua] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QuanLiTraSua]
GO
/****** Object:  Table [dbo].[CHITIETHOADON]    Script Date: 12/14/2019 10:25:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETHOADON](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_HoaDon] [int] NULL,
	[ID_Mon] [int] NULL,
	[Duong] [nvarchar](50) NULL,
	[Da] [nvarchar](50) NULL,
	[Huong] [nvarchar](50) NULL,
	[Topping] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITIETMON]    Script Date: 12/14/2019 10:25:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETMON](
	[ID_Mon] [int] NOT NULL,
	[ID_NguyenLieu] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Mon] ASC,
	[ID_NguyenLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 12/14/2019 10:25:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_KhachHang] [int] NULL,
	[NgayDat] [datetime] NULL,
	[HinhThucThanhToan] [nvarchar](50) NULL,
	[KT_Ship] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 12/14/2019 10:25:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[NgaySinh] [datetime] NULL,
	[SDT] [varchar](11) NULL,
	[LoaiKH] [int] NULL,
	[Email] [varchar](50) NULL,
	[DiemTichLuy] [int] NULL,
 CONSTRAINT [PK__KHACHHAN__3214EC27D7C7DF7E] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOAIKHACHHANG]    Script Date: 12/14/2019 10:25:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIKHACHHANG](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LoaiKhachHang] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MON]    Script Date: 12/14/2019 10:25:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MON](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenMon] [nvarchar](50) NULL,
	[Size] [nvarchar](10) NULL,
	[Gia] [int] NULL,
	[KT_DacBiet] [int] NULL,
	[KT_BanChay] [int] NULL,
	[LinkAnh] [varchar](20) NULL,
 CONSTRAINT [PK__MON__3214EC278A977807] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NGUYENLIEU]    Script Date: 12/14/2019 10:25:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGUYENLIEU](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenNguyenLieu] [nvarchar](50) NULL,
	[XuatXu] [nvarchar](50) NULL,
	[NgayNhap] [datetime] NULL,
	[TinhTrang] [nvarchar](50) NULL,
 CONSTRAINT [PK__NGUYENLI__3214EC27D8E657B1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SHIP]    Script Date: 12/14/2019 10:25:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SHIP](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_HoaDon] [int] NULL,
	[ID_Shipper] [int] NULL,
	[TenNguoiGiao] [nvarchar](50) NULL,
	[SDTNguoiGiao] [varchar](11) NULL,
	[TenNguoiNhan] [nvarchar](50) NULL,
	[SDTNguoiNhan] [varchar](11) NULL,
	[DiaChiNhan] [nvarchar](50) NULL,
 CONSTRAINT [PK__SHIP__3214EC27F0420ECA] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SHIPPER]    Script Date: 12/14/2019 10:25:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SHIPPER](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](20) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [varchar](11) NULL,
	[CtyQuanLi] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[CHITIETHOADON] ON 

INSERT [dbo].[CHITIETHOADON] ([ID], [ID_HoaDon], [ID_Mon], [Duong], [Da], [Huong], [Topping], [GhiChu]) VALUES (1, 1, 1, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[CHITIETHOADON] ([ID], [ID_HoaDon], [ID_Mon], [Duong], [Da], [Huong], [Topping], [GhiChu]) VALUES (2, 1, 2, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[CHITIETHOADON] ([ID], [ID_HoaDon], [ID_Mon], [Duong], [Da], [Huong], [Topping], [GhiChu]) VALUES (3, 2, 1, NULL, NULL, NULL, NULL, N'Không dá')
INSERT [dbo].[CHITIETHOADON] ([ID], [ID_HoaDon], [ID_Mon], [Duong], [Da], [Huong], [Topping], [GhiChu]) VALUES (4, 3, 1, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[CHITIETHOADON] ([ID], [ID_HoaDon], [ID_Mon], [Duong], [Da], [Huong], [Topping], [GhiChu]) VALUES (5, 4, 5, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[CHITIETHOADON] ([ID], [ID_HoaDon], [ID_Mon], [Duong], [Da], [Huong], [Topping], [GhiChu]) VALUES (6, 5, 6, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[CHITIETHOADON] ([ID], [ID_HoaDon], [ID_Mon], [Duong], [Da], [Huong], [Topping], [GhiChu]) VALUES (7, 6, 5, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[CHITIETHOADON] ([ID], [ID_HoaDon], [ID_Mon], [Duong], [Da], [Huong], [Topping], [GhiChu]) VALUES (8, 7, 3, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[CHITIETHOADON] ([ID], [ID_HoaDon], [ID_Mon], [Duong], [Da], [Huong], [Topping], [GhiChu]) VALUES (9, 8, 4, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[CHITIETHOADON] ([ID], [ID_HoaDon], [ID_Mon], [Duong], [Da], [Huong], [Topping], [GhiChu]) VALUES (10, 9, 7, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[CHITIETHOADON] ([ID], [ID_HoaDon], [ID_Mon], [Duong], [Da], [Huong], [Topping], [GhiChu]) VALUES (91, 41, 14, N'100%', N'100%', N'Truyền thống', N'Không', N'')
INSERT [dbo].[CHITIETHOADON] ([ID], [ID_HoaDon], [ID_Mon], [Duong], [Da], [Huong], [Topping], [GhiChu]) VALUES (92, 41, 14, N'100%', N'100%', N'Truyền thống', N'Không', N'')
INSERT [dbo].[CHITIETHOADON] ([ID], [ID_HoaDon], [ID_Mon], [Duong], [Da], [Huong], [Topping], [GhiChu]) VALUES (93, 41, 14, N'100%', N'100%', N'Truyền thống', N'Không', N'')
INSERT [dbo].[CHITIETHOADON] ([ID], [ID_HoaDon], [ID_Mon], [Duong], [Da], [Huong], [Topping], [GhiChu]) VALUES (98, 51, 30, N'100%', N'100%', N'Truyền thống', N'Không', N'')
INSERT [dbo].[CHITIETHOADON] ([ID], [ID_HoaDon], [ID_Mon], [Duong], [Da], [Huong], [Topping], [GhiChu]) VALUES (99, 51, 30, N'100%', N'100%', N'Truyền thống', N'Không', N'')
INSERT [dbo].[CHITIETHOADON] ([ID], [ID_HoaDon], [ID_Mon], [Duong], [Da], [Huong], [Topping], [GhiChu]) VALUES (100, 51, 30, N'100%', N'100%', N'Truyền thống', N'Không', N'')
INSERT [dbo].[CHITIETHOADON] ([ID], [ID_HoaDon], [ID_Mon], [Duong], [Da], [Huong], [Topping], [GhiChu]) VALUES (101, 51, 30, N'100%', N'100%', N'Truyền thống', N'Không', N'')
INSERT [dbo].[CHITIETHOADON] ([ID], [ID_HoaDon], [ID_Mon], [Duong], [Da], [Huong], [Topping], [GhiChu]) VALUES (102, 51, 30, N'100%', N'100%', N'Truyền thống', N'Không', N'')
SET IDENTITY_INSERT [dbo].[CHITIETHOADON] OFF
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (1, 2)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (1, 4)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (1, 14)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (2, 2)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (2, 4)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (2, 14)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (3, 2)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (3, 4)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (3, 14)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (4, 4)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (4, 14)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (5, 4)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (5, 14)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (6, 4)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (6, 14)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (7, 1)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (7, 4)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (7, 14)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (8, 1)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (8, 4)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (8, 14)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (9, 1)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (9, 4)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (9, 14)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (10, 4)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (10, 5)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (10, 14)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (11, 4)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (11, 5)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (11, 14)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (12, 4)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (12, 5)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (12, 14)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (13, 1)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (13, 4)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (13, 14)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (13, 15)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (14, 1)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (14, 4)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (14, 14)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (14, 15)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (15, 1)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (15, 4)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (15, 14)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (15, 15)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (16, 7)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (16, 13)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (17, 7)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (17, 13)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (18, 7)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (18, 13)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (19, 8)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (19, 13)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (20, 8)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (20, 13)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (21, 8)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (21, 13)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (22, 7)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (22, 13)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (23, 7)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (23, 13)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (24, 7)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (24, 13)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (25, 1)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (25, 11)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (25, 15)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (26, 1)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (26, 11)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (26, 15)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (27, 1)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (27, 11)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (27, 15)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (28, 1)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (28, 10)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (28, 15)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (29, 1)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (29, 10)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (29, 15)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (30, 1)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (30, 10)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (30, 15)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (31, 12)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (31, 15)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (32, 12)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (32, 15)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (33, 12)
INSERT [dbo].[CHITIETMON] ([ID_Mon], [ID_NguyenLieu]) VALUES (33, 15)
SET IDENTITY_INSERT [dbo].[HOADON] ON 

INSERT [dbo].[HOADON] ([ID], [ID_KhachHang], [NgayDat], [HinhThucThanhToan], [KT_Ship]) VALUES (1, 1, CAST(N'2019-11-28 00:00:00.000' AS DateTime), N'Thẻ ngân hàng', 0)
INSERT [dbo].[HOADON] ([ID], [ID_KhachHang], [NgayDat], [HinhThucThanhToan], [KT_Ship]) VALUES (2, 1, CAST(N'2019-11-29 00:00:00.000' AS DateTime), N'Tiền mặt', 1)
INSERT [dbo].[HOADON] ([ID], [ID_KhachHang], [NgayDat], [HinhThucThanhToan], [KT_Ship]) VALUES (3, 2, CAST(N'2019-11-29 00:00:00.000' AS DateTime), N'Tiền mặt', 1)
INSERT [dbo].[HOADON] ([ID], [ID_KhachHang], [NgayDat], [HinhThucThanhToan], [KT_Ship]) VALUES (4, 2, CAST(N'2019-11-30 00:00:00.000' AS DateTime), N'Tiền mặt', 1)
INSERT [dbo].[HOADON] ([ID], [ID_KhachHang], [NgayDat], [HinhThucThanhToan], [KT_Ship]) VALUES (5, 3, CAST(N'2019-12-01 00:00:00.000' AS DateTime), N'Tiền mặt', 1)
INSERT [dbo].[HOADON] ([ID], [ID_KhachHang], [NgayDat], [HinhThucThanhToan], [KT_Ship]) VALUES (6, 3, CAST(N'2019-12-02 00:00:00.000' AS DateTime), N'Tiền mặt', 1)
INSERT [dbo].[HOADON] ([ID], [ID_KhachHang], [NgayDat], [HinhThucThanhToan], [KT_Ship]) VALUES (7, 5, CAST(N'2019-12-01 00:00:00.000' AS DateTime), N'Tiền mặt', 1)
INSERT [dbo].[HOADON] ([ID], [ID_KhachHang], [NgayDat], [HinhThucThanhToan], [KT_Ship]) VALUES (8, 5, CAST(N'2019-12-02 00:00:00.000' AS DateTime), N'Thẻ ngân hàng', 0)
INSERT [dbo].[HOADON] ([ID], [ID_KhachHang], [NgayDat], [HinhThucThanhToan], [KT_Ship]) VALUES (9, NULL, CAST(N'2019-12-03 00:00:00.000' AS DateTime), N'Thẻ ngân hàng', 0)
INSERT [dbo].[HOADON] ([ID], [ID_KhachHang], [NgayDat], [HinhThucThanhToan], [KT_Ship]) VALUES (41, 3, CAST(N'2019-12-13 04:24:56.410' AS DateTime), N'Thẻ ngân hàng', 0)
INSERT [dbo].[HOADON] ([ID], [ID_KhachHang], [NgayDat], [HinhThucThanhToan], [KT_Ship]) VALUES (51, 9, CAST(N'2019-12-14 10:08:07.633' AS DateTime), N'Tiền mặt', 0)
SET IDENTITY_INSERT [dbo].[HOADON] OFF
SET IDENTITY_INSERT [dbo].[KHACHHANG] ON 

INSERT [dbo].[KHACHHANG] ([ID], [HoTen], [DiaChi], [NgaySinh], [SDT], [LoaiKH], [Email], [DiemTichLuy]) VALUES (1, N'Trần Văn An', N'Đồng Nai', CAST(N'1999-01-02 00:00:00.000' AS DateTime), N'08965432162', 1, N'tva@gmail.com', 17)
INSERT [dbo].[KHACHHANG] ([ID], [HoTen], [DiaChi], [NgaySinh], [SDT], [LoaiKH], [Email], [DiemTichLuy]) VALUES (2, N'Đỗ Văn Bình', N'Hồ Chí Minh', CAST(N'1998-02-03 00:00:00.000' AS DateTime), N'0919865401', 2, NULL, 19)
INSERT [dbo].[KHACHHANG] ([ID], [HoTen], [DiaChi], [NgaySinh], [SDT], [LoaiKH], [Email], [DiemTichLuy]) VALUES (3, N'Nguyễn Lê Tú', N'Hồ Chí Minh', NULL, N'0919876351', 1, N'aaa1@gmail.com', 10)
INSERT [dbo].[KHACHHANG] ([ID], [HoTen], [DiaChi], [NgaySinh], [SDT], [LoaiKH], [Email], [DiemTichLuy]) VALUES (4, N'Trần Văn Kiên', N'Hồ Chí Minh', CAST(N'2000-03-05 00:00:00.000' AS DateTime), N'0987652147', 1, N'tvk1111@gmail.com', 20)
INSERT [dbo].[KHACHHANG] ([ID], [HoTen], [DiaChi], [NgaySinh], [SDT], [LoaiKH], [Email], [DiemTichLuy]) VALUES (5, N'Phan Tấn Trung', N'Hồ Chí Minh', NULL, N'0768845561', 1, N'baroibeo@gmail.com', 50)
INSERT [dbo].[KHACHHANG] ([ID], [HoTen], [DiaChi], [NgaySinh], [SDT], [LoaiKH], [Email], [DiemTichLuy]) VALUES (6, N'Trương Tuấn Tú', N'Hải Phòng', NULL, N'0767845861', 1, N'tusena@gmail.com', 40)
INSERT [dbo].[KHACHHANG] ([ID], [HoTen], [DiaChi], [NgaySinh], [SDT], [LoaiKH], [Email], [DiemTichLuy]) VALUES (7, N'Phạm Gia Vỹ', N'Bình Dương', CAST(N'2001-09-08 00:00:00.000' AS DateTime), N'0932145671', 2, N'kitz1998@gmail.com', 25)
INSERT [dbo].[KHACHHANG] ([ID], [HoTen], [DiaChi], [NgaySinh], [SDT], [LoaiKH], [Email], [DiemTichLuy]) VALUES (8, N'Lê Quang Khải', N'Bình Dương', CAST(N'2003-03-04 00:00:00.000' AS DateTime), N'0768824479', 2, N'lqk2017@gmail.com', 35)
INSERT [dbo].[KHACHHANG] ([ID], [HoTen], [DiaChi], [NgaySinh], [SDT], [LoaiKH], [Email], [DiemTichLuy]) VALUES (9, N'Trần Bình Minh', N'Hồ Chí Minh', CAST(N'1997-09-08 00:00:00.000' AS DateTime), N'0917253617', 1, N'bmtran111@gmail.com', 28)
INSERT [dbo].[KHACHHANG] ([ID], [HoTen], [DiaChi], [NgaySinh], [SDT], [LoaiKH], [Email], [DiemTichLuy]) VALUES (10, N'Nguyễn Thị Tươi', N'Hồ Chí Minh', NULL, N'0939765438', 1, N'tttuoi222@gmail.com', 150)
SET IDENTITY_INSERT [dbo].[KHACHHANG] OFF
SET IDENTITY_INSERT [dbo].[LOAIKHACHHANG] ON 

INSERT [dbo].[LOAIKHACHHANG] ([ID], [LoaiKhachHang]) VALUES (1, N'Thành viên thường')
INSERT [dbo].[LOAIKHACHHANG] ([ID], [LoaiKhachHang]) VALUES (2, N'Thành viên VIP')
SET IDENTITY_INSERT [dbo].[LOAIKHACHHANG] OFF
SET IDENTITY_INSERT [dbo].[MON] ON 

INSERT [dbo].[MON] ([ID], [TenMon], [Size], [Gia], [KT_DacBiet], [KT_BanChay], [LinkAnh]) VALUES (1, N'Trà sữa chocolate', N'S', 20000, 0, 0, N'1.png')
INSERT [dbo].[MON] ([ID], [TenMon], [Size], [Gia], [KT_DacBiet], [KT_BanChay], [LinkAnh]) VALUES (2, N'Trà sữa chocolate', N'M', 25000, 0, 0, N'1.png')
INSERT [dbo].[MON] ([ID], [TenMon], [Size], [Gia], [KT_DacBiet], [KT_BanChay], [LinkAnh]) VALUES (3, N'Trà sữa chocolate', N'L', 30000, 0, 0, N'1.png')
INSERT [dbo].[MON] ([ID], [TenMon], [Size], [Gia], [KT_DacBiet], [KT_BanChay], [LinkAnh]) VALUES (4, N'Trà sữa truyền thống', N'S', 15000, 0, 0, N'2.png')
INSERT [dbo].[MON] ([ID], [TenMon], [Size], [Gia], [KT_DacBiet], [KT_BanChay], [LinkAnh]) VALUES (5, N'Trà sữa truyền thống', N'M', 20000, 0, 0, N'2.png')
INSERT [dbo].[MON] ([ID], [TenMon], [Size], [Gia], [KT_DacBiet], [KT_BanChay], [LinkAnh]) VALUES (6, N'Trà sữa truyền thống', N'L', 25000, 0, 0, N'2.png')
INSERT [dbo].[MON] ([ID], [TenMon], [Size], [Gia], [KT_DacBiet], [KT_BanChay], [LinkAnh]) VALUES (7, N'Trà sữa thái', N'S', 15000, 0, 0, N'3.png')
INSERT [dbo].[MON] ([ID], [TenMon], [Size], [Gia], [KT_DacBiet], [KT_BanChay], [LinkAnh]) VALUES (8, N'Trà sữa thái', N'M', 20000, 0, 0, N'3.png')
INSERT [dbo].[MON] ([ID], [TenMon], [Size], [Gia], [KT_DacBiet], [KT_BanChay], [LinkAnh]) VALUES (9, N'Trà sữa thái', N'L', 25000, 0, 0, N'3.png')
INSERT [dbo].[MON] ([ID], [TenMon], [Size], [Gia], [KT_DacBiet], [KT_BanChay], [LinkAnh]) VALUES (10, N'Trà sữa matcha', N'S', 25000, 1, 0, N'4.png')
INSERT [dbo].[MON] ([ID], [TenMon], [Size], [Gia], [KT_DacBiet], [KT_BanChay], [LinkAnh]) VALUES (11, N'Trà sữa matcha', N'M', 30000, 1, 0, N'4.png')
INSERT [dbo].[MON] ([ID], [TenMon], [Size], [Gia], [KT_DacBiet], [KT_BanChay], [LinkAnh]) VALUES (12, N'Trà sữa matcha', N'L', 35000, 1, 0, N'4.png')
INSERT [dbo].[MON] ([ID], [TenMon], [Size], [Gia], [KT_DacBiet], [KT_BanChay], [LinkAnh]) VALUES (13, N'Trà sữa trân châu đường đen', N'S', 25000, 1, 0, N'5.png')
INSERT [dbo].[MON] ([ID], [TenMon], [Size], [Gia], [KT_DacBiet], [KT_BanChay], [LinkAnh]) VALUES (14, N'Trà sữa trân châu đường đen', N'M', 30000, 1, 0, N'5.png')
INSERT [dbo].[MON] ([ID], [TenMon], [Size], [Gia], [KT_DacBiet], [KT_BanChay], [LinkAnh]) VALUES (15, N'Trà sữa trân châu đường đen', N'L', 35000, 1, 0, N'5.png')
INSERT [dbo].[MON] ([ID], [TenMon], [Size], [Gia], [KT_DacBiet], [KT_BanChay], [LinkAnh]) VALUES (16, N'Hồng trà', N'S', 10000, 0, 1, N'6.png')
INSERT [dbo].[MON] ([ID], [TenMon], [Size], [Gia], [KT_DacBiet], [KT_BanChay], [LinkAnh]) VALUES (17, N'Hồng trà', N'M', 15000, 0, 1, N'6.png')
INSERT [dbo].[MON] ([ID], [TenMon], [Size], [Gia], [KT_DacBiet], [KT_BanChay], [LinkAnh]) VALUES (18, N'Hồng trà', N'L', 20000, 0, 1, N'6.png')
INSERT [dbo].[MON] ([ID], [TenMon], [Size], [Gia], [KT_DacBiet], [KT_BanChay], [LinkAnh]) VALUES (19, N'Hồng trà vải', N'S', 15000, 1, 0, N'7.png')
INSERT [dbo].[MON] ([ID], [TenMon], [Size], [Gia], [KT_DacBiet], [KT_BanChay], [LinkAnh]) VALUES (20, N'Hồng trà vải', N'M', 15000, 1, 0, N'7.png')
INSERT [dbo].[MON] ([ID], [TenMon], [Size], [Gia], [KT_DacBiet], [KT_BanChay], [LinkAnh]) VALUES (21, N'Hồng trà vải', N'L', 15000, 1, 0, N'7.png')
INSERT [dbo].[MON] ([ID], [TenMon], [Size], [Gia], [KT_DacBiet], [KT_BanChay], [LinkAnh]) VALUES (22, N'Hồng trà đào', N'S', 15000, 0, 1, N'8.png')
INSERT [dbo].[MON] ([ID], [TenMon], [Size], [Gia], [KT_DacBiet], [KT_BanChay], [LinkAnh]) VALUES (23, N'Hồng trà đào', N'M', 20000, 0, 1, N'8.png')
INSERT [dbo].[MON] ([ID], [TenMon], [Size], [Gia], [KT_DacBiet], [KT_BanChay], [LinkAnh]) VALUES (24, N'Hồng trà đào', N'L', 25000, 0, 1, N'8.png')
INSERT [dbo].[MON] ([ID], [TenMon], [Size], [Gia], [KT_DacBiet], [KT_BanChay], [LinkAnh]) VALUES (25, N'Hồng trà tắc', N'S', 12000, 0, 0, N'9.png')
INSERT [dbo].[MON] ([ID], [TenMon], [Size], [Gia], [KT_DacBiet], [KT_BanChay], [LinkAnh]) VALUES (26, N'Hồng trà tắc', N'M', 15000, 0, 0, N'9.png')
INSERT [dbo].[MON] ([ID], [TenMon], [Size], [Gia], [KT_DacBiet], [KT_BanChay], [LinkAnh]) VALUES (27, N'Hồng trà tắc', N'L', 20000, 0, 0, N'9.png')
INSERT [dbo].[MON] ([ID], [TenMon], [Size], [Gia], [KT_DacBiet], [KT_BanChay], [LinkAnh]) VALUES (28, N'Sinh tố bơ', N'S', 25000, 0, 0, N'10.png')
INSERT [dbo].[MON] ([ID], [TenMon], [Size], [Gia], [KT_DacBiet], [KT_BanChay], [LinkAnh]) VALUES (29, N'Sinh tố bơ', N'M', 30000, 0, 0, N'10.png')
INSERT [dbo].[MON] ([ID], [TenMon], [Size], [Gia], [KT_DacBiet], [KT_BanChay], [LinkAnh]) VALUES (30, N'Sinh tố bơ', N'L', 35000, 0, 0, N'10.png')
INSERT [dbo].[MON] ([ID], [TenMon], [Size], [Gia], [KT_DacBiet], [KT_BanChay], [LinkAnh]) VALUES (31, N'Sinh tố dâu', N'S', 15000, 0, 1, N'11.png')
INSERT [dbo].[MON] ([ID], [TenMon], [Size], [Gia], [KT_DacBiet], [KT_BanChay], [LinkAnh]) VALUES (32, N'Sinh tố dâu', N'M', 20000, 0, 1, N'11.png')
INSERT [dbo].[MON] ([ID], [TenMon], [Size], [Gia], [KT_DacBiet], [KT_BanChay], [LinkAnh]) VALUES (33, N'Sinh tố dâu', N'L', 25000, 0, 1, N'11.png')
INSERT [dbo].[MON] ([ID], [TenMon], [Size], [Gia], [KT_DacBiet], [KT_BanChay], [LinkAnh]) VALUES (34, N'Nước ép táo', N'S', 25000, 1, 0, N'12.png')
INSERT [dbo].[MON] ([ID], [TenMon], [Size], [Gia], [KT_DacBiet], [KT_BanChay], [LinkAnh]) VALUES (35, N'Nước ép táo', N'M', 25000, 1, 0, N'12.png')
INSERT [dbo].[MON] ([ID], [TenMon], [Size], [Gia], [KT_DacBiet], [KT_BanChay], [LinkAnh]) VALUES (36, N'Nước ép táo', N'L', 25000, 1, 0, N'12.png')
SET IDENTITY_INSERT [dbo].[MON] OFF
SET IDENTITY_INSERT [dbo].[NGUYENLIEU] ON 

INSERT [dbo].[NGUYENLIEU] ([ID], [TenNguyenLieu], [XuatXu], [NgayNhap], [TinhTrang]) VALUES (1, N'Sữa tươi', N'Đồng Nai', CAST(N'2019-02-03 00:00:00.000' AS DateTime), N'Còn hàng')
INSERT [dbo].[NGUYENLIEU] ([ID], [TenNguyenLieu], [XuatXu], [NgayNhap], [TinhTrang]) VALUES (2, N'Bột chocolate', N'Thái Lan', CAST(N'2019-02-03 00:00:00.000' AS DateTime), N'Còn hàng')
INSERT [dbo].[NGUYENLIEU] ([ID], [TenNguyenLieu], [XuatXu], [NgayNhap], [TinhTrang]) VALUES (3, N'Bột matcha', N'Hà Nội', CAST(N'2019-03-03 00:00:00.000' AS DateTime), N'Sắp hết hàng')
INSERT [dbo].[NGUYENLIEU] ([ID], [TenNguyenLieu], [XuatXu], [NgayNhap], [TinhTrang]) VALUES (4, N'Trân châu đen', N'Hồ Chí Minh', CAST(N'2019-02-03 00:00:00.000' AS DateTime), N'Hết hàng')
INSERT [dbo].[NGUYENLIEU] ([ID], [TenNguyenLieu], [XuatXu], [NgayNhap], [TinhTrang]) VALUES (5, N'Thạch trái cây', N'Hồ Chí Minh', CAST(N'2019-02-03 00:00:00.000' AS DateTime), N'Còn hàng')
INSERT [dbo].[NGUYENLIEU] ([ID], [TenNguyenLieu], [XuatXu], [NgayNhap], [TinhTrang]) VALUES (6, N'Thạch nha đam', N'Hồ Chí Minh', CAST(N'2019-02-03 00:00:00.000' AS DateTime), N'Còn hàng')
INSERT [dbo].[NGUYENLIEU] ([ID], [TenNguyenLieu], [XuatXu], [NgayNhap], [TinhTrang]) VALUES (7, N'Đào tươi', N'Đà Lạt', CAST(N'2019-12-03 00:00:00.000' AS DateTime), N'Còn hàng')
INSERT [dbo].[NGUYENLIEU] ([ID], [TenNguyenLieu], [XuatXu], [NgayNhap], [TinhTrang]) VALUES (8, N'Vải', N'Đà Lạt', CAST(N'2019-12-03 00:00:00.000' AS DateTime), N'Còn hàng')
INSERT [dbo].[NGUYENLIEU] ([ID], [TenNguyenLieu], [XuatXu], [NgayNhap], [TinhTrang]) VALUES (9, N'Tắc', N'Tiền Giang', CAST(N'2019-12-03 00:00:00.000' AS DateTime), N'Còn hàng')
INSERT [dbo].[NGUYENLIEU] ([ID], [TenNguyenLieu], [XuatXu], [NgayNhap], [TinhTrang]) VALUES (10, N'Dâu', N'Đà Lạt', CAST(N'2019-12-05 00:00:00.000' AS DateTime), N'Sắp hết hàng')
INSERT [dbo].[NGUYENLIEU] ([ID], [TenNguyenLieu], [XuatXu], [NgayNhap], [TinhTrang]) VALUES (11, N'Bơ', N'Đà Lạt', CAST(N'2019-12-05 00:00:00.000' AS DateTime), N'Còn hàng')
INSERT [dbo].[NGUYENLIEU] ([ID], [TenNguyenLieu], [XuatXu], [NgayNhap], [TinhTrang]) VALUES (12, N'Táo', N'Hồ Chí Minh', CAST(N'2019-12-05 00:00:00.000' AS DateTime), N'Hết hàng')
INSERT [dbo].[NGUYENLIEU] ([ID], [TenNguyenLieu], [XuatXu], [NgayNhap], [TinhTrang]) VALUES (13, N'Hồng trà hòa tan', N'Hồ Chí Minh', CAST(N'2019-12-05 00:00:00.000' AS DateTime), N'Còn hàng')
INSERT [dbo].[NGUYENLIEU] ([ID], [TenNguyenLieu], [XuatXu], [NgayNhap], [TinhTrang]) VALUES (14, N'Bột trà sữa', N'Hồ Chí Minh', CAST(N'2019-12-05 00:00:00.000' AS DateTime), N'Còn hàng')
INSERT [dbo].[NGUYENLIEU] ([ID], [TenNguyenLieu], [XuatXu], [NgayNhap], [TinhTrang]) VALUES (15, N'Đường', N'Biên Hòa', CAST(N'2019-12-05 00:00:00.000' AS DateTime), N'Còn hàng')
SET IDENTITY_INSERT [dbo].[NGUYENLIEU] OFF
SET IDENTITY_INSERT [dbo].[SHIP] ON 

INSERT [dbo].[SHIP] ([ID], [ID_HoaDon], [ID_Shipper], [TenNguoiGiao], [SDTNguoiGiao], [TenNguoiNhan], [SDTNguoiNhan], [DiaChiNhan]) VALUES (1, 2, 1, NULL, NULL, NULL, N'0919865401', NULL)
INSERT [dbo].[SHIP] ([ID], [ID_HoaDon], [ID_Shipper], [TenNguoiGiao], [SDTNguoiGiao], [TenNguoiNhan], [SDTNguoiNhan], [DiaChiNhan]) VALUES (2, 2, 2, NULL, NULL, NULL, N'0919865401', NULL)
INSERT [dbo].[SHIP] ([ID], [ID_HoaDon], [ID_Shipper], [TenNguoiGiao], [SDTNguoiGiao], [TenNguoiNhan], [SDTNguoiNhan], [DiaChiNhan]) VALUES (3, 3, 5, NULL, NULL, NULL, N'0919876351', NULL)
INSERT [dbo].[SHIP] ([ID], [ID_HoaDon], [ID_Shipper], [TenNguoiGiao], [SDTNguoiGiao], [TenNguoiNhan], [SDTNguoiNhan], [DiaChiNhan]) VALUES (4, 3, NULL, N'Trần Huy', N'0908756431', NULL, N'0919876351', NULL)
INSERT [dbo].[SHIP] ([ID], [ID_HoaDon], [ID_Shipper], [TenNguoiGiao], [SDTNguoiGiao], [TenNguoiNhan], [SDTNguoiNhan], [DiaChiNhan]) VALUES (5, 5, 6, NULL, NULL, NULL, N'0768845561', NULL)
INSERT [dbo].[SHIP] ([ID], [ID_HoaDon], [ID_Shipper], [TenNguoiGiao], [SDTNguoiGiao], [TenNguoiNhan], [SDTNguoiNhan], [DiaChiNhan]) VALUES (6, 5, 3, NULL, NULL, NULL, N'0768845561', NULL)
SET IDENTITY_INSERT [dbo].[SHIP] OFF
SET IDENTITY_INSERT [dbo].[SHIPPER] ON 

INSERT [dbo].[SHIPPER] ([ID], [HoTen], [DiaChi], [SDT], [CtyQuanLi]) VALUES (1, N'Nguyễn Văn A', N'Hồ Chí Minh', N'0758849921', N'Grab')
INSERT [dbo].[SHIPPER] ([ID], [HoTen], [DiaChi], [SDT], [CtyQuanLi]) VALUES (2, N'Nguyễn Văn B', N'Hồ Chí Minh', N'0758949822', N'Go Viet')
INSERT [dbo].[SHIPPER] ([ID], [HoTen], [DiaChi], [SDT], [CtyQuanLi]) VALUES (3, N'Lê Đình Thành', N'Long An', N'0949844063', N'Go Viet')
INSERT [dbo].[SHIPPER] ([ID], [HoTen], [DiaChi], [SDT], [CtyQuanLi]) VALUES (4, N'Trần Long', N'Tiền Giang', N'0987635218', N'Go Viet')
INSERT [dbo].[SHIPPER] ([ID], [HoTen], [DiaChi], [SDT], [CtyQuanLi]) VALUES (5, N'Ngô Văn Tiến', N'An Giang', N'091762415', N'Grab')
INSERT [dbo].[SHIPPER] ([ID], [HoTen], [DiaChi], [SDT], [CtyQuanLi]) VALUES (6, N'Trần Văn Tý', N'Đồng Tháp', N'098975078', N'Grab')
INSERT [dbo].[SHIPPER] ([ID], [HoTen], [DiaChi], [SDT], [CtyQuanLi]) VALUES (7, N'Nguyễn Thị Hoa', N'Hồ Chí Minh', N'0768805505', N'Grab')
INSERT [dbo].[SHIPPER] ([ID], [HoTen], [DiaChi], [SDT], [CtyQuanLi]) VALUES (8, N'Nguyễn Thị Quỳnh', N'Đà Nẵng', N'0919897837', N'Grab')
INSERT [dbo].[SHIPPER] ([ID], [HoTen], [DiaChi], [SDT], [CtyQuanLi]) VALUES (9, N'Trần Văn Tèo', N'Đà Nẵng', N'0768805502', N'Grab')
INSERT [dbo].[SHIPPER] ([ID], [HoTen], [DiaChi], [SDT], [CtyQuanLi]) VALUES (10, N'Nguyễn Thị Quỳnh Hoa', N'Cà Mau', N'0919786541', N'Go Viet')
INSERT [dbo].[SHIPPER] ([ID], [HoTen], [DiaChi], [SDT], [CtyQuanLi]) VALUES (11, NULL, NULL, NULL, N'Vato')
INSERT [dbo].[SHIPPER] ([ID], [HoTen], [DiaChi], [SDT], [CtyQuanLi]) VALUES (12, NULL, NULL, NULL, N'Baemin')
SET IDENTITY_INSERT [dbo].[SHIPPER] OFF
/****** Object:  Index [UQ__HOADON__3214EC268EA0AADC]    Script Date: 12/14/2019 10:25:00 AM ******/
ALTER TABLE [dbo].[HOADON] ADD UNIQUE NONCLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UQ__KHACHHAN__3214EC2643E90EE5]    Script Date: 12/14/2019 10:25:00 AM ******/
ALTER TABLE [dbo].[KHACHHANG] ADD  CONSTRAINT [UQ__KHACHHAN__3214EC2643E90EE5] UNIQUE NONCLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHOADON_HOADON] FOREIGN KEY([ID_HoaDon])
REFERENCES [dbo].[HOADON] ([ID])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK_CHITIETHOADON_HOADON]
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHOADON_MON] FOREIGN KEY([ID_Mon])
REFERENCES [dbo].[MON] ([ID])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK_CHITIETHOADON_MON]
GO
ALTER TABLE [dbo].[CHITIETMON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETMON_MON] FOREIGN KEY([ID_Mon])
REFERENCES [dbo].[MON] ([ID])
GO
ALTER TABLE [dbo].[CHITIETMON] CHECK CONSTRAINT [FK_CHITIETMON_MON]
GO
ALTER TABLE [dbo].[CHITIETMON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETMON_NGUYENLIEU] FOREIGN KEY([ID_NguyenLieu])
REFERENCES [dbo].[NGUYENLIEU] ([ID])
GO
ALTER TABLE [dbo].[CHITIETMON] CHECK CONSTRAINT [FK_CHITIETMON_NGUYENLIEU]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_KHACHHANG] FOREIGN KEY([ID_KhachHang])
REFERENCES [dbo].[KHACHHANG] ([ID])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_KHACHHANG]
GO
ALTER TABLE [dbo].[KHACHHANG]  WITH CHECK ADD  CONSTRAINT [FK_KHACHHANG_LOAIKHACHHANG] FOREIGN KEY([LoaiKH])
REFERENCES [dbo].[LOAIKHACHHANG] ([ID])
GO
ALTER TABLE [dbo].[KHACHHANG] CHECK CONSTRAINT [FK_KHACHHANG_LOAIKHACHHANG]
GO
ALTER TABLE [dbo].[SHIP]  WITH CHECK ADD  CONSTRAINT [FK_SHIP_HOADON] FOREIGN KEY([ID_HoaDon])
REFERENCES [dbo].[HOADON] ([ID])
GO
ALTER TABLE [dbo].[SHIP] CHECK CONSTRAINT [FK_SHIP_HOADON]
GO
ALTER TABLE [dbo].[SHIP]  WITH CHECK ADD  CONSTRAINT [FK_SHIP_SHIPPER] FOREIGN KEY([ID_Shipper])
REFERENCES [dbo].[SHIPPER] ([ID])
GO
ALTER TABLE [dbo].[SHIP] CHECK CONSTRAINT [FK_SHIP_SHIPPER]
GO
/****** Object:  StoredProcedure [dbo].[USP_GetDrinkByID]    Script Date: 12/14/2019 10:25:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_GetDrinkByID] @id int
AS
BEGIN
SELECT * FROM MON WHERE ID = @id
END

GO
/****** Object:  StoredProcedure [dbo].[USP_GetDrinkByName]    Script Date: 12/14/2019 10:25:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetDrinkByName] @name_drink nvarchar(50)
AS
BEGIN
SELECT * FROM MON WHERE @name_drink=TenMon
END

GO
/****** Object:  StoredProcedure [dbo].[USP_GetListCustomer]    Script Date: 12/14/2019 10:25:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetListCustomer]
 AS
 BEGIN
 SELECT KH.ID,KH.HoTen,KH.NgaySinh,KH.DiaChi,KH.SDT,KH.LoaiKH,KH.Email,KH.DiemTichLuy FROM KHACHHANG KH,LOAIKHACHHANG L WHERE KH.LoaiKH=L.ID
 END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListDrink]    Script Date: 12/14/2019 10:25:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_GetListDrink]
AS
BEGIN
SELECT * FROM MON
END

GO
/****** Object:  StoredProcedure [dbo].[USP_GetListMaterial]    Script Date: 12/14/2019 10:25:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_GetListMaterial]
AS
BEGIN
SELECT * FROM NGUYENLIEU
END

GO
/****** Object:  StoredProcedure [dbo].[USP_GetMaterialByName]    Script Date: 12/14/2019 10:25:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_GetMaterialByName] @name_mater nvarchar(50)
AS
BEGIN
SELECT * FROM NGUYENLIEU WHERE TenNguyenLieu LIKE @name_mater
END

GO
/****** Object:  StoredProcedure [dbo].[USP_SearchCustomerByName]    Script Date: 12/14/2019 10:25:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_SearchCustomerByName] @keyword nvarchar(50)
AS
BEGIN
SELECT * FROM KHACHHANG WHERE HoTen LIKE '%' + @keyword + '%'
END

GO
/****** Object:  StoredProcedure [dbo].[USP_SearchMaterialByName]    Script Date: 12/14/2019 10:25:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_SearchMaterialByName] @keyword nvarchar(50)
AS
BEGIN
SELECT * FROM NGUYENLIEU WHERE TenNguyenLieu LIKE '%' + @keyword + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[USP_SearchProductByName]    Script Date: 12/14/2019 10:25:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 --ADD
CREATE PROC [dbo].[USP_SearchProductByName] @keyword nvarchar(50)
AS
BEGIN
SELECT * FROM MON WHERE TenMon LIKE '%' + @keyword + '%'
END

GO
USE [master]
GO
ALTER DATABASE [QuanLiTraSua] SET  READ_WRITE 
GO
