<%@ Page Title="" Language="C#" MasterPageFile="~/LoginMaster.Master" AutoEventWireup="true" CodeBehind="Login_addVenue.aspx.cs" Inherits="TheSportsWeb.Login_addVenue" %>
<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main">
            <h3>添加场地信息</h3>
            <p>
                场地名称：<asp:TextBox runat="server" ID="txtName"></asp:TextBox>
            </p>
            <p>
                场地类别:<asp:DropDownList ID="ddlVenue" runat="server"></asp:DropDownList>
            </p>
            <p>上传图片：&nbsp;&nbsp;<asp:FileUpload runat="server" ID="imgUpLoad"/></p>
            <p>
                <asp:Image ID="Image1" runat="server" Height="150px" Width="126px" />
            </p>
            <p>
                &nbsp;&nbsp;
                <asp:Button ID="btnUpLoad" runat="server" Text="上传图片" OnClick="btnUpLoad_Click" />
            &nbsp;&nbsp;&nbsp;<asp:Label ID="lblNote" runat="server" Text="Label"></asp:Label>
            </p>
            <p>
                场地内容：<fckeditorv2:fckeditor id="fckContent" runat="server" width="600px" ></fckeditorv2:fckeditor>
            </p>
            <p style="margin-left: 220px;">
                <asp:Button ID="btnAdd" runat="server" Text="添加场地" OnClick="btnAdd_Click"></asp:Button>
            </p>
        </div>
</asp:Content>
