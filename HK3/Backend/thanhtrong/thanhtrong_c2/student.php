<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <?php
    if (isset($_POST['submit'])) {
        $user = $_POST['username'];
        $pass = $_POST['password'];
        $firs = $_POST['firstName'];
        $last = $_POST['lastName'];
        $gp = $_POST['gpa'];
        $sub = $_POST['submit'];
    }
    else{
        $user = " ";
        $pass = " ";
        $firs = " ";
        $last = " ";
        $gp = " ";
    }
    ?>
    <table>
        <form action="" method="post">
            <tr><td>Username: <input type="text" name="username" value="<?php echo $user?>" required></td></tr>
            <tr><td>Password: <input type="password" name="password" required></td></tr>
            <tr><td>FirstName: <input type="text" name="firstName" value="<?php echo $firs?>" required></td></tr>
            <tr> <td>LastName: <input type="text" name="lastName" value="<?php echo $last?>" required></td></tr>
            <tr><td>GPA: <input type="integer" name="gpa" required></td></tr>
            <tr><td><button type="submit" name="submit">Submit</button></td></tr>
        </form>
    </table>
    <?php include "user.php";
    if (isset($sub)){
        $student = new Student($user, $pass, $firs, $last, $gp);?>
    <table border="1" , cellspacing="0">
        <tr>
            <th>Username</th>
            <th>Full name</th>
            <th>GPA</th>
            <th>Rank</th>
        </tr>
        <tr>
            <td><?php echo $student -> getUsername() ?></td>
            <td><?php echo $student -> getFullname() ?></td>
            <td><?php echo $student -> getGpa() ?></td>
            <td><?php echo $student -> rank() ?></td>
        </tr>
    </table>
    <?php } ?>
    <style>
        table, th, td{
            margin: 15px;
        }
    </style>
</body>

</html>