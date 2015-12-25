USE [master]
GO
/****** Object:  Database [QL_VLXD]    Script Date: 12/25/2015 11:26:21 AM ******/
CREATE DATABASE [QL_VLXD]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QL_VLXD', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QL_VLXD.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QL_VLXD_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QL_VLXD_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QL_VLXD] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QL_VLXD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QL_VLXD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QL_VLXD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QL_VLXD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QL_VLXD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QL_VLXD] SET ARITHABORT OFF 
GO
ALTER DATABASE [QL_VLXD] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QL_VLXD] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QL_VLXD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QL_VLXD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QL_VLXD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QL_VLXD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QL_VLXD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QL_VLXD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QL_VLXD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QL_VLXD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QL_VLXD] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QL_VLXD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QL_VLXD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QL_VLXD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QL_VLXD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QL_VLXD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QL_VLXD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QL_VLXD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QL_VLXD] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QL_VLXD] SET  MULTI_USER 
GO
ALTER DATABASE [QL_VLXD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QL_VLXD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QL_VLXD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QL_VLXD] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QL_VLXD]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 12/25/2015 11:26:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaHD] [nchar](10) NOT NULL,
	[MaLH] [nchar](10) NOT NULL,
	[SLBan] [int] NOT NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaLH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 12/25/2015 11:26:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[MaPN] [nchar](10) NOT NULL,
	[MaLH] [nchar](10) NOT NULL,
 CONSTRAINT [PK_ChiTietPhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC,
	[MaLH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietPKK]    Script Date: 12/25/2015 11:26:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPKK](
	[MaPKK] [nchar](10) NOT NULL,
	[MaLH] [nchar](10) NOT NULL,
	[SLTon] [int] NOT NULL,
 CONSTRAINT [PK_ChiTietPKK] PRIMARY KEY CLUSTERED 
(
	[MaPKK] ASC,
	[MaLH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DonViTinh]    Script Date: 12/25/2015 11:26:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonViTinh](
	[MaDVT] [nchar](10) NOT NULL,
	[TenDVT] [nchar](10) NOT NULL,
 CONSTRAINT [PK_DonViTinh] PRIMARY KEY CLUSTERED 
(
	[MaDVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 12/25/2015 11:26:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [nchar](10) NOT NULL,
	[MaNV] [nchar](10) NOT NULL,
	[MaKH] [nchar](10) NOT NULL,
	[ThoiGianLap] [smalldatetime] NOT NULL,
	[TongTien] [money] NOT NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 12/25/2015 11:26:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [nchar](10) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[Sdt] [nvarchar](11) NOT NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoHang]    Script Date: 12/25/2015 11:26:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoHang](
	[MaLH] [nchar](10) NOT NULL,
	[MaMH] [nchar](10) NOT NULL,
	[NgaySX] [smalldatetime] NOT NULL,
	[HanSD] [int] NOT NULL,
	[SLNhap] [int] NOT NULL,
	[SLBan] [int] NOT NULL,
	[GiaNhap] [money] NOT NULL,
	[GiaBan] [money] NOT NULL,
 CONSTRAINT [PK_LoHang] PRIMARY KEY CLUSTERED 
(
	[MaLH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MatHang]    Script Date: 12/25/2015 11:26:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MatHang](
	[MaMH] [nchar](10) NOT NULL,
	[TenMH] [nvarchar](50) NOT NULL,
	[TenNSX] [nvarchar](50) NOT NULL,
	[MaDVT] [nchar](10) NOT NULL,
	[ThueVAT] [float] NOT NULL,
 CONSTRAINT [PK_MatHang] PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaCC]    Script Date: 12/25/2015 11:26:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCC](
	[MaNCC] [nchar](10) NOT NULL,
	[TenNCC] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](max) NULL,
	[SDT] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhaCC] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/25/2015 11:26:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nchar](10) NOT NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[NgaySinh] [smalldatetime] NOT NULL,
	[GioiTinh] [int] NOT NULL,
	[CMND] [int] NOT NULL,
	[DiaChi] [nvarchar](max) NULL,
	[NgayVL] [smalldatetime] NOT NULL,
	[TenDangNhap] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuKiemKe]    Script Date: 12/25/2015 11:26:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuKiemKe](
	[MaPKK] [nchar](10) NOT NULL,
	[MaNV] [nchar](10) NOT NULL,
	[ThoiGianLap] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_PhieuKiemKe] PRIMARY KEY CLUSTERED 
(
	[MaPKK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 12/25/2015 11:26:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPN] [nchar](10) NOT NULL,
	[MaNV] [nchar](10) NOT NULL,
	[MaNCC] [nchar](10) NOT NULL,
	[ThoiGianLap] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuThanhToan]    Script Date: 12/25/2015 11:26:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuThanhToan](
	[MaPhieuTT] [nchar](10) NOT NULL,
	[SoTienNop] [money] NOT NULL,
	[ThoiGianNop] [smalldatetime] NOT NULL,
	[MaHD] [nchar](10) NOT NULL,
	[MaNV] [nchar](10) NOT NULL,
 CONSTRAINT [PK_PhieuThanhToan] PRIMARY KEY CLUSTERED 
(
	[MaPhieuTT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThamSo]    Script Date: 12/25/2015 11:26:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThamSo](
	[TenTS] [nvarchar](50) NOT NULL,
	[GiaTri] [int] NOT NULL,
 CONSTRAINT [PK_ThamSo] PRIMARY KEY CLUSTERED 
(
	[TenTS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_LoHang] FOREIGN KEY([MaLH])
REFERENCES [dbo].[LoHang] ([MaLH])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_LoHang]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_LoHang] FOREIGN KEY([MaLH])
REFERENCES [dbo].[LoHang] ([MaLH])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_LoHang]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap] FOREIGN KEY([MaPN])
REFERENCES [dbo].[PhieuNhap] ([MaPN])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap]
GO
ALTER TABLE [dbo].[ChiTietPKK]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPKK_LoHang] FOREIGN KEY([MaLH])
REFERENCES [dbo].[LoHang] ([MaLH])
GO
ALTER TABLE [dbo].[ChiTietPKK] CHECK CONSTRAINT [FK_ChiTietPKK_LoHang]
GO
ALTER TABLE [dbo].[ChiTietPKK]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPKK_PhieuKiemKe] FOREIGN KEY([MaPKK])
REFERENCES [dbo].[PhieuKiemKe] ([MaPKK])
GO
ALTER TABLE [dbo].[ChiTietPKK] CHECK CONSTRAINT [FK_ChiTietPKK_PhieuKiemKe]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
ALTER TABLE [dbo].[LoHang]  WITH CHECK ADD  CONSTRAINT [FK_LoHang_MatHang] FOREIGN KEY([MaMH])
REFERENCES [dbo].[MatHang] ([MaMH])
GO
ALTER TABLE [dbo].[LoHang] CHECK CONSTRAINT [FK_LoHang_MatHang]
GO
ALTER TABLE [dbo].[MatHang]  WITH CHECK ADD  CONSTRAINT [FK_MatHang_DonViTinh] FOREIGN KEY([MaDVT])
REFERENCES [dbo].[DonViTinh] ([MaDVT])
GO
ALTER TABLE [dbo].[MatHang] CHECK CONSTRAINT [FK_MatHang_DonViTinh]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhaCC] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCC] ([MaNCC])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhaCC]
GO
ALTER TABLE [dbo].[PhieuThanhToan]  WITH CHECK ADD  CONSTRAINT [FK_PhieuThanhToan_HoaDon] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[PhieuThanhToan] CHECK CONSTRAINT [FK_PhieuThanhToan_HoaDon]
GO
USE [master]
GO
ALTER DATABASE [QL_VLXD] SET  READ_WRITE 
GO
