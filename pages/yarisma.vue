<script lang="ts" setup>
import { ElMessage } from "element-plus";
import "element-plus/theme-chalk/dark/css-vars.css";

const GameManualLink = "/booklet-v4-18may.pdf";
//FOR DOWNLOAD: "https://drive.google.com/uc?export=download&id=12iHxPUFdAGZI0VhcalCVpcBuWyNJ7lj-";
//FOR VIEWING WITH GOOGLE DRIVE: https://docs.google.com/document/d/e/2PACX-1vQivHU-iSlBDrDkVS-zbKb5mkdHC79XRb9_XcbLQTjr3BAoZbRsTOF7id0j7PF-VPTejMU9X1DWN3Mv/pub
const GameManualUpdate = "18 Mayıs";

definePageMeta({
  layout: "landing",
});
type question = {
  title: string;
  content: string;
};
const sss: question[] = [
  {
    title: "Kimler Katılabilir?",
    content:
      "Yarışmaya Hazırlık, 9, 10 ve 11. sınıftaki her öğrenci katılabilir. Katılmak için başvuru formunu doldurmanız yeterlidir.",
  },
  {
    title: "Takımlar kaç Kişiden oluşmalı?",
    content: "Takımlar 2 ila 5 kişi arasında olmalıdır.",
  },
  {
    title: "Robotik Bilgisine İhtiyacım Var Mı?",
    content:
      "Hayır, yarışmaya katılmak için robotik bilgisine ihtiyacınız yoktur. Yarışma öncesinde size yardımcı olacak bir mentor bulunacaktır.",
  },
  {
    title: "Robot Kuralları Konusunda Kısıtlama Var Mı?",
    content:
      "Evet, bu konudaki kısıtlamalar için kural kitapçığını detaylı bir şekilde incelemenizi tavsiye ediyoruz. (30.04.2024 tarihinde yüklenecektir)",
  },
  {
    title: "Yarışmaya Katılım Ücretli Mi?",
    content:
      "Hayır, yarışmaya katılmak için herhangi bir ücret ödemenize gerek yoktur.",
  },
  {
    title: "Robot Malzemelerini Nereden Temin Edebilirim?",
    content:
      "Robot malzemelerini temin ettiğiniz yer hakkında herhangi bir kısıtlama yoktur. Maalesef Malzeme temini konusunda size yardımcı olamıyoruz.",
  },
];
let elName = 1;

const goToBooklet = () => {
  navigateTo(GameManualLink, {
    external: true,
  });
};

const openFunc = () => {
  ElMessage({
    message: `Yarışma Kitapçığına Yönlendiriliyorsunuz<br/><br/>Son Değişiklik: ${GameManualUpdate}`,
    type: "success",
    duration: 3000,
    center: true,
    dangerouslyUseHTMLString: true,
  });
  //ElMessageBox.alert(`Yarışma Kitapçığı İndiriliyor <br/> Revize Tarihi: ${GameManualUpdate}`, "Yarışma Kitapçığı İndiriliyor",{dangerouslyUseHTMLString: true});
};

const scrollTo = (path: string) => {
  const scrollElement = document.getElementById(path);
  scrollElement?.scrollIntoView({ behavior: "smooth" });
};
</script>

<template>
  <el-alert
    title="Başvurular Kapandı"
    type="error"
    center
    show-icon
  />
  <LandingContainer>
    <div class="flex flex-col w-full h-full justify-center items-center">
      <h1
        class="text-6xl lg:text-7xl xl:text-8xl text-center font-bold text-red-900 mt-20"
        style="text-shadow: 0px 0px 5px lightblue"
      >
        Cosmos Robot Yarışması 2024
      </h1>
      <p class="text-center text-2xl mt-10">
        Cosmos Robot Yarışması'na katılmak için hazır mısınız?<br />
        13 Mayısa kadar başvurular açık!
      </p>
      <div
        class="flex flex-row items-center justify-between mt-10 w-5/6 h-100 sm:p-2 sm:w-2/3 lg:w-2/5 sm:flex-row"
      >
        <div
          @click="openFunc"
          class="cursor-pointer sm:w-64 flex flex-col pt-4"
        >
          <LandingLink class="w-32 sm:w-48" @click="goToBooklet"
            >Yarışma Kitapçığı</LandingLink
          >
          <p class="text-center w-32 sm:w-48 h-4">
            Son Değişiklik: {{ GameManualUpdate }}
          </p>
        </div>
        <div class="cursor-pointer sm:w-48 bg-blue-500 flex">
          <LandingLink
            href="#"
            styleName="outline"
            class="w-32 sm:w-48 bg-red-300"
            >Başvurular Kapandı</LandingLink
          >
        </div>
      </div>
      <NuxtImg
        src="/robot.jpeg"
        alt="Robot Competition 2024"
        quality="85"
        densities="x1 x2"
        class="w-full h-auto mt-20 border-2 border-red-200 rounded-lg shadow-lg"
      />
      <RobotCompTitle>Robot Destek Kitapçığı</RobotCompTitle>
      <RobotCompParagraph textPlacement="text-center"
        >Eğer robot yapma konusunda desteğe ihtiyacınız varsa bu kitapçıktan
        yardım alabilirsiniz:</RobotCompParagraph
      >
      <LandingLink
        class="w-1/2 mt-5"
        href="https://docs.google.com/document/d/e/2PACX-1vSbgMeupxy4D2nWW-T39N0LuSxxGn61y0SVhY-YZ7VpDMUobcPHtp_5wkSkJ3uD2SU4XZznoOjcaWgy/pub"
        target="_blank"
        >Robot Destek Kitapçığı</LandingLink
      >
      <RobotCompTitle id="details" headingColor="text-violet-900">
        Detaylar
      </RobotCompTitle>
      <RobotCompParagraph
        >Mühendisliğe İlgili Sevgili Bahçeşehir Nakkaştepe Öğrencileri, Büyük
        gün geldi! <br />Fen ve Teknoloji Lisesi FRC takımımız Cosmos RW'ün bu
        yıl düzenleyeceği Cosmos Robot Yarışması'na hepiniz hoş geldiniz...
        Takım liderleri, diğer takım liderleri ve Cosmos mentörlerinin birlikte
        oldukları bir WhatsApp grubuna eklenecekler ve istedikleri zaman
        sorularını sorabileceklerdir. Gerektiği zamanlarda önceden anlaşmak
        koşulu ile yemekhane katındaki atölyemize gelerek de robotlarını deneme
        imkanı bulabilecek veya hatalarını Cosmos'tan deneyimli mentörleriyle
        düzeltebileceklerdir. Cosmos destek sağlamaktan hiç çekinmeyecektir. En
        az 2, en fazla 5 kişiden oluşabilecek takımlarınızla hazırlayacağınız
        robotlarınızla, verilen sürede en fazla puanı toplamaya çalışacaksınız.
        Bu heyecanlı yarışmada en fazla puanı toplayan kazanacak. Öncesinde
        Cosmos atölyesinde denemeler yapılabilecektir. <br /><br /><span
          class="text-red-700"
          >Ödüller 4 kategoride incelenir:</span
        >
        <br />
        <span class="mt-10">
          <span class="inline text-yellow-600 font-bold italic">Winner:</span>
          Final maçını kazanan ittifaktaki takımlara verilir.<br />
          <span class="inline text-blue-900 font-bold italic">Creativity:</span>
          Robotun inovasyon ve işlevselliğine bakılarak verilir.<br />
          <span class="inline text-pink-400 font-bold italic">Imagery:</span>
          Robotun estetik güzelliği değerlendirilerek verilir.<br />
          <span class="inline text-green-600 font-bold italic"
            >Team Spirit:</span
          >
          Takım üyelerinin mücadeleler boyunca birbirlerini ne kadar
          destekledikleri dikkate alınarak verilir.
        </span>
      </RobotCompParagraph>
      <RobotCompTitle id="contact" headingColor="text-purple-900">
        İletişim
      </RobotCompTitle>
      <RobotCompParagraph>
        Herhangi bir sorunuz olursa bize
        <a href="/contact" class="text-blue-500 underline"
          >İletişim Sayfasından</a
        >
        ulaşabilir veya
        <a
          @click="scrollTo('faq')"
          class="text-blue-500 underline cursor-pointer"
          >Sıkça Sorulan Sorulara</a
        >
        bakabilirsiniz.
      </RobotCompParagraph>

      <RobotCompTitle id="faq" headingColor="text-sky-900">
        Sıkça Sorulan Sorular
      </RobotCompTitle>
      <el-collapse accordion class="mt-10 w-full text-4xl">
        <el-collapse-item
          :title="question.title"
          :name="key"
          class="w-full"
          v-for="(question, key) in sss"
        >
          <div class="text-sm mt-2">
            {{ question.content }}
          </div>
        </el-collapse-item>
      </el-collapse>
    </div>
  </LandingContainer>
</template>
