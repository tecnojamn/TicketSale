<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AppWeb.Views.Default" %>

<%@ Import Namespace="DTO" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="container-fluid">
        <div class="row" style="min-height:800px;  background-color: #ECF0F1;">
            <div class="col-lg-12" style="  background-color: rgb(26, 188, 156);   margin-bottom: 20px; height: 65px;  line-height: 65px;  text-align: center;">
             <h3 style="margin: 0;  line-height: 65px;">Eventos destacados</h3>
                </div>
            <div class="col-lg-12" style="">
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

                <asp:ListView ID="listViewEvents" ItemType="DTO.EventDTO" GroupItemCount="2" SelectMethod="listViewEvents_GetData" runat="server">
                    <EmptyDataTemplate>No hay eventos</EmptyDataTemplate>
                    <GroupTemplate>
                        <div class="row" style="  padding: 15px 0px;">
                            <div id="itemPlaceholder" runat="server"></div>
                        </div>
                    </GroupTemplate>                    
                    
                    <ItemTemplate>
                        <div class="col-lg-6"  >  
                            <div class="jsEventContainer" style="overflow:hidden;display:none;background-color: #2980B9;  padding: 30px 20px;   line-height: 1.214;">
                             <asp:ImageButton CssClass="col-lg-6" style="" ID="imgbtnLogo" OnCommand="linkEvent_Click" CommandArgument='<%#Eval("id")%>' ImageUrl='<%#IMG_PATH+""+Eval("id")+".jpg"%>'  runat="server" />
                           <div class="col-lg-6"  >  
                            <asp:LinkButton ID="linkEvent" style="  display: block;  margin-bottom: 20px;font-size: 25px;  font-weight: bold;  color: rgb(26, 188, 156);" OnCommand="linkEvent_Click" CommandArgument='<%#Eval("id")%>' runat="server"><%#Eval("name") %></asp:LinkButton>
                            <p style="  color: #ECF0F1;  line-height: 25px;  font-size: 16px;">
                               <%#Eval("description")%>
                            </p>
                            <p style="color: rgb(26, 188, 156);  line-height: 10px;  font-size: 14px;">
                                <span class="fui-location"> <%#Eval("EventLocation.name")%>-<%#Eval("EventLocation.address")%>  </span>
                            </p> 
                             <p style="color: rgb(26, 188, 156);  line-height: 10px;  font-size: 14px;">
                               <span class="fui-calendar"> <%#Eval("date")%>  </span>
                            </p>
                                <asp:LinkButton ID="LinkButton1" class="btn btn-block btn-lg btn-danger" OnCommand="linkEvent_Click" CommandArgument='<%#Eval("id")%>' runat="server">Ver mas info  >>></asp:LinkButton>
                        </div></div>
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
