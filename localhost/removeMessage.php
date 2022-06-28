<?php
session_start();
require('connection.php');
if (isset($_SESSION['username'])) {
    $username = $_SESSION['username'];
    $query = "UPDATE users SET isMessage=0 WHERE username='$username'";
    $result = mysqli_query($connection, $query) or die(mysqli_error($connection));
    header('Location: cabinet.php');
}
?>