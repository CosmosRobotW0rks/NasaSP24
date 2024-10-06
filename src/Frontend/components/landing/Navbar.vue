<script lang="ts" setup>
const menuitems = [
  {
    title : "Home",
    path : "/"
  },
  {
    title: "Your Exoplanet Exploration",
    path: "/exoexplo",
  },
  {
    title:"Expolanet Storybook",
    path: "/storybok"
  },
  {
    title: "Chatbot",
    path: "/chatbot"
  },
  {
    title: "About Us",
    path: "/about",
  }
  
];
//You can get icons from:
//https://icon-sets.iconify.design
type social = { icon: string; url: string };
const socials: social[] = [

];

const open = ref(false);
</script>

<template>
  <LandingContainer>
    <header class=" flex flex-col lg:flex-row justify-between items-center  py-5 px-20">
      
        <div class="flex w-full lg:w-auto items-center justify-between">
        <a href="/" class="text-lg group">
          
          
        <span class="text-red-900 font-extrabold group-hover:text-red-400 transition-colors duration-300">Cosmos RW</span>
        </a>
        <div class="block lg:hidden">
          <button @click="open = !open" class="text-gray-800">
            <svg fill="currentColor" class="w-4 h-4" viewBox="0 0 20 20" xmlns="http://www.w3.org/2000/svg">
              <title>Menu</title>
              <path v-show="open" fill-rule="evenodd" clip-rule="evenodd"
                d="M18.278 16.864a1 1 0 01-1.414 1.414l-4.829-4.828-4.828 4.828a1 1 0 01-1.414-1.414l4.828-4.829-4.828-4.828a1 1 0 011.414-1.414l4.829 4.828 4.828-4.828a1 1 0 111.414 1.414l-4.828 4.829 4.828 4.828z">
              </path>
              
              <path v-show="!open" fill-rule="evenodd"
                d="M4 5h16a1 1 0 010 2H4a1 1 0 110-2zm0 6h16a1 1 0 010 2H4a1 1 0 010-2zm0 6h16a1 1 0 010 2H4a1 1 0 010-2z">
              </path>
            </svg>
          </button>
        </div>
      </div>

      
      <nav class="w-full lg:w-auto mt-2 lg:flex lg:mt-0" :class="{ block: open, hidden: !open }">
        <ul class="flex flex-col lg:flex-row lg:gap-3">
          <li v-for="item of menuitems">
            <a :href="item.path"
              class="flex lg:px-3 py-2 text-white hover:text-red-950 hover:bg-white transition-all duration-300 hover:scale-105 bg-red-950 rounded-xl">
              {{ item.title }}
            </a>
          </li>
          
        </ul>
      </nav>
        
    </header>
  </LandingContainer>
</template>
