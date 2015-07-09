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
    <asp:ListView ID="ListView1" runat="server">
        <ItemTemplate>
            <asp:LinkButton ID="linkEvent"  OnCommand="linkEvent_Click" CommandArgument='<%#Eval("idEvent")%>' runat="server"><%#Eval("name") %></asp:LinkButton>
            <asp:Label ID="labelDate" runat="server" style="margin-left:10px;"><%#Eval("date") %></asp:Label>
            <asp:Label ID="labelType" runat="server" style="margin-left:10px;"><%#Eval("type") %></asp:Label>
            <asp:Label ID="labelLocation" runat="server" style="margin-left:10px;"><%#Eval("location") %></asp:Label><
            <asp:Label ID="labelAddress" runat="server" style="margin-left:10px;"><%#Eval("address") %></asp:Label>
            <asp:Label ID="labelAvailability" runat="server" style="margin-left:10px;"><%#Eval("availability") %></asp:Label><br />
        </ItemTemplate>
    </asp:ListView>
    <br />
    <br />
</asp:Content>
