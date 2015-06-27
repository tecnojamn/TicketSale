<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AppWeb.Views.Default" %>

<%@ Import Namespace="DTO" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-lg-6">

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
            <asp:Button ID="BtnSearch" runat="server" Text="Search" OnClick="BtnSearch_Click" />
        </div>
    </div>
</asp:Content>
