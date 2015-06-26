<%@ Page Title="" EnableEventValidation="false" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Events.aspx.cs" Inherits="AppWeb.Views.Events" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">


    <script>
        function validate(rowIndex) {
            var availableTickets = $("#ContentPlaceHolder_gvTickets tbody tr:eq(" + (rowIndex + 1) + ") td:eq(2)").text();
            var inputQuantity = $("#ContentPlaceHolder_gvTickets_txtTickets_" + rowIndex).val();
            if($.isEmptyObject(inputQuantity)){inputQuantity=0}
            if (inputQuantity > availableTickets) {
                //No hay entradas suficientes
                alert("ah pero pero tu sos bobo");
            }
            if (inputQuantity < 0 || !$.isNumeric(inputQuantity)) {
                //Valor incorrecto
                alert("sos un pelotudo barbaro");
            }
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
                    <asp:TextBox ID="txtTickets" runat="server" TextMode="Number" onblur='<%#"validate(" + Container.DataItemIndex +")"%>'></asp:TextBox>
                    <asp:Label ID="alert" runat="server" Text=""></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>


        </Columns>
    </asp:GridView>

    <asp:Button ID="btnDoReserve" runat="server" Text="Realizar Reserva" OnClick="btnDoReserve_Click" />
</asp:Content>
