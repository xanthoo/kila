<?php

class Controller {
	function __construct() {
		header('Content-Type: application/json');

		switch ($_SERVER['REQUEST_METHOD']) {
			case 'GET':
				echo $this->get();
				break;
			
			case 'POST':
				echo $this->post();
				break;
		
			case 'DELETE':
				echo $this->delete();
				break;
		}
	}

	protected function get() {}
	protected function post() {}
	protected function delete() {}
}