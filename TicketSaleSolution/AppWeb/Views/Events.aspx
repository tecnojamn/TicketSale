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
    ENTRADAS DISPONIBLES ,etc etc
</asp:Content>
