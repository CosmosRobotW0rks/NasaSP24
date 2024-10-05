<script setup>
definePageMeta({
  layout: "landing",
});

const TeamImg1 = "https://source.unsplash.com/IF9TK5Uy-KI";
const TeamImg2 = "https://source.unsplash.com/iEEBWgY_6lA";
const TeamImg3 = "https://source.unsplash.com/ZHvM3XIOHoE";

const team = [
  {
    name: "Janette Lynch",
    title: "Senior Director",
    avatar: {
      src: TeamImg1,
      width: 480,
      height: 560,
    },
  },
  {
    name: "Marcell Ziemann",
    title: "Principal Strategist",
    avatar: {
      src: TeamImg2,
      width: 580,
      height: 580,
    },
  },
  {
    name: "Robert Palmer",
    title: "Marketing Engineer",
    avatar: {
      src: TeamImg3,
      width: 580,
      height: 580,
    },
  },
];
</script>

<template>
  <LandingContainer>
    <LandingSectionhead>
      <template v-slot:title>About Us</template>
    </LandingSectionhead>

    <div class="flex flex-col gap-3 mx-auto max-w-4xl mt-16">
      <p>
        In 2019, a group from our school started a journey to make a significant impact in the community.<br/><br/>
        What began as small steps has grown into a team with 2 mentors, 30 members, and many alumni.<br/><br/>
        Our unique focus has always been on delivering STEM education to underserved parts of our community.<br/><br/>
        We chose creative methods over standard approaches to reach overlooked segments of society.<br/><br/>
        This strategy allowed us to make a "Cosmic Impact," reaching every corner of our community.<br/><br/>
        As the "Stars of the Cosmos," our goal was to spread knowledge and opportunity in STEM, illuminating every dark corner.<br/><br/>
        As stars align with planets, STEM becomes accessible to all.<br/><br/>
        So, let's grab our telescopes and explore the Cosmos and our impact further!<br/><br/>
      </p>
    </div>
  </LandingContainer>
</template>
