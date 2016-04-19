<%@ Page Title="" Language="C#" MasterPageFile="~/LoginMaster.Master" AutoEventWireup="true" CodeBehind="Login_video.aspx.cs" Inherits="TheSportsWeb.Login_video"  %>
<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main">
        <h3>添加视频信息</h3>
        <p>&nbsp;</p>
        <p>视频标题：<asp:TextBox ID="txtTitle" runat="server" OnTextChanged="txtTitle_TextChanged"></asp:TextBox></p>
        <p>&nbsp;</p>
        <p>上传视频：<a href="http://www.tudou.com/my/program/publish.html" target="_blank">土豆上传</a></p>
        <p>&nbsp;</p>
        <p>视频内容(复制上传的html代码)：
            <FCKeditorV2:FCKeditor ID="fckVideo" runat="server" Height="500px"></FCKeditorV2:FCKeditor>
        </p>
        <p style="margin-left: 220px;">
                <asp:Button ID="btnAdd" runat="server" Text="添加视频" OnClick="btnAdd_Click" ></asp:Button>
            </p>
        <p style="margin-left: 220px;">
                &nbsp;</p>
    </div>
</asp:Content>
