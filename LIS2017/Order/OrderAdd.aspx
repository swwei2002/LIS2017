<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderAdd.aspx.cs" Inherits="LIS2017.Order.OrderAdd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
                <script type="text/javascript">
		window.onload=function(){
		    changeSideBar("order", "order-add");
		}		
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

     <div id="main-content">

        <div class="content-box">
      <!-- Start Content Box -->
      <div class="content-box-header">
        <h3>标本管理</h3>

        <div class="clear"></div>
      </div>
      <!-- End .content-box-header -->
<div class="content-box-content">

        <div class="tab-content default-tab" id="tab1">

            <fieldset>
            <!-- Set class to "column-left" or "column-right" on fieldsets to divide the form into columns -->
       
            <p>
              <label>标本来源</label>
                <asp:DropDownList ID="ddlOrderFrom" runat="server" class="small-input">
                    
                </asp:DropDownList>

            </p>

            <p>
              <label>标本数量</label>
              <asp:TextBox ID="txtNumber" runat="server" class="text-input small-input" onkeyup="this.value=this.value.replace(/\D/g,'')" onafterpaste="this.value=this.value.replace(/\D/g,'')" MaxLength="3"></asp:TextBox>

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
