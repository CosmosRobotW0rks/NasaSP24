// https://nuxt.com/docs/api/configuration/nuxt-config
export default defineNuxtConfig({
  devtools: { enabled: true },
  css: ["~/assets/css/main.css"],

  postcss: {
    plugins: {
      tailwindcss: {},
      autoprefixer: {},
    },
  },

  modules: [
    "nuxt-icon",
    "@nuxtjs/tailwindcss",
    "@nuxt/image",
    "@element-plus/nuxt",
  ],

  image: {
    provider: "ipx",
    inject: true,
    quality: 80,
    dir: "public",
  },

  compatibilityDate: "2024-08-27",
});