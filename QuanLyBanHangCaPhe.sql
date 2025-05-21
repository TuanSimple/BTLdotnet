CREATE DATABASE QuanLyBanHangCaPhe;
USE QuanLyBanHangCaPhe;
GO
-- create table
CREATE TABLE NhaCungCap (
    MaNhaCungCap VARCHAR(20) PRIMARY KEY,
    TenNhaCungCap NVARCHAR(50),
    DiaChi NVARCHAR(50),
    SoDienThoai CHAR(10)
);

CREATE TABLE ChucVu (
    MaChucVu VARCHAR(20) PRIMARY KEY,
    TenChucVu NVARCHAR(50),
    LuongCoBan DECIMAL(15,4)
);

CREATE TABLE Que (
    MaQue VARCHAR(20) PRIMARY KEY,
    TenQue NVARCHAR(50)
);

CREATE TABLE NhanVien (
    MaNhanVien VARCHAR(20) PRIMARY KEY,
    MaChucVu VARCHAR(20),
    MaQue VARCHAR(20),
    TenNhanVien NVARCHAR(50),
    GioiTinh CHAR(1),
    NgaySinh DATE,
    Email NVARCHAR(50),
    SoDienThoai NVARCHAR(15),
    MatKhau NVARCHAR(50),
    NgayTao DATE,
    FOREIGN KEY (MaChucVu) REFERENCES ChucVu(MaChucVu),
    FOREIGN KEY (MaQue) REFERENCES Que(MaQue)
);

CREATE TABLE Ban (
    MaBan VARCHAR(20) PRIMARY KEY,
    SoLuongGhe INT,
    TinhTrang CHAR(1)
);

CREATE TABLE KhachHang (
    MaKhachHang VARCHAR(20) PRIMARY KEY,
    TenKhachHang NVARCHAR(50),
    SoDienThoai NVARCHAR(50),
    DiemTichLuy INT
);

CREATE TABLE HoaDonNhap (
    MaHoaDonNhap VARCHAR(20) PRIMARY KEY,
    NgayNhap DATE,
    MaNhanVien VARCHAR(20),
    MaNhaCungCap VARCHAR(20),
    TongTien DECIMAL(15,4),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien),
    FOREIGN KEY (MaNhaCungCap) REFERENCES NhaCungCap(MaNhaCungCap)
);

CREATE TABLE NguyenLieu (
    MaNguyenLieu VARCHAR(20) PRIMARY KEY,
    TenNguyenLieu NVARCHAR(50),
    SoLuongHienCo INT,
    DonViTinh NVARCHAR(20)
);

CREATE TABLE ChiTietHoaDonNhap (
    MaHoaDonNhap VARCHAR(20),
    MaNguyenLieu VARCHAR(20),
    SoLuong INT,
    DonGia DECIMAL(15,4),
    ThanhTien DECIMAL(15,4),
    PRIMARY KEY (MaHoaDonNhap, MaNguyenLieu),
    FOREIGN KEY (MaHoaDonNhap) REFERENCES HoaDonNhap(MaHoaDonNhap),
    FOREIGN KEY (MaNguyenLieu) REFERENCES NguyenLieu(MaNguyenLieu)
);

CREATE TABLE Loai (
    MaLoai VARCHAR(20) PRIMARY KEY,
    TenLoai NVARCHAR(50)
);

CREATE TABLE SanPham (
    MaSanPham VARCHAR(20) PRIMARY KEY,
    TenSanPham NVARCHAR(50),
    MaLoai VARCHAR(20),
    GiaBan DECIMAL(15,4),
    HinhAnh NVARCHAR(200),
    FOREIGN KEY (MaLoai) REFERENCES Loai(MaLoai)
);

CREATE TABLE ChiTietSanPham (
    MaSanPham VARCHAR(20),
    MaNguyenLieu VARCHAR(20),
    SoLuongDung FLOAT,
    ChiPhi DECIMAL(15,4),
    PRIMARY KEY (MaSanPham, MaNguyenLieu),
    FOREIGN KEY (MaSanPham) REFERENCES SanPham(MaSanPham),
    FOREIGN KEY (MaNguyenLieu) REFERENCES NguyenLieu(MaNguyenLieu)
);

CREATE TABLE KhuyenMai (
    MaKhuyenMai VARCHAR(20) PRIMARY KEY,
    MucKhuyenMai DECIMAL(2,2),
    NgayBatDau DATE,
    NgayKetThuc DATE,
    DieuKien NVARCHAR(50)
);

CREATE TABLE HoaDonBan (
    MaHoaDonBan VARCHAR(20) PRIMARY KEY,
    NgayBan DATE,
    MaNhanVien VARCHAR(20),
    MaKhachHang VARCHAR(20),
    TongTien DECIMAL(15,4),
    MaBan VARCHAR(20),
	MaKhuyenMai VARCHAR(20),
	FOREIGN KEY (MaKhuyenMai) REFERENCES KhuyenMai(MaKhuyenMai),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien),
    FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang),
    FOREIGN KEY (MaBan) REFERENCES Ban(MaBan)
);

CREATE TABLE ChiTietHoaDonBan (
    MaHoaDonBan VARCHAR(20),
    MaSanPham VARCHAR(20),
    SoLuong INT,
    ThanhTien DECIMAL(15,4),
    PRIMARY KEY (MaHoaDonBan, MaSanPham),
    FOREIGN KEY (MaHoaDonBan) REFERENCES HoaDonBan(MaHoaDonBan),
    FOREIGN KEY (MaSanPham) REFERENCES SanPham(MaSanPham)
    
);

--create trigger cho hoa don nhap
CREATE TRIGGER trg_CalculateThanhTien_HDN
ON ChiTietHoaDonNhap
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE cthdn
    SET ThanhTien = i.SoLuong * i.DonGia
    FROM ChiTietHoaDonNhap cthdn
    INNER JOIN inserted i
        ON cthdn.MaHoaDonNhap = i.MaHoaDonNhap
        AND cthdn.MaNguyenLieu = i.MaNguyenLieu;
END;
--create trigger cho hoa don ban
CREATE TRIGGER trg_CalculateThanhTien_HDB
ON ChiTietHoaDonBan
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE ct
    SET ThanhTien = i.SoLuong * sp.GiaBan
    FROM ChiTietHoaDonBan ct
    INNER JOIN inserted i ON ct.MaHoaDonBan = i.MaHoaDonBan AND ct.MaSanPham = i.MaSanPham
    INNER JOIN SanPham sp ON i.MaSanPham = sp.MaSanPham;
END;
--create trigger cho chi phi cua chi tiet san pham
CREATE TRIGGER trg_TinhChiPhi
ON ChiTietSanPham
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE ctsp
    SET ChiPhi = i.SoLuongDung * (
        SELECT TOP 1 ctdn.DonGia
        FROM ChiTietHoaDonNhap ctdn
        WHERE ctdn.MaNguyenLieu = i.MaNguyenLieu
        ORDER BY ctdn.MaHoaDonNhap DESC -- lấy giá nhập mới nhất
    )
    FROM ChiTietSanPham ctsp
    INNER JOIN inserted i
        ON ctsp.MaSanPham = i.MaSanPham AND ctsp.MaNguyenLieu = i.MaNguyenLieu;
END;
select * from HoaDonNhap

select * from ChiTietSanPham	
-- Trigger tính TongTien cho bảng HoaDonNhap
CREATE TRIGGER trg_TinhTongTien_HoaDonNhap
ON ChiTietHoaDonNhap
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;
	alter table SanPham
	add GiaNhap decimal(15,0)
-- Cập nhật lại tổng tiền cho các hóa đơn bị ảnh hưởng
    UPDATE hdn
    SET TongTien = (
        SELECT SUM(ThanhTien)
        FROM ChiTietHoaDonNhap
        WHERE MaHoaDonNhap = hdn.MaHoaDonNhap
    )
    FROM HoaDonNhap hdn
    WHERE hdn.MaHoaDonNhap IN (
        SELECT MaHoaDonNhap FROM inserted
        UNION
        SELECT MaHoaDonNhap FROM deleted
    );
END;
-- Trigger tính TongTien cho bảng HoaDonBan
CREATE TRIGGER trg_TinhTongTien_HoaDonBan
ON ChiTietHoaDonBan
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    -- Cập nhật tổng tiền cho các hóa đơn bị ảnh hưởng
    UPDATE hdb
    SET TongTien = ISNULL((
        SELECT SUM(ThanhTien)
        FROM ChiTietHoaDonBan
        WHERE MaHoaDonBan = hdb.MaHoaDonBan
    ), 0)
    FROM HoaDonBan hdb
    WHERE hdb.MaHoaDonBan IN (
        SELECT MaHoaDonBan FROM inserted
        UNION
        SELECT MaHoaDonBan FROM deleted
    );
END;
--Nhập hàng
CREATE TRIGGER trg_CapNhatSoLuongNguyenLieu
ON ChiTietHoaDonNhap
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    -- Cộng số lượng nếu thêm
    UPDATE nl
    SET nl.SoLuongHienCo = nl.SoLuongHienCo + ISNULL(i.SoLuong, 0)
    FROM NguyenLieu nl
    INNER JOIN inserted i ON nl.MaNguyenLieu = i.MaNguyenLieu;
END;



-- Insert data for NhaCungCap
INSERT INTO NhaCungCap VALUES 
('NCC01', N'Coffee Supplier A', N'123 Đường A', '0909123456');

