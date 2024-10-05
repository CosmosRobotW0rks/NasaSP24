<script setup lang="ts">
import { useMouse } from "@vueuse/core";
type project = {
  title: string;
  location: string;
  desc: string;
  url?: string;
  date: Date;
  image?: string;
};
interface Props {
  project: project;
  [x: string]: any;
}
withDefaults(defineProps<Props>(), {});
const isHovered = ref(false);
const eventRef: Ref<HTMLElement | null> = ref(null);
const eventImageRef = ref();

let x = ref(0);
let y = ref(0);

const handleMouseMove = (event: MouseEvent) => {
  if (eventRef.value) {
    const rect = eventRef.value?.getBoundingClientRect();
    x.value = event.clientX - rect.left - rect.width / 2 + 180;
    y.value = event.clientY - rect.top - rect.height / 2 + 85;
  }
};

let currentX = ref(0);
let currentY = ref(0);

const smooth = 0.08; // Smoothing factor lower is smoother
onMounted(() => {
  setInterval(() => {
    currentX.value += (x.value - currentX.value) * smooth;
    currentY.value += (y.value - currentY.value) * smooth;
  }, 1000 / 60);
});

let i = ref(100);
let intervalId = ref();
onMounted(() => {
  watch(
    isHovered,
    (newVal) => {
      if (newVal) {
        i.value = 50;
        clearInterval(intervalId.value);
      } else {
        intervalId.value = setInterval(() => {
          if (i.value < 100) {
            i.value++;
          } else {
            clearInterval(intervalId.value);
          }
        }, 10); // adjust the time as needed
      }
    },
    { immediate: true }
  );
});

const imageGradient = computed(() => {
  let rect = eventImageRef.value?.getBoundingClientRect();
  if (rect) {
    if (isHovered.value) {
      const xPos = currentX.value - (rect.left ?? 0);
      const yPos = currentY.value - (rect.top ?? 0);
      return `radial-gradient(circle at ${currentX.value - 100}px ${
        currentY.value
      }px, black 50%, transparent 100%)`;
    } else {
      return `radial-gradient(circle at ${currentX.value - 100}px ${
        currentY.value
      }px, black ${i.value}%, transparent 100%)`;
    }
  } else {
    return;
  }
});
const goToEvent = (url: any) => {
  if (url) {
    navigateTo(url);
  }
};
// watchEffect(() => {
//   currentX.value += (newX.value - currentX.value) * smooth;
//   currentY.value += (newY.value - currentY.value) * smooth;
// });
</script>

<template>
  <div
    class="flex w-full flex-col sm:w-144 h-80 rounded-xl p-2.5 shadow-[5px_5px_15px_2px_rgba(0,0,0,0.6)] hover:shadow-[5px_5px_20px_2px_rgba(0,0,0,0.7)] transition-all scale-100 hover:cursor-pointer duration-300 overflow-hidden group"
    @click="goToEvent(event.url)"
    @mouseenter="isHovered = true"
    @mouseleave="isHovered = false"
    @mousemove="handleMouseMove"
    ref="eventRef"
  >
    <div
      class="absolute inset-0 bg-gradient-to-br from-purple-500 via-blue-600 to-green-500 rounded-xl -z-30"
    ></div>
    <div
      class="absolute inset-0 bg-gradient-to-tl from-red-700 to-red-950 rounded-lg -z-20 transition-all duration-300 group-hover:inset-2"
      ref="gradBorder"
    ></div>
    <div
      class="absolute bg-pink-200 w-64 h-64 rounded-full pointer-events-none -z-20 blur-3xl transition-opacity duration-1000"
      :style="{
        left: `${currentX}px`,
        top: `${currentY}px`,
        width: '150px',
        height: '150px',
        opacity: isHovered ? '80' : '0',
      }"
    ></div>
    <div class="flex flex-col w-full h-1/5 z-10">
      <h2 class="text-xl sm:text-2xl w-full text-blue-50 pr-2">
        {{ project.title }}
      </h2>
      <div class="w-full flex flex-row justify-between">
        <p class="text-gray-400">
          {{
            project.date.toLocaleDateString("tr-TR", {
              year: "numeric",
              month: "long",
              day: "numeric",
            })
          }}
        </p>
        <div
          class="flex flex-row justify-end justify-items-center items-center sm:w-2/3 w-3/5"
        >
          <Icon name="mdi:location" class="text-blue-500 mr-1" />
          <p class="text-sm text-blue-500 text-right w-10/12 mr-0">
            {{ project.location }}
          </p>
        </div>
      </div>
    </div>
    <div class="flex h-4/5 bottom-0 pt-4 rounded-sm z-10">
      <p class="w-2/5 text-white">{{ project.desc }}</p>
      <NuxtImg
        v-if="project.image"
        :src="project.image"
        ref="eventImageRef"
        quality="45"
        alt="event.title"
        class="object-cover mb-0 rounded-sm w-3/5 shadow-inner border-2 border-blue-950 transition-all duration-1000"
        :style="{ maskImage: imageGradient }"
      />
    </div>
    <!-- <div
          class="flex absolute bg-black w-full h-full border-8 border-blue-700 top-0 left-0 rounded-xl"
        ></div> -->
  </div>
</template>
