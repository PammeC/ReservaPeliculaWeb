<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Layout.Master" AutoEventWireup="true" CodeBehind="ListadoCategorias.aspx.cs" Inherits="SitioReservaPeliculas.UI.ListadoCategorias" %>

<asp:Content ID="Content1" ContentPlaceHolderID="titulo" runat="server">Listado Categorias</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="cuerpo" runat="server">

    <div class="row">
        <div class="col-md-10 offset-md-1">
            <div class="card mt-5 text-center">
                <div class="mt-3">
                    <h3>Listado Categorias</h3>
                </div>
                <form id="form1" runat="server">
                    <div>
                        <asp:GridView ID="GridView_Categorias" runat="server" AutoGenerateColumns="False" DataKeyNames="id" CssClass="table table-hover table-secondary"
                            OnRowEditing="GridView_Categorias_RowEditing" OnRowUpdating="GridView_Categorias_RowUpdating"
                            OnRowCancelingEdit="GridView_Categorias_RowCancelingEdit">
                            <Columns>
                                <asp:TemplateField HeaderText="Acciones">
                                    <ItemTemplate>
                                        <asp:Button runat="server" Text="Editar" CommandName="Edit" CssClass="btn btn-primary" />
                                        <asp:Button runat="server" Text="Eliminar" CommandName="Delete" CssClass="btn btn-danger" OnClientClick='<%# "showDeleteModal(\"ListadoCategorias.aspx/EliminarFila\", " + Eval("id") + "); return false;" %>' />
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:Button runat="server" Text="Modificar" CommandName="Update" CssClass="btn btn-success" />
                                        <asp:Button runat="server" Text="Cancelar" CommandName="Cancel" CssClass="btn btn-secondary" />
                                    </EditItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="id" HeaderText="ID" ReadOnly="true" />
                                <asp:TemplateField HeaderText="Nombre Categoria">
                                    <ItemTemplate>
                                        <asp:Label ID="LabelNombre" runat="server" oninput="validarTexto(this)" Text='<%# Bind("nombre") %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBoxNombre" runat="server" oninput="validarTexto(this)" Text='<%# Bind("nombre") %>'></asp:TextBox>
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
