<?php

$input = [1, 2, 3, 4, 5, 7, 8, 9, 10, 14,15,16,18,22,6];

sort($input);
$range = [];
$min = $input[0];
$max = $input[0];

for ($i = 1; $i < count($input); $i++) {
    if ($input[$i] == $max + 1) {
        $max = $input[$i];
    } else {
        if ($min != $max) {
            $range[] = $min . '-' . $max;
        } else {
            $range[] = $min;
        }
        $min = $input[$i];
        $max = $input[$i];
    }
}

if ($min != $max) {
    $range[] = $min . '-' . $max;
} else {
    $range[] = $min;
}

echo implode(',', $range);

?>
