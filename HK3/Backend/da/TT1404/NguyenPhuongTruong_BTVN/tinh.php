<?php
//Bai1
echo"Phep tinh";
//Bai2
define("PI",3.14);
echo "<br>".PI;
echo "<br>";
//Bai3
for ($i=1; $i < 30 ; $i++) { 
    if ($i%2==0) {
        echo $i." ";
    }
    else {
        echo $i." ";
    }
}
echo"<br>";
//Bai4
for ($j=1; $j <=3 ; $j++) { 
    echo"Tiêu đề".$i;
}
echo"<br>";
for ($i=1; $i < 100; $i++) { 
    for ($j=1; $j <= 3 ; $j++) { 
        echo"cột".$j."hàng".$i." ";
    }
    echo"<br>";
}
?>