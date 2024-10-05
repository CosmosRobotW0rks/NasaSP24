<script setup>
const sponsors = [
  // {
  //   title: "TesterYou",
  //   description:
  //     "Birçok sektörden gelen her seviyedeki profesyonele eğitim çalışmaları sunmak konusunda uzmanlaşmış, uluslararası bir dijital dönüşüm, çeviklik, UX ve yazılım testi eğitim sağlayıcısı.",
  //   icon: "bx:bxs-briefcase",
  //   url: "https://testeryou.com",
  // },
];
</script>

<template>
  <div class="mt-16 md:mt-0">
    <h2 class="text-4xl lg:text-5xl font-bold lg:tracking-tight">
      Our Sponsors
    </h2>

    <p class="text-lg mt-4 text-slate-600">
      You can 
      <a href="/contact" class="text-red-400 hover:text-red-600">contact us</a>
      to become a sponsor.
    </p>
  </div>
  <div class="grid sm:grid-cols-2 md:grid-cols-3 mt-16 gap-16">
    <div v-for="item of sponsors" class="flex gap-4 items-start">
      <div class="mt-1 bg-blue-800 rounded-full p-2 w-10 h-10 shrink-0">
        <Icon class="text-white w-6 h-6" :name="item.icon" />
      </div>
      <div>
        <h3
          class="font-semibold lg:text-4xl hover:animate-pulse hover:text-red-900"
        >
          <a :href="item.url" target="_blank">{{ item.title }}</a>
        </h3>
        <p class="text-slate-500 mt-2 leading-relaxed">
          {{ item.description }}
        </p>
      </div>
    </div>
  </div>
</template>
