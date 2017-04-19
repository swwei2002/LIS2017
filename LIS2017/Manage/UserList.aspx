<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserList.aspx.cs" Inherits="LIS2017.Manage.UserList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">

    <script type="text/javascript">
		    window.onload=function(){
		        changeSideBar("system", "system-totaluser");
		    }		
    </script>

</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="main-content">
      <div class="content-box">
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
                <th>真名</th>
                <th>科室</th>
				<th>开启状态</th>
                <th>操作</th>
              </tr>
            </thead>
            <tfoot>
              <tr>
                <td colspan="5">
                  <div class="bulk-actions align-left">
                    <a class="button" href="#">新增用户</a> </div>
                  <div class="pagination"> <a href="#" title="First Page">&laquo; First</a><a href="#" title="Previous Page">&laquo; Previous</a> <a href="#" class="number" title="1">1</a> <a href="#" class="number" title="2">2</a> <a href="#" class="number current" title="3">3</a> <a href="#" class="number" title="4">4</a> <a href="#" title="Next Page">Next &raquo;</a><a href="#" title="Last Page">Last &raquo;</a> </div>
                  <!-- End .pagination -->
                  <div class="clear"></div>
                </td>
              </tr>
            </tfoot>
            <tbody>
			

              <tr>
                <td>user_name</td>
                <td>real_name</td>
                <td>mobile</td>
				<td>开启or关闭</td>
                <td>
                  <a href="#" title="编辑"><img src="/Resources/images/icons/pencil.png" alt="编辑" /></a>
				  <a href="#" title="禁用"><img src="/Resources/images/icons/cross.png" alt="禁用" /></a>
				  <a href="#" title="配置权限"><img src="/Resources/images/icons/hammer_screwdriver.png" alt="配置权限" /></a>
			    </td>
              </tr>  
			  


 
            </tbody>
          </table>
        </div>

      </div>
      <!-- End .content-box-content -->
    </div>
    <!-- End .content-box -->	
    </div>

</asp:Content>
