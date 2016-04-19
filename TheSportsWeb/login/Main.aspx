<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="TheSportsWeb.login.Main" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="../css/Common.css" rel="stylesheet" type="text/css" />
     <link href="../css/admin.css" rel="stylesheet" type="text/css" />
<style type="text/css">
#top{height:25px;width:1348px;margin:0px auto;background-color:#ebf3ff;line-height:25px;}
.top-left{width:15px;float:left;}
.top-left img{padding-top:5px;}
.top-center{width:300px;float:left;}
.top-right{width:1020px;float:left;text-align:right;}
#bottom{margin:0px auto;height:79px;}
.footer{width:1348px;margin:0px auto;height:50px;margin-top:10px;text-align:center;}  
.middle{width:1348px;margin:0px auto;height:600px;background:url(../image/bc_1.gif) no-repeat;}
.middle_left{width:150px;height:500px;float:left;margin-top:53px;}

.middle_right{width:1185px;height:540px;float:left;margin-top:53px;border:1px solid #90b8ed;background:white;}

#iframe{height:530px;width:1185px;background:white;}
.middle_head{height:30px;width:1000px;margin:0px auto;}
#select{width:1348px;margin:0px auto;height:40px;}
#select_left{width:300px;height:22px;float:left;margin-top:15px;}
#select_right{width:80px;height:20px;float:right;margin-top:21px;margin-right:8px;}
</style>
</head>
<body>
    <form id="form1" runat="server">
     <div id="top">
       <div class="top-left"><a  href="../index.aspx"><img src="../image/home1.gif"  alt=""/></a></div>
       <div class="top-center">后台管理系统</div>
       <div class="top-right">
       欢迎,<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label><img src="../image/whitearrow.gif" alt="" />|
          <span id="localtime"></span>
      <script type="text/javascript">
          function showLocale(objD) {
              var str, colorhead, colorfoot;
              var yy = objD.getYear();
              if (yy < 1900) yy = yy + 1900;
              var MM = objD.getMonth() + 1;
              if (MM < 10) MM = '0' + MM;
              var dd = objD.getDate();
              if (dd < 10) dd = '0' + dd;
              var hh = objD.getHours();
              if (hh < 10) hh = '0' + hh;
              var mm = objD.getMinutes();
              if (mm < 10) mm = '0' + mm;
              var ss = objD.getSeconds();
              if (ss < 10) ss = '0' + ss;
              var ww = objD.getDay();
              if (ww == 0) colorhead = "<font color=\"#FF0000\">";
              if (ww > 0 && ww < 6) colorhead = "<font color=\"#aeaeae\">";
              if (ww == 6) colorhead = "<font color=\"#008000\">";
              if (ww == 0) ww = "星期日";
              if (ww == 1) ww = "星期一";
              if (ww == 2) ww = "星期二";
              if (ww == 3) ww = "星期三";
              if (ww == 4) ww = "星期四";
              if (ww == 5) ww = "星期五";
              if (ww == 6) ww = "星期六";
              colorfoot = "</font>"
              str = colorhead + yy + "-" + MM + "-" + dd + " " + hh + ":" + mm + ":" + ss + "  " + ww + colorfoot;
              return (str);
          }
          function tick() {
              var today;
              today = new Date();
              document.getElementById("localtime").innerHTML = showLocale(today);
              window.setTimeout("tick()", 1000);
          }
          tick();
</script>
       </div>
     </div>   
    <div class="clear"></div>
    <div id="select">
      <div id="select_left"><img src="../image/titlegraphic.gif" /><span style="font-size:16px;color:#17aaaa;font-weight:bold;">管理员 </span></div>
      <div id="select_right"><a href="../Login.aspx"><img src="../image/hou.gif" /></a></div>
    </div>
    <div class="clear"></div>
    <div class="middle">
      <div class="middle_left">
       <ul id="nav">
          <li><a href="#Menu=ChildMenu1"  onclick="DoMenu('ChildMenu1')">新闻管理</a>
            <ul id="ChildMenu1" >
             <li><a href="addNews.aspx" target="mainFrame">添加新闻</a></li>
             <li><a href="manageNews.aspx" target="mainFrame">管理新闻</a></li>       
            </ul>
          </li>
        <li><a href="#Menu=ChildMenu2" onclick="DoMenu('ChildMenu2')">一级栏目管理</a>
          <ul id="ChildMenu2">
            <li><a href="manageCommon.aspx" target="mainFrame">栏目管理</a></li>                  
           </ul>
       </li>
       <li><a href="#Menu=ChildMenu3" onclick="DoMenu('ChildMenu3')">二级栏目管理</a>
          <ul id="ChildMenu3" class="collapsed">
            <li><a href="addCommonSon.aspx" target="mainFrame">添加二级栏目</a></li>
            <li><a href="manageCommonSon.aspx"  target="mainFrame">二级栏目管理</a></li>       
           </ul>
       </li>
       <li><a href="#Menu=ChildMenu4" onclick="DoMenu('ChildMenu4')">文件管理</a>
          <ul id="ChildMenu4" class="collapsed">
            <li><a href="addDownloadFile.aspx" target="mainFrame">上传文件</a></li>
            <li><a href="manageDownloadFile.aspx"  target="mainFrame">文件管理</a></li>       
           </ul>
       </li>
       <li><a href="#Menu=ChildMenu5" onclick="DoMenu('ChildMenu5')">视频管理</a>
          <ul id="ChildMenu5" class="collapsed">
            <li><a href="addVideo.aspx" target="mainFrame">上传视频</a></li>
            <li><a href="manageVideo.aspx"  target="mainFrame">视频管理</a></li>       
           </ul>
       </li>
       <li><a href="#Menu=ChildMenu6" onclick="DoMenu('ChildMenu6')">教师管理</a>
          <ul id="ChildMenu6" class="collapsed">
            <li><a href="addTeacher.aspx" target="mainFrame">添加教师</a></li>
            <li><a href="manageTeacher.aspx"  target="mainFrame">教师管理</a></li>       
           </ul>
       </li>
       
       
      </ul>
     </div>
    <div class="middle_right">
        <iframe id="iframe" name="mainFrame" frameborder="0" 
            class="style1" scrolling="auto" src=""
            allowTransparency="true"></iframe>
    </div>
   </div>
    <div class="clear"></div>
    <div id="bottom">
      <div class="footer"><p style="font-size:12px;color:#575757"> Copyright @2015 版权所有</p></div>
    </div>
</form>
<script type="text/javascript"><!--
    var LastLeftID = "";
    function menuFix() {
        var obj = document.getElementById("nav").getElementsByTagName("li");

        for (var i = 0; i < obj.length; i++) {
            obj[i].onmouseover = function () {
                this.className += (this.className.length > 0 ? " " : "") + "sfhover";
            }
            obj[i].onMouseDown = function () {
                this.className += (this.className.length > 0 ? " " : "") + "sfhover";
            }
            obj[i].onMouseUp = function () {
                this.className += (this.className.length > 0 ? " " : "") + "sfhover";
            }
            obj[i].onmouseout = function () {
                this.className = this.className.replace(new RegExp("( ?|^)sfhover\\b"), "");
            }
        }
    }
    function DoMenu(emid) {
        var obj = document.getElementById(emid);
        obj.className = (obj.className.toLowerCase() == "expanded" ? "collapsed" : "expanded");
        if ((LastLeftID != "") && (emid != LastLeftID)) //关闭上一个Menu
        {
            document.getElementById(LastLeftID).className = "collapsed";
        }
        LastLeftID = emid;
    }
    function GetMenuID() {
        var MenuID = "";
        var _paramStr = new String(window.location.href);
        var _sharpPos = _paramStr.indexOf("#");

        if (_sharpPos >= 0 && _sharpPos < _paramStr.length - 1) {
            _paramStr = _paramStr.substring(_sharpPos + 1, _paramStr.length);
        }
        else {
            _paramStr = "";
        }

        if (_paramStr.length > 0) {
            var _paramArr = _paramStr.split("&");
            if (_paramArr.length > 0) {
                var _paramKeyVal = _paramArr[0].split("=");
                if (_paramKeyVal.length > 0) {
                    MenuID = _paramKeyVal[1];
                }
            }
            /*
            if (_paramArr.length>0)
            {
            var _arr = new Array(_paramArr.length);
            }
  
            //取所有#后面的，菜单只需用到Menu
            //for (var i = 0; i < _paramArr.length; i++)
            {
            var _paramKeyVal = _paramArr[i].split('=');
   
            if (_paramKeyVal.length>0)
            {
            _arr[_paramKeyVal[0]] = _paramKeyVal[1];
            }  
            }
            */
        }

        if (MenuID != "") {
            DoMenu(MenuID)
        }
    }
    GetMenuID(); //*这两个function的顺序要注意一下，不然在Firefox里GetMenuID()不起效果
    menuFix();
--></script>
</body>
</html>
