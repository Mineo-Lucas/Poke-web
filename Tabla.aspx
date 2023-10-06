<%@ Page Title="" Language="C#" MasterPageFile="~/masterpag.Master" AutoEventWireup="true" CodeBehind="Tabla.aspx.cs" Inherits="Poke_Web.Tabla" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div>
        <h1> BIENVENIDOS AL POKEDEX</h1>
       </div>  
     <asp:GridView ID="DgvPokedex" runat="server" AutoGenerateColumns="false" CssClass="table table-dark border-danger">
            <Columns>
               <asp:BoundField HeaderText="Nombre" DataField="nombre" />
               <asp:BoundField HeaderText="Numero" DataField="numero" />
                <asp:BoundField HeaderText="Tipo" DataField="tipo" />
                <asp:CommandField HeaderText="Accion" ShowSelectButton="true" SelectText="Seleccionado"/>
            </Columns>
        </asp:GridView>
</asp:Content>
