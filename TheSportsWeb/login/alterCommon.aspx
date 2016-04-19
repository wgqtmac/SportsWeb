<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="alterCommon.aspx.cs" Inherits="TheSportsWeb.login.alterCommon" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>修改文章页</title>
    <link href="../css/manager.css" type="text/css" rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server">
        <div class="main">
            <h3>修改一级栏目</h3>
            <%--<p>顶栏分类：
      <asp:DropDownList ID ="ddlCategory" runat="server" > 
       </asp:DropDownList>
       </p>--%>
            <p>栏目标题：<asp:TextBox ID="txtTitle" runat="server" ReadOnly="true"></asp:TextBox></p>
            <p>
                栏目内容：<FCKeditorV2:FCKeditor ID="fckContent" runat="server" Width="600px" Height="400px"></FCKeditorV2:FCKeditor>
            </p>
            <p style="margin-left: 200px;">
                <asp:Button ID="btnAdd" runat="server" Text="修改栏目" OnClick="btnAdd_Click"></asp:Button>
            </p>
        </div>
    </form>
</body>
</html>
