<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LIS2017.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>SCCL LIS</title>

<!-- Reset Stylesheet -->
<link rel="stylesheet" href="/Resources/css/reset.css" type="text/css" media="screen" />
<!-- Main Stylesheet -->
<link rel="stylesheet" href="/Resources/css/style.css" type="text/css" media="screen" />
<!-- Invalid Stylesheet. This makes stuff look pretty. Remove it if you want the CSS completely valid -->
<link rel="stylesheet" href="/Resources/css/invalid.css" type="text/css" media="screen" />


<!-- jQuery -->
<script type="text/javascript" src="/Resources/scripts/jquery-1.3.2.min.js"></script>
<!-- jQuery Configuration -->
<script type="text/javascript" src="/Resources/scripts/simpla.jquery.configuration.js"></script>
<!-- Facebox jQuery Plugin -->
<script type="text/javascript" src="/Resources/scripts/facebox.js"></script>

<script type="text/javascript" src="/Resources/scripts/common.js"></script>
</head>
<body id="login">
    <form runat="server">
<div id="login-wrapper" class="png_bg">
  <div id="login-top">
    <h1>SCCL OA</h1>
    <!-- Logo (221px width) -->
    <a href="#"><img id="logo" src="/Resources/images/logo.png" alt="Simpla Admin logo" /></a> 
   
	<!--<a href="#"><img id="logo" src="__STORAGE__/Index/images/loginlogo.png" alt="SCCL logo" /></a>-->
	</div>
  <!-- End #logn-top -->
  <div id="login-content">
    
      <div class="notification information png_bg">
        <div>请输入您的用户名密码<br />如忘记密码请联系信息科</div>
      </div>
      <p>
        <label>用户名</label>
        <asp:TextBox ID="txtUserName" runat="server" class="text-input"></asp:TextBox>
      </p>
      <div class="clear"></div>
      <p>
        <label>密码</label>
          <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" class="text-input"></asp:TextBox>

      </p>
      <div class="clear"></div>

	  <!--
      <p id="remember-password">
        <input type="checkbox" />
        记住帐号</p>
      <div class="clear"></div>
      -->
      <p>
          <asp:Button ID="btnLogin" runat="server" class="button" Text="登录" OnClick="btnLogin_Click" />
      </p>
    
  </div>
  <!-- End #login-content -->
</div>
<!-- End #login-wrapper -->
</form>
</body>
</html>
