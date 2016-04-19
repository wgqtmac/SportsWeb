<%@ Page Title="" Language="C#" MasterPageFile="~/common1.Master" AutoEventWireup="true" CodeBehind="download.aspx.cs" Inherits="TheSportsWeb.content" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CaName" runat="server">
    下载专区
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CaContent" runat="server">
  
    <asp:Repeater ID="download" runat="server">
        <ItemTemplate>
            <li>>><a href="inweb2.aspx?commonSonType=<%# DataBinder.Eval(Container.DataItem, "id")%>" target="inweb"><%# DataBinder.Eval(Container.DataItem, "title")%></a></li>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="CaHeadName" runat="server">
    下载专区
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="CaHead" runat="server">
    资料下载
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="content" runat="server">
    <iframe id="inweb" width="100%" scrolling="auto" height="600px" frameborder="0" src="inweb.aspx?commonType=1025" name="inweb"></iframe>
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
