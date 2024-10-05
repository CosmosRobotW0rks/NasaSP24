<script lang="ts" setup>
import { useTransition } from "@vueuse/core";

const eventRef: Ref<HTMLElement | null> = ref(null);

definePageMeta({
  layout: "landing",
});

type project = {
  title: string;
  location: string;
  desc: string;
  url?: string;
  date: Date;
  image?: string;
};
const projects: project[] = [

];
</script>

<template>
  <div class="relative flex flex-col justify-center items-center justify-items-center overflow-hidden">
    <LandingContainer>
      <LandingSectionhead>
        <template v-slot:title>Projects</template>
        <template v-slot:desc>Coming Soon..</template>
      </LandingSectionhead>
    </LandingContainer>
    <div
      class="w-screen-80 h-auto grid grid-cols-1 xl:grid-cols-2 items-center justify-around place-items-center gap-y-20 mt-20 pb-5">
      <Project v-for="(project, index) in projects" :key="index" :project="project" />
    </div>

  </div>
</template>
