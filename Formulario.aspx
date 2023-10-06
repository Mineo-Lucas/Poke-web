<%@ Page Title="" Language="C#" MasterPageFile="~/masterpag.Master" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="Poke_Web.Formulario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <h1>Formulario</h1>
    <div>
    <asp:Label ID="LblNombre" runat="server" Text="Label"></asp:Label>
    <asp:TextBox ID="Txt Nombre" runat="server"></asp:TextBox>
    </div>
    <div>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </div>
    <div>
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </div>
    <div>
    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </div>
    
</asp:Content>
