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
    //Bai1
    define("PI",3.14);
    echo "PI =  ".PI;
    echo "<br>";
    ?>
    <?php
    //bai2
    echo "<br>";
    for ($i = 1; $i <= 30; $i++){
        if ($i % 2 != 0){
            echo "<b>$i</b>\x20";      
        }
        else {
            echo "$i\x20";
        }
    }
    ?>
    <style>
        b {color:blue;}
        body
        {
            text-align: center;
            font-size: 1.4em;
        }
    </style>
</body>
</html>