body {
  font-family: "Shrikhand", serif;
  font-family: "Roboto", sans-serif;
}

.header {
  height: 63px;
  display: flex;
  flex-direction: column;
}
.header .logo {
  height: 63px;
  width: 100%;
  display: flex;
  justify-content: center;
  align-items: center;
  box-shadow: 0px 2px 4px 0px rgba(0, 0, 0, 0.15);
  z-index: 1;
}
.header .logo a {
  text-decoration: none;
  height: 75px;
}
.header .logo a img {
  display: none;
}
.header .logo a h1 {
  font-family: "Shrikhand";
  color: #101010;
  font-size: 30px;
  font-weight: 400;
}

footer {
  display: flex;
  flex-direction: column;
  padding-left: 20px;
  background-color: #353535;
  margin-top: 60px;
}
footer p {
  font-family: Shrikhand;
  font-size: 18px;
  font-weight: 400;
  margin-bottom: 0;
}
footer a {
  color: #fff;
  text-decoration: none;
}
footer ul {
  padding: 0;
  list-style-type: none;
  font-family: Roboto;
  font-size: 16px;
  font-weight: 400;
  line-height: 19px;
}
footer ul li {
  padding-bottom: 8px;
}
footer ul i {
  width: 20px;
  font-size: 14px;
  padding-right: 4px;
  color: #fff;
}

body {
  margin: 0;
  box-sizing: border-box;
}

.icon-location {
  height: 50px;
  width: 100%;
  display: flex;
  justify-content: center;
  align-items: center;
  background-color: #EAEAEA;
}
.icon-location i {
  font-size: medium;
  padding-right: 8px;
}

.icon-location input {
  border: none;
  background-color: #EAEAEA;
  font-family: Roboto;
  font-size: 16px;
  width: 109px;
  padding: 0 0 0 8px;
}
.icon-location input::placeholder {
  color: black;
  opacity: 1;
  font-weight: 500;
}

.top-section {
  background-color: #F6F6F6;
  height: auto;
  box-sizing: border-box;
  display: flex;
  flex-direction: column;
  align-items: center;
}

hgroup {
  text-align: center;
}
hgroup h2 {
  font-size: 24px;
  font-weight: 700;
  margin: 0 45px 0 45px;
  padding-top: 35px;
}
hgroup p {
  font-size: 18px;
  font-weight: 300;
  padding: 0 20px;
  margin-top: 10px;
}

.btn-gradient {
  width: 218px;
  height: 50px;
  border-radius: 25px;
  border: none;
  background: linear-gradient(0deg, #9356DC -11.44%, #FF79DA 123.93%);
  color: #fff;
  font-family: "Roboto";
  font-weight: 500;
  font-size: 16px;
  box-shadow: 0px 4px 10px 0px rgba(0, 0, 0, 0.2509803922);
  display: flex;
  justify-content: center;
  align-items: center;
  margin: 10px 0 45px 0;
}

.section-fonctionnement h2 {
  margin-left: 20px;
  margin-top: 50px;
  font-family: Roboto;
  font-size: 24px;
  font-weight: 700;
  line-height: 28px;
  letter-spacing: 0em;
  text-align: left;
}

ol {
  display: flex;
  align-items: center;
  flex-direction: column;
  padding: 0;
  margin: 0;
  counter-reset: liste;
}

.function-list {
  display: flex;
  flex-direction: row;
  align-items: baseline;
  width: 80%;
  border-radius: 20px;
  box-shadow: 0px 4px 15px 0px rgba(0, 0, 0, 0.1490196078);
  background: #F6F6F6;
  margin-bottom: 25px;
  padding: 0.7em;
}
.function-list::before {
  counter-increment: liste;
  content: counter(liste);
  background-color: #9356DC;
  color: white;
  border-radius: 50%;
  width: 24px;
  height: 24px;
  padding: 0;
  margin: 0;
  display: flex;
  justify-content: center;
  align-items: center;
  margin-left: -20px;
  font-size: 13px;
}
.function-list i {
  display: flex;
  justify-content: center;
  align-items: center;
  color: #7E7E7E;
  width: 18px;
  margin-left: 25px;
  font-size: 20px;
}
.function-list .fa-store {
  color: #9356DC;
}
.function-list p {
  margin-left: 25px;
  text-align: center;
  font-weight: 500;
  font-size: 16px;
  line-height: 19px;
  letter-spacing: 0em;
  text-align: left;
}

.section-restos {
  background: #F6F6F6;
  padding: 0 20px;
}
.section-restos h2 {
  padding-top: 50px;
  margin-bottom: 20px;
  font-size: 24px;
  font-weight: 700;
  line-height: 28px;
}
.section-restos .resto-cards {
  display: grid;
  grid-template-columns: 1fr;
  width: 100%;
  gap: 20px;
}
.section-restos a {
  width: 100%;
  height: 251px;
  text-decoration: none;
  color: inherit;
  box-shadow: 0px 4px 15px 0px rgba(0, 0, 0, 0.1019607843);
  border-radius: 20px;
}

.resto-card {
  height: 251px;
}
.resto-card figure {
  margin: 0;
  position: relative;
  height: 176px;
}
.resto-card img {
  height: 176px;
  width: 100%;
  object-fit: cover;
  box-sizing: border-box;
  border-radius: 20px 20px 0 0;
}
.resto-card span {
  position: absolute;
  right: 10px;
  top: 20px;
  font-family: Roboto;
  font-size: 14px;
  font-weight: 500;
  line-height: 16px;
  letter-spacing: 0em;
  width: 80px;
  height: 29px;
  color: #008766;
  background-color: #99E2D0;
  border-radius: 2px;
  display: flex;
  justify-content: center;
  align-items: center;
}
.resto-card .bottom-card {
  height: 30%;
  background-color: #fff;
  display: flex;
  border-radius: 0 0 20px 20px;
  position: relative;
}
.resto-card .bottom-card i {
  position: absolute;
  font-size: 25px;
  right: 30px;
  top: 15px;
}
.resto-card .text-card {
  padding-left: 10px;
}
.resto-card .text-card h3 {
  font-size: 18px;
  margin: 15px 0 4px 0;
}
.resto-card .text-card p {
  margin: 0;
  font-size: 17px;
  font-weight: 300;
}

figure {
  margin: 0;
}
figure #img-header {
  height: 275px;
  width: 100%;
  object-fit: cover;
  box-sizing: border-box;
}

.main-container {
  width: 100%;
  padding-left: 20px;
  border-radius: 40px 40px 0 0;
  background-color: #F6F6F6;
  box-sizing: border-box;
  margin-top: -40px;
  position: relative;
}
.main-container h3 {
  font-size: 16px;
  font-weight: 300;
  margin-bottom: 5px;
}
.main-container .line {
  width: 40px;
  margin-left: 0;
  background-color: #99E2D0;
  height: 3px;
  border: none;
  margin-top: 0;
}

#menu-title-heart {
  display: flex;
  position: relative;
  height: 80px;
}
#menu-title-heart h2 {
  font-family: Shrikhand;
  font-size: 28px;
  font-weight: 400;
  margin-top: 30px;
}
#menu-title-heart i {
  position: absolute;
  right: 40px;
  top: 40px;
  font-size: 23px;
}

.entrees-menus {
  display: grid;
  grid-template-columns: 1fr;
  width: 100%;
  border: 1px solid red;
}

/*# sourceMappingURL=style.cs.map */