-- Insert data for ChucVu
INSERT INTO ChucVu VALUES 
('CV01', N'Nhân viên pha chế', 7000000),
('CV02', N'Thu ngân', 6500000);

-- Insert data for Que
INSERT INTO Que VALUES 
('Q01', N'Hà Nội'),
('Q02', N'Hồ Chí Minh');

-- Insert data for NhanVien
INSERT INTO NhanVien VALUES 
('NV01', 'CV01', 'Q01', N'Nguyễn Văn A', 'M', '1995-02-10', 'a@example.com', '0912345678', N'123456', GETDATE());

-- Insert data for Ban
INSERT INTO Ban VALUES 
('B01', 4, 0),
('B02', 2, 0);

-- Insert data for KhachHang
INSERT INTO KhachHang VALUES 
('KH01', N'Trần Thị B', '0987654321', 120);

-- Insert data for KhuyenMai
INSERT INTO KhuyenMai VALUES 
('KM01', 0.1, '2025-05-01', '2025-05-31', N'Đơn > 100K');

-- Insert data for NguyenLieu
INSERT INTO NguyenLieu VALUES 
('NL01', N'Cà phê hạt', 0, N'kg'),
('NL02', N'Sữa đặc', 0, N'lon');

-- Insert data for Loai
INSERT INTO Loai VALUES 
('L01', N'Cà phê'),
('L02', N'Trà'),
('L03', N'Đá xay'),
('L04', N'Trà sữa Macchiato'),
('L05', N'Hi-Tea Healthy'),
('L06', N'Thức uống đá viên'),
('L07', N'Bánh & Snack'),
('L08', N'Choco'),
('L09', N'Nước ép'),
('L10', N'Thức uống mới');

-- Insert data for SanPham
INSERT INTO SanPham VALUES 
('SP01', N'Cà phê đen', 'L01', 20000, N'cfd.jpg'),
('SP02', N'Cà phê sữa', 'L01', 25000, N'cfs.jpg'),
('SP03', N'Latte đá', 'L01', 45000, N'latte_da.jpg'),
('SP04', N'Caramel Macchiato', 'L01', 49000, N'caramel_macchiato.jpg'),
('SP05', N'Cold Brew Truyền Thống', 'L01', 39000, N'coldbrew.jpg'),
('SP06', N'Trà Đào Cam Sả', 'L02', 49000, N'tra_dao_cam_sa.jpg'),
('SP07', N'Trà Oolong Vải', 'L02', 49000, N'tra_oolong_vai.jpg'),
('SP08', N'Trà Sen Vàng', 'L02', 45000, N'tra_sen_vang.jpg'),
('SP09', N'Trà Đen Macchiato', 'L04', 49000, N'tra_den_macchiato.jpg'),
('SP10', N'Trà Sữa Oolong Nướng', 'L04', 49000, N'tra_sua_oolong.jpg'),
('SP11', N'Hi-Tea Yuzu Trà Xanh', 'L05', 49000, N'hitea_yuzu.jpg'),
('SP12', N'Hi-Tea Đào Kombucha', 'L05', 49000, N'hitea_kombucha.jpg'),
('SP13', N'Chocolate Nóng', 'L08', 45000, N'chocolate_nong.jpg'),
('SP14', N'Choco Macchiato', 'L08', 49000, N'choco_macchiato.jpg'),
('SP15', N'Đá xay Socola', 'L03', 59000, N'daxay_socola.jpg'),
('SP16', N'Đá xay Trà Xanh', 'L03', 59000, N'daxay_traxanh.jpg'),
('SP17', N'Trà Xanh Latte', 'L02', 49000, N'traxanh_latte.jpg'),
('SP18', N'Trà Thạch Đào', 'L02', 45000, N'tra_thach_dao.jpg'),
('SP19', N'Trà Sữa Trân Châu', 'L04', 49000, N'tra_sua_tc.jpg'),
('SP20', N'Hi-Tea Vải Kombucha', 'L05', 49000, N'hitea_vai.jpg'),
('SP21', N'Nước Ép Cam Tươi', 'L09', 45000, N'ep_cam.jpg'),
('SP22', N'Nước Ép Dưa Hấu', 'L09', 45000, N'ep_duahau.jpg'),
('SP23', N'Sữa tươi Macchiato', 'L04', 49000, N'suatươi_macchiato.jpg'),
('SP24', N'Cà phê Muối', 'L01', 49000, N'caphemuoi.jpg'),
('SP25', N'Bánh Mousse Cacao', 'L07', 39000, N'bmousse_cacao.jpg'),
('SP26', N'Bánh Mì Gà Phô Mai', 'L07', 45000, N'banhmi_ga.jpg'),
('SP27', N'Trà Sữa Sôcôla Nướng', 'L04', 49000, N'tra_sua_socola.jpg'),
('SP28', N'Sữa Chua Dâu Đá Xay', 'L03', 59000, N'daxay_suachua_dau.jpg'),
('SP29', N'Trà Dâu Macchiato', 'L04', 49000, N'tra_dau_macchiato.jpg'),
('SP30', N'Trà Cam Xả Nhiệt Đới', 'L10', 49000, N'tra_cam_xa.jpg'),
('SP31', N'Sữa tươi đường đen', 'L06', 49000, N'suatuoi_duongden.jpg'),
('SP32', N'Trà Đào Đá Viên', 'L06', 45000, N'tra_dao_da.jpg'),
('SP33', N'Trà Chanh Sả', 'L06', 45000, N'tra_chanh_sa.jpg'),
('SP34', N'Soda Việt Quất', 'L06', 49000, N'soda_vietquat.jpg'),
('SP35', N'Soda Chanh Dây', 'L06', 49000, N'soda_chanhday.jpg');

