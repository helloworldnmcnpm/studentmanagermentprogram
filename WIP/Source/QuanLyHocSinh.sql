﻿create database QuanLyHocSinh
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
	PhanLop nvarchar(100),
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
	MaQuaTrinhHoc int identity  not null,
	MaLop nvarchar(100) not null,
	MaHocSinh int not null,
	MaHocKy nvarchar(100) not null,
	DiemTBHK float,
	primary key(MaQuaTrinhHoc)
)
go
create table CHITIETBANGDIEMMON
(
	MaChiTietBangDiemMon int identity not null,
	MaBangDiemMon nvarchar(100)not null,
	MaHinhThucKiemTra nvarchar(100)not null,
	Diem float,
	primary key(MaChiTietBangDiemMon)
)
go

create table BANGDIEMMON
(
	MaBangDiemMon nvarchar(100)not null,
	MaQuaTrinhHoc int,
	DiemTBM float,
	MaMon nvarchar (100),
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
	MaBaoCaoTongKetMon nvarchar(100) not null,
	MaBaoCaoTongKetMon nvarchar(100)not null,
	MaLop nvarchar(100)not null,
	SoLuongDat int,
	TyLeDat float,
	primary key(MaChiTietBaoCaoTongKetMon)
)
go
create table QUYDINH
(
	TuoiToiDa int,
	TuoiToiThieu int,
	SoHocSinhToiDa int,
	DiemDat float
)

go
--Tạo khóa ngoại
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
alter table CHITIETBAOCAOTONGKETMON add constraint fk16 foreign key (MaBaoCaoTongKetMon) references BAOCAOTONGKETMON(MaBaoCaoTongKetMon),
constraint fk17 foreign key(MaLop) references LOP(MaLop)
go
alter table BANGDIEMMON add constraint fk18 foreign key(MaMon) references MON(MaMon)
go



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
--Trigger kiểm tra DenNam phải lớn hơn TuNam 1 năm
create trigger trg_ins_up_TuNam_DenNam_NAMHOC on NAMHOC
for insert, update
as
begin
	declare @MaNamHoc nvarchar(100), @TuNam int, @DenNam int
	select @TuNam=TuNam,@DenNam=DenNam
	from inserted

	if(@DenNam-@TuNam !=1)
		begin
			print'Den nam phai lon hon tu nam 1 nam'
			rollback tran
	    end
end
go
--Trigger kiểm tra DenNam phải khác tất cả các DenNam có trng bảng
create  trigger trg_ins_up_NAMHOC on NAMHOC
for insert, update
as
begin
	declare @MaNamHoc nvarchar(100), @TuNam int, @DenNam int
	select @TuNam=TuNam,@DenNam=DenNam
	from inserted
	if(select count(*)
	   from NAMHOC
	   where @TuNam=TuNam and @DenNam=DenNam)>1
	   begin
			print'Tu Nam va Den Nam phai doi mot khac nhau'
			rollback tran
	    end
end
go
--Thêm dữ liệu vào bảng quy định
insert into  QUYDINH(TuoiToiDa, TuoiToiThieu, SoHocSinhToiDa, DiemDat) values (20,15,40,5)
go
--Thêm bảng TAIKHOAN
create table TAIKHOANDANGNHAP
(
	TenTaiKhoan nvarchar(100),
	MatKhau nvarchar(100),
	primary key(TenTaiKhoan)
)
go 
insert into TAIKHOANDANGNHAP(TenTaiKhoan, MatKhau) values('Admin','admin')
go
insert into NAMHOC values('1',2019,2020)
go
create trigger trg_ins_up_TenHocKy_MaNamHoc_HOCKY on HOCKY
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
go

--Tạo proc Lên lớp
create proc USP_LenLop
 @MaHocKy nvarchar(100),@MaLop nvarchar(100),@MaHocSinh int
as
begin
	select * into QUATRINHHOC1 from QUATRINHHOC where MaHocSinh=@MaHocSinh
	update QUATRINHHOC
	set MaLop=@MaLop, MaHocKy=@MaHocKy
	where MaHocSinh=@MaHocSinh
end
--Tạo proc Chuyển lớp
create proc USP_ChuyenLop
 @MaHocKy nvarchar(100),@MaLop nvarchar(100),@MaHocSinh int
as
begin
	update QUATRINHHOC
	set MaLop=@MaLop
	where  MaHocKy=@MaHocKy and MaHocSinh=@MaHocSinh
end

go

select * from TAIKHOANDANGNHAP