<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderList.aspx.cs" Inherits="LIS2017.Order.OrderList" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
            <script type="text/javascript">
		window.onload=function(){
		    changeSideBar("order", "order-info");
		}		
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="main-content">

    <div class="content-box">
      <!-- Start Content Box -->
      <div class="content-box-header">
        <h3>标本信息</h3>
        <ul class="content-box-tabs">
          <li><a href="#tab1" class="default-tab">未完善</a></li>
          <!-- href must be unique and match the id of target div -->
          <li><a href="#tab2">全部信息</a></li>
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
                <th>标本来源</th>
                <th style="width:10%">操作</th>
              </tr>
            </thead>

           <tbody>
			
		<!-- loop list -->
        <asp:Repeater ID="rptNoInfo" runat="server">
        <ItemTemplate>

              <tr>
                <td><%# Eval("CODE")%></td>
                <td><%# Eval("company_name")%></td>
                <td>
                  <!-- Icons -->
                  <a href="OrderDetail.aspx?info_id=<%# Eval("info_id")%>" title="Edit"><img src="/Resources/images/icons/pencil.png" alt="编辑" /></a>  </td>
              </tr>  
		  <!-- loop list end -->
        </ItemTemplate>
        </asp:Repeater> 
            </tbody>

            <tfoot>
              <tr>
                <td colspan="3">
                  <div class="pagination">       
                       <webdiyer:aspnetpager ID="AspNetPager1" runat="server" AlwaysShow="True" OnPageChanged="AspNetPager1_PageChanged" ShowCustomInfoSection="Left"></webdiyer:aspnetpager>
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

            <tfoot>
              <tr>
                <td colspan="6">
                        <div class="pagination">
                            <webdiyer:aspnetpager ID="AspNetPager2" runat="server" AlwaysShow="True" OnPageChanged="AspNetPager2_PageChanged" ShowCustomInfoSection="Left"></webdiyer:aspnetpager>
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


    </div>
</asp:Content>
