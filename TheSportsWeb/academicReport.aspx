<%@ Page Title="" Language="C#" MasterPageFile="~/common1.Master" AutoEventWireup="true" CodeBehind="academicReport.aspx.cs" Inherits="TheSportsWeb.academicReport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CaName" runat="server">
    学术动态
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CaContent" runat="server">
    
    <asp:Repeater runat="server" ID="science_report">
        <ItemTemplate>
            <li>>><a href="inweb1.aspx?commonType=<%# DataBinder.Eval(Container.DataItem, "id")%>" target="inweb">
                <%# DataBinder.Eval(Container.DataItem, "title")%></a></li>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="CaHeadName" runat="server">
    科研活动
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="CaHead" runat="server">
    学术动态
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="content" runat="server">
    <iframe id="inweb" width="100%" scrolling="auto" height="500" frameborder="0" src="inweb.aspx?commonType=1019" name="inweb"></iframe>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
