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
                <th>密码</th>
                <th>真名</th>
                <th>科室</th>
                <th>权限</th>
				<th>状态</th>
                <th>操作</th>
              </tr>
            </thead>

            <tbody>

        <asp:Repeater ID="rptData" runat="server">
        <ItemTemplate>

              <tr>
                <td><%# Eval("user_name")%></td>
                <td><%# Eval("user_password")%></td>
                <td><%# Eval("real_name")%></td>
                <td><%# Eval("name")%></td>
                <td><%# Eval("user_access").ToString() == "1" ? "普通用户" : Eval("user_access").ToString() == "2" ? "管理员" : "超级管理员"%></td>
				<td><%# Eval("disable").ToString() == "0" ? "启用" : "禁用"%></td>
                <td>
                  <a href="UserDetail.aspx?user_id=<%# Eval("user_id")%>" title="编辑"><img src="/Resources/images/icons/pencil.png" alt="编辑" /></a>
				  <a href="UserDisable.aspx?user_id=<%# Eval("user_id")%>&disable=<%# Eval("disable")%>" title="禁用"><img src="/Resources/images/icons/cross.png" alt="禁用" /></a>	 
			    </td>
              </tr> 
                
               </ItemTemplate>
        </asp:Repeater>       

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
    </div>

</asp:Content>
