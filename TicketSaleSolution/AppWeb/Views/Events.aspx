<%@ Page Title="" EnableEventValidation="false" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Events.aspx.cs" Inherits="AppWeb.Views.Events" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <div id="fb-root"></div>
<script>(function (d, s, id) {
    var js, fjs = d.getElementsByTagName(s)[0];
    if (d.getElementById(id)) return;
    js = d.createElement(s); js.id = id;
    js.src = "//connect.facebook.net/es_LA/sdk.js#xfbml=1&version=v2.4";
    fjs.parentNode.insertBefore(js, fjs);
}(document, 'script', 'facebook-jssdk'));</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">


    <script>

        $(document).ready(function () {
            $(".table").css("border", "none");
            $(".table").find("th").css("background-color", "rgb(26, 188, 156)").css("border", "none");
            $(".table").find("td").css("background-color", "rgb(231, 231, 231)").css("border", "1px solid rgb(202, 202, 202)");
        });

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
            $("#ContentPlaceHolder_lblTotalAmount").text(total);
        }
    </script>
    <div class="palette  palette-turquoise" style="overflow: hidden;">
        <span style="float: left; line-height: 20px;" class="fui-video"></span>
        <h3 id="name" runat="server" style="font-size: 22px; float: left; margin: 0px 7px 0px 10px; line-height: 20px;"></h3>
    </div>
    <div class="well " style="padding: 15px 40px; font-size: 15px;">
        <div class="col-lg-12 share" style="  line-height: 7px;  padding: 10px;  background-color: rgba(26, 188, 156, 0.12);">
         <div class="fb-share-button"></div>
        <a href="https://twitter.com/share" class="twitter-share-button" data-url="http://localhost:1341/Views/Events.aspx?id=7" data-text="Evento Re loco, Entra!!!!" data-lang="es" data-count="none">Twittear</a>
        <script>!function (d, s, id) { var js, fjs = d.getElementsByTagName(s)[0], p = /^http:/.test(d.location) ? 'http' : 'https'; if (!d.getElementById(id)) { js = d.createElement(s); js.id = id; js.src = p + '://platform.twitter.com/widgets.js'; fjs.parentNode.insertBefore(js, fjs); } }(document, 'script', 'twitter-wjs');</script>
   </div>

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
         <asp:Label style="padding: 10px;  display: block;" CssClass="alert-danger" ID="alertMaxOverflow" runat="server" Text="Maximo 10  reservas por sector!" Visible="false"></asp:Label><br />
        <asp:Label style="padding: 10px;  display: block;" CssClass="alert-danger" ID="alertNoneSelected" runat="server" Text="Seleccione al menos una reserva!" Visible="false"></asp:Label><br />
        <asp:Label style="padding: 10px;  display: block;" CssClass="alert-success" ID="alertConfirmation" runat="server" Text="Su Reserva se ha realizado con exito!" Visible="false"></asp:Label><br />
        <asp:Label ID="lblTotal" Text="Total a pagar:" runat="server"></asp:Label>
        <asp:Label ID="lblTotalAmount" runat="server" Text="0"></asp:Label>
        <br />
        <asp:Button ID="btnDoReserve" runat="server" Text="Realizar Reserva" CssClass="btn btn-lg btn-primary" OnClick="btnDoReserve_Click" />
        </div>
</asp:Content>
