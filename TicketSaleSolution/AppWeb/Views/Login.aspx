<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AppWeb.Views.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!--Agregar estilos acá-->
    <link href="../Content/dist/css/style.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="container-fluid banner">
        <div class="container-fluid container-banner">
            <div class="row">
                <div class="radius col-lg-3 col-md-3 col-sm-5 col-ms-7 col-xs-12 form-cont login-form">

                    <h4>Iniciar Sesión</h4>
                    <div class="form-group">
                        <asp:TextBox ID="txtMail" CssClass="form-control login-field" placeholder="Correo" runat="server"></asp:TextBox>
                        <label class="login-field-icon fui-mail" for="txtMail"></label>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txtPass" TextMode="Password" CssClass="form-control login-field" placeholder="Contraseña" runat="server"></asp:TextBox>
                        <label class="login-field-icon fui-lock" for="txtPass"></label>
                    </div>
                    <asp:Button CssClass="form-group btn btn-primary btn-block" ID="login" runat="server" OnClick="login_Click" Text="Iniciar Sesión" />

                    <label id="lblForm" runat="server" for="signup">Aun no tengo cuenta:</label>
                    <asp:Button CssClass="form-group btn btn-info btn-block" ID="signup" runat="server" OnClick="signup_Click" Text="Registrarme" />

                </div>
                <div class="col-lg-9 col-md-9 col-sm-7 col-xs-12">
                    <h3>Encuentra tu próxima experienca papa!</h3>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
