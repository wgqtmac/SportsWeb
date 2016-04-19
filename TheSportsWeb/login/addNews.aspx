<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addNews.aspx.cs" Inherits="TheSportsWeb.login.addNews" %>
<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>添加新闻</title>
    <style type="text/css">
         .content
        {
            width: 700px;
            height: 420px;
            margin: 0px auto;
            margin-top: 10px;
           
        }
        .ct_c
        {
            width: 500px;
            margin: 0px auto;
            height: 410px;
        }
        .ct_c_1
        {
            height: 25px;
            margin-top: 3px;
        }
        .c_1_left
        {
            width: 130px;
            float: left;
            text-align: right;
            height: 26px;
            line-height: 26px;
            color: #666666;
        }
        .c_1_right
        {
            width: 330px;
            float: left;
            height: 26px;
            line-height: 26px;
        }
     .btn{width:400px;margin:0px auto;height:30px;line-height:30px;text-align:center;}
     </style>
    <script src="../fckeditor/fckeditor.js"></script>
    <link href="../css/manager.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        
        <div class="main">
            <h3>添加新闻</h3>
            <p>
                新闻分类：<asp:DropDownList ID="ddlCategory" runat="server"></asp:DropDownList>
            </p>
            <p>新闻标题：<asp:TextBox ID="txtTitle" runat="server"></asp:TextBox></p>
            <p>
                新闻内容：<FCKeditorV2:FCKeditor ID="fckContent" runat="server" Width="600px" Height="400px"></FCKeditorV2:FCKeditor>
            </p>
            <p></p>
            <p style="margin-left: 220px;">
                <asp:Button ID="btnAdd" runat="server" Text="添加新闻" OnClick="btnAdd_Click"></asp:Button>
            </p>
        </div>
    </form>
</body>
</html>
