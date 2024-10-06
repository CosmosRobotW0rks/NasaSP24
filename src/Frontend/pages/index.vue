<script setup>
definePageMeta({
  layout: "landing",
});
</script>

<template>
    <LandingContainer>
    <main>
    <div class="min-h-screen flex flex-col justify-center items-center bg-black">
      
        <NuxtImg src="img/3.svg" width="100%" alt="Space Exploration" class="mx-auto block" />

        <a href="/exoexplo" class="flex lg:px-6 py-4 text-white bg-gray-800 hover:text-black hover:bg-white transition-all duration-300 transform hover:scale-105 rounded-xl shadow-lg hover:shadow-xl text-xl lg:text-2xl font-bold">Start Your Exoplanet Exploration Journey!</a>
        
        
    </div>
    </main>
    </LandingContainer>
  </template>
  
  <script>
  export default {
    name: 'SpaceExploration',
  };
  </script>
  
  <style scoped>

  </style>
  