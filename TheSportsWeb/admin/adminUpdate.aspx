<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminUpdate.aspx.cs" Inherits="TheSportsWeb.admin.adminUpdate" %>
<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="addnews">
            <div>
                栏目标题：<asp:TextBox ID="txtCommon" runat="server" Width="400px" ReadOnly="true"></asp:TextBox><br />
                <div>
                    内容编辑：
                </div>
                <div style="margin-top: 20px;">
                    <%--<CKEditor:CKEditorControl ID="updateCommonCKEdit" runat="server"></CKEditor:CKEditorControl>--%>
                    <FCKeditorV2:FCKeditor runat="server" ID="updateCommonFck"></FCKeditorV2:FCKeditor>
                </div>
                <asp:Button ID="btnSubmit" runat="server" Text="提交" OnClick="btnSubmit_Click" />
            </div>
        </div>
    </form>
</body>
</html>
