create database QLHS
go 
use QLHS
go
create table HocSinh
(
	MaHS nvarchar(5) primary key,
	TenHS nvarchar(50) not null,
	NgaySinh date null,
	GioiTinh nvarchar(10) null,
)
go
insert into HocSinh(MaHS, TenHS, NgaySinh, GioiTinh) values ('HS001', N'Phạm Nhật Minh', '03/07/1995', N'Nam');
insert into HocSinh(MaHS, TenHS, NgaySinh, GioiTinh) values ('HS002', N'Hoàng Nam', '03/07/1995', N'Nam');
insert into HocSinh(MaHS, TenHS, NgaySinh, GioiTinh) values ('HS003', N'Trung Anh', '03/07/1995', N'Nữ');
go
create table Diem
(
	MaHS nvarchar(5) primary key,
	Toan float default(0),
	Ly float default(0),
	Hoa float default(0),
	DTB float default(0),

	foreign key(MaHS) references HocSinh(MaHS),
)
go
insert into Diem(MaHS, Toan, Ly, Hoa) values ('HS001', 5,5,5);
insert into Diem(MaHS, Toan, Ly, Hoa) values ('HS002', 5,1,7);
insert into Diem(MaHS, Toan, Ly, Hoa) values ('HS003', 5,5,4);
select DAY(NgaySinh)
from HocSinh
select Toan ,(Toan+Ly+ Hoa) as DTB
from Diem