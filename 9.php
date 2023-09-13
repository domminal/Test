<?php
$sentence = "Good Morning Teacher";
$words = explode(" ", $sentence);  

$reverted_sentence = "";

foreach ($words as $word) {
    $reversed_word = "";
    $word_length = strlen($word);

    for ($i = $word_length - 1; $i >= 0; $i--) {
        $reversed_word .= $word[$i];
    }

    $reverted_sentence .= $reversed_word . " ";
}

$reverted_sentence = rtrim($reverted_sentence); 

echo "ประโยคที่ revert : " . $reverted_sentence;
?>
