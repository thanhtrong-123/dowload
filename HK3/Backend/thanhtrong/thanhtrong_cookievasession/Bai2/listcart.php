<?php
    session_start();
?>
<?php
if(isset($_SESSION['cart'])) : 
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" type="text/css" href="public/css/style.css">
    <title>listcart</title>
</head>
<body>
<h1 style=" text-align: center;">Your Cart</h1>
<table border="1" cellspacing="0">
        <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Price</th>
            <th>Quantity</th>
        </tr>
            <?php foreach($_SESSION['cart'] as $key => $val ) :?>
        <tr>
            <td><?php echo $key ?></td>
            <td><?php echo $val['name'] ?></td>
            <td><?php echo $val['qty'] ?></td>
            <td><?php echo $val['price'] ?></td>
        </tr>
        <?php endforeach ; ?>
    </table>
    <p style=" text-align: center;" ><a  href="index.php" class="addcart">Quay Lại</a></p>
<?php else :?>
    <p>Không tồn tại giỏ hàng</p>
<?php endif; ?>
</body>
</html>