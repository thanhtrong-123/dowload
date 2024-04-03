-- phpMyAdmin SQL Dump
-- version 4.0.9
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Dec 15, 2022 at 09:26 AM
-- Server version: 5.5.34
-- PHP Version: 5.3.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `quanlynhanvien`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbchucvu`
--

CREATE TABLE IF NOT EXISTS `tbchucvu` (
  `maCV` varchar(10) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `tenCV` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbchucvu`
--

INSERT INTO `tbchucvu` (`maCV`, `tenCV`) VALUES
('TP', 'Trưởng Phòng'),
('QL', 'Quản Lý'),
('NV', 'Nhân Viên');

-- --------------------------------------------------------

--
-- Table structure for table `tbluong`
--

CREATE TABLE IF NOT EXISTS `tbluong` (
  `maNV` varchar(10) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `maBL` varchar(10) NOT NULL,
  `luongCB` float NOT NULL,
  `luongThuong` float NOT NULL,
  `heSL` float NOT NULL,
  `thang` int(11) NOT NULL,
  `nam` int(11) NOT NULL,
  `tongLT` float NOT NULL,
  `tinhTrang` int(11) NOT NULL,
  PRIMARY KEY (`maBL`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbluong`
--

INSERT INTO `tbluong` (`maNV`, `maBL`, `luongCB`, `luongThuong`, `heSL`, `thang`, `nam`, `tongLT`, `tinhTrang`) VALUES
('NV01', 'BL01', 8000000, 0, 1.2, 1, 2022, 9600000, 1),
('NV01', 'BL02', 8000000, 0, 1, 2, 2022, 8000000, 1),
('NV02', 'BL03', 6000000, 0, 1, 1, 2022, 6000000, 1),
('NV02', 'BL04', 6000000, 500000, 1.5, 2, 2022, 9500000, 1),
('NV03', 'BL05', 6000000, 0, 1, 3, 2022, 6000000, 0);

-- --------------------------------------------------------

--
-- Table structure for table `tbnhanvien`
--

CREATE TABLE IF NOT EXISTS `tbnhanvien` (
  `maNV` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `hoTen` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `namSinh` int(11) NOT NULL,
  `gioiTinh` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `diaChi` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `SDT` varchar(11) COLLATE utf8_unicode_ci NOT NULL,
  `maCV` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`maNV`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `tbnhanvien`
--

INSERT INTO `tbnhanvien` (`maNV`, `hoTen`, `namSinh`, `gioiTinh`, `diaChi`, `SDT`, `maCV`) VALUES
('NV01', 'Nguyễn Trưởng Phòng', 1980, 'Nam', 'TP.HCM', '0123456789', 'TP'),
('NV03', 'Nhữ Thanh Nữ', 1994, 'Nữ', 'Hà Nội', '0912341232', 'NV'),
('NV04', 'Nguyễn Nhân Sự', 1993, 'Nam', 'Tp.HCM', '0912341233', 'NV'),
('nv5', 'vantrong', 1, 'Nam', '2', '0911601340', 'TP');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
