<!DOCTYPE html>
<?php
    session_start();
    ?>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>logout</title>
</head>
<body>
<form action="" method = "post">
<input type="submit" name ="Logout" value="Logout">
</form>
    <?php
    if(isset($_POST['Logout']))
         {
            header("location:login.php");
         }
    ?>
</body>
</html>