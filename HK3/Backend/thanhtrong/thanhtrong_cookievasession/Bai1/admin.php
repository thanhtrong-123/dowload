<?php
    session_start();
 ?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>admin</title>
</head>
<body>
    <?php
        if(isset($_SESSION['user'])){
            echo "Xin Chao " . $_SESSION['user'];
            $link_logout = 'logout.php';
            echo "<a href='$link_logout'><br>Logout</a>";
        }
        else{   
            header('location: login.php');
        }
    ?>
</body>
</html>