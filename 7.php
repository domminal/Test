<?php

$seconds = 60;
function to_time(int $seconds): string {

  if (!is_int($seconds)) {
    throw new InvalidArgumentException("Input must be an integer.");
  }

  $hours = floor($seconds / 3600);
  $minutes = floor($seconds / 60) % 60;
  $seconds = $seconds % 60;

  $hours = str_pad($hours, 2, "0", STR_PAD_LEFT);
  $minutes = str_pad($minutes, 2, "0", STR_PAD_LEFT);
  $seconds = str_pad($seconds, 2, "0", STR_PAD_LEFT);

  return "$hours:$minutes:$seconds";
}


echo to_time($seconds); 
?>
