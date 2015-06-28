<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="AppWeb.Views.Edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <asp:Panel CssClass="hide" ID="AlertPanel" runat="server">
        <asp:Label ID="AlertLabel" runat="server" Text="Label" CssClass="sr-only"></asp:Label>
    </asp:Panel>

    <asp:Panel ID="PanelUser" runat="server" CssClass="login-screen" Style="overflow: hidden;">
        <div class="col-lg-5 login-form" id="personalInfo">
           
            <span class="col-lg-12">Editar datos básicos</span>
             <div class="form-group">

                <asp:TextBox placeholder="Nombre" CssClass="form-control login-field" ID="TextName" runat="server"></asp:TextBox></div>

            <div class="form-group">


                <asp:TextBox placeholder="Apellido" ID="TextLastName" runat="server" CssClass="form-control login-field"></asp:TextBox></div>

            <asp:Button CssClass="btn btn-primary btn-lg btn-block" OnClick="EditUser_Click" ID="Button2" runat="server" Text="Editar" />
        </div>
        <div class="col-lg-5 col-lg-offset-1 login-form" id="editPass">
            <span class="col-lg-12">Editar contraseña</span>


            <div class="form-group">
                <asp:TextBox placeholder="Editar contraseña" ID="TextCurrentPassword" runat="server" CssClass="form-control login-field"></asp:TextBox></div>

                <div class="form-group">
                <asp:TextBox placeholder="Nueva Contraseña" ID="TextNewPassword" runat="server" CssClass="form-control login-field"></asp:TextBox></div>


<div class="form-group">
                <asp:TextBox placeholder="Repita nueva Contraseña" ID="TextConfirmationPassword" runat="server" CssClass="form-control login-field"></asp:TextBox></div>

            <asp:Button CssClass="btn btn-primary btn-lg btn-block" OnClick="Button1_Click" ID="Button1" runat="server" Text="Cambiar" />
        </div>
    </asp:Panel>




</asp:Content>
