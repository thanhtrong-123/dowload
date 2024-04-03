<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Document</title>
</head>
<body>
  <style>
    body 
    {
      text-align: center;
    }
  </style>
<h1>Chon ngay thang nam sinh:</h1>
    <thead>
        <tr><th>Ngày </th><th>Tháng<th>    Năm  </th></tr>
    </thead>
 
<?php 

$myArray1 = array(1, 2, 3, 4, 5, 6, 7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30); 
$myArray2 = array("January ","February ","March ","April ","May ","June ","July ","August ","September ","October ","November ","December "); 
$myArray3 = array(1990, 1991, 1992, 1993, 1994, 1995, 1996, 1997,1998, 1999, 2000, 2001, 2002, 2003, 2004, 2005,
2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020, 2021, 2022);
echo"<br>";
echo'<select name="Words">'; 
foreach($myArray1 as $word){ 
    echo'<option value="'.$word.'">'.$word.'</option>'; 
} 
echo'</select>'; 

echo'<select name="Words">'; 
foreach($myArray2 as $let=>$word){ 
    echo'<option value="'.$let.'">'.$word.'</option>'; 
} 
echo'</select>'; 
echo'<select name="Words">'; 
foreach($myArray3 as $let=>$word){ 
    echo'<option value="'.$let.'">'.$word.'</option>'; 
} 
echo'</select>'; 
?>
</body>
</html>