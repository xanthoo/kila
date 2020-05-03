<?php
require_once "config.php";

try {
    $db = new PDO('mysql:dbname=' . DBNAME . ';host=' . HOST, USER, PASS);
} 
catch (PDOException $e) {
    echo 'Connection failed: ' . $e->getMessage();
}

session_set_cookie_params(3600 * 5, "/");
session_start();

$user = null;
if (isset($_SESSION["userid"])) {
	$query = $db->prepare('
		SELECT id, firstname, lastname FROM employee WHERE id = ?
	');
	$query->bindParam(1, $_SESSION['userid']);
	$query->execute();

	if ($query->rowCount() === 0) {
		session_unset();
		session_regenerate_id();
	} else {
		$user = $query->fetch();
	}
}
 function redirect(){
	header('Location: index.php');
	exit();
}
?>