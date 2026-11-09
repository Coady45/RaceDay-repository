
:root {
    --background: #0b0f19;
    --surface: #141b2a;
    --accent: #ff7a1a;
    --accent - hover: #e96508;
    --text: #f8fafc;
    --muted: #a7b0c0;
    --border: #283246;
}

* {
    box - sizing: border - box;
}

html {
    scroll-behavior: smooth;
scroll - padding - top: 90px;
}

body {
    margin: 0;
font - family: Arial, Helvetica, sans-serif;
background: var(--background);
color: var(--text);
line - height: 1.6;
}

a {
    color: inherit;
text - decoration: none;
}

/* Navigation */
.navbar {
    min-height: 76px;
padding: 18px 7%;
display: flex;
align - items: center;
justify - content: space - between;
gap: 24px;
background: #0b0f19;
    border - bottom: 1px solid var(--border);
}

.brand {
    font-size: 25px;
font - weight: 900;
letter - spacing: 1px;
}

.brand span
{
    color: var(--accent);
}

.navbar nav
{
    display: flex;
    align-items: center;
    gap: 28px;
}

.navbar nav a {
    color: var(--muted);
font - size: 14px;
transition: color 0.2s ease;
}

.navbar nav a:hover {
    color: var(--accent);
}

.navbar nav .nav - button {
color: white;
border: 1px solid var(--accent);
    border - radius: 6px;
padding: 9px 15px;
}

/* Hero section */
.hero {
    min-height: 570px;
padding: 100px 7%;
display: flex;
align - items: center;
background:
radial - gradient(
    ellipse at 85 % 20 %,
    rgba(255, 122, 26, 0.16),
    transparent 45 %

),
        linear - gradient(135deg, #0b0f19, #151d2d);
}

.hero - content {
    max - width: 760px;
}

.eyebrow {
    color: var(--accent);
font - size: 12px;
font - weight: bold;
letter - spacing: 3px;
margin - bottom: 18px;
}

.hero h1
{
    font-size: clamp(42px, 6vw, 72px);
    line-height: 1.08;
    letter-spacing: -2px;
    margin: 0 0 24px;
}

.hero h1 span {
    color: var(--accent);
}

.hero - description {
    max - width: 580px;
color: var(--muted);
    font - size: 17px;
    margin - bottom: 30px;
}

.hero - actions {
display: flex;
    flex - wrap: wrap;
gap: 14px;
}

.btn - primary,
.btn - secondary {
display: inline - block;
padding: 13px 23px;
    border - radius: 6px;
    font - size: 14px;
    font - weight: bold;
transition: background 0.2s ease, transform 0.2s ease;
}

.btn - primary {
background: var(--accent);
color: #111827;
}

.btn - primary:hover {
    background: var(--accent - hover);
transform: translateY(-2px);
}

.btn - secondary {
color: white;
border: 1px solid #596579;
}

.btn - secondary:hover {
    background: var(--surface);
}

.hero - note {
color: var(--muted);
    font - size: 13px;
    margin - top: 25px;
}

/* General sections */
.section {
    padding: 85px 7%;
}

.section - heading {
    text - align: center;
    max - width: 650px;
margin: 0 auto 42px;
}

.section - heading h2,
.about h2 {
    font-size: clamp(28px, 4vw, 40px);
line - height: 1.2;
margin: 0 0 16px;
}

.section - heading > p:last - child,
.about > p:not(.eyebrow) {
color: var(--muted);
}

/* Feature cards */
.features {
    background: #0e1420;
}

.feature - grid {
display: grid;
    grid - template - columns: repeat(3, minmax(0, 1fr));
gap: 22px;
}

.feature - card {
padding: 28px;
border: 1px solid var(--border);
    border - radius: 12px;
background: var(--surface);
transition: transform 0.2s ease, border-color 0.2s ease;
}

.feature - card:hover {
    transform: translateY(-4px);
border - color: var(--accent);
}

.feature - number {
color: var(--accent);
    font - size: 13px;
    font - weight: bold;
    letter - spacing: 2px;
}

.feature - card h3 {
    font-size: 21px;
margin: 18px 0 10px;
}

.feature - card p {
    color: var(--muted);
font - size: 14px;
margin - bottom: 0;
}

/* About section */
.about {
    max-width: 850px;
margin: 0 auto;
text - align: center;
}

.about > p:not(.eyebrow) {
margin: 20px auto 28px;
    max - width: 650px;
}

/* Footer */
.footer {
    padding: 30px 7%;
border - top: 1px solid var(--border);
text - align: center;
color: var(--muted);
font - size: 13px;
}

.footer.brand {
color: var(--text);
    font - size: 20px;
}

/* Mobile responsiveness */
@media(max - width: 700px) {
    .navbar {
        flex - direction: column;
    padding: 20px;
    }

    .navbar nav {
        flex - wrap: wrap;
        justify - content: center;
    gap: 16px;
    }

    .hero {
        min - height: auto;
    padding: 75px 24px;
    }

    .hero h1 {
        letter - spacing: -1px;
    }

    .section {
    padding: 65px 24px;
    }

    .feature - grid {
        grid - template - columns: 1fr;
    }
}
