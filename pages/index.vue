<script setup>
definePageMeta({
  layout: "landing",
});
useSeoMeta({
  title: "CRW 7742",
  description:
    "Cosmos Robot Works, Team 7742 First Robotics Competition Website",
  ogTitle: "CRW 7742",
  ogDescription: "Cosmos Robot Works is an FRC team from Turkey.",
  ogImage: "/hero.png",
  ogUrl: "https://cosmos7742.com",
  twitterTitle: "CRW",
  twitterDescription: "Cosmos 7742",
  twitterImage: "/hero.png",
  twitterCard: "Cosmos Robot Works",
});

useHead({
  htmlAttrs: {
    lang: "tr",
  },
  link: [
    {
      rel: "icon",
      type: "image/x-icon",
      href: "/favicon.ico",
    },
  ],
});
</script>

<template>
  <LandingContainer>
    <LandingHero></LandingHero>
    <LandingFeatures></LandingFeatures>
  </LandingContainer>
</template>
