<?php
require_once "../core/autoload.php";

class Departments extends Controller {
	function __construct() {
        parent::__construct();
	}

	protected function get() {
		global $db;
		
		$query = $db->prepare('
			SELECT *
			FROM departments
		');
		$query->execute();
		$departments = $query->fetchAll(PDO::FETCH_CLASS);

		return json_encode($departments);
	}
}

new Departments();