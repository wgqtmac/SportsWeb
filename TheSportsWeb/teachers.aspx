<%@ Page Title="" Language="C#" MasterPageFile="~/common.Master" AutoEventWireup="true" CodeBehind="teachers.aspx.cs" Inherits="TheSportsWeb.teachers" %>

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
    <div class="main-pic" style="height:1400px">
        
            <%--<a href="">
                <img src="imgs/man.jpg"></a>
            <a href="">房游光<span>中共党员</span></a>
            <p>教授<span>副主任[主持工作]</span></p>--%>
            <asp:Repeater runat="server" ID="teacherList">
                <ItemTemplate>
                    <div class="box">
                    <a href="teacherInfo.aspx?teacherType=<%# DataBinder.Eval(Container.DataItem, "teaId")%>"><img src="<%# DataBinder.Eval(Container.DataItem, "pic_path")%>"></a>
                    <a href=""><%# DataBinder.Eval(Container.DataItem, "teaName")%><span><%# DataBinder.Eval(Container.DataItem, "party")%></span></a>
                    <p><%# DataBinder.Eval(Container.DataItem, "title")%><span><%# DataBinder.Eval(Container.DataItem, "post")%></span></p>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        
        
    </div>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
