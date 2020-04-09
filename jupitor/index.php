<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://fonts.googleapis.com/css?family=Poppins&display=swap" rel="stylesheet">
    <link rel="stylesheet" href="style.css">
    <title>Jupitor</title>
</head>
<body>
    <header>
        <div class="main-header">
            <form action="validation.php" method="post">
            <h1>Login</h1>
            <hr>
            <h3>Welcome to Jupitor</h3>
            <p><input type="text" name="email"required placeholder="Email"></p>
            <p><input type="password" name="password" required placeholder="Password"></p>
            <p><button onclick="validation();">Continue</button></p>
        </div>
    </header>
</body>
</html>