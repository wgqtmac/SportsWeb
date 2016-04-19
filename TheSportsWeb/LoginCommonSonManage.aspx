﻿<%@ Page Title="" Language="C#" MasterPageFile="~/LoginMaster.Master" AutoEventWireup="true" CodeBehind="LoginCommonSonManage.aspx.cs" Inherits="TheSportsWeb.LoginVenueManage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <table class="tb">
            <tr>
                <th>所属分类</th>
                <th>二级标题</th>
                <th>修改</th>
                <th>删除</th>
            </tr>
            <asp:Repeater ID="repInfos" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#suoshufenlei( Eval ("id").ToString ()) %></td>
                        <td><%#Eval("title") %></td>
                        <td><a href='LoginCommonSonAlter.aspx?commonSonId=<%#Eval ("id") %>' target="_blank">修改</a></td>
                        <td>
                            <asp:LinkButton ID="lbtnDel" runat="server" CommandArgument='<%#Eval("id") %>' OnClientClick="return confirm('确定要删除该条新闻吗？')" OnClick="lbtnDel_Click"> 删除</asp:LinkButton></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
    </div>
    <div style="text-align: center; margin-top: 20px;">
        <asp:Button ID="Butbefore" runat="server" Text="上一页" Style="background: transparent; border: none; cursor: pointer;" OnClick="Butbefore_Click"/>
        <asp:DropDownList ID="DDLnews" runat="server">
        </asp:DropDownList>
        <asp:Button ID="Button1" runat="server" Text="转到" OnClick="Button1_Click" Style="background: transparent; border: none; cursor: pointer;" />
        <asp:Button ID="Butafter" runat="server" Text="下一页" OnClick="Butafter_Click" Style="background: transparent; border: none; cursor: pointer;" />
    </div>
</asp:Content>
