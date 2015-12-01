<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Categorias.aspx.cs" Inherits="ReclamaPoaS2B.Categorias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <br />
     <asp:DropDownList ID="ddlCategorias" runat="server"></asp:DropDownList>
<br />
 <br />
    <asp:Label ID="Label2" runat="server" Text="Informe o nome: "></asp:Label>
    <asp:TextBox ID="txtNome" runat="server" Width="186px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Informe a descrição: "></asp:Label>
    <asp:TextBox ID="txtDescricao" runat="server" Height="16px" Width="473px"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="cmdInserir" 
        runat="server" Text="Inserir" OnClick="cmdInserir_Click" />

</asp:Content>
