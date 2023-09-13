<?php
$input = 3;

for ($i = 1; $i <= $input; $i++) {
	echo "<center>";
    	for ($j = 1; $j <= ($input - $i) + 1; $j++) {
        	echo "*";
    	}  
    	for ($j = $input - $i; $j >= 1; $j--) {
        	echo "*";
    	}
    echo "<br>";  
}
?>

