/* =========================
   AHAD JUS DUX WEBSITE JS
   ========================= */

const introScreen = document.getElementById("introScreen");
const introVideo = document.getElementById("introVideo");
const website = document.getElementById("website");
const skipIntro = document.getElementById("skipIntro");
const soundButton = document.getElementById("soundButton");

let websiteShown = false;

function showWebsite() {
  if (websiteShown) return;
  websiteShown = true;

  introScreen.style.opacity = "0";
  introScreen.style.transition = "opacity 0.7s ease";

  setTimeout(() => {
    introScreen.style.display = "none";
    website.classList.remove("hidden");
  }, 700);
}

/* When the intro video finishes, show the website */
introVideo.addEventListener("ended", showWebsite);

/* Enter Site button */
skipIntro.addEventListener("click", showWebsite);

/* Tap for Sound button */
soundButton.addEventListener("click", () => {
  introVideo.muted = false;
  introVideo.play();
  soundButton.textContent = "Sound On";
});

/* Safety backup: if video does not load, show website after 9 seconds */
setTimeout(showWebsite, 9000);

/* Mobile menu */
const openMenu = document.getElementById("openMenu");
const mobileMenu = document.getElementById("mobileMenu");
const closeMenu = document.getElementById("closeMenu");

openMenu.addEventListener("click", () => {
  mobileMenu.classList.add("active");
});

closeMenu.addEventListener("click", () => {
  mobileMenu.classList.remove("active");
});

/* Close mobile menu after clicking a link */
const mobileLinks = mobileMenu.querySelectorAll("a");

mobileLinks.forEach((link) => {
  link.addEventListener("click", () => {
    mobileMenu.classList.remove("active");
  });
});