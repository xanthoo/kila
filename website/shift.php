<?php
require_once "core/core.php";
if ($user === null) {
	header('Location: login.php');
	die();
}
require_once "includes/header.php";
?>
	<div class="py-6 px-8 w-full my-auto bg-orange-200">
    <div class="mb-12">
			<h1 class="text-2xl text-orange-900 text-center font-light mb-6">Your Shifts</h1>

			<div class="grid grid-cols-2 col-gap-8">
				<label class="block mb-5">
					<span class="text-lg text-orange-900 font-light ">Month</span>
                    <div class="input-group">
                 <select class="custom-select w-full bg-white focus:outline-none px-3 py-2" id="inputGroupSelect04" aria-label="Example select with button addon">
                    <option selected>Choose...</option>
                    <option value="jan">January</option>
                    <option value="feb">Frbruary</option>
                    <option value="mar">March</option>
                    <option value="apr">April</option>
                    <option value="may">May</option>
                    <option value="june">June</option>
                    <option value="july">July</option>
                    <option value="aug">August</option>
                    <option value="sep">September</option>
                    <option value="oct">October</option>
                    <option value="nov">November</option>
                    <option value="dec">December</option>
                    </select>
                    </div>
				</label>
				<label class="block mb-5">
					<span class="text-lg text-orange-900 font-light">Year</span>
					<div class="input-group">
                 <select class="custom-select w-full bg-white focus:outline-none px-3 py-2" id="inputGroupSelect04" aria-label="Example select with button addon">
                    <option selected>Choose...</option>
                    <option class="year">2019</option>
                    <option class="year">2020</option>
                    <option class="year">2021</option>
                    <option class="year">2012</option>
                    <option class="year">2023</option>
                    <option class="year">2024</option>
                    <option class="year">2024</option>
                    </select>
                    </div>
				</label>
			</div>
            <div class="py-6 px-8 w-full my-auto bg-orange-100">
            <table class="table w-full bg-orange-100 focus:outline-none px-3 py-2">
            <thead>
            <tr>
             <td class="text-lg text-orange-900 font-bold" >Date</td>
             <td class="text-lg text-orange-900 font-bold">Shift</td>  
             </tr>
             </thead>
             <tbody>
             <tr>
             <td>05/05/2020</td>
             <td>Afternoon</td>
            </tr>
           </tbody>
         </table>
       </div>
	</div>
    <div class="flex flex-col items-right">
			<button class="transition duration-150 ease-in-out w-48 px-3 py-3 bg-orange-500 hover:bg-orange-400 text-orange-100 text-xl font-light focus:outline-none">View Details</button>
		</div>
</div>
<?php
require_once "includes/footer.php";
?>
