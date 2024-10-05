<script setup>
definePageMeta({
  layout: "landing",
});
</script>

<template>

  <LandingContainer>
    <main class="bg-red-950 text-white px-10 py-10 pt-10">
      <div class="flex flex-col items-start space-y-4">

        <div class="flex flex-col w-full justify-center items-center">
          <div class="text-7xl leading-snug text-center">
            <p>Have you ever seen Venus in the sky and</p>
            <p>wondered why we cannot see other</p>
            <p>planets ?</p>
          </div>
        </div>

        
        <div class="text-4xl leading-snug space-y-4 flex flex-col w-full justify-center items-center pt-10">
          <p>✯ Let's meet <span class="font-bold">Miss.Exo</span> and get to</p>
          <p>know her story with <span class="font-bold">Exoplanets</span>!</p>

        </div>

        <div class="flex-grow w-full">
          <iframe src="/path/to/ebook.pdf" class="w-full h-full" frameborder="0"
            style="min-height: calc(100vh - 300px);" scrolling="auto">
          </iframe>
        </div>
        
      </div>
    </main>
  </LandingContainer>

</template>