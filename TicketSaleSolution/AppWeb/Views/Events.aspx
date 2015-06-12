<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Events.aspx.cs" Inherits="AppWeb.Views.Events" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <h3 id="name" runat="server"></h3>
    <br />
    <label>Fecha: </label>
    <asp:Label ID="lblDate" runat="server" Text=""></asp:Label><br />
    <label>Hora: </label>
    <asp:Label ID="lblTime" runat="server" Text=""></asp:Label><br />
    <label>Lugar: </label>
    <asp:Label ID="lblLoc" runat="server" Text=""></asp:Label><br />
    <label>Entradas Disponibles: </label>
    <asp:Label ID="lblTickets" runat="server" Text=""></asp:Label><br />
    <label>Sectores Disponibles: </label>
    <asp:GridView ID="grdTickets" runat="server">
    </asp:GridView>

</asp:Content>
