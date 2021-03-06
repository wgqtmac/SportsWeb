﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login_alterCommonSon.aspx.cs" Inherits="TheSportsWeb.Login_alterCommonSon" %>

<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="css/manager.css" type="text/css" rel="stylesheet">
</head>
<body>
    <div class="head">
        <h3>后台管理</h3>
        <div class="top">
            <a href="Login_addNews.aspx" target='_blank'>增加新闻</a>
            <a href="Login_newsmanager.aspx">新闻管理</a>
            <a href="Login_commonmanage.aspx" target='_blank'>栏目管理</a>
            <a href="LoginCommonSonmanage.aspx" target='_blank'>二级栏目管理</a>
            <a href="Login_addCommonSon.aspx" target='_blank'>添加二级栏目</a>
            <a href="LoginDownloadManager.aspx" target="_blank">文件管理</a>
            <a href="Login_download.aspx" target='_blank'>上传文件</a>
            <a href="Login_video.aspx" target='_blank'>添加视频</a>
            <a href="LoginVideoManager.aspx" target="_blank">视频管理</a>
            <a href="LoginTeacherManager.aspx" target="_blank">教师管理</a>
            <a href="Login_addTeacher.aspx" target="_blank">添加教师</a>
            <a href="LoginVenueManager.aspx" target="_blank">场地管理</a>
            <a href="Login_addVenue.aspx" target="_blank">添加场地图片</a>
        </div>
    </div>
    <form id="form1" runat="server">
        <div class="main">
            <h3>修改二级栏目</h3>

            <p>栏目标题：<asp:TextBox ID="txtTitle" runat="server"></asp:TextBox></p>
            <p>
                栏目内容：<FCKeditorV2:FCKeditor ID="fckContent" runat="server" Width="600px" Height="400px"></FCKeditorV2:FCKeditor>
            </p>
            <p style="margin-left: 200px;">
                <asp:Button ID="btnAdd" runat="server" Text="修改顶栏" OnClick="btnAdd_Click"></asp:Button>
            </p>
        </div>
    </form>
</body>
</html>
