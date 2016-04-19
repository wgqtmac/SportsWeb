<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TheSportsWeb.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="css/style-run.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="main">
            <ul>
                <li>
                    <%--<input type="text">--%>
                    <asp:TextBox runat="server" CssClass="input" ID="txtName"></asp:TextBox></li>
                <li>
                    <%--<input type="text">--%>
                    <asp:TextBox runat="server" CssClass="input" ID="txtPwd" TextMode="Password"></asp:TextBox>
                </li>
            </ul>
            <%--<input class="button" type="submit" value="">--%>
            <asp:Button runat="server" CssClass="button" ID="btnLogin" OnClick="btnLogin_Click" />
        </div>
    </form>
</body>
</html>
