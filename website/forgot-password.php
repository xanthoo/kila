<?php
require_once "core/core.php";
if($_POST)
{
	if(isset($_POST['email']))
	{
	   $email = $_POST['email'];
	   $sql = "SELECT email FROM employee WHERE email = '$email' ";
	   $result = $db->prepare($sql);
	   $result = $db->query($sql);
	   if($result->rowCount()) {
		$token = "plmqazoknijbuhvygctdxsezr1234567890";
		$token = str_shuffle($token);
		$token = substr($token, 0, 10);

		$sql = "UPDATE employee SET token = '$token',
		tokenexpires = DATE_ADD(NOW(), INTERVAL 5 MINUTE)
		WHERE email = '$email'";
		
		$db->query($sql);
		$db = null;
		
		//Sending an email to the user
		$to = $email;
		
		$subject = "JUPITER - Employee password reset";
		$message = "<p>Greetings,</p><br><br>";
		$message .= "<p>We have recieved a password reset request from this email. You can click on the link below to reset your password.</p><br>";
		$message .= "<p>If you did not make this request, you can ignore this email.</p>";
		$message .= "Password reset link: <a href='http://localhost/website/reset-password.php?email=$email&token=$token'>http://localhost/website/reset-password.php?email=$email&token=$token</a>";

		$headers = "From: Jupiter <jupiterSupport@gmail.com>\r\n";
		$headers .= "Reply-To: jupiterSupport@gmail.com\r\n";
		$headers .= "Contect-type: text/html\r\n";
		mail($to, $subject, $message, $headers);
	   }
	   else
	   {
		   $message = "This email doesn't exist";
	   }
	}
}
require_once "includes/header.php";
?>
<div class="flex h-full justify-center">
	<div class="py-6 px-8 w-full my-auto bg-orange-200" style="max-width: 25rem;">
		<form action="" method="post">
			<h1 class="text-2xl text-orange-900 text-center font-light mb-6">Forgotten Password</h1>
			<label class="block mb-5">
				<span class="text-lg text-orange-900 font-light">Enter your email address</span>
				<input required type="email" name="email" value="<?php echo htmlspecialchars($_POST['email'] ?? '') ?>" class="w-full bg-white focus:outline-none px-3 py-2">
			</label>

			<div class="flex flex-col items-center">

				<button class="transition duration-150 ease-in-out w-48 px-3 py-3 bg-orange-500 hover:bg-orange-400 text-orange-100 text-xl font-light focus:outline-none">Change Password</button>
			</div>
		</form>
	</div>
</div>

<?php
require_once "includes/footer.php";
?>
