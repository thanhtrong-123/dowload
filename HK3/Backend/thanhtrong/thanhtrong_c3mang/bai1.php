<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>bai_1</title>
    <style>
        table, th, td {
            border: 1px solid black;
            border-collapse: collapse;
        }
    </style>
</head>
<body>
    <?php 
    $sinhvien = array(
        'sv1'=> array('TinHoc'=>10,'KTLT'=>8,'MMT'=>10),
        'sv2'=> array('TinHoc'=>8,'KTLT'=>8,'MMT'=>9),
        'sv3'=> array('TinHoc'=>9,'KTLT'=>7,'MMT'=>8)
        );
    ?>
        <table>
            <tr>
                <th class="ttt">Họ Tên</th>
                <th>Tin Học</th>
                <th>KTLT</th>
                <th>MMT</th>
            </tr>
            <?php foreach ($sinhvien as $key=>$value) { ?>
            <tr>
                <td>
                    <?php echo $key; ?>
                </td>
                <td>
                    <?php echo $value['TinHoc']; ?>
                </td>
                <td>
                    <?php echo $value['KTLT']; ?>
                </td>
                <td>
                    <?php echo $value['MMT']; ?>
                </td>
            </tr>
            <?php } ?>
        </table>
        <style>
            body{
                background: rgb(206 205 107);
                margin: 50px 60px 50px 650px;
            }
            table{
                background: #fff;
            }
        </style>
</body>
</html>