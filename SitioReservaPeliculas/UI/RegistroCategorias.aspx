<%@ Page Language="C#" MasterPageFile="~/UI/Layout.master" AutoEventWireup="true" CodeBehind="RegistroCategorias.aspx.cs" Inherits="SitioReservaPeliculas.UI.RegistroCategorias" %>

<asp:Content ID="Content1" ContentPlaceHolderID="titulo" runat="server">Registro Categorias de Peliculas</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cuerpo" runat="server">

    <div class="container mt-4">
        <!-- Panel para mostrar alertas de error -->
        <asp:Panel runat="server" Visible='<%# Alerta %>'>
            <div class="alert alert-dismissible alert-danger fade show" role="alert">
                <button type="button" class="close" data-dismiss="alert" aria-label="Close">
                    <span aria-hidden="true">&times;</span>
                </button>
                <asp:Label ID="Label_Alerta" runat="server" Text=""></asp:Label>
            </div>
        </asp:Panel>
        <!-- Panel para mostrar mensajes informativos -->
        <asp:Panel runat="server" Visible='<%# Info %>'>
            <div class="alert alert-dismissible alert-success fade show" role="alert">
                <button type="button" class="close" data-dismiss="alert" aria-label="Close">
                    <span aria-hidden="true">&times;</span>
                </button>
                <asp:Label ID="Label_Info" runat="server" Text=""></asp:Label>
            </div>
        </asp:Panel>
    </div>

    <div class="row">
        <div class="col-md-4 offset-md-4">
            <div class="card mt-5 text-center">
                <div class="card-header">
                    <h3>Registro de Categorias de Peliculas</h3>
                </div>
                <div class="card-body">
                    <form id="form2" runat="server">
                        <!-- Campo para ingresar nueva categorias -->
                        <div class="form-group">
                            <asp:Label ID="Label1" runat="server" Text="Ingrese Nueva Categoria"></asp:Label>
                            <asp:TextBox ID="TextBox_Nombre" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                        </div>
                        <!-- Botón para registrar la nueva categorias -->
                        <asp:Button ID="Button_Registrar" runat="server" Text="Registrar" OnClick="Button_Registrar_Click" CssClass="btn btn-primary btn-block mt-4" />
                    </form>
                </div>
            </div>
        </div>
    </div>

</asp:Content>

