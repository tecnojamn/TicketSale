<%@ Page Title="" EnableEventValidation="false" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Events.aspx.cs" Inherits="AppWeb.Views.Events" %>

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
    <asp:GridView ID="gvTickets" runat="server">
        <Columns>
            <asp:TemplateField HeaderText="Sector"></asp:TemplateField>
            <asp:TemplateField HeaderText="Costo"></asp:TemplateField>
            <asp:TemplateField HeaderText="Disponibles/Totales"></asp:TemplateField>
            <asp:TemplateField HeaderText="Reservar">
                <ItemTemplate>
                    <input id="ticketsQuantity" type="number" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

</asp:Content>
