<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="AppWeb.Views.Edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <asp:Panel CssClass="hide" ID="AlertPanel" runat="server">
        <asp:Label ID="AlertLabel" runat="server" Text="Label" CssClass="sr-only"></asp:Label>
    </asp:Panel>

    <asp:Panel ID="PanelUser" runat="server" CssClass="well" Style="overflow: hidden;">
        <div class="col-lg-6" id="personalInfo">

            <span class="col-lg-12">Editar datos básicos</span>
            <label class="col-lg-12">Nombre:</label>
            <div class="col-lg-12">
                <asp:TextBox ID="TextName" runat="server"></asp:TextBox></div>
            <label class="col-lg-12">Apellido:</label>
            <div class="col-lg-12">
                <asp:TextBox ID="TextLastName" runat="server"></asp:TextBox></div>
            <asp:Button CssClass="btn btn-default" OnClick="EditUser_Click" ID="Button2" runat="server" Text="Editar" />
        </div>
        <div class="col-lg-6" id="editPass">
            <span class="col-lg-12">Editar contraseña</span>
            <label class="col-lg-12">Contraseña actual:</label>
            <div class="col-lg-12">
                <asp:TextBox ID="TextCurrentPassword" runat="server"></asp:TextBox></div>
            <label class="col-lg-12">Nueva Contraseña:</label>
            <div class="col-lg-12">
                <asp:TextBox ID="TextNewPassword" runat="server"></asp:TextBox>

            </div>
            <label class="col-lg-12">Repita nueva Contraseña:</label>
            <div class="col-lg-12">
                <asp:TextBox ID="TextConfirmationPassword" runat="server"></asp:TextBox></div>
            <asp:Button CssClass="btn btn-default" OnClick="Button1_Click" ID="Button1" runat="server" Text="Cambiar" />
        </div>
    </asp:Panel>




</asp:Content>
