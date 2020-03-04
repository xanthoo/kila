<?php
require_once "config.php";
require_once "../classes/Controller.php";

try {
    $db = new PDO('mysql:dbname=' . DBNAME . ';host=' . HOST, USER, PASS);
} catch (PDOException $e) {
    echo 'Connection failed: ' . $e->getMessage();
}