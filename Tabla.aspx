<%@ Page Title="" Language="C#" MasterPageFile="~/masterpag.Master" AutoEventWireup="true" CodeBehind="Tabla.aspx.cs" Inherits="Poke_Web.Tabla" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <head>

    </head>
    <body>
       <h1> BIENVENIDOS AL POKEDEX</h1>
        <asp:GridView ID="DgvPokedex" runat="server"></asp:GridView>

    </body>
   
</asp:Content>
