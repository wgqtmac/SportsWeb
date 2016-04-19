<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login_newsManager.aspx.cs" Inherits="TheSportsWeb.Login_newsManager" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="css/manager.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="head">
            <h3>新闻管理</h3>
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
        <div>
            <table class="tb">
                <tr>
                    <th>所属分类</th>
                    <th>新闻标题</th>
                    <th>修改</th>
                    <th>删除</th>
                </tr>
                <asp:Repeater ID="repInfos" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%#suoshufenlei( Eval ("id").ToString ()) %></td>
                            <td><%#Eval("title") %></td>
                            <td><a href='Login_newsAlter.aspx?newsId=<%#Eval ("id") %>' target="_blank">修改</a></td>
                            <td>
                                <asp:LinkButton ID="lbtnDel" runat="server" CommandArgument='<%#Eval("id") %>' OnClientClick="return confirm('确定要删除该条新闻吗？')" OnClick="lbtnDel_Click"> 删除</asp:LinkButton></td>
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
