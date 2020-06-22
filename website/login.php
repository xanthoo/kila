<?php
require_once "core/core.php";
if ($user !== null) {
	header('Location: index.php');
	die();
}

$success = false;
$successRedirect = '';
$message = '';
if (
	isset($_POST['email']) &&
	isset($_POST['password']) &&
	$_POST['email'] !== '' &&
	$_POST['password'] !== ''
) {
	$query = $db->prepare('
		SELECT id, firedate FROM employee WHERE email = ? && password = ?
	');
	$pw = md5($_POST['password']);
	$query->bindParam(1, $_POST['email']);
	$query->bindParam(2, $pw);

	$query->execute();
	
	if ($query->rowCount()) {
		$user = $query->fetch();
		if ($user['firedate'] !== null) {
			$message = 'You are not allowed to login.';
		} else {
			session_regenerate_id();
			$_SESSION["userid"] = $user['id'];

			$success = true;
			$successRedirect = 'index.php';
		}
	} else {
		$message = 'Incorrect login details.';
	}
}

require_once "includes/header.php";
?>

<div class="flex h-full justify-center">
	<div class="py-6 px-8 w-full my-auto bg-orange-200" style="max-width: 25rem;">
		<form action="" method="post">
			<h1 class="text-2xl text-orange-900 text-center font-light mb-6">Login</h1>

			<label class="block mb-5">
				<span class="text-lg text-orange-900 font-light">Email address</span>
				<input required type="email" name="email" value="<?php echo htmlspecialchars($_POST['email'] ?? '') ?>" class="w-full bg-white focus:outline-none px-3 py-2">
			</label>
			<label class="block mb-1">
				<span class="text-lg text-orange-900 font-light">Password</span>
				<input required type="password" name="password" class="w-full bg-white focus:outline-none px-3 py-2">
			</label>

			<div class="flex flex-col items-center">
				<a href="forgot-password.php" class="block transition duration-150 ease-in-out text-orange-700 hover:text-orange-600 font-light text-center mb-3">Forgot password</a>

				<button class="transition duration-150 ease-in-out w-48 px-3 py-3 bg-orange-500 hover:bg-orange-400 text-orange-100 text-xl font-light focus:outline-none">Login</button>
			</div>
		</form>
	</div>
</div>

<?php
require_once "includes/footer.php";
?>