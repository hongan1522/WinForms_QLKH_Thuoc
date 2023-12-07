USE [master]
GO
/****** Object:  Database [QLKH_Thuoc]    Script Date: 12/7/2023 3:05:33 PM ******/
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
/****** Object:  Table [dbo].[ChiNhanh]    Script Date: 12/7/2023 3:05:33 PM ******/
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
/****** Object:  Table [dbo].[ChiTietDonNhap]    Script Date: 12/7/2023 3:05:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDonNhap](
	[Lo_ID] [nchar](10) NOT NULL,
	[DNhap_ID] [nchar](10) NOT NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_ChiTietDonNhap] PRIMARY KEY CLUSTERED 
(
	[Lo_ID] ASC,
	[DNhap_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietDonXuat]    Script Date: 12/7/2023 3:05:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDonXuat](
	[Thuoc_ID] [nchar](10) NOT NULL,
	[DXuat_ID] [nchar](10) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_ChiTietDonXuat] PRIMARY KEY CLUSTERED 
(
	[Thuoc_ID] ASC,
	[DXuat_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietThuoc]    Script Date: 12/7/2023 3:05:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietThuoc](
	[Thuoc_ID] [nchar](10) NOT NULL,
	[Lo_ID] [nchar](10) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_ChiTietThuoc] PRIMARY KEY CLUSTERED 
(
	[Thuoc_ID] ASC,
	[Lo_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonNhap]    Script Date: 12/7/2023 3:05:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonNhap](
	[DNhap_ID] [nchar](10) NOT NULL,
	[NCC_ID] [nchar](10) NOT NULL,
	[Thuoc_ID] [nchar](10) NOT NULL,
	[DN_Datetime] [datetime] NOT NULL,
	[DN_Name] [nvarchar](50) NULL,
	[NV_ID] [nchar](10) NULL,
 CONSTRAINT [PK_DonNhap] PRIMARY KEY CLUSTERED 
(
	[DNhap_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonXuat]    Script Date: 12/7/2023 3:05:33 PM ******/
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
/****** Object:  Table [dbo].[Kho]    Script Date: 12/7/2023 3:05:33 PM ******/
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
/****** Object:  Table [dbo].[Lo]    Script Date: 12/7/2023 3:05:33 PM ******/
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
/****** Object:  Table [dbo].[NCC]    Script Date: 12/7/2023 3:05:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NCC](
	[NCC_ID] [nchar](10) NOT NULL,
	[NCC_Name] [nvarchar](50) NULL,
	[NCC_Address] [nvarchar](50) NULL,
	[NCC_Phone] [int] NULL,
	[Quantity] [nchar](10) NOT NULL,
 CONSTRAINT [PK_NCC] PRIMARY KEY CLUSTERED 
(
	[NCC_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/7/2023 3:05:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[NV_ID] [nchar](10) NOT NULL,
	[NV_Name] [nvarchar](50) NULL,
	[BirthDay] [datetime] NULL,
	[Sex] [nchar](10) NULL,
	[Phone] [int] NULL,
	[Address] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[CN_ID] [nchar](10) NOT NULL,
	[UserID] [nchar](10) NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[NV_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhomThuoc]    Script Date: 12/7/2023 3:05:33 PM ******/
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
/****** Object:  Table [dbo].[Permission]    Script Date: 12/7/2023 3:05:33 PM ******/
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
/****** Object:  Table [dbo].[Role]    Script Date: 12/7/2023 3:05:33 PM ******/
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
/****** Object:  Table [dbo].[Role_Permission]    Script Date: 12/7/2023 3:05:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role_Permission](
	[RoleID] [nchar](10) NOT NULL,
	[PermissionID] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Role_Permission] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC,
	[PermissionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 12/7/2023 3:05:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[UserID] [nchar](10) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[Password] [nvarchar](10) NULL,
	[Description] [nvarchar](max) NULL,
	[RoleID] [nchar](10) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Thuoc]    Script Date: 12/7/2023 3:05:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Thuoc](
	[Thuoc_ID] [nchar](10) NOT NULL,
	[Thuoc_Name] [nvarchar](50) NULL,
	[Nhom_ID] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Thuoc] PRIMARY KEY CLUSTERED 
(
	[Thuoc_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiNhanh] ([CN_ID], [CN_Name], [CN_Address]) VALUES (N'CN1       ', N'Branch 1', N'Address 1')
INSERT [dbo].[ChiNhanh] ([CN_ID], [CN_Name], [CN_Address]) VALUES (N'CN2       ', N'Branch 2', N'Address 2')
GO
INSERT [dbo].[ChiTietDonNhap] ([Lo_ID], [DNhap_ID], [Description]) VALUES (N'Lo1       ', N'DN1       ', N'Description 1')
INSERT [dbo].[ChiTietDonNhap] ([Lo_ID], [DNhap_ID], [Description]) VALUES (N'Lo2       ', N'DN2       ', N'Description 2')
GO
INSERT [dbo].[ChiTietDonXuat] ([Thuoc_ID], [DXuat_ID], [Description], [Quantity]) VALUES (N'Thuoc1    ', N'DX1       ', N'Description 1', 10)
INSERT [dbo].[ChiTietDonXuat] ([Thuoc_ID], [DXuat_ID], [Description], [Quantity]) VALUES (N'Thuoc2    ', N'DX2       ', N'Description 2', 20)
GO
INSERT [dbo].[ChiTietThuoc] ([Thuoc_ID], [Lo_ID], [Description], [Quantity]) VALUES (N'Thuoc1    ', N'Lo1       ', N'Description 1', 50)
INSERT [dbo].[ChiTietThuoc] ([Thuoc_ID], [Lo_ID], [Description], [Quantity]) VALUES (N'Thuoc2    ', N'Lo2       ', N'Description 2', 30)
GO
INSERT [dbo].[DonNhap] ([DNhap_ID], [NCC_ID], [Thuoc_ID], [DN_Datetime], [DN_Name], [NV_ID]) VALUES (N'DN1       ', N'NCC1      ', N'Thuoc1    ', CAST(N'2023-12-07T14:00:00.000' AS DateTime), N'DonNhap 1', N'NV1       ')
INSERT [dbo].[DonNhap] ([DNhap_ID], [NCC_ID], [Thuoc_ID], [DN_Datetime], [DN_Name], [NV_ID]) VALUES (N'DN2       ', N'NCC2      ', N'Thuoc2    ', CAST(N'2023-12-07T15:00:00.000' AS DateTime), N'DonNhap 2', N'NV2       ')
GO
INSERT [dbo].[DonXuat] ([DXuat_ID], [DX_Name], [DX_Datetime], [NV_ID]) VALUES (N'DX1       ', N'DonXuat 1', CAST(N'2023-12-07T16:00:00.000' AS DateTime), N'NV1       ')
INSERT [dbo].[DonXuat] ([DXuat_ID], [DX_Name], [DX_Datetime], [NV_ID]) VALUES (N'DX2       ', N'DonXuat 2', CAST(N'2023-12-07T17:00:00.000' AS DateTime), N'NV2       ')
GO
INSERT [dbo].[Kho] ([Kho_ID], [Kho_Name], [Kho_Address], [CN_ID]) VALUES (N'Kho1      ', N'Warehouse 1', N'Warehouse Address 1', N'CN1       ')
INSERT [dbo].[Kho] ([Kho_ID], [Kho_Name], [Kho_Address], [CN_ID]) VALUES (N'Kho2      ', N'Warehouse 2', N'Warehouse Address 2', N'CN2       ')
GO
INSERT [dbo].[Lo] ([Lo_ID], [Lo_Name], [Lo_Position], [Kho_ID]) VALUES (N'Lo1       ', N'Position 1', N'Position Address 1', N'Kho1      ')
INSERT [dbo].[Lo] ([Lo_ID], [Lo_Name], [Lo_Position], [Kho_ID]) VALUES (N'Lo2       ', N'Position 2', N'Position Address 2', N'Kho2      ')
GO
INSERT [dbo].[NCC] ([NCC_ID], [NCC_Name], [NCC_Address], [NCC_Phone], [Quantity]) VALUES (N'NCC1      ', N'Supplier 1', N'Supplier Address 1', 123456789, N'Quantity1 ')
INSERT [dbo].[NCC] ([NCC_ID], [NCC_Name], [NCC_Address], [NCC_Phone], [Quantity]) VALUES (N'NCC2      ', N'Supplier 2', N'Supplier Address 2', 987654321, N'Quantity2 ')
GO
INSERT [dbo].[NhanVien] ([NV_ID], [NV_Name], [BirthDay], [Sex], [Phone], [Address], [Email], [CN_ID], [UserID]) VALUES (N'NV1       ', N'Employee 1', CAST(N'1990-01-01T00:00:00.000' AS DateTime), N'Male      ', 111111111, N'Employee Address 1', N'employee1@email.com', N'CN1       ', N'User1     ')
INSERT [dbo].[NhanVien] ([NV_ID], [NV_Name], [BirthDay], [Sex], [Phone], [Address], [Email], [CN_ID], [UserID]) VALUES (N'NV2       ', N'Employee 2', CAST(N'1995-02-02T00:00:00.000' AS DateTime), N'Female    ', 222222222, N'Employee Address 2', N'employee2@email.com', N'CN2       ', N'User2     ')
GO
INSERT [dbo].[NhomThuoc] ([Nhom_ID], [Nhom_Name], [Description]) VALUES (N'Nhom1     ', N'Group 1', N'Group Description 1')
INSERT [dbo].[NhomThuoc] ([Nhom_ID], [Nhom_Name], [Description]) VALUES (N'Nhom2     ', N'Group 2', N'Group Description 2')
GO
INSERT [dbo].[Permission] ([PermissionID], [PermissionName]) VALUES (N'Per1      ', N'Permission 1')
INSERT [dbo].[Permission] ([PermissionID], [PermissionName]) VALUES (N'Per2      ', N'Permission 2')
GO
INSERT [dbo].[Role] ([RoleID], [RoleName]) VALUES (N'Role1     ', N'Role 1')
INSERT [dbo].[Role] ([RoleID], [RoleName]) VALUES (N'Role2     ', N'Role 2')
GO
INSERT [dbo].[Role_Permission] ([RoleID], [PermissionID]) VALUES (N'Role1     ', N'Per1      ')
INSERT [dbo].[Role_Permission] ([RoleID], [PermissionID]) VALUES (N'Role2     ', N'Per2      ')
GO
INSERT [dbo].[TaiKhoan] ([UserID], [UserName], [Password], [Description], [RoleID]) VALUES (N'User1     ', N'User 1', N'Pass1', N'User Description 1', N'Role1     ')
INSERT [dbo].[TaiKhoan] ([UserID], [UserName], [Password], [Description], [RoleID]) VALUES (N'User2     ', N'User 2', N'Pass2', N'User Description 2', N'Role2     ')
GO
INSERT [dbo].[Thuoc] ([Thuoc_ID], [Thuoc_Name], [Nhom_ID]) VALUES (N'Thuoc1    ', N'Medicine 1', N'Nhom1     ')
INSERT [dbo].[Thuoc] ([Thuoc_ID], [Thuoc_Name], [Nhom_ID]) VALUES (N'Thuoc2    ', N'Medicine 2', N'Nhom2     ')
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
ALTER TABLE [dbo].[DonNhap]  WITH CHECK ADD  CONSTRAINT [FK_DonNhap_Thuoc1] FOREIGN KEY([Thuoc_ID])
REFERENCES [dbo].[Thuoc] ([Thuoc_ID])
GO
ALTER TABLE [dbo].[DonNhap] CHECK CONSTRAINT [FK_DonNhap_Thuoc1]
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
ALTER TABLE [dbo].[Role_Permission]  WITH CHECK ADD  CONSTRAINT [FK_Role_Permission_Permission] FOREIGN KEY([PermissionID])
REFERENCES [dbo].[Permission] ([PermissionID])
GO
ALTER TABLE [dbo].[Role_Permission] CHECK CONSTRAINT [FK_Role_Permission_Permission]
GO
ALTER TABLE [dbo].[Role_Permission]  WITH CHECK ADD  CONSTRAINT [FK_Role_Permission_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([RoleID])
GO
ALTER TABLE [dbo].[Role_Permission] CHECK CONSTRAINT [FK_Role_Permission_Role]
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
