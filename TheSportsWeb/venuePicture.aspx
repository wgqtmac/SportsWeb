<%@ Page Title="" Language="C#" MasterPageFile="~/common.Master" AutoEventWireup="true" CodeBehind="venuePicture.aspx.cs" Inherits="TheSportsWeb.venuePicture" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CaName" runat="server">
    本部概况
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CaId" runat="server">
    场地设施
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="title_head" runat="server">
    <asp:Label runat="server" ID="lblVenue"></asp:Label>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="content" runat="server">
    <div class="main">
        <img src="imgs/photo.jpg">
        <span>1</span>
    </div>
    <%--<div class="bt">
        <a href="">上页</a>
        <a href="">下页</a>
        <p>当前第<span>1</span>页</p>
    </div>--%>
    <div style="text-align: center; margin-top: 20px;">
        <asp:Button ID="Butbefore" runat="server" Text="上一页" Style="background: transparent; border: none; cursor: pointer;" OnClick="Butbefore_Click"/>
        <asp:DropDownList ID="DDLnews" runat="server">
        </asp:DropDownList>
        <asp:Button ID="Button1" runat="server" Text="转到" OnClick="Button1_Click" Style="background: transparent; border: none; cursor: pointer;" />
        <asp:Button ID="Butafter" runat="server" Text="下一页" OnClick="Butafter_Click" Style="background: transparent; border: none; cursor: pointer;" />
    </div>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
