<!DOCTYPE html>
<?php
    session_start();
    ?>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>login</title>
</head>
<body>
<form action=""method="post">
        Username: <input type="text"name="username"><br>
        <br>
        Password: <input type="password"name="password"><br>
        <br>
        <input type="submit" name ="submit" value="submit">
    </form>
    <?php
    require "user.php";
    if(isset($_POST['submit'])){
        if(User::login($_POST['username'],$_POST['password']))
        {
           $_SESSION['user']=$_POST['username'];
            header("location:admin.php");
        }
    }
   
    ?>
</body>
</html>