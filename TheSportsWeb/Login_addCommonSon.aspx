<%@ Page Title="" Language="C#" MasterPageFile="~/LoginMaster.Master" AutoEventWireup="true" CodeBehind="Login_addCommonSon.aspx.cs" Inherits="TheSportsWeb.Login_addCommonSon" %>

<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main">
            <h3>添加二级栏目</h3>
            <p>
                二级栏目分类：<asp:DropDownList ID="commonDDL" runat="server"></asp:DropDownList>
            </p>
            <p>二级栏目标题：<asp:TextBox ID="txtTitle" runat="server"></asp:TextBox></p>
            <p>
                内容：<fckeditorv2:fckeditor ID="fckContent" runat="server" Width="600px" Height="400px"></fckeditorv2:fckeditor>
            </p>
            <p style="margin-left: 220px;">
                <asp:Button ID="btnAdd" runat="server" Text="添加二级栏目" OnClick="btnAdd_Click"></asp:Button>
            </p>
        </div>
</asp:Content>
