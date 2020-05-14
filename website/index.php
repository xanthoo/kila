<?php
require_once "core/core.php";
if ($user === null) {
	header('Location: login.php');
	die();
}

function processData() {
	global $db, $user, $message;

	if (isset($_POST['password']) && $_POST['password'] !== '') {
		$query = $db->prepare('
			SELECT id FROM employee WHERE id = ? && password = ?
		');

		$query->bindParam(1, $user['id']);
		$query->bindParam(2, md5($_POST['password']));

		$query->execute();

		if (!$query->rowCount()) {
			$message = 'Incorrect password.';
			return;
		}

		if ($_POST['newpassword'] !== $_POST['repeatnewpassword']) {
			$message = 'New passwords do not match.';
			return;
		}
	}

	$query = $db->prepare('
		UPDATE employee SET firstname = ?, lastname = ?, address = ? ' .
		(
			isset($_POST['newpassword']) && $_POST['newpassword'] !== ''
				? ', password = ?'
				: ''
		) .
		' WHERE id = ?
	');
	$query->bindParam(1, $_POST['firstname']);
	$query->bindParam(2, $_POST['lastname']);
	$query->bindParam(3, $_POST['address']);
	if (isset($_POST['newpassword']) && $_POST['newpassword'] !== '') {
		$query->bindParam(4, md5($_POST['newpassword']));
	}
	$query->bindParam(isset($_POST['newpassword']) && $_POST['newpassword'] !== '' ? 5 : 4, $user['id']);


	$response = $query->execute();
	
	if ($response) {
		$success = true;
		$successRedirect = 'index.php';

		unset($_POST);
		$user = fetchUser();
	} else {
		$message = 'Something went wrong. Please try again later.';
	}
}


$success = false;
$successRedirect = '';
$message = '';
if (
	isset($_POST['firstname']) &&
	isset($_POST['lastname']) &&
	isset($_POST['address']) &&
	$_POST['firstname'] !== '' &&
	$_POST['lastname'] !== '' &&
	$_POST['address'] !== '' &&
	(
		isset($_POST['password']) && $_POST['password'] !== ''
			? isset($_POST['newpassword']) && $_POST['newpassword'] !== '' &&
			  isset($_POST['repeatnewpassword']) && $_POST['repeatnewpassword'] !== ''
			: true
	)
) {
	processData();
}


require_once "includes/header.php";
?>

<div class="py-6 px-8 w-full my-auto bg-orange-200">
	<form action="" method="post">
		<div class="mb-12">
			<h1 class="text-2xl text-orange-900 text-center font-light mb-6">Your details</h1>

			<div class="grid grid-cols-2 col-gap-8">
				<label class="block mb-5">
					<span class="text-lg text-orange-900 font-light">First name</span>
					<input required type="text" name="firstname" value="<?php echo htmlspecialchars($_POST['firstname'] ?? $user['firstname'] ?? '') ?>" class="w-full bg-white focus:outline-none px-3 py-2">
				</label>
				<label class="block mb-5">
					<span class="text-lg text-orange-900 font-light">Last name</span>
					<input required type="text" name="lastname" value="<?php echo htmlspecialchars($_POST['lastname'] ?? $user['lastname'] ?? '') ?>" class="w-full bg-white focus:outline-none px-3 py-2">
				</label>
				<label class="block mb-5 col-span-2">
					<span class="text-lg text-orange-900 font-light">Address</span>
					<input required type="text" name="address" value="<?php echo htmlspecialchars($_POST['address'] ?? $user['address'] ?? '') ?>" class="w-full bg-white focus:outline-none px-3 py-2">
				</label>
			</div>
		</div>

		<div class="mb-8">
			<h1 class="text-2xl text-orange-900 text-center font-light mb-6">Security</h1>

			<div class="grid grid-cols-2 col-gap-8">
				<label class="block mb-5 col-span-2">
					<span class="text-lg text-orange-900 font-light">Current password</span>
					<input type="password" name="password" class="w-full bg-white focus:outline-none px-3 py-2">
				</label>
				<label class="block mb-5">
					<span class="text-lg text-orange-900 font-light">New password</span>
					<input type="password" name="newpassword" class="w-full bg-white focus:outline-none px-3 py-2">
				</label>
				<label class="block mb-5">
					<span class="text-lg text-orange-900 font-light">Repeat New password</span>
					<input type="password" name="repeatnewpassword" class="w-full bg-white focus:outline-none px-3 py-2">
				</label>
			</div>
		</div>

		<div class="flex justify-between items-center">
			<a href="shift.php" class="transition duration-150 ease-in-out text-center w-48 px-3 py-3 bg-orange-300 hover:bg-orange-400 text-orange-700 text-xl font-light focus:outline-none">View Shifts</a>
			<button class="transition duration-150 ease-in-out w-48 px-3 py-3 bg-orange-500 hover:bg-orange-400 text-orange-100 text-xl font-light focus:outline-none">Save changes</button>
		</div>
	</form>
</div>

<script>
	const passwordField = document.querySelector('input[name="password"]');
	const newPasswordField = document.querySelector('input[name="newpassword"]');
	const repeatNewPasswordField = document.querySelector('input[name="repeatnewpassword"]');

	passwordField.addEventListener('change', () => {
		if (passwordField.value === '') {
			newPasswordField.removeAttribute('required');
			repeatNewPasswordField.removeAttribute('required');
		} else {
			newPasswordField.setAttribute('required', true);
			repeatNewPasswordField.setAttribute('required', true);
		}
	});
</script>

<?php
require_once "includes/footer.php";
?>
