CREATE DATABASE db_ASP;
GO

USE db_ASP;
GO

--- Create tables ---
CREATE TABLE Hoa (
	MaHoa varchar(10) PRIMARY KEY NOT NULL,
	TenHoa nvarchar(100),
	GiaTien int,
	SoLuongTonKho int,
	MaLoaiHoa varchar(10),
	AnhMinhHoa nvarchar(MAX),
	TrangThai bit DEFAULT 1 NOT NULL
);

CREATE TABLE LoaiHoa (
	MaLoaiHoa varchar(10) PRIMARY KEY NOT NULL,
	TenLoaiHoa nvarchar(100) NOT NULL,
	TrangThai bit DEFAULT 1 NOT NULL
);

CREATE TABLE TaiKhoan (
	TenTaiKhoan varchar(20) PRIMARY KEY NOT NULL,
	MatKhau varchar(20) NOT NULL,
	Email nvarchar(100),
	SDT varchar(20),
	DiaChi nvarchar(MAX),
	HoTen nvarchar(100),
	LaAdmin bit DEFAULT 0 NOT NULL,
	AnhDaiDien nvarchar(MAX),
	TrangThai bit DEFAULT 1 NOT NULL
);

CREATE TABLE GioHang (
	TenTaiKhoan varchar(20) NOT NULL,
	MaHoa varchar(10) NOT NULL,
	SoLuong int DEFAULT 1 NOT NULL,
	CONSTRAINT PK_GioHang PRIMARY KEY (TenTaiKhoan, MaHoa)
);

CREATE TABLE HoaDon (
	MaHD varchar(10) PRIMARY KEY NOT NULL,
	TenTaiKhoan varchar(20) NOT NULL,
	NgayMua datetime,
	DiaChiGiaoHang nvarchar(MAX),
	SDTGiaoHang varchar(20),
	TongTien int,
	TrangThai bit DEFAULT 1 NOT NULL
);

CREATE TABLE CTHoaDon (
	MaHD varchar(10) NOT NULL,
	MaHoa varchar(10) NOT NULL,
	SoLuong int,
	DonGia int,
	CONSTRAINT PK_CTHoaDon PRIMARY KEY (MaHD, MaHoa)
);

--- Create foreign key constraints
ALTER TABLE Hoa
ADD FOREIGN KEY (MaLoaiHoa) REFERENCES LoaiHoa(MaLoaiHoa);

ALTER TABLE GioHang
ADD FOREIGN KEY (MaHoa) REFERENCES Hoa(MaHoa)

ALTER TABLE GioHang
ADD FOREIGN KEY (TenTaiKhoan) REFERENCES TaiKhoan(TenTaiKhoan)

ALTER TABLE HoaDon
ADD FOREIGN KEY (TenTaiKhoan) REFERENCES TaiKhoan(TenTaiKhoan)

ALTER TABLE CTHoaDon
ADD FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD)

ALTER TABLE CTHoaDon
ADD FOREIGN KEY (MaHoa) REFERENCES Hoa(MaHoa)

--- Insert values ---
--- into table TaiKhoan ---
INSERT INTO TaiKhoan (TenTaiKhoan, MatKhau, Email, SDT, DiaChi, HoTen, LaAdmin, AnhDaiDien, TrangThai) VALUES ('admin', 'admin', N'admin@webbanhang.com', '01234567890', N'Tp.Hồ Chí Minh', N'Nguyễn Văn Ad Min', 1, NULL, 1);
INSERT INTO TaiKhoan (TenTaiKhoan, MatKhau, Email, SDT, DiaChi, HoTen, LaAdmin, AnhDaiDien, TrangThai) VALUES ('test1', '123456', N'test@gmail.com', '0905123456', N'Hà Nội', N'Nguyễn Văn A', 0, NULL, 1);
INSERT INTO TaiKhoan (TenTaiKhoan, MatKhau, Email, SDT, DiaChi, HoTen, LaAdmin, AnhDaiDien, TrangThai) VALUES ('customer', '123456', N'customer@gmail.com', '0987654321', N'Huế', N'Trần Thị B', 0, NULL, 1);

---into Loai Hoa---
INSERT INTO LoaiHoa(MaLoaiHoa,TenLoaiHoa,TrangThai) VALUES('L001',N'Loại Hoa Hồng',1)
INSERT INTO LoaiHoa(MaLoaiHoa,TenLoaiHoa,TrangThai) VALUES('L002',N'Loại Hoa Mai',1)
INSERT INTO LoaiHoa(MaLoaiHoa,TenLoaiHoa,TrangThai) VALUES('L003',N'Loại Hoa Cúc',1)
INSERT INTO LoaiHoa(MaLoaiHoa,TenLoaiHoa,TrangThai) VALUES('L004',N'Loại Hoa Tulip',1)

--- into Hoa ---
INSERT INTO Hoa (MaHoa, TenHoa, GiaTien, SoLuongTonKho, MaLoaiHoa, AnhMinhHoa, TrangThai) VALUES ('H001', N'Hoa Hồng', 45000, 40, 'L001', 'Hoa-1.jpg', 1)
INSERT INTO Hoa (MaHoa, TenHoa, GiaTien, SoLuongTonKho, MaLoaiHoa, AnhMinhHoa, TrangThai) VALUES ('H002', N'Hoa Tulip', 51000, 15, 'L001', 'Hoa-2.jpg', 1)
INSERT INTO Hoa (MaHoa, TenHoa, GiaTien, SoLuongTonKho, MaLoaiHoa, AnhMinhHoa, TrangThai) VALUES ('H003', N'Hoa Mai', 59000, 29,'L002', 'Hoa-3.jpg', 1)
INSERT INTO Hoa (MaHoa, TenHoa, GiaTien, SoLuongTonKho, MaLoaiHoa, AnhMinhHoa, TrangThai) VALUES ('H004', N'Hoa Tuyết', 53000, 1, 'L002', 'Hoa-4.jpg', 1)
INSERT INTO Hoa (MaHoa, TenHoa, GiaTien, SoLuongTonKho, MaLoaiHoa, AnhMinhHoa, TrangThai) VALUES ('H005', N'Hoa Cúc', 52000, 36, 'L003', 'Hoa-5.jpg', 1)
INSERT INTO Hoa (MaHoa, TenHoa, GiaTien, SoLuongTonKho, MaLoaiHoa, AnhMinhHoa, TrangThai) VALUES ('H006', N'Hoa Lan', 57000, 9, 'L003', 'Hoa-6.jpg', 1)
INSERT INTO Hoa (MaHoa, TenHoa, GiaTien, SoLuongTonKho, MaLoaiHoa, AnhMinhHoa, TrangThai) VALUES ('H007', N'Hoa Mộc Lan', 42000, 7, 'L004', 'Hoa-7.jpg', 1)
INSERT INTO Hoa (MaHoa, TenHoa, GiaTien, SoLuongTonKho, MaLoaiHoa, AnhMinhHoa, TrangThai) VALUES ('H008', N'Hoa Mười Giờ', 51000, 0, 'L004', 'Hoa-8.jpg', 1)

