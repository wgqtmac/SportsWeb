<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="imginweb.aspx.cs" Inherits="TheSportsWeb.imginweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style>
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

            .nr img
            {
                clear: both;
                display: block;
                margin: 10px auto;
                max-width: 600px;
                max-height: 400px;
            }

            .nr span
            {
                margin: 20px auto;
                clear: both;
                display: block;
                text-align: center;
            }

                .nr span a
                {
                    text-decoration: none;
                    color: #000;
                }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div class="fdiv">
            <h3>室内图片</h3>
            <div class="nr">
                <img src="imgs/photo2.jpg">
                <span><a href="">查看更多图片 >></a></span>
            </div>
        </div>

    </form>
</body>
</html>
