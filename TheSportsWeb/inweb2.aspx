<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inweb2.aspx.cs" Inherits="TheSportsWeb.inweb3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        .fdiv {
            width: 715px;
        }

            .fdiv h3 {
                margin-left: 300px;
            }

        .nr {
            width: 100%;
            margin-top: 15px;
            padding-bottom: 40px;
        }

            .nr p {
                text-indent: 2em;
                line-height: 180%;
                font-size: 14px;
            }

        .new-ul {
            padding-left: 5px;
        }

            .new-ul li {
                list-style-image: url(../imgs/list-blue.png);
                list-style-position: inside;
                margin-top: 5px;
            }

                .new-ul li a {
                    font-size: 15px;
                    color: #333;
                    text-decoration: none;
                }

                    .new-ul li a:hover {
                        color: #0085e5;
                    }

                .new-ul li span {
                    margin-left: 20px;
                    color: #666;
                    font-size: 14px;
                }

        .bt-list {
            padding-bottom: 50px;
        }

            .bt-list p {
                float: left;
                margin-left: 30px;
                font-size: 16px;
                font-weight: bold;
                color: #000;
            }

        .bt {
            width: 350px;
            height: 25px;
            margin: 10px auto;
        }

            .bt a {
                float: left;
                margin-left: 50px;
                font-size: 18px;
            }

                .bt a:hover {
                    color: #0396cc;
                }

            .bt p {
                font-size: 18px;
                margin-right: 20px;
                float: right;
            }

                .bt p span {
                    color: #0396cc;
                }

            /*.bt input {
                float: right;
                padding: 0 5px;
                font-size: 14px;
                margin-top: 15px;
                margin-right: 5px;
                background-color: #fff;
                border: 2px solid #999;
            }

                .bt input:hover {
                    background-color: #f9b900;
                    color: #fff;
                    border: 2px solid #fb7f05;
                }*/
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="fdiv">
            <h3>资料下载</h3>
            <div class="nr">
                <ul class="new-ul">
                    <%--<li><a href="">我校足球队痛失小组赛出线机会</a><span>doc 规章制度</span></li>
                    <li><a href="">最美不过兄弟情，我校足球队再战贵州校足球队</a><span>doc 规章制度</span></li>
                    <li><a href="">我校足球队痛失小组赛出线机会</a><span>doc 规章制度</span></li>
                    <li><a href="">最美不过兄弟情，我校足球队再战贵州校足球队</a><span>doc 规章制度</span></li>
                    <li><a href="">足球夺冠传递卓越精神——记勇首夺中国大学生足球联赛北区冠军的校足球队</a><span>doc 规章制度</span></li>
                    <li><a href="">我校足球队痛失小组赛出线机会</a><span>doc 规章制度</span></li>
                    <li><a href="">最美不过兄弟情，我校足球队再战贵州校足球队</a><span>doc 规章制度</span></li>
                    <li><a href="">我校足球队痛失小组赛出线机会</a><span>doc 规章制度</span></li>
                    <li><a href="">最美不过兄弟情，我校足球队再战贵州校足球队</a><span>doc 规章制度</span></li>
                    <li><a href="">足球夺冠传递卓越精神——记勇首夺中国大学生足球联赛北区冠军的校足球队</a><span>doc 规章制度</span></li>
                    <li><a href="">我校足球队痛失小组赛出线机会</a><span>doc 规章制度</span></li>
                    <li><a href="">最美不过兄弟情，我校足球队再战贵州校足球队</a><span>doc 规章制度</span></li>
                    <li><a href="">我校足球队痛失小组赛出线机会</a><span>doc 规章制度</span></li>
                    <li><a href="">我校足球队痛失小组赛出线机会</a><span>doc 规章制度</span></li>
                    <li><a href="">最美不过兄弟情，我校足球队再战贵州校足球队</a><span>doc 规章制度</span></li>--%>
                    <asp:Repeater ID="downList" runat="server">
                        <ItemTemplate>
                            <li><a href="<%# DataBinder.Eval(Container.DataItem, "down_path")%>"><%# DataBinder.Eval(Container.DataItem, "dTitle")%></a>   <span>doc <%# DataBinder.Eval(Container.DataItem, "title")%></span></li>
                        </ItemTemplate>
                    </asp:Repeater>
                </ul>
            </div>
            <p>&nbsp;</p>
            <p>&nbsp;</p>
            <p>&nbsp;</p>
            <p>&nbsp;</p>
            <p>&nbsp;</p>
            <p>&nbsp;</p>
            <p>&nbsp;</p>
            <p>&nbsp;</p>
            <p>&nbsp;</p>
            <div class="bt-list">
                <%--<p>共<span>40</span>条/共<span>2</span>页</p>
                <p>第<span>1</span>页</p>--%>
                <div class="bt">
                    <asp:Button ID="previousBtn" Text="上页" runat="server" OnClick="previousBtn_Click" />
                    <asp:DropDownList ID="DDLnews" runat="server">
                    </asp:DropDownList>
                    <asp:Button ID="goBtn" runat="server" Text="转到" OnClick="goBtn_Click" />
                    <asp:Button ID="nextBtn" Text="下页" runat="server" OnClick="nextBtn_Click" />
                
                </div>
            </div>
        </div>
    </form>
</body>
</html>
