<?php
   require_once "core/core.php";
   
   
   require_once "includes/header.php";
   ?>
<div class="py-6 px-8 w-full my-auto bg-orange-200">
   <h1 class="text-2xl text-orange-900 text-center font-light mb-6">Generated Shifts</h1>
   <div class="flex flex-wrap -mb-4">
      <div class="w-1/3 mb-4 h-12">
         <span class="text-lg text-orange-900 font-light">Year</span>
         <div class="inline-block relative w-64">
            <select class="block appearance-none w-full bg-white border border-gray-400 hover:border-gray-500 px-4 py-2 pr-8 rounded shadow leading-tight focus:outline-none focus:shadow-outline">
            </select>
            <div class="pointer-events-none absolute inset-y-0 right-0 flex items-center px-2 text-gray-700">
               <svg class="fill-current h-4 w-4" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 20 20">
                  <path d="M9.293 12.95l.707.707L15.657 8l-1.414-1.414L10 10.828 5.757 6.586 4.343 8z"/>
               </svg>
            </div>
         </div>
      </div>
      <div class="w-1/3 mb-4 h-12">
         <span class="text-lg text-orange-900 font-light">Month</span>
         <div class="inline-block relative w-64">
            <select class="block appearance-none w-full bg-white border border-gray-400 hover:border-gray-500 px-4 py-2 pr-8 rounded shadow leading-tight focus:outline-none focus:shadow-outline">
            </select>
            <div class="pointer-events-none absolute inset-y-0 right-0 flex items-center px-2 text-gray-700">
               <svg class="fill-current h-4 w-4" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 20 20">
                  <path d="M9.293 12.95l.707.707L15.657 8l-1.414-1.414L10 10.828 5.757 6.586 4.343 8z"/>
               </svg>
            </div>
         </div>
      </div>
      <div class="w-1/3 mb-4 h-12">
         <span class="text-lg text-orange-900 font-light">Day</span>
         <div class="inline-block relative w-64">
            <select class="block appearance-none w-full bg-white border border-gray-400 hover:border-gray-500 px-4 py-2 pr-8 rounded shadow leading-tight focus:outline-none focus:shadow-outline">
            </select>
            <div class="pointer-events-none absolute inset-y-0 right-0 flex items-center px-2 text-gray-700">
               <svg class="fill-current h-4 w-4" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 20 20">
                  <path d="M9.293 12.95l.707.707L15.657 8l-1.414-1.414L10 10.828 5.757 6.586 4.343 8z"/>
               </svg>
            </div>
         </div>
      </div>
      <div class="w-1/3 mb-4 h-12">
         <span class="text-lg text-orange-900 font-light">Shift</span> 
         <input class="appearance-none bg-transparent border-none w-full text-gray-700 mr-3 py-1 px-2 leading-tight focus:outline-none" type="text" placeholder="Shift from DB" aria-label="shift">

      </div>
      <div class="w-1/3 mb-4 h-12">
         <span class="text-lg text-orange-900 font-light">Employee:</span>
         <div class="inline-block relative w-64">
            <select class="block appearance-none w-full bg-white border border-gray-400 hover:border-gray-500 px-4 py-2 pr-8 rounded shadow leading-tight focus:outline-none focus:shadow-outline">
               <option>Employee from DB</option>
            </select>
            <div class="pointer-events-none absolute inset-y-0 right-0 flex items-center px-2 text-gray-700">
               <svg class="fill-current h-4 w-4" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 20 20">
                  <path d="M9.293 12.95l.707.707L15.657 8l-1.414-1.414L10 10.828 5.757 6.586 4.343 8z"/>
               </svg>
            </div>
         </div>
      </div>
      <div class="w-1/3 mb-4 h-12">
      </div>
      <div class="w-1/2 mb-4 h-12">
      <button class="bg-orange-500 hover:bg-blue-700 text-white font-bold py-2 px-4 rounded">
  Cancel
</button>
      </div>
      <div class="w-1/2 mb-4 h-12">
      <button class="bg-orange-500 hover:bg-blue-700 text-white font-bold py-2 px-4 rounded">
  Confirm Shifts
</button>
      </div>
   </div>
</div>
<?php
   require_once "includes/footer.php";
   ?>