<%@ Page Title="" Language="C#" MasterPageFile="~/LoginMaster.Master" AutoEventWireup="true" CodeBehind="LoginDownloadManager.aspx.cs" Inherits="TheSportsWeb.LoginDownloadManager" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <table class="tb">
            <tr>
                <th>所属分类</th>
                <th>文件名称</th>
                <th>删除</th>
            </tr>
            <asp:Repeater ID="repInfos" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#suoshufenlei( Eval ("dId").ToString ()) %></td>
                        <td><%#Eval("dTitle") %></td>
                        <td>
                            <asp:LinkButton ID="lbtnDel" runat="server" CommandArgument='<%#Eval("dId") %>' OnClientClick="return confirm('确定要删除该条新闻吗？')" OnClick="lbtnDel_Click"> 删除</asp:LinkButton></td>
                    </tr>

                </ItemTemplate>
            </asp:Repeater>
        </table>
    </div>
    <div style="text-align: center; margin-top: 20px;">
        <asp:Button ID="Butbefore" runat="server" Text="上一页" Style="background: transparent; border: none; cursor: pointer;" OnClick="Butbefore_Click" />
        <asp:DropDownList ID="DDLnews" runat="server">
        </asp:DropDownList>
        <asp:Button ID="Button1" runat="server" Text="转到" OnClick="Button1_Click" Style="background: transparent; border: none; cursor: pointer;" />
        <asp:Button ID="Butafter" runat="server" Text="下一页" OnClick="Butafter_Click" Style="background: transparent; border: none; cursor: pointer;" />
    </div>
</asp:Content>
