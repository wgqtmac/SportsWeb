<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="venueDetails.aspx.cs" Inherits="TheSportsWeb.venueDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="css/css.css" rel="stylesheet" type="text/css" />
    <link href="css/style.css" rel="stylesheet" type="text/css" />
    <link href="css/style1.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="header">
        <img  src="imgs/header-img.png"style="float:right;">
  </div>
            <div id="warp">
                <div class="nav">
                    <ul>
                        <li class="bg" style="z-index: 10;"><a href="http://www.ncepu.edu.cn/">大学首页</a>
                        </li>
                        <li class="bg" style="z-index: 9;"><a href="index.aspx">首页信息</a> </li>
                        <li class="bg" style="z-index: 8;"><a href="">本部概况</a>
                            <ul>
                                <li><a href="teachingInduction.aspx">教学部简介</a></li>
                                <li><a href="organization.aspx">组织机构</a></li>
                                <li><a href="teachers.aspx">师资队伍</a></li>
                                <li><a href="veneuFacilities.aspx">场地设施</a></li>
                            </ul>
                        </li>
                        <li class="bg" style="z-index: 7;"><a href="">体育教学</a>
                            <ul>
                                <li><a href="techIndroduction.aspx">教学简介</a></li>
                                <li><a href="regulations.aspx">规章制度</a></li>
                                <li><a href="courseIntroduction.aspx">课程介绍</a></li>
                                <li><a href="http://59.67.225.73/jiaowuchu/?tid=10">课程表</a></li>
                                <li><a href="http://59.67.225.73/jiaowuchu/?tid=10">选课系统</a></li>
                            </ul>
                        </li>
                        <li class="bg" style="z-index: 6;"><a href="">  群众体育</a>
                            <ul>
                                <li><a href="games.aspx">运动会</a></li>
                            </ul>
                        </li>
                        <li class="bg" style="z-index: 5;"><a href="sportsTeam.aspx">竞技体育</a></li>
                        <li class="bg" style="z-index: 4;"><a href="">科研活动</a>
                            <ul>
                                <li><a href="activityProfile.aspx">科研概况</a></li>
                                <li><a href="academicReport.aspx">学术动态</a></li>
                            </ul>
                        </li>
                        <li class="bg" style="z-index: 3;"><a href="">体质监测中心</a>
                            <ul>
                                <li><a href="policyDocument.aspx">政策文件</a></li>
                                <li><a href="standardMethod.aspx">标准方法</a></li>
                            </ul>
                        </li>
                        <li class="bg" style="z-index: 2;"><a href="">党建工会</a>
                            <ul>
                                <li><a href="partyUnion.aspx">党组织</a></li>
                                <li><a href="unions.aspx">工会组织</a></li>
                            </ul>
                        </li>
                        <li class="bg" style="z-index: 1;"><a href="download.aspx">下载专区</a>
                            <ul>
                                <li><a href="download.aspx">资料下载</a></li>
                            </ul>
                        </li>
                    </ul>
                </div>
            </div>
            <!-- ------------------------------------------ -->
            <div class="s-content">

                <div class="s-fright1">
                    <p class="frightp">您当前所在的位置是 : 华北电力大学——体育教学部——<span style="color: #000;">场地设施</span></p>
                    <div class="new">
                        <div class="new-header">
                            <h2>
                                <asp:Label ID="lblName" runat="server"></asp:Label></h2>
                        </div>
                        <div class="main">
                            <asp:Repeater ID="repInfos" runat="server">
                                <ItemTemplate>
                                    <img src="<%#Eval("pic_path") %>" />
                                </ItemTemplate>
                            </asp:Repeater>
                            <span><%#Eval("content") %></span>
                        </div>
                        <%--<div style="margin-left: 350px">
                            <asp:Button ID="previousBtn" Text="上页" runat="server" OnClick="previousBtn_Click" />
                            &nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:DropDownList ID="DDLnews" runat="server">
                            </asp:DropDownList>
                            &nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="goBtn" runat="server" Text="转到" OnClick="goBtn_Click" />
                            &nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="nextBtn" Text="下页" runat="server" OnClick="nextBtn_Click" />
                        </div>--%>
                    </div>
                </div>
            </div>




            <!-- ------------------ -->
            <div class="bottom">
                <div class="sbottom">
                    <p>版权所有：华北电力大学体育教学部</p>
                    <p>技术支持：华北电力大学Dreamtech计算机工作室</p>
                    <span><a href="Login.aspx">管理员登陆</a></span>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
