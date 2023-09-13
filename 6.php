<?php
$values = [1, 2, 9, 4, 5, 8, 7, 6, 3, 10];
$count = count($values);

for ($i = 0; $i < $count - 1; $i++) {
    for ($j = $i + 1; $j < $count; $j++) {
        if ($values[$i] < $values[$j]) {
            $temp = $values[$i];
            $values[$i] = $values[$j];
            $values[$j] = $temp;
        }
    }
}

foreach ($values as $value) {
    echo $value . ' ';
}
?>
