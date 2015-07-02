<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="PaymentConfirmation.aspx.cs" Inherits="AppWeb.Views.Paypal.PaymentConfirmation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Confirmame COnfirmate</title>
     <link href="../../Content/dist/css/vendor/bootstrap.css" rel="stylesheet" />
    <link href="../../Content/dist/css/vendor/bootstrap.min.css" rel="stylesheet" />
    <link href="paypal.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
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
            <form >
            <div class="actions">
                <asp:Button CssClass="button actionContinue" Text="Confirmar Pago" ID="Button1" OnClick="Button1_Click" runat="server" />
            </div></form>
        </section>
    </div>
</div>

    </div>
    </form>

</body>
</html>
