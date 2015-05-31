<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="AppWeb.Views.Signup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <!-- Load jQuery and bootstrap datepicker scripts and ajax-->
    <script type='text/javascript' src="//ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
    <script src="../Content/dist/js/jquery-1.9.1.js"></script>
    <script src="../Content/dist/js/boostrap-datapicker.js"></script>
    <link href="../Content/dist/css/datepicker.css" rel="stylesheet" />
    <script type="text/javascript">
        // When the document is ready
        $(document).ready(function () {

            $('#ContentPlaceHolder_dateBirth').datepicker({
                format: "dd/mm/yyyy"
            });

        });
    </script>
    <div class="container-fluid banner">
        <div class="container-fluid container-banner">
            <div class="row">
                <div class="radius col-lg-3 col-md-3 col-sm-5 col-ms-7 col-xs-12 form-cont login-form">
                        <h4>Registrate!</h4>
                        <div class="form-group">
                            <asp:TextBox ID="txtMail" CssClass="form-control login-field" placeholder="Correo" runat="server"></asp:TextBox>
                            <label class="login-field-icon fui-mail" for="textMail"></label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtName" CssClass="form-control login-field" placeholder="Nombre" runat="server"></asp:TextBox>
                            <label class="login-field-icon fui-user" for="TextName"></label>
                            <div style="height:5px"></div>
                            <asp:TextBox ID="txtLastName" CssClass="form-control login-field" placeholder="Apellido" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="dateBirth" CssClass="form-control login-field" placeholder="Fecha de Nacimiento" runat="server"></asp:TextBox>
                            <label class="login-field-icon fui-calendar" for="dateBirth"></label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox TextMode="Password" ID="txtPass1" CssClass="form-control login-field" placeholder="Contraseña" runat="server"></asp:TextBox>
                            <label class="login-field-icon fui-lock" for="login-pass"></label>
                            <div style="height:5px"></div>
                            <asp:TextBox TextMode="Password" ID="txtPass2" CssClass="form-control login-field" placeholder="Repetir Contraseña" runat="server"></asp:TextBox>
                        </div>
                        <asp:Button CssClass="form-group btn btn-primary btn-block" ID="signupSubmit" runat="server" OnClick="signupSubmit_Click" Text="Registrarme" />
                </div>
                <div class="col-lg-9 col-md-9 col-sm-7 col-xs-12">
                    <h3>PROBANDOOOO ASHDGBKAJSBHDVKAHSBDKJASD
                            ASIDBAKSJDAS
                            DASDBALKSD
                            ASDKASBDASD
                    </h3>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

