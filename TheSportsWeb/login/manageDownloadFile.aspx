﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="manageDownloadFile.aspx.cs" Inherits="TheSportsWeb.login.manageDownloadFile" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
     <link href="../css/admin.css" rel="stylesheet" type="text/css" />
    
</head>
<body>
    <form id="form1" runat="server">
    <div class="m_box">
      <div class="m_head">后台管理信息</div>
     
      <div class="m_content">
          <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
              EnableModelValidation="True" Height="16px" Width="1177px" 
              DataKeyNames="dId" onrowdeleting="GridView1_RowDeleting"
              AllowPaging="True" CellPadding="4" ForeColor="Black" GridLines="Horizontal" 
              onpageindexchanging="GridView1_PageIndexChanging" 
              BackColor="White" onrowediting="GridView1_RowEditing"
              
              BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
              >
              <Columns>
                  
                  <asp:TemplateField HeaderText="所属类别">
                      <EditItemTemplate><asp:TextBox ID="TextBox1"  CssClass="tb" runat="server" Text='<%# Bind("dId") %>' ReadOnly="True" BorderStyle="None"></asp:TextBox></EditItemTemplate>
                      <ItemTemplate>
                          <asp:Label ID="Label1" runat="server" Text='<%#suoshufenlei( Eval ("dId").ToString ()) %>'></asp:Label>
                      </ItemTemplate>
                  </asp:TemplateField>
                  <asp:TemplateField HeaderText="文件名称">
                      <EditItemTemplate><asp:TextBox ID="TextBox2" CssClass="tb" runat="server" Text='<%# Bind("dTitle") %>'></asp:TextBox></EditItemTemplate>
                      <ItemTemplate>
                          <asp:Label ID="Label2" runat="server" Text='<%# Bind("dTitle") %>'></asp:Label>
                      </ItemTemplate>
                  </asp:TemplateField>
                  
                  <asp:TemplateField HeaderText="添加时间">
                      <EditItemTemplate><asp:TextBox ID="TextBox4" CssClass="tb" runat="server" Text='<%# Bind("createTime") %>'></asp:TextBox></EditItemTemplate>
                      <ItemTemplate>
                          <asp:Label ID="Label4" runat="server" Text='<%# Bind("createTime") %>'></asp:Label>
                      </ItemTemplate>
                  </asp:TemplateField>
                  <asp:TemplateField HeaderText="删除" ShowHeader="False">
                      <ItemTemplate>
                          <%--<asp:Button ID="Button1" runat="server" CausesValidation="False" 
                              CommandName="Edit" Text="编辑" />--%>
                              <asp:Button ID="Button2" runat="server" CausesValidation="False" 
                              CommandName="Delete" Text="删除" OnClientClick="return confirm('您确认删除该文件吗?')"/>
                              
                          
                      </ItemTemplate>
                      <%--<EditItemTemplate><asp:Button ID="Button1" runat="server" CausesValidation="True" 
                              CommandName="Update" Text="更新" />
                          &nbsp;<asp:Button ID="Button2" runat="server" CausesValidation="False" 
                              CommandName="Cancel" Text="取消" /></EditItemTemplate>--%>
                  </asp:TemplateField>
              </Columns>
              <RowStyle HorizontalAlign="Center" /> 
              <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
              <HeaderStyle BackColor="#3a9cff" Font-Bold="True" ForeColor="White" />
              <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
              <RowStyle HorizontalAlign="Center" />
              <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
          </asp:GridView>
        </div>
          
    </div>
    </form>
</body>
</html>
