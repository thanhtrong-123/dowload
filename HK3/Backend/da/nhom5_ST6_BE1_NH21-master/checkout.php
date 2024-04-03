<?php
session_start();
include "headeruser.php"; ?>
<!DOCTYPE html>
<html lang="en">

<head>
	<meta charset="utf-8">
	<meta http-equiv="X-UA-Compatible" content="IE=edge">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->

	<title>Electro - HTML Ecommerce Template</title>

	<!-- Google font -->
	<link href="https://fonts.googleapis.com/css?family=Montserrat:400,500,700" rel="stylesheet">

	<!-- Bootstrap -->
	<link type="text/css" rel="stylesheet" href="css/bootstrap.min.css" />

	<!-- Slick -->
	<link type="text/css" rel="stylesheet" href="css/slick.css" />
	<link type="text/css" rel="stylesheet" href="css/slick-theme.css" />

	<!-- nouislider -->
	<link type="text/css" rel="stylesheet" href="css/nouislider.min.css" />

	<!-- Font Awesome Icon -->
	<link rel="stylesheet" href="css/font-awesome.min.css">

	<!-- Custom stlylesheet -->
	<link type="text/css" rel="stylesheet" href="css/style.css" />

	<!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
	<!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
	<!--[if lt IE 9]>
		  <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
		  <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
		<![endif]-->

</head>

<body>



	<!-- SECTION -->
	<div class="section">
		<!-- container -->
		<div class="container">
			<!-- row -->
			<div class="row">
				<form action="addorder.php?id=<?php echo $_GET['id'] ?>" method="post">
					<div class="col-md-7">
						<!-- Billing Details -->
						<div class="billing-details">
							<div class="section-title">
								<h3 class="title">Thông tin người nhận</h3>
							</div>
							<?php if (isset($_SESSION['user'])) :
								$getInfoByUsername =	$user->getInfoByUsername($_SESSION['user']);
								foreach ($getInfoByUsername as $value) :
							?>
									<div class="form-group">
										<input class="input" type="text" name="full name" placeholder="Full Name" value="<?php echo $value['First_name'] . $value['Last_name'] ?>" readonly>
									</div>
									<div class="form-group">
										<input class="input" type="text" name="address" placeholder="Địa chỉ" required>
									</div>

									<div class="form-group">
										<input class="input" type="tel" name="phone" placeholder="Điện thoại" value="<?php echo $value['phone'] ?>" required>
									</div>

								<?php endforeach ?>
							<?php endif ?>
						</div>
						<!-- /Billing Details -->



						<!-- Order notes -->
						<div class="row">
							<div class="col-md-8">
								<div class="order-notes">
									<h4>Ghi chú</h4>
									<textarea style="height: 115px;" class="input" placeholder="Ghi chú" name="note"></textarea>
								</div>
							</div>
							<div class="col-md-3"><?php $getProductById = $product->getProductById($_GET['id']) ?>
								<img width="145" height="145" alt="poster_1_up" class="shop_thumbnail" src="img/<?php foreach ($getProductById as $value) {
																													echo $value['pro_image'];
																												} ?>">
							</div>
						</div>


						<!-- /Order notes -->
					</div>

					<!-- Order Details -->
					<div class="col-md-5 order-details">

						<div class="section-title text-center">
							<h3 class="title">đơn hàng của bạn</h3>
						</div>
						<div class="order-summary">
							<div class="order-col">
								<div><strong>SẢN PHẨM</strong></div>
								<div><strong>ĐƠN GIÁ</strong></div>
							</div>
							<div class="order-products">
								<?php if (isset($_SESSION['cart'])) :
									$getAllProducts =  $product->getAllProducts();
									foreach ($getAllProducts as $value) :
										if ($value['id'] == $_GET['id']) : ?>
											<div class="order-col">
												<div><?php echo $_SESSION['cart'][$value['id']] ?>x <?php echo $value['name'] ?></div>
												<div style="max-width:440px;"><?php echo number_format($value['price']) ?>VND</div>
											</div>

							</div>
							<div class="order-col">
								<div><strong>PHÍ VẬN CHUYỂN</strong></div>
								<div><strong>MIỄN PHÍ</strong></div>
							</div>
							<div class="order-col">
								<div><strong>TỔNG</strong></div>
								<div><strong class="order-total"><?php echo number_format($_SESSION['cart'][$value['id']] * $value['price']) ?>VND</strong></div>
							</div>
						</div>
			<?php
										endif;
									endforeach;

								endif
			?>

<button class="primary-btn order-submit col-lg-offset-4" type="submit" name="submit" >ĐẶT HÀNG</button>

					</div>
					<!-- /Order Details -->
				</form>
			</div>
			<!-- /row -->
		</div>
		<!-- /container -->
	</div>
	<!-- /SECTION -->

