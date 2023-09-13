<?php

$max = 4;
$start = 1;

for ($i = 1; $i <= $max; $i++) {
    $end = $start + $i - 1;
    
    for ($j = $start; $j <= $end; $j++) {
        echo $j;
        if ($j < $end) {
            echo ' ';
        }
    }
    
    if ($i < $max) {
        echo '<br>';
    }
    $start = $end + 1;
}
?>
