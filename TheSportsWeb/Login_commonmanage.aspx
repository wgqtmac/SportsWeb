<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login_commonmanage.aspx.cs" Inherits="TheSportsWeb.Login_localmanage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="css/manager.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style2 {
            height: 19px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="head">
            <h3>新闻管理</h3>
            <div class="top">
                <a href="Login_addNews.aspx" target='_self'>增加新闻</a>
                <a href="Login_newsmanager.aspx" target='_self'>新闻管理</a>
                <a href="Login_commonmanage.aspx" target='_self'>栏目管理</a>
                <a href="LoginCommonSonmanage.aspx" target='_self'>二级栏目管理</a>
                <a href="Login_addCommonSon.aspx" target='_self'>添加二级栏目</a>
                <a href="LoginDownloadManager.aspx" target="_self">文件管理</a>
                <a href="Login_download.aspx" target='_self'>上传文件</a>
                <a href="Login_video.aspx" target='_self'>添加视频</a>
                <a href="LoginVideoManager.aspx" target="_self">视频管理</a>
                <a href="LoginTeacherManager.aspx" target="_self">教师管理</a>
                <a href="Login_addTeacher.aspx" target="_self">添加教师</a>
                <a href="LoginVenueManager.aspx" target="_self">场地管理</a>
                <a href="Login_addVenue.aspx" target="_self" >添加场地图片</a>
            </div>
        </div>
        <div>
            <table class="tb">
                <tr>
                    <th>所属分类</th>
                    <th>新闻标题</th>
                    <th>修改</th>
                </tr>
                <asp:Repeater ID="repInfos" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%#suoshufenlei( Eval ("id").ToString ()) %></td>
                            <td><%#Eval("title") %></td>
                            <td><a href='Login_alterCommon.aspx?commonId=<%#Eval ("id") %>' target="_blank">修改</a></td>
                        </tr>

                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </div>
        <div style="text-align: center; margin-top: 20px;">
            <asp:Button ID="Butbefore" runat="server" Text="上一页" Style="background: transparent; border: none; cursor: pointer;" OnClick="Butbefore_Click" />
            <asp:DropDownList ID="DDLnews" runat="server">
            </asp:DropDownList>
            <asp:Button ID="Button1" runat="server" Text="转到" OnClick="Button1_Click" Style="background: transparent; border: none; cursor: pointer;" />
            <asp:Button ID="Butafter" runat="server" Text="下一页" OnClick="Butafter_Click" Style="background: transparent; border: none; cursor: pointer;" />
        </div>
    </form>
</body>
</html>
