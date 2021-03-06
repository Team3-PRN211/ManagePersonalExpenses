USE [master]
GO
/****** Object:  Database [ManagePersonalExpenses]    Script Date: 13/07/2022 11:44:18 SA ******/
CREATE DATABASE [ManagePersonalExpenses]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ManagePersonalExpenses', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.TRINHNX151\MSSQL\DATA\ManagePersonalExpenses.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ManagePersonalExpenses_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.TRINHNX151\MSSQL\DATA\ManagePersonalExpenses_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ManagePersonalExpenses] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ManagePersonalExpenses].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ManagePersonalExpenses] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ManagePersonalExpenses] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ManagePersonalExpenses] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ManagePersonalExpenses] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ManagePersonalExpenses] SET ARITHABORT OFF 
GO
ALTER DATABASE [ManagePersonalExpenses] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ManagePersonalExpenses] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ManagePersonalExpenses] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ManagePersonalExpenses] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ManagePersonalExpenses] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ManagePersonalExpenses] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ManagePersonalExpenses] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ManagePersonalExpenses] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ManagePersonalExpenses] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ManagePersonalExpenses] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ManagePersonalExpenses] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ManagePersonalExpenses] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ManagePersonalExpenses] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ManagePersonalExpenses] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ManagePersonalExpenses] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ManagePersonalExpenses] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ManagePersonalExpenses] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ManagePersonalExpenses] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ManagePersonalExpenses] SET  MULTI_USER 
GO
ALTER DATABASE [ManagePersonalExpenses] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ManagePersonalExpenses] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ManagePersonalExpenses] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ManagePersonalExpenses] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ManagePersonalExpenses] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ManagePersonalExpenses] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ManagePersonalExpenses] SET QUERY_STORE = OFF
GO
USE [ManagePersonalExpenses]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 13/07/2022 11:44:18 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[category_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[description] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[category_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Record]    Script Date: 13/07/2022 11:44:18 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Record](
	[record_id] [int] IDENTITY(1,1) NOT NULL,
	[money] [money] NOT NULL,
	[date] [datetime] NOT NULL,
	[description] [nvarchar](max) NULL,
	[user_id] [int] NOT NULL,
	[type_id] [int] NOT NULL,
	[subCategory_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[record_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubCategory]    Script Date: 13/07/2022 11:44:18 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubCategory](
	[subCategory_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[description] [nvarchar](max) NULL,
	[category_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[subCategory_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Type]    Script Date: 13/07/2022 11:44:18 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Type](
	[type_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](10) NOT NULL,
	[description] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[type_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 13/07/2022 11:44:18 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[fullname] [nvarchar](50) NOT NULL,
	[account] [varchar](20) NOT NULL,
	[password] [varchar](max) NOT NULL,
	[gender] [bit] NOT NULL,
 CONSTRAINT [PK__User__B9BE370FDCD017DC] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([category_id], [name], [description]) VALUES (1, N'Ăn uống', N'Ăn uống')
INSERT [dbo].[Category] ([category_id], [name], [description]) VALUES (2, N'Dịch vụ Sinh Hoạt', N'Dịch vụ Sinh Hoạt')
INSERT [dbo].[Category] ([category_id], [name], [description]) VALUES (3, N'Đi Lại', N'Đi Lại')
INSERT [dbo].[Category] ([category_id], [name], [description]) VALUES (4, N'Trang Phục', N'Trang Phục')
INSERT [dbo].[Category] ([category_id], [name], [description]) VALUES (5, N'Hưởng Thụ', N'Hưởng Thụ')
INSERT [dbo].[Category] ([category_id], [name], [description]) VALUES (6, N'Hiếu Hỉ', N'Hiếu Hỉ')
INSERT [dbo].[Category] ([category_id], [name], [description]) VALUES (7, N'Con cái', N'Con cái')
INSERT [dbo].[Category] ([category_id], [name], [description]) VALUES (8, N'Nhà cửa', N'Nhà cửa')
INSERT [dbo].[Category] ([category_id], [name], [description]) VALUES (9, N'Sức Khỏe', N'Sức Khỏe')
INSERT [dbo].[Category] ([category_id], [name], [description]) VALUES (10, N'Phát Triển Bản Thân', N'Phát Triển Bản Thân')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Record] ON 

INSERT [dbo].[Record] ([record_id], [money], [date], [description], [user_id], [type_id], [subCategory_id]) VALUES (14, 50.0000, CAST(N'2022-07-07T17:06:16.927' AS DateTime), N'', 2, 2, 5)
INSERT [dbo].[Record] ([record_id], [money], [date], [description], [user_id], [type_id], [subCategory_id]) VALUES (15, 40.0000, CAST(N'2022-07-07T17:07:05.277' AS DateTime), N'', 2, 2, 3)
INSERT [dbo].[Record] ([record_id], [money], [date], [description], [user_id], [type_id], [subCategory_id]) VALUES (19, 100.0000, CAST(N'2022-07-11T23:31:27.080' AS DateTime), N'mua bột giăt,dầu gội', 2, 2, 1)
INSERT [dbo].[Record] ([record_id], [money], [date], [description], [user_id], [type_id], [subCategory_id]) VALUES (20, 3.0000, CAST(N'2022-07-12T16:19:01.617' AS DateTime), N'Cơm hộp', 2, 2, 1)
INSERT [dbo].[Record] ([record_id], [money], [date], [description], [user_id], [type_id], [subCategory_id]) VALUES (21, 20.0000, CAST(N'2022-07-12T16:21:16.853' AS DateTime), N'', 2, 2, 14)
INSERT [dbo].[Record] ([record_id], [money], [date], [description], [user_id], [type_id], [subCategory_id]) VALUES (22, 30.0000, CAST(N'2022-07-12T16:21:48.923' AS DateTime), N'Mua kẹo', 2, 2, 1)
INSERT [dbo].[Record] ([record_id], [money], [date], [description], [user_id], [type_id], [subCategory_id]) VALUES (23, 17.0000, CAST(N'2022-07-12T16:22:10.073' AS DateTime), N'Mua kem đánh răng', 2, 2, 1)
INSERT [dbo].[Record] ([record_id], [money], [date], [description], [user_id], [type_id], [subCategory_id]) VALUES (24, 20.0000, CAST(N'2022-07-12T16:22:34.977' AS DateTime), N'', 2, 1, 9)
INSERT [dbo].[Record] ([record_id], [money], [date], [description], [user_id], [type_id], [subCategory_id]) VALUES (25, 30.0000, CAST(N'2022-07-12T16:22:50.190' AS DateTime), N'', 2, 2, 7)
INSERT [dbo].[Record] ([record_id], [money], [date], [description], [user_id], [type_id], [subCategory_id]) VALUES (26, 15.0000, CAST(N'2022-07-06T23:09:10.000' AS DateTime), N'', 2, 1, 4)
INSERT [dbo].[Record] ([record_id], [money], [date], [description], [user_id], [type_id], [subCategory_id]) VALUES (27, 80.0000, CAST(N'2022-07-07T23:09:33.000' AS DateTime), N'Mua thuốc cúm', 2, 2, 39)
INSERT [dbo].[Record] ([record_id], [money], [date], [description], [user_id], [type_id], [subCategory_id]) VALUES (28, 150.0000, CAST(N'2022-07-05T23:11:21.000' AS DateTime), N'Đi với người yêu', 2, 1, 24)
INSERT [dbo].[Record] ([record_id], [money], [date], [description], [user_id], [type_id], [subCategory_id]) VALUES (29, 10.0000, CAST(N'2022-06-12T23:12:46.000' AS DateTime), N'', 2, 2, 29)
INSERT [dbo].[Record] ([record_id], [money], [date], [description], [user_id], [type_id], [subCategory_id]) VALUES (30, 50.0000, CAST(N'2022-07-13T11:29:50.830' AS DateTime), N'Mua mì tôm vs nước , giấy', 2, 2, 1)
SET IDENTITY_INSERT [dbo].[Record] OFF
GO
SET IDENTITY_INSERT [dbo].[SubCategory] ON 

INSERT [dbo].[SubCategory] ([subCategory_id], [name], [description], [category_id]) VALUES (1, N'Đi Chợ/Siêu Thị', N'Đi Chợ/Siêu Thị', 1)
INSERT [dbo].[SubCategory] ([subCategory_id], [name], [description], [category_id]) VALUES (2, N'Ăn Sáng', N'Ăn Sáng', 1)
INSERT [dbo].[SubCategory] ([subCategory_id], [name], [description], [category_id]) VALUES (3, N'Ăn Trưa', N'Ăn Trưa', 1)
INSERT [dbo].[SubCategory] ([subCategory_id], [name], [description], [category_id]) VALUES (4, N'Ăn Tối', N'Ăn Tối', 1)
INSERT [dbo].[SubCategory] ([subCategory_id], [name], [description], [category_id]) VALUES (5, N'Cafe', N'Cafe', 1)
INSERT [dbo].[SubCategory] ([subCategory_id], [name], [description], [category_id]) VALUES (6, N'Ăn Tiệm', N'Ăn Tiệm', 1)
INSERT [dbo].[SubCategory] ([subCategory_id], [name], [description], [category_id]) VALUES (7, N'Internet', N'Internet', 2)
INSERT [dbo].[SubCategory] ([subCategory_id], [name], [description], [category_id]) VALUES (8, N'Gas', N'Gas', 2)
INSERT [dbo].[SubCategory] ([subCategory_id], [name], [description], [category_id]) VALUES (9, N'Nước', N'Nước', 2)
INSERT [dbo].[SubCategory] ([subCategory_id], [name], [description], [category_id]) VALUES (10, N'Điện', N'Điện', 2)
INSERT [dbo].[SubCategory] ([subCategory_id], [name], [description], [category_id]) VALUES (11, N'Điện Thoại Di Động', N'Điện Thoại Di Động', 2)
INSERT [dbo].[SubCategory] ([subCategory_id], [name], [description], [category_id]) VALUES (12, N'Truyền Hình', N'Truyền Hình', 2)
INSERT [dbo].[SubCategory] ([subCategory_id], [name], [description], [category_id]) VALUES (13, N'Xăng Xe', N'Xăng Xe', 3)
INSERT [dbo].[SubCategory] ([subCategory_id], [name], [description], [category_id]) VALUES (14, N'Rửa Xe', N'Rửa Xe', 3)
INSERT [dbo].[SubCategory] ([subCategory_id], [name], [description], [category_id]) VALUES (15, N'Taxi/Thuê Xe', N'Taxi/Thuê Xe', 3)
INSERT [dbo].[SubCategory] ([subCategory_id], [name], [description], [category_id]) VALUES (16, N'Gửi Xe', N'Gửi Xe', 3)
INSERT [dbo].[SubCategory] ([subCategory_id], [name], [description], [category_id]) VALUES (17, N'Sửa Chữa', N'Sửa Chữa', 3)
INSERT [dbo].[SubCategory] ([subCategory_id], [name], [description], [category_id]) VALUES (18, N'Quần Áo', N'Quần Áo', 4)
INSERT [dbo].[SubCategory] ([subCategory_id], [name], [description], [category_id]) VALUES (19, N'Giầy Dép', N'Giầy Dép', 4)
INSERT [dbo].[SubCategory] ([subCategory_id], [name], [description], [category_id]) VALUES (20, N'Vui Chơi Giải Trí', N'Vui Chơi Giải Trí', 5)
INSERT [dbo].[SubCategory] ([subCategory_id], [name], [description], [category_id]) VALUES (21, N'Du Lịch', N'Du Lịch', 5)
INSERT [dbo].[SubCategory] ([subCategory_id], [name], [description], [category_id]) VALUES (22, N'Làm Đẹp', N'Làm Đẹp', 5)
INSERT [dbo].[SubCategory] ([subCategory_id], [name], [description], [category_id]) VALUES (23, N'Mỹ Phẩm', N'Mỹ Phẩm', 5)
INSERT [dbo].[SubCategory] ([subCategory_id], [name], [description], [category_id]) VALUES (24, N'Phim Ảnh Ca Nhạc', N'Phim Ảnh Ca Nhạc', 5)
INSERT [dbo].[SubCategory] ([subCategory_id], [name], [description], [category_id]) VALUES (25, N'Tham Hỏi', N'Tham Hỏi', 6)
INSERT [dbo].[SubCategory] ([subCategory_id], [name], [description], [category_id]) VALUES (26, N'Cưới Xin', N'Cưới Xin', 6)
INSERT [dbo].[SubCategory] ([subCategory_id], [name], [description], [category_id]) VALUES (27, N'Biếu Tặng', N'Biếu Tặng', 6)
INSERT [dbo].[SubCategory] ([subCategory_id], [name], [description], [category_id]) VALUES (28, N'Ma Chay', N'Ma Chay', 6)
INSERT [dbo].[SubCategory] ([subCategory_id], [name], [description], [category_id]) VALUES (29, N'Học Phí', N'Học Phí', 7)
INSERT [dbo].[SubCategory] ([subCategory_id], [name], [description], [category_id]) VALUES (30, N'Sách vở', N'Sách Vở', 7)
INSERT [dbo].[SubCategory] ([subCategory_id], [name], [description], [category_id]) VALUES (31, N'Đồ Chơi', N'Đồ Chơi', 7)
INSERT [dbo].[SubCategory] ([subCategory_id], [name], [description], [category_id]) VALUES (32, N'Sữa', N'Sữa', 7)
INSERT [dbo].[SubCategory] ([subCategory_id], [name], [description], [category_id]) VALUES (33, N'Mua Sắm Đồ Đạc', N'Mua Sắm Đồ Đạc', 8)
INSERT [dbo].[SubCategory] ([subCategory_id], [name], [description], [category_id]) VALUES (34, N'Sửa Chữa Nhà Cửa', N'Sửa Chữa Nhà Cửa', 8)
INSERT [dbo].[SubCategory] ([subCategory_id], [name], [description], [category_id]) VALUES (35, N'Thuê Nhà', N'Thuê Nhà', 8)
INSERT [dbo].[SubCategory] ([subCategory_id], [name], [description], [category_id]) VALUES (36, N'Học Hành', N'Học Hành', 10)
INSERT [dbo].[SubCategory] ([subCategory_id], [name], [description], [category_id]) VALUES (37, N'Giao Lưu Quan Hệ', N'Giao Lưu Quan Hệ', 10)
INSERT [dbo].[SubCategory] ([subCategory_id], [name], [description], [category_id]) VALUES (38, N'Khám Chữa Bệnh', N'Khám Chữa Bệnh', 9)
INSERT [dbo].[SubCategory] ([subCategory_id], [name], [description], [category_id]) VALUES (39, N'Thuốc Men', N'Thuốc Men', 9)
SET IDENTITY_INSERT [dbo].[SubCategory] OFF
GO
SET IDENTITY_INSERT [dbo].[Type] ON 

INSERT [dbo].[Type] ([type_id], [name], [description]) VALUES (1, N'Thu', N'Thu')
INSERT [dbo].[Type] ([type_id], [name], [description]) VALUES (2, N'Chi', N'Chi')
SET IDENTITY_INSERT [dbo].[Type] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([user_id], [fullname], [account], [password], [gender]) VALUES (1, N'Ninh Hoai Bac', N'khuphuochue643', N'123', 0)
INSERT [dbo].[User] ([user_id], [fullname], [account], [password], [gender]) VALUES (2, N'Khu Phuoc Hue', N'ninhhoaibac919', N'123', 0)
INSERT [dbo].[User] ([user_id], [fullname], [account], [password], [gender]) VALUES (3, N'Nham Cao Minh', N'nhamcaominh707', N'123', 1)
INSERT [dbo].[User] ([user_id], [fullname], [account], [password], [gender]) VALUES (4, N'Ngo Viet Huong', N'ngoviethuong971', N'123', 0)
INSERT [dbo].[User] ([user_id], [fullname], [account], [password], [gender]) VALUES (5, N'Trieu Manh Nghiem', N'trieumanhnghiem962', N'123', 1)
INSERT [dbo].[User] ([user_id], [fullname], [account], [password], [gender]) VALUES (6, N'Bui Thien Minh', N'buithienminh508', N'123', 1)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Record]  WITH CHECK ADD  CONSTRAINT [FKRecord283691] FOREIGN KEY([user_id])
REFERENCES [dbo].[User] ([user_id])
GO
ALTER TABLE [dbo].[Record] CHECK CONSTRAINT [FKRecord283691]
GO
ALTER TABLE [dbo].[Record]  WITH CHECK ADD  CONSTRAINT [FKRecord368175] FOREIGN KEY([type_id])
REFERENCES [dbo].[Type] ([type_id])
GO
ALTER TABLE [dbo].[Record] CHECK CONSTRAINT [FKRecord368175]
GO
ALTER TABLE [dbo].[Record]  WITH CHECK ADD  CONSTRAINT [FKRecord570510] FOREIGN KEY([subCategory_id])
REFERENCES [dbo].[SubCategory] ([subCategory_id])
GO
ALTER TABLE [dbo].[Record] CHECK CONSTRAINT [FKRecord570510]
GO
ALTER TABLE [dbo].[SubCategory]  WITH CHECK ADD  CONSTRAINT [FKSubCategor644572] FOREIGN KEY([category_id])
REFERENCES [dbo].[Category] ([category_id])
GO
ALTER TABLE [dbo].[SubCategory] CHECK CONSTRAINT [FKSubCategor644572]
GO
USE [master]
GO
ALTER DATABASE [ManagePersonalExpenses] SET  READ_WRITE 
GO
