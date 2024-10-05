<script setup lang="ts">
interface Props {
  className?: string;
  [x: string]: any;
}

withDefaults(defineProps<Props>(), {
  headingColor: "emerald-800",
});
</script>

<template>
  <div>
    <h1
      class="text-5xl lg:text-6xl xl:text-8xl font-bold lg:tracking-tight text-emerald-800 mt-40 lg:w-2/3 text-center"
    >
      <slot />
    </h1>
  </div>
</template>
