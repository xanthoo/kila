		</div>
	</div>

	<script>
		var message = "<?php echo htmlspecialchars($message) ?>";
	</script>
    <script src="js/javascript.js"></script>
	<script>
		<?php
			if ($success && $successRedirect !== '') {
				echo 'window.location.replace("' . $successRedirect . '");';
			}
		?>
	</script>
</body>
</html>
