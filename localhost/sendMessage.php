<?php
$connection = mysqli_connect('localhost', 'ad', '1','zakaz');
$select_db = mysqli_select_db($connection, 'users');
if (isset($_POST['sendName']) && isset($_POST['sendTheme']) && isset($_POST['sendText'])) {
    $sendName = $_POST['sendName'];
    $sendTheme = $_POST['sendTheme'];
    $sendText = $_POST['sendText'];
    $query = "UPDATE users SET isMessage=1, messageTheme='$sendTheme', messageText='$sendText' WHERE username='$sendName'";
    $result = mysqli_query($connection, $query) or die(mysqli_error($connection));
    header('Location: apanel.php');
}
?>