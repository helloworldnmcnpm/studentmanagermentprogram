USE [master]
GO
/****** Object:  Database [QuanLyHocSinh]    Script Date: 06/30/2018 18:02:47 ******/
CREATE DATABASE [QuanLyHocSinh]
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyHocSinh].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyHocSinh] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyHocSinh] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyHocSinh] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyHocSinh] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyHocSinh] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyHocSinh] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyHocSinh] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyHocSinh] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyHocSinh] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyHocSinh] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyHocSinh] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyHocSinh] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyHocSinh] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyHocSinh] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyHocSinh] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyHocSinh] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyHocSinh] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyHocSinh] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyHocSinh] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyHocSinh] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyHocSinh] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyHocSinh] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyHocSinh] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyHocSinh] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyHocSinh] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyHocSinh] SET DB_CHAINING OFF 
GO
USE [QuanLyHocSinh]
GO
/****** Object:  Table [dbo].[BANGDIEMMON]    Script Date: 06/30/2018 18:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BANGDIEMMON](
	[MaBangDiemMon] [nvarchar](100) NOT NULL,
	[MaQuaTrinhHoc] [int] NULL,
	[DiemTBM] [float] NULL,
	[MaMon] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBangDiemMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BAOCAOTONGKETHOCKY]    Script Date: 06/30/2018 18:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BAOCAOTONGKETHOCKY](
	[MaHocKy] [nvarchar](100) NOT NULL,
	[MaLop] [nvarchar](100) NOT NULL,
	[SoLuongDat] [int] NULL,
	[TyLeDat] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHocKy] ASC,
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BAOCAOTONGKETMON]    Script Date: 06/30/2018 18:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BAOCAOTONGKETMON](
	[MaBaoCaoTongKetMon] [nvarchar](100) NOT NULL,
	[MaHocKy] [nvarchar](100) NOT NULL,
	[MaMon] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBaoCaoTongKetMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITIETBANGDIEMMON]    Script Date: 06/30/2018 18:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETBANGDIEMMON](
	[MaChiTietBangDiemMon] [int] IDENTITY(1,1) NOT NULL,
	[MaBangDiemMon] [nvarchar](100) NOT NULL,
	[MaHinhThucKiemTra] [nvarchar](100) NOT NULL,
	[Diem] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChiTietBangDiemMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITIETBAOCAOTONGKETMON]    Script Date: 06/30/2018 18:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETBAOCAOTONGKETMON](
	[MaChiTietBaoCaoTongKetMon] [nvarchar](100) NOT NULL,
	[MaBaoCaoTongKetMon] [nvarchar](100) NOT NULL,
	[MaLop] [nvarchar](100) NOT NULL,
	[SoLuongDat] [int] NULL,
	[TyLeDat] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChiTietBaoCaoTongKetMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HINHTHUCKIEMTRA]    Script Date: 06/30/2018 18:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HINHTHUCKIEMTRA](
	[MaHinhThucKiemTra] [nvarchar](100) NOT NULL,
	[TenHinhThucKiemTra] [nvarchar](100) NOT NULL,
	[HeSo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHinhThucKiemTra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HOCKY]    Script Date: 06/30/2018 18:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOCKY](
	[MaHocKy] [nvarchar](100) NOT NULL,
	[TenHocKy] [nvarchar](100) NOT NULL,
	[MaNamHoc] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHocKy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HOCSINH]    Script Date: 06/30/2018 18:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOCSINH](
	[MaHocSinh] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](100) NOT NULL,
	[NgaySinh] [smalldatetime] NOT NULL,
	[NoiSinh] [nvarchar](100) NULL,
	[GioiTinh] [nvarchar](100) NOT NULL,
	[DanToc] [nvarchar](100) NULL,
	[TonGiao] [nvarchar](100) NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[DienThoai] [nvarchar](100) NOT NULL,
	[HoTenCha] [nvarchar](100) NULL,
	[NgheNghiepCha] [nvarchar](100) NULL,
	[HoTenMe] [nvarchar](100) NULL,
	[NgheNghiepMe] [nvarchar](100) NULL,
	[PhanLop] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHocSinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHOI]    Script Date: 06/30/2018 18:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHOI](
	[MaKhoi] [nvarchar](100) NOT NULL,
	[TenKhoi] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOP]    Script Date: 06/30/2018 18:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOP](
	[MaLop] [nvarchar](100) NOT NULL,
	[TenLop] [nvarchar](100) NOT NULL,
	[SiSo] [int] NULL,
	[MaKhoi] [nvarchar](100) NOT NULL,
	[MaNamHoc] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MON]    Script Date: 06/30/2018 18:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MON](
	[MaMon] [nvarchar](100) NOT NULL,
	[TenMon] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NAMHOC]    Script Date: 06/30/2018 18:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NAMHOC](
	[MaNamHoc] [nvarchar](100) NOT NULL,
	[TuNam] [int] NOT NULL,
	[DenNam] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNamHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QUATRINHHOC]    Script Date: 06/30/2018 18:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUATRINHHOC](
	[MaQuaTrinhHoc] [int] IDENTITY(1,1) NOT NULL,
	[MaLop] [nvarchar](100) NOT NULL,
	[MaHocSinh] [int] NOT NULL,
	[MaHocKy] [nvarchar](100) NOT NULL,
	[DiemTBHK] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaQuaTrinhHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QUYDINH]    Script Date: 06/30/2018 18:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUYDINH](
	[TuoiToiDa] [int] NULL,
	[TuoiToiThieu] [int] NULL,
	[SoHocSinhToiDa] [int] NULL,
	[DiemDat] [float] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TAIKHOANDANGNHAP]    Script Date: 06/30/2018 18:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOANDANGNHAP](
	[TenTaiKhoan] [nvarchar](100) NOT NULL,
	[MatKhau] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[TenTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[HINHTHUCKIEMTRA] ([MaHinhThucKiemTra], [TenHinhThucKiemTra], [HeSo]) VALUES (N'15Phut', N'Kiểm tra 15 phút', 1)
INSERT [dbo].[HINHTHUCKIEMTRA] ([MaHinhThucKiemTra], [TenHinhThucKiemTra], [HeSo]) VALUES (N'1Tiet', N'Kiểm tra 1 tiết', 2)
INSERT [dbo].[HINHTHUCKIEMTRA] ([MaHinhThucKiemTra], [TenHinhThucKiemTra], [HeSo]) VALUES (N'Mieng', N'Kiểm tra miệng', 1)
INSERT [dbo].[HOCKY] ([MaHocKy], [TenHocKy], [MaNamHoc]) VALUES (N'1', N'Hk1', N'1')
INSERT [dbo].[HOCKY] ([MaHocKy], [TenHocKy], [MaNamHoc]) VALUES (N'2', N'Hk1', N'10')
INSERT [dbo].[HOCKY] ([MaHocKy], [TenHocKy], [MaNamHoc]) VALUES (N'4', N'Hk2', N'11')
INSERT [dbo].[HOCKY] ([MaHocKy], [TenHocKy], [MaNamHoc]) VALUES (N'5', N'Hk1', N'11')
SET IDENTITY_INSERT [dbo].[HOCSINH] ON 

INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [DanToc], [TonGiao], [DiaChi], [DienThoai], [HoTenCha], [NgheNghiepCha], [HoTenMe], [NgheNghiepMe], [PhanLop]) VALUES (3, N'Nguyễn Văn A', CAST(N'2001-02-10 00:00:00' AS SmallDateTime), N'TPHCM', N'Nam', N'Kinh', N'Không', N'TPHCM', N'0123456789', N'Nguyễn Văn B', N'Kỹ sư', N'Nguyễn Thị C', N'Giáo viên', N'')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [DanToc], [TonGiao], [DiaChi], [DienThoai], [HoTenCha], [NgheNghiepCha], [HoTenMe], [NgheNghiepMe], [PhanLop]) VALUES (4, N'Lê Thị Ly', CAST(N'2002-05-12 00:00:00' AS SmallDateTime), N'TPHCM', N'Nữ', N'Kinh', N'Không', N'TPHCM', N'0987213466', N'Lê Văn A', N'Nông dân', N'Trần Thi B', N'Giáo viên', N'')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [NgaySinh], [NoiSinh], [GioiTinh], [DanToc], [TonGiao], [DiaChi], [DienThoai], [HoTenCha], [NgheNghiepCha], [HoTenMe], [NgheNghiepMe], [PhanLop]) VALUES (12, N'A', CAST(N'2003-12-31 00:00:00' AS SmallDateTime), N'Long An', N'Nữ', N'Kinh', N'Không', N'Long An', N'0', N'A', N'A', N'A', N'A', N'Inserted')
SET IDENTITY_INSERT [dbo].[HOCSINH] OFF
INSERT [dbo].[KHOI] ([MaKhoi], [TenKhoi]) VALUES (N'K10', N'Khối 10')
INSERT [dbo].[KHOI] ([MaKhoi], [TenKhoi]) VALUES (N'K11', N'Khối 11')
INSERT [dbo].[KHOI] ([MaKhoi], [TenKhoi]) VALUES (N'k12', N'Khối 12')
INSERT [dbo].[LOP] ([MaLop], [TenLop], [SiSo], [MaKhoi], [MaNamHoc]) VALUES (N'10A1', N'10A1', 1, N'K10', N'10')
INSERT [dbo].[MON] ([MaMon], [TenMon]) VALUES (N'Toan', N'Toán')
INSERT [dbo].[NAMHOC] ([MaNamHoc], [TuNam], [DenNam]) VALUES (N'1', 2019, 2020)
INSERT [dbo].[NAMHOC] ([MaNamHoc], [TuNam], [DenNam]) VALUES (N'10', 2020, 2021)
INSERT [dbo].[NAMHOC] ([MaNamHoc], [TuNam], [DenNam]) VALUES (N'11', 2021, 2022)
SET IDENTITY_INSERT [dbo].[QUATRINHHOC] ON 

INSERT [dbo].[QUATRINHHOC] ([MaQuaTrinhHoc], [MaLop], [MaHocSinh], [MaHocKy], [DiemTBHK]) VALUES (3, N'10A1', 12, N'2', 0)
SET IDENTITY_INSERT [dbo].[QUATRINHHOC] OFF
INSERT [dbo].[QUYDINH] ([TuoiToiDa], [TuoiToiThieu], [SoHocSinhToiDa], [DiemDat]) VALUES (20, 15, 40, 5)
INSERT [dbo].[TAIKHOANDANGNHAP] ([TenTaiKhoan], [MatKhau]) VALUES (N'Admin', N'admin')
ALTER TABLE [dbo].[BANGDIEMMON]  WITH CHECK ADD  CONSTRAINT [fk11] FOREIGN KEY([MaQuaTrinhHoc])
REFERENCES [dbo].[QUATRINHHOC] ([MaQuaTrinhHoc])
GO
ALTER TABLE [dbo].[BANGDIEMMON] CHECK CONSTRAINT [fk11]
GO
ALTER TABLE [dbo].[BANGDIEMMON]  WITH CHECK ADD  CONSTRAINT [fk18] FOREIGN KEY([MaMon])
REFERENCES [dbo].[MON] ([MaMon])
GO
ALTER TABLE [dbo].[BANGDIEMMON] CHECK CONSTRAINT [fk18]
GO
ALTER TABLE [dbo].[BAOCAOTONGKETHOCKY]  WITH CHECK ADD  CONSTRAINT [fk12] FOREIGN KEY([MaHocKy])
REFERENCES [dbo].[HOCKY] ([MaHocKy])
GO
ALTER TABLE [dbo].[BAOCAOTONGKETHOCKY] CHECK CONSTRAINT [fk12]
GO
ALTER TABLE [dbo].[BAOCAOTONGKETHOCKY]  WITH CHECK ADD  CONSTRAINT [fk13] FOREIGN KEY([MaLop])
REFERENCES [dbo].[LOP] ([MaLop])
GO
ALTER TABLE [dbo].[BAOCAOTONGKETHOCKY] CHECK CONSTRAINT [fk13]
GO
ALTER TABLE [dbo].[BAOCAOTONGKETMON]  WITH CHECK ADD  CONSTRAINT [fk14] FOREIGN KEY([MaHocKy])
REFERENCES [dbo].[HOCKY] ([MaHocKy])
GO
ALTER TABLE [dbo].[BAOCAOTONGKETMON] CHECK CONSTRAINT [fk14]
GO
ALTER TABLE [dbo].[BAOCAOTONGKETMON]  WITH CHECK ADD  CONSTRAINT [fk15] FOREIGN KEY([MaMon])
REFERENCES [dbo].[MON] ([MaMon])
GO
ALTER TABLE [dbo].[BAOCAOTONGKETMON] CHECK CONSTRAINT [fk15]
GO
ALTER TABLE [dbo].[CHITIETBANGDIEMMON]  WITH CHECK ADD  CONSTRAINT [fk10] FOREIGN KEY([MaHinhThucKiemTra])
REFERENCES [dbo].[HINHTHUCKIEMTRA] ([MaHinhThucKiemTra])
GO
ALTER TABLE [dbo].[CHITIETBANGDIEMMON] CHECK CONSTRAINT [fk10]
GO
ALTER TABLE [dbo].[CHITIETBANGDIEMMON]  WITH CHECK ADD  CONSTRAINT [fk9] FOREIGN KEY([MaBangDiemMon])
REFERENCES [dbo].[BANGDIEMMON] ([MaBangDiemMon])
GO
ALTER TABLE [dbo].[CHITIETBANGDIEMMON] CHECK CONSTRAINT [fk9]
GO
ALTER TABLE [dbo].[CHITIETBAOCAOTONGKETMON]  WITH CHECK ADD  CONSTRAINT [fk16] FOREIGN KEY([MaBaoCaoTongKetMon])
REFERENCES [dbo].[BAOCAOTONGKETMON] ([MaBaoCaoTongKetMon])
GO
ALTER TABLE [dbo].[CHITIETBAOCAOTONGKETMON] CHECK CONSTRAINT [fk16]
GO
ALTER TABLE [dbo].[CHITIETBAOCAOTONGKETMON]  WITH CHECK ADD  CONSTRAINT [fk17] FOREIGN KEY([MaLop])
REFERENCES [dbo].[LOP] ([MaLop])
GO
ALTER TABLE [dbo].[CHITIETBAOCAOTONGKETMON] CHECK CONSTRAINT [fk17]
GO
ALTER TABLE [dbo].[HOCKY]  WITH CHECK ADD  CONSTRAINT [fk4] FOREIGN KEY([MaNamHoc])
REFERENCES [dbo].[NAMHOC] ([MaNamHoc])
GO
ALTER TABLE [dbo].[HOCKY] CHECK CONSTRAINT [fk4]
GO
ALTER TABLE [dbo].[LOP]  WITH CHECK ADD  CONSTRAINT [fk2] FOREIGN KEY([MaKhoi])
REFERENCES [dbo].[KHOI] ([MaKhoi])
GO
ALTER TABLE [dbo].[LOP] CHECK CONSTRAINT [fk2]
GO
ALTER TABLE [dbo].[LOP]  WITH CHECK ADD  CONSTRAINT [fk3] FOREIGN KEY([MaNamHoc])
REFERENCES [dbo].[NAMHOC] ([MaNamHoc])
GO
ALTER TABLE [dbo].[LOP] CHECK CONSTRAINT [fk3]
GO
ALTER TABLE [dbo].[QUATRINHHOC]  WITH CHECK ADD  CONSTRAINT [fk5] FOREIGN KEY([MaLop])
REFERENCES [dbo].[LOP] ([MaLop])
GO
ALTER TABLE [dbo].[QUATRINHHOC] CHECK CONSTRAINT [fk5]
GO
ALTER TABLE [dbo].[QUATRINHHOC]  WITH CHECK ADD  CONSTRAINT [fk7] FOREIGN KEY([MaHocSinh])
REFERENCES [dbo].[HOCSINH] ([MaHocSinh])
GO
ALTER TABLE [dbo].[QUATRINHHOC] CHECK CONSTRAINT [fk7]
GO
ALTER TABLE [dbo].[QUATRINHHOC]  WITH CHECK ADD  CONSTRAINT [fk8] FOREIGN KEY([MaHocKy])
REFERENCES [dbo].[HOCKY] ([MaHocKy])
GO
ALTER TABLE [dbo].[QUATRINHHOC] CHECK CONSTRAINT [fk8]
GO
/****** Object:  StoredProcedure [dbo].[USP_AddNamHoc]    Script Date: 06/30/2018 18:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_AddNamHoc] 
@MaNamHoc nvarchar(100), @NamBatDau nvarchar(100), @NamKetThuc nvarchar(100)
as
begin
	insert into NAMHOC values(@MaNamHoc, @NamBatDau,@NamKetThuc)
end
GO
/****** Object:  Trigger [dbo].[trg_ins_up_TenHocKy_MaNamHoc_HOCKY]    Script Date: 06/30/2018 18:02:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[trg_ins_up_TenHocKy_MaNamHoc_HOCKY] on [dbo].[HOCKY]
for insert, update
as
begin
	declare @MaHocKy nvarchar(100), @TenHocKy nvarchar(100), @MaNamHoc nvarchar(100)
	select @MaHocKy=MaHocKy,@TenHocKy=TenHocKy,@MaNamHoc=MaNamHoc
	from inserted
	if(select count(*)
	   from HOCKY
	   where @TenHocKy=TenHocKy and @MaNamHoc=MaNamHoc)>1
	   begin
			print'TenHocKy va MaNamHoc phai doi mot khac nhau'
			rollback tran
	    end
end
GO
USE [master]
GO
ALTER DATABASE [QuanLyHocSinh] SET  READ_WRITE 
GO
