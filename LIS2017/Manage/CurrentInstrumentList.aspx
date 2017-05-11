<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CurrentInstrumentList.aspx.cs" Inherits="LIS2017.Manage.CurrentInstrumentList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
            <script type="text/javascript">
		window.onload=function(){
		    changeSideBar("admin", "admin-currinstrlist");
		}		
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
                <div id="main-content">
                    <div class="content-box-header">
                    <h3>检验仪器管理</h3>
                    <div class="clear"></div>
                </div>
                <div class="content-box-content">
                    <p>
                        <label style="display: inline">检验组</label>
                        <asp:DropDownList ID="DropDownListTestGroup" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownListTestGroup_SelectedIndexChanged"></asp:DropDownList>
                        <a href="CurrentInstrumentDetail.aspx?op=add" title="编辑" class="button">新增仪器</a>
                    </p>
                    <div>
                        <table>
                            <thead>
                                <tr>
                                    <th>仪器类型</th>
                                    <th>仪器名称</th>
                                    <th>检验种类</th>
                                    <th>有效性</th>
                                    <th>操作</th>
                                </tr>
                            </thead>
                            <tbody>
                                <asp:Repeater ID="RepeaterInstr" runat="server">
                                    <ItemTemplate>
                                        <tr>
                                            <td><%# Eval("TYPE")%></td>
                                            <td><%# Eval("NAME")%></td>
                                            <td><%# Eval("C_TEST_TYPE")%></td>
                                            <td><%# Eval("VALID_FLG").ToString() == "0" ? "有效" : "不使用"%></td>
                                            <td><a href="CurrentInstrumentDetail.aspx?instrumentID=<%# Eval("INSTRUMENT_ID")%>" title="编辑"><img src="/Resources/images/icons/pencil.png" alt="编辑" /></a></td>
                                        </tr>
                                        </tr>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
</asp:Content>
