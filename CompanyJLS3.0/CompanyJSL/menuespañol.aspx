<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menuespañol.aspx.cs" Inherits="CompanyJSL.menuespañol" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" href="Content/Bootn.min.css" />
</head>
<body>
    <form id="form1" runat="server">
        <main class="head">
           
            <div class="Johan">
                <a class="#">Platos</a>
            </div>
            <div>
                <section class="Paella">
                    <h1 class="Title">Paella Valenciana</h1>
                    <img src="Imagenes/paella_valenciana.jpg" wigth="15px" height="200" />
                    <p>Este plato tiene como ingredientes: Arroz, carne de pollo, Carne de conejo, Tomate triturado, Pimentón dulce, Colorante, entre otros</p>
                    <a href="#">Precio</a>
                </section>
                <section class="Gazpacho">
                    <h1 class="Title">Gazpacho</h1>
                    <img src="Imagenes/Gazpacho_Cazuela_Barro.jpg" wight="15px" height="200" />
                    <p>Este plato tiene como ingredientes: Tomate, Pimentón, Ajo, Cebolla, Vinagre, Sal, Pimienta negra, entre otros.</p>
                    <a href="#">Precio</a>
                </section>
                <section class="Tortilladepatata">
                    <h1 class="Title">Tortilla de patata</h1>
                    <img src="Imagenes/1606754177821.jpg" wigth="15px" height="200" />
                    <p>Este plato tiene como ingredientes: Huevos, Papas, Sal, Aceite de oliva y Cebolla.</p>
                    <a href="#">Precio</a>
                </section>
            </div>
        </main>

    </form>
    <nav>
        <h1></h1>
        <p>&copy;<%: DateTime.Now.Year%> - CompanyJLS </p>
    </nav>
</body>

</html>
