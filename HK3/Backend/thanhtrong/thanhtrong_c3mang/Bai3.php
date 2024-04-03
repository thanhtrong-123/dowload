<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>bai_3</title>
</head>
<body>
    <?php
    if(isset($_GET['submit'])){
        $name = $_GET['name'];
        $email =$_GET['email'];
        $website = $_GET['website'];
        $comment = $_GET['comment'];
        $gender = $_GET['gender'];
    }
    else{
        $name = "";
        $email ="";
        $website ="";
        $comment ="";
        $gender ="";
    }
    ?>
    
    <form action="" method="get">
    Name: <input type="text" name="name" require value="<?php echo $name?>">
    <br> <br>
    E-mail: <input type="text" name="email" require value="<?php echo $email?>">
    <br> <br>
    Website: <input type="text" name="website" require value="<?php echo $website?>">
    <br> <br>
    Comment: <textarea name="comment" require rows="5" cols="40"><?php echo $comment ?></textarea>
    <br> <br>
    Gender:
    <input type="radio" name="gender"
    <?php if (isset($gender) && $gender=="Male") echo "checked";?> value="Male"checked>Male
    <input type="radio" name="gender"
    <?php if (isset($gender) && $gender=="Female") echo "checked";?> value="Female" >Female
    
<br> <br>
<button type="submit" name='submit'>Submit</button>
</form>
<table border="1", cellspacing="0">
    <br>
<td>
<?php
if(isset($_GET['submit'])){
    $name = $_GET['name'];
    $email =$_GET['email'];
    $website = $_GET['website'];
    $comment = $_GET['comment'];
    $gender = $_GET['gender'];
}


if(isset ($_GET['submit'])){
    echo "Name: ".$_GET['name']."<br>";
    echo "Email: ".$_GET['email']."<br>";
    echo "Website: ".$_GET['website']."<br>";
    echo "Comment: ".$_GET['comment']."<br>";
    echo "Gender: ".$_GET['gender']."<br>";
}
?>
</td>
</table>

<style>
    body{
        margin:50px 600px;
        background: rgb(206 205 107);
    }
    table{
        background: #fff;
    }
    
</style>
</body>
</html>