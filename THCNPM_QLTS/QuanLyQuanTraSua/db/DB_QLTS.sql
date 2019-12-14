CREATE DATABASE QuanLiTraSua
GO
USE QuanLiTraSua
GO

CREATE TABLE KHACHHANG
(
ID int NOT NULL UNIQUE IDENTITY(1,1),
HoTen nvarchar(50),
DiaChi nvarchar(50),
NgaySinh datetime,
SDT varchar(11),
LoaiKH int,
Email varchar(50),
DiemTichLuy int,
PRIMARY KEY(ID)
)
CREATE TABLE LOAIKHACHHANG
(
ID int NOT NULL IDENTITY(1,1),
LoaiKhachHang nvarchar(50),
PRIMARY KEY(ID)
)
CREATE TABLE CHITIETHOADON
(
ID int NOT NULL IDENTITY(1,1),
ID_HoaDon int,
ID_Mon int,
--Size varchar(10) NOT NULL,
Duong nvarchar(50),
Da nvarchar(50),
Huong nvarchar(50),
Topping nvarchar(50),
GhiChu nvarchar(50)

PRIMARY KEY(ID)
)
CREATE TABLE CHITIETMON
(
ID_Mon int NOT NULL ,
ID_NguyenLieu int NOT NULL,
PRIMARY KEY(ID_Mon,ID_NguyenLieu)
)
CREATE TABLE HOADON
(
ID int NOT NULL UNIQUE IDENTITY(1,1),
ID_KhachHang int,
NgayDat datetime,
HinhThucThanhToan nvarchar(50),
ID_PhuongThucGiao int,
DiaChiNhan nvarchar(50),
KT_Ship int,
PRIMARY KEY(ID)
)
CREATE TABLE MON
(
ID int NOT NULL IDENTITY(1,1),
TenMon nvarchar(50),
Size nvarchar(10),
Gia int,
KT_DacBiet int,
KT_BanChay int,
LinkAnh varchar(20),
PRIMARY KEY(ID)
)
CREATE TABLE NGUYENLIEU
(
ID int NOT NULL IDENTITY(1,1),
TenNguyenLieu nvarchar(50),
XuatXu nvarchar(50),
NgayNhap datetime,
TinhTrang nvarchar(50),
PRIMARY KEY(ID)
)
CREATE TABLE PHUONGTHUC
(
ID int NOT NULL IDENTITY(1,1),
TenPhuongThuc nvarchar(50),
PRIMARY KEY(ID)
)
CREATE TABLE SHIP
(
ID int NOT NULL IDENTITY(1,1),
ID_HoaDon int,
ID_Shipper int,
TenNguoiGiao nvarchar(50),
SDTNguoiGiao varchar(11),
SDTNguoiNhan varchar(11),
PRIMARY KEY(ID)
)
CREATE TABLE SHIPPER
(
ID int NOT NULL IDENTITY(1,1),
HoTen nvarchar(20),
DiaChi nvarchar(50),
SDT varchar(11),
CtyQuanLi nvarchar(50),
PRIMARY KEY(ID)
)
ALTER TABLE KHACHHANG ADD CONSTRAINT FK_KHACHHANG_LOAIKHACHHANG FOREIGN KEY(LoaiKH) REFERENCES LOAIKHACHHANG(ID) 
ALTER TABLE CHITIETMON ADD CONSTRAINT FK_CHITIETMON_NGUYENLIEU FOREIGN KEY(ID_NguyenLieu) REFERENCES NGUYENLIEU(ID)
ALTER TABLE CHITIETMON ADD CONSTRAINT FK_CHITIETMON_MON FOREIGN KEY(ID_Mon) REFERENCES MON(ID)
ALTER TABLE HOADON ADD CONSTRAINT FK_HOADON_KHACHHANG FOREIGN KEY(ID_KhachHang) REFERENCES KHACHHANG(ID)
ALTER TABLE SHIP ADD CONSTRAINT FK_SHIP_HOADON FOREIGN KEY(ID_HoaDon) REFERENCES HOADON(ID)
ALTER TABLE SHIP ADD CONSTRAINT FK_SHIP_SHIPPER FOREIGN KEY(ID_Shipper) REFERENCES SHIPPER(ID)
ALTER TABLE HOADON ADD CONSTRAINT FK_HOADON_PHUONGTHUC FOREIGN KEY(ID_PhuongThucGiao) REFERENCES PHUONGTHUC(ID)
ALTER TABLE CHITIETHOADON ADD CONSTRAINT FK_CHITIETHOADON_HOADON FOREIGN KEY(ID_HoaDon) REFERENCES HOADON(ID)
ALTER TABLE CHITIETHOADON ADD CONSTRAINT FK_CHITIETHOADON_MON FOREIGN KEY(ID_Mon) REFERENCES MON(ID)
GO

/*SET IDENTITY_INSERT PHUONGTHUC ON*/
GO
--SET IDENTITY_INSERT PHUONGTHUC ON
--SET IDENTITY_INSERT LOAIKHACHHANG ON
INSERT INTO LOAIKHACHHANG(LoaiKhachHang)
VALUES
(N'Thành viên thường'),
(N'Thành viên VIP')

--SET IDENTITY_INSERT PHUONGTHUC ON
INSERT INTO PHUONGTHUC(TenPhuongThuc)
VALUES
(N'Giao hàng thường'),
(N'Giao hàng nhanh')

INSERT INTO SHIPPER(HoTen,DiaChi,SDT,CtyQuanLi) VALUES
(N'Nguyễn Văn A',N'Hồ Chí Minh','0758849921','Grab'),
(N'Nguyễn Văn B',N'Hồ Chí Minh','0758949822','Go Viet'),
(N'Lê Đình Thành',N'Long An','0949844063','Go Viet'),
(N'Trần Long',N'Tiền Giang','0987635218','Go Viet'),
(N'Ngô Văn Tiến',N'An Giang','091762415','Grab'),
(N'Trần Văn Tý',N'Đồng Tháp','098975078','Grab'),
(N'Nguyễn Thị Hoa',N'Hồ Chí Minh','0768805505','Grab'),
(N'Nguyễn Thị Quỳnh',N'Đà Nẵng','0919897837','Grab'),
(N'Trần Văn Tèo',N'Đà Nẵng','0768805502','Grab'),
(N'Nguyễn Thị Quỳnh Hoa',N'Cà Mau','0919786541','Go Viet')
--DELETE SHIPPer
--SELECT * FROM KHACHHANG
INSERT INTO KHACHHANG VALUES
(N'Trần Văn An',N'Đồng Nai','1999-01-02','08965432162',1,'tva@gmail.com',100),
(N'Đỗ Văn Bình',N'Hồ Chí Minh','1998-02-03','0919865401',2,NULL,500),
(N'Nguyễn Lê Tú',N'Hồ Chí Minh',NULL,'0919876351',1,'aaa1@gmail.com',50),
(N'Trần Văn Kiên',N'Hồ Chí Minh','2000-03-05','0987652147',1,'tvk1111@gmail.com',150),
(N'Phan Tấn Trung',N'Hồ Chí Minh',NULL,'0768845561',1,'baroibeo@gmail.com',100),
(N'Trương Tuấn Tú',N'Hải Phòng',NULL,'0767845861',1,'tusena@gmail.com',200),
(N'Phạm Gia Vỹ',N'Bình Dương','2001-09-08','0932145671',2,'kitz1998@gmail.com',300),
(N'Lê Quang Khải',N'Bình Dương','2003-03-04','0768824479',2,'lqk2017@gmail.com',350),
(N'Trần Bình Minh',N'Hồ Chí Minh','1997-09-08','0917253617',1,'bmtran111@gmail.com',50),
(N'Nguyễn Thị Tươi',N'Hồ Chí Minh',NULL,'0939765438',1,'tttuoi222@gmail.com',150)
INSERT INTO NGUYENLIEU VALUES
(N'Sữa tươi',N'Đồng Nai','2019-02-03',N'Còn hàng'),
(N'Bột chocolate',N'Thái Lan','2019-02-03',N'Còn hàng'),
(N'Bột matcha',N'Hà Nội','2019-03-03',N'Sắp hết hàng'),
(N'Trân châu đen',N'Hồ Chí Minh','2019-02-03',N'Hết hàng'),
(N'Thạch trái cây',N'Hồ Chí Minh','2019-02-03',N'Còn hàng'),
(N'Thạch nha đam',N'Hồ Chí Minh','2019-02-03',N'Còn hàng'),
(N'Đào tươi',N'Đà Lạt','2019-12-03',N'Còn hàng'),
(N'Vải',N'Đà Lạt','2019-12-03',N'Còn hàng'),
(N'Tắc',N'Tiền Giang','2019-12-03',N'Còn hàng'),
(N'Dâu',N'Đà Lạt','2019-12-05',N'Sắp hết hàng'),
(N'Bơ',N'Đà Lạt','2019-12-05',N'Còn hàng'),
(N'Táo',N'Hồ Chí Minh','2019-12-05',N'Hết hàng'),
(N'Hồng trà hòa tan',N'Hồ Chí Minh','2019-12-05',N'Còn hàng'),
(N'Bột trà sữa',N'Hồ Chí Minh','2019-12-05',N'Còn hàng'),
(N'Đường',N'Biên Hòa','2019-12-05',N'Còn hàng')

INSERT INTO MON VALUES
(N'Trà sữa chocolate','S',20000,0,0,'1.png'),
(N'Trà sữa chocolate','M',25000,0,0,'1.png'),
(N'Trà sữa chocolate','L',30000,0,0,'1.png'),
(N'Trà sữa truyền thống','S',15000,0,0,'2.png'),
(N'Trà sữa truyền thống','M',20000,0,0,'2.png'),
(N'Trà sữa truyền thống','L',25000,0,0,'2.png'),
(N'Trà sữa thái','S',15000,0,0,'3.png'),
(N'Trà sữa thái','M',20000,0,0,'3.png'),
(N'Trà sữa thái','L',25000,0,0,'3.png'),
(N'Trà sữa matcha','S',25000,1,0,'4.png'),
(N'Trà sữa matcha','M',30000,1,0,'4.png'),
(N'Trà sữa matcha','L',35000,1,0,'4.png'),
(N'Trà sữa trân châu đường đen','S',25000,1,0,'5.png'),
(N'Trà sữa trân châu đường đen','M',30000,1,0,'5.png'),
(N'Trà sữa trân châu đường đen','L',35000,1,0,'5.png'),
(N'Hồng trà','S',10000,0,1,'6.png'),
(N'Hồng trà','M',15000,0,1,'6.png'),
(N'Hồng trà','L',20000,0,1,'6.png'),
(N'Hồng trà vải','S',15000,1,0,'7.png'),
(N'Hồng trà vải','M',20000,1,0,'7.png'),
(N'Hồng trà vải','L',25000,1,0,'7.png'),
(N'Hồng trà đào','S',15000,0,1,'8.png'),
(N'Hồng trà đào','M',20000,0,1,'8.png'),
(N'Hồng trà đào','L',25000,0,1,'8.png'),
(N'Hồng trà tắc','S',12000,0,0,'9.png'),
(N'Hồng trà tắc','M',15000,0,0,'9.png'),
(N'Hồng trà tắc','L',20000,0,0,'9.png'),
(N'Sinh tố bơ','S',25000,0,0,'10.png'),
(N'Sinh tố bơ','M',30000,0,0,'10.png'),
(N'Sinh tố bơ','L',35000,0,0,'10.png'),
(N'Sinh tố dâu','S',15000,0,1,'11.png'),
(N'Sinh tố dâu','M',20000,0,1,'11.png'),
(N'Sinh tố dâu','L',25000,0,1,'11.png'),
(N'Nước ép táo','S',25000,1,0,'12.png'),
(N'Nước ép táo','M',30000,1,0,'12.png'),
(N'Nước ép táo','L',35000,1,0,'12.png')

INSERT INTO CHITIETMON VALUES
(1,14),(1,2),(1,4),(2,14),(2,2),(2,4),(3,14),(3,2),(3,4),(4,14),(4,4),(5,14),(5,4),(6,14),(6,4),
(7,14),(7,4),(7,1),(8,14),(8,4),(8,1),(9,14),(9,4),(9,1),(10,14),(10,5),(10,4),(11,14),(11,5),(11,4),
(12,14),(12,5),(12,4),(13,1),(13,14),(13,15),(13,4),(14,1),(14,14),(14,15),(14,4),(15,1),(15,14),(15,15),(15,4),
(16,13),(16,7),(17,13),(17,7),(18,13),(18,7),(19,13),(19,8),(20,13),(20,8),(21,13),(21,8),(22,13),(22,7),
(23,13),(23,7),(24,13),(24,7),(25,1),(25,15),(25,11),(26,1),(26,15),(26,11),(27,1),(27,15),(27,11),
(28,1),(28,10),(28,15),(29,1),(29,10),(29,15),(30,1),(30,10),(30,15),(31,12),(31,15),(32,12),(32,15),(33,12),(33,15)



INSERT INTO HOADON VALUES
(1,'2019-11-28',N'Thẻ ngân hàng',NULL,N'78 Nguyễn Thị Minh Khai,Q1,HCM',0),
(1,'2019-11-29',N'Tiền mặt',1,N'431A/31,P12,Q10,HCM',1),
(2,'2019-11-29',N'Tiền mặt',2,N'227 Nguyễn Văn Cừ,Q5,HCM',1),
(2,'2019-11-30',N'Tiền mặt',1,N'227 Nguyễn Văn Cừ,Q5,HCM',1),
(3,'2019-12-01',N'Tiền mặt',2,N'227 Nguyễn Văn Cừ,Q5,HCM',1),
(3,'2019-12-02',N'Tiền mặt',2,N'227 Nguyễn Văn Cừ,Q5,HCM',1),
(5,'2019-12-01',N'Tiền mặt',1,N'777 Nguyễn Thị Tần,Q8,HCM',1),
(5,'2019-12-02',N'Thẻ ngân hàng',NULL,N'78 Nguyễn Thị Minh Khai,Q1,HCM',0),
(NULL,'2019-12-03',N'Thẻ ngân hàng',NULL,N'78 Nguyễn Thị Minh Khai,Q1,HCM',0)

INSERT INTO SHIP VALUES
(2,1,NULL,NULL,'0919865401'),
(2,2,NULL,NULL,'0919865401'),
(3,5,NULL,NULL,'0919876351'),
(3,NULL,N'Trần Huy','0908756431','0919876351'),
(5,6,NULL,NULL,'0768845561'),
(5,3,NULL,NULL,'0768845561')


INSERT INTO CHITIETHOADON VALUES
(1,1,NULL,NULL,NULL,NULL,NULL),
(1,2,NULL,NULL,NULL,NULL,NULL),
(2,1,NULL,NULL,NULL,NULL,'Không đá'),
(3,1,NULL,NULL,NULL,NULL,NULL),
(4,5,NULL,NULL,NULL,NULL,NULL),
(5,6,NULL,NULL,NULL,NULL,NULL),
(6,5,NULL,NULL,NULL,NULL,NULL),
(7,3,NULL,NULL,NULL,NULL,NULL),
(8,4,NULL,NULL,NULL,NULL,NULL),
(9,7,NULL,NULL,NULL,NULL,NULL)


CREATE PROC USP_GetDrinkByName @name_drink nvarchar(50)
AS
BEGIN
SELECT * FROM MON WHERE @name_drink=TenMon
END
GO

CREATE PROC USP_GetMaterialByName @name_mater nvarchar(50)
AS
BEGIN
SELECT * FROM NGUYENLIEU WHERE TenNguyenLieu LIKE @name_mater
END
GO

CREATE PROC USP_GetListMaterial
AS
BEGIN
SELECT * FROM NGUYENLIEU
END
GO

CREATE PROC USP_GetListDrink
AS
BEGIN
SELECT * FROM MON
END
GO

 CREATE PROC USP_GetListCustomer
 AS
 BEGIN
 SELECT KH.ID,KH.HoTen,KH.NgaySinh,KH.DiaChi,KH.SDT,L.LoaiKhachHang,KH.Email,KH.DiemTichLuy FROM KHACHHANG KH,LOAIKHACHHANG L WHERE KH.LoaiKH=L.ID
 END
 GO

 --ADD
CREATE PROC USP_SearchProductByName @keyword nvarchar(50)
AS
BEGIN
SELECT * FROM MON WHERE TenMon LIKE '%' + @keyword + '%'
END
GO

CREATE PROC USP_GetDrinkByID @id int
AS
BEGIN
SELECT * FROM MON WHERE ID = @id
END
GO
--INSERT INTO CHITIETHOADON VALUES
--(1,5,NULL,NULL,NULL,NULL,1,NULL)
--SELECT * FROM CHITIETHOADON