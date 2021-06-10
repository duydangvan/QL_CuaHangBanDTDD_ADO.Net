CREATE DATABASE CH_DIENTHOAIDIDONG
USE CH_DIENTHOAIDIDONG

CREATE TABLE NHANVIEN
(
MANV CHAR(20) PRIMARY KEY,
HOTEN NVARCHAR(50),
DIACHI NVARCHAR(100),
CMND CHAR(20),
NGAYSINH DATE,
SDT CHAR(15),
EMAIL CHAR(20),
CHUCVU NVARCHAR(50)
)

CREATE TABLE THANHVIEN
(
TAIKHOAN CHAR(50),
 PRIMARY KEY(TAIKHOAN),
MATKHAU CHAR(20),
MANV CHAR(20),
CONSTRAINT FK_THANHVIEN_MANV FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV)
)

CREATE TABLE HANGSX
(
MAHANGSX CHAR(20) PRIMARY KEY,
TENHANGSX CHAR(20),
DIACHI NVARCHAR(50)
)

--sửa ngày sinh khách hàng
CREATE TABLE KHACHHANG
(
MAKH CHAR(20)PRIMARY KEY,
TENKH NVARCHAR(50),
DIACHI NVARCHAR(50),
SDT CHAR(15),
NgaySinh date,
EMAIL CHAR(20),
)

CREATE TABLE SANPHAM
(
MASP CHAR(20)PRIMARY KEY,
TENSP NVARCHAR(50),
MAHANGSX CHAR(20),
DONGIA FLOAT,
SOLUONG INT,
XUATXU NVARCHAR(50),
THOIGIAN_BH INT,
CONSTRAINT FK_SANPHAM_MAHANGSX FOREIGN KEY(MAHANGSX) REFERENCES HANGSX(MAHANGSX)
)


CREATE TABLE CHITIET_SP
(
MASP CHAR(20),
MAHANGSX CHAR(20),
PRIMARY KEY(MASP,MAHANGSX),
CHIEUDAI FLOAT,
CHIEURONG FLOAT,
DODAY FLOAT,
TRONGLUONG FLOAT,
MANHINH FLOAT,
RAM NVARCHAR(20),
BONHOTRONG NVARCHAR(20),
HEDIEUHANH NVARCHAR(500),
MOTA NVARCHAR(1000)
CONSTRAINT FK_CHITIETSP_MASP FOREIGN KEY(MASP) REFERENCES SANPHAM(MASP)
)


CREATE TABLE HOADON 
(
MAHD CHAR(20),
MANV CHAR(20),
MAKH CHAR(20),
PRIMARY KEY(MAHD),
CONSTRAINT FK_HOADON_MANV FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV),
CONSTRAINT FK_HOADON_MAKH FOREIGN KEY(MAKH) REFERENCES KHACHHANG(MAKH),
NGAYLAPHD DATE,
PHUONGTHUCTHANHTOAN NVARCHAR(50)
)


CREATE TABLE CHITIET_HD
(
MAHD CHAR(20),
MASP CHAR(20),
PRIMARY KEY(MAHD,MASP),
CONSTRAINT FK_CHITIET_HD_MAHD FOREIGN KEY(MAHD) REFERENCES HOADON(MAHD),
CONSTRAINT FK_CHITIET_HD_MASP FOREIGN KEY(MASP) REFERENCES SANPHAM(MASP),
SOLUONG INT,
GIAMGIA FLOAT
)



SET DATEFORMAT DMY
INSERT INTO NHANVIEN
VALUES
('NV01',N'NGUYỄN VĂN A',N'TP.HCM','215464','22/12/2000','3132134543','nguyenvana@gmail.com',N'Chủ'),
('NV02',N'ĐẶNG VĂN B',N'Bình Định','2154264','12/02/1999','3132134543','dangvanb@gmail.com',N'Nhân Viên'),
('NV03',N'Trần Văn C',N'Long An','21545464','19/02/1998','3132134543','tranvanc@gmail.com',N'Nhân Viên')

INSERT INTO THANHVIEN
VALUES
('admin','123','NV01'),
('aa','123','NV02'),
('bb','123','NV03')


INSERT INTO HANGSX
VALUES 
('HSX01',N'SAMSUNG',N'Hàn Quốc'),
('HSX02',N'XIAOMI',N'Trung Quốc'),
('HSX03',N'VSMART',N'Việt Nam'),
('HSX04',N'APPLE',N'Mỹ'),
('HSX05',N'NOKIA',N'Phần Lan'),
('HSX06',N'LG',N'Hàn Quốc')


SET DATEFORMAT DMY
INSERT INTO KHACHHANG
VALUES
('KH01',N'NGUYỄN VĂN ĐÔ',N'TÂY NINH','3213130311','22/11/1997','vando@gmail.com'),
('KH02',N'PHẠM THỊ NGỌC MAI',N'LÂM ĐỒNG','13130123','20/10/2000','ngocmai@gmail.com'),
('KH03',N'VÕ CÔNG CHẨN',N'BÌNH ĐỊNH','9874356','27/04/2000','congchan@gmail.com')


