<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="AppWeb.Views.Search" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
    <asp:Button ID="btnSearch" CssClass="btn-primary btn" runat="server" Text="Search" OnClick="BtnSearch_Click" />
    <asp:Button ID="btnAdvanced" runat="server" CssClass="btn-info btn" Text="&gt;" OnClick="btnAdvanced_Click" />
    <br />
    <asp:Panel ID="panelAdvanced" runat="server" Height="205px">
        <asp:Label ID="Label5" runat="server" Text="Busqueda avanzada"></asp:Label>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Min date"></asp:Label>
        <asp:DropDownList ID="ddListMinDay" runat="server" Width="63px">
        </asp:DropDownList>
        <asp:DropDownList ID="ddListMinMonth" runat="server" Width="63px">
        </asp:DropDownList>
        <asp:DropDownList ID="ddListMinYear" runat="server" Width="88px">
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Max date"></asp:Label>
        <asp:DropDownList ID="ddListMaxDay" runat="server" Width="63px">
        </asp:DropDownList>
        <asp:DropDownList ID="ddListMaxMonth" runat="server" Height="21px" Width="63px">
        </asp:DropDownList>
        <asp:DropDownList ID="ddListMaxYear" runat="server" Width="88px">
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Local"></asp:Label>
        <asp:DropDownList ID="ddListLocal" runat="server" Width="214px">
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Precio menor a"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label7" runat="server" Text="Type"></asp:Label>
        <asp:DropDownList ID="ddListType" runat="server">
        </asp:DropDownList>
    </asp:Panel>
    <asp:GridView ID="eventsGrid" runat="server" OnRowCommand="eventsGrid_RowCommand" OnRowCreated="eventsGrid_RowCreated">
        <Columns>
            <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Details" ShowHeader="True" Text="&gt;" />
        </Columns>
        <EmptyDataTemplate> PENES</EmptyDataTemplate>
    </asp:GridView>
    <br />
</asp:Content>
