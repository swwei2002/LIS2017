<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GeneralInstrumentList.aspx.cs" Inherits="LIS2017.Manage.GeneralInstrumentList" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
                <script type="text/javascript">
                    window.onload = function () {
                        changeSideBar("admin", "admin-instrlist");
                    }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
        <div id="main-content">
            <div class="content-box-header">
                <h3>仪器库管理</h3>
                <div class="clear"></div>
            </div>
            <div class="content-box-content">
                <p>
                    <label style="display: inline">仪器代码</label>
                    <asp:TextBox ID="TextBoxInstID" runat="server" class="text-input small-input"></asp:TextBox>
                    <asp:Button ID="ButtonQuery" runat="server" Text="查询" class="button" OnClick="ButtonQuery_Click" />
                    <a href="GeneralInstrumentDetail.aspx?op=add" title="编辑" class="button">新增仪器</a>
                </p>
                <div>
                    <table>
                        <thead>
                            <tr>
                                <th>仪器代码</th>
                                <th>厂家名称</th>
                                <th>仪器类型</th>
                                <th>仪器名称</th>
                                <th>操作</th>
                            </tr>
                            
                        </thead>
                        <tbody>
                            <asp:Repeater ID="RepeaterInstr" runat="server">
                            <ItemTemplate>
                            <tr>
                                <td><%# Eval("INSTR_ID")%></td>
                                <td><%# Eval("MAKER")%></td>
                                <td><%# Eval("TYPE")%></td>
                                <td><%# Eval("NAME")%></td>
                                <td>
                                    <a href="GeneralInstrumentDetail.aspx?type=<%# Eval("TYPE")%>" title="编辑"><img src="/Resources/images/icons/pencil.png" alt="编辑" /></a>
				                    <asp:ImageButton ID="ImageButtonDelete" runat="server" CommandArgument='<%# Eval("TYPE")%>' ImageUrl="/Resources/images/icons/cross.png"  OnClick="ImageButtonDelete_Click" OnClientClick="return confirm('确定删除？')" ToolTip="删除"/>
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
</asp:Content>
