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

/* Scroll-controlled handshake video and story text */
const handshakeSection = document.getElementById("trust-flow");
const handshakeVideo = document.getElementById("handshakeVideo");
const handshakeSteps = document.querySelectorAll(".handshake-copy-step");
const handshakeProgressBar = document.getElementById("handshakeProgressBar");

let handshakeReady = false;
let handshakeTicking = false;
let handshakeStartTime = 0;
let handshakeEndTime = 4.2;

function clamp(value, min, max) {
  return Math.min(Math.max(value, min), max);
}

function forceMutedVideo(video) {
  if (!video) return;

  video.muted = true;
  video.defaultMuted = true;
  video.volume = 0;
  video.controls = false;
  video.setAttribute("muted", "");
  video.setAttribute("playsinline", "");
  video.setAttribute("preload", "auto");
}

function primeMutedScrollVideo(video) {
  if (!video) return;

  forceMutedVideo(video);

  // Quietly primes autoplay permission on browsers that need it.
  // The video is immediately paused again because scroll controls the timeline.
  const playPromise = video.play();

  if (playPromise && typeof playPromise.then === "function") {
    playPromise
      .then(() => {
        video.pause();
        requestHandshakeUpdate();
      })
      .catch(() => {
        video.pause();
      });
  } else {
    video.pause();
  }
}

function updateHandshakeScroll() {
  handshakeTicking = false;

  if (!handshakeSection || !handshakeVideo || !handshakeReady) return;

  forceMutedVideo(handshakeVideo);

  // The video should never run freely. The scroll position is the playhead.
  if (!handshakeVideo.paused) {
    handshakeVideo.pause();
  }

  const sectionRect = handshakeSection.getBoundingClientRect();
  const scrollableDistance = Math.max(handshakeSection.offsetHeight - window.innerHeight, 1);
  const progress = clamp(-sectionRect.top / scrollableDistance, 0, 1);

  const videoTime = handshakeStartTime + progress * (handshakeEndTime - handshakeStartTime);

  if (Number.isFinite(videoTime)) {
    handshakeVideo.currentTime = videoTime;
  }

  const activeIndex = clamp(
    Math.floor(progress * handshakeSteps.length),
    0,
    handshakeSteps.length - 1
  );

  handshakeSteps.forEach((step, index) => {
    step.classList.toggle("active", index === activeIndex);
  });

  if (handshakeProgressBar) {
    handshakeProgressBar.style.width = `${progress * 100}%`;
  }
}

function requestHandshakeUpdate() {
  if (handshakeTicking) return;
  handshakeTicking = true;
  window.requestAnimationFrame(updateHandshakeScroll);
}

function initializeHandshakeScroll() {
  if (!handshakeSection || !handshakeVideo) return;

  forceMutedVideo(handshakeVideo);
  handshakeStartTime = Number(handshakeVideo.dataset.startTime || 0);
  const preferredEndTime = Number(handshakeVideo.dataset.endTime || 4.2);
  handshakeEndTime = Math.min(preferredEndTime, Math.max(handshakeVideo.duration - 0.05, 0.1));

  handshakeReady = true;
  primeMutedScrollVideo(handshakeVideo);
  updateHandshakeScroll();
}

if (handshakeVideo) {
  forceMutedVideo(handshakeVideo);
  handshakeVideo.load();

  if (handshakeVideo.readyState >= 1) {
    initializeHandshakeScroll();
  } else {
    handshakeVideo.addEventListener("loadedmetadata", initializeHandshakeScroll, { once: true });
  }

  handshakeVideo.addEventListener("loadeddata", requestHandshakeUpdate, { once: true });
}

window.addEventListener("scroll", requestHandshakeUpdate, { passive: true });
window.addEventListener("resize", requestHandshakeUpdate);
window.addEventListener("load", requestHandshakeUpdate);
window.addEventListener("pageshow", requestHandshakeUpdate);
