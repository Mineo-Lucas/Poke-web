<%@ Page Title="" Language="C#" MasterPageFile="~/masterpag.Master" AutoEventWireup="true" CodeBehind="Tarjetas.aspx.cs" Inherits="Poke_Web.Tarjetas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h1>Bienvenido a las Tarjetas Pokedex</h1>
    <%foreach (Dominio.POKEMONS item in listapokemons)
        {%>
      <div class="row row-cols-1 row-cols-md-3 g-4">
  <div class="col">
    <div class="card h-100">
      <img src="<%: item.urlimagen%>" class="card-img-top" alt="...">
      <div class="card-body">
        <h5 class="card-title"><%: item.nombre %></h5>
        <p class="card-text"><%: item.descripcion%></p>
      </div>
    </div>
  </div>
          </div>
        <%} %>
</asp:Content>
