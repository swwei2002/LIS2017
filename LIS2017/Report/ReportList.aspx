<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReportList.aspx.cs" Inherits="LIS2017.Report.ReportList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">

        <script type="text/javascript">
		    window.onload=function(){
		        changeSideBar("report", "report-total");
		    }		
    </script>

</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
        <div id="main-content">
      <div class="content-box column-left">
      <!-- Start Content Box -->
      <div class="content-box-header">
        <h3>用户管理</h3>
        <div class="clear"></div>
      </div>
      <!-- End .content-box-header -->
      <div class="content-box-content">
        <div class="tab-content default-tab" id="tab1">
          <!-- This is the target div. id must match the href of this div's tab -->

          <table>
            <thead>
              <tr>
                <th>用户名</th>
                <th>密码</th>
                <th>真名</th>
                <th>科室</th>
                <th>权限</th>
				<th>状态</th>
                <th>操作</th>
              </tr>
            </thead>

            <tbody>


            </tbody>

            <tfoot>

              <tr>
                <td colspan="7">
                  <div class="bulk-actions align-left">
                    <a class="button" href="UserAdd.aspx">新增用户</a> </div>
                        <div class="pagination">
 </div>
                  <!-- End .pagination -->
                  <div class="clear"></div>
                </td>
              </tr>
            </tfoot>
          </table>
        </div>

      </div>
      <!-- End .content-box-content -->
    </div>
    <!-- End .content-box -->	


    <div class="content-box column-right closed-box">
      <div class="content-box-header">
        <!-- Add the class "closed" to the Content box header to have it closed by default -->
        <h3>Content box right</h3>
      </div>
      <!-- End .content-box-header -->
      <div class="content-box-content">
        <div class="tab-content default-tab">
          <h4>This box is closed by default</h4>
          <p> Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed in porta lectus. Maecenas dignissim enim quis ipsum mattis aliquet. Maecenas id velit et elit gravida bibendum. Duis nec rutrum lorem. Donec egestas metus a risus euismod ultricies. Maecenas lacinia orci at neque commodo commodo. </p>
        </div>
        <!-- End #tab3 -->
      </div>
      <!-- End .content-box-content -->
    </div>
    </div>


</asp:Content>
