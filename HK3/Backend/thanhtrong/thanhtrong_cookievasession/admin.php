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
    session_start();
    if (isset($_SESSION['user'])) {
        if ($_SESSION['user'] == "") {
            header('location:login');
        }
        else{
            echo "Welcome ".$_SESSION['user'];
        }
    }
    ?>
    <br>
    <form action="" method = "post">
        <input type="submit" name="submit" value="log out">
    </form>
    <?php
    if (isset($_POST['submit'])) {
        header('location:logout');
    }
    ?>
</body>
</html>