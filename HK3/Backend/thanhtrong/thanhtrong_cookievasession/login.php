<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>login</title>
</head>
<body>
    <?php
    include "ktra.php";
    ?>
    <form action="" method="post">
    Username <input type="text" name="username"><br><br>
    Password <input type="password"name="password"><br><br>
    <input type="submit"name="submit"value="submit">
    </form>

    <?php
    if(isset($_POST['submit'])){
        $username = $_POST['username'];
        $password = $_POST['password'];
        $user = new account($username,$password);
        session_start();
            $_SESSION['user'] = $username;
            header('location:admin');
    }
    ?>
</body>
</html>