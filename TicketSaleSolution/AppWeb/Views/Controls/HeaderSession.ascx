<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HeaderSession.ascx.cs" Inherits="AppWeb.Views.Controls.HeaderSession" %>

<nav class="navbar navbar-inverse navbar-embossed">
    <div class="navbar-header">
        <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#navbar-collapse-01">
            <span class="sr-only">Toggle navigation</span>
        </button>
        <asp:HyperLink ID="navName" CssClass="navbar-brand" NavigateUrl="/Views/Profile.aspx" runat="server"></asp:HyperLink>
    </div>
    <div class="collapse navbar-collapse" id="navbar-collapse-01">
        <ul class="nav navbar-nav navbar-left">
            <li>
                <asp:LinkButton id="linkPayments" OnClick="linkPayments_Click" runat="server">Mis pagos</asp:LinkButton>
            </li>
            <li>
                <asp:LinkButton id="linkReservations" OnClick="linkReservations_Click" runat="server">Mis Reservas</asp:LinkButton>
            </li>
            <li>
            </li>
        </ul>
        <ul class="nav navbar-nav navbar-right">
            <li>
                
                <asp:LinkButton id="linkExit" OnClick="linkExit_Click" runat="server">Salir</asp:LinkButton>

            </li>

        </ul>
    </div>
</nav>

