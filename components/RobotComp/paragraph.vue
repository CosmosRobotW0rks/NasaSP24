<script setup lang="ts">
interface Props {
  textColor?: string;
  className?: string;
  textPlacement?: "text-left" | "text-center" | "text-right";
  [x: string]: any;
}
withDefaults(defineProps<Props>(), {
  textColor: "emerald-800",
  textPlacement: "text-left",
});
</script>

<template>
  <div class="text-2xl mt-10 w-full" :class="textPlacement">
    <slot />
  </div>
</template>
