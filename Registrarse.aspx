<%@ Page Title="" Language="C#" MasterPageFile="~/masterpag.Master" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="Poke_Web.Registrarse" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div>
    <h1>Registro</h1>
</div>
<div>
    <asp:Label ID="LblUser" runat="server" Text="User:"></asp:Label>
    <asp:TextBox ID="TxtUser" runat="server" placeholder="user name
        " CssClass="input-group-text"></asp:TextBox>
</div>
    <div>
    <asp:Label ID="LblPass" runat="server" Text="Pass:"></asp:Label>
    <asp:TextBox ID="TxtPass" runat="server" placeholder="******" CssClass="input-group-text"></asp:TextBox>
</div>
    <div>
        <asp:Button ID="BtnAceptar" runat="server" Text="Confirmar" CssClass="btn btn-primary" OnClick="BtnAceptar_Click"/>
    </div>
</asp:Content>





