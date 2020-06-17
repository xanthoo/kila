<?php
require_once "core/core.php";
if ($user === null || $user['position'] !== 'MANAGER') {
	header('Location: login.php');
	die();
}

require_once "includes/header.php";
?>
<div class="py-8 px-8 w-full my-auto bg-orange-200">
    <div class="">
		<h1 class="text-2xl text-orange-900 text-center font-light">Generate Shifts</h1>
		<h1 class="text-orange-700 text-center font-light mb-6">Choose date from and date to</h1>

		<form action="generated-shifts.php" method="GET">
			<div class="grid grid-cols-2 col-gap-8">
				<label class="block mb-5">
					<span class="text-lg text-orange-900 font-light">From Year</span>
					<div class="input-group">
						<select required id="from-year" name="from-year" class="custom-select w-full bg-white focus:outline-none px-3 py-2" id="inputGroupSelect04" aria-label="Example select with button addon">
							
							
						<option value="">Choose...</option>
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
					<span class="text-lg text-orange-900 font-light">To Year</span>
					<div class="input-group">
						<select required id="to-year" name="to-year" class="custom-select w-full bg-white focus:outline-none px-3 py-2" id="inputGroupSelect04" aria-label="Example select with button addon">
							
							
						<option value="">Choose...</option>
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
					<span class="text-lg text-orange-900 font-light">From Month</span>
					<div class="input-group">
						<select required id="from-month" name="from-month" class="custom-select w-full bg-white focus:outline-none px-3 py-2" id="inputGroupSelect04" aria-label="Example select with button addon">
							
						<option value="">Choose...</option>
							<option value="1">January</option>
							<option value="2">February</option>
							<option value="3">March</option>
							<option value="4">April</option>
							<option value="5">May</option>
							<option value="6">June</option>
							<option value="7">July</option>
							<option value="8">August</option>
							<option value="9">September</option>
							<option value="10">October</option>
							<option value="11">November</option>
							<option value="12">December</option>
						</select>
						
					</div>
				</label>
				<label class="block mb-5">
					<span class="text-lg text-orange-900 font-light ">To Month</span>
					<div class="input-group">
						<select required id="to-month" name="to-month" class="custom-select w-full bg-white focus:outline-none px-3 py-2" id="inputGroupSelect04" aria-label="Example select with button addon">
					
						<option value="">Choose...</option>
							<option value="1">January</option>
							<option value="2">February</option>
							<option value="3">March</option>
							<option value="4">April</option>
							<option value="5">May</option>
							<option value="6">June</option>
							<option value="7">July</option>
							<option value="8">August</option>
							<option value="9">September</option>
							<option value="10">October</option>
							<option value="11">November</option>
							<option value="12">December</option>
						</select>
					</div>
				</label>
				<label class="block mb-5">
					<span class="text-lg text-orange-900 font-light">From Day</span>
					<div class="input-group">
						<select required id="from-day" name="from-day" class="custom-select w-full bg-white focus:outline-none px-3 py-2" id="inputGroupSelect04" aria-label="Example select with button addon">
						
						<option value="">Choose...</option><?php for ($i = 0; $i < 30; $i++) { ?>
								<option value="<?php echo htmlspecialchars($i + 1); ?>"><?php echo htmlspecialchars($i + 1); ?></option>
							<?php } ?>
						</select>
						
					</div>
				</label>
				<label class="block mb-5">
					<span class="text-lg text-orange-900 font-light">To Day</span>
					<div class="input-group">
						<select required id="to-day" name="to-day" class="custom-select w-full bg-white focus:outline-none px-3 py-2" id="inputGroupSelect04" aria-label="Example select with button addon">
						
						<option value="">Choose...</option><?php for ($i = 0; $i < 30; $i++) { ?>
								<option value="<?php echo htmlspecialchars($i + 1); ?>"><?php echo htmlspecialchars($i + 1); ?></option>
							<?php } ?>
						</select>
						
					</div>
				</label>
			</div>

<div class="flex flex-col items-right mt-12">
	<button type="submit" class="transition duration-150 ease-in-out text-center px-3 py-3 bg-orange-300 hover:bg-orange-400 text-orange-700 text-xl font-light focus:outline-none">Generate Pending Shifts</button>
</div>
		</form>
	</div>
</div>
<?php
require_once "includes/footer.php";
?>
