Create database QLDT;
use QLDT;


create table ErrorLog(
Id bigint primary key identity(1,1),
CreatedDate nvarchar(50) default 0,
AppVersion nvarchar(20) default '' not null,
Messagelog nvarchar(max) default '' not null,
);


create table UserAccount(
Id bigint primary key identity(1,1),
CreatedDate bigint default 0,
ModifiedDate bigint default 0,
IsActived bit default 1,

TenNguoiDung nvarchar(50) default '',
MatKhau text default '',
LoaiNguoiDung text default '',
TenNhanVien nvarchar(100) default '',
DiaChi nvarchar(100) default '',
CMND varchar(20) default '',
Dienthoai varchar(20) default '',
GhiChu nvarchar(1000) default '',
);

insert UserAccount(CreatedDate,ModifiedDate,IsActived,TenNguoiDung, MatKhau, LoaiNguoiDung) values (123,456,1, 'admin', '123456', 'Admin')

create table PhanQuyenNguoiDung(
Id bigint primary key identity(1,1),
CreatedDate bigint default 0,
ModifiedDate bigint default 0,
IsActived bit default 1,

UserAccountId bigint foreign key references UserAccount(Id) not null,
Feature nvarchar(50) default '',
Permission nvarchar (50) default '0',
)

create table DanhMuc(
Id bigint primary key identity(1,1),
AuthorId bigint foreign key references UserAccount(Id) not null,
CreatedDate bigint default 0,
ModifiedDate bigint default 0,
IsActived bit default 1,

Ten nvarchar(100) default '',
Loai nvarchar(20) default '',
GhiChu nvarchar(1000) default '',
);


create table KhachHang(
Id bigint primary key identity(1,1),
AuthorId bigint foreign key references UserAccount(Id) not null,
CreatedDate bigint default 0,
ModifiedDate bigint default 0,
IsActived bit default 1,

MaKH nvarchar(50),
Ten nvarchar(100) default '',
LoaiKhachHang nvarchar(20) default '',
DiaChi nvarchar(100) default '',
CMND varchar(20) default '',
Dienthoai varchar(20) default '',
Fax nvarchar(100) default '',
Email nvarchar(100) default '',
MaSoThue nvarchar(100) default '',
STK nvarchar(100) default '',
NganHang nvarchar(100) default '',
GhiChu nvarchar(1000) default '',
);

insert KhachHang(AuthorId,ModifiedDate,CreatedDate,IsActived,LoaiKhachHang) values (1,123,456,1,'KhachLe');

create table KhoHang(
Id bigint primary key identity(1,1),
AuthorId bigint foreign key references UserAccount(Id) not null,
CreatedDate bigint default 0,
ModifiedDate bigint default 0,
IsActived bit default 1,

LoaiHangId bigint foreign key references DanhMuc(Id) not null,
TenHang nvarchar(50) default '',
DonViTinh nvarchar(20) default 'CÁI',
SoLuong bigint default 0,
GiaBan bigint default 0,
TonLyTuong bigint default 0,
GhiChu nvarchar(1000) default '',
);

create table DonHang(
Id bigint primary key identity(1,1),
AuthorId bigint foreign key references UserAccount(Id) not null,
CreatedDate bigint default 0,
ModifiedDate bigint default 0,
IsActived bit default 1,

MaDH nvarchar(50),
LoaiDonHang nvarchar(50) default '',
NgayLap bigint default 0,
KhachHangId bigint foreign key references KhachHang(Id) not null,
Ten nvarchar(100) default '',
Dienthoai varchar(20) default '',
DiaChi nvarchar(100) default '',
ThanhTien bigint default 0,
Thue bigint default 10,
ChietKhau bigint default 0,
TongCong bigint default 0,
ThanhToan bigint default 0,
GhiChu nvarchar(1000) default '',
);

create table ChiTietDonHang(
Id bigint primary key identity(1,1),
AuthorId bigint foreign key references UserAccount(Id) not null,
CreatedDate bigint default 0,
ModifiedDate bigint default 0,
IsActived bit default 1,

DonHangId bigint foreign key references DonHang(Id) not null,
HangHoaId bigint foreign key references KhoHang(Id) not null,
LoaiDonHang nvarchar(50) default '',
DonGia bigint default 0,
SoLuong bigint default 0,
);

create table ChiTietHangHoa(
Id bigint primary key identity(1,1),
AuthorId bigint foreign key references UserAccount(Id) not null,
CreatedDate bigint default 0,
ModifiedDate bigint default 0,
IsActived bit default 1,

ChiTietDonHangId bigint foreign key references ChiTietDonHang(Id) not null,
IMEI nvarchar(50) default '',
)

alter table ThuChi drop constraint DF__ThuChi__NoiDung__114A936A
alter table ThuChi drop column NoiDung
alter table ThuChi add NoiDungId bigint foreign key references DanhMuc(Id) not null
create table ThuChi(
Id bigint primary key identity(1,1),
AuthorId bigint foreign key references UserAccount(Id) not null,
CreatedDate bigint default 0,
ModifiedDate bigint default 0,
IsActived bit default 1,

NgayLap bigint default 0,
Loai nvarchar(50) default '',
SoTien bigint default 0,
NoiDungId bigint foreign key references DanhMuc(Id) not null,
GhiChu nvarchar(1000) default '',
)

alter table CongNo add KhachHangId bigint foreign key references KhachHang(Id)
alter table CongNo drop constraint FK__CongNo__DonHangI__60A75C0F
alter table CongNo drop column DonHangId
alter table CongNo add DonHangId bigint foreign key references DonHang(Id)
alter table CongNo add LoaiDonHang nvarchar(50) default ''
alter table CongNo add NgayLap bigint default 0
create table CongNo(
Id bigint primary key identity(1,1),
AuthorId bigint foreign key references UserAccount(Id) not null,
CreatedDate bigint default 0,
ModifiedDate bigint default 0,
IsActived bit default 1,

NgayLap bigint default 0,
LoaiDonHang nvarchar(50) default '',
DonHangId bigint foreign key references DonHang(Id),
KhachHangId bigint foreign key references KhachHang(Id),
No bigint default 0,
ThanhToan bigint default 0,
GhiChu nvarchar(1000) default '',
);

create table ThanhToanCongNo(
Id bigint primary key identity(1,1),
AuthorId bigint foreign key references UserAccount(Id) not null,
CreatedDate bigint default 0,
ModifiedDate bigint default 0,
IsActived bit default 1,

CongNoId bigint foreign key references CongNo(Id) not null,
ThanhToan bigint default 0,
NgayThanhToan bigint default 0,
GhiChu nvarchar(1000) default '',
);