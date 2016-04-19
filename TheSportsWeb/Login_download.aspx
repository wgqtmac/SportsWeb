<%@ Page Title="" Language="C#" MasterPageFile="~/LoginMaster.Master" AutoEventWireup="true" CodeBehind="Login_download.aspx.cs" Inherits="TheSportsWeb.Login_download" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
            <asp:Button ID="btnAdd" runat="server" Text="上传文件" OnClick="btnAdd_Click" />
        </p>
    </div>
</asp:Content>
