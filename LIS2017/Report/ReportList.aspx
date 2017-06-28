<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReportList.aspx.cs" Inherits="LIS2017.Report.ReportList" %>



<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript">
		    window.onload=function(){
		        changeSideBar("report", "report-list");
		    }		
    </script>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="main-content">

        <div class="content-box">
      <!-- Start Content Box -->
      <div class="content-box-header">
        <h3>搜索</h3>
        <div class="clear"></div>
      </div>
      <!-- End .content-box-header -->
      <div class="content-box-content">
        <div class="tab-content default-tab" id="tab1">
            标本号（模糊搜索）<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button ID="btnSearch" runat="server" Text="搜索" class="button" OnClick="btnSearch_Click" />
        </div>

      </div>
      <!-- End .content-box-content -->
    </div>


    <div class="content-box column-left">
      <div class="content-box-header">
        <h3>样本号</h3>
      </div>
      <!-- End .content-box-header -->
      <div class="content-box-content">
          <div> 
             <asp:Button ID="btnPrint" runat="server" Text="打印选中的报告" class="button" OnClick="btnPrint_Click" />
           </div>
        <div class="tab-content default-tab">

           <table>
           <tbody>
           <asp:Repeater ID="rptCode" runat="server">
            <ItemTemplate>

			
			<!-- loop list -->
              <tr>
                <td>
                  <asp:CheckBox ID="cbPrint" ToolTip='<%#Eval("CODE") %>' Text="" runat="server"/>
                </td>
                <td><%# Eval("CODE")%></td>
                  <td><asp:Button ID="btnDetail" runat="server" Text="查看" ToolTip='<%#Eval("CODE") %>' class="button" OnClick="btnDetail_Click" /></td>
              </tr>  
		  <!-- loop list end -->
            		  <!-- loop list end -->
        </ItemTemplate>
        </asp:Repeater> 

                </tbody>
            </table>
      </div>
        <!-- End #tab3 -->
      </div>
      <!-- End .content-box-content -->
    </div>
    <!-- End .content-box -->
    <div class="content-box column-right">
      <div class="content-box-header">
        <!-- Add the class "closed" to the Content box header to have it closed by default -->
        <h3>样本数据</h3>
      </div>
      <!-- End .content-box-header -->
      <div class="content-box-content">
            <div> 
             <asp:Button ID="btnPrintSingle" runat="server" Text="打印此报告" class="button" OnClick="btnPrintSingle_Click" />
           </div>
        <div class="tab-content default-tab">
            <table>
                <tr>
                    <td>项目</td>
                    <td>值</td>
                </tr>
            </table>
        </div>
        <!-- End #tab3 -->
      </div>
      <!-- End .content-box-content -->
    </div>
    <!-- End .content-box -->
    <div class="clear"></div>

        </div>
</asp:Content>
