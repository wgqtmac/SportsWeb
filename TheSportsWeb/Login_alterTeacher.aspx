﻿<%@ Page Title="" Language="C#" MasterPageFile="~/LoginMaster.Master" AutoEventWireup="true" CodeBehind="Login_alterTeacher.aspx.cs" Inherits="TheSportsWeb.Login_alterTeacher" %>
<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main" style="height:1050px">
            <h3>修改教师信息</h3>
            <p>
                教师姓名：<asp:TextBox runat="server" ID="txtName"></asp:TextBox>
            </p>
            <p>党派：&nbsp;&nbsp;<asp:TextBox ID="txtParty" runat="server"></asp:TextBox></p>
             <p>职称：&nbsp;&nbsp;<asp:TextBox ID="txtTitle" runat="server"></asp:TextBox></p>
             <p>职位：&nbsp;&nbsp;<asp:TextBox ID="txtPost" runat="server"></asp:TextBox></p>
            <p>上传头像：&nbsp;&nbsp;<asp:FileUpload runat="server" ID="imgUpLoad"/></p>
            <p>
                <asp:Image ID="Image1" runat="server" Height="150px" Width="126px" />
            </p>
            <p>
                &nbsp;&nbsp;
                <asp:Button ID="btnUpLoad" runat="server" Text="上传图片" OnClick="btnUpLoad_Click" />
            &nbsp;&nbsp;&nbsp;<asp:Label ID="lblNote" runat="server" Text="Label"></asp:Label>
            </p>
            <p>
                个人具体信息：<fckeditorv2:fckeditor id="fckContent" runat="server" width="600px" height="400px"></fckeditorv2:fckeditor>
            </p>
            <p style="margin-left: 220px;">
                <asp:Button ID="btnAdd" runat="server" Text="修改教师信息" OnClick="btnAdd_Click"></asp:Button>
            </p>
        </div>
</asp:Content>
