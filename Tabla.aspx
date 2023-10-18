
<%@ Page Title="" Language="C#" MasterPageFile="~/masterpag.Master" AutoEventWireup="true" CodeBehind="Tabla.aspx.cs" Inherits="Poke_Web.Tabla" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div>
        <h1> BIENVENIDOS AL POKEDEX</h1>
       </div>  
     <div>
         <asp:Label ID="LblFiltro" runat="server" Text="Filtro:"></asp:Label>
         <asp:TextBox ID="TxtFiltro" runat="server" OnTextChanged="TxtFiltro_TextChanged" AutoPostBack="true" CssClass="input-group-text"></asp:TextBox>
         <asp:Label ID="LblFiltroAvanzado" runat="server" Text="Filtro avanzado"></asp:Label>
         <asp:CheckBox ID="CbxFiltroAvanzado" runat="server" AutoPostBack="true" OnCheckedChanged="CbxFiltroAvanzado_CheckedChanged" />
         <%if (CbxFiltroAvanzado.Checked)
            {%>
                  <div class="row">
                      <div class="col-3">
                          <div class="mb-3">
                              <asp:Label ID="Label1" runat="server" Text="Campo"></asp:Label>
                              <asp:DropDownList ID="DdlCampo" runat="server" CssClass="input-group-text" OnSelectedIndexChanged="DdlCampo_SelectedIndexChanged" AutoPostBack="true">
                                  <asp:ListItem Text="Nombre"/>
                                  <asp:ListItem Text="Numero" />
                                  <asp:ListItem text="Tipo"/>
                              </asp:DropDownList>

                          </div>

                      </div>
                         <div class="col-3">
                          <div class="mb-3">
                              <asp:Label ID="Label2" runat="server" Text="Criterio"></asp:Label>
                              <asp:DropDownList ID="DdlCriterio" runat="server" CssClass="input-group-text">
                              </asp:DropDownList>
                  </div>
                             </div>
                                <div class="col-3">
                          <div class="mb-3">
                              <asp:Label ID="Label3" runat="server" Text="Filtro"></asp:Label>
                              <asp:TextBox ID="TxtFiltroAvanzado" runat="server" CssClass="input-group-text"></asp:TextBox>
                              </div>
                                    </div>
                          <div class="col-3">
                             
                              <asp:Button ID="BtnBuscar" runat="server" Text="Buscar" CssClass="btn btn-primary" OnClick="BtnBuscar_Click" />                           
                  </div>
                      </div>
            <%}
             %>
     </div>
    <asp:GridView ID="DgvPokedex" runat="server" AutoGenerateColumns="false" CssClass="table table-dark border-danger" DataKeyNames="Id" 
         OnSelectedIndexChanged="DgvPokedex_SelectedIndexChanged" OnPageIndexChanging="DgvPokedex_PageIndexChanging" AllowPaging="true" PageSize="5">
            <Columns>
               <asp:BoundField HeaderText="Nombre" DataField="nombre" />
               <asp:BoundField HeaderText="Numero" DataField="numero" />
                <asp:BoundField HeaderText="Tipo" DataField="tipo" />
                <asp:CommandField HeaderText="Accion" ShowSelectButton="true" SelectText="Seleccionado" />
            </Columns>
        </asp:GridView>
    <div>
        <asp:Button ID="BtnAgregar" runat="server" Text="Agregar" />
        <a href="Formulario.aspx" csclass="">Agregar</a>
    </div>
</asp:Content>
