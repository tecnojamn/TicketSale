<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AppWeb.Views.Default" %>

<%@ Import Namespace="DTO" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="container-fluid">
        <div class="row" style="min-height:800px;  background-color: #ECF0F1;">
            <div class="col-lg-6 col-lg-offset-3" style="">
             <h3>Eventos destacados</h3>
                </div>
            <div class="col-lg-6 col-lg-offset-3" style="">
               <script>
                   $("document").ready(function(){
                       $(".jsEventContainer").each(function (i, v) {
                           if (i % 2 == 0) {
                               $(v).css("background-color", "#2C3E50");
                           }
                           $(v).fadeIn(2000);
                       });
                   });
               </script>

                <asp:ListView ID="listViewEvents" ItemType="DTO.EventDTO" GroupItemCount="4" SelectMethod="listViewEvents_GetData" runat="server">
                    <EmptyDataTemplate>No hay eventos</EmptyDataTemplate>
                    <GroupTemplate>
                        <div class="row" style="  padding: 20px 0px;">
                            <div id="itemPlaceholder" runat="server"></div>
                        </div>
                    </GroupTemplate>                    
                    
                    <ItemTemplate>
                        <div class="col-lg-3 jsEventContainer" style="display:none;background-color: #2980B9;  padding: 20px;   line-height: 1.214;">  
                             <asp:ImageButton style="height: 100px;width: 100%;" ID="imgbtnLogo" OnCommand="linkEvent_Click" CommandArgument='<%#Eval("id")%>' ImageUrl='<%#IMG_PATH+""+Eval("id")+".jpg"%>' CssClass="logo" runat="server" />
                            <asp:LinkButton ID="linkEvent" style="font-size: 16px;font-weight: bold;color : white;" OnCommand="linkEvent_Click" CommandArgument='<%#Eval("id")%>' runat="server"><%#Eval("name") %></asp:LinkButton>
                        </div>
                    </ItemTemplate>
                </asp:ListView>
                <asp:DataPager ID="lvDataPager1" runat="server" PagedControlID="listViewEvents" PageSize="12">
                    <Fields>
                       
                    </Fields>
                </asp:DataPager>
            </div>
        </div>
    </div>
</asp:Content>
