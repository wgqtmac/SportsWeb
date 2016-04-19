<%@ Page Title="" Language="C#" MasterPageFile="~/LoginMaster.Master" AutoEventWireup="true" CodeBehind="LoginVideoManager.aspx.cs" Inherits="TheSportsWeb.LoginVideoManager" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div>
            <table class="tb">
                <tr>
                    <th>视频标题</th>
                    <th>删除</th>
                </tr>
                <asp:Repeater ID="repInfos" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%#Eval("vTitle") %></td>
                            <td>
                                <asp:LinkButton ID="lbtnDel" runat="server" CommandArgument='<%#Eval("vId") %>' OnClientClick="return confirm('确定要删除该条视频吗？')" OnClick="lbtnDel_Click"> 删除</asp:LinkButton>
                            </td>
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
