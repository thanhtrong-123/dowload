<?php
    session_start();
    $id = isset($_GET['id']) ? (int)$_GET['id'] : '';
?>
<?php
	include "products.php";
	if(isset($_GET['id'])):
		foreach($products as $value):
			if($value['id'] == $_GET['id']):
?>
<?php
    //b2: kiem tra session:
    if(isset($_SESSION['cart']))
    {
        if(isset($_SESSION['cart'][$id])){
            $_SESSION['cart'][$id]['qty'] += 1;
        }
        else{
            $_SESSION['cart'][$id]['qty'] = 1;
        }
        $_SESSION['cart'][$id]['name'] = $value['name'];
        $_SESSION['cart'][$id]['price'] = $value['price'];
    }
    else
    {
        $_SESSION['cart'][$id]['qty'] = 1;
        $_SESSION['cart'][$id]['name'] = $value['name'];
        $_SESSION['cart'][$id]['price'] = $value['price'];
    }
?>
<?php
	endif;
		endforeach;
	endif;
    header("Location: listcart.php");
?>

    

