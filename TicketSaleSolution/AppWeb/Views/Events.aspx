<%@ Page Title="" EnableEventValidation="false" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Events.aspx.cs" Inherits="AppWeb.Views.Events" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">


    <script>
        function validate(rowIndex) {

            var availableTickets = $("#ContentPlaceHolder_gvTickets tbody tr:eq(" + (rowIndex + 1) + ") td:eq(2)").text();
            var inputQuantity = $("#ContentPlaceHolder_gvTickets_txtTickets_" + rowIndex).val();
            var cost = $("#ContentPlaceHolder_gvTickets tbody tr:eq(" + (rowIndex + 1) + ") td:eq(1)").text();

            if (inputQuantity.length === 0) {
                $("#ContentPlaceHolder_gvTickets_txtTickets_" + rowIndex).val(0);
                inputQuantity = 0;
            } else if (inputQuantity < 0) {
                $("#ContentPlaceHolder_gvTickets_txtTickets_" + rowIndex).val(0);
                inputQuantity = 0;
            }
            if (inputQuantity > availableTickets) {
                $("#ContentPlaceHolder_gvTickets_txtTickets_" + rowIndex).val(availableTickets);
                inputQuantity = availableTickets;
            }
            //set Subtotal
            $("#ContentPlaceHolder_gvTickets tbody tr:eq(" + (rowIndex + 1) + ") td:eq(4)").text(cost * inputQuantity);
            setTotal();
        }
        function setTotal() {
            var total = 0;
            var rowsCount = ($("#ContentPlaceHolder_gvTickets tbody tr").length) - 1;
            for (i = 1; i <= rowsCount; i++) {
                total += parseInt($("#ContentPlaceHolder_gvTickets tbody tr:eq(" + i + ") td:eq(4)").text() ,10);
            }
            $("#ContentPlaceHolder_lblTotal").text(total);
         }
    </script>


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
                    <asp:TextBox ID="txtTickets" runat="server" TextMode="Number" Text="0" onblur='<%#"validate(" + Container.DataItemIndex +")"%>'></asp:TextBox>
                    <asp:Label ID="alert" runat="server" Text=""></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>
            <asp:BoundField  HeaderText="SubTotal"  />


        </Columns>
    </asp:GridView>
    <label>Total a pagar:</label>
    <asp:Label ID="lblTotal" runat="server" Text="0"></asp:Label>
    <asp:Button ID="btnDoReserve" runat="server" Text="Realizar Reserva" OnClick="btnDoReserve_Click" />
</asp:Content>
