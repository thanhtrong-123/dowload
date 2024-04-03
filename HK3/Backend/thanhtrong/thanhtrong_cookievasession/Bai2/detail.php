<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<meta http-equiv="X-UA-Compatible" content="IE=edge">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<title>detail</title>
	<link rel="stylesheet" type="text/css" href="public/css/style.css">
<body>
<?php
	include "products.php";
	if(isset($_GET['id'])):
		foreach($products as $value):
			if($value['id'] == $_GET['id']):
?>
	<div class='sanpham'>
		<img src='public/images/<?php echo $value['image'] ?>'>
		<h1><?php echo $value['name'] ?></h1>
		<b>Giá: </b> <span class='gia'><?php echo $value['price'] ?></span><br>
		<p><?php echo $value['desc'] ?></p>
		<a class="addcart" name="sumbit" href="addcart.php?id=<?php echo $value['id'] ?>">Add To Cart</a>
	</div>
<?php
	endif;
		endforeach;
	endif
?>
</body>
</html>