<?php
session_start() 
?>
<?php
include "products.php";
if (isset($_GET['id'])){
    $id = $_GET['id'];
    foreach($products as $value)
    unset($_SESSION["cart"][$_GET['id']]);
    header("location:addcart.php");
} 
?>