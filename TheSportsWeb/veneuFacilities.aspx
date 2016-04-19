<%@ Page Title="" Language="C#" MasterPageFile="~/common1.Master" AutoEventWireup="true" CodeBehind="veneuFacilities.aspx.cs" Inherits="TheSportsWeb.veneuFacilities" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CaName" runat="server">
    场地设施
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CaContent" runat="server">
    
    <asp:Repeater runat="server" ID="finessFacilities">
        <ItemTemplate>
            <%--<li>>><a href="venue.aspx?venueType=<%# DataBinder.Eval(Container.DataItem, "id")%>" target="inweb">
                <%# DataBinder.Eval(Container.DataItem, "title")%></a></li>--%>
                <li>>><a href="inweb1.aspx?commonType=<%# DataBinder.Eval(Container.DataItem, "id")%>" target="inweb"><%# DataBinder.Eval(Container.DataItem, "title")%></a></li>
        </ItemTemplate>
        
    </asp:Repeater>

</asp:Content>

<asp:Content ID="Content7" ContentPlaceHolderID="CaHeadName" runat="server">
    本部概况
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="CaHead" runat="server">
    <a href="veneuFacilities.aspx">场地设施</a>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="content" runat="server">
    <div class="inw">
        <iframe id="inweb" width="100%" scrolling="auto" height="600" frameborder="0" src="inweb.aspx?commonType=1020" name="inweb"></iframe>
    </div>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
