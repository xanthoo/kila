<?php
require_once "../core/autoload.php";

class Employees extends Controller {
	function __construct() {
        parent::__construct();
	}

	protected function get() {
		global $db;

		$query = $db->prepare('
			SELECT 
				E.*, 
				D.name as department_name
			FROM employees AS E
			LEFT JOIN departments AS D
			ON E.department_id = D.id;
		');
		$query->execute();
		$employees = $query->fetchAll(PDO::FETCH_CLASS);

		return json_encode($employees);
	}
}

new Employees();