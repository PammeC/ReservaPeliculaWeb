<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PrincipalAdmin.aspx.cs" Inherits="SitioReservaPeliculas.UI.PrincipalAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>ADMINISTRADOR</title>f
    <link rel="icon" type="image/x-icon" href="../img/palomitas-de-maiz.ico" />
    <!-- Core theme CSS (includes Bootstrap)-->
    <link href="../css/stylesBootstrap.css" rel="stylesheet" />
    <!-- Font Awesome icons (free version)-->
    <script src="https://use.fontawesome.com/releases/v6.3.0/js/all.js" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
</head>
<body runat="server">
    <form runat="server" method="post">
        <nav class="navbar navbar-expand-lg bg-secondary text-uppercase fixed-top" id="mainNav">
            <div class="container-fluid">
                <div class="logo">
                    <a href="InicioReservaPelicula.aspx">
                        <img src="../img/palomitas-de-maiz.ico" alt="" style="height: 80px; width: 80px" /></a>
                    <a href="InicioReservaPelicula.aspx" class="navbar-brand">CINEMAK</a>
                </div>
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#opciones">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse justify-content-center" id="opciones">
                    <ul class="navbar-nav">
                        <li class="nav-item">
                            <a class="nav-link">Inicio</a>
                        </li>
                        <!--CLIENTES-->
                        <li class="nav-item dropdown">
                            <a class="nav-link dropdown-toggle" href="#" role="button" data-bs-toggle="dropdown">CLIENTES
                            </a>
                            <ul class="dropdown-menu">
                                <li>
                                    <a class="dropdown-item" href="RegistroClientes.aspx">Registro de Clientes
                                    </a>
                                </li>
                                <li>
                                    <asp:HyperLink class="dropdown-item" runat="server" NavigateUrl="ListadoClientes.aspx" OnServerClick="btnCerrar_Click">
                                Lista de Clientes
                                    </asp:HyperLink>
                                </li>
                            </ul>

                            <!--CATEGORIAS-->
                            <li class="nav-item dropdown">
                                <a class="nav-link dropdown-toggle" href="RegistroCategorias.aspx" role="button" data-bs-toggle="dropdown">Categorias
                                </a>
                                <ul class="dropdown-menu">
                                    <li>
                                        <a class="dropdown-item" href="RegistroCategorias.aspx">Registro de Categorias
                                        </a>
                                    </li>
                                    <li>
                                        <a class="dropdown-item" href="ListadoCategorias.aspx">Lista de Categorias
                                        </a>
                                    </li>
                                </ul>
                            </li>

                            <!--Peliculas-->
                            <li class="nav-item dropdown">
                                <a class="nav-link dropdown-toggle" href="ListadoPeliculas.aspx" role="button" data-bs-toggle="dropdown">Peliculas
                                </a>
                                <ul class="dropdown-menu">
                                    <li>
                                        <a class="dropdown-item" href="RegistroPeliculas.aspx">Registro de Peliculas
                                        </a>
                                    </li>
                                    <li>
                                        <a class="dropdown-item" href="ListadoPeliculas.aspx">Lista de Peliculas
                                        </a>
                                    </li>
                                </ul>
                            </li>
                            <li class="nav-item dropdown">
                                <a class="nav-link dropdown-toggle" href="ListadoReservas.aspx" role="button" data-bs-toggle="dropdown">Reservas
                                </a>
                                <ul class="dropdown-menu">
                                    <li>
                                        <a class="dropdown-item" href="RegistroReservas.aspx">Registro de Reservas de Peliculas
                                        </a>
                                    </li>
                                    <li>
                                        <a class="dropdown-item" href="ListadoReservas.aspx">Lista de Reservas
                                        </a>
                                    </li>
                                </ul>
                            </li>
                    </ul>

                    <!--BUTÓN DE SALIR-->

                    <asp:Button type="button" class="btn btn-danger" OnClick="btnCerrar_Click" runat="server" Text="Cerrar Sesión"></asp:Button>
                </div>
            </div>
        </nav>
    </form>
    <script src="https://cdn.startbootstrap.com/sb-forms-latest.js"></script>


    <header class="masthead bg-primary text-white text-center">
        <div class="container d-flex align-items-center flex-column">
            <!-- Masthead Avatar Image-->
            <img class="masthead-avatar mb-5" src="../img/admin.png" alt="..." />
            <!-- Masthead Heading-->
            <h1 class="masthead-heading text-uppercase mb-0">Bienvenido Administrador</h1>
            <!-- Icon Divider-->
            <div class="divider-custom divider-light">
                <div class="divider-custom-line"></div>
                <div class="divider-custom-icon"><i class="fas fa-star"></i></div>
                <div class="divider-custom-line"></div>
            </div>
           
            <!-- Masthead Subheading-->
            <p class="masthead-subheading font-weight-light mb-0"></p>
        </div>
    </header>
</body>
</html>
