<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Layout.Master" AutoEventWireup="true" CodeBehind="ListadoReservas.aspx.cs" Inherits="SitioReservaPeliculas.UI.ListadoReservas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="titulo" runat="server">Listado Reservas</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="cuerpo" runat="server">

    <div class="row">
        <div class="col-md-10 offset-md-1">
            <div class="card mt-5 text-center">
                <div class="mt-3">
                    <h3>Listado Reservas</h3>
                </div>
                <form id="form1" runat="server">
                    <div>
                        <asp:GridView ID="GridView_Reservas" runat="server" AutoGenerateColumns="False" DataKeyNames="id" CssClass="table table-hover table-secondary"
                             OnRowUpdating="GridView_Reservas_RowUpdating" OnRowEditing="GridView_Reservas_RowEditing"
                            OnRowCancelingEdit="GridView_Reservas_RowCancelingEdit">
                            <Columns>
                                <asp:TemplateField HeaderText="Acciones">
                                    <ItemTemplate>
                                        <asp:Button runat="server" Text="Editar" CommandName="Edit" CssClass="btn btn-primary" />
                                        <asp:Button runat="server" Text="Eliminar" CommandName="Delete" CssClass="btn btn-danger" OnClientClick='<%# "showDeleteModal(\"ListadoReservas.aspx/EliminarFila\", " + Eval("id") + "); return false;" %>' />
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:Button runat="server" Text="Modificar" CommandName="Update" CssClass="btn btn-success" />
                                        <asp:Button runat="server" Text="Cancelar" CommandName="Cancel" CssClass="btn btn-secondary" />
                                    </EditItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="id" HeaderText="ID" ReadOnly="true" />
                                <asp:TemplateField HeaderText="Cliente">
                                    <ItemTemplate>
                                        <asp:Label ID="LabelCliente" runat="server" Text='<%# Bind("Cliente") %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBoxCliente" runat="server" Text='<%# Bind("Cliente") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                </asp:TemplateField>
                                
                                <asp:TemplateField HeaderText="Fecha">
                                    <ItemTemplate>
                                        <asp:Label ID="LabelFecha" runat="server" Text='<%# ObtenerFechaSinHoraEnFormato(Convert.ToDateTime(Eval("Fecha"))) %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBoxFecha" runat="server" Text='<%# ObtenerFechaSinHoraEnFormato(Convert.ToDateTime(Eval("Fecha"))) %>'></asp:TextBox>
                                    </EditItemTemplate>
                                </asp:TemplateField>


                                <asp:TemplateField HeaderText="Hora">
                                    <ItemTemplate>
                                        <asp:Label ID="LabelHora" runat="server" Text='<%# Bind("Hora") %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBoxHora" runat="server" Text='<%# Bind("Hora") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Pelicula">
                                    <ItemTemplate>
                                        <asp:Label ID="LabelPelicula" runat="server" Text='<%# Bind("Pelicula") %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBoxPelicula" runat="server" Text='<%# Bind("Pelicula") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </div>
                </form>
            </div>
        </div>
    </div>

</asp:Content>

