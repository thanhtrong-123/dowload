<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>login</title>
</head>

<body>
    <table>
        <form action="" method="post">
        <tr><td>Username: <input type="text" name="username" required></td></tr>
        <tr><td>Password: <input type="password" name="password" required></td></tr>
        <tr><td><button type="submit" name="submit">Submit</button></td></tr>
        </form>
    </table>
    <?php
    include "user.php";
    if (isset($_POST['submit'])) {
        if (User :: login($_POST['username'], $_POST['password'])) {
            echo "<br> Logged in successfully";
        }
    }
    ?>
</body>

</html>