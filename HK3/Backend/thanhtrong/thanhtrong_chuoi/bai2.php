<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>bai2</title>
</head>
<body>
    <p style=" margin-left: 40px;">BÀI TẬP ĐỊNH DẠNG NGÀY</p>
    <form action="" method="get">
    Nhập Ngày: <input type="text" name="ngay" value=<?php echo isset($_GET['ngay'])?$_GET['ngay']:""?> >
    <p><button style=" margin-left: 100px;" type="submit" >Gửi</button></p>
    </form>

    <?php
    echo "Kết Quả"."<br>";
    if(isset($_GET['ngay'])){
        echo "Ngày đã nhập: " . $_GET['ngay'] ."<br>";
        $chuoi = explode("/",$_GET['ngay']);
        echo "a."." Ngày " . $chuoi[0] .", tháng " . $chuoi[1] ." năm ".$chuoi[2]."<br>";
        $chuyen = (implode("-",$chuoi));
        $date = date_create($chuyen);
        echo "b." . date_format($date,"l, F, jS, Y");
    }
    ?>
    
</body>
</html>