<%@ Page Language="C#" MasterPageFile="~/UI/Layout.master" AutoEventWireup="true" CodeBehind="RegistroPeliculas.aspx.cs" Inherits="SitioReservaPeliculas.UI.RegistroPeliculas" %>


<asp:Content ID="Content1" ContentPlaceHolderID="titulo" runat="server">Listado de Peliculas</asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="cuerpo" runat="server">


    <div class="container mt-4">
        <asp:Panel runat="server" Visible='<%# Alerta %>'>
            <div class="alert alert-dismissible alert-danger fade show" role="alert">
                <button type="button" class="close" data-dismiss="alert" aria-label="Close">
                    <span aria-hidden="true">&times;</span>
                </button>
                <asp:Label ID="Label_Alerta" runat="server" Text=""></asp:Label>
            </div>
        </asp:Panel>
       
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
                    <h3>Registro Peliculas</h3>
                </div>
                <div class="card-body">
                    <form id="form2" runat="server">
                 
                        <div class="form-group">
                            <asp:Label ID="Label1" runat="server" Text="Ingrese Nombre de Pelicula"></asp:Label>
                            <asp:TextBox ID="TextBox_Nombre" runat="server" Text="" CssClass="form-control" oninput="validarTexto(this)"></asp:TextBox>
                        </div>
              
                        <div class="form-group">
                            <asp:Label ID="Label2" runat="server" Text="Ingrese Descripcion de la Pelicula"></asp:Label>
                            <asp:TextBox ID="TextBox_Descripcion" runat="server" Text="" CssClass="form-control" oninput="validarTexto(this)"></asp:TextBox>
                        </div>
            
                        <div class="form-group">
                            <asp:Label ID="Label3" runat="server" Text="Ingrese Categoria de pelicula"></asp:Label>
                            <asp:DropDownList ID="DropDownList_Categoria" runat="server" CssClass="form-control"></asp:DropDownList>
                        </div>

                        <asp:Button ID="Button_Registrar" runat="server" Text="Registrar" OnClick="Button_Registrar_Click" CssClass="btn btn-primary btn-block mt-4" />
                    </form>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