INSERT INTO SANPHAM
VALUES
('SP01','Xiaoni Mi6x','HSX02','5000000','3',N'Trung Quốc','12'),
('SP02','Vsmart Aris Pro','HSX03','6990000','4',N'Việt Nam','18'),
('SP03','iPhone 12 Pro Max','HSX04','31990000','5',N'Mỹ','24'),
('SP04','Samsung Galaxy S21 5G','HSX01','18990000','3',N'Hàn Quốc','6'),
('SP05','Iphone 7 plus','HSX04','12000000','5',N'Hàn Quốc','6'),
('SP06','Samsung Galaxy A32','HSX01','5400000','1',N'Hàn Quốc','6'),
('SP07','Xiaomi Mi 11 Lite 5G','HSX02','8900000','4',N'Hàn Quốc','12'),
('SP08','Samsung Galaxy A52','HSX01','5700000','10',N'Hàn Quốc','6'),
('SP09','Oppo Reno5','HSX02','8200000','3',N'Hàn Quốc','6'),
('SP10','Xiaomi Redmi 9T','HSX02','4300000','3',N'Hàn Quốc','6'),
('SP11','Xiaomi Mi 10T Pro','HSX02','3200000','5',N'Hàn Quốc','12'),
('SP12','iPhone 11 128GB','HSX04','18000000','2',N'Hàn Quốc','12'),
('SP13','Iphone 8 64GB','HSX04','12000000','1',N'Hàn Quốc','6'),
('SP14','Iphone 7 128GB','HSX04','11000000','4',N'Hàn Quốc','6'),

('SP17','Vsmart Joy 4','HSX03','3200000','7',N'Hàn Quốc','6'),
('SP18','Samsung Galaxy A02s','HSX01','4300000','1',N'Hàn Quốc','6'),
('SP19','Vsmart Joy 4 4GB','HSX03','5400000','1',N'Hàn Quốc','6'),
('SP20','Vsmart Star 5','HSX03','3400000','1',N'Hàn Quốc','6')


INSERT INTO CHITIET_SP
VALUES
('SP01','HSX02','158.7','75.4','7.3','166','5.99','4G','64G',N'Android 8.1 (Oreo), upgradable to Android 9.0 (Pie), Android One',N'Chipset:	Qualcomm SDM660 Snapdragon 660 (14 nm),CPU:	Octa-core (4x2.2 GHz Kryo 260 Gold & 4x1.8 GHz Kryo 260 Silver)'),
('SP02','HSX03','156.2','75.04','8.55','178','6.39','8G','128G',N'Android 10',N'Chip xử lý (CPU):Snapdragon 730, Tốc độ CPU:2 nhân 2.2 GHz & 6 nhân 1.8 GHz'),
('SP03','HSX04','160.8','78.1','7.4','228','6.7','4G','64G','iOS 14',N'Chip xử lý (CPU): Apple A14 Bionic, Tốc độ CPU:2 nhân 3.1 GHz & 4 nhân 1.8 GHz'),
('SP04','HSX01','151.7','71.2','7.9','169','6.2','3G','32G',N'Android 11, One UI 3.1',N'Chipset	Exynos 2100 (5 nm) - International, Qualcomm SM8350 Snapdragon 888 5G (5 nm) - USA/China, CPU: Octa-core (1x2.9 GHz Cortex-X1 & 3x2.80 GHz Cortex-A78 & 4x2.2 GHz Cortex-A55) - International, Octa-core (1x2.84 GHz Kryo 680 & 3x2.42 GHz Kryo 680 & 4x1.80 GHz Kryo 680) - USA/China'),
('SP05','HSX04','160.8','78.1','7.4','228','6.7','4G','64G','iOS 14',N'Chip xử lý (CPU): Apple A14 Bionic, Tốc độ CPU:2 nhân 3.1 GHz & 4 nhân 1.8 GHz'),
('SP06','HSX01','151.7','71.2','7.9','169','6.2','3G','32G',N'Android 11, One UI 3.1',N'Chipset	Exynos 2100 (5 nm) - International, Qualcomm SM8350 Snapdragon 888 5G (5 nm) - USA/China, CPU: Octa-core (1x2.9 GHz Cortex-X1 & 3x2.80 GHz Cortex-A78 & 4x2.2 GHz Cortex-A55) - International, Octa-core (1x2.84 GHz Kryo 680 & 3x2.42 GHz Kryo 680 & 4x1.80 GHz Kryo 680) - USA/China'),
('SP07','HSX02','158.7','75.4','7.3','166','5.99','4G','64G',N'Android 8.1 (Oreo), upgradable to Android 9.0 (Pie), Android One',N'Chipset:	Qualcomm SDM660 Snapdragon 660 (14 nm),CPU:	Octa-core (4x2.2 GHz Kryo 260 Gold & 4x1.8 GHz Kryo 260 Silver)'),
('SP08','HSX01','151.7','71.2','7.9','169','6.2','3G','32G',N'Android 11, One UI 3.1',N'Chipset	Exynos 2100 (5 nm) - International, Qualcomm SM8350 Snapdragon 888 5G (5 nm) - USA/China, CPU: Octa-core (1x2.9 GHz Cortex-X1 & 3x2.80 GHz Cortex-A78 & 4x2.2 GHz Cortex-A55) - International, Octa-core (1x2.84 GHz Kryo 680 & 3x2.42 GHz Kryo 680 & 4x1.80 GHz Kryo 680) - USA/China'),
('SP09','HSX02','158.7','75.4','7.3','166','5.99','4G','64G',N'Android 8.1 (Oreo), upgradable to Android 9.0 (Pie), Android One',N'Chipset:	Qualcomm SDM660 Snapdragon 660 (14 nm),CPU:	Octa-core (4x2.2 GHz Kryo 260 Gold & 4x1.8 GHz Kryo 260 Silver)'),
('SP10','HSX02','158.7','75.4','7.3','166','5.99','4G','64G',N'Android 8.1 (Oreo), upgradable to Android 9.0 (Pie), Android One',N'Chipset:	Qualcomm SDM660 Snapdragon 660 (14 nm),CPU:	Octa-core (4x2.2 GHz Kryo 260 Gold & 4x1.8 GHz Kryo 260 Silver)'),
('SP11','HSX02','158.7','75.4','7.3','166','5.99','4G','64G',N'Android 8.1 (Oreo), upgradable to Android 9.0 (Pie), Android One',N'Chipset:	Qualcomm SDM660 Snapdragon 660 (14 nm),CPU:	Octa-core (4x2.2 GHz Kryo 260 Gold & 4x1.8 GHz Kryo 260 Silver)'),
('SP12','HSX04','160.8','78.1','7.4','228','6.7','4G','64G','iOS 14',N'Chip xử lý (CPU): Apple A14 Bionic, Tốc độ CPU:2 nhân 3.1 GHz & 4 nhân 1.8 GHz'),
('SP13','HSX04','160.8','78.1','7.4','228','6.7','4G','64G','iOS 14',N'Chip xử lý (CPU): Apple A14 Bionic, Tốc độ CPU:2 nhân 3.1 GHz & 4 nhân 1.8 GHz'),
('SP14','HSX04','160.8','78.1','7.4','228','6.7','4G','64G','iOS 14',N'Chip xử lý (CPU): Apple A14 Bionic, Tốc độ CPU:2 nhân 3.1 GHz & 4 nhân 1.8 GHz'),
('SP17','HSX03','156.2','75.04','8.55','178','6.39','8G','128G',N'Android 10',N'Chip xử lý (CPU):Snapdragon 730, Tốc độ CPU:2 nhân 2.2 GHz & 6 nhân 1.8 GHz'),
('SP18','HSX01','151.7','71.2','7.9','169','6.2','3G','32G',N'Android 11, One UI 3.1',N'Chipset	Exynos 2100 (5 nm) - International, Qualcomm SM8350 Snapdragon 888 5G (5 nm) - USA/China, CPU: Octa-core (1x2.9 GHz Cortex-X1 & 3x2.80 GHz Cortex-A78 & 4x2.2 GHz Cortex-A55) - International, Octa-core (1x2.84 GHz Kryo 680 & 3x2.42 GHz Kryo 680 & 4x1.80 GHz Kryo 680) - USA/China'),
('SP19','HSX03','156.2','75.04','8.55','178','6.39','8G','128G',N'Android 10',N'Chip xử lý (CPU):Snapdragon 730, Tốc độ CPU:2 nhân 2.2 GHz & 6 nhân 1.8 GHz'),
('SP20','HSX03','156.2','75.04','8.55','178','6.39','8G','128G',N'Android 10',N'Chip xử lý (CPU):Snapdragon 730, Tốc độ CPU:2 nhân 2.2 GHz & 6 nhân 1.8 GHz')


SET DATEFORMAT DMY
INSERT INTO HOADON
VALUES
('HD01','NV03','KH01',getdate(),N'THANH TOÁN QUA MOMO'),
('HD02','NV01','KH02','12/12/2021',N'THANH TOÁN KHI NHẬN HÀNG'),
('HD03','NV03','KH03','16/09/2020',N'THANH TOÁN KHI NHẬN HÀNG'),
('HD04','NV01','KH02','14/07/2021',N'THANH TOÁN KHI NHẬN HÀNG'),
('HD05','NV03','KH01','22/08/2020',N'THANH TOÁN NHẬN HÀNG'),
('HD06','NV02','KH03','28/07/2021',N'THANH TOÁN NHẬN HÀNG')


INSERT INTO CHITIET_HD
VALUES
('HD01','SP01','4',''),
('HD01','SP02','2',''),
('HD01','SP03','1',''),
('HD02','SP01','1',''),
('HD02','SP03','1',''),
('HD03','SP02','1',''),
('HD03','SP03','1',''),
('HD04','SP01','1','')

select count(*) from THANHVIEN where TAIKHOAN='duy'
select count(*) from thanhvien where manv='NV0264'

