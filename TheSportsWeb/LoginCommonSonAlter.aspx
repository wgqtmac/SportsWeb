<%@ Page Title="" Language="C#" MasterPageFile="~/LoginMaster.Master" AutoEventWireup="true" CodeBehind="LoginCommonSonAlter.aspx.cs" Inherits="TheSportsWeb.LoginCommonSonAlter" %>

<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main">
        <h3>修改新闻</h3>
        <p>
            栏目分类：
      <asp:TextBox runat="server" ID="txtCommon" ReadOnly="true"></asp:TextBox>
        </p>
        <p>二级栏目标题：<asp:TextBox ID="txtTitle" runat="server"></asp:TextBox></p>
        <p>
            内容：<FCKeditorV2:FCKeditor ID="fckContent" runat="server" Width="600px" Height="400px"></FCKeditorV2:FCKeditor>
        </p>
        <p style="margin-left: 200px;">
            <asp:Button ID="btnAdd" runat="server" Text="修改内容" OnClick="btnAdd_Click"></asp:Button></p>
    </div>
</asp:Content>
