<%@ Page Title="" Language="C#" MasterPageFile="~/common.Master" AutoEventWireup="true" CodeBehind="teacherInfo.aspx.cs" Inherits="TheSportsWeb.teacherInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CaName" runat="server">
    本部概况
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CaId" runat="server">
    师资队伍
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="title_head" runat="server">
    师资队伍
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="content" runat="server">
    <div class="intro">
        <h3>个人简介</h3>
        <%--<img src="imgs/man.jpg">--%>
        <asp:Repeater runat="server" ID="teacherInfos">
                <ItemTemplate>
        <img src="<%# DataBinder.Eval(Container.DataItem, "pic_path")%>">
        <div class="intro-main">
            <%--<h2>房游光</h2>
            <span>个人资料</span>
            <p>房游光，男，1960年12月生人，中共党员，1982年毕业于北京体育大学，房游光，男，1960年12月生人，中共党员，1982年毕业于北京体育大学，房游光，男，1960年12月生人</p>--%>
            <%--<asp:Repeater runat="server" ID="teacherInfos">
                <ItemTemplate>--%>
                    <%--<div class="box">
                        <a href="">
                            <img src="<%# DataBinder.Eval(Container.DataItem, "pic_path")%>"></a>
                        <a href=""><%# DataBinder.Eval(Container.DataItem, "teaName")%><span><%# DataBinder.Eval(Container.DataItem, "party")%></span></a>
                        <p><%# DataBinder.Eval(Container.DataItem, "title")%><span><%# DataBinder.Eval(Container.DataItem, "post")%></span></p>
                    </div>--%>
                    <h2><%# DataBinder.Eval(Container.DataItem, "teaName")%></h2>
                    <span>个人资料</span>
                    <p><%# DataBinder.Eval(Container.DataItem, "content")%></p>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
