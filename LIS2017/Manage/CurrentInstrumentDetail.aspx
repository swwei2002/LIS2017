<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CurrentInstrumentDetail.aspx.cs" Inherits="LIS2017.Manage.CurrentInstrumentDetail" EnableEventValidation="false" %>

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
            <div style="float:left;width:40%">
                <p>
                <label style="color:blue">仪器属性</label>
                </p>
                <p>
                    <label style="display:inline">仪器类型</label>
                    <asp:DropDownList ID="DropDownListType" runat="server" class="text-input medium-input"></asp:DropDownList>
                </p>
                <p>
                    <label style="display:inline">检验小组</label>
                    <asp:DropDownList ID="DropDownListGroupID" runat="server" class="text-input medium-input"></asp:DropDownList>
                </p>
                <p>
                    <label style="display:inline">仪器名称</label>
                    <asp:TextBox ID="TextBoxName" runat="server" class="text-input medium-input"></asp:TextBox>
                </p>
                <p>
                    <label style="display:inline">检验种类</label>
                    <asp:DropDownList ID="DropDownListTestType" runat="server" class="text-input medium-input"></asp:DropDownList>
                </p>
                <p>
                    <label style="display:inline">有效标志</label>
                    <asp:DropDownList ID="DropDownListValidFlg" runat="server"></asp:DropDownList>
                </p>
                <p>
                    <label style="display:inline">使用试剂</label>
                    <asp:TextBox ID="TextBoxRegment" runat="server" class="text-input medium-input"></asp:TextBox>
                </p>
             <p>
                <asp:Button ID="ButtonSave" runat="server" Text="保存" class="button" OnClick="ButtonSave_Click"/>
            </p>
            <div style="height:500px;overflow:auto"><asp:TreeView runat="server" ID="TreeViewItemList" ShowCheckBoxes="Leaf" ExpandDepth="0" style="width:20% !important;background-color:rebeccapurple !important;"></asp:TreeView></div>
            <div><asp:Button ID="ButtonAddItem" runat="server" Text="添加项目" CssClass="button" OnClick="ButtonAddItem_Click" /></div>
               
          </div>

            <div style="width:55%;float:right;overflow:auto;height:800px;">
                <p>
                <label style="color:blue">仪器项目</label>
                </p>
                <table>
                    <thead>
                        <tr>
                            <th>项目代码</th>
                            <th>项目名称</th>
                            <th>项目简称</th>
                            <th>通道号</th>
                            <th>操作</th>
                        </tr>

                    </thead>
                    <tbody>
                        <asp:Repeater ID="RepeaterItem" runat="server">
                            <ItemTemplate>
                                <tr>
                                    <td><%# Eval("ITEM_CODE") %></td>
                                    <td><%# Eval("NAME") %></td>
                                    <td><%# Eval("SHORTNAME") %></td>
                                    <td><%# Eval("CHANNEL_NO") %></td>
                                    <td><asp:ImageButton ID="ImageButtonDelete" runat="server" CommandArgument='<%# Eval("ITEM_CODE") %>' ImageUrl="/Resources/images/icons/cross.png"  OnClick="ImageButtonDelete_Click" OnClientClick="return confirm('确定删除？')" ToolTip="删除"/></td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </tbody>
                </table>
            </div>
            <div class="clear"></div>
             <div class="clear"></div>   
        </div>

    </div>
          
</asp:Content>