-- Insert data for HoaDonNhap
INSERT INTO HoaDonNhap VALUES 
('HDN01', '2025-05-05', 'NV01', 'NCC01', 0);

-- Insert data for ChiTietHoaDonNhap
INSERT INTO ChiTietHoaDonNhap VALUES 
('HDN01', 'NL01', 10, 100000, 0),
('HDN01', 'NL02', 5, 20000, 0);

-- Insert data for ChiTietSanPham
INSERT INTO ChiTietSanPham VALUES 
('SP01', 'NL01', 0.02, 0),
('SP02', 'NL01', 0.015, 0),
('SP02', 'NL02', 0.01, 0);

-- Insert data for HoaDonBan
INSERT INTO HoaDonBan VALUES 
('HDB01', '2025-05-06', 'NV01', 'KH01', 0, 'B01', 'KM01');

-- Insert data for ChiTietHoaDonBan
INSERT INTO ChiTietHoaDonBan VALUES 
('HDB01', 'SP01', 2, 0),
('HDB01', 'SP02', 1, 0);

select * from SanPham

-- cập nhập chi phí trong chi tiết sản phẩm
CREATE TRIGGER trg_CapNhatChiPhi_ChiTietSanPham
ON ChiTietSanPham
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE ctsp
    SET ChiPhi = ctsp.SoLuongDung * cthdn.DonGia
    FROM ChiTietSanPham ctsp
    JOIN inserted i ON ctsp.MaSanPham = i.MaSanPham AND ctsp.MaNguyenLieu = i.MaNguyenLieu
    CROSS APPLY (
        SELECT TOP 1 cthdn.DonGia
        FROM ChiTietHoaDonNhap cthdn
        JOIN HoaDonNhap hdn ON cthdn.MaHoaDonNhap = hdn.MaHoaDonNhap
        WHERE cthdn.MaNguyenLieu = i.MaNguyenLieu
        ORDER BY hdn.NgayNhap DESC
    ) AS cthdn;
END;

-- Cập nhập giá nhập trong bảng sản phẩm
CREATE TRIGGER trg_CapNhatGiaNhap_SanPham
ON ChiTietSanPham
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    -- Danh sách sản phẩm bị ảnh hưởng
    DECLARE @AffectedSanPham TABLE (MaSanPham VARCHAR(20));

    -- Với INSERT
    INSERT INTO @AffectedSanPham (MaSanPham)
    SELECT DISTINCT MaSanPham FROM inserted;

    -- Với DELETE
    INSERT INTO @AffectedSanPham (MaSanPham)
    SELECT DISTINCT MaSanPham FROM deleted;

    -- Cập nhật lại GiaNhap = tổng ChiPhi của nguyên liệu cấu thành sản phẩm
    UPDATE sp
    SET GiaNhap = ISNULL(ct.TongChiPhi, 0)
    FROM SanPham sp
    JOIN (
        SELECT MaSanPham, SUM(ChiPhi) AS TongChiPhi
        FROM ChiTietSanPham
        GROUP BY MaSanPham
    ) ct ON sp.MaSanPham = ct.MaSanPham
    WHERE sp.MaSanPham IN (SELECT MaSanPham FROM @AffectedSanPham);
END;
-- Tự động cập nhập giá bán
CREATE TRIGGER trg_CapNhatGiaBan_SanPham
ON SanPham
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Cập nhật Giá Bán nếu Giá Nhập bị thay đổi
    UPDATE sp
    SET GiaBan = ROUND(sp.GiaNhap * 1.1, 0)  -- Làm tròn nếu cần
    FROM SanPham sp
    JOIN inserted i ON sp.MaSanPham = i.MaSanPham
    WHERE i.GiaNhap IS NOT NULL AND i.GiaNhap <> sp.GiaBan / 1.1;
END;


