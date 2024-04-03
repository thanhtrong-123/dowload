<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>bai3</title>
</head>
<body>
<p style=" margin-left: 100px;">PHÉP TÍNH</p>
<form action="" method="post">
    <p>Số Thứ 1: <input type="text" name="sothunhat" value=""></p>
    <p>Số Thứ 2: <input type="text" name="sothuhai" value=""></p>
    <p>Chọn phép tính</p>
    <table>
            <input type="radio" name="pheptinh" value="+">
            <label for="+">Cộng</label>
            <input type="radio" name="pheptinh" value="-">
            <label for="-">Trừ</label>
            <input type="radio" name="pheptinh" value="*">
            <label for="*">Nhân</label>
            <input type="radio" name="pheptinh" value="/">
            <label for="/">Chia</label>
    </table>
    <p><button style=" margin-left: 100px;" type="submit" >Gửi</button></p>
</form>
    <?php
        function math($pt,$a,$b){
            if($pt=='+'){
              return $a + $b;
            } 
            else if($pt=='-'){
              return $a - $b;
            } 
            else if($pt=='*'){
              return $a * $b; 
            } 
            else if($pt=='/'){
                if($b != 0){
                    return $a / $b;
                }
                else{
                    echo 'Không thể chia cho 0'."<br>";
                }
            }
        }
            if(isset($_POST['pheptinh']))
            {
                $a = $_POST['sothunhat'];
                $b = $_POST['sothuhai'];
                $pt = $_POST['pheptinh'];
                if($pt=='+'){
                   $kq = math($pt,$a,$b);
                   echo 'Kết quả phép cộng: '.$kq;
                  } else if($pt=='-'){
                    $kq = math($pt,$a,$b);
                    echo 'Kết quả phép trừ: '.$kq;
                  } else if($pt=='*'){
                    $kq = math($pt,$a,$b);
                   echo 'Kết quả phép nhân: '.$kq;
                  } else if($pt=='/'){
                    $kq = math($pt,$a,$b);
                    echo 'Kết quả phép chia: '.$kq;
                  }
                }
    ?>
</body>
</html>