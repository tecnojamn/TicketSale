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

    <asp:GridView ID="gvTickets" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="Sector" HeaderText="Sector" />
            <asp:BoundField DataField="Costo" HeaderText="Costo" />
            <asp:BoundField DataField="EntradasDisponibles" HeaderText="Entradas Disponibles" />

            <asp:TemplateField HeaderText="Reservar">
                <ItemTemplate>
                    <asp:TextBox ID="txtTickets" runat="server" TextMode="Number"></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>

        </Columns>
    </asp:GridView>

    <asp:Button ID="btnDoReserve" runat="server" Text="Realizar Reserva" OnClick="btnDoReserve_Click"/>
</asp:Content>