<!-- NEWSLETTER -->
<div id="newsletter" class="section">
    <!-- container -->
    <div class="container">
        <!-- row -->
        <div class="row">
            <div class="col-md-12">
                <div class="newsletter">
                    <p>Đăng Kí Để Nhận <strong>THÔNG BÁO</strong></p>
                    <form>
                        <input class="input" type="email" placeholder="Email của bạn">
                        <button class="newsletter-btn"><i class="fa fa-envelope"></i> Đăng kí</button>
                    </form>
                    <ul class="newsletter-follow">
                        <li>
                            <a href="https://www.facebook.com/"><i class="fa fa-facebook"></i></a>
                        </li>
                        <li>
                            <a href="https://twitter.com/"><i class="fa fa-twitter"></i></a>
                        </li>
                        <li>
                            <a href="https://www.instagram.com/"><i class="fa fa-instagram"></i></a>
                        </li>
                        <li>
                            <a href="https://www.pinterest.com/"><i class="fa fa-pinterest"></i></a>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
        <!-- /row -->
    </div>
    <!-- /container -->
</div>
<!-- /NEWSLETTER -->

<!-- FOOTER -->
<footer id="footer">
    <!-- top footer -->
    <div class="section">
        <!-- container -->
        <div class="container">
            <!-- row -->
            <div class="row">
                <div class="col-md-3 col-xs-6">
                    <div class="footer">
                        <h3 class="footer-title">Chúng tôi</h3>
                        <p><strong>Nhóm 5-Khóa CNC10745305-Năm học 2021</strong></p>
                        <ul class="footer-links">
                            <li><i class="fa fa-map-marker"></i>53 Võ Văn Ngân - Phường Linh Chiểu- Thành phố Thủ Đức</li>
                            <li><i class="fa fa-phone"></i>08.38970023</li>
                            <li><i class="fa fa-envelope-o"></i>fit@tdc.edu.vn</li>
                        </ul>
                    </div>
                </div>

                <div class="col-md-3 col-xs-6">
                    <div class="footer">
                        <h3 class="footer-title">thể loại</h3>
                        <ul class="footer-links">
                            <li><a href="products.php?type_id=1">Điện thoại</a></li>
                            <li><a href="products.php?type_id=2">Laptop</a></li>
                            <li><a href="products.php?type_id=3">Máy tính bảng</a></li>
                            <li><a href="products.php?type_id=4">Đồng hồ</a></li>
                            <li><a href="products.php?type_id=5">tai nghe</a></li>
                        </ul>
                    </div>
                </div>

                <div class="clearfix visible-xs"></div>

                <div class="col-md-3 col-xs-6">
                    <div class="footer">
                        <h3 class="footer-title">thông tin</h3>
                        <ul class="footer-links">
                            <li><strong>Thái Minh Hiếu</strong> - Thaihieu243@gmail.com</li>
                            <li><strong>Nguyễn Anh Vũ</strong> - Anhvu4777@gmail.com</li>
                            <li><strong>Nguyễn Anh Khoa</strong> - nguyenanhkhoaa5@gmail.com</li>
                        </ul>
                    </div>
                </div>

                <div class="col-md-3 col-xs-6">
                    <div class="footer">
                        <h3 class="footer-title">Dịch vụ</h3>
                        <ul class="footer-links">
                            <li><a href="login/index.php">Tài Khoản Của Tôi</a></li>
                            <li><a href="#">Xem Giỏ Hàng</a></li>
                            <li><a href="#">Yêu Thích</a></li>
                            <li><a href="#">Xem Đơn Hàng</a></li>
                            <li><a href="#">Giúp Đỡ</a></li>
                        </ul>
                    </div>
                </div>
            </div>
            <!-- /row -->
        </div>
        <!-- /container -->
    </div>
    <!-- /top footer -->

    <!-- bottom footer -->
    <div id="bottom-footer" class="section">
        <div class="container">
            <!-- row -->
            <div class="row">
                <div class="col-md-12 text-center">
                    <ul class="footer-payments">
                        <li><a href="#"><i class="fa fa-cc-visa"></i></a></li>
                        <li><a href="#"><i class="fa fa-credit-card"></i></a></li>
                        <li><a href="#"><i class="fa fa-cc-paypal"></i></a></li>
                        <li><a href="#"><i class="fa fa-cc-mastercard"></i></a></li>
                        <li><a href="#"><i class="fa fa-cc-discover"></i></a></li>
                        <li><a href="#"><i class="fa fa-cc-amex"></i></a></li>
                    </ul>
                    <span class="copyright">
                        <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                        Copyright &copy;<script>
                        document.write(new Date().getFullYear());
                        </script> All rights reserved | This template is made with <i class="fa fa-heart-o"
                            aria-hidden="true"></i> by <a href="https://colorlib.com" target="_blank">Colorlib</a>
                        <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                    </span>
                </div>
            </div>
            <!-- /row -->
        </div>
        <!-- /container -->
    </div>
    <!-- /bottom footer -->
</footer>
<!-- /FOOTER -->

	<!-- jQuery Plugins -->
	<script src="js/jquery.min.js"></script>
	<script src="js/bootstrap.min.js"></script>
	<script src="js/slick.min.js"></script>
	<script src="js/nouislider.min.js"></script>
	<script src="js/jquery.zoom.min.js"></script>
	<script src="js/main.js"></script>

</body>

</html>