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



// RENDER NOT RENDERING
</script>

<template>
  
  <LandingContainer>
    <div class="flex flex-col w-full h-full justify-center items-center">
      <h1 class="text-6xl lg:text-7xl xl:text-8xl text-center font-bold text-red-900 mt-20"
        style="text-shadow: 0px 0px 5px lightblue">
        Cosmos Robot Works<br />Takım Başvurusu
      </h1>
      <p class="text-center text-2xl mt-10">
        Takımımız Cosmos Robot Works'e siz de katılmak ister misiniz?<br />
        3 Ekime kadar başvurular açık!
      </p>

      <NuxtImg src="/robet.png" alt="Robot" quality="85" densities="x1 x2"
        class="w-full h-auto mt-20 border-2 border-red-200 rounded-lg shadow-lg" />

      <RobotCompParagraph>
        <div class="flex flex-col w-full h-full justify-center items-center text-center">
          <p>
            <span class="text-red-950 font-bold">Cosmos Robot Works</span> olarak bu sezonun FRC teması olan
            <NuxtImg src="/dive.png" alt="DIVE" width="100" class="inline-flex" />
            için yeni takım arkadaşları arıyoruz. <br>
            Siz de aramıza katılmak isterseniz aşağıdaki başvuru formunu doldurarak takımımıza başvurabilirsiniz.
            <br> <br>

            Takımımıza başvurmadan önce <a class="underline text-blue-900"
              href="https://www.firstinspires.org/robotics/frc/">FRC Hakkında</a> araştırma yapmanızı öneririz.
          </p>
        </div>
      </RobotCompParagraph>

      <RobotCompTitle id="a" headingColor="text-violet-900">Görev Tanımı</RobotCompTitle>

      <RobotCompParagraph>

        <div class="flex flex-col w-full h-full justify-center items-center text-center">

          <span class="inline font-bold italic text-3xl" style="color: #e91e63;">PR</span>
          <p>
            STEM’i ve mühendislik ilkelerini yaymak adına toplumsal projeler yürütür, teknolojik ürünler geliştirir. <br>
            Bunun yanı sıra takımın sponsorluk görüşmelerini ve sosyal medyasını yönetir.<br><br><br>
          </p>

          <span class="inline font-bold italic text-3xl" style="color: #f1c40f;">Mekanik</span>
          <p>
            Robotun tasarımını, montajını ve elektronik bağlantılarını yapar. <br>
            Robot tasarımında bir CAD uygulaması olan <a class="underline text-blue-900" href="https://www.autodesk.com/tr/products/fusion-360/overview">Fusion</a> kullanılır.<br><br><br>
          </p>

          <span class="inline font-bold italic text-3xl" style="color: #e74c3c;">Yazılım</span>
          <p>
            Robotun, websitenin ve ihtiyaca göre gerçekleştirilen etkinliklerin yazılımını yapar. <br>
            Robot yazılımında <a class="underline text-blue-900" href="https://dev.java/">Java</a> dilinde <a class="underline text-blue-900" href="https://docs.wpilib.org/en/stable/">WPILib</a> kütüphanesi kullanılır. <br>
            Website yazılımında ise <a class="underline text-blue-900" href="https://vuejs.org/">Vue.js</a> ile <a class="underline text-blue-900" href="https://www.typescriptlang.org/">Typescript</a> kullanılır.
          </p>

        </div>
      </RobotCompParagraph>

      <RobotCompTitle id="plan" headingColor="text-violet-900">Başvuru Takvimi</RobotCompTitle>
      
      <RobotCompParagraph>
        <span class="inline text-red-950 font-bold italic">30 Eylül Pazartesi:</span>
        Başvuruların Açılması<br><br>

        <span class="inline text-red-700 font-bold italic">3 Ekim Perşembe 23:00 :</span>
        Başvuruların Kapanması ve Proje Bilgi Maili Gönderimi <br><br>

        <span class="inline text-red-950 font-bold italic">6 Ekim Pazar 22:00 :</span>
        Proje Son Teslimi <br><br>
        
        <span class="inline text-red-700 font-bold italic">8-11 Ekim (Salı-Cuma):</span>
        Mülakat
      </RobotCompParagraph>


      <RobotCompTitle>Başvuru Formu</RobotCompTitle>
      <RobotCompParagraph textPlacement="text-center">Takıma başvurmak için aşağıdaki formu kullanabilirsiniz
      </RobotCompParagraph>
      <LandingLink class="w-1/2 mt-5" href="https://forms.gle/nTYLZEwfZmWTJnfP9" target="_blank">Takım Başvuru Formu</LandingLink>

      <RobotCompTitle id="contact" headingColor="text-purple-900">
        İletişim
      </RobotCompTitle>
      <RobotCompParagraph>
        <div class="flex flex-col w-full h-full justify-center items-center text-center">
          <p>
            
        Herhangi bir sorunuz olursa bize
        <a href="/contact" class="text-blue-900 underline">İletişim Sayfasından</a>
        ulaşabilirsiniz.
          </p>
      </div>
      </RobotCompParagraph>

      
    </div>
  </LandingContainer>
</template>
