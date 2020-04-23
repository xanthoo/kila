<?php
require_once "core/core.php";
if ($user === null) {
	header('Location: login.php');
	die();
}

require_once "includes/header.php";
?>

Index page

<?php
require_once "includes/footer.php";
?>
