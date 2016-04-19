<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="left.aspx.cs" Inherits="UI.admin.left" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>

    <title>后台管理页面</title>
    <meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
    <script src="../js/prototype.lite.js" type="text/javascript"></script>
    <script src="../js/moo.fx.js" type="text/javascript"></script>
    <script src="../js/moo.fx.pack.js" type="text/javascript"></script>
    <style type="text/css">
        body {
            font: 12px Arial, Helvetica, sans-serif;
            color: #000;
            background-color: #EEF2FB;
            margin: 0px;
        }

        #container {
            width: 182px;
        }

        H1 {
            font-size: 12px;
            margin: 0px;
            width: 182px;
            cursor: pointer;
            height: 30px;
            line-height: 20px;
        }

            H1 a {
                display: block;
                width: 182px;
                color: #000;
                height: 30px;
                text-decoration: none;
                moz-outline-style: none;
                background-image: url(../imgs/menu_bgS.gif);
                background-repeat: no-repeat;
                line-height: 30px;
                text-align: center;
                margin: 0px;
                padding: 0px;
            }

        .content {
            width: 182px;
            height: 26px;
        }

        .MM ul {
            list-style-type: none;
            margin: 0px;
            padding: 0px;
            display: block;
        }

        .MM li {
            font-family: Arial, Helvetica, sans-serif;
            font-size: 12px;
            line-height: 26px;
            color: #333333;
            list-style-type: none;
            display: block;
            text-decoration: none;
            height: 26px;
            width: 182px;
            padding-left: 0px;
        }

        .MM {
            width: 182px;
            margin: 0px;
            padding: 0px;
            left: 0px;
            top: 0px;
            right: 0px;
            bottom: 0px;
            clip: rect(0px,0px,0px,0px);
        }

            .MM a:link {
                font-family: Arial, Helvetica, sans-serif;
                font-size: 12px;
                line-height: 26px;
                color: #333333;
                background-image: url(../imgs/menu_bg1.gif);
                background-repeat: no-repeat;
                height: 26px;
                width: 182px;
                display: block;
                text-align: center;
                margin: 0px;
                padding: 0px;
                overflow: hidden;
                text-decoration: none;
            }

            .MM a:visited {
                font-family: Arial, Helvetica, sans-serif;
                font-size: 12px;
                line-height: 26px;
                color: #333333;
                background-image: url(../imgs/menu_bg1.gif);
                background-repeat: no-repeat;
                display: block;
                text-align: center;
                margin: 0px;
                padding: 0px;
                height: 26px;
                width: 182px;
                text-decoration: none;
            }

            .MM a:active {
                font-family: Arial, Helvetica, sans-serif;
                font-size: 12px;
                line-height: 26px;
                color: #333333;
                background-image: url(../imgs/menu_bg1.gif);
                background-repeat: no-repeat;
                height: 26px;
                width: 182px;
                display: block;
                text-align: center;
                margin: 0px;
                padding: 0px;
                overflow: hidden;
                text-decoration: none;
            }

            .MM a:hover {
                font-family: Arial, Helvetica, sans-serif;
                font-size: 12px;
                line-height: 26px;
                font-weight: bold;
                color: #006600;
                background-image: url(../imgs/menu_bg2.gif);
                background-repeat: no-repeat;
                text-align: center;
                display: block;
                margin: 0px;
                padding: 0px;
                height: 26px;
                width: 182px;
                text-decoration: none;
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table width="100%" height="280" border="0" cellpadding="0" cellspacing="0" bgcolor="#EEF2FB">
            <tr>
                <td width="182" valign="top">
                    <div id="container">
                        <h1 class="type"><a href="javascript:void(0)">本部概况</a></h1>
                        <div class="content">
                            <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td>
                                        <img src="../imgs/menu_topline.gif" width="182" height="5" /></td>
                                </tr>
                            </table>
                            <ul class="MM">
                                <li>
                                    <a href="adminUpdate.aspx?commonType=3" target="main">教学部简介</a></li>
                                <li>
                                    <asp:LinkButton ID="orgLink" OnClick="orgLink_Click"  runat="server">组织机构</asp:LinkButton></li>
                                <li>
                                    <asp:LinkButton ID="teachers" OnClick="teachers_Click" runat="server">师资队伍</asp:LinkButton></li>
                                <li>
                                    <asp:LinkButton ID="venueLink" OnClick="venueLink_Click" runat="server">场地设施</asp:LinkButton></li>
                            </ul>
                        </div>
                        <h1 class="type"><a href="javascript:void(0)">体育教学</a></h1>
                        <div class="content">
                            <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td>
                                        <img src="../imgs/menu_topline.gif" width="182" height="5" /></td>
                                </tr>
                            </table>
                            <ul class="MM">
                                <li>
                                    <asp:LinkButton ID="teachingIndLink" OnClick="teachingIndLink_Click" runat="server">教学简介</asp:LinkButton>
                                </li>
                                <li>
                                    <asp:LinkButton ID="regLink" OnClick="regLink_Click"  runat="server">规章制度</asp:LinkButton>
                                </li>
                                <li>
                                    <asp:LinkButton ID="couIndLink" OnClick="couIndLink_Click" runat="server">课程介绍</asp:LinkButton>
                                </li>
                            </ul>
                        </div>
                        <h1 class="type"><a href="javascript:void(0)">竞赛活动</a></h1>
                        <div class="content">
                            <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td>
                                        <img src="../imgs/menu_topline.gif" width="182" height="5" /></td>
                                </tr>
                            </table>
                            <ul class="MM">
                                <asp:LinkButton ID="gameLink" OnClick="gameLink_Click" runat="server">运动会</asp:LinkButton>
                            </ul>
                        </div>
                        <h1 class="type"><a href="javascript:void(0)">运动队管理</a></h1>
                        <div class="content">
                            <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td>
                                        <img src="../imgs/menu_topline.gif" width="182" height="5" /></td>
                                </tr>
                            </table>
                            <ul class="MM">
                                <asp:LinkButton ID="sportsTeamLink" OnClick="sportsTeamLink_Click" runat="server">运动队管理</asp:LinkButton>   
                            </ul>
                        </div>
                        <h1 class="type"><a href="javascript:void(0)">科研活动</a></h1>
                        <div class="content">
                            <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td>
                                        <img src="../imgs/menu_topline.gif" width="182" height="5" /></td>
                                </tr>
                            </table>
                            <ul class="MM">
                                <li> <asp:LinkButton ID="activityLink" OnClick="activityLink_Click" runat="server">活动简介</asp:LinkButton></li>
                                <li> <asp:LinkButton ID="reportLink" OnClick="reportLink_Click" runat="server">学术报告</asp:LinkButton></li>
                            </ul>
                        </div>
                        <h1 class="type"><a href="javascript:void(0)">体质监测中心</a></h1>
                        <div class="content">
                            <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td>
                                        <img src="../imgs/menu_topline.gif" width="182" height="5" /></td>
                                </tr>
                            </table>
                            <ul class="MM">
                                <asp:LinkButton ID="policyLink" OnClick="policyLink_Click" runat="server">政策文件</asp:LinkButton>
                                <asp:LinkButton ID="standardLink" OnClick="standardLink_Click" runat="server">标准方法</asp:LinkButton>
                            </ul>
                        </div>
                        <h1 class="type"><a href="javascript:void(0)">党建工会</a></h1>
                        <div class="content">
                            <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td>
                                        <img src="../imgs/menu_topline.gif" width="182" height="5" /></td>
                                </tr>
                            </table>
                            <ul class="MM">
                                <asp:LinkButton ID="partyLink" OnClick="partyLink_Click" runat="server">党组织</asp:LinkButton>
                                <asp:LinkButton ID="unionLink" OnClick="unionLink_Click" runat="server">工会组织</asp:LinkButton>
                            </ul>
                        </div>
                        <h1 class="type"><a href="javascript:void(0)">下载专区</a></h1>
                        <div class="content">
                            <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td>
                                        <img src="../imgs/menu_topline.gif" width="182" height="5" /></td>
                                </tr>
                            </table>
                            <ul class="MM">
                                <asp:LinkButton ID="downloaLink" OnClick="downloaLink_Click" runat="server">资料下载</asp:LinkButton>
                            </ul>
                        </div> 
                    </div>

                    <script type="text/javascript">
                        var contents = document.getElementsByClassName('content');
                        var toggles = document.getElementsByClassName('type');

                        var myAccordion = new fx.Accordion(
                        toggles, contents, { opacity: true, duration: 400 }
                    );
                        myAccordion.showThisHideOpen(contents[0]);
                    </script>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
