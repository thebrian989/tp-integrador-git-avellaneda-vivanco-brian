/* Reseteo básico y variables */
* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
  font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
}

body {
  background-color: #f9f9f9;
  color: #333;
}

/* Header */
.header {
  display: flex;
  justify-content: space-between;
  align-items: center;
  padding: 1.5rem 5%;
  background-color: #2c2c2c;
  color: #fff;
}

.logo {
  font-size: 1.5rem;
  font-weight: bold;
  letter-spacing: 1px;
}

.nav a {
  color: #fff;
  text-decoration: none;
  margin-left: 1.5rem;
  transition: color 0.3s;
}

.nav a:hover {
  color: #d4a373;
}

/* Hero Section */
.hero {
  background: linear-gradient(rgba(0,0,0,0.6), rgba(0,0,0,0.6)), url('https://images.unsplash.com/photo-1555041469-a586c61ea9bc?q=80&w=1200') center/cover no-repeat;
  height: 60vh;
  display: flex;
  justify-content: center;
  align-items: center;
  text-align: center;
  color: #fff;
  padding: 0 1rem;
}

.hero-content h1 {
  font-size: 2.5rem;
  margin-bottom: 1rem;
}

.hero-content p {
  font-size: 1.2rem;
  margin-bottom: 1.5rem;
}

.btn {
  display: inline-block;
  padding: 0.8rem 1.8rem;
  background-color: #d4a373;
  color: #fff;
  text-decoration: none;
  border-radius: 4px;
  font-weight: bold;
  transition: background 0.3s;
}

.btn:hover {
  background-color: #bc8a5f;
}

/* Sección Productos */
.productos {
  padding: 4rem 5%;
  text-align: center;
}

.productos h2 {
  font-size: 2rem;
  margin-bottom: 2rem;
  color: #2c2c2c;
}

.grid-productos {
  display: grid;
  grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
  gap: 2rem;
}

.card {
  background-color: #fff;
  padding: 2rem;
  border-radius: 8px;
  box-shadow: 0 4px 6px rgba(0,0,0,0.1);
  transition: transform 0.3s;
}

.card:hover {
  transform: translateY(-5px);
}

.card-img {
  font-size: 3.5rem;
  margin-bottom: 1rem;
}

.card h3 {
  margin-bottom: 0.5rem;
  color: #2c2c2c;
}

.card p {
  font-size: 0.9rem;
  color: #666;
  margin-bottom: 1rem;
}

.precio {
  font-size: 1.3rem;
  font-weight: bold;
  color: #d4a373;
}

/* Footer */
.footer {
  background-color: #2c2c2c;
  color: #ccc;
  text-align: center;
  padding: 2rem 1rem;
  font-size: 0.9rem;
  line-height: 1.6;
}