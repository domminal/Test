<?php

$arr = [1, 2, 3, 4, 5,8];
$targetSum = 8;

for ($i = 0; $i < count($arr); $i++) {
    for ($j = $i + 1; $j < count($arr); $j++) {
        if ($arr[$i] + $arr[$j] == $targetSum) {
            echo " {$arr[$i]} + {$arr[$j]} = $targetSum\n";
        }
    }
}

?>
