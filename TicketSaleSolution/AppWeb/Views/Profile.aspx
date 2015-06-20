<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="AppWeb.Views.Profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">




    <div class="well" style="overflow:hidden;">
        <div id="personalInfo">
            <span class="col-lg-12">Mis datos</span>
            <label  class="col-lg-12">Nombre:</label>
            <div  class="col-lg-12"><asp:Label CssClass="col-lg-6" ID="LblName" runat="server" Text="Label"></asp:Label></div>
            <label  class="col-lg-12">Apellido:</label>
            <div  class="col-lg-12"><asp:Label CssClass="col-lg-6" ID="LblLastName" runat="server" Text="Label"></asp:Label></div>
            <label  class="col-lg-12">Mail:</label>
            <div  class="col-lg-12"><asp:Label CssClass="col-lg-6" ID="LblMail" runat="server" Text="Label"></asp:Label></div>
            <label  class="col-lg-12">Fecha Nacimiento:</label>
            <div  class="col-lg-12"><asp:Label CssClass="col-lg-6" ID="LblDOB" runat="server" Text="Label"></asp:Label></div>
        </div>
        <div css="col-log12" id="editPersonalInfo">
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Dar de baja" />        
        </div>
    </div>
</asp:Content>
