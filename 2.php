<?php
$s1 = "Listen";
$s2 = "Silent";
function isAnagram($s1, $s2) {

    if (strlen($s1) != strlen($s2)) {
        return false;
    }
    $chars1 = str_split(strtolower($s1));
    $chars2 = str_split(strtolower($s2));

    sort($chars1);
    sort($chars2);

    if (implode('', $chars1) == implode('', $chars2)) {
        return true;
    } else {
        return false;
    }
}

if (isAnagram($s1, $s2)) {
    echo "True";
} else {
    echo "False";
}

?>
