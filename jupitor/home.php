<?php
session_start();

?>

<html>
<head>
<title>Home page</title>
</head>
<body>

    <a href="logout.php ">Logout</a>
   <h1>Welcome <?php echo $_SESSION['email'];?></h1> 
</body>
</html>