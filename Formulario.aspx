<%@ Page Title="" Language="C#" MasterPageFile="~/masterpag.Master" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="Poke_Web.Formulario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <h1>Formulario</h1>
    <div>
        <asp:TextBox ID="TxtId" runat="server"></asp:TextBox>
    </div>
    <div>
    <asp:Label ID="LblNombre" runat="server" Text="Nombre:"></asp:Label>
    <asp:TextBox ID="TxtNombre" runat="server" CssClass="input-group-text" ></asp:TextBox>
    </div>
    <div>
    <asp:Label ID="Label1" runat="server" Text="Descripcion:" ></asp:Label>
    <asp:TextBox ID="TxtDescripcion" runat="server" CssClass="input-group-text"></asp:TextBox>
    </div>
    <div>
    <asp:Label ID="Label2" runat="server" Text="Numero:"></asp:Label>
    <asp:TextBox ID="TxtNumero" runat="server" CssClass="input-group-text"></asp:TextBox>
    </div>
    <div>
    <asp:Label ID="Label3" runat="server" Text="UrlImagen:"></asp:Label>
    <asp:TextBox ID="TxtUrlImagen" runat="server" CssClass="input-group-text"></asp:TextBox>
    <asp:Image ID="Image1" runat="server" />
    </div>
    <div>
        <asp:Label ID="Label4" runat="server" Text="Tipo:"></asp:Label>
        <asp:DropDownList ID="DdlTipo" runat="server" CssClass="input-group-text"></asp:DropDownList>
    </div>
    <div>
        <asp:Label ID="Label5" runat="server" Text="Debilidad:"></asp:Label>
        <asp:DropDownList ID="DdlDebilidad" runat="server" CssClass="input-group-text" ></asp:DropDownList>
    </div>
    <div>
        <asp:Button ID="BtnAgregar" runat="server" Text="Agregar" CssClass="btn btn-primary" OnClick="BtnAgregar_Click"/>
        <asp:Button ID="BtnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger"/>
    </div>
   
    
</asp:Content>
