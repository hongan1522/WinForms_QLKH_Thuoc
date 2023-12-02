USE [QLKH_Thuoc]
GO
/****** Object:  Table [dbo].[ChiNhanh]    Script Date: 11/23/2023 5:09:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiNhanh](
	[CN_ID] [nchar](10) NOT NULL,
	[CN_Name] [nvarchar](50) NULL,
	[CN_Address] [nvarchar](50) NULL,
	[NV_ID] [nchar](10) NOT NULL,
 CONSTRAINT [PK_ChiNhanh] PRIMARY KEY CLUSTERED 
(
	[CN_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietDonNhap]    Script Date: 11/23/2023 5:09:11 PM ******/
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
/****** Object:  Table [dbo].[ChiTietDonXuat]    Script Date: 11/23/2023 5:09:11 PM ******/
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
/****** Object:  Table [dbo].[ChiTietLo]    Script Date: 11/23/2023 5:09:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietLo](
	[Kho_ID] [nchar](10) NOT NULL,
	[Lo_ID] [nchar](10) NOT NULL,
 CONSTRAINT [PK_ChiTietLo] PRIMARY KEY CLUSTERED 
(
	[Kho_ID] ASC,
	[Lo_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietThuoc]    Script Date: 11/23/2023 5:09:11 PM ******/
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
/****** Object:  Table [dbo].[DonNhap]    Script Date: 11/23/2023 5:09:11 PM ******/
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
/****** Object:  Table [dbo].[DonXuat]    Script Date: 11/23/2023 5:09:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonXuat](
	[DXuat_ID] [nchar](10) NOT NULL,
	[DX_Name] [nvarchar](50) NULL,
	[DX_Datetime] [datetime] NOT NULL,
 CONSTRAINT [PK_DonXuat] PRIMARY KEY CLUSTERED 
(
	[DXuat_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kho]    Script Date: 11/23/2023 5:09:11 PM ******/
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
/****** Object:  Table [dbo].[Lo]    Script Date: 11/23/2023 5:09:11 PM ******/
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
/****** Object:  Table [dbo].[NCC]    Script Date: 11/23/2023 5:09:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NCC](
	[NCC_ID] [nchar](10) NOT NULL,
	[NCC_Name] [nvarchar](50) NULL,
	[NCC_Address] [nvarchar](50) NULL,
	[NCC_Phone] [int] NULL,
 CONSTRAINT [PK_NCC] PRIMARY KEY CLUSTERED 
(
	[NCC_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/23/2023 5:09:11 PM ******/
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
/****** Object:  Table [dbo].[NhomThuoc]    Script Date: 11/23/2023 5:09:11 PM ******/
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
/****** Object:  Table [dbo].[Permission]    Script Date: 11/23/2023 5:09:11 PM ******/
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
/****** Object:  Table [dbo].[Role]    Script Date: 11/23/2023 5:09:11 PM ******/
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
/****** Object:  Table [dbo].[Role_Permission]    Script Date: 11/23/2023 5:09:11 PM ******/
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
/****** Object:  Table [dbo].[Thuoc]    Script Date: 11/23/2023 5:09:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Thuoc](
	[Thuoc_ID] [nchar](10) NOT NULL,
	[Thuoc_Name] [nvarchar](50) NULL,
	[DNhap_ID] [nchar](10) NOT NULL,
	[Nhom_ID] [nchar](10) NULL,
 CONSTRAINT [PK_Thuoc] PRIMARY KEY CLUSTERED 
(
	[Thuoc_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 11/23/2023 5:09:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserID] [nchar](10) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[Password] [nvarchar](10) NULL,
	[Image] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[NV_ID] [nchar](10) NOT NULL,
	[RoleID] [nchar](10) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChiNhanh]  WITH CHECK ADD  CONSTRAINT [FK_ChiNhanh_NhanVien] FOREIGN KEY([NV_ID])
REFERENCES [dbo].[NhanVien] ([NV_ID])
GO
ALTER TABLE [dbo].[ChiNhanh] CHECK CONSTRAINT [FK_ChiNhanh_NhanVien]
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
ALTER TABLE [dbo].[ChiTietLo]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietLo_Kho] FOREIGN KEY([Kho_ID])
REFERENCES [dbo].[Kho] ([Kho_ID])
GO
ALTER TABLE [dbo].[ChiTietLo] CHECK CONSTRAINT [FK_ChiTietLo_Kho]
GO
ALTER TABLE [dbo].[ChiTietLo]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietLo_Lo] FOREIGN KEY([Kho_ID])
REFERENCES [dbo].[Lo] ([Lo_ID])
GO
ALTER TABLE [dbo].[ChiTietLo] CHECK CONSTRAINT [FK_ChiTietLo_Lo]
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
ALTER TABLE [dbo].[DonNhap]  WITH CHECK ADD  CONSTRAINT [FK_DonNhap_Thuoc] FOREIGN KEY([Thuoc_ID])
REFERENCES [dbo].[Thuoc] ([Thuoc_ID])
GO
ALTER TABLE [dbo].[DonNhap] CHECK CONSTRAINT [FK_DonNhap_Thuoc]
GO
ALTER TABLE [dbo].[Kho]  WITH CHECK ADD  CONSTRAINT [FK_Kho_ChiNhanh] FOREIGN KEY([CN_ID])
REFERENCES [dbo].[ChiNhanh] ([CN_ID])
GO
ALTER TABLE [dbo].[Kho] CHECK CONSTRAINT [FK_Kho_ChiNhanh]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChiNhanh] FOREIGN KEY([CN_ID])
REFERENCES [dbo].[ChiNhanh] ([CN_ID])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ChiNhanh]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_User]
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
ALTER TABLE [dbo].[Thuoc]  WITH CHECK ADD  CONSTRAINT [FK_Thuoc_DonNhap] FOREIGN KEY([DNhap_ID])
REFERENCES [dbo].[DonNhap] ([DNhap_ID])
GO
ALTER TABLE [dbo].[Thuoc] CHECK CONSTRAINT [FK_Thuoc_DonNhap]
GO
ALTER TABLE [dbo].[Thuoc]  WITH CHECK ADD  CONSTRAINT [FK_Thuoc_NhomThuoc] FOREIGN KEY([Nhom_ID])
REFERENCES [dbo].[NhomThuoc] ([Nhom_ID])
GO
ALTER TABLE [dbo].[Thuoc] CHECK CONSTRAINT [FK_Thuoc_NhomThuoc]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_NhanVien] FOREIGN KEY([NV_ID])
REFERENCES [dbo].[NhanVien] ([NV_ID])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_NhanVien]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([RoleID])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Role]
GO
