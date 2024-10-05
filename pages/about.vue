<script setup>
definePageMeta({
  layout: "landing",
});

</script>

<template>
  <LandingContainer class = "bg-red-950">
    <main class = "bg-red-950 text-white px-10 py-10 pt-10 min-h-screen">
    <LandingSectionhead>
      <template v-slot:title>About Us</template>
    </LandingSectionhead>

    <div class="flex flex-col gap-3 mx-auto max-w-4xl mt-16">
      <p class = "text-2xl font-mono">
        Hello there! <br>
        We are Cosmos RW, a team of 6 high schoolers from Türkiye who are all passionate about exploring the mysteries of the Cosmos. 
        We decided that we wanted to share this passion and enthusiasm by kindling thoughts of wonder all around the world. <br>
        Space is a vast dimension. 
        In each spot we are able find bits of knowledge previously unknown to mankind. <br>
        In this project, however, we focused on a particularly interesting aspect. 
        <span class = "font-bold text-blue-400"> EXOPLANETS </span> <br>
        Whether it is to find life or habitable worlds, exoplanets have always been a major point of research by scientists and space entuhsiasts all around the world. <br>
        We wanted to ignite a spark of joy in the future engineers and scientist of the world by explaining this complex yet wonderful topic in a fun way. <br>
        Through this website we offer 3 tools that we have created to the use of any child who wants to learn about exoplanets <br>
        We aim to make this learning experience an efficient but also a very fun journey. <br>

      </p>
    </div>
  </main>
  </LandingContainer>
</template>
