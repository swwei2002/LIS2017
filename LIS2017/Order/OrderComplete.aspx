<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderComplete.aspx.cs" Inherits="LIS2017.Order.OrderComplete" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
                <script type="text/javascript">
		window.onload=function(){
		    changeSideBar("order", "order-complete");
		}		
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

     <div id="main-content">

    <div class="content-box">
      <!-- Start Content Box -->
      <div class="content-box-header">
        <h3>标本补录</h3>

        <div class="clear"></div>
      </div>
      <!-- End .content-box-header -->

      <div class="content-box-content">
 


        <div class="tab-content default-tab" id="tab2">

              <div> 

                    <asp:Button ID="btnPrint" runat="server" Text="打印" class="button" OnClick="btnPrint_Click" />
                  &nbsp;
                  <asp:Button ID="btnDelete" runat="server" Text="删除" class="button" OnClick="btnDelete_Click" />

                 </div>

        <table>
            <thead>
              <tr>
               <th>
                  <input class="check-all" type="checkbox" />
                </th>
                <th>标本号</th>
                <th>标本来源</th>
                <th>生成日期</th>
                <th style="width:10%">操作</th>
              </tr>
            </thead>

            <tbody>
            		<!-- loop list -->
        <asp:Repeater ID="rptData" runat="server">
        <ItemTemplate>

			
			<!-- loop list -->
              <tr>
                <td>
                  <asp:CheckBox ID="cbPrint" ToolTip='<%#Eval("CODE") %>' Text="" runat="server"/>
                </td>
                <td><%# Eval("CODE")%></td>
                <td><%# Eval("company_name")%></td>
                <td><%# Eval("create_date")%></td>

                <td>
                  <!-- Icons -->
                  <a href="OrderDetail.aspx?type=complete&info_id=<%# Eval("info_id")%>" title="Edit"><img src="/Resources/images/icons/pencil.png" alt="编辑" /></a>
                 <asp:ImageButton ID="ImageButtonDelete" runat="server" CommandArgument='<%# Eval("info_id")%>' ImageUrl="/Resources/images/icons/cross.png" OnClick="ImageButtonDelete_Click"  OnClientClick="return confirm('确定删除？')" ToolTip="删除"/>

                </td>
              </tr>  
		  <!-- loop list end -->
            		  <!-- loop list end -->
        </ItemTemplate>
        </asp:Repeater> 
 
            </tbody>

            <tfoot>
              <tr>

                <td colspan="7">

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
