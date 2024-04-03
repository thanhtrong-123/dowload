<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>bai_2</title>
</head>
<body>
    <form action="" method="post">
        <input type="text" name="search" placeholder ="Từ khóa...">
        <button type="submit">Tìm</button>
    </form>
    <br>
    <p>
    <?php 
    if (isset($_POST["search"])) {
        $keyword = $_POST["search"];
        echo "Kết quả tìm kiếm với từ khoá: " . $keyword;
    }
    ?>
    </p>
    <style>
        body{
                background: rgb(196 155 220);;
                margin: 50px 60px 50px 650px;
        }
        p{
            color: #00ffd5;
            font-size: 1.5em;
        }
    </style>
</body>
</html>