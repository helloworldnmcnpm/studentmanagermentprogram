drop database QuanLyHocSinh
create database QuanLyHocSinh
go
use QuanLyHocSinh
go
create table HOCSINH
(
	MaHocSinh int identity not null,
	HoTen nvarchar(100) not null,
	NgaySinh smalldatetime not null,
	NoiSinh nvarchar(100),
	GioiTinh nvarchar(100) not null,
	DanToc nvarchar(100),
	TonGiao nvarchar(100),
	DiaChi nvarchar(100) not null,
	DienThoai nvarchar(100)not null,
	HoTenCha nvarchar(100) ,
	NgheNghiepCha nvarchar(100),
	HoTenMe nvarchar(100),
	NgheNghiepMe nvarchar(100),
	MaLop nvarchar(100),

	primary key(MaHocSinh)
	
)
go

create table LOP
(
	MaLop nvarchar(100)not null,
	TenLop nvarchar(100) not null,
	SiSo int,
	MaKhoi nvarchar(100)not null,
	MaNamHoc nvarchar(100)not null,
	primary key(MaLop)
)

go
create table KHOI
(
	MaKhoi nvarchar(100)not null,
	TenKhoi nvarchar(100)not null,
	primary key(MaKhoi)

)

go

create table HOCKY
(
	MaHocKy nvarchar(100)not null,
	TenHocKy nvarchar(100)not null,
	MaNamHoc nvarchar(100)not null,
	primary key(MaHocKy)
)

go
create table NAMHOC
(
	MaNamHoc nvarchar(100)not null,
	TuNam int not null,
	DenNam int not null,
	primary key(MaNamHoc)
)

go
create table MON
( 
	MaMon nvarchar(100)not null,
	TenMon nvarchar(100)not null,
	primary key(MaMon)
)
go
create table HINHTHUCKIEMTRA
(
	MaHinhThucKiemTra nvarchar(100)not null,
	TenHinhThucKiemTra nvarchar(100)not null,
	HeSo int not null,
	primary key(MaHinhThucKiemTra)
)
go
create table QUATRINHHOC
(
	MaQuaTrinhHoc nvarchar(100) not null,
	MaLop nvarchar(100) not null,
	MaHocSinh int not null,
	MaHocKy nvarchar(100) not null,
	DiemTBHK float,
	primary key(MaQuaTrinhHoc)
)
go
create table CHITIETBANGDIEMMON
(
	MaChiTietBangDiemMon nvarchar(100)not null,
	MaBangDiemMon nvarchar(100)not null,
	MaHinhThucKiemTra nvarchar(100)not null,
	Diem float,
	primary key(MaChiTietBangDiemMon)
)
go
create table BANGDIEMMON
(
	MaBangDiemMon nvarchar(100)not null,
	MaQuaTrinhHoc nvarchar(100)not null,
	DiemTBM float,
	primary key(MaBangDiemMon)
)
go
create table BAOCAOTONGKETHOCKY
(
	MaHocKy nvarchar(100)not null,
	MaLop nvarchar(100)not null,
	SoLuongDat int,
	TyLeDat float,
	primary key(MaHocKy,MaLop)
)
go
create table BAOCAOTONGKETMON
(
	MaBaoCaoTongKetMon nvarchar(100)not null,
	MaHocKy nvarchar(100)not null,
	MaMon nvarchar(100)not null,
	primary key(MaBaoCaoTongKetMon)
)
go
create table CHITIETBAOCAOTONGKETMON
(	 
	MaChiTietBangDiemMon nvarchar(100) not null,
	MaBaoCaoTongKetMon nvarchar(100)not null,
	MaLop nvarchar(100)not null,
	SoLuongDat int,
	TyLeDat float,
	primary key(MaChiTietBangDiemMon)
)
go
create table QUYDINH
(
	TuoiToiDa int,
	TuoiToiThieu int,
	SoHocSinhToiDa int,
	DiemDat float,
	
)
go
--Tạo khóa ngoại
alter table HOCSINH add constraint  fk1 foreign key (MaLop) references LOP(MaLop)
go
alter table LOP add constraint fk2 foreign key(MaKhoi) references KHOI(MaKhoi)
go
alter table LOP add constraint fk3 foreign key(MaNamHoc) references NAMHOC(MaNamHoc)
go
alter table HOCKY add constraint fk4 foreign key (MaNamHoc) references NAMHOC(MaNamHoc)
go
alter table QUATRINHHOC add constraint fk5 foreign key (MaLop) references LOP(MaLop),
constraint fk7 foreign key (MaHocSinh) references HOCSINH(MaHocSinh),
constraint fk8 foreign key (MaHocKy) references HOCKY(MaHocKy)
go
alter table CHITIETBANGDIEMMON add constraint fk9 foreign key(MaBangDiemMon) references BANGDIEMMON(MaBangDiemMon),
constraint fk10 foreign key(MaHinhThucKiemTra) references HINHTHUCKIEMTRA(MaHinhThucKiemTra)
go
alter table BANGDIEMMON add constraint fk11 foreign key(MaQuaTrinhHoc)references QUATRINHHOC(MaQuaTrinhHoc)
go
alter table BAOCAOTONGKETHOCKY add constraint fk12 foreign key (MaHocKy) references HOCKY(MaHocKy),
constraint fk13 foreign key(MaLop) references LOP(MaLop)
go
alter table BAOCAOTONGKETMON add constraint fk14 foreign key (MaHocKy) references HOCKY(MaHocKy),
constraint fk15 foreign key(MaMon) references MON(MaMon)
go
alter table CHITIETBAOCAOTONGKETMON add constraint fk16 foreign key (MaBaoCaoTongKetMon) references BAOCAOTONGKETMoN(MaBaoCaoTongKetMon),
constraint fk17 foreign key(MaLop) references LOP(MaLop)
go


--Tạo ràng buộc
<<<<<<< HEAD
--Giới tính chỉ thuộc 2 giá trị là Nam hoặc nữ
alter table  HOCSINH add constraint  GioiTinh CHECK ( GIOITINH IN ('Nam','Nữ'))
go
 
=======
>>>>>>> 51d9e07d4ce430b487403d33d0d11102fd8ec11d

--Trigger Kiểm tra tuổi
create trigger trg_ins_up_HOCSINH on HOCSINH
for insert, update
as 
begin
	declare @NgaySinh smalldatetime,@TuoiToiDa int, @TuoiToiThieu int
	select @NgaySinh=NgaySinh from inserted
	select @TuoiToiDa=TuoiToiDa, @TuoiToiThieu=TuoiToiThieu from QUYDINH
	if(year(GETDATE())-year(@NgaySinh)<15 or year(GETDATE())-year(@NgaySinh)>20)
		begin
			print'Tuoi cua hoc sinh phai lon hon bang 15 va nho hon bang 20'
			rollback tran
		end
end
go


		





