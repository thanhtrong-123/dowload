<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>bai1</title>
</head>
<body>
    <?php
    $txt = "Chào mừng các bạn đến với môn học Lập Trình Web Back-end 1";
    $str = (explode(" ",$txt));  
    print_r (implode("<br>",$str));
    ?>    

</body>
</html>