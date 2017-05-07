<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderSearch.aspx.cs" Inherits="LIS2017.Order.OrderSearch" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
                <script type="text/javascript">
		window.onload=function(){
		    changeSideBar("order", "order-search");
		}		
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
       
     <div id="main-content">

        <div class="content-box">
      <!-- Start Content Box -->
      <div class="content-box-header">
        <h3>标本搜索</h3>

        <div class="clear"></div>
      </div>
      <!-- End .content-box-header -->
<div class="content-box-content">

        <div class="tab-content default-tab" id="tab1">

            <fieldset>
            <!-- Set class to "column-left" or "column-right" on fieldsets to divide the form into columns -->
            
              <p>
              <label>标本号</label>
              <asp:TextBox ID="txtCode" runat="server" class="text-input small-input"></asp:TextBox>
            </p>

<!--
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
              <label>性别</label>
                <asp:DropDownList ID="ddlGender" runat="server" class="small-input">
                    
                </asp:DropDownList>

            </p>

    -->

            <p>
              <label>姓名</label>
              <asp:TextBox ID="txtName" runat="server" class="text-input small-input" ></asp:TextBox>
            </p>



            <p>
              <label>年龄</label>
              <asp:TextBox ID="txtAge" runat="server" class="text-input small-input" ></asp:TextBox>
            </p>
    

            <p>
              <label>保单号</label>
              <asp:TextBox ID="txtCardId" runat="server" class="text-input small-input" ></asp:TextBox>
            </p>
            <p>
              <asp:Button ID="btnSubmit" class="button" runat="server" Text="搜索" OnClick="btnSubmit_Click" />
            </p>
            </fieldset>
            <div class="clear"></div>

            <!-- End .clear -->

        </div>
        <!-- End #tab2 -->
</div>



 <div class="tab-content" id="tab2">

        <table>
            <thead>
              <tr>
                <th>标本号</th>
                <th>标本来源</th>
                <th>姓名</th>
                <th>性别</th>
                <th>年龄</th>
                <th style="width:10%">操作</th>
              </tr>
            </thead>

            <tbody>
            		<!-- loop list -->
        <asp:Repeater ID="rptData" runat="server">
        <ItemTemplate>

			
			<!-- loop list -->
              <tr>
                <td><%# Eval("CODE")%></td>
                <td><%# Eval("company_name")%></td>
                <td><%# Eval("name")%></td>
                <td><%# Eval("gender")%></td>
                <td><%# Eval("age")%></td>
                <td>
                  <!-- Icons -->
                  <a href="OrderDetail.aspx?info_id=<%# Eval("info_id")%>" title="Edit"><img src="/Resources/images/icons/pencil.png" alt="编辑" /></a>  </td>
              </tr>  
		  <!-- loop list end -->
            		  <!-- loop list end -->
        </ItemTemplate>
        </asp:Repeater> 
 
            </tbody>



          </table>

        </div>

    </div></div>

</asp:Content>
