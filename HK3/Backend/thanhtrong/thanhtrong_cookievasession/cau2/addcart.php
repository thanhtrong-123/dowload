<?php
session_start()
?>
<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<title>cart</title>
	<link rel="stylesheet" type="text/css" href="public/css/style.css">
	<link rel="stylesheet" href="index.php">
</head>
<body>
<a href="index.php">Trang Chủ</a>
	<h1 align = "center">Your cart</h1>
<table border="1" cellspacing="0" cellpadding="5">
	<tr>
		<th>id</th>
		<th>Name</th>
		<th>Quantity</th>
		<th>Price</th>
		<th>Action</th>
	</tr>
	<?php
	require "products.php";
	if(isset($_GET['id'])){
		if(isset($_SESSION['cart'][$_GET['id']])){
			$_SESSION['cart'][$_GET['id']]++;
		}
		else{
			$_SESSION['cart'][$_GET['id']] = 1;
		}
	}  
	foreach($products as $value)
	{
		if(isset($_SESSION['cart'][$value['id']]) && $_SESSION['cart'][$value['id']] > 0)
		{
	?>		
		<tr>
			<td><?php echo $value['id'] ?></td>
			<td><a href='detail.php?id=<?php echo $value['id']?>'><?php echo $value['name']?></a></td>
			<td><?php echo $_SESSION['cart'][$value['id']]?></td>
			<td ><?php echo $value['price']*$_SESSION['cart'][$value['id']]?></td>
			<td ><a href="xoa.php?id=<?php echo $value['id']?>">Delete</a></td>
		</tr>
		<?php
		}
	}
	?>
	</table>
</body>
</html>