<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addVideo.aspx.cs" Inherits="TheSportsWeb.login.addVideo" %>
<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../css/manager.css" rel="stylesheet" />
    
</head>
<body>
    <form id="form1" runat="server">
    <div class="main">
        <h3>添加视频信息</h3>
        <p>&nbsp;</p>
        <p>视频标题：<asp:TextBox ID="txtTitle" runat="server" ></asp:TextBox></p>
        <p>&nbsp;</p>
        <p>上传视频：<a href="http://www.tudou.com/my/program/publish.html" target="_blank">土豆上传</a></p>
        <p>&nbsp;</p>
        <p>视频内容(复制上传的html代码)：
            <FCKeditorV2:FCKeditor ID="fckVideo" runat="server" Height="300px"></FCKeditorV2:FCKeditor>
        </p>
        <p style="margin-left: 220px;">
                <asp:Button ID="btnAdd" runat="server" Text="添加视频" OnClick="btnAdd_Click" ></asp:Button>
            </p>
        <p style="margin-left: 220px;">
                &nbsp;</p>
    </div>
    </form>
</body>
</html>
