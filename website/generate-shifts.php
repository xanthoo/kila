<?php
require_once "core/core.php";


require_once "includes/header.php";
?>
<div class="py-6 px-8 w-full my-auto bg-orange-200">
    <div class="mb-12">
			<h1 class="text-2xl text-orange-900 text-center font-light mb-6">Generate Shifts</h1>

			<form>
			<div class="grid grid-cols-2 col-gap-8">
				<label class="block mb-5">
					<span class="text-lg text-orange-900 font-light">From Year</span>
					<div class="input-group">
						<select id="from-year" name="from-year" class="custom-select w-full bg-white focus:outline-none px-3 py-2" id="inputGroupSelect04" aria-label="Example select with button addon">
							
						</select>
                        
                    </div>
				</label>
                <label class="block mb-5">
					<span class="text-lg text-orange-900 font-light">To Year</span>
					<div class="input-group">
						<select id="to-year" name="to-year" class="custom-select w-full bg-white focus:outline-none px-3 py-2" id="inputGroupSelect04" aria-label="Example select with button addon">
							
						</select>
                        
                    </div>
				</label>
                <label class="block mb-5">
					<span class="text-lg text-orange-900 font-light">From Day</span>
					<div class="input-group">
						<select id="from-day" name="from-day" class="custom-select w-full bg-white focus:outline-none px-3 py-2" id="inputGroupSelect04" aria-label="Example select with button addon">
							
						</select>
                        
                    </div>
				</label>
                <label class="block mb-5">
					<span class="text-lg text-orange-900 font-light">To Day</span>
					<div class="input-group">
						<select id="to-day" name="to-day" class="custom-select w-full bg-white focus:outline-none px-3 py-2" id="inputGroupSelect04" aria-label="Example select with button addon">
							
						</select>
                        
                    </div>
				</label>
                <label class="block mb-5">
					<span class="text-lg text-orange-900 font-light">From Month</span>
					<div class="input-group">
						<select id="from-month" name="from-month" class="custom-select w-full bg-white focus:outline-none px-3 py-2" id="inputGroupSelect04" aria-label="Example select with button addon">
							
						</select>
                        
                    </div>
				</label>
				<label class="block mb-5">
					<span class="text-lg text-orange-900 font-light ">To Month</span>
                    <div class="input-group">
                 <select id="to-month" name="to-month" class="custom-select w-full bg-white focus:outline-none px-3 py-2" id="inputGroupSelect04" aria-label="Example select with button addon">
                    
                    </select>
                    </div>
				</label>
			</div>
				</label>
			</div>
				</form>

	</div>
    <div class="flex flex-col items-right">
			<a href="" class="transition duration-150 ease-in-out text-center w-48 px-3 py-3 bg-orange-300 hover:bg-orange-400 text-orange-700 text-xl font-light focus:outline-none">Generate Pending Shifts</a>
		</div>
</div>
<?php
require_once "includes/footer.php";
?>
