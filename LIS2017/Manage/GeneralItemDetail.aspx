<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GeneralItemDetail.aspx.cs" Inherits="LIS2017.Manage.GeneralItemDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript">
		    window.onload=function(){
		        changeSideBar("admin", "admin-gitemlist");
		    }		
    </script>
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
                    <label style="color:blue">基本属性</label>
                </p>
              <p>
                  <label>项目代码</label>
                  <asp:TextBox ID="TextBoxItemCode" runat="server" class="text-input small-input"></asp:TextBox>
              </p>
              <p>
                  <label>项目类型</label>
                  <asp:DropDownList ID="DropDownListItemType" runat="server" class="small-input"></asp:DropDownList>

              </p>
            <p>
                  <label>检验类型</label>
                  <asp:DropDownList ID="DropDownListTestType" runat="server" class="small-input"></asp:DropDownList>

              </p>
                              <p>
                  <label>检验方法</label>
                                  <asp:DropDownList ID="DropDownListTestMethod" runat="server" class="small-input"></asp:DropDownList>
                              </p>
                                              <p>
                  <label>项目名称</label>
                  <asp:TextBox ID="TextBoxName" runat="server" class="text-input small-input"></asp:TextBox>
              </p>
                                              <p>
                  <label>项目简称</label>
                  <asp:TextBox ID="TextBoxShortName" runat="server" class="text-input small-input"></asp:TextBox>
              </p>
            <p>
                <asp:Button ID="ButtonSave" runat="server" Text="保存" class="button" OnClick="ButtonSave_Click"/>
            </p>
            </div>
        </div>
    </div>
</asp:Content>
