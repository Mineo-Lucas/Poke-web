<%@ Page Title="" Language="C#" MasterPageFile="~/masterpag.Master" AutoEventWireup="true" CodeBehind="EnviarEmail.aspx.cs" Inherits="Poke_Web.EnviarEmail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div>
<h1>Envio de email</h1>
</div>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Email:"></asp:Label>
        <asp:TextBox ID="TxtEmail" runat="server" CssClass="input-group-text" TextMode="Email"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label2" runat="server" Text="Asunto:"></asp:Label>
        <asp:TextBox ID="TxtAsunto" runat="server" CssClass="input-group-text"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label3" runat="server" Text="Mensaje:"></asp:Label>
        <asp:TextBox ID="TxtMensaje" runat="server" CssClass="input-group-text" TextMode="MultiLine"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="BtnEnviar" runat="server" Text="Enviar" CssClass="btn btn-primary" OnClick="BtnEnviar_Click"/>
        <a href="Tarjetas.aspx">Cancelar</a>
    </div>

</asp:Content>
