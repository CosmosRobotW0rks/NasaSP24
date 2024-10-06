<template>
  <LandingNavbar></LandingNavbar>
  <slot></slot>
  <LandingFooter></LandingFooter>
</template>

<script setup>
const route = useRouter();
useSeoMeta({
  title: "Cosmos RW",
  description:
    "Cosmos RW",
  ogTitle: "Cosmos RW",
  ogDescription: "Cosmos RW"
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
