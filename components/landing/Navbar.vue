<script lang="ts" setup>
const menuitems = [

  // {
  //   title: "Robot Yarışması",
  //   path: "/robot-competition-2024",
  // },
  {
    title: "Home",
    path: "/",
  },
  {
    title: "About Us",
    path: "/about",
  },
  {
    title: "Projects",
    path: "/projects",
  },
  {
    title: "Contact Us",
    path: "/contact",
  },
];
//You can get icons from:
//https://icon-sets.iconify.design
type social = { icon: string; url: string };
const socials: social[] = [
  {
    icon: "entypo-social:instagram",
    url: "https://www.instagram.com/cosmosrobotworks",
  },
  {
    icon: "entypo-social:github-with-circle",
    url: "https://github.com/CosmosRobotW0rks",
  },
  {
    icon: "mingcute:social-x-line",
    url: "https://x.com/cosmosrobotics",
  },
  {
    icon: "entypo-social:linkedin-with-circle",
    url: "https://www.linkedin.com/company/cosmos-robot-works/",
  },
];
const open = ref(false);
</script>

<template>
  <LandingContainer>
    <header class="flex flex-col lg:flex-row justify-between items-center my-5">
      <div class="flex w-full lg:w-auto items-center justify-between">
        <a href="/" class="text-lg group"
          ><span
            class="font-bold text-slate-800 group-hover:text-red-800 transition-colors duration-300"
            >7742 </span
          ><span
            class="text-slate-500 group-hover:text-red-400 transition-colors duration-300"
            >Cosmos Robot Works</span
          >
        </a>
        <div class="block lg:hidden">
          <button @click="open = !open" class="text-gray-800">
            <svg
              fill="currentColor"
              class="w-4 h-4"
              viewBox="0 0 20 20"
              xmlns="http://www.w3.org/2000/svg"
            >
              <title>Menu</title>
              <path
                v-show="open"
                fill-rule="evenodd"
                clip-rule="evenodd"
                d="M18.278 16.864a1 1 0 01-1.414 1.414l-4.829-4.828-4.828 4.828a1 1 0 01-1.414-1.414l4.828-4.829-4.828-4.828a1 1 0 011.414-1.414l4.829 4.828 4.828-4.828a1 1 0 111.414 1.414l-4.828 4.829 4.828 4.828z"
              ></path>
              <path
                v-show="!open"
                fill-rule="evenodd"
                d="M4 5h16a1 1 0 010 2H4a1 1 0 110-2zm0 6h16a1 1 0 010 2H4a1 1 0 010-2zm0 6h16a1 1 0 010 2H4a1 1 0 010-2z"
              ></path>
            </svg>
          </button>
        </div>
      </div>
      <nav
        class="w-full lg:w-auto mt-2 lg:flex lg:mt-0"
        :class="{ block: open, hidden: !open }"
      >
        <ul class="flex flex-col lg:flex-row lg:gap-3">
          <li v-for="item of menuitems">
            <a
              :href="item.path"
              class="flex lg:px-3 py-2 text-gray-600 hover:text-red-800 transition-all duration-300 hover:scale-105"
            >
              {{ item.title }}
            </a>
          </li>
          <div
            class="flex lg:hidden flex-row w-full sm:w-3/12 justify-around mt-8"
          >
            <div
              v-for="social in socials"
              class="relative overflow-hidden inline-block cursor-pointer"
            >
              <a :href="social.url" target="_blank">
                <Icon
                  class="w-6 h-6 text-gray-800 hover:text-red-500 transition-color duration-300 z-10"
                  :name="social.icon"
                />
              </a>
            </div>
          </div>
        </ul>
      </nav>
      <div class="hidden lg:flex flex-row w-1/5 justify-around">
        <div
          v-for="social in socials"
          class="relative overflow-hidden inline-block cursor-pointer hover:-translate-y-1 transition-transform duration-300"
        >
          <a :href="social.url" target="_blank">
            <Icon
              class="w-6 h-6 text-gray-800 hover:text-red-500 transition-colors duration-300 z-10"
              :name="social.icon"
            />
          </a>
        </div>
      </div>
    </header>
  </LandingContainer>
</template>
