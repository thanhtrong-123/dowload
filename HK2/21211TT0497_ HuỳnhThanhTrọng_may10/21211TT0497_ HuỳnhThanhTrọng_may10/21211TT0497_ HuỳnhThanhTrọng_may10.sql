--tao db KQMonHoc
create database QL_KQMonHoc

--tao tb sinh vien
create table SinhVien(
MaSV nvarchar(10)not null,
HoTen nvarchar(40),
NgaySinh smalldatetime,
MaLop nvarchar(10),
primary key(MaSV)
)

--tao tb lop
create table Lop(
MaLop nvarchar (10) not null,
TenLop nvarchar (30),
primary key(MaLop)
)

--tao tb mon hoc
create table MonHoc(
MaMH nvarchar(10) not null,
TenMH nvarchar(30),
SoTiet tinyint,
primary key(MaMH)
)

--tao tb ketqua
create table KetQua(
MaMH nvarchar(10) not null,
MaSV nvarchar(10) not null,
DiemThi float,
primary key(MaMH,MaSV)
)

--tao lien ket giua bang  ketqua va bang sinh vien
ALTER TABLE KetQua
ADD CONSTRAINT KetQua_SinhVien_MaSV
FOREIGN KEY (MaSV)
REFERENCES SinhVien(MaSV)

--tao lien ket giua bang  ketqua va bang mon hoc
ALTER TABLE KetQua
ADD CONSTRAINT KetQua_MonHoc_MaMH
FOREIGN KEY (MaMH) 
REFERENCES MonHoc(MaMH)

--tao lien ket giua bang  Lop va bang sinh vien
ALTER TABLE SinhVien
ADD CONSTRAINT SinhVien_Lop_MaLop
FOREIGN KEY (MaLop) 
REFERENCES Lop(MaLop)

--Cau c them 1 dong thong tin vao bang mon hoc
INSERT INTO MonHoc (MaMH, TenMH, SoTiet)
VALUES ('CSDL', N'C? s? d? li?u', 75)

--Cau d cap nhat lai thongtin ngay sinh cho dinh vien SV01
UPDATE SinhVien
SET NgaySinh = '2000-01-01'
WHERE MaSV = 'SV01';

--cau e liet ke thong tin cua sinh vien co ma lop L1
SELECT *
FROM SinhVien
WHERE MaLop = 'LP';

--cau f liet ke thong tin cua sinh vien co ma lop Lap trinh 2
SELECT *
FROM SinhVien
WHERE MaLop IN (SELECT MaLop FROM Lop WHERE TenLop = 'L?p trình 2');

-- cau g liet ke moi lop co bao nhieu thong tin gom ten lop so luong sinh vien cua moi lop
SELECT L.TenLop, COUNT(S.MaSV) AS SoLuongSinhVien
FROM Lop L
JOIN SinhVien S ON L.MaLop = S.MaLop
GROUP BY L.TenLop;

--cau h liet ke sinh vien hoc cung voi sinh viej co ma Sv01
SELECT *
FROM SinhVien
WHERE MaLop IN (SELECT MaLop FROM SinhVien WHERE MaSV = 'SV01');

