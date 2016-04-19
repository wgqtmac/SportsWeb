﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addCommonSon.aspx.cs" Inherits="TheSportsWeb.login.addCommonSon" %>
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
    </form>
</body>
</html>
