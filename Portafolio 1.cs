<style> @import url('https://fonts.googleapis.com/css2?family=Roboto:ital,wght@0,400;0,500;0,700;0,900;1,500&family=Signika+Negative:wght@300;400;500;600&display=swap'); </style>
*{
    box-sizing: border-box;
    font family: "Work Sans";
    marging: 0;
    padding: 0;

}
html{
    scroll-behavior: smooth;
}
/* MENU ENCABEZADO */
.contendedor-header{
    background: #le2326;
    position: fixed;
    width: 100%;
    top: 0;
    left: 0;
    z-index: 99;
}
.contendedor-header header { 
    background: 1100 px;
    margin: auto;
    display: felx;
    justify-content: space-around;
    aling-items: center;
    padding: 15px 20px;
}
.contendedor-header header .logo a{
    font-family: "Roboto";
    font.size = 36px;
    color: #1CB698;
    text-decoration: none;
}
.contenedor.header header ul{
    display:flex;
    list-style: none;
}
.contenedor-header header nav ul li a{
    text-aling: none;
    color: #fff;
    margin: 0 15px;
    padding: 3px;
    transition: .5s;
    text.decoration: none;
}
.contenedor-header head nav ul li a {hover{
    color: #1CB698;
}
.nav-responsive{
    background-color: #1CB698:
    color: #fff;
    padding: 5px 10px;
    border-readius: 5px;
    cursor: pointer;
    display: none;
}
/* SECCION INICIO */
.inicio{
    background: linear-gradient(to top, rgba(30,35,38,,8), rgba(38,35,38,11),
    url{img/fondo.jpg};
    background-size: cover;
    height: 100vh;
    color: #ffffff;
    display: felx;
    aling-items: center;
}
.inicio .contendedor-banner{
    padding: 20px;
    background-color: #000000;
    max-width:350px;
    margin: auto;
    text-aling: center;
    border-radius: 40px;
}
.inicio .contendedor-banner img{
    margin-top: 40px;
    border: 10px; solid #1CB698;
    display: block;
    width: 80%;
    margin: auto;
    border-radius: 100%;
}
.inicio .contendedor-banner h1{
    margin-top: 40px;
    font-size:42px;
    font-family:""; /*FALTA COMPLETAR*/  
}
.inicio .contendedor-banner h2{
    font-size: 15px;
    font-weight: normal;
}
.inicio .contendedor-banner .redes a{
    color: #ffffff;
    display: inline-block;
    text-decoration: none;
    border: 1px solid: #fff;
    border-radius: 100%;
    width: 42px;
    height: 42px;
    line-header: 42px;
    margin: 40px 5px;
    font-size: 20px;
    transition: .3s;
}
.inicio .contendedor-banner .redes a hover{
    background-color: #1CB698;
}
