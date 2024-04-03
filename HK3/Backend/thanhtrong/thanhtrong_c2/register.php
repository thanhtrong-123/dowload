<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>register</title>
</head>

<body>
    <?php
    if (isset($_POST['submit'])) {
        $user = $_POST['username'];
        $pass = $_POST['password'];
        $firs = $_POST['firstName'];
        $last = $_POST['lastName'];
        $sub = $_POST['submit'];
    }
    else{
        $user = " ";
        $pass = " ";
        $firs = " ";
        $last = " ";
    }
    ?>
    
        <form action="" method="post">
            Username: <input type="text" name="username" value="<?php echo $user?>" required>
            Password: <input type="password" name="password" required>
            FirstName: <input type="text" name="firstName" value="<?php echo $firs?>" required>
            LastName: <input type="text" name="lastName" value="<?php echo $last?>" required>
            <button type="submit" name="submit">Submit</button>
        </form>
    
    <?php include "user.php";
    if (isset($sub)){
        $user = new User($user, $pass, $firs, $last);?>
    <table border="1" , cellspacing="0">
        <tr>
            <th>Username</th>
            <th>Full name</th>
        </tr>
        <tr>
            <td><?php echo $user -> getUsername()?></td>
            <td><?php echo $user -> getFullname()?></td>
        </tr>
    </table>
    <?php } ?>
</body>

</html>