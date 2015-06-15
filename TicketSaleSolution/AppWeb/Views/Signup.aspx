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
                     <asp:Panel CssClass="hide" ID="AlertPanel" runat="server">
                        <asp:Label ID="AlertLabel" runat="server" Text="Label" CssClass="sr-only"></asp:Label>
                    </asp:Panel>
                        <h4>Registrate!</h4>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1"
                        ControlToValidate="txtMail"
                        Display="Static"
                        ValidationGroup="LoginGroup"
                        ErrorMessage="Ingrese email"
                        runat="Server">
                    </asp:RequiredFieldValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3"
                        ControlToValidate="txtName" 
                        Display="Static"
                        ValidationGroup="LoginGroup"
                        ErrorMessage="Ingrese nombre"
                        runat="Server">
                    </asp:RequiredFieldValidator>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator5"
                        ControlToValidate="dateBirth"
                        Display="Static"
                        ValidationGroup="LoginGroup"
                        ErrorMessage="Ingrese fecha"
                        runat="Server">
                    </asp:RequiredFieldValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4"
                        ControlToValidate="txtLastName" 
                        Display="Static"
                        ValidationGroup="LoginGroup"
                        ErrorMessage="Ingrese apellido"
                        runat="Server">
                    </asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ValidationGroup="LoginGroup" CssClass="validation-error" ID="RegularExpressionValidator3" runat="server" ErrorMessage="Email invalido" ControlToValidate="txtMail"
                        ValidationExpression="[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?"></asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2"
                        ControlToValidate="txtPass1" 
                        Display="Static"
                        ValidationGroup="LoginGroup"
                        ErrorMessage="Ingrese contraseña"
                        runat="Server">
                    </asp:RequiredFieldValidator>
                     <asp:RegularExpressionValidator ValidationGroup="LoginGroup"  ID="RegularExpressionValidator4" runat="server" ErrorMessage="El password debe tener mínimo 8 caracteres" ControlToValidate="txtPass1"
                        ValidationExpression="^[\s\S]{8,}$"></asp:RegularExpressionValidator>
                    <asp:RegularExpressionValidator ValidationGroup="LoginGroup" ID="RegularExpressionValidator1" runat="server" ErrorMessage="La confirmación debe tener mínimo 8 caracteres" ControlToValidate="txtPass1"
                        ValidationExpression="^[\s\S]{8,}$"></asp:RegularExpressionValidator>
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
                        <asp:Button CausesValidation="true" ValidationGroup="LoginGroup" CssClass="form-group btn btn-primary btn-block" ID="signupSubmit" runat="server" OnClick="signupSubmit_Click" Text="Registrarme" />
                <asp:ValidationSummary 
                              id="valSum" 
                              DisplayMode="BulletList" 
                              runat="server"
                              ValidationGroup="LoginGroup"
                              HeaderText="Errores :"
                              Font-Names="verdana" 
                              Font-Size="12"/>
                     </div>
               
                <div class="col-lg-9 col-md-9 col-sm-7 col-xs-12">
                    <h3>
                         Registraté, reservá, pagá rápido y divertite
                    </h3>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

