<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AppWeb.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/base.css" rel="stylesheet" />
    <link href="css/default.css" rel="stylesheet" />
    <style>
        #input{
              padding: 1px 0px;
        }
        
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="landing-hero landing-section--bg landing-section--bg-cover g-group g-group--full-width" id="banner">
        <div class="g-grid l-block--padded-v-40 l-align-center-md l-align-center-sm">
            <div class="col-md-6  g-cell g-cell-10-12 g-cell-md-7-12 g-cell-lg-4-12 l-block--bg-dark-trans radius l-padded-v-2">
                <h2 class="marketing-text-body-large marketing-text--white text--centered">Registrate!</h2>
                <form name="signupForm" method="post" action="" class="responsive-form marketing-form l-block-2 js-validate-signup">
                    <div class="responsive-form-input--bg">
                        <input type="email" name="email" placeholder="Correo"/>
                    </div>
                    <div class="responsive-form-input responsive-form-input --bg">
                        <input type="password" name="passwd1" placeholder="Contraseña"/>
                    </div>
                        <input type="submit" class="btn btn--block l-block-2" value="Enviar"/>
                    
                </form>
            </div>
            <div class="col-md-6">
               <h2> AKSJDBAKJSBHDKJASD</h2>
            </div>
        </div>
    </div>


</asp:Content>
