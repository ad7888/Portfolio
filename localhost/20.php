<?php
//Собственно обновление данных //Получение обновленных значений из формы
$title = $_POST['title'];
$article = $_POST[‘article’];
//Создание запроса на обновление
$update_query = "UPDATE notes SET title = '$title', article = '$article’ WHERE id =
$note_id";
//Реализация
запроса
на
$update_query); ?>