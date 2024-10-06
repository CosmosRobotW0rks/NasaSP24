<script setup>
definePageMeta({
  layout: "landing",
});
</script>

<template>
  <LandingContainer>
    <main>
      <div class="min-h-screen flex flex-col justify-center items-center bg-black">

        <NuxtImg src="img/4.svg" width="100%" alt="Space Exploration" class="mx-auto block" />


        <p class="text-white text-center py-10 italic font-semibold">
          NASA’s Exoplanet Exploration Program discovers and studies planets beyond our solar system, <br>
          using data and innovative tools to inspire curiosity and exploration of distant worlds. <br>
          For more information check out the link below! </p>
        <a href="https://exoplanets.nasa.gov/exep/" class ="text-white text-center py-10 italic font-semibold">https://exoplanets.nasa.gov/exep/</a>  
        <a href="/storybook"
          class="flex lg:px-6 py-4 mb-8 text-white bg-gray-800 hover:text-black hover:bg-white transition-all duration-300 transform hover:scale-105 rounded-xl shadow-lg hover:shadow-xl text-xl lg:text-2xl font-bold">Start
          Your OWN  Exoplanet Exploration Journey!</a>


      </div>
    </main>
  </LandingContainer>
</template>

<script>
export default {
  name: 'SpaceExploration',
};
</script>

<style scoped></style>