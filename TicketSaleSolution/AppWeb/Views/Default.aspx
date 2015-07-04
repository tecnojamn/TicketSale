<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AppWeb.Views.Default" %>

<%@ Import Namespace="DTO" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="container-fluid">
        <div class="row" style="min-height:800px">
            <div class="col-lg-6 col-lg-offset-2" style="
    margin-top: 30px;
">


                <asp:ListView ID="listViewEvents" ItemType="DTO.EventDTO" GroupItemCount="3" SelectMethod="listViewEvents_GetData" runat="server">
                    <EmptyDataTemplate>No hay eventos</EmptyDataTemplate>
                    <GroupTemplate>
                        <div class="row">
                            <div id="itemPlaceholder" runat="server"></div>
                        </div>
                    </GroupTemplate>                    
                    <GroupSeparatorTemplate>
                        <tr runat="server">
                            <td colspan="3">
                                <hr />
                            </td>
                        </tr>
                    </GroupSeparatorTemplate>
                    <ItemTemplate>
                        <div class="col-lg-3">   
                            <asp:LinkButton ID="linkEvent"  OnCommand="linkEvent_Click" CommandArgument='<%#Eval("id")%>' runat="server"><%#Eval("name") %></asp:LinkButton>
                        </div>
                    </ItemTemplate>
                </asp:ListView>
                <asp:DataPager ID="lvDataPager1" runat="server" PagedControlID="listViewEvents" PageSize="4">
                    <Fields>
                        <asp:NumericPagerField ButtonType="Link" />
                    </Fields>
                </asp:DataPager>
            </div>
        </div>
    </div>
</asp:Content>
