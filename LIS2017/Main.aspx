<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="LIS2017.Main" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript">
		window.onload=function(){
		    changeSideBar("home");
		}		
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div id="main-content">

    <block name="head">
	<!-- Page Head -->
    <h2>Welcome XXX</h2>
    <p id="page-intro">How do you do ?</p>
    
    <!-- End .shortcut-buttons-set -->
    <div class="clear"></div>
    <!-- End .clear -->	
	</block>

	<block name="notification">
    <!-- Start Notifications -->
    <div class="notification attention png_bg"> <a href="#" class="close"><img src="/Resources/images/icons/cross_grey_small.png" title="Close this notification" alt="close" /></a>
      <div> <a href="#">您有X条标本待核收，请点击核收。 </a></div>
    </div>
    <div class="notification information png_bg"> <a href="#" class="close"><img src="/Resources/images/icons/cross_grey_small.png" title="Close this notification" alt="close" /></a>
      <div> <a href="#">您有X条标本检验未完成，请点击录入。</a> </div>
    </div>
    
    <!-- End Notifications -->
	</block>


    </div>

</asp:Content>
