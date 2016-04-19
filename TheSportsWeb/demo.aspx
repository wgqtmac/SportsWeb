<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="demo.aspx.cs" Inherits="TheSportsWeb.demo" %>

<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script type="text/javascript" language="javascript" src="ckfinder/ckfinder.js"></script>
    <script type="text/javascript" language="javascript" src="ckeditor/ckeditor.js"></script>
    <script type="text/javascript">
        var editor = CKEDITOR.replace('post_content');          // 创建编辑器
        CKFinder.setupCKEditor(editor, '/PlugIns/ckfinder/');   // 为编辑器绑定"上传控件"
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <CKEditor:CKEditorControl runat="server" ID="ck1"></CKEditor:CKEditorControl>
    </form>
</body>
</html>
