<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="AppWeb.Views.Search" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
     <div class="container-fluid" style="background-color: #C5D8E5;">
    <div class="row" style="  padding: 10px 0px 15px 20px;  background-color: rgb(52, 73, 94);">
    <asp:Button ID="btnAdvanced" runat="server" CssClass="btn-info btn" Text="Busqueda avanzada" OnClick="btnAdvanced_Click" />
    </div>
         <div style="padding: 20px 0px 10px 20px;">
        <asp:Panel ID="panelAdvanced" runat="server" >

        <label> <asp:Label ID="Label5" runat="server" Text="Busqueda avanzada"></asp:Label></label>
        <div class="row">
        <div class="form-group col-lg-3">
        <label> <asp:Label ID="Label8" runat="server" Text="Nombre"></asp:Label></label>
        <asp:TextBox ID="txtSearch" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
         <div class="form-group col-lg-3">
        <label> <asp:Label ID="Label4" runat="server" Text="Local"></asp:Label></label>
        <asp:DropDownList  CssClass="form-control" ID="ddListLocal" runat="server" >
        </asp:DropDownList>
            </div>
       <div class="form-group col-lg-3">
        <label> <asp:Label ID="Label6" runat="server" Text="Precio menor a"></asp:Label></label>
        <asp:TextBox ID="txtPrice"  CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="form-group col-lg-3">
        <label> <asp:Label ID="Label7" runat="server" Text="Tipo"></asp:Label></label>
        <asp:DropDownList ID="ddListType"  CssClass="form-control" runat="server">
        </asp:DropDownList>
            </div>
       </div>
         
         <div class="row">
              <label class="col-lg-3"><asp:Label ID="Label1" runat="server" Text="Fecha minima"></asp:Label></label>
        <div class="form-group  col-xs-3">
      
        <asp:DropDownList  CssClass="form-control" ID="ddListMinDay" runat="server" >
        </asp:DropDownList></div>
        <div class="form-group  col-xs-3">
        <asp:DropDownList  CssClass="form-control" ID="ddListMinMonth" runat="server" >
        </asp:DropDownList></div>
        <div class="form-group  col-xs-3">
        <asp:DropDownList  CssClass="form-control" ID="ddListMinYear" runat="server">
        </asp:DropDownList></div>
        </div>
         <div class="row">
             <label class="col-lg-3"> <asp:Label ID="Label2" runat="server" Text="Fecha maxima"></asp:Label></label>
                <div class="form-group  col-xs-3">
        
        <asp:DropDownList  CssClass="form-control" ID="ddListMaxDay" runat="server">
        </asp:DropDownList></div>
                            <div class="form-group  col-xs-3">
        <asp:DropDownList CssClass="form-control"  ID="ddListMaxMonth" runat="server" >
        </asp:DropDownList></div>
                                        <div class="form-group  col-xs-3">
        <asp:DropDownList  CssClass="form-control" ID="ddListMaxYear" runat="server" >
        </asp:DropDownList></div>
        </div>

     <asp:Button ID="btnSearch" runat="server" CssClass="btn-primary btn" OnClick="BtnSearch_Click" Text="Buscar" />
    </asp:Panel>

     </div>
    <asp:ListView ID="ListView1" runat="server" GroupItemCount="2">
        <EmptyDataTemplate>No hay eventos</EmptyDataTemplate>
                    <GroupTemplate>
                        <div class="row" style="  padding: 15px 0px;">
                            <div id="itemPlaceholder" runat="server"></div>
                        </div>
                    </GroupTemplate>  
        <ItemTemplate>
             <div class="col-lg-6">  
                            <div class="jsEventContainer" style="overflow:hidden;background-color: #2980B9;  padding: 30px 20px;   line-height: 1.214;">
                             <asp:ImageButton CssClass="col-lg-6" style="" ID="imgbtnLogo" OnCommand="linkEvent_Click" CommandArgument='<%#Eval("idEvent")%>' ImageUrl='<%#IMG_PATH+""+Eval("idEvent")+".jpg"%>'  runat="server" />
                           <div class="col-lg-6"  >  
                            <asp:LinkButton ID="LinkButton1" style="  display: block;  margin-bottom: 20px;font-size: 25px;  font-weight: bold;  color: rgb(26, 188, 156);" OnCommand="linkEvent_Click" CommandArgument='<%#Eval("idEvent")%>' runat="server"><%#Eval("name") %></asp:LinkButton>
                            <p style="  color: #ECF0F1;  line-height: 25px;  font-size: 16px;">
                               <%#Eval("description")%>
                            </p>
                            <%--<asp:Label ID="label3" runat="server" Style="margin-left: 10px;"><%#Eval("availability") %></asp:Label>--%><br />
                             <p style="color: rgb(26, 188, 156);  line-height: 10px;  font-size: 14px;">
                               <span class="fui-calendar"> <%#Eval("date")%>  </span>
                            </p>
                                <asp:LinkButton ID="LinkButton2" class="btn btn-block btn-lg btn-danger" OnCommand="linkEvent_Click" CommandArgument='<%#Eval("idEvent")%>' runat="server">Ver mas info  >>></asp:LinkButton>
                        </div></div>
                        </div>
        </ItemTemplate>
    </asp:ListView>
    <br />
    <br />
         </div>
</asp:Content>
