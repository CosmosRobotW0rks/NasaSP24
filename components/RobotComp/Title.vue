<script setup lang="ts">
interface Props {
  headingColor?: string;
  className?: string;
  [x: string]: any;
}

withDefaults(defineProps<Props>(), {
  headingColor: "text-emerald-800",
});
</script>

<template>
  <h1
    :class="
      'text-5xl lg:text-6xl xl:text-7xl font-bold lg:tracking-tight mt-32 lg:w-2/3 text-center ' +
      headingColor
    "
  >
    <slot />
  </h1>
</template>
