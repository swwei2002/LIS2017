<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserAdd.aspx.cs" Inherits="LIS2017.Manage.UserAdd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">

    <script type="text/javascript">
		window.onload=function(){
		    changeSideBar("system", "system-totaluser");
		}		
    </script>

</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div id="main-content">

        <div class="content-box">
      <!-- Start Content Box -->
      <div class="content-box-header">
        <h3>用户管理</h3>

        <div class="clear"></div>
      </div>
      <!-- End .content-box-header -->
<div class="content-box-content">
        <div class="tab-content default-tab" id="tab1">

            <fieldset>
            <!-- Set class to "column-left" or "column-right" on fieldsets to divide the form into columns -->
            <p>
              <label>用户名</label>
              <asp:TextBox ID="txtUserName" runat="server" class="text-input small-input"></asp:TextBox>
            </p>

            <p>
              <label>密码</label>
              <asp:TextBox ID="txtPassword" runat="server" class="text-input small-input"></asp:TextBox>
            </p>

           <p>
              <label>真名</label>
             <asp:TextBox ID="txtRealName" runat="server" class="text-input small-input"></asp:TextBox>
            </p>

            <p>
              <label>科室</label>
                <asp:DropDownList ID="ddlDepartment" runat="server" class="small-input">

                </asp:DropDownList>

            </p>

            <!-- 0=超级管理员 1=普通用户 2=管理员 -->
            <p>
                
              <label>权限</label>

            <asp:CheckBoxList ID="cblAccess" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem Text="普通用户" Value="1"  Selected="True"></asp:ListItem>
                <asp:ListItem Text="管理员" Value="2"></asp:ListItem>
                <asp:ListItem Text="超级管理员" Value="0"></asp:ListItem>
            </asp:CheckBoxList>



            </p>


            <p>
              <label>状态</label>

                <asp:RadioButtonList ID="rblDisable" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Text="启用" Value="0" Selected="True"></asp:ListItem>
                    <asp:ListItem Text="禁用" Value="1" ></asp:ListItem>
                </asp:RadioButtonList>
 </p>

            <p>
              <input class="button" type="submit" value="提交" />
            </p>
            </fieldset>
            <div class="clear"></div>
            <!-- End .clear -->

        </div>
        <!-- End #tab2 -->
</div>
    </div>

</div>
</asp:Content>
