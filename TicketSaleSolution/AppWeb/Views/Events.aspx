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
            } else {
                inputQuantity = parseInt(inputQuantity);
                if (inputQuantity < 0) {
                    $("#ContentPlaceHolder_gvTickets_txtTickets_" + rowIndex).val(0);
                    inputQuantity = 0;
                } else if (inputQuantity > availableTickets) {
                    $("#ContentPlaceHolder_gvTickets_txtTickets_" + rowIndex).val(availableTickets);
                    inputQuantity = availableTickets;
                }
            }

            //set Subtotal
            $("#ContentPlaceHolder_gvTickets tbody tr:eq(" + (rowIndex + 1) + ") td:eq(4)").text(cost * inputQuantity);
            setTotal();
        }
        function setTotal() {
            var total = 0;
            var rowsCount = ($("#ContentPlaceHolder_gvTickets tbody tr").length) - 1;
            for (i = 1; i <= rowsCount; i++) {
                var subTotal = $("#ContentPlaceHolder_gvTickets tbody tr:eq(" + i + ") td:eq(4)").text();
                if (subTotal.length === 0) { subTotal = 0 }
                total += parseInt(subTotal);
            }
            $("#ContentPlaceHolder_lblTotal").text(total);
        }
    </script>
    <div class="palette  palette-turquoise" style="overflow: hidden;">
        <span style="float: left; line-height: 20px;" class="fui-video"></span>
        <h3 id="name" runat="server" style="font-size: 22px; float: left; margin: 0px 7px 0px 10px; line-height: 20px;"></h3>
    </div>
    <div class="well " style="padding: 15px 40px; font-size: 15px;">

        <label>Fecha: </label>
        <asp:Label ID="lblDate" runat="server" Text=""></asp:Label><br />
        <label>Hora: </label>
        <asp:Label ID="lblTime" runat="server" Text=""></asp:Label><br />
        <label>Lugar: </label>
        <asp:Label ID="lblLoc" runat="server" Text=""></asp:Label><br />
        <label>Entradas Habilitadas: </label>
        <asp:Label ID="lblTotalTickets" runat="server" Text=""></asp:Label><br />
        <label>Entradas Disponibles: </label>
        <asp:Label ID="lblAvailableTickets" runat="server" Text=""></asp:Label><br />

        <label>Sectores Disponibles: </label>
        <div class="table-responsive">
            <asp:GridView ID="gvTickets" runat="server" AutoGenerateColumns="false" CssClass="table table-striped">
                <Columns>
                    <asp:BoundField DataField="Sector" HeaderText="Sector" />
                    <asp:BoundField DataField="Costo" HeaderText="Costo" />
                    <asp:BoundField DataField="EntradasDisponibles" HeaderText="Entradas Disponibles" />

                    <asp:TemplateField HeaderText="Reservar">
                        <ItemTemplate>
                            <asp:TextBox CssClass="form-control" ID="txtTickets" runat="server" TextMode="Number" MaxLength="2" Text="0" onblur='<%#"validate(" + Container.DataItemIndex +")"%>'></asp:TextBox>
                            <asp:Label ID="alert" runat="server" Text=""></asp:Label>
                        </ItemTemplate>

                    </asp:TemplateField>
                    <asp:BoundField HeaderText="SubTotal" />


                </Columns>
            </asp:GridView>
        </div>
        <asp:Label CssClass="alert-success" ID="alertConfirmation" runat="server" Text="Su Reserva se ha realizado con exito!" Visible="false"></asp:Label><br />
        <asp:Label ID="lblTotal" Text="Total a pagar:" runat="server"></asp:Label>
        <asp:Label ID="lblTotalAmount" runat="server" Text="0"></asp:Label>
        <br />
        <asp:Button ID="btnDoReserve" runat="server" Text="Realizar Reserva" CssClass="btn btn-lg btn-primary" OnClick="btnDoReserve_Click" />
        <asp:Button ID="btnShare" runat="server" Text="Share" OnClick="btnShare_Click" />
    </div>
</asp:Content>
