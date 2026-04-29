/* =========================
   AHAD JUS DUX WEBSITE CSS
   ========================= */

/* BASIC RESET */

* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}

html {
  scroll-behavior: smooth;
}

body {
  font-family: Georgia, "Times New Roman", serif;
  background: #efe4d4;
  color: #071a2f;
}

a {
  text-decoration: none;
}

.hidden {
  display: none;
}

/* =========================
   INTRO VIDEO SCREEN
   ========================= */

.intro-screen {
  position: fixed;
  inset: 0;
  z-index: 9999;
  background: #071a2f;
  display: flex;
  align-items: center;
  justify-content: center;
}

.intro-screen video {
  width: 100%;
  height: 100%;
  object-fit: cover;
}

.intro-controls {
  position: absolute;
  right: 25px;
  bottom: 25px;
  display: flex;
  gap: 12px;
}

.intro-controls button {
  border: 1px solid rgba(201, 169, 106, 0.6);
  background: rgba(7, 26, 47, 0.72);
  color: #f0d79a;
  padding: 12px 18px;
  border-radius: 30px;
  cursor: pointer;
  font-family: inherit;
  backdrop-filter: blur(12px);
  transition: 0.3s ease;
}

.intro-controls button:hover {
  background: #c9a96a;
  color: #071a2f;
}

/* =========================
   NAVIGATION BAR
   ========================= */

.navbar {
  position: fixed;
  top: 0;
  left: 0;
  width: 100%;
  height: 78px;
  z-index: 1000;
  background: rgba(7, 26, 47, 0.9);
  backdrop-filter: blur(18px);
  border-bottom: 1px solid rgba(201, 169, 106, 0.22);
  display: flex;
  align-items: center;
  justify-content: space-between;
  padding: 0 7%;
}

.brand-area {
  display: flex;
  align-items: center;
  gap: 14px;
  color: white;
}

.nav-logo {
  width: 48px;
  height: 48px;
  object-fit: contain;
  border-radius: 50%;
  box-shadow: 0 0 24px rgba(201, 169, 106, 0.25);
  background: rgba(239, 228, 212, 0.06);
}

.brand-area h1 {
  color: #f0d79a;
  font-size: 18px;
  letter-spacing: 4px;
  font-weight: normal;
}

.brand-area p {
  color: rgba(255, 255, 255, 0.58);
  font-size: 10px;
  letter-spacing: 3px;
  margin-top: 4px;
}

.desktop-menu {
  display: flex;
  align-items: center;
  gap: 8px;
}

.desktop-menu a {
  color: rgba(255, 255, 255, 0.78);
  font-size: 14px;
  padding: 11px 15px;
  border-radius: 30px;
  transition: 0.3s ease;
}

.desktop-menu a:hover {
  color: #f0d79a;
  background: rgba(255, 255, 255, 0.08);
  transform: translateY(-2px);
}

.desktop-menu .menu-gold {
  background: #c9a96a;
  color: #071a2f;
  margin-left: 6px;
}

.desktop-menu .menu-gold:hover {
  background: #d9bd7f;
  color: #071a2f;
}

/* MOBILE MENU BUTTON */

.mobile-menu-button {
  display: none;
  width: 44px;
  height: 44px;
  border: 1px solid rgba(201, 169, 106, 0.55);
  background: transparent;
  color: #f0d79a;
  border-radius: 50%;
  font-size: 24px;
  cursor: pointer;
}

/* MOBILE MENU */

.mobile-menu {
  position: fixed;
  inset: 0;
  z-index: 2000;
  background: #071a2f;
  display: none;
  flex-direction: column;
  padding: 90px 28px 28px;
  gap: 16px;
}

.mobile-menu.active {
  display: flex;
}

.mobile-menu a {
  color: white;
  font-size: 28px;
  padding: 22px;
  border: 1px solid rgba(201, 169, 106, 0.22);
  border-radius: 24px;
  background: rgba(255, 255, 255, 0.03);
}

.close-menu {
  position: absolute;
  top: 24px;
  right: 28px;
  width: 44px;
  height: 44px;
  border: 1px solid rgba(201, 169, 106, 0.55);
  background: transparent;
  color: #f0d79a;
  border-radius: 50%;
  font-size: 30px;
  cursor: pointer;
}

/* =========================
   HERO SECTION
   ========================= */

