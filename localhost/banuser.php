<?php
$connection = mysqli_connect('localhost', 'ad', '1','zakaz');
$select_db = mysqli_select_db($connection, 'users');
if (isset($_POST['banuser'])) {
    $banuser = $_POST['banuser'];
    $query = "UPDATE users SET isBanned=1 WHERE username='$banuser'";
    $result = mysqli_query($connection, $query) or die(mysqli_error($connection));
    header('Location: apanel.php');
}
?>