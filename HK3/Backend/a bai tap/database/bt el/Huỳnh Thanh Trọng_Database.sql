-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1:3306
-- Thời gian đã tạo: Th10 04, 2022 lúc 01:09 PM
-- Phiên bản máy phục vụ: 5.7.36
-- Phiên bản PHP: 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Cơ sở dữ liệu: `huỳnh thanh trọng`
--

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `manufactures`
--

DROP TABLE IF EXISTS `manufactures`;
CREATE TABLE IF NOT EXISTS `manufactures` (
  `manu_id` int(11) NOT NULL AUTO_INCREMENT,
  `manu_name` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`manu_id`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `manufactures`
--

INSERT INTO `manufactures` (`manu_id`, `manu_name`) VALUES
(1, 'Huawei'),
(2, 'LG'),
(3, 'Samsung'),
(4, 'Xiaomi'),
(5, 'Sony');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `products`
--

DROP TABLE IF EXISTS `products`;
CREATE TABLE IF NOT EXISTS `products` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `manu_id` int(11) DEFAULT NULL,
  `type_id` int(11) DEFAULT NULL,
  `price` int(11) NOT NULL,
  `image` varchar(150) COLLATE utf8_unicode_ci DEFAULT NULL,
  `description` text COLLATE utf8_unicode_ci NOT NULL,
  `feature` tinyint(4) NOT NULL,
  `created_at` timestamp NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=38 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `products`
--

INSERT INTO `products` (`id`, `name`, `manu_id`, `type_id`, `price`, `image`, `description`, `feature`, `created_at`) VALUES
(1, 'Điện thoại Samsung Galaxy A72', 3, 1, 10490000, 'samsung-galaxy-a72-black-1020x680-org.jpg', 'Galaxy A72 cuốn hút người dùng ngay ánh nhìn đầu tiên với đường cong mềm mại, bóng bẩy. Cụm 4 camera sau nằm gọn trong mô-đun hình chữ nhật quen thuộc cùng với đèn LED flash, màu sắc của phần mô-đun và mặt lưng được thiết kế cùng màu giúp cho tổng thể trở nên đồng bộ, hài hòa hơn.', 1, '2022-11-02 17:00:00'),
(2, 'Điện thoại Samsung Galaxy S20 FE', 3, 1, 12990000, 'samsung-galaxy-s20-fan-edition-090320-040338-600x600.jpg', 'Camera trên S20 FE là 3 cảm biến chất lượng nằm gọn trong mô đun chữ nhật độc đáo ở mặt lưng bao gồm: Camera chính 12 MP cho chất lượng ảnh sắc nét, camera góc siêu rộng 12 MP cung cấp góc chụp tối đa và cuối cùng camera tele 8 MP hỗ trợ zoom quang 3X.', 1, '2022-11-02 17:00:00'),
(3, 'Điện thoại Xiaomi Redmi Note 10 Pro', 4, 1, 7490000, 'xiaomi-redmi-note-10-pro-thumb-xam-600x600-600x600.jpg', 'Xiaomi Redmi Note 10 Pro có thiết kế nguyên khối mang lại cảm giác rất đầm tay và chắc chắn, bên cạnh việc trang bị mặt kính ở hai cả hai mặt, tăng khả năng chống chịu va đập và các trầy xước không mong muốn.', 1, '2022-11-02 17:00:00'),
(4, 'Điện thoại Xiaomi Redmi 9T', 4, 1, 4990000, 'xiaomi-redmi-9t-6gb-110621-080650-600x600.jpg', 'Xiaomi duy trì sự trẻ trung trong thiết kế của mình từ Redmi 9A, Redmi 9C và đến hiện tại là Redmi 9T, chiếc điện thoại mang đến tùy chọn màu nổi bật, rất phù hợp với cá tính năng động của giới trẻ.', 1, '2022-11-02 17:00:00'),
(5, ' Điện Thoại Huawei P30 Lite', 1, 1, 5490000, 'shoppingpng.jpg', ' Chính hãng, Nguyên seal, Mới 100% Miễn phí giao hàng toàn quốc Thiết kế nguyên khối, mỏng, bo tròn Màn hình: 6.15 inch (1080 x 2312 pixels) Camera Trước/Sau: 32 MP/ 24MP + 8MP + 2MP CPU: 8 nhân (4 x Cortex-A73 2,2GHz + 4 x Cortex-A53 1,7GHz) Bộ Nhớ: 128GB RAM: 6GB Dung lượng: 4300mAh SIM tương thích: Nano SIM (2 SIM) Tính năng: Mở khóa bằng cảm biến vân tay', 1, '2022-11-02 17:00:00'),
(6, 'Điện Thoại Huawei Y9 Prime', 1, 1, 5490000, 'a3604c8a158cf2ca3983d6888d84fe07-1.jpg', 'Huawei Y9 Prime (2019) sở hữu bộ ba camera sau 16 MP, 8 MP và 2 MP. Camera chính có độ phân giải 16 MP, khẩu độ f/1.8, có chế độ quay phim ban đêm và quay chậm (slow-motion) 480 fps. Tính năng chụp góc rộng ấn tượng với ống kính 8 MP cho góc nhìn ngang lên tới 120 độ, dễ dàng ghi lại được những phong cảnh trải rộng, hùng vĩ hay chụp nhóm đông người.', 1, '2022-11-02 17:00:00'),
(7, 'LG V50S 5G Like new 99%', 2, 1, 4690000, 'shopping.jpg', 'LG V50S ThinQ bản xách tay Hàn Quốc 8GB RAM bộ nhớ trong 256GB, hỗ trợ kết nối 5G công nghệ cao. Máy cũ qua sử dụng, hình thức đẹp như mới. Thiết bị đã được đội ngũ kỹ thuật viên nhiều năm kinh nghiệm kiểm tra chất lượng cẩn thận trước khi đến tay khách hàng.', 0, '2022-11-02 17:00:00'),
(8, 'Điện thoại LG G7 ThinQ', 2, 1, 4700000, 'lg-g7-thinq-didongviet_1.jpg', 'Điện thoại LG G7 là mẫu flagship mới nhất thuộc dòng “G” Series của LG sau khi ra mắt LG V30 vào năm ngoái. Chiếc Smartphone mang đến niềm hi vọng dành lại ví trí của mình trên thị trường điện thoại khi đang dần đánh mất vào tay các hãng điện thoại Trung Quốc.', 0, '2022-11-02 17:00:00'),
(9, 'Sony XZ Premium', 5, 1, 2290000, 'untitled-1_1579236078.jpg', 'Chiếc Sony sở hữu màn hình 3840 x 2160 tuyệt đẹp với 807 ppi, với công nghệ Triluminos và HDR cho các thước phim với độ sáng cao cấp rõ ràng ngay cả trong điều kiện ngoài sáng.', 0, '2022-11-02 17:00:00'),
(10, 'Laptop LG Gram 17 ', 2, 2, 52890000, 'lg-gram-17-i7-17z90pgah76a5-3-600x600.jpg', ' LG Gram trang bị màn hình kích thước đến 17 inch nhưng lại sở hữu độ mỏng ấn tượng 17.8 mm và trọng lượng chỉ 1.35 kg, dễ dàng để bạn đặt gọn trong balo và mang theo đến mọi nơi, mọi lúc.', 1, '2022-11-02 17:00:00'),
(11, 'Laptop LG Gram 14', 2, 2, 47890000, 'lg-gram-14-i7-14z90pgah75a5-0-600x600.jpg', 'Laptop LG Gram mang kiểu dáng thanh lịch và đậm tính di động chỉ mỏng 16.8 mm và nhẹ 999 gram được làm từ hợp kim Nano Carbon - Magie, dễ dàng di chuyển hội họp hay siêu tiện lợi khi mang đi công tác xa.', 1, '2022-11-02 17:00:00'),
(12, 'Samsung Galaxy Book Flex Alpha 2', 3, 2, 20200000, 'SamsungGalaxyBook.jpg', 'Vi xử lý: Intel Core i5-1135G7, 4 nhân / 8 luồng. Màn hình: 13.3\" FHD QLED (1920 x 1080). Độ phủ màu: 100% sRGB. RAM: 8GB LDDR4X (Hàn trên bo mạch - Không thể nâng cấp). Card đồ họa: Intel Iris Xe. Lưu trữ: 256GB m.2 NVMe (Nâng cấp tối đa 2TB). Pin: 54Wh', 1, '2022-11-02 17:00:00'),
(13, 'Laptop Samsung Galaxy Book Flex Alpha', 3, 2, 21000000, '81ack-3BIlL-768x768.jpg', 'Cụ thể, Galaxy Book Flex Alpha có ngoại hình gần như không khác gì so với chiếc Galaxy Book Flex, khi nó hoàn thiện từ chất liệu nhôm, có các cạnh sắc nét và viền khá mỏng, cùng với phần bản lề có khả năng xoay 360 độ, giúp bạn có thể sử dụng máy ở nhiều tư thế khác nhau.', 1, '2022-11-02 17:00:00'),
(14, 'Xiaomi Mi Pro 14', 4, 2, 24600000, 'mi14_800x449.jpg', 'Xiaomi Mi Pro 14 2021 có thiết kế kim loại nguyên khối (hợp kim nhôm hàng không 600 series) trông khá giống với Macbook Pro với 2 màu Xám Moonstone và Bạc Crescent. Phiên bản 14 inch dày 15,6 mm.', 1, '2022-11-02 17:00:00'),
(15, 'Xiaomi Mi Pro 15', 4, 2, 28000000, 'mi15_800x450.jpg', 'Với chiếc Xiaomi Mi Pro 15 thì thiết bị cũng được cấu tạo từ hợp kim nhôm 600 series chuyên sử dụng cho công nghệ hàng không, trông giống hệt Apple MacBook Pro cùng với hai màu quen thuộc tương tự như trên phiên bản 14 inch.', 1, '2022-11-02 17:00:00'),
(16, 'Laptop Huawei Matebook 13', 1, 2, 21990000, 'laptop-huawei-matebook-13-9.jpg', 'Việc chiếc laptop Huawei Matebook này chỉ có độ mỏng là 14.9 mm, tức nghĩa là các trang bị bên trong đều được tối ưu không gian và cao cấp nhất có thể thì chúng chỉ mang trọng lượng là chưa đến 1.3kg. Việc này giúp bạn rất nhiều trong việc sử dụng trong thời gian dài và mang vác chúng đến nhiều nơi khác nhau mà không cảm thấy nặng nề', 1, '2022-11-02 17:00:00'),
(17, 'Sony Vaio SVF14328SGW', 5, 2, 16990000, 'uploaded_c7083a1f72d19a307624ced711303055.jpg', 'Laptop Sony Vaio SVF14328SGW là chiếc máy tính xách tay chạy hệ điều hành Windows 8, tốc độ xung nhịp 1.6GHz. Về khả năng hiển thị, mẫu laptop này sở hữu card đồ họa Intel được thể hiện trên kích thước màn hình 14\" độ phân giải 1366 x 768pixels. Thiết bị sở hữu ổ cứng HDD và chỉ nặng khoảng 2.2kg.', 0, '2022-11-02 17:00:00'),
(18, 'Loa bluetooth Huawei Honor AM51', 1, 3, 550000, 'loa-bluetooth-huawei-honor-am51-gia-re-7.jpg', 'Loa bluetooth Huawei Honor AM51 là mẫu loa mới nhất của Huawei ở thời điểm hiện tại. \r\nVới thiết kế nhỏ gọn tiện dụng giá rẻ nhưng vẫn đảm bảo được tính năng mà các mẫu loa cao cấp hiện tại đang có. Màng loa nhạy, tích hợp khả năng khử tiếng ồn CVC 6.0 giúp chất lượng âm thanh rõ nét. Kết nối không dây Bluetooth 4.1 rất ổn định, bán kính khoảng 10m giúp bạn có kết nối với Smartphone tốt hơn. Loa bluetooth Huawei Honor AM51 được tích hợp chống nước IPX5. Tích hợp mirco với khả năng chống ồn', 0, '2022-11-02 17:00:00'),
(19, 'Loa Bluetooth LG Xboom Go PL5 Xanh Đen', 2, 3, 3590000, 'loa-bluetooth-lg-xboom-go-pl5-xanh-den-1-1-org.jpg', 'Thiết kế đơn giản, phong cách năng động. Loa Bluetooth LG Xboom Go PL5 Xanh Đen có thiết kế hình trụ nằm ngang tạo cảm giác vừa vặn khi cầm trên tay, màu xanh đen trẻ trung năng động. Thoải mái mang chiếc loa Bluetooth này tham gia vào các bữa tiệc tại bể bơi hay ngoài trời mà không cần lo lắng bị ướt nước với chuẩn kháng nước IPX5.', 1, '2022-11-02 17:00:00'),
(20, 'Loa tháp Samsung MX-T50', 3, 3, 4990000, '10044876-loa-thap-samsung-mx-t50-1_pqcr-1p.jpg', 'Công suất đến 500W sôi động, khuấy đảo mọi cuộc vui. Bùng nổ hết mình với tính năng Bass Booster chỉ 1 nút nhấn. Khoe trọn giọng hát, tự tin tỏa sáng với tính năng Karaoke. Ứng dụng Giga Party Audio điều khiển âm nhạc dễ dàng. Hiệu ứng đèn LED DJ sặc sỡ, cho không khí thêm cuồng nhiệt.', 1, '2022-11-02 17:00:00'),
(21, 'Loa bluetooth tích hợp sạc không dây Xiaomi XMWXCLYYX01ZM', 4, 3, 1100000, 'XiaomiXMWXCLYYX01ZM.jpg', 'Loa bluetooth tích hợp sạc không dây Xiaomi XMWXCLYYX01ZM là một chiếc loa có chất âm tốt cùng với khả năng sạc nhanh không dây công suất lên đến 30W.Một sự lựa chọn tuyệt vời để sử dụng cũng như để tối ưu không gian sống của bạn.', 1, '2022-11-02 17:00:00'),
(22, 'Loa Bluetooth Sony SRS-XB13', 5, 3, 1290000, 'bluetooth-sony-srs-xb13-1-1-org.jpg', 'Thiết kế loa Bluetooth Sony đơn giản, gọn nhẹ chỉ 0.4 kg, đi kèm dây treo cho bạn dễ dàng đeo vào cổ tay của mình hoặc treo móc vào balo mang theo khi đi chơi, du lịch, đi học,... Chất liệu vỏ nhựa có thêm \r\nlớp UV coating cho độ bền cao, chống trầy xước, làm sạch nhẹ nhàng. \r\n', 1, '2022-11-02 17:00:00'),
(23, 'Tai nghe không dây Samsung Galaxy Buds 2', 3, 4, 2700000, 'samsung-galaxy-buds-2-2.jpg', 'Loa 2 chiều : chất lượng âm thanh chân thật. Chế độ chống ồn chủ động chặn tiếng ồn môi trường. Chất lượng đàm thoại rõ ràng với 3 micro. Tích hợp chế độ chơi game giảm độ trễ xuống mức thấp nhất. Dùng trong 5 giờ với 1 (bật chống ồn) , 7.5 giờ (tắt chống ồn)', 1, '2022-11-02 17:00:00'),
(24, 'Tai nghe không dây Huawei Freebuds 4', 1, 4, 3290000, 'tai-nghe-khong-day-huawei-freebuds-4-8.jpg', 'Driver 14.3mm cho trải nghiệm âm thanh chất lượng cao. Tự động chọn chế độ chống ồn phù hợp với người dùng. Chế độ giọng nói loại bỏ âm thanh bên ngoài khi ghi âm. Kết nối cùng lúc 2 thiết bị,cho phép chuyển đổi nhanh chóng. Công nghệ giảm độ trễ chỉ còn 90ms', 1, '2022-11-02 17:00:00'),
(25, 'Tai nghe không dây LG Tone Free HBS-FN4', 2, 4, 990000, '3_49.jpg', 'Thời lượng pin 6 giờ,12 giờ khi đi kèm hộp sạc. Sạc nhanh 10 phút sạc cho 1 giờ sử dụng. Chất âm trong trẻo,tôn rõ giọng ca sĩ và nhạc cụ cho các dòng nhạc trữ tình\r\nCông nghệ âm thanh chân thực đến từ Meridian. Hỗ trợ chế độ hoạt động độc lập 1 bên tai. Tuỳ chỉnh âm thanh thông qua ứng dụng LG TONE', 1, '2022-11-02 17:00:00'),
(26, 'Tai nghe Bluetooth Xiaomi Earbud Basic S', 4, 4, 450000, 'screenshot_2_19.jpg', 'Kháng nước IPX4 chống mồ hôi và nước bắn\r\n. Công nghệ khử ồn DSP cho giọng nói trong trẻo hơn khi đàm thoại. Chất âm ít Bass thích hợp cho các loại nhạc nhẹ. Trang bị gamemode giảm độ trễ khi chơi game. Có thể sử dụng độc lập mỗi bên tai', 1, '2022-11-02 17:00:00'),
(27, 'Tai nghe Bluetooth Sony Extra Bass True Wireless WF-XB700', 5, 4, 2691000, 'tai-nghe-bluetooth-true-wireless-sony-wf-xb700-xanh-1-org.jpg', 'Thiết kế không dây thời thượng, có nút đệm êm tai. Tái hiện chi tiết từng dải âm với công nghệ Extra Bass. Trang bị chuẩn kháng nước IPX4 chống thấm nước cho tai nghe hiệu quả. Tùy chỉnh nghe nhạc, gọi rảnh tay tương tác với Google Assistant, Siri tiện lợi. Thời gian sử dụng tối đa lên tới 18 tiếng. Kết nối Bluetooth 5.0 ổn định với khoảng cách xa đến 10 m.\r\n', 1, '2022-11-02 17:00:00'),
(28, 'Smart Tivi LG 55SM8100PTA', 2, 5, 14900000, 'tivi-lg-55sm8100pta.jpg', 'Tivi LG 55SM8100PTA có độ phân giải 4K sắc nét cùng công nghệ Active HDR cho hình ảnh chân thật từng chi tiết. Nâng cấp hình ảnh độ phân giải thấp lên gần bằng 4K với 4K Upscaler. Công nghệ âm thanh DTS Virtual:X mang đến âm thanh vòm sống động mạnh mẽ. Ngoài ra, tivi còn tích hợp hệ điều hành WebOS 4.5 với nhiều tiện ích thông minh và dễ sử dụng. ', 0, '2022-11-02 17:00:00'),
(29, 'Smart Tivi LG 4K 55 inch 55SM8100PTA', 2, 5, 14600000, 'smart-tivi-lg-4k-55-inch-55sm8100pta-2019.jpg', 'Smart Tivi LG 4K 55 inch 55SM8100PTA được thiết kế viền màn hình bằng thép đi kèm chân đế hình bán nguyệt giúp cho thiết kế càng thêm nổi bật hơn với cảm nhận hiện đại. Màn hình tivi rộng 55 inch rất thích hợp để bạn đặt ở phòng khách, phòng họp,... hay với những gia chủ thích xem trên một màn hình lớn.', 0, '2022-11-02 17:00:00'),
(30, 'Smart Tivi Samsung 4K Crystal UHD 75 inch UA75TU7000', 3, 5, 29900000, 'samsung-ua75tu7000-245420-105446-550x340.jpg', 'Smart Tivi Samsung 4K 75 inch UA75TU7000 với màn hình phẳng được thiết kế theo phong cách tinh giản không viền 3 cạnh cùng giải pháp giấu dây cực tiện lợi dây được ẩn gọn gàng trong chân đế mang đến \r\ncho không gian nội thất nhà bạn thêm tinh tế và đẳng cấp.', 1, '2022-11-02 17:00:00'),
(31, 'Smart Tivi Samsung 4K Crystal UHD 43 inch UA43TU8100', 3, 5, 11200000, 'samsung-ua43tu8100-240020-100024-550x340.jpg', 'Smart Tivi Samsung 4K 43 inch UA43TU8100 sở hữu thiết kế không viền 3 cạnh mang đến trải nghiệm xem trọn vẹn hình ảnh sắc nét cùng cặp chân đế chữ V úp ngược để tivi có thể đứng vững trên mọi mặt phẳng.', 0, '2022-11-02 17:00:00'),
(32, 'Android Tivi OLED Sony 4K 48 inch KD-48A9S', 5, 5, 34900000, 'sony-kd-48a9s-1-550x340.jpg', 'Màn hình OLED tăng cường màu sắc và độ tương phản ở các vùng sáng, nâng cao độ chi tiết cho từng vùng tối, vùng sáng cho màu sắc trung thực, màu đen thuần khiết, hình ảnh có chiều sâu hơn.', 1, '2022-11-02 17:00:00'),
(33, 'Tivi Xiaomi E65C Tràn Màn Hình', 4, 5, 12990000, 'tivi-xiaomi-e65a-tran-man-hinh-tivixiaomihanoi.jpg', 'Màn hình Millet E65A TRÀN MÀN HÌNH, 4K HDR với âm thanh Dolby gây sốc, giống như tạo ra một rạp chiếu phim khổng lồ trong nhà bạn, với tầm nhìn tuyệt với, không giới hạn.', 0, '2022-11-02 17:00:00'),
(34, 'Tivi Thông Minh Xiaomi Mi TV3 70-inch, 4K Utra HD', 4, 5, 43000000, 'Tivi-Thong-Minh-Xiaomi-Mi-TV3-70-inch-4K-Utra-HD.jpg', 'Đây là sản phẩm sở hữu màn hình tuyệt đẹp được cung cấp bởi Sharp có độ phân giải siêu nét 4K cùng độ mỏng của Mi TV3 đủ để khiến bạn kinh ngạc, bên cạnh đó những tính năng về âm thanh và hình ảnh cũng sẽ \r\nkhiến bạn cực kỳ hài lòng về nó', 1, '2022-11-02 17:00:00'),
(35, 'Android Tivi Sony 4K 65 inch KD-65X7500H ', 5, 5, 22900000, 'sony-kd-55x7500h-193620-103647-550x340.jpg', 'kiểu dáng thanh thoát, thoải mái và thích ứng với không gian sống hiện đại. Thiết kế \r\nviền mỏng sẽ giúp xóa mờ ranh giới giữa không gian của bạn và nội dung hiển thị, mang đến trải nghiệm xem tập trung nhất vào từng khung hình.', 0, '2022-11-02 17:00:00');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `protypes`
--

DROP TABLE IF EXISTS `protypes`;
CREATE TABLE IF NOT EXISTS `protypes` (
  `type_id` int(11) NOT NULL AUTO_INCREMENT,
  `type_name` varchar(150) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`type_id`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `protypes`
--

INSERT INTO `protypes` (`type_id`, `type_name`) VALUES
(1, 'Điện Thoại'),
(2, 'Laptop'),
(3, 'Loa'),
(4, 'Tai nghe'),
(5, 'Tivi');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
