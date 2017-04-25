<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderList.aspx.cs" Inherits="LIS2017.Order.OrderList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
            <script type="text/javascript">
		window.onload=function(){
		    changeSideBar("order", "order-info");
		}		
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="main-content">
<block name="main">	
    <div class="content-box">
      <!-- Start Content Box -->
      <div class="content-box-header">
        <h3>标本信息</h3>
        <ul class="content-box-tabs">
          <li><a href="#tab1" class="default-tab">未完善</a></li>
          <!-- href must be unique and match the id of target div -->
          <li><a href="#tab2">已完善</a></li>
        </ul>
        <div class="clear"></div>
      </div>
      <!-- End .content-box-header -->
      <div class="content-box-content">
        <div class="tab-content default-tab" id="tab1">

          <table>
            <thead>
              <tr>
                <th>标本号</th>
                <th>状态</th>
                <th>操作</th>
              </tr>
            </thead>

           <tbody>
			
		<!-- loop list -->
        <asp:Repeater ID="rptData" runat="server">
        <ItemTemplate>

              <tr>
                <td>Lorem ipsum dolor</td>
                <td>Consectetur adipiscing</td>
                <td>
                  <!-- Icons -->
                  <a href="#" title="Edit"><img src="/Resources/images/icons/pencil.png" alt="编辑" /></a> <a href="#" title="Delete"><img src="/Resources/images/icons/cross.png" alt="Delete" /></a> </td>
              </tr>  
		  <!-- loop list end -->
        </ItemTemplate>
        </asp:Repeater> 
            </tbody>

            <tfoot>
              <tr>
                <td colspan="3">
                  <div class="pagination">
                      
                       <a href="#" title="First Page">&laquo; First</a><a href="#" title="Previous Page">&laquo; Previous</a> <a href="#" class="number" title="1">1</a> <a href="#" class="number" title="2">2</a> <a href="#" class="number current" title="3">3</a> <a href="#" class="number" title="4">4</a> <a href="#" title="Next Page">Next &raquo;</a><a href="#" title="Last Page">Last &raquo;</a> 

                  </div>
                  <!-- End .pagination -->
                  <div class="clear"></div>
                </td>
              </tr>
            </tfoot>

          </table>
        </div>
        <!-- End #tab1 -->


        <div class="tab-content" id="tab2">

 <table>
            <thead>
              <tr>
                <th>标本号</th>
                <th>状态</th>
                <th>操作</th>
              </tr>
            </thead>

           <tbody>
			
			<!-- loop list -->
              <tr>

                <td>Lorem ipsum dolor</td>
                <td>Consectetur adipiscing</td>
                <td>
                  <!-- Icons -->
                  <a href="#" title="Edit"><img src="/Resources/images/icons/pencil.png" alt="编辑" /></a> <a href="#" title="Delete"><img src="/Resources/images/icons/cross.png" alt="Delete" /></a> </td>
              </tr>  
		  <!-- loop list end -->
 
            </tbody>

            <tfoot>
              <tr>
                <td colspan="3">
                  <div class="pagination">
                      
                       <a href="#" title="First Page">&laquo; First</a><a href="#" title="Previous Page">&laquo; Previous</a> <a href="#" class="number" title="1">1</a> <a href="#" class="number" title="2">2</a> <a href="#" class="number current" title="3">3</a> <a href="#" class="number" title="4">4</a> <a href="#" title="Next Page">Next &raquo;</a><a href="#" title="Last Page">Last &raquo;</a> 

                  </div>
                  <!-- End .pagination -->
                  <div class="clear"></div>
                </td>
              </tr>
            </tfoot>

          </table>

        </div>
        <!-- End #tab2 -->
      </div>
      <!-- End .content-box-content -->
    </div>
    <!-- End .content-box -->	
	</block>

    </div>
</asp:Content>
