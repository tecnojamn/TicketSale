<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="Paypal.aspx.cs" Inherits="AppWeb.Views.Paypal.Paypal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../../Content/dist/css/vendor/bootstrap.css" rel="stylesheet" />
    <link href="../../Content/dist/css/vendor/bootstrap.min.css" rel="stylesheet" />
    <link href="paypal.css" rel="stylesheet" />
</head>
<body>
    <form id="form" runat="server">
        <asp:HiddenField ID="hfReservationId" runat="server" />
        <asp:HiddenField ID="hfAccess" runat="server" />
        <div>
            <asp:Panel ID="panelContent" runat="server">
            </asp:Panel>
        </div>
    </form>
</body>
</html>
