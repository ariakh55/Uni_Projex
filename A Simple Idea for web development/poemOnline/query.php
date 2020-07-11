<?php
require_once('dbcon.php');

mysqli_query($conn, "SET NAMES utf8");

$poemsql = "SELECT * FROM poem";
$booksql = "SELECT * FROM book";
$authorsql = "SELECT * FROM author"

?>