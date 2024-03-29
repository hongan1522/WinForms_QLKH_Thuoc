USE [master]
GO
/****** Object:  Database [QLKH_Thuoc]    Script Date: 1/12/2024 2:47:11 PM ******/
CREATE DATABASE [QLKH_Thuoc]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLKH_Thuoc', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.HONGAN\MSSQL\DATA\QLKH_Thuoc.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLKH_Thuoc_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.HONGAN\MSSQL\DATA\QLKH_Thuoc_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QLKH_Thuoc] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLKH_Thuoc].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLKH_Thuoc] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLKH_Thuoc] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLKH_Thuoc] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLKH_Thuoc] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLKH_Thuoc] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLKH_Thuoc] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLKH_Thuoc] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLKH_Thuoc] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLKH_Thuoc] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLKH_Thuoc] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLKH_Thuoc] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLKH_Thuoc] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLKH_Thuoc] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLKH_Thuoc] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLKH_Thuoc] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLKH_Thuoc] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLKH_Thuoc] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLKH_Thuoc] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLKH_Thuoc] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLKH_Thuoc] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLKH_Thuoc] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLKH_Thuoc] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLKH_Thuoc] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLKH_Thuoc] SET  MULTI_USER 
GO
ALTER DATABASE [QLKH_Thuoc] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLKH_Thuoc] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLKH_Thuoc] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLKH_Thuoc] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLKH_Thuoc] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLKH_Thuoc] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QLKH_Thuoc] SET QUERY_STORE = OFF
GO
USE [QLKH_Thuoc]
GO
/****** Object:  Table [dbo].[ChiNhanh]    Script Date: 1/12/2024 2:47:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiNhanh](
	[CN_ID] [nchar](10) NOT NULL,
	[CN_Name] [nvarchar](50) NULL,
	[CN_Address] [nvarchar](50) NULL,
 CONSTRAINT [PK_ChiNhanh] PRIMARY KEY CLUSTERED 
(
	[CN_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietDonNhap]    Script Date: 1/12/2024 2:47:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDonNhap](
	[Lo_ID] [nchar](10) NOT NULL,
	[DNhap_ID] [nchar](10) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Thuoc_ID] [nchar](10) NOT NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_ChiTietDonNhap] PRIMARY KEY CLUSTERED 
(
	[DNhap_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietDonXuat]    Script Date: 1/12/2024 2:47:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDonXuat](
	[DXuat_ID] [nchar](10) NOT NULL,
	[Thuoc_ID] [nchar](10) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_ChiTietDonXuat] PRIMARY KEY CLUSTERED 
(
	[DXuat_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietThuoc]    Script Date: 1/12/2024 2:47:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietThuoc](
	[Thuoc_ID] [nchar](10) NOT NULL,
	[Lo_ID] [nchar](10) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_ChiTietThuoc_1] PRIMARY KEY CLUSTERED 
(
	[Thuoc_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonNhap]    Script Date: 1/12/2024 2:47:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonNhap](
	[DNhap_ID] [nchar](10) NOT NULL,
	[NCC_ID] [nchar](10) NOT NULL,
	[DN_Datetime] [datetime] NOT NULL,
	[DN_Name] [nvarchar](50) NULL,
	[NV_ID] [nchar](10) NULL,
 CONSTRAINT [PK_DonNhap] PRIMARY KEY CLUSTERED 
(
	[DNhap_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonXuat]    Script Date: 1/12/2024 2:47:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonXuat](
	[DXuat_ID] [nchar](10) NOT NULL,
	[DX_Name] [nvarchar](50) NULL,
	[DX_Datetime] [datetime] NOT NULL,
	[NV_ID] [nchar](10) NULL,
 CONSTRAINT [PK_DonXuat] PRIMARY KEY CLUSTERED 
(
	[DXuat_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kho]    Script Date: 1/12/2024 2:47:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kho](
	[Kho_ID] [nchar](10) NOT NULL,
	[Kho_Name] [nvarchar](50) NULL,
	[Kho_Address] [nvarchar](50) NULL,
	[CN_ID] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Kho] PRIMARY KEY CLUSTERED 
(
	[Kho_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lo]    Script Date: 1/12/2024 2:47:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lo](
	[Lo_ID] [nchar](10) NOT NULL,
	[Lo_Name] [nvarchar](50) NULL,
	[Lo_Position] [nvarchar](50) NULL,
	[Kho_ID] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Lo] PRIMARY KEY CLUSTERED 
(
	[Lo_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NCC]    Script Date: 1/12/2024 2:47:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NCC](
	[NCC_ID] [nchar](10) NOT NULL,
	[NCC_Name] [nvarchar](50) NULL,
	[NCC_Address] [nvarchar](50) NULL,
	[NCC_Phone] [nvarchar](15) NULL,
	[NCC_Status] [nvarchar](50) NULL,
 CONSTRAINT [PK_NCC] PRIMARY KEY CLUSTERED 
(
	[NCC_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 1/12/2024 2:47:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[NV_ID] [nchar](10) NOT NULL,
	[NV_Name] [nvarchar](50) NULL,
	[BirthDay] [datetime] NULL,
	[Sex] [nvarchar](20) NULL,
	[Phone] [nvarchar](15) NULL,
	[Address] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[CN_ID] [nchar](10) NOT NULL,
	[UserID] [nchar](10) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[NV_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhomThuoc]    Script Date: 1/12/2024 2:47:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomThuoc](
	[Nhom_ID] [nchar](10) NOT NULL,
	[Nhom_Name] [nvarchar](50) NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_NhomThuoc] PRIMARY KEY CLUSTERED 
(
	[Nhom_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permission]    Script Date: 1/12/2024 2:47:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permission](
	[PermissionID] [nchar](10) NOT NULL,
	[PermissionName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Permission] PRIMARY KEY CLUSTERED 
(
	[PermissionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 1/12/2024 2:47:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[RoleID] [nchar](10) NOT NULL,
	[RoleName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role_Permission]    Script Date: 1/12/2024 2:47:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role_Permission](
	[RoleID] [nchar](10) NOT NULL,
	[PermissionID] [nchar](10) NOT NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Role_Permission] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC,
	[PermissionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 1/12/2024 2:47:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[UserID] [nchar](10) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[Password] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[RoleID] [nchar](10) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Thuoc]    Script Date: 1/12/2024 2:47:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Thuoc](
	[Thuoc_ID] [nchar](10) NOT NULL,
	[Thuoc_Name] [nvarchar](50) NULL,
	[Nhom_ID] [nchar](10) NULL,
 CONSTRAINT [PK_Thuoc] PRIMARY KEY CLUSTERED 
(
	[Thuoc_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiNhanh] ([CN_ID], [CN_Name], [CN_Address]) VALUES (N'CN1       ', N'CN_HCM', N'Hồ Chí Minh')
INSERT [dbo].[ChiNhanh] ([CN_ID], [CN_Name], [CN_Address]) VALUES (N'CN2       ', N'CN_HaNoi', N'Hà Nội')
INSERT [dbo].[ChiNhanh] ([CN_ID], [CN_Name], [CN_Address]) VALUES (N'CN3       ', N'CN_Hue', N'Huế')
INSERT [dbo].[ChiNhanh] ([CN_ID], [CN_Name], [CN_Address]) VALUES (N'CN4       ', N'CN_DaNang', N'Đà Nẵng')
INSERT [dbo].[ChiNhanh] ([CN_ID], [CN_Name], [CN_Address]) VALUES (N'CN5       ', N'CN_ThanhHoa', N'Thanh Hóa')
GO
INSERT [dbo].[ChiTietDonNhap] ([Lo_ID], [DNhap_ID], [Description], [Thuoc_ID], [Quantity]) VALUES (N'Lo6       ', N'DN1       ', N'', N'Thuoc4    ', 100)
INSERT [dbo].[ChiTietDonNhap] ([Lo_ID], [DNhap_ID], [Description], [Thuoc_ID], [Quantity]) VALUES (N'Lo3       ', N'DN2       ', NULL, N'Thuoc1    ', 20)
GO
INSERT [dbo].[ChiTietDonXuat] ([DXuat_ID], [Thuoc_ID], [Description], [Quantity]) VALUES (N'DX1       ', N'Thuoc4    ', N'', 25)
INSERT [dbo].[ChiTietDonXuat] ([DXuat_ID], [Thuoc_ID], [Description], [Quantity]) VALUES (N'DX3       ', N'Thuoc2    ', NULL, 120)
GO
INSERT [dbo].[ChiTietThuoc] ([Thuoc_ID], [Lo_ID], [Description], [Quantity]) VALUES (N'Thuoc1    ', N'Lo6       ', N'', 120)
INSERT [dbo].[ChiTietThuoc] ([Thuoc_ID], [Lo_ID], [Description], [Quantity]) VALUES (N'Thuoc2    ', N'Lo3       ', NULL, 130)
GO
INSERT [dbo].[DonNhap] ([DNhap_ID], [NCC_ID], [DN_Datetime], [DN_Name], [NV_ID]) VALUES (N'DN1       ', N'NCC1      ', CAST(N'2023-08-01T08:00:00.000' AS DateTime), N'DonNhap 1', N'NV1       ')
INSERT [dbo].[DonNhap] ([DNhap_ID], [NCC_ID], [DN_Datetime], [DN_Name], [NV_ID]) VALUES (N'DN2       ', N'NCC2      ', CAST(N'2023-11-15T10:30:00.000' AS DateTime), N'DonNhap 2', N'NV2       ')
INSERT [dbo].[DonNhap] ([DNhap_ID], [NCC_ID], [DN_Datetime], [DN_Name], [NV_ID]) VALUES (N'DN3       ', N'NCC1      ', CAST(N'2023-05-29T12:45:00.000' AS DateTime), N'DonNhap 3', N'NV3       ')
INSERT [dbo].[DonNhap] ([DNhap_ID], [NCC_ID], [DN_Datetime], [DN_Name], [NV_ID]) VALUES (N'DN4       ', N'NCC3      ', CAST(N'2023-08-01T08:00:00.000' AS DateTime), N'DonNhap 4', N'NV4       ')
INSERT [dbo].[DonNhap] ([DNhap_ID], [NCC_ID], [DN_Datetime], [DN_Name], [NV_ID]) VALUES (N'DN5       ', N'NCC4      ', CAST(N'2020-06-09T08:00:00.000' AS DateTime), N'DonNhap 5', N'NV5       ')
INSERT [dbo].[DonNhap] ([DNhap_ID], [NCC_ID], [DN_Datetime], [DN_Name], [NV_ID]) VALUES (N'DN6       ', N'NCC4      ', CAST(N'2023-02-21T08:00:00.000' AS DateTime), N'DonNhap 1', N'NV2       ')
GO
INSERT [dbo].[DonXuat] ([DXuat_ID], [DX_Name], [DX_Datetime], [NV_ID]) VALUES (N'DX1       ', N'DonXuat 1', CAST(N'2023-01-01T00:00:00.000' AS DateTime), N'NV1       ')
INSERT [dbo].[DonXuat] ([DXuat_ID], [DX_Name], [DX_Datetime], [NV_ID]) VALUES (N'DX2       ', N'DonXuat 2', CAST(N'2023-02-01T00:00:00.000' AS DateTime), N'NV2       ')
INSERT [dbo].[DonXuat] ([DXuat_ID], [DX_Name], [DX_Datetime], [NV_ID]) VALUES (N'DX3       ', N'DonXuat 3', CAST(N'2023-03-01T00:00:00.000' AS DateTime), N'NV3       ')
INSERT [dbo].[DonXuat] ([DXuat_ID], [DX_Name], [DX_Datetime], [NV_ID]) VALUES (N'DX4       ', N'DonXuat 4', CAST(N'2023-06-20T00:00:00.000' AS DateTime), N'NV4       ')
INSERT [dbo].[DonXuat] ([DXuat_ID], [DX_Name], [DX_Datetime], [NV_ID]) VALUES (N'DX5       ', N'DonXuat 5', CAST(N'2023-11-14T00:00:00.000' AS DateTime), N'NV5       ')
GO
INSERT [dbo].[Kho] ([Kho_ID], [Kho_Name], [Kho_Address], [CN_ID]) VALUES (N'Kho1      ', N'Kho_HiepPhuoc', N'KCN Hiệp Phước, Nhà Bè', N'CN1       ')
INSERT [dbo].[Kho] ([Kho_ID], [Kho_Name], [Kho_Address], [CN_ID]) VALUES (N'Kho2      ', N'Kho_GoVap', N'Gò Vấp, TPHCM', N'CN2       ')
INSERT [dbo].[Kho] ([Kho_ID], [Kho_Name], [Kho_Address], [CN_ID]) VALUES (N'Kho3      ', N'Kho_Quan7', N'Quận 7, TPHCM', N'CN3       ')
INSERT [dbo].[Kho] ([Kho_ID], [Kho_Name], [Kho_Address], [CN_ID]) VALUES (N'Kho4      ', N'Kho_BinhPhuoc', N'Bình Phước', N'CN4       ')
INSERT [dbo].[Kho] ([Kho_ID], [Kho_Name], [Kho_Address], [CN_ID]) VALUES (N'Kho5      ', N'Kho_HaiPhong', N'Hải Phòng, Hà Nội', N'CN5       ')
GO
INSERT [dbo].[Lo] ([Lo_ID], [Lo_Name], [Lo_Position], [Kho_ID]) VALUES (N'Lo1       ', N'Lo_HiepPhuoc_A', N'A', N'Kho1      ')
INSERT [dbo].[Lo] ([Lo_ID], [Lo_Name], [Lo_Position], [Kho_ID]) VALUES (N'Lo10      ', N'Lo_Quan7_B', N'B', N'Kho3      ')
INSERT [dbo].[Lo] ([Lo_ID], [Lo_Name], [Lo_Position], [Kho_ID]) VALUES (N'Lo11      ', N'Lo_Quan7_C', N'C', N'Kho3      ')
INSERT [dbo].[Lo] ([Lo_ID], [Lo_Name], [Lo_Position], [Kho_ID]) VALUES (N'Lo12      ', N'Lo_Quan7_D', N'D', N'Kho3      ')
INSERT [dbo].[Lo] ([Lo_ID], [Lo_Name], [Lo_Position], [Kho_ID]) VALUES (N'Lo13      ', N'Lo_BinhPhuoc_A', N'A', N'Kho4      ')
INSERT [dbo].[Lo] ([Lo_ID], [Lo_Name], [Lo_Position], [Kho_ID]) VALUES (N'Lo14      ', N'Lo_BinhPhuoc_B', N'B', N'Kho4      ')
INSERT [dbo].[Lo] ([Lo_ID], [Lo_Name], [Lo_Position], [Kho_ID]) VALUES (N'Lo15      ', N'Lo_BinhPhuoc_C', N'C', N'Kho4      ')
INSERT [dbo].[Lo] ([Lo_ID], [Lo_Name], [Lo_Position], [Kho_ID]) VALUES (N'Lo16      ', N'Lo_HiepPhuoc_D', N'D', N'Kho1      ')
INSERT [dbo].[Lo] ([Lo_ID], [Lo_Name], [Lo_Position], [Kho_ID]) VALUES (N'Lo17      ', N'Lo_HaiPhong_A', N'A', N'Kho5      ')
INSERT [dbo].[Lo] ([Lo_ID], [Lo_Name], [Lo_Position], [Kho_ID]) VALUES (N'Lo18      ', N'Lo_HaiPhong_B', N'B', N'Kho5      ')
INSERT [dbo].[Lo] ([Lo_ID], [Lo_Name], [Lo_Position], [Kho_ID]) VALUES (N'Lo19      ', N'Lo_HaiPhong_C', N'C', N'Kho5      ')
INSERT [dbo].[Lo] ([Lo_ID], [Lo_Name], [Lo_Position], [Kho_ID]) VALUES (N'Lo2       ', N'Lo_HiepPhuoc_B', N'B', N'Kho1      ')
INSERT [dbo].[Lo] ([Lo_ID], [Lo_Name], [Lo_Position], [Kho_ID]) VALUES (N'Lo20      ', N'Lo_HaiPhong_D', N'D', N'Kho5      ')
INSERT [dbo].[Lo] ([Lo_ID], [Lo_Name], [Lo_Position], [Kho_ID]) VALUES (N'Lo3       ', N'Lo_HiepPhuoc_C', N'C', N'Kho1      ')
INSERT [dbo].[Lo] ([Lo_ID], [Lo_Name], [Lo_Position], [Kho_ID]) VALUES (N'Lo4       ', N'Lo_HiepPhuoc_D', N'D', N'Kho1      ')
INSERT [dbo].[Lo] ([Lo_ID], [Lo_Name], [Lo_Position], [Kho_ID]) VALUES (N'Lo5       ', N'Lo_GoVap_A', N'A', N'Kho2      ')
INSERT [dbo].[Lo] ([Lo_ID], [Lo_Name], [Lo_Position], [Kho_ID]) VALUES (N'Lo6       ', N'Lo_GoVap_B', N'B', N'Kho2      ')
INSERT [dbo].[Lo] ([Lo_ID], [Lo_Name], [Lo_Position], [Kho_ID]) VALUES (N'Lo7       ', N'Lo_GoVap_C', N'C', N'Kho2      ')
INSERT [dbo].[Lo] ([Lo_ID], [Lo_Name], [Lo_Position], [Kho_ID]) VALUES (N'Lo8       ', N'Lo_GoVap_D', N'D', N'Kho2      ')
INSERT [dbo].[Lo] ([Lo_ID], [Lo_Name], [Lo_Position], [Kho_ID]) VALUES (N'Lo9       ', N'Lo_Quan7_A', N'A', N'Kho3      ')
GO
INSERT [dbo].[NCC] ([NCC_ID], [NCC_Name], [NCC_Address], [NCC_Phone], [NCC_Status]) VALUES (N'NCC1      ', N'Công ty TNHH Dược', N'TPHCM', N'0113456789', N'Hoạt động')
INSERT [dbo].[NCC] ([NCC_ID], [NCC_Name], [NCC_Address], [NCC_Phone], [NCC_Status]) VALUES (N'NCC2      ', N'Công ty cổ phần Bắc Hà', N'Hà Nội', N'0987654321', N'Hoạt động')
INSERT [dbo].[NCC] ([NCC_ID], [NCC_Name], [NCC_Address], [NCC_Phone], [NCC_Status]) VALUES (N'NCC3      ', N'Công ty ABC', N'TPHCM', N'0123456789', N'Hoạt động')
INSERT [dbo].[NCC] ([NCC_ID], [NCC_Name], [NCC_Address], [NCC_Phone], [NCC_Status]) VALUES (N'NCC4      ', N'Công ty Dược phẩm A', N'Quận 3, TPHCM', N'0119456789', N'Hoạt động')
INSERT [dbo].[NCC] ([NCC_ID], [NCC_Name], [NCC_Address], [NCC_Phone], [NCC_Status]) VALUES (N'NCC5      ', N'Công ty Dược W', N'Thanh Hóa', N'0323456789', N'Không hoạt động')
GO
INSERT [dbo].[NhanVien] ([NV_ID], [NV_Name], [BirthDay], [Sex], [Phone], [Address], [Email], [CN_ID], [UserID]) VALUES (N'NV1       ', N'Trần Văn A', CAST(N'1990-01-01T00:00:00.000' AS DateTime), N'Nam', N'0972345679', N'Nhà Bè', N'TranA@example.com', N'CN1       ', N'User1     ')
INSERT [dbo].[NhanVien] ([NV_ID], [NV_Name], [BirthDay], [Sex], [Phone], [Address], [Email], [CN_ID], [UserID]) VALUES (N'NV2       ', N'Nguyễn Thị B', CAST(N'1995-05-05T00:00:00.000' AS DateTime), N'Nữ', N'0987654321', N'TPHCM', N'NguyenB@example.com', N'CN1       ', N'User2     ')
INSERT [dbo].[NhanVien] ([NV_ID], [NV_Name], [BirthDay], [Sex], [Phone], [Address], [Email], [CN_ID], [UserID]) VALUES (N'NV3       ', N'Lê Văn C', CAST(N'1988-12-31T00:00:00.000' AS DateTime), N'Nam', N'0123456789', N'Gò Vấp', N'LeC@example.com', N'CN1       ', N'User3     ')
INSERT [dbo].[NhanVien] ([NV_ID], [NV_Name], [BirthDay], [Sex], [Phone], [Address], [Email], [CN_ID], [UserID]) VALUES (N'NV4       ', N'Dương Thị D', CAST(N'1990-01-01T00:00:00.000' AS DateTime), N'Nữ', N'0111111111', N'TPHCM', N'DuongD@gmail.com', N'CN2       ', N'User4     ')
INSERT [dbo].[NhanVien] ([NV_ID], [NV_Name], [BirthDay], [Sex], [Phone], [Address], [Email], [CN_ID], [UserID]) VALUES (N'NV5       ', N'Hồ Văn E', CAST(N'1995-06-20T00:00:00.000' AS DateTime), N'Nam', N'0672345679', N'Nhà Bè', N'VanE@example.com', N'CN1       ', N'User5     ')
GO
INSERT [dbo].[NhomThuoc] ([Nhom_ID], [Nhom_Name], [Description]) VALUES (N'Nhom1     ', N'N_HaSot', N'Nhóm thuốc hạ sốt')
INSERT [dbo].[NhomThuoc] ([Nhom_ID], [Nhom_Name], [Description]) VALUES (N'Nhom2     ', N'N_NhucDau', N'Nhóm thuốc giảm nhức đầu, đau nửa đầu')
INSERT [dbo].[NhomThuoc] ([Nhom_ID], [Nhom_Name], [Description]) VALUES (N'Nhom3     ', N'N_Vitamin', N'Nhóm thuốc bổ sung các vitamin')
GO
INSERT [dbo].[Permission] ([PermissionID], [PermissionName]) VALUES (N'Per1      ', N'Thêm')
INSERT [dbo].[Permission] ([PermissionID], [PermissionName]) VALUES (N'Per2      ', N'Sửa')
INSERT [dbo].[Permission] ([PermissionID], [PermissionName]) VALUES (N'Per3      ', N'Xóa')
INSERT [dbo].[Permission] ([PermissionID], [PermissionName]) VALUES (N'Per4      ', N'Tìm kiếm')
INSERT [dbo].[Permission] ([PermissionID], [PermissionName]) VALUES (N'Per5      ', N'Import')
INSERT [dbo].[Permission] ([PermissionID], [PermissionName]) VALUES (N'Per6      ', N'Export')
GO
INSERT [dbo].[Role] ([RoleID], [RoleName]) VALUES (N'Role1     ', N'Admin')
INSERT [dbo].[Role] ([RoleID], [RoleName]) VALUES (N'Role2     ', N'Nhân viên')
GO
INSERT [dbo].[Role_Permission] ([RoleID], [PermissionID], [Description]) VALUES (N'Role1     ', N'Per1      ', NULL)
INSERT [dbo].[Role_Permission] ([RoleID], [PermissionID], [Description]) VALUES (N'Role1     ', N'Per2      ', NULL)
INSERT [dbo].[Role_Permission] ([RoleID], [PermissionID], [Description]) VALUES (N'Role1     ', N'Per3      ', NULL)
INSERT [dbo].[Role_Permission] ([RoleID], [PermissionID], [Description]) VALUES (N'Role1     ', N'Per4      ', NULL)
INSERT [dbo].[Role_Permission] ([RoleID], [PermissionID], [Description]) VALUES (N'Role1     ', N'Per5      ', NULL)
INSERT [dbo].[Role_Permission] ([RoleID], [PermissionID], [Description]) VALUES (N'Role1     ', N'Per6      ', NULL)
INSERT [dbo].[Role_Permission] ([RoleID], [PermissionID], [Description]) VALUES (N'Role2     ', N'Per1      ', NULL)
INSERT [dbo].[Role_Permission] ([RoleID], [PermissionID], [Description]) VALUES (N'Role2     ', N'Per4      ', NULL)
GO
INSERT [dbo].[TaiKhoan] ([UserID], [UserName], [Password], [Description], [RoleID]) VALUES (N'User1     ', N'User1', N'7d72c0525f8139cbd149dfb93e07a4c2a5aefe02cb35533a2d5a4a033d35cae3', N'', N'Role1     ')
INSERT [dbo].[TaiKhoan] ([UserID], [UserName], [Password], [Description], [RoleID]) VALUES (N'User2     ', N'User2', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', N'', N'Role2     ')
INSERT [dbo].[TaiKhoan] ([UserID], [UserName], [Password], [Description], [RoleID]) VALUES (N'User3     ', N'User3', N'7d72c0525f8139cbd149dfb93e07a4c2a5aefe02cb35533a2d5a4a033d35cae3', N'', N'Role1     ')
INSERT [dbo].[TaiKhoan] ([UserID], [UserName], [Password], [Description], [RoleID]) VALUES (N'User4     ', N'User4', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', N'', N'Role2     ')
INSERT [dbo].[TaiKhoan] ([UserID], [UserName], [Password], [Description], [RoleID]) VALUES (N'User5     ', N'User5', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', N'', N'Role2     ')
GO
INSERT [dbo].[Thuoc] ([Thuoc_ID], [Thuoc_Name], [Nhom_ID]) VALUES (N'Thuoc1    ', N'Paracetamol', N'Nhom1     ')
INSERT [dbo].[Thuoc] ([Thuoc_ID], [Thuoc_Name], [Nhom_ID]) VALUES (N'Thuoc2    ', N'Ibuprofen', N'Nhom1     ')
INSERT [dbo].[Thuoc] ([Thuoc_ID], [Thuoc_Name], [Nhom_ID]) VALUES (N'Thuoc3    ', N'Naproxen', N'Nhom1     ')
INSERT [dbo].[Thuoc] ([Thuoc_ID], [Thuoc_Name], [Nhom_ID]) VALUES (N'Thuoc4    ', N'Panadol', N'Nhom2     ')
INSERT [dbo].[Thuoc] ([Thuoc_ID], [Thuoc_Name], [Nhom_ID]) VALUES (N'Thuoc5    ', N'Oxaprozin', N'Nhom2     ')
INSERT [dbo].[Thuoc] ([Thuoc_ID], [Thuoc_Name], [Nhom_ID]) VALUES (N'Thuoc6    ', N'Triptans', N'Nhom2     ')
INSERT [dbo].[Thuoc] ([Thuoc_ID], [Thuoc_Name], [Nhom_ID]) VALUES (N'Thuoc7    ', N'Vitamin C 1000', N'Nhom3     ')
INSERT [dbo].[Thuoc] ([Thuoc_ID], [Thuoc_Name], [Nhom_ID]) VALUES (N'Thuoc8    ', N'Xtendlife', N'Nhom3     ')
INSERT [dbo].[Thuoc] ([Thuoc_ID], [Thuoc_Name], [Nhom_ID]) VALUES (N'Thuoc9    ', N'Bronson Vitamin K2', N'Nhom3     ')
GO
ALTER TABLE [dbo].[ChiTietDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonNhap_DonNhap] FOREIGN KEY([DNhap_ID])
REFERENCES [dbo].[DonNhap] ([DNhap_ID])
GO
ALTER TABLE [dbo].[ChiTietDonNhap] CHECK CONSTRAINT [FK_ChiTietDonNhap_DonNhap]
GO
ALTER TABLE [dbo].[ChiTietDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonNhap_Lo] FOREIGN KEY([Lo_ID])
REFERENCES [dbo].[Lo] ([Lo_ID])
GO
ALTER TABLE [dbo].[ChiTietDonNhap] CHECK CONSTRAINT [FK_ChiTietDonNhap_Lo]
GO
ALTER TABLE [dbo].[ChiTietDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonNhap_Thuoc] FOREIGN KEY([Thuoc_ID])
REFERENCES [dbo].[Thuoc] ([Thuoc_ID])
GO
ALTER TABLE [dbo].[ChiTietDonNhap] CHECK CONSTRAINT [FK_ChiTietDonNhap_Thuoc]
GO
ALTER TABLE [dbo].[ChiTietDonXuat]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonXuat_DonXuat] FOREIGN KEY([DXuat_ID])
REFERENCES [dbo].[DonXuat] ([DXuat_ID])
GO
ALTER TABLE [dbo].[ChiTietDonXuat] CHECK CONSTRAINT [FK_ChiTietDonXuat_DonXuat]
GO
ALTER TABLE [dbo].[ChiTietDonXuat]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonXuat_Thuoc] FOREIGN KEY([Thuoc_ID])
REFERENCES [dbo].[Thuoc] ([Thuoc_ID])
GO
ALTER TABLE [dbo].[ChiTietDonXuat] CHECK CONSTRAINT [FK_ChiTietDonXuat_Thuoc]
GO
ALTER TABLE [dbo].[ChiTietThuoc]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietThuoc_Lo] FOREIGN KEY([Lo_ID])
REFERENCES [dbo].[Lo] ([Lo_ID])
GO
ALTER TABLE [dbo].[ChiTietThuoc] CHECK CONSTRAINT [FK_ChiTietThuoc_Lo]
GO
ALTER TABLE [dbo].[ChiTietThuoc]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietThuoc_Thuoc] FOREIGN KEY([Thuoc_ID])
REFERENCES [dbo].[Thuoc] ([Thuoc_ID])
GO
ALTER TABLE [dbo].[ChiTietThuoc] CHECK CONSTRAINT [FK_ChiTietThuoc_Thuoc]
GO
ALTER TABLE [dbo].[DonNhap]  WITH CHECK ADD  CONSTRAINT [FK_DonNhap_NCC] FOREIGN KEY([NCC_ID])
REFERENCES [dbo].[NCC] ([NCC_ID])
GO
ALTER TABLE [dbo].[DonNhap] CHECK CONSTRAINT [FK_DonNhap_NCC]
GO
ALTER TABLE [dbo].[DonNhap]  WITH CHECK ADD  CONSTRAINT [FK_DonNhap_NhanVien] FOREIGN KEY([NV_ID])
REFERENCES [dbo].[NhanVien] ([NV_ID])
GO
ALTER TABLE [dbo].[DonNhap] CHECK CONSTRAINT [FK_DonNhap_NhanVien]
GO
ALTER TABLE [dbo].[DonXuat]  WITH CHECK ADD  CONSTRAINT [FK_DonXuat_NhanVien] FOREIGN KEY([NV_ID])
REFERENCES [dbo].[NhanVien] ([NV_ID])
GO
ALTER TABLE [dbo].[DonXuat] CHECK CONSTRAINT [FK_DonXuat_NhanVien]
GO
ALTER TABLE [dbo].[Kho]  WITH CHECK ADD  CONSTRAINT [FK_Kho_ChiNhanh] FOREIGN KEY([CN_ID])
REFERENCES [dbo].[ChiNhanh] ([CN_ID])
GO
ALTER TABLE [dbo].[Kho] CHECK CONSTRAINT [FK_Kho_ChiNhanh]
GO
ALTER TABLE [dbo].[Lo]  WITH CHECK ADD  CONSTRAINT [FK_Lo_Kho] FOREIGN KEY([Kho_ID])
REFERENCES [dbo].[Kho] ([Kho_ID])
GO
ALTER TABLE [dbo].[Lo] CHECK CONSTRAINT [FK_Lo_Kho]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChiNhanh1] FOREIGN KEY([CN_ID])
REFERENCES [dbo].[ChiNhanh] ([CN_ID])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ChiNhanh1]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_TaiKhoan] FOREIGN KEY([UserID])
REFERENCES [dbo].[TaiKhoan] ([UserID])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_TaiKhoan]
GO
ALTER TABLE [dbo].[Role_Permission]  WITH CHECK ADD  CONSTRAINT [FK_Role_Permission_Permission1] FOREIGN KEY([PermissionID])
REFERENCES [dbo].[Permission] ([PermissionID])
GO
ALTER TABLE [dbo].[Role_Permission] CHECK CONSTRAINT [FK_Role_Permission_Permission1]
GO
ALTER TABLE [dbo].[Role_Permission]  WITH CHECK ADD  CONSTRAINT [FK_Role_Permission_Role1] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([RoleID])
GO
ALTER TABLE [dbo].[Role_Permission] CHECK CONSTRAINT [FK_Role_Permission_Role1]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_User_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([RoleID])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_User_Role]
GO
ALTER TABLE [dbo].[Thuoc]  WITH CHECK ADD  CONSTRAINT [FK_Thuoc_NhomThuoc] FOREIGN KEY([Nhom_ID])
REFERENCES [dbo].[NhomThuoc] ([Nhom_ID])
GO
ALTER TABLE [dbo].[Thuoc] CHECK CONSTRAINT [FK_Thuoc_NhomThuoc]
GO
USE [master]
GO
ALTER DATABASE [QLKH_Thuoc] SET  READ_WRITE 
GO
