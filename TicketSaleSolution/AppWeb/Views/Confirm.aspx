<%@ Page Title="" EnableEventValidation="false" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="True" CodeBehind="Confirm.aspx.cs" Inherits="AppWeb.Views.Confirm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
                   
    <asp:Panel CssClass="hide" ID="AlertPanel" runat="server">
        <asp:Label ID="AlertLabel" runat="server" CssClass="sr-only" Text="Label"></asp:Label>
    </asp:Panel>

</asp:Content>
