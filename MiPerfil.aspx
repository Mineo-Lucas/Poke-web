
<%@ Page Title="" Language="C#" MasterPageFile="~/masterpag.Master" AutoEventWireup="true" CodeBehind="MiPerfil.aspx.cs" Inherits="Poke_Web.MiPerfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Mi perfil</h1>
    </div>
    <div>
        <asp:Label runat="server" Text="Nombre:"></asp:Label>
        <asp:TextBox runat="server" CssClass="input-group-text" ID="TxtNombre"></asp:TextBox>
    </div>
    <div>
        <asp:Label runat="server" Text="Apellido:"></asp:Label>
        <asp:TextBox runat="server" CssClass="input-group-text" ID="TxtApellido"></asp:TextBox>
    </div>
    <div>
        <asp:Label runat="server" Text="Imagen:"></asp:Label>
    </div>
    <div>
        <asp:Image ID="ImgMiPerfil" runat="server" CssClass="img-fluid mb3" ImageUrl="https://w7.pngwing.com/pngs/848/297/png-transparent-white-graphy-color-empty-banner-blue-angle-white.png"/>
    </div>
    <div>
        <input type="file" runat="server" class="form-control" id="TxtImagen"/>
    </div>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Fecha de nacimiento:"></asp:Label>
        <asp:TextBox ID="TxtFechaNacimiento" CssClass="input-group-text" runat="server" TextMode="Date" ></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="BtnAceptar" runat="server" Text="Modificar" CssClass="btn btn-primary" OnClick="BtnAceptar_Click"/>
    </div>
</asp:Content>
