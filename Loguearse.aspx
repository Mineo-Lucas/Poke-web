<%@ Page Title="" Language="C#" MasterPageFile="~/masterpag.Master" AutoEventWireup="true" CodeBehind="Loguearse.aspx.cs" Inherits="Poke_Web.Registrarse" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div>
    <h1>Loguearse</h1>
</div>
<div>
    <asp:Label ID="LblEmail" runat="server" Text="User:"></asp:Label>
    <asp:TextBox ID="TxtEmail" runat="server" placeholder=
        "Ejemplo@123.com" CssClass="input-group-text" TextMode="Email"></asp:TextBox>
</div>
    <div>
    <asp:Label ID="LblPass" runat="server" Text="Pass:"></asp:Label>
    <asp:TextBox ID="TxtPass" runat="server" placeholder="******" CssClass="input-group-text" TextMode="Password"></asp:TextBox>
</div>
    <div>
        <asp:Button ID="BtnAceptar" runat="server" Text="Confirmar" CssClass="btn btn-primary" OnClick="BtnAceptar_Click"/>
        <a href="Tarjetas.aspx">Cancelar</a>
    </div>
</asp:Content>





