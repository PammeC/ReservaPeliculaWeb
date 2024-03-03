<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Layout.Master" AutoEventWireup="true" CodeBehind="RegistroReservas.aspx.cs" Inherits="SitioReservaPeliculas.UI.RegistroReservas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="titulo" runat="server">Registro Peliculas</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="cuerpo" runat="server">

    <div class="container mt-4">
        <!-- Panel para mostrar alerta en caso de error -->
        <asp:Panel runat="server" Visible='<%# Alerta %>'>
            <div class="alert alert-dismissible alert-danger fade show" role="alert">
                <button type="button" class="close" data-dismiss="alert" aria-label="Close">
                    <span aria-hidden="true">&times;</span>
                </button>
                <!-- Etiqueta para mostrar el mensaje de alerta -->
                <asp:Label ID="Label_Alerta" runat="server" Text=""></asp:Label>
            </div>
        </asp:Panel>
        <!-- Panel para mostrar información exitosa -->
        <asp:Panel runat="server" Visible='<%# Info %>'>
            <div class="alert alert-dismissible alert-success fade show" role="alert">
                <button type="button" class="close" data-dismiss="alert" aria-label="Close">
                    <span aria-hidden="true">&times;</span>
                </button>
                <!-- Etiqueta para mostrar el mensaje de información exitosa -->
                <asp:Label ID="Label_Info" runat="server" Text=""></asp:Label>
            </div>
        </asp:Panel>
    </div>

    <!-- Formulario para registrar reservas -->
    <form id="form2" runat="server">
        <div class="container">
            <div class="row">
                <!-- Columna para seleccionar cliente y pelicula -->
                <div class="col-md-6 d-inline-block ml-5">
                    <div class="card mt-5 text-center">
                        <div class="card-header">
                            <h3>Registro Reserva</h3>
                        </div>
                        <div class="card-body">
                            <div class="form-group">
                                <!-- Etiqueta para seleccionar cliente -->
                                <asp:Label ID="Label1" runat="server" Text="Seleccione Cliente"></asp:Label>
                                <!-- Lista desplegable para seleccionar cliente -->
                                <asp:DropDownList ID="DropDownList_Cliente" runat="server" CssClass="form-control"></asp:DropDownList>
                            </div>
                            <div class="form-group">
                                <!-- Etiqueta para seleccionar pelicula -->
                                <asp:Label ID="Label3" runat="server" Text="Seleccione Pelicula"></asp:Label>
                                <!-- Lista desplegable para seleccionar pelicula -->
                                <asp:DropDownList ID="DropDownList_Pelicula" runat="server" CssClass="form-control"></asp:DropDownList>
                            </div>
                            <!-- Botón para registrar la reserva -->
                            <asp:Button ID="Button_Registrar" runat="server" Text="Registrar" OnClick="Button_Registrar_Click" CssClass="btn btn-primary btn-block mt-4" />
                        </div>
                    </div>
                </div>

                <!-- Columna para seleccionar horario -->
                <div class="col-md-4 d-inline-block">
                    <div class="card mt-5 text-center">
                        <div class="card-header">
                            <h5>Seleccione Horario</h5>
                        </div>
                        <div class="card-body">
                            <div class="form-group">
                                <!-- Etiqueta para seleccionar fecha de la reserva -->
                                <asp:Label ID="Label6" runat="server" Text="Seleccione fecha reserva"></asp:Label>
                                <div class="mx-2">
                                    <!-- Cuadro de texto para seleccionar fecha de la reserva -->
                                    <asp:TextBox ID="datePicker" runat="server" CssClass="date-picker"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">                            
                                <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css">
                                <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
                                <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.min.js"></script>
                                <input type="text" id="timePicker" runat="server" />
                                <script>
                                        $(function () {
                                            // Configuración del timePicker
                                            $('#timePicker').timepicker({
                                                'timeFormat': 'H:i', // Formato de 24 horas
                                                'minTime': '09:00', // Hora mínima
                                                'maxTime': '17:00', // Hora máxima
                                                'step': 60, // Intervalo de minutos
                                                'disableTextInput': true // Deshabilitar la entrada de texto manual
                                            });
                                        });
                                </script>
                                </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </form>
</asp:Content>

