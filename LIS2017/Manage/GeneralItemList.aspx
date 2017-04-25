<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GeneralItemList.aspx.cs" Inherits="LIS2017.Manage.GeneralItemList" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>


<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="main-content">
        <div class="content-box">
            <div class="content-box-header">
                <h3>项目库管理</h3>
                <div class="clear"></div>
            </div>
            <div class="content-box-content">
                <p>
                    <label style="display: inline">检验类型</label>
                    <asp:DropDownList ID="DropDownListType" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownListType_SelectedIndexChanged"></asp:DropDownList>
                    <a href="GeneralItemDetail.aspx?op=add" title="编辑" class="button">新增项目</a>
                </p>
                <div>
                    <table>
                        <thead>
                            <tr>
                                <th>项目代码</th>
                                <th>项目名称</th>
                                <th>项目简称</th>
                                <th>操作</th>
                            </tr>
                        </thead>
                        <tbody>
                        <asp:Repeater ID="RepeaterItem" runat="server">
                            <ItemTemplate>
                            <tr>
                                <td><%# Eval("ITEM_CODE")%></td>
                                <td><%# Eval("NAME")%></td>
                                <td><%# Eval("SHORTNAME")%></td>
                                <td>
                                    <a href="GeneralItemDetail.aspx?item_code=<%# Eval("ITEM_CODE")%>" title="编辑"><img src="/Resources/images/icons/pencil.png" alt="编辑" /></a>
				                    <asp:ImageButton ID="ImageButtonDelete" runat="server" CommandArgument='<%# Eval("ITEM_CODE")%>' ImageUrl="/Resources/images/icons/cross.png" OnClick="ImageButtonDelete_Click"  OnClientClick="return confirm('确定删除？')" ToolTip="删除"/>
			                    </td>
                            </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                        </tbody>

                    </table>
                        <div class="pagination">
                            <webdiyer:aspnetpager ID="AspNetPager1" runat="server" AlwaysShow="True" OnPageChanged="AspNetPager1_PageChanged" ShowCustomInfoSection="Left"></webdiyer:aspnetpager>
                        </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
