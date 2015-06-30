<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Login.ascx.cs" Inherits="AppWeb.Views.Paypal.Login" %>

<asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
<asp:TextBox ID="txtPass" runat="server"></asp:TextBox>
<asp:Button ID="btnSubmit" OnClick="btnSubmit_Click" runat="server" Text="Button" />