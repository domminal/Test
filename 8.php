<?php
$input =1;
$money=1000-$input;
	if($input==1000){
    echo "ไม่มีเงินทอน <br>";
    }
	if($input>1000){
    echo "Error";
    }
  if($money>=1000){
      $sum1=$money/1000;
      $sum1s=floor($sum1)*1000;
      $money=$money-$sum1s;
      echo "ธนบัตร 1,000 = ".floor($sum1)." ใบ"."<br>";
  }if($money>=500){
      $sum2=$money/500;
      $sum2s=floor($sum2)*500;
      $money=$money-$sum2s;
      echo "ธนบัตร 500 = ".floor($sum2)." ใบ"."<br>";
  }if($money>=100){
      $sum3=$money/100;
      $sum3s=floor($sum3)*100;
      $money=$money-$sum3s;
      echo "ธนบัตร 100 = ".floor($sum3)." ใบ"."<br>";
  }if($money>=50){
      $sum4=$money/50;
      $sum4s=floor($sum4)*50;
      $money=$money-$sum4s;
      echo "ธนบัตร 50 = ".floor($sum4)." ใบ"."<br>";
  }if($money>=20){
      $sum5=$money/20;
      $sum5s=floor($sum5)*20;
      $money=$money-$sum5s;
      echo "ธนบัตร 20 = ".floor($sum5)." ใบ"."<br>";
  }if($money>=10){
      $sum51=$money/10;
      $sum51s=floor($sum51)*10;
      $money=$money-$sum51s;
      echo "เหรียญ 10 = ".floor($sum51)." เหรียญ"."<br>";
  }if($money>=5){
      $sum6=$money/5;
      $sum6s=floor($sum6)*5;
      $money=$money-$sum6s;
      echo "เหรียญ 5 = ".floor($sum6)." เหรียญ"."<br>";
  }if($money>=2){
      $sum7=$money/2;
      $sum7s=floor($sum7)*2;
      $money=$money-$sum7s;
      echo "เหรียญ 2 = ".floor($sum7)." เหรียญ"."<br>";
  }if($money>=1){
      $sum8=$money/1;
      $sum8s=floor($sum8)*1;
      $money=$money-$sum8s;
      echo "เหรียญ 1 = ".floor($sum8)." เหรียญ"."<br>";
  }if($money>=0.75){            
      echo "เหรียญ 0.75 = 1 เหรียญ"."<br>";
      $money=$money-0.75;  
  }if($money>=0.50){
      $money=$money-0.50;      
      echo "เหรียญ 0.50 = 1 เหรียญ"."<br>";
  }
  ?>
