<?php
require_once "core/core.php";
if ($user === null || $user['position'] !== 'MANAGER') {
	header('Location: login.php');
	die();
}

require_once "includes/header.php";


if (isset($_POST['shift']) && isset($_POST['employee']) && isset($_POST['date'])) {
	$query = $db->prepare('
		DELETE FROM workshift
	');
	$query->execute();

	foreach ($_POST['shift'] as $index => $shift) {
		$employee = $_POST['employee'][$index];
		$date = $_POST['date'][$index];

		$query = $db->prepare('
			INSERT INTO workshift (shift, date, empId, pending) VALUES (?, ?, ?, 0)
		');
		$query->bindParam(1, $shift);
		$query->bindParam(2, $date);
		$query->bindParam(3, $employee);
		$query->execute();
	}
	header('Location: generate-shifts.php');
	die();
}

$query = $db->prepare('
	SELECT id, firstname, lastname FROM employee
');
$query->execute();
$employees = $query->fetchAll();

$fromDate = $_GET['from-year'] . '-' . ($_GET['from-month'] <= 9 ? '0' : '') . $_GET['from-month'] . '-' . ($_GET['from-day'] <= 9 ? '0' : '') . $_GET['from-day'];
$toDate = $_GET['to-year'] . '-' . ($_GET['to-month'] <= 9 ? '0' : '') . $_GET['to-month'] . '-' . ($_GET['to-day'] <= 9 ? '0' : '') . $_GET['to-day'];
$fromTime = strtotime($fromDate);
$toTime = strtotime($toDate);

$shifts = [];
for ($day = 0; $day <= ($toTime - $fromTime) / (24 * 60 * 60); $day++) {
	$date = date('Y-m-d', $fromTime + ($day * 24 * 60 * 60));
	if (date('N', strtotime($date)) >= 6) {
		continue;
	}

	$morning = [];
	$dayShift = [];
	$afternoon = [];
	foreach ($employees as $index => $employee) {
		$query = $db->prepare('
			SELECT date, empId, shift FROM workshift WHERE date = ? AND pending = 1 AND empId = ?
		');
		$query->bindParam(1, $date);
		$query->bindParam(2, $employee['id']);
		$query->execute();
		$current = $query->fetch();

		if ($current) {
			if ($current['shift'] === 'MORNING') {
				$morning[] = $employee['id'];
			} else if ($current['shift'] === 'DAY') {
				$dayShift[] = $employee['id'];
			} else if ($current['shift'] === 'AFTERNOON') {
				$afternoon[] = $employee['id'];
			}
			continue;
		}

		if ($index % 3 === 0) {
			if (count($morning) < 2) {
				$morning[] = $employee['id'];
			} else {
				$dayShift[] = $employee['id'];
			}
		} else if ($index % 3 === 1) {
			if (count($dayShift) < 2) {
				$dayShift[] = $employee['id'];
			} else {
				$afternoon[] = $employee['id'];
			}
		} else if ($index % 3 === 2) {
			if (count($afternoon) < 2) {
				$afternoon[] = $employee['id'];
			} else {
				$morning[] = $employee['id'];
			}
		}
	}

	$shifts[$date] = [
		'MORNING' => $morning,
		'DAY' => $dayShift,
		'AFTERNOON' => $afternoon
	];
}


?>
<div class="py-8 px-8 w-full my-auto bg-orange-200">
    <div class="">
		<h1 class="text-2xl text-orange-900 text-center font-light">Generated Shifts</h1>
		<h1 class="text-orange-700 text-center font-light mb-6">
			<?php echo htmlspecialchars($fromDate); ?> - <?php echo htmlspecialchars($toDate); ?>
		</h1>

		
				<div class="py-6 px-8 w-full my-auto bg-orange-100">
				<form action="" method="POST">
            <table class="table w-full bg-orange-100 focus:outline-none px-3 py-2">
            <thead>
            <tr>
             <td class="w-1/2 text-lg text-orange-900 font-bold">Shift</td>
             <td class="w-1/2 text-lg text-orange-900 font-bold">Employee</td>  
             </tr>
             </thead>
             <tbody>
			 <?php foreach ($shifts as $date => $shifts2) { ?>
				<?php foreach ($shifts2 as $shift => $employees2) { ?>
					<?php foreach ($employees2 as $index => $employeeId) { ?>
						<tr>
							<td class="py-1 <?php echo $shift === 'AFTERNOON' && $index === count($employees2) - 1 ? 'border-b border-orange-300' : '' ?>">
								<input type="hidden" name="shift[]" value="<?php echo $shift; ?>" />
								<input type="hidden" name="date[]" value="<?php echo htmlspecialchars($date); ?>" />
								<?php echo htmlspecialchars($date); ?> | <?php echo htmlspecialchars($shift); ?>
							</td>
							<td class="py-1 <?php echo $shift === 'AFTERNOON' && $index === count($employees2) - 1 ? 'border-b border-orange-300' : '' ?>">
								<select name="employee[]" class="custom-select w-full bg-white focus:outline-none px-3 py-2">
									<?php foreach ($employees as $employee) { ?>
										<option value="<?php echo htmlspecialchars($employee['id']); ?>" <?php echo $employeeId === $employee['id'] ? 'selected="selected"' : ''; ?>>
											<?php echo htmlspecialchars($employee['firstname'] . ' ' . $employee['lastname']); ?>
										</option>
									<?php } ?>
								</select>
							</td>
						</tr>
					<?php } ?>
				<?php } ?>
			 <?php } ?>
           </tbody>
         </table>
    <div class="flex justify-between mt-12">
		<a href="generate-shifts.php" class="transition duration-150 ease-in-out text-center px-3 py-3 bg-orange-100 hover:bg-orange-200 text-orange-700 text-xl font-light focus:outline-none">Cancel</a>
		<button type="submit" class="transition duration-150 ease-in-out text-center px-3 py-3 bg-orange-300 hover:bg-orange-400 text-orange-700 text-xl font-light focus:outline-none">Confirm Shifts</button>
	</div>
         </form>
       </div>
	</div>

</div>
<?php
require_once "includes/footer.php";
?>
