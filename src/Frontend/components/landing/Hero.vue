<template>
  <div class="flex justify-center items-center h-screen bg-black">
    <!-- Background space -->
    <div class="text-center relative">
      <!-- Outer circle border -->
      <div class="absolute inset-0 flex justify-center items-center">
        <div class="w-64 h-64 border-2 border-red-500 rounded-full opacity-70"></div>
      </div>

      <!-- Text above the circle -->
      <div class="text-white text-3xl font-bold">
        <span>THIS IS </span>
        <span class="text-cyan-400">YOUR</span>
        <span> SPACE EXPLORATION</span>
      </div>
      
      <!-- Glowing blue planet -->
      <div class="mt-6">
        <div class="relative flex justify-center items-center">
          <div class="w-48 h-48 bg-gradient-to-br from-blue-500 to-cyan-400 rounded-full shadow-2xl"></div>
          <div class="absolute text-white font-bold text-3xl">COSMOS RW</div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "SpaceExploration",
};
</script>

<style>
/* Tailwind CSS will take care of most styling, you can add extra if necessary */
</style>
