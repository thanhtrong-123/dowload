<!DOCTYPE html>
<?php
    session_start();
    ?>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>admin</title>
</head>
<body>
    <?php
    if(isset($_SESSION['user']))
    {
        
        echo "Xin Chào\t".$_SESSION['user'];
    }
    else{
        header("location:login.php");
    }
    ?>
</body>
</html>