<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="venue.aspx.cs" Inherits="TheSportsWeb.venue" %>

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
        }

            .nr p {
                text-indent: 2em;
                line-height: 180%;
                font-size: 14px;
            }

            .nr img {
                clear: both;
                display: block;
                margin: 10px auto;
                max-width: 600px;
                max-height: 400px;
            }

            .nr span {
                margin: 20px auto;
                clear: both;
                display: block;
                text-align: center;
            }

                .nr span a {
                    text-decoration: none;
                    color: #000;
                }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="fdiv">
            <h3><asp:Label runat="server" ID="lblTitle"></asp:Label></h3>
            <div class="nr">
                
                <asp:Repeater runat="server" ID="venues">
                <ItemTemplate>
                    <%--<li><a href="inweb.aspx?commonType=<%# DataBinder.Eval(Container.DataItem, "id")%>" target="inweb">>><%# DataBinder.Eval(Container.DataItem, "title")%></a></li>--%>
                    <img src="<%# DataBinder.Eval(Container.DataItem, "pic_path")%>" />
                    <span><a href="venueDetails.aspx?venueType=<%=GetVenueType() %>" target="_top" >查看更多图片 >></a></span>
                </ItemTemplate>
            </asp:Repeater>
            </div>
            
        </div>
    </form>
</body>
</html>
