<%@ Page Title="" Language="C#" MasterPageFile="~/common2.Master" AutoEventWireup="true" CodeBehind="videoArea.aspx.cs" Inherits="TheSportsWeb.videoArea" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CaId" runat="server">
    视频专区
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="title_head" runat="server">
    视频列表 
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="content" runat="server">
    <div class="main-list">
        <ul class="new-ul">
            <asp:Repeater ID="videoList" runat="server">
                <ItemTemplate>
                    <li><a href="videoDetails.aspx?videoType=<%# DataBinder.Eval(Container.DataItem, "vId")%>"><%# DataBinder.Eval(Container.DataItem, "vTitle")%></a></li>
                </ItemTemplate>
            </asp:Repeater>
        </ul>
    </div>
    <%--<div class="bt-list">
        <p>共<span>40</span>条/共<span>2</span>页</p>
        <p>第<span>1</span>页</p>
        <div class="bt">
            <input type="button" value="末页">
            <input type="button" value="下页">
            <input type="button" value="2">
            <input type="button" value="1">
            <input type="button" value="首页">
        </div>
    </div>--%>

</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