.hero-section {
  min-height: 100vh;
  background:
    radial-gradient(circle at 78% 18%, rgba(201, 169, 106, 0.22), transparent 28%),
    radial-gradient(circle at 15% 75%, rgba(255, 255, 255, 0.08), transparent 25%),
    #071a2f;
  color: white;
  display: grid;
  grid-template-columns: 1.05fr 0.95fr;
  align-items: center;
  gap: 50px;
  padding: 145px 7% 90px;
  position: relative;
  overflow: hidden;
}

.hero-section::after {
  content: "";
  position: absolute;
  left: 0;
  right: 0;
  bottom: 0;
  height: 180px;
  background: linear-gradient(to top, #efe4d4, transparent);
  pointer-events: none;
}

.hero-content {
  position: relative;
  z-index: 2;
  animation: fadeUp 1s ease forwards;
}

.small-label,
.section-label {
  color: #8d6f3d;
  font-size: 13px;
  letter-spacing: 5px;
  margin-bottom: 22px;
  text-transform: uppercase;
}

.hero-content h2 {
  max-width: 900px;
  font-size: clamp(52px, 7vw, 96px);
  line-height: 0.98;
  letter-spacing: -3px;
  font-weight: normal;
}

.hero-content h2 span {
  color: #f0d79a;
}

.hero-description {
  max-width: 700px;
  margin-top: 28px;
  color: rgba(255, 255, 255, 0.72);
  font-size: 20px;
  line-height: 1.8;
}

.main-tagline {
  margin-top: 24px;
  color: #f0d79a;
  font-size: 30px;
}

.hero-buttons {
  margin-top: 36px;
  display: flex;
  gap: 16px;
  flex-wrap: wrap;
}

.primary-button,
.secondary-button {
  padding: 16px 28px;
  border-radius: 40px;
  transition: 0.3s ease;
  font-size: 16px;
}

.primary-button {
  background: #c9a96a;
  color: #071a2f;
}

.secondary-button {
  color: #f0d79a;
  border: 1px solid rgba(201, 169, 106, 0.55);
}

.primary-button:hover,
.secondary-button:hover {
  transform: translateY(-3px);
}

.secondary-button:hover {
  background: rgba(255, 255, 255, 0.08);
}

/* HERO LOGO */

.hero-visual {
  min-height: 500px;
  position: relative;
  z-index: 2;
  display: flex;
  align-items: center;
  justify-content: center;
}

.hero-logo-image {
  width: min(430px, 82vw);
  height: auto;
  object-fit: contain;
  animation: slowFloat 5s ease-in-out infinite;
  filter: drop-shadow(0 0 45px rgba(201, 169, 106, 0.28));
}

.floating-card {
  position: absolute;
  border: 1px solid rgba(201, 169, 106, 0.22);
  background: rgba(255, 255, 255, 0.06);
  backdrop-filter: blur(15px);
  border-radius: 28px;
  padding: 18px 22px;
  box-shadow: 0 20px 40px rgba(0, 0, 0, 0.18);
}

.floating-card p {
  color: rgba(255, 255, 255, 0.55);
  font-size: 14px;
}

.floating-card h3 {
  margin-top: 4px;
  color: #f0d79a;
  font-size: 25px;
  font-weight: normal;
}

.floating-card-one {
  left: 0;
  bottom: 70px;
}

.floating-card-two {
  right: 0;
  top: 70px;
}

/* =========================
   GENERAL SECTIONS
   ========================= */

.section {
  padding: 105px 7%;
}

.light-section {
  background: #efe4d4;
}

.dark-section {
  background:
    radial-gradient(circle at 85% 10%, rgba(201, 169, 106, 0.14), transparent 26%),
    #071a2f;
  color: white;
}

.section-title {
  max-width: 920px;
  font-size: clamp(36px, 5vw, 66px);
  line-height: 1.08;
  font-weight: normal;
  margin-bottom: 50px;
}

.white-title {
  color: white;
}

.gold-label {
  color: #f0d79a;
}

/* =========================
   CARDS
   ========================= */

.four-card-grid {
  display: grid;
  grid-template-columns: repeat(4, 1fr);
  gap: 22px;
}

.six-card-grid {
  display: grid;
  grid-template-columns: repeat(3, 1fr);
  gap: 22px;
}

.info-card,
.service-card,
.process-card,
.insight-card {
  background: rgba(255, 255, 255, 0.58);
  border: 1px solid rgba(201, 169, 106, 0.32);
  border-radius: 32px;
  padding: 32px;
  transition: 0.3s ease;
}

.info-card:hover,
.service-card:hover,
.process-card:hover,
.insight-card:hover {
  transform: translateY(-8px);
  box-shadow: 0 22px 45px rgba(7, 26, 47, 0.12);
}

.info-card h3,
.service-card h3,
.process-card h3 {
  font-size: 25px;
  line-height: 1.2;
  font-weight: normal;
  margin-bottom: 16px;
}

.info-card p,
.service-card p,
.process-card p {
  color: rgba(7, 26, 47, 0.68);
  line-height: 1.75;
  font-size: 15px;
}

.card-icon {
  width: 56px;
  height: 56px;
  background: #071a2f;
  color: #f0d79a;
  border-radius: 18px;
  display: flex;
  align-items: center;
  justify-content: center;
  font-size: 26px;
  margin-bottom: 28px;
}

.process-card span {
  display: block;
  color: #c9a96a;
  font-size: 50px;
  margin-bottom: 22px;
}

/* =========================
   INDIA UAE DESK
   ========================= */

.two-column {
  display: grid;
  grid-template-columns: 0.9fr 1.1fr;
  gap: 70px;
  align-items: start;
}

.desk-text p {
  color: rgba(255, 255, 255, 0.72);
  font-size: 18px;
  line-height: 1.85;
  margin-bottom: 24px;
}

.desk-points {
  display: grid;
  grid-template-columns: repeat(3, 1fr);
  gap: 15px;
  margin-top: 30px;
}

.desk-points div {
  border: 1px solid rgba(201, 169, 106, 0.22);
  background: rgba(255, 255, 255, 0.045);
  color: #f0d79a;
  border-radius: 24px;
  padding: 22px;
  font-size: 20px;
}

/* =========================
   PEOPLE
   ========================= */

.people-grid {
  display: grid;
  grid-template-columns: repeat(2, 1fr);
  gap: 20px;
}

.person-card {
  background: rgba(255, 255, 255, 0.045);
  border: 1px solid rgba(201, 169, 106, 0.22);
  border-radius: 32px;
  padding: 32px;
}

.avatar {
  width: 58px;
  height: 58px;
  border-radius: 50%;
  background: linear-gradient(135deg, #f0d79a, #8d6f3d);
  margin-bottom: 24px;
}

.person-card h3 {
  color: #f0d79a;
  font-size: 25px;
  font-weight: normal;
  margin-bottom: 14px;
}

.person-card p {
  color: rgba(255, 255, 255, 0.65);
  line-height: 1.75;
}

/* =========================
   INSIGHTS
   ========================= */

.insight-card p {
  color: #8d6f3d;
  font-size: 12px;
  letter-spacing: 4px;
  margin-bottom: 28px;
}

.insight-card h3 {
  font-size: 24px;
  line-height: 1.3;
  font-weight: normal;
  margin-bottom: 28px;
}

.insight-card a {
  color: #071a2f;
  font-size: 15px;
}

/* =========================
   START A MATTER
   ========================= */

.matter-section {
  background: #efe4d4;
  padding: 60px 7% 100px;
}

.matter-box {
  background:
    radial-gradient(circle at 95% 10%, rgba(201, 169, 106, 0.18), transparent 28%),
    #071a2f;
  color: white;
  border-radius: 44px;
  padding: 62px;
  display: grid;
  grid-template-columns: 1fr 0.85fr;
  gap: 55px;
  box-shadow: 0 28px 80px rgba(7, 26, 47, 0.22);
}

.matter-box h2 {
  font-size: clamp(38px, 5vw, 66px);
  line-height: 1.05;
  font-weight: normal;
}

.matter-box p {
  margin-top: 24px;
  color: rgba(255, 255, 255, 0.66);
  line-height: 1.8;
  font-size: 17px;
}

.contact-lines {
  margin-top: 28px;
  display: flex;
  flex-wrap: wrap;
  gap: 18px;
  color: rgba(255, 255, 255, 0.72);
}

.matter-form {
  display: grid;
  gap: 14px;
  background: rgba(255, 255, 255, 0.045);
  border: 1px solid rgba(201, 169, 106, 0.22);
  border-radius: 32px;
  padding: 24px;
}

.matter-form input,
.matter-form textarea {
  width: 100%;
  border: 1px solid rgba(201, 169, 106, 0.24);
  background: rgba(255, 255, 255, 0.05);
  color: white;
  padding: 17px;
  border-radius: 18px;
  font-family: inherit;
  font-size: 15px;
  outline: none;
}

.matter-form input::placeholder,
.matter-form textarea::placeholder {
  color: rgba(255, 255, 255, 0.42);
}

.matter-form input:focus,
.matter-form textarea:focus {
  border-color: rgba(201, 169, 106, 0.8);
}

.matter-form textarea {
  min-height: 115px;
  resize: vertical;
}

.matter-form button {
  border: none;
  background: #c9a96a;
  color: #071a2f;
  padding: 17px;
  border-radius: 18px;
  font-family: inherit;
  font-size: 16px;
  cursor: pointer;
  transition: 0.3s ease;
}

.matter-form button:hover {
  background: #d9bd7f;
  transform: translateY(-2px);
}

/* =========================
   FOOTER
   ========================= */

.footer {
  background: #071a2f;
  color: rgba(255, 255, 255, 0.55);
  padding: 42px 7%;
  border-top: 1px solid rgba(255, 255, 255, 0.08);
  display: grid;
  grid-template-columns: 0.8fr 1.4fr 0.7fr;
  gap: 40px;
}

.footer h3 {
  color: #f0d79a;
  font-weight: normal;
  letter-spacing: 4px;
  font-size: 20px;
  margin-bottom: 10px;
}

.footer-tagline {
  color: #f0d79a;
  margin-top: 18px;
}

.disclaimer {
  font-size: 13px;
  line-height: 1.7;
}

.footer-links {
  display: grid;
  gap: 10px;
}

.footer-links a {
  color: rgba(255, 255, 255, 0.55);
  font-size: 14px;
  transition: 0.3s ease;
}

.footer-links a:hover {
  color: #f0d79a;
}

/* =========================
   ANIMATIONS
   ========================= */

@keyframes fadeUp {
  from {
    opacity: 0;
    transform: translateY(26px);
  }

  to {
    opacity: 1;
    transform: translateY(0);
  }
}

@keyframes slowFloat {
  0% {
    transform: translateY(0);
  }

  50% {
    transform: translateY(-12px);
  }

  100% {
    transform: translateY(0);
  }
}

/* =========================
   RESPONSIVE DESIGN
   ========================= */

@media (max-width: 1100px) {
  .desktop-menu {
    display: none;
  }

  .mobile-menu-button {
    display: block;
  }

  .hero-section {
    grid-template-columns: 1fr;
    padding-top: 120px;
  }

  .hero-visual {
    order: -1;
    min-height: 360px;
  }

  .hero-logo-image {
    width: min(320px, 78vw);
  }

  .floating-card-one {
    left: 5%;
    bottom: 30px;
  }

  .floating-card-two {
    right: 5%;
    top: 20px;
  }

  .four-card-grid,
  .six-card-grid {
    grid-template-columns: repeat(2, 1fr);
  }

  .two-column {
    grid-template-columns: 1fr;
    gap: 38px;
  }

  .matter-box {
    grid-template-columns: 1fr;
  }

  .footer {
    grid-template-columns: 1fr;
  }
}

@media (max-width: 700px) {
  .navbar {
    padding: 0 20px;
  }

  .nav-logo {
    width: 42px;
    height: 42px;
  }

  .brand-area h1 {
    font-size: 14px;
    letter-spacing: 2px;
  }

  .brand-area p {
    font-size: 9px;
    letter-spacing: 1.5px;
  }

  .hero-section {
    padding: 115px 6% 70px;
  }

  .hero-content h2 {
    font-size: 49px;
    letter-spacing: -2px;
  }

  .hero-description {
    font-size: 17px;
  }

  .main-tagline {
    font-size: 24px;
  }

  .hero-buttons {
    flex-direction: column;
  }

  .primary-button,
  .secondary-button {
    text-align: center;
  }

  .section {
    padding: 78px 6%;
  }

  .section-title {
    font-size: 38px;
  }

  .four-card-grid,
  .six-card-grid,
  .people-grid,
  .desk-points {
    grid-template-columns: 1fr;
  }

  .matter-section {
    padding: 40px 6% 80px;
  }

  .matter-box {
    padding: 34px;
    border-radius: 32px;
  }

  .matter-box h2 {
    font-size: 38px;
  }

  .intro-controls {
    left: 20px;
    right: 20px;
    bottom: 20px;
    justify-content: center;
  }

  .intro-controls button {
    padding: 11px 14px;
    font-size: 13px;
  }

  .floating-card {
    display: none;
  }
}