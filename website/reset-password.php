<?php 
require_once "core/core.php";
require_once "includes/header.php";
if (isset($_POST['resetButton'])) {

if(isset($_GET['email']) && isset($_GET['token']))
{ 
    $email = $_GET['email'];
    $token = $_GET['token'];
    $newPassword = $_POST['password'];
    $confirmPass = $_POST['confirmPass'];
    
    $sql = "SELECT id FROM employee WHERE email = '$email' AND 
    token = '$token' AND token <> '' AND tokenexpires > NOW()";
    $result = $db->prepare($sql);
    $result = $db->query($sql);
    if($result->rowCount() > 0)
    {
        if($newPassword === $newPassword)
        {
        $db ->query("UPDATE employee SET password = '$newPassword', token = ''
        WHERE email = '$email'");
        $message = "Password has been reset! Redirecting...";
        redirect();
        }
        else
        {
            $message = "The passwords don't match!";
        }
    }
    else{
        redirect();
    }
}
else
{
    redirect();
}
}
?>
<div class="flex h-full justify-center">
	<div class="py-6 px-8 w-full my-auto bg-orange-200" style="max-width: 25rem;">
		<form action="" method="post">
			<h1 class="text-2xl text-orange-900 text-center font-light mb-6">Reset Password</h1>

			<label class="block mb-1">
				<span class="text-lg text-orange-900 font-light">New Password</span>
				<input required type="password" name="password" class="w-full bg-white focus:outline-none px-3 py-2">
			</label>
			<label class="block mb-1">
				<span class="text-lg text-orange-900 font-light">Confirm New Password</span>
				<input required type="password" name="confirmPass" class="w-full bg-white focus:outline-none px-3 py-2">
			</label>

			<div class="flex flex-col items-center">
				<button name= "resetButton" class="transition duration-150 ease-in-out w-48 px-3 py-3 bg-orange-500 hover:bg-orange-400 text-orange-100 text-xl font-light focus:outline-none">Reset My Password</button>
			</div>
		</form>
	</div>
</div>
<?php
require_once "includes/footer.php";
?>
