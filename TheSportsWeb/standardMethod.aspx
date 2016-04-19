<%@ Page Title="" Language="C#" MasterPageFile="~/common.Master" AutoEventWireup="true" CodeBehind="standardMethod.aspx.cs" Inherits="TheSportsWeb.standardMethod" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CaName" runat="server">
    体质测试中心
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CaId" runat="server">
    标准方法
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="title_head" runat="server">
    标准方法
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="content" runat="server">
    <div class="main-list">
        <ul class="new-ul">
            <asp:Repeater ID="standard_method" runat="server">
                <ItemTemplate>
                    <li><a href="commonDetails.aspx?commonType=<%# DataBinder.Eval(Container.DataItem, "id")%>" target="inweb"><%# DataBinder.Eval(Container.DataItem, "title")%></a></li>
                </ItemTemplate>
            </asp:Repeater>
        </ul>
    </div>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
