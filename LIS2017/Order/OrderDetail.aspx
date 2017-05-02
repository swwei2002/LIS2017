<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderDetail.aspx.cs" Inherits="LIS2017.Order.OrderDetail" %>
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
              <label>标本号</label>
              <asp:TextBox ID="txtCode" runat="server" class="text-input small-input" ReadOnly="true"></asp:TextBox>
                   <br />
              <small>标本号不允许修改</small>
            </p>


            <p>
              <label>标本来源</label>
                <asp:DropDownList ID="ddlOrderFrom" runat="server" class="small-input">
                    
                </asp:DropDownList>

            </p>

            <p>
              <label>标本类别</label>
              
                                <asp:DropDownList ID="ddlSampleType" runat="server" class="small-input">
                    
                </asp:DropDownList>
            </p>

            <p>
              <label>标本状态</label>
              
                                <asp:DropDownList ID="ddlDisease" runat="server" class="small-input">
                    
                </asp:DropDownList>
            </p>

            <p>
              <label>姓名</label>
              <asp:TextBox ID="txtName" runat="server" class="text-input small-input" ></asp:TextBox>
            </p>

              <p>
              <label>性别</label>
                <asp:DropDownList ID="ddlGender" runat="server" class="small-input">
                    
                </asp:DropDownList>

            </p>

            <p>
              <label>年龄</label>
              <asp:TextBox ID="txtAge" runat="server" class="text-input small-input" ></asp:TextBox>
            </p>
    

            <p>
              <label>身份证号码</label>
              <asp:TextBox ID="txtCardId" runat="server" class="text-input small-input" ></asp:TextBox>
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
