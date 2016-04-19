<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="TheSportsWeb.index" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>体育部首页</title>
    <link href="css/css.css" rel="stylesheet" type="text/css" />
    <link href="css/style.css" rel="stylesheet" type="text/css" />
    <link href="css/style1.css" rel="stylesheet" type="text/css" />
    <script src="js/pic.js" type="text/javascript"></script>
    <script src="js/js.js"></script>
    <!-- wbg解决ie6下的背景 勿动！！！-->
    <%--[if IE 6]>
    <script src="js/ie_png.js" mce_src="js/ie_png.js">
    </script>
    <script type="text/javascript">
        DD_belatedPNG.fix('.previous,img');
    </script>
    <![endif]--%>
</head>
<script type="text/javascript">
    function clo() {
        var div = document.getElementById("roll");
        div.style.display = "none";
    }

</script>
<body>
    <form id="form1" runat="server">
    <div id="roll">
        <input id="Button1" class="close" type="button" onclick="clo()" runat="server"><%--<asp:Button CssClass="close" ID="btnXuanfu" OnClick="btnXuanfu_Click" runat="server" />--%>
        <a href="newsDetails.aspx?newsType=<% = newNewsId()%>"><p style="margin:40px 15px;font-size:20px;color:#fff;"><% = newNewsTitle()%></p></a>
        </div>
        <SCRIPT src="js/js.js"></SCRIPT>
    <div class="header">
        <img  src="imgs/header-img.png"style="float:right;">
  </div>
 
      <div class="line-box">
      <a href="http://ty.ncepu.edu.cn/" >北京校区体育教学部</a>
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
                                <li><a href="CourseTable.aspx">课程表</a></li>
                                <li><a href="http://59.67.225.73/jiaowuchu/?tid=10">选课系统</a></li>
                            </ul>
                        </li>
                        <li class="bg" style="z-index: 6;"><a href="">  群众体育</a>
                            <ul>
                                <li><a href="sportsMeeting.aspx">运动会</a></li>
                                <li><a href="sportsDay.aspx">体育节</a></li>
                            </ul>
                        </li>
                        <li class="bg" style="z-index: 5;"><a href="sportsTeam.aspx">竞技体育</a>
                            <ul>
                                <li><a href="highLevelTeam.aspx">高水平运动队</a></li>
                                <li><a href="commonStudentTeam.aspx">普通学生代表队</a></li>
                            </ul>
                        
                        </li>
                        <li class="bg" style="z-index: 4;"><a href="">科研活动</a>
                            <ul>
                                <li><a href="activityProfile.aspx">科研概况</a></li>
                                <li><a href="academicReport.aspx">学术动态</a></li>
                            </ul>
                        </li>
                        <li class="bg" style="z-index: 3;"><a href="">体质监测与评价</a>
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
                        <li class="bg" style="z-index: 1; top: 0px; left: 0px;"><a href="download.aspx">下载专区</a>
                            <ul>
                                <li><a href="download.aspx">资料下载</a></li>
                            </ul>
                        </li>
                    </ul>
                </div>
            </div>
    
    <!-- ---------------------------------------------------------------------- -->
    <script language="javascript" type="text/javascript">

        var s = function () {
            var interv = 2000;
            var interv2 = 10;
            var opac1 = 80;
            var source = "fade_focus"
            function getTag(tag, obj) { if (obj == null) { return document.getElementsByTagName(tag) } else { return obj.getElementsByTagName(tag) } }
            function getid(id) { return document.getElementById(id) };
            var opac = 0, j = 0, t = 63, num, scton = 0, timer, timer2, timer3; var id = getid(source); id.removeChild(getTag("div", id)[0]); var li = getTag("li", id); var div = document.createElement("div"); var title = document.createElement("div"); var span = document.createElement("span"); var button = document.createElement("div"); button.className = "button"; for (var i = 0; i < li.length; i++) { var a = document.createElement("a"); a.innerHTML = i + 1; a.onclick = function () { clearTimeout(timer); clearTimeout(timer2); clearTimeout(timer3); j = parseInt(this.innerHTML) - 1; scton = 0; t = 63; opac = 0; fadeon(); }; a.className = "b1"; a.onmouseover = function () { this.className = "b2" }; a.onmouseout = function () { this.className = "b1"; sc(j) }; button.appendChild(a); }
            function alpha(obj, n) { if (document.all) { obj.style.filter = "alpha(opacity=" + n + ")"; } else { obj.style.opacity = (n / 100); } }
            function sc(n) { for (var i = 0; i < li.length; i++) { button.childNodes[i].className = "b1" }; button.childNodes[n].className = "b2"; }
            title.className = "num_list"; title.appendChild(span); alpha(title, opac1); id.className = "d1"; div.className = "d2"; id.appendChild(div); id.appendChild(title); id.appendChild(button);
            var fadeon = function () { opac += 5; div.innerHTML = li[j].innerHTML; span.innerHTML = getTag("img", li[j])[0].alt; alpha(div, opac); if (scton == 0) { sc(j); num = -2; scrolltxt(); scton = 1 }; if (opac < 100) { timer = setTimeout(fadeon, interv2) } else { timer2 = setTimeout(fadeout, interv); }; }
            var fadeout = function () { opac -= 5; div.innerHTML = li[j].innerHTML; alpha(div, opac); if (scton == 0) { num = 2; scrolltxt(); scton = 1 }; if (opac > 0) { timer = setTimeout(fadeout, interv2) } else { if (j < li.length - 1) { j++ } else { j = 0 }; fadeon() }; }
            var scrolltxt = function () { t += num; span.style.marginTop = t + "px"; if (num < 0 && t > 3) { timer3 = setTimeout(scrolltxt, interv2) } else if (num > 0 && t < 62) { timer3 = setTimeout(scrolltxt, interv2) } else { scton = 0 } };
            fadeon();
        }
        window.onload = s;

    </script>
    <div class="content">
        <div class="fleft">
            <div class="fleft2">
                <div id="fade_focus">
                    <div class="loading">
                        Loading...<br />
                        <img src="http://p1.mb5u.com/texiao/1/20110225160506306.gif">
                    </div>
                    <ul class="ul1">
                        <li>
                            <img src="<%=picAllList(0)%>" width="380" height="250" alt="<%=picAllContent(0) %>" /></li>
                        <li>
                            <img src="<%=picAllList(1) %>" width="380" height="250" alt="<%=picAllContent(1) %>" /></li>
                        <li>
                            <img src="<%=picAllList(2) %>" width="380" height="250" alt="<%=picAllContent(2) %>" /></li>
                        <li>
                            <img src="<%=picAllList(3) %>" width="380" height="250" alt="<%=picAllContent(3) %>" /></li>
                        <li>
                            <img src="<%=picAllList(4)%>" width="380" height="250" alt="<%=picAllContent(4) %>" /></li>
                        <%--<li>
                            <img src="UploadFiles/20101227111745114(1).jpg" width="380" height="250" alt="ncepu" /></li>
                        <li>
                            <img src="UploadFiles/20101227111745114(1).jpg" width="380" height="250" alt="ncepu" /></li>
                        <li>
                            <img src="UploadFiles/photo.jpg" width="380" height="250" alt="ncepu" /></li>
                        <li>
                           <img src="UploadFiles/photo2.jpg" width="380" height="250" alt="ncepu" /></li>
                        <li>
                            <img src="UploadFiles/photo3.jpg" width="380" height="250" alt="ncepu" /></li>--%>
                    </ul>
                </div>
            </div>
            <div class="fleft1">
                <div class="fcontent"><h3>通知公告</h3><span><a href="news.aspx?newsType=8">More >></a></span></div>
                <div class="nr1">
                    
                    <ul class="hul1">
                        <asp:Repeater runat="server" ID="inform_announce">
                            <ItemTemplate>
                                <li><a href="newsDetails.aspx?newsType=<%# DataBinder.Eval(Container.DataItem, "id")%>">
                                    <%# DataBinder.Eval(Container.DataItem, "title")%></a><span><%# DataBinder.Eval(Container.DataItem, "time")%></span></li>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                </div>
            </div>
            <div class="fleft1">
               <div class="fcontent"><h3>相关链接</h3><span><a href="#">More >></a></span></div>
                <div class="nr2">
                    
                    <ul class="hul2">
                        <li><a href="http://sports.cntv.cn/">体育频道</a></li>
                        <li><a href="http://www.sports.whu.edu.cn/">武汉大学体育部</a></li>
                        <li><a href="http://www.thsports.tsinghua.edu.cn/">清华大学体育部</a></li>
                        <li><a href="http://www.csh123.com/">学生体质健康服务网</a></li>
                    </ul>
                </div>
            </div>
            <div class="fleft1">
               <div class="fcontent"><h3 style="background-color: #ff9900">信息平台</h3><span><a href="news.aspx?newsType=12">More >></a></span></div>
                <div class="nr3">
                    
                    <ul class="hul2">
                        <asp:Repeater runat="server" ID="information_station">
                            <ItemTemplate>
                                <li><a href="newsDetails.aspx?newsType=<%# DataBinder.Eval(Container.DataItem, "id")%>">
                                    <%# DataBinder.Eval(Container.DataItem, "title")%></a></li>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                </div>
            </div>
        </div>
        <div class="fright">
            <div class="fright1">
                <div class="box1">
                               <div class="box-content"> <h3>新闻动态</h3>
            <span><a href="news.aspx?newsType=1">MORE >></a></span></div>
                    <ul class="hul4">
                        <%--<li><a href="">我校足球队痛失小组出线机会</a><span>2013-7-23</span></li>
                            <li><a href="">关于09-10学生代表补测的通知</a><span>2013-7-23</span></li>
                            <li><a href="">我校足球队痛失小组出线机会</a><span>2013-7-23</span></li>
                            <li><a href="">关于09-10学生代表补测的通知</a><span>2013-7-23</span></li>
                            <li><a href="">关于09-10学生代表补测的通知</a><span>2013-7-23</span></li>
                            <li><a href="">我校足球队痛失小组出线机会</a><span>2013-7-23</span></li>
                            <li><a href="">关于09-10学生代表补测的通知</a><span>2013-7-23</span></li>
                            <li><a href="">我校足球队痛失小组出线机会</a><span>2013-7-23</span></li>--%>
                        <asp:Repeater runat="server" ID="teachnews">
                            <ItemTemplate>
                                <li><a href="newsDetails.aspx?newsType=<%# DataBinder.Eval(Container.DataItem, "id")%>">
                                    <%# DataBinder.Eval(Container.DataItem, "title")%></a><span><%# DataBinder.Eval(Container.DataItem, "time")%></span></li>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                </div>
                <div class="box2">
                   <div class="box-content1"><h3>视频专区</h3>
            <span><a href="videoArea.aspx">MORE >></a></span></div>
                    <ul class="hul1">
                        <%--<li><a href="">健美操考试动作示范视频</a></li>
                            <li><a href="">团体操表演视频</a></li>
                            <li><a href="">体育舞蹈视频</a></li>--%>
                        <asp:Repeater runat="server" ID="videoRepeater">
                            <ItemTemplate>
                                <li><a href="videoDetails.aspx?videoType=<%# DataBinder.Eval(Container.DataItem, "vId")%>">
                                    <%# DataBinder.Eval(Container.DataItem, "vTitle")%></a></li>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                </div>
            </div>
            <div class="fright2">
                <div class="sright">
                    <div class="sright1">
                        <!-- ----------------------------- -->
                        <div id="tab_container2" style="width: 360px;">
                            <div class="cls_tab_nav">
                                <ul>
                                    <li class="cls_tab_nav_li cls_tab_nav_li_first"><a href="news.aspx?newsType=2">科研活动</a></li>
                                    <li class="cls_tab_nav_li"><a href="news.aspx?newsType=3">● 交流活动</a></li>
                                    <li class="cls_tab_nav_li"><a href="news.aspx?newsType=4">● 社团活动</a></li>
                                </ul>
                                <span><a href="news.aspx?newsType=2">More>></a></span>
                            </div>
                            <div class="cls_tab_body">
                                <div class="cls_div" style="display: block;">
                                    <ul class="hul3">
                                        <%--<li><a href="">关于09-11学生代表补测的通知</a></li>
                                            <li><a href="">关于09-10学生代表补测的通知</a></li>
                                            <li><a href="">李全华教授发表论文：事论信心在田径中的作用</a></li>
                                            <li><a href="">关于09-10学生代表补测的通知</a></li>
                                            <li><a href="">关于09-10学生代表补测的通知</a></li>
                                            <li><a href="">李全华教授发表论文：事论信心在田径中的作用</a></li>--%>
                                        <asp:Repeater runat="server" ID="researchnews">
                                            <ItemTemplate>
                                                <li><a href="newsDetails.aspx?newsType=<%# DataBinder.Eval(Container.DataItem, "id")%>">
                                                    <%# DataBinder.Eval(Container.DataItem, "title")%></a></li>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </ul>
                                </div>
                                <div class="cls_div">
                                    <ul class="hul3">
                                        <%--<li><a href="">关于09-12学生代表补测的通知</a></li>
                                            <li><a href="">关于09-10学生代表补测的通知</a></li>
                                            <li><a href="">李全华教授发表论文：事论信心在田径中的作用</a></li>
                                            <li><a href="">关于09-10学生代表补测的通知</a></li>
                                            <li><a href="">关于09-10学生代表补测的通知</a></li>
                                            <li><a href="">李全华教授发表论文：事论信心在田径中的作用</a></li>--%>
                                        <asp:Repeater runat="server" ID="communicationnews">
                                            <ItemTemplate>
                                                <li><a href="newsDetails.aspx?newsType=<%# DataBinder.Eval(Container.DataItem, "id")%>">
                                                    <%# DataBinder.Eval(Container.DataItem, "title")%></a></li>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </ul>
                                </div>
                                <div class="cls_div">
                                    <ul class="hul3">
                                        <%--<li><a href="">关于09-13学生代表补测的通知</a></li>
                                            <li><a href="">关于09-10学生代表补测的通知</a></li>
                                            <li><a href="">李全华教授发表论文：事论信心在田径中的作用</a></li>
                                            <li><a href="">关于09-10学生代表补测的通知</a></li>
                                            <li><a href="">关于09-10学生代表补测的通知</a></li>
                                            <li><a href="">李全华教授发表论文：事论信心在田径中的作用</a></li>--%>
                                        <asp:Repeater runat="server" ID="organizationnews">
                                            <ItemTemplate>
                                                <li><a href="newsDetails.aspx?newsType=<%# DataBinder.Eval(Container.DataItem, "id")%>">
                                                    <%# DataBinder.Eval(Container.DataItem, "title")%></a></li>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="sright1">
                        <div id="tab_container1">
                            <div class="cls_tab_nav">
                                <ul>
                                    <li class="cls_tab_nav_li cls_tab_nav_li_first"><a href="news.aspx?newsType=5">体质测试</a></li>
                                    <li class="cls_tab_nav_li"><a href="news.aspx?newsType=6">● 测试通知</a></li>
                                    <li class="cls_tab_nav_li"><a href="news.aspx?newsType=7">● 锻炼手册</a></li>
                                </ul>
                                <span><a href="news.aspx?newsType=5">More>></a></span>
                            </div>
                            <div class="cls_tab_body">
                                <div class="cls_div" style="display: block;">
                                    <ul class="hul3">
                                        <%--<li><a href="">《国家学生体质健康标准》测试的标准方法</a></li>
                                            <li><a href="">《国家学生体质健康标准》测试的标准方法</a></li>
                                            <li><a href="">《国家学生体质健康标准》测试的标准方法</a></li>
                                            <li><a href="">《国家学生体质健康标准》测试的标准方法</a></li>
                                            <li><a href="">《国家学生体质健康标准》测试的标准方法</a></li>
                                            <li><a href="">《国家学生体质健康标准》测试的标准方法</a></li>--%>
                                        <asp:Repeater runat="server" ID="physical_test">
                                            <ItemTemplate>
                                                <li><a href="newsDetails.aspx?newsType=<%# DataBinder.Eval(Container.DataItem, "id")%>">
                                                    <%# DataBinder.Eval(Container.DataItem, "title")%></a></li>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </ul>
                                </div>
                                <div class="cls_div">
                                    <ul class="hul3">
                                        <%--<li><a href="">关于09-10学生代表补测的通知</a></li>
                                            <li><a href="">关于09-10学生代表补测的通知</a></li>
                                            <li><a href="">李全华教授发表论文：事论信心在田径中的作用</a></li>
                                            <li><a href="">关于09-10学生代表补测的通知</a></li>
                                            <li><a href="">关于09-10学生代表补测的通知</a></li>
                                            <li><a href="">李全华教授发表论文：事论信心在田径中的作用</a></li>--%>
                                        <asp:Repeater runat="server" ID="test_inform">
                                            <ItemTemplate>
                                                <li><a href="newsDetails.aspx?newsType=<%# DataBinder.Eval(Container.DataItem, "id")%>">
                                                    <%# DataBinder.Eval(Container.DataItem, "title")%></a></li>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </ul>
                                </div>
                                <div class="cls_div">
                                    <ul class="hul3">
                                        <%--<li><a href="">关于09-10学生代表补测的通知</a></li>
                                            <li><a href="">关于09-10学生代表补测的通知</a></li>
                                            <li><a href="">李全华教授发表论文：事论信心在田径中的作用</a></li>
                                            <li><a href="">关于09-10学生代表补测的通知</a></li>
                                            <li><a href="">关于09-10学生代表补测的通知</a></li>
                                            <li><a href="">李全华教授发表论文：事论信心在田径中的作用</a></li>--%>
                                        <asp:Repeater runat="server" ID="exercise_book">
                                            <ItemTemplate>
                                                <li><a href="newsDetails.aspx?newsType=<%# DataBinder.Eval(Container.DataItem, "id")%>">
                                                    <%# DataBinder.Eval(Container.DataItem, "title")%></a></li>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                    <script type="text/javascript">
                        try {
                            document.execCommand("BackgroundImageCache", false, true);
                        } catch (e) { }
                        function $(element) {
                            if (arguments.length > 1) {
                                for (var i = 0, elements = [], length = arguments.length; i < length; i++)
                                    elements.push($(arguments[i]));
                                return elements;
                            }
                            if (typeof element == "string")
                                return document.getElementById(element);
                            else
                                return element;
                        }
                        var Class = {
                            create: function () {
                                return function () {
                                    this.initialize.apply(this, arguments);
                                }
                            }
                        }
                        Object.extend = function (destination, source) {
                            for (var property in source) {
                                destination[property] = source[property];
                            }
                            return destination;
                        }
                        var tabMenu = Class.create();
                        tabMenu.prototype = {
                            initialize: function (container, selfOpt, otherOpt) {
                                this.container = $(container);

                                var selfOptions = Object.extend({ fontWeight: "bold", fontSize: "12px", color: "#0671a4" }, selfOpt || {});
                                var otherOptions = Object.extend({ fontWeight: "normal", fontSize: "12px", color: "#0671a4" }, otherOpt || {});

                                for (var i = 0, length = this.container.childNodes.length, objs = []; i < length; i++) {
                                    if (this.container.childNodes[i].nodeType == 1)
                                        objs.push(this.container.childNodes[i]);
                                }
                                var tabArray = objs[0].getElementsByTagName("li");

                                var divArray = new Array();
                                for (i = 0, length = objs[1].childNodes.length; i < length; i++) {
                                    if (objs[1].childNodes[i].nodeType == 1)
                                        divArray.push(objs[1].childNodes[i]);
                                }

                                for (i = 0, length = tabArray.length; i < length; i++) {
                                    tabArray[i].length = length;
                                    tabArray[i].index = i;
                                    tabArray[i].onmouseover = function () {

                                        for (var j = 0; j < this.length; j++) {
                                            tabArray[j].style.backgroundPosition = "-" + tabArray[j].offsetWidth + "px 0";
                                            for (var property in selfOptions) {
                                                tabArray[j].firstChild.style[property] = otherOptions[property];
                                            }
                                        }

                                        this.style.backgroundPosition = "0 0";
                                        for (var property in selfOptions) {
                                            this.firstChild.style[property] = selfOptions[property];

                                        }

                                        for (j = 0; j < this.length; j++) {
                                            divArray[j].style.display = "none";
                                        }

                                        divArray[this.index].style["display"] = "block";
                                    }
                                }
                            }
                        }

                        var tab1 = new tabMenu("tab_container1", { fontSize: "13px", color: "#0671a4", fontWeight: "bold" }, { fontWeight: "normal", color: "#0671a4" });
                        var tab2 = new tabMenu("tab_container2");
                        var tab3 = new tabMenu("tab_container3", { textDecoration: "underline" }, { textDecoration: "none" });
                        var tab4 = new tabMenu("tab_container4", { fontWeight: "normal" });
                        var tab5 = new tabMenu("tab_container5");
                    </script>
                </div>
                <div class="sleft">
                    <%--<input type="text" style="width: 160px; height: 25px; color: #666; float: left; margin-right: 1px;" value="站内搜索" />
                        <input type="submit" style="width: 50px; height: 25px;margin-top:-10px; background-image: url(imgs/submit.jpg); border: 1px solid #ff3e02; color: #fff;" value="搜索" />--%>
                    <asp:TextBox runat="server" Width="160px" Height="23px" Text="" ID="txtSearch"></asp:TextBox>
                    <%--<asp:Button runat="server" Width="40" Height="25px" BackColor="#ff3300" Text="搜索" ID="btnSearch" OnClick="btnSearch_Click1" />--%>
                    <asp:ImageButton ID="ibtnSearch" runat="server" ImageUrl="~/imgs/sousuo.jpg" Width="42px"
                        Height="25px" CssClass="inbutton" ImageAlign="Middle" OnClick="ibtnSearch_Click" />
                    <div class="sleft1">
                       
                        <div class="box-content2"><h3>教师风采</h3>
              <span><a href="news.aspx?newsType=10">MORE>></a></span></div>
                        <div class="nr4">
                            
                            <div class="pic" style="height:145px;width:200px">
                                <%--<a href="">
                                        <img src="imgs/pic.jpg"></a>--%>
                                <a href="news.aspx?newsType=10">
                                    <img src="<%=PicList(0,"10") %>" alt="<%=PicContentList(0,"10") %>" style="height:140px;width:195px" />
                                    <%--<img src="UploadFiles/pic.jpg" alt="tupian" style="height:140px;width:195px" />--%>
                                    </a>
                            </div>
                            <p>
                                <%=PicContentList(0,"10") %><%--首届乒乓球邀请赛--%></p>
                        </div>
                    </div>
                    <div class="sleft2">
                       <div class="box-content2">     <h3>站内服务</h3>
              <span><a href="#">MORE>></a></span></div>
                        <div class="nr5">
                            
                            <table>
                                <tbody>
                                    <tr>
                                        <td>
                                            <a href="news.aspx?newsType=5">体质测试</a>
                                        </td>
                                        <td>
                                            <a href="http://59.67.225.73/te/">成绩查询</a>
                                        </td>
                                        <td>
                                            <a href="http://sports.cntv.cn/live/cctv5/index.shtml?f=mk1j&s=b">体育简报</a>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <a href="Login.aspx">管理系统</a>
                                        </td>
                                        <td>
                                            <a href="news.aspx?newsType=7">锻炼手册</a>
                                        </td>
                                        <td>
                                            <a href="news.aspx?newsType=6">测试通知</a>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <a href="policyDocument.aspx">政策文件</a>
                                        </td>
                                        <td>
                                            <a href="standardMethod.aspx">标准方法</a>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="bottom">
        <div class="sbottom">
            <p>
                版权所有：华北电力大学体育教学部</p>
            <p>
                技术支持：华北电力大学Dreamtech计算机工作室</p>
            <span><a href="Login.aspx">管理员登陆</a></span>
        </div>
    </div>
    </form>
</body>
</html>
