<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AppWeb.Views.Login" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="container-fluid banner">
        <div class="container-fluid container-banner">
            <div class="row">
                <div class="radius col-lg-3 col-md-3 col-sm-5 col-ms-7 col-xs-12 form-cont login-form">

                    <asp:Panel CssClass="hide" ID="AlertPanel" runat="server">
                        <asp:Label ID="AlertLabel" runat="server" Text="Label" CssClass="sr-only"></asp:Label>
                    </asp:Panel>



                    <h4>Iniciar Sesión</h4>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1"
                        ControlToValidate="txtMail" CssClass="validation-error"
                        Display="Static"
                        ValidationGroup="LoginGroup"
                        ErrorMessage="Ingrese email"
                        runat="Server">
                    </asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ValidationGroup="LoginGroup" CssClass="validation-error" ID="RegularExpressionValidator3" runat="server" ErrorMessage="Email invalido" ControlToValidate="txtMail"
                        ValidationExpression="[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?"></asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2"
                        ControlToValidate="txtPass" CssClass="validation-error"
                        Display="Static"
                        ValidationGroup="LoginGroup"
                        ErrorMessage="Ingrese contraseña"
                        runat="Server">
                    </asp:RequiredFieldValidator>
                     <asp:RegularExpressionValidator ValidationGroup="LoginGroup" CssClass="validation-error" ID="RegularExpressionValidator4" runat="server" ErrorMessage="El password debe tener mínimo 8 caracteres" ControlToValidate="txtPass"
                        ValidationExpression="^[\s\S]{8,}$"></asp:RegularExpressionValidator>
                    
                    
                    <div class="form-group">


                        <asp:TextBox ID="txtMail" CssClass="form-control login-field" placeholder="Correo" runat="server"></asp:TextBox>
                        <label class="login-field-icon fui-mail" for="txtMail"></label>
                    </div>
                    
                    <div class="form-group">
                    <div class="form-group">
                        <asp:TextBox ID="txtPass" TextMode="Password" CssClass="form-control login-field" placeholder="Contraseña" runat="server"></asp:TextBox>
                        <label class="login-field-icon fui-lock" for="txtPass"></label>
                    </div>

                    <asp:Button CausesValidation="true" ValidationGroup="LoginGroup" CssClass="form-group btn btn-primary btn-block" ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Iniciar Sesión" />

                    <label id="lblForm" runat="server" for="signup">Aun no tengo cuenta:</label>
                    <asp:Button CssClass="form-group btn btn-info btn-block" ID="btnSignup" runat="server" OnClick="btnSignup_Click" Text="Registrarme" />

                </div>
                <div class="col-lg-9 col-md-9 col-sm-7 col-xs-12">
                    <h3>Encuentra tu próxima experienca papa!</h3>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
