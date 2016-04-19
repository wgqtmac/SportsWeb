<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login_addTeacher.aspx.cs" Inherits="TheSportsWeb.Login_addTeacher" %>
<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>添加教师信息</title>
    <script src="fckeditor/fckeditor.js"></script>
    <link href="css/manager.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="head">
            <h3>教师管理</h3>
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
                <a href="Login_addVenue.aspx" target="_blank" >添加场地图片</a>
            </div>
        </div>
        <div class="main" style="height:900px">
            <h3>添加教师</h3>
            <p>
                教师姓名：<asp:TextBox runat="server" ID="txtName"></asp:TextBox>
            </p>
            <p>党派：&nbsp;&nbsp;<asp:TextBox ID="txtParty" runat="server"></asp:TextBox></p>
             <p>职称：&nbsp;&nbsp;<asp:TextBox ID="txtTitle" runat="server"></asp:TextBox></p>
             <p>职位：&nbsp;&nbsp;<asp:TextBox ID="txtPost" runat="server"></asp:TextBox></p>
            <p>上传头像：&nbsp;&nbsp;<asp:FileUpload runat="server" ID="imgUpLoad"/></p>
            <p>
                <asp:Image ID="Image1" runat="server" Height="150px" Width="126px" />
            </p>
            <p>
                &nbsp;&nbsp;
                <asp:Button ID="btnUpLoad" runat="server" Text="上传图片" OnClick="btnUpLoad_Click" 
                    Width="78px" />
            &nbsp;&nbsp;&nbsp;<asp:Label ID="lblNote" runat="server" Text="Label"></asp:Label>
            </p>
            <p>
                个人具体信息：<fckeditorv2:fckeditor id="fckContent" runat="server" width="600px" height="300px"></fckeditorv2:fckeditor>
            </p>
            <p style="margin-left: 220px;">
                <asp:Button ID="btnAdd" runat="server" Text="添加教师信息" OnClick="btnAdd_Click"></asp:Button>
            </p>
        </div>
    </form>
</body>
</html>
