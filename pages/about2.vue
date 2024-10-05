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
        In the year 2019, a group of individuals from our school embarked on a journey to create a profound impact within the Cosmos.<br/><br/>
        The team began with small steps and has now grown into a large team with 2 mentors, 30 members, and numerous alumni.<br/><br/>
        Throughout this journey, what made 7742 special was our ability to deliver STEM education to the most underserved segments of our community.<br/><br/>
        Therefore, we focused on the segments of our society that are considered "overlooked " and creative methods rather than standard approaches.<br/><br/>
        Our goal was to devise a unique methodology tailored to our objectives, which enabled us to reach a broader audience.<br/><br/>
        This strategy facilitated a Cosmic Impact, allowing us to effectively reach the entirety of our community within the Cosmos.<br/><br/>
        As the Stars of the Cosmos, we aimed to extend our radiance to every dark corner of the universe, shedding light on Planets.<br/><br/>
        Particularly in the realm of STEM, our objective was to leave no dark spot unilluminated by the light of knowledge and opportunity. <br/><br/>
        As Stars continue to align with Planets, STEM becomes accessible to all.<br/><br/>
        So, let's grab our telescopes and delve deeper into Cosmos and the Cosmic Impact!
      </p>
    </div>
  </LandingContainer>
</template>
