<?php
    session_start();
 ?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>login</title>
</head>
<body>
<form method="post" action="login.php">
    <h2>Đăng Nhập</h2>
    <p>Username: <input type="text" name="username" value="<?php echo isset($_POST['username'])?$_POST['username']:"" ?>" ></p>
    <p>Password: <input type="password" name="password" value="<?php echo isset($_POST['password'])?$_POST['password']:"" ?>" /></p>
    <input type="submit" name="dangky" value="Đăng Nhập"/>
</form>
        <?php 
            if (isset ($_POST['username'])) {
                include "User.php";
                $user = new User($_POST['username'],$_POST['password'],NULL,NULL);
                if(($user ->login($_POST['username'],$_POST['password'])) == true )
                {
                    $_SESSION['user'] = $_POST['username'] ;
                    header('location: admin.php');
                }
         }?>
</body>
</html>