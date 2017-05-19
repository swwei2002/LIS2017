<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserPassword.aspx.cs" Inherits="LIS2017.Manage.UserPassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
        <script type="text/javascript">
		    window.onload=function(){
		        changeSideBar("system", "system-password");
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
                <asp:TextBox ID="txtUserName" runat="server" class="text-input small-input" ReadOnly="true"></asp:TextBox>
            </p>

            <p>
              <label>新密码</label>
              <asp:TextBox ID="txtPassword" runat="server" class="text-input small-input"></asp:TextBox>
            </p>

            <p>
              <label>确认新密码</label>
              <asp:TextBox ID="txtPasswordConfirm" runat="server" class="text-input small-input"></asp:TextBox>
            </p>

            <p>
            <asp:Button ID="btnSubmit" class="button" runat="server" Text="提交" OnClick="btnSubmit_Click" />
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
