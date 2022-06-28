<pre>
<?php
$connection = mysqli_connect('localhost', 'ad', '1','zakaz');
$select_db = mysqli_select_db($connection, 'users'); 
if (isset($_POST['username']) && isset($_POST['password']) && isset($_POST['powpassword'])) {
    $username = $_POST['username'];
    $password = $_POST['password'];
    $powpassword = $_POST['powpassword'];
    var_dump($username);
    var_dump($password);
    var_dump($powpassword);
    if ($password == $powpassword){
        $query = "INSERT INTO users (username, pasword, isAdmin, isBanned, isMessage, messageTheme, messageText) VALUES ('$username', '$password', 0, 0, 0, 'none', 'none')";
        var_dump($query);
        $rs = mysqli_query($connection, $query); 
        
    }
    else {
        echo '<script language="javascript">';
        echo 'alert("Пароли не совпадают!")';
        echo '</script>';
        Reload();
    }
}
else {
    Reload();
}
function Reload() {
    $filename = "T4.html";
    $data = file_get_contents($filename);
    echo ($data);
}

?>
</pre>