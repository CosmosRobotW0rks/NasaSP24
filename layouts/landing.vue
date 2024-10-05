<template>
  <LandingNavbar></LandingNavbar>
  <slot></slot>
  <LandingFooter></LandingFooter>
</template>

<script setup>
const route = useRouter();
useSeoMeta({
  title: "CRW 7742",
  description:
    "Cosmos Robot Works, Team 7742 First Robotics Competition Website",
  ogTitle: "CRW 7742",
  ogDescription: "Cosmos Robot Works is an FRC team from Turkey.",
  ogImage: "/hero.png",
  ogUrl: "https://cosmos7742.com" + route.currentRoute.value.fullPath,
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
