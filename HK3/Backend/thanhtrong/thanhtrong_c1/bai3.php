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
    echo "<table>";    
    echo "<tr>";
        for ($i=1; $i <= 3; $i++) { 
            echo "<th>Tieu De ".$i."</th>";
        }
       echo "</tr>";
       for($j=1;$j<=100;$j++)
       {
           echo "<tr>
           <td>cột 1, hàng ".$j."</td>
           <td>cột 2, hàng ".$j."</td>
           <td>cột 3, hàng ".$j."</td>
           </tr>";
       }
    echo "</table>";
    ?>
    <style>
        table{
            margin-left: 620px;
        }
        body
        {
            text-align: center;
        }
        table, th, td {
            border: 1px solid black;
            border-collapse: collapse;
        }
    </style>
</body>
</html>