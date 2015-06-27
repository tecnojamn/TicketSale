<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="AppWeb.Views.Search" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
    <asp:Button ID="btnSearch" CssClass="btn-primary btn" runat="server" Text="Search" OnClick="BtnSearch_Click" />
    <asp:ListView ID="ListView1" runat="server">
    </asp:ListView>
    <br />
</asp:Content>
