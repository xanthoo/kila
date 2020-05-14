<?php
require_once "core/core.php";
if ($user === null) {
	header('Location: login.php');
	die();
}

$shifts = [];
if (isset($_GET['month']) && $_GET['month'] !== '' && isset($_GET['year']) && $_GET['year'] !== '') {
	$dateFrom = date('Y-m-d', strtotime($_GET['year'] . '-' . $_GET['month']));
	$dateTo = date('Y-m-d', strtotime(($_GET['month'] == 12 ? $_GET['year'] + 1 : $_GET['year']) . '-' . ($_GET['month'] == 12 ? 1 : $_GET['month'] + 1)));

	$query = $db->prepare('
		SELECT date, shift FROM workshift WHERE empId = ? AND date >= ? AND date < ? ORDER BY date ASC
	');
	$query->bindParam(1, $user['id']);
	$query->bindParam(2, $dateFrom);
	$query->bindParam(3, $dateTo);
	$query->execute();

	if ($query->rowCount()) {
		$shifts = $query->fetchAll();
	}
}

require_once "includes/header.php";
?>
	<div class="py-6 px-8 w-full my-auto bg-orange-200">
    <div class="mb-12">
			<h1 class="text-2xl text-orange-900 text-center font-light mb-6">Your Shifts</h1>

			<form>
			<div class="grid grid-cols-2 col-gap-8">
				<label class="block mb-5">
					<span class="text-lg text-orange-900 font-light">Year</span>
					<div class="input-group">
						<select id="year-select" name="year" class="custom-select w-full bg-white focus:outline-none px-3 py-2" id="inputGroupSelect04" aria-label="Example select with button addon">
							<option value="" <?php echo isset($_GET['year']) && $_GET['year'] === '' ? 'selected' : ''; ?>>Choose...</option>
							<option value="2019" <?php echo isset($_GET['year']) && $_GET['year'] === '2019' ? 'selected' : ''; ?> class="year">2019</option>
							<option value="2020" <?php echo isset($_GET['year']) && $_GET['year'] === '2020' ? 'selected' : ''; ?> class="year">2020</option>
							<option value="2021" <?php echo isset($_GET['year']) && $_GET['year'] === '2021' ? 'selected' : ''; ?> class="year">2021</option>
							<option value="2022" <?php echo isset($_GET['year']) && $_GET['year'] === '2022' ? 'selected' : ''; ?> class="year">2022</option>
							<option value="2023" <?php echo isset($_GET['year']) && $_GET['year'] === '2023' ? 'selected' : ''; ?> class="year">2023</option>
							<option value="2024" <?php echo isset($_GET['year']) && $_GET['year'] === '2024' ? 'selected' : ''; ?> class="year">2024</option>
							<option value="2025" <?php echo isset($_GET['year']) && $_GET['year'] === '2025' ? 'selected' : ''; ?> class="year">2025</option>
						</select>
                    </div>
				</label>
				<label class="block mb-5">
					<span class="text-lg text-orange-900 font-light ">Month</span>
                    <div class="input-group">
                 <select id="month-select" name="month" class="custom-select w-full bg-white focus:outline-none px-3 py-2" id="inputGroupSelect04" aria-label="Example select with button addon">
                    <option value="" <?php echo isset($_GET['month']) && $_GET['month'] === '' ? 'selected' : ''; ?>>Choose...</option>
                    <option value="1" <?php echo isset($_GET['month']) && $_GET['month'] === '1' ? 'selected' : ''; ?>>January</option>
                    <option value="2" <?php echo isset($_GET['month']) && $_GET['month'] === '2' ? 'selected' : ''; ?>>February</option>
                    <option value="3" <?php echo isset($_GET['month']) && $_GET['month'] === '3' ? 'selected' : ''; ?>>March</option>
                    <option value="4" <?php echo isset($_GET['month']) && $_GET['month'] === '4' ? 'selected' : ''; ?>>April</option>
                    <option value="5" <?php echo isset($_GET['month']) && $_GET['month'] === '5' ? 'selected' : ''; ?>>May</option>
                    <option value="6" <?php echo isset($_GET['month']) && $_GET['month'] === '6' ? 'selected' : ''; ?>>June</option>
                    <option value="7" <?php echo isset($_GET['month']) && $_GET['month'] === '7' ? 'selected' : ''; ?>>July</option>
                    <option value="8" <?php echo isset($_GET['month']) && $_GET['month'] === '8' ? 'selected' : ''; ?>>August</option>
                    <option value="9" <?php echo isset($_GET['month']) && $_GET['month'] === '9' ? 'selected' : ''; ?>>September</option>
                    <option value="10" <?php echo isset($_GET['month']) && $_GET['month'] === '10' ? 'selected' : ''; ?>>October</option>
                    <option value="11" <?php echo isset($_GET['month']) && $_GET['month'] === '11' ? 'selected' : ''; ?>>November</option>
                    <option value="12" <?php echo isset($_GET['month']) && $_GET['month'] === '12' ? 'selected' : ''; ?>>December</option>
                    </select>
                    </div>
				</label>
			</div>
				</form>
            <div class="py-6 px-8 w-full my-auto bg-orange-100">
            <table class="table w-full bg-orange-100 focus:outline-none px-3 py-2">
            <thead>
            <tr>
             <td class="w-1/2 text-lg text-orange-900 font-bold" >Date</td>
             <td class="w-1/2 text-lg text-orange-900 font-bold">Shift</td>  
             </tr>
             </thead>
             <tbody>
			 <?php foreach ($shifts as $shift) { ?>
				<tr>
					<td><?php echo htmlspecialchars($shift['date']); ?></td>
					<td><?php echo htmlspecialchars($shift['shift']); ?></td>
				</tr>
			 <?php } ?>
           </tbody>
         </table>
       </div>
	</div>
    <div class="flex flex-col items-right">
			<a href="index.php" class="transition duration-150 ease-in-out text-center w-48 px-3 py-3 bg-orange-300 hover:bg-orange-400 text-orange-700 text-xl font-light focus:outline-none">View Details</a>
		</div>
</div>

<script>
document.getElementById('month-select').addEventListener('change', function (event) {
	event.target.closest('form').submit();
});
document.getElementById('year-select').addEventListener('change', function (event) {
	event.target.closest('form').submit();
});
</script>

<?php
require_once "includes/footer.php";
?>
