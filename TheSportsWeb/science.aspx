<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="science.aspx.cs" Inherits="TheSportsWeb.science" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        .fdiv
        {
            width: 715px;
        }

            .fdiv h3
            {
                margin-left: 300px;
            }

        .nr
        {
            width: 100%;
            margin-top: 15px;
        }

            .nr p
            {
                text-indent: 2em;
                line-height: 180%;
                font-size: 14px;
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="fdiv">
                <h3>学术报告</h3>
                <div class="nr">
                    <p>
                        <%--版权所有：华北电力大学体育教学部.技术支持：华北电力大学Dreamtech计算机工作室,技术支持：华北电力大学Dreamtech计算机工作室,技术支持：华北电力大学Dreamtech计算机工作室--%>
                        <asp:Repeater runat="server" ID="content">
                                <ItemTemplate>
                                    <%# DataBinder.Eval(Container.DataItem, "content")%>
                                </ItemTemplate>
                            </asp:Repeater>
                    </p>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
