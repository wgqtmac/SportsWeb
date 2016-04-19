<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addDownloadFile.aspx.cs" Inherits="TheSportsWeb.login.addDownloadFile" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../css/manager.css" rel="stylesheet" />
    
</head>
<body>
    <form id="form1" runat="server">
    <div class="main" style="height:300px">
        <h3>上传文件</h3>
        <p>&nbsp;</p>
        <p>
            文件名称：<asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
        </p>
        <p>
            所属类别：<asp:DropDownList ID="comonSonDDL" runat="server"></asp:DropDownList>
        </p>
        <p>
            文件地址：<asp:FileUpload ID="fileDownload" runat="server" />
        </p>
        <p>
            &nbsp;</p>
        <p style="margin-left: 220px;">
            <asp:Button ID="btnAdd" runat="server" Text="上传文件" OnClick="btnAdd_Click" 
                style="height: 21px" />
        </p>
    </div>
    </form>
</body>
</html>
