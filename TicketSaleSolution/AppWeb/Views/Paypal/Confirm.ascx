<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Confirm.ascx.cs" Inherits="AppWeb.Views.Paypal.Confirm" %>


<div id="content" class="contentContainer col-lg-4 col-lg-offset-4">
    <header>
        <div class="paypal-logo">
        </div>
    </header>

    <div id="main" class="main " role="main">
        <section id="login" class="login" data-role="page" data-title="Inicie sesión en su cuenta PayPal">
            <div id="notifications" class="notifications" tabindex="-1">
                <asp:Panel ID="panelAlert" CssClass="notification notification-critical" runat="server">Algo salió mal, su saldo posiblemente no sea suficiente</asp:Panel>
            </div>
            <div class="table-responsive">
                <table class="table table-condensed">
                    <thead>
                        <tr>
                            <th>Usuario TicketSale</th>
                            <th>Evento</th>
                            <th>Monto</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>
                                <asp:Label ID="lblMail" runat="server"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblEvent" runat="server"></asp:Label></td>
                            <td>
                                <asp:Label ID="lblAmount" runat="server"></asp:Label>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>
            <div class="actions">
                <asp:Button CssClass="button actionContinue" Text="Confirmar Pago" ID="btnConfirm" OnClick="btnConfirm_Click" runat="server"></asp:Button>
            </div>
        </section>
    </div>
</div>
