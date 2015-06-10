<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Events.aspx.cs" Inherits="AppWeb.Views.Events" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Content/dist/css/style.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <h3 id="name" runat="server"></h3>
    <label runat="server">Fecha: </label>
    <asp:Label ID="lblDate" runat="server" Text=""></asp:Label>
    <label runat="server">Hora: </label>
    <asp:Label ID="lblTime" runat="server" Text=""></asp:Label>
    <label runat="server">Lugar: </label>
    <asp:Label ID="lblLoc" runat="server" Text=""></asp:Label>
    <label runat="server">Entradas: </label>
    <asp:GridView ID="grdTickets" runat="server">
        <Columns>
            <asp:BoundField DataField="description" HeaderText="Sector" />
            <asp:BoundField DataField="cost" HeaderText="Costo" />
        </Columns>
    </asp:GridView>

</asp:Content>
