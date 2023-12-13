INSERT [dbo].[ChiNhanh] ([CN_ID], [CN_Name], [CN_Address]) VALUES (N'CN1', N'Branch 1', N'Address 1')
INSERT [dbo].[ChiNhanh] ([CN_ID], [CN_Name], [CN_Address]) VALUES (N'CN2', N'Branch 2', N'Address 2')
GO
INSERT [dbo].[ChiTietDonNhap] ([Lo_ID], [DNhap_ID], [Description]) VALUES (N'Lo1', N'DN1', N'Description 1')
INSERT [dbo].[ChiTietDonNhap] ([Lo_ID], [DNhap_ID], [Description]) VALUES (N'Lo2', N'DN2', N'Description 2')
GO
INSERT [dbo].[ChiTietDonXuat] ([Thuoc_ID], [DXuat_ID], [Description], [Quantity]) VALUES (N'Thuoc1', N'DX1', N'Description 1', 10)
INSERT [dbo].[ChiTietDonXuat] ([Thuoc_ID], [DXuat_ID], [Description], [Quantity]) VALUES (N'Thuoc2', N'DX2', N'Description 2', 20)
GO
INSERT [dbo].[ChiTietThuoc] ([Thuoc_ID], [Lo_ID], [Description], [Quantity]) VALUES (N'Thuoc1', N'Lo1', N'Description 1', 50)
INSERT [dbo].[ChiTietThuoc] ([Thuoc_ID], [Lo_ID], [Description], [Quantity]) VALUES (N'Thuoc2', N'Lo2', N'Description 2', 30)
GO
INSERT [dbo].[DonNhap] ([DNhap_ID], [NCC_ID], [Thuoc_ID], [DN_Datetime], [DN_Name], [NV_ID]) VALUES (N'DN1', N'NCC1', N'Thuoc1', CAST(N'2023-12-07T14:00:00.000' AS DateTime), N'DonNhap 1', N'NV1')
INSERT [dbo].[DonNhap] ([DNhap_ID], [NCC_ID], [Thuoc_ID], [DN_Datetime], [DN_Name], [NV_ID]) VALUES (N'DN2', N'NCC2', N'Thuoc2', CAST(N'2023-12-07T15:00:00.000' AS DateTime), N'DonNhap 2', N'NV2')
GO
INSERT [dbo].[DonXuat] ([DXuat_ID], [DX_Name], [DX_Datetime], [NV_ID]) VALUES (N'DX1', N'DonXuat 1', CAST(N'2023-12-07T16:00:00.000' AS DateTime), N'NV1')
INSERT [dbo].[DonXuat] ([DXuat_ID], [DX_Name], [DX_Datetime], [NV_ID]) VALUES (N'DX2', N'DonXuat 2', CAST(N'2023-12-07T17:00:00.000' AS DateTime), N'NV2')
GO
INSERT [dbo].[Kho] ([Kho_ID], [Kho_Name], [Kho_Address], [CN_ID]) VALUES (N'Kho1', N'Warehouse 1', N'Warehouse Address 1', N'CN1')
INSERT [dbo].[Kho] ([Kho_ID], [Kho_Name], [Kho_Address], [CN_ID]) VALUES (N'Kho2', N'Warehouse 2', N'Warehouse Address 2', N'CN2')
GO
INSERT [dbo].[Lo] ([Lo_ID], [Lo_Name], [Lo_Position], [Kho_ID]) VALUES (N'Lo1', N'Position 1', N'Position Address 1', N'Kho1')
INSERT [dbo].[Lo] ([Lo_ID], [Lo_Name], [Lo_Position], [Kho_ID]) VALUES (N'Lo2', N'Position 2', N'Position Address 2', N'Kho2')
GO
INSERT [dbo].[NCC] ([NCC_ID], [NCC_Name], [NCC_Address], [NCC_Phone], [Quantity]) VALUES (N'NCC1', N'Supplier 1', N'Supplier Address 1', 123456789, N'Quantity1')
INSERT [dbo].[NCC] ([NCC_ID], [NCC_Name], [NCC_Address], [NCC_Phone], [Quantity]) VALUES (N'NCC2', N'Supplier 2', N'Supplier Address 2', 987654321, N'Quantity2')
GO
INSERT [dbo].[NhanVien] ([NV_ID], [NV_Name], [BirthDay], [Sex], [Phone], [Address], [Email], [CN_ID], [UserID]) VALUES (N'NV1', N'Employee 1', CAST(N'1990-01-01T00:00:00.000' AS DateTime), N'Male', 111111111, N'Employee Address 1', N'employee1@email.com', N'CN1', N'User1')
INSERT [dbo].[NhanVien] ([NV_ID], [NV_Name], [BirthDay], [Sex], [Phone], [Address], [Email], [CN_ID], [UserID]) VALUES (N'NV2', N'Employee 2', CAST(N'1995-02-02T00:00:00.000' AS DateTime), N'Female', 222222222, N'Employee Address 2', N'employee2@email.com', N'CN2', N'User2')
GO
INSERT [dbo].[NhomThuoc] ([Nhom_ID], [Nhom_Name], [Description]) VALUES (N'Nhom1', N'Group 1', N'Group Description 1')
INSERT [dbo].[NhomThuoc] ([Nhom_ID], [Nhom_Name], [Description]) VALUES (N'Nhom2', N'Group 2', N'Group Description 2')
GO
INSERT [dbo].[Permission] ([PermissionID], [PermissionName]) VALUES (N'Per1', N'Permission 1')
INSERT [dbo].[Permission] ([PermissionID], [PermissionName]) VALUES (N'Per2', N'Permission 2')
GO
INSERT [dbo].[Role] ([RoleID], [RoleName]) VALUES (N'Role1', N'Role 1')
INSERT [dbo].[Role] ([RoleID], [RoleName]) VALUES (N'Role2', N'Role 2')
GO
INSERT [dbo].[Role_Permission] ([RoleID], [PermissionID]) VALUES (N'Role1', N'Per1')
INSERT [dbo].[Role_Permission] ([RoleID], [PermissionID]) VALUES (N'Role2', N'Per2')
GO
INSERT [dbo].[TaiKhoan] ([UserID], [UserName], [Password], [Description], [RoleID]) VALUES (N'User1', N'User 1', N'Pass1', N'User Description 1', N'Role1')
INSERT [dbo].[TaiKhoan] ([UserID], [UserName], [Password], [Description], [RoleID]) VALUES (N'User2', N'User 2', N'Pass2', N'User Description 2', N'Role2')
GO
INSERT [dbo].[Thuoc] ([Thuoc_ID], [Thuoc_Name], [Nhom_ID]) VALUES (N'Thuoc1', N'Medicine 1', N'Nhom1')
INSERT [dbo].[Thuoc] ([Thuoc_ID], [Thuoc_Name], [Nhom_ID]) VALUES (N'Thuoc2', N'Medicine 2', N'Nhom2')
GO