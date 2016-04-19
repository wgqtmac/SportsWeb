<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admintop.aspx.cs" Inherits="TheSportsWeb.admin.admintop" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>后台管理页面</title>
    <script language="JavaScript">
        function logout() {
            if (confirm("您确定要退出控制面板吗？"))
                top.location = "out.asp";
            return false;
        }
    </script>
    <script language="JavaScript1.2">
function showsubmenu(sid) {
	var whichEl = eval("submenu" + sid);
	var menuTitle = eval("menuTitle" + sid);
	if (whichEl.style.display == "none"){
		eval("submenu" + sid + ".style.display=\"\";");
	}else{
		eval("submenu" + sid + ".style.display=\"none\";");
	}
}
    </script>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta http-equiv="refresh" content="60">
    <script language="JavaScript1.2">
function showsubmenu(sid) {
	var whichEl = eval("submenu" + sid);
	var menuTitle = eval("menuTitle" + sid);
	if (whichEl.style.display == "none"){
		eval("submenu" + sid + ".style.display=\"\";");
	}else{
		eval("submenu" + sid + ".style.display=\"none\";");
	}
}
    </script>
    <base target="main">
    <link href="../imgs/skin.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            height: 38px;
        }

        .auto-style2 {
            height: 64px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <body leftmargin="0" topmargin="0">
            <table width="100%" height="64" border="0" cellpadding="0" cellspacing="0" class="admin_topbg">
                <tr>
                    <td width="61%" class="auto-style2">
                        <img src="../imgs/logo.gif" width="262" height="64"></td>
                    <td width="39%" valign="top" class="auto-style2">
                        <table width="100%" border="0" cellspacing="0" cellpadding="0">
                            <tr>
                                <td width="74%" class="admin_txt">管理员：您好,感谢登陆使用！</td>
                                <td width="22%" class="auto-style1"><a href="#" target="_self" onclick="logout();">
                                    <img src="../imgs/out.gif" alt="安全退出" width="46" height="20" border="0"></a></td>
                                <td width="4%" class="auto-style1"></td>
                            </tr>
                            <tr>
                                <td height="19" colspan="3">&nbsp;</td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </body>
    </form>
</body>
</html>
