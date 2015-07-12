<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reservations.aspx.cs" Inherits="AppWeb.Views.Reservations" %>

<%@ Import Namespace="DTO" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        li {
            display: inline;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">

    <script>
        $(document).ready(function () {

            var table = $(".soTable").css("border", "none");
            table.find("tr").css("background-color", "rgb(240, 240, 240)").css("border", "none");
            table.find("th").css("background-color", "rgb(140, 203, 190)").css("border", "none");
            table.find("td").css("background-color", "rgb(229, 229, 229)").css("border", "none");
            table.find("th").each(function (index, object) {
                if (index == 0) {
                    $(object).html("ID");
                }
                if (index == 1) {
                    $(object).html("Monto");
                }
                if (index == 2) {
                    $(object).html("Sector");
                }
                if (index == 3) {
                    $(object).html("Estado");
                }
            });
        })
        function cancelSubOrder(idSO, rowIndex, lvItemIndex) {
            $.ajax({
                type: "POST",
                url: "Reservations.aspx/cancelSubOrder",
                data: '{idSO: "' + idSO + '" }',
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    if (response.d == "true") {
                        $("#ContentPlaceHolder_lvReservations_gvSubOrders_" + lvItemIndex + "_btnCancelSubOrder_" + rowIndex).replaceWith('<div style="background-color:#e74c3c" >Cancelada</div>');
                    } else {
                        // Error al intentar cancelar.
                    }
                },
                failure: function (response) {
                    alert(response);
                }
            });
        }
        function cancelAllSubOrders(idSO, lvItemIndex) {
            $.ajax({
                type: "POST",
                url: "Reservations.aspx/cancelAllSubOrders",
                data: '{idRes: "' + idRes + '" }',
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    if (response.d == "true") {
                        console.log("True");
                    } else {
                        // Error al intentar cancelar.
                    }
                },
                failure: function (response) {
                    alert(response);
                }
            });
        }

    </script>
    <div class="row" style="min-height:800px">
    <div class="col-lg-10 col-lg-offset-1">
        
        <ul style="text-align:center;padding:0;">
            <ol style="  padding: 0;">
            <li style="text-align: center;  background-color: rgba(26, 188, 156, 0.29);  margin-top: 10px;" class="col-lg-1">#</li>
            <li style="text-align: center;  background-color: rgba(26, 188, 156, 0.29);  margin-top: 10px;" class="col-lg-2">Fecha</li>
            <li style="text-align: center;  background-color: rgba(26, 188, 156, 0.29);  margin-top: 10px;" class="col-lg-2">Total</li>
            <li style="text-align: center;  background-color: rgba(26, 188, 156, 0.29);  margin-top: 10px;" class="col-lg-3">Nombre de Evento</li>
            <li style="text-align: center;  background-color: rgba(26, 188, 156, 0.29);  margin-top: 10px;" class="col-lg-4">Acciones</li>
                </ol>
    </ul>
            
    <asp:ListView ID="lvReservations" runat="server" GroupItemCount="1" ItemType="DTO.ReservationDTO" SelectMethod="lvReservations_GetData" OnDataBinding="lvReservations_DataBinding">
        <EmptyDataTemplate>
            <h4 style="font-size:16px">No hay datos para mostrar</h4>
        </EmptyDataTemplate>
        <ItemTemplate>
            <ul style="text-align:center;padding:0;">
                <li style="  padding: 0;  background-color: rgb(245, 245, 245);" class="col-lg-1"><%#Eval("id")%></li>
                <li style="  padding: 0;  background-color: rgb(245, 245, 245);" class="col-lg-2"><%#((DateTime)Eval("date")).ToString("dd/MM/yyyy")%></li>
                <li style="  padding: 0;  background-color: rgb(245, 245, 245);" class="col-lg-2"><%# getTotalAmount((ICollection<SubOrderDTO>)Eval("SubOrder")) %></li>
                <li style="  padding: 0;  background-color: rgb(245, 245, 245);" class="col-lg-4"><%#((ICollection<SubOrderDTO>)Eval("SubOrder")).First().Ticket.TicketType.Event.name%></li>
                <li style="  padding: 0;  background-color: rgb(245, 245, 245);" class="col-lg-3">
                    <asp:LinkButton CssClass="jsBtnShowSubOrders btn btn-default btn-xs" ID="showSubOrders" Text="" title="Ver subordenes" CommandArgument='<%# Container.DataItemIndex + ";" + Eval("id") %> ' OnCommand="showSubOrders_Command" runat="server">Detalle</asp:LinkButton>
                    <asp:LinkButton CssClass="btn btn-info btn-xs" ID="btnDoPayment" runat="server" CommandArgument='<%#Eval("id") %>' OnCommand="btnDoPayment_Command" ><%#isPaid((PaymentDTO)Eval("Payment"),Container.DataItemIndex)%></asp:LinkButton>
                     <asp:LinkButton CssClass='<%#isPaid((PaymentDTO)Eval("Payment"),Container.DataItemIndex).Equals("PAGAR")?"btn btn-danger btn-xs":"hidden"%>' ID="btnCancelAllSubOrders" runat="server"  CommandArgument='<%# Container.DataItemIndex + ";" + Eval("id") %>' OnCommand="btnCancelAllSubOrders_Command" ><%#alreadyCanceled((ICollection<SubOrderDTO>)Eval("SubOrder"))%></asp:LinkButton>
                </li>
            </ul>
        </ItemTemplate>
    </asp:ListView>
               
   </div>
        <div class="col-lg-10 col-lg-offset-1" style="margin-top:20px;">
    <asp:DataPager class="paginator" ID="lvDataPager" runat="server" PagedControlID="lvReservations" PageSize="2">
        <Fields>
            <asp:NumericPagerField ButtonType="Link" />
        </Fields>
    </asp:DataPager>
   </div>
    <asp:ScriptManager ID="scm" runat="server" EnablePageMethods="true" />
    </div>
</asp:Content>
