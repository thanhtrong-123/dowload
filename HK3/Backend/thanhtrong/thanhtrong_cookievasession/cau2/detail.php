<?php
session_start() 
?>
<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<title>Chi tiết sản phẩm</title>
	<link rel="stylesheet" type="text/css" href="public/css/style.css">
	<link rel="stylesheet" href="index.php">
</head>
<body>
<a href="addcart.php">Tới Giỏ Hàng</a>
<a href="index.php">Trang Chủ</a>

	<?php
	include "products.php";
	if (isset($_GET['id'])){
		$id = $_GET['id'];
		foreach($products as $value){
			if($value['id'] == $id){ 
	?>
	<div class='sanpham'>
		<img src='public/images/<?php echo $value['image']?>'>
		<h1><?php echo $value['name'] ?></h1>
		<b>Giá: </b> <span class='gia'><?php echo $value['price']?></span><br>
		<p><?php echo $value['desc'] ?></p>
		<a class="addcart" href='addcart.php?id=<?php echo $value['id']?>'>Add To Cart</a>	
	</div>
	<?php
			}
		}
	}
	?>
</body>
</html>
