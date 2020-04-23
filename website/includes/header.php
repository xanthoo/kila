<!DOCTYPE html>
<html lang="en" class="h-full">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
	<link href="https://unpkg.com/tailwindcss@^1.0/dist/tailwind.min.css" rel="stylesheet">
    <title>KILR</title>
</head>
<body class="h-full">
	<div class="flex flex-col h-full pb-5">
		<header class="bg-orange-200 mb-5 px-5">
			<div class="flex justify-between w-full mx-auto items-center h-16 max-w-screen-xl">
				<div class="text-2xl text-orange-900">
					KILR
				</div>
				<?php if ($user !== null) { ?>
					<div class="flex">
						<a href="logout.php" class="block px-5 py-3 text-orange-900 font-light">Logout</a>
					</div>
				<?php } ?>
			</div>
		</header>

		<div class="flex-1 w-full mx-auto max-w-screen-xl">