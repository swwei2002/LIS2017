<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderSubAdd.aspx.cs" Inherits="LIS2017.Order.OrderSubAdd" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .t
        {
            width:20% !important;
            
        }
        .t tr
        {
            background-color:transparent !important;
            border-color:transparent !important;
        }


    </style>
                <script type="text/javascript">
                    function load() {
                        Sys.WebForms.PageRequestManager.getInstance().add_endRequest(EndRequestHandler);
                        changeSideBar("order", "order-receive");
                    }
                    function EndRequestHandler() {
                        $(document).ready(function () {

                            $('#MainContent_TextBoxBegin').datepicker({
                                changeMonth: true,
                                changeYear: true
                            });
                            $("#MainContent_TextBoxBegin").datepicker("option", "dateFormat", "yy-mm-dd");
                            $('#MainContent_TextBoxEnd').datepicker({
                                changeMonth: true,
                                changeYear: true
                            });
                            $("#MainContent_TextBoxEnd").datepicker("option", "dateFormat", "yy-mm-dd");
                            //$("#MainContent_CheckBoxAll").click(function () {

                            //    if ($(this).is(":checked")) {

                            //        $("input[name$='CheckCode']").attr("checked", true);

                            //    }
                            //    else {
                            //        $("input[name$='CheckCode']").removeAttr("checked");

                            //    }
                            //})

                            //$("input[title='series']").click(function () {
                            //    //var s = $(this).val;
                            //    alert($(this).val());
                            //    $("input[title='" + s + "']").attr("checked", true);
                            //})
                        });
                    }
                    window.onload = load;


                    $(document).ready(EndRequestHandler);
		function postBackByObject() {
		    var o = window.event.srcElement;
		    if (o.tagName == "INPUT" && o.type == "checkbox" && o.title=="series") {
		        __doPostBack("MainContent_UpdatePanel1", "");
		    }
		}
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>   


<div id="main-content">
            <div class="content-box-header">
                    <h3>项目绑定</h3>
                    <div class="clear"></div>
            </div>
    <div class="content-box-content">
        <div>
            <p><label style="display:inline">起始日期</label><asp:TextBox ID="TextBoxBegin" runat="server"></asp:TextBox>
               
            </p>
            <p><label style="display:inline">终止日期</label><asp:TextBox ID="TextBoxEnd" runat="server"></asp:TextBox>
                <asp:Button ID="ButtonSearch" runat="server" Text="查询" OnClick="ButtonSearch_Click" CssClass="button" /> 
                <asp:Button ID="ButtonBind" runat="server" Text="绑定项目" CssClass="button" OnClick="ButtonBind_Click" /> 
            </p>
        </div>

    </div>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
    <div class="content-box column-left">
      <div class="content-box-header">
        <h3>样品信息</h3>
      </div>
      <div class="content-box-content">
          <div>
              <table>
                  <thead>
                      <tr>
                          <th><asp:CheckBox ID="CheckBoxAll" runat="server" OnCheckedChanged="CheckBoxAll_CheckedChanged" AutoPostBack="True" /></th>
                          <th>样品编号</th>
                          <th>姓名</th>
                          <th>年龄</th>
                          <th>送检单位</th>
                          <th>日期</th>
                          <th>类型</th>
                          <th>状态</th>
                      </tr>
                  </thead>
                  <tbody>
                      <asp:Repeater ID="RepeaterInfo" runat="server">
                          <ItemTemplate>
                              <tr>
                                  <td><input type="checkbox" runat="server" id="CheckCode" value='<%#Eval("code") %>'/></td>
                                  <td><asp:LinkButton ID="LinkButtonInfo" runat="server" CommandArgument='<%#Eval("code") %>' OnClick="LinkButtonInfo_Click"><%#Eval("code") %></asp:LinkButton></td>
                                  <td><%#Eval("name") %></td>
                                  <td><%#Eval("age") %></td>
                                  <td><%#Eval("company_name") %></td>
                                  <td><%#((DateTime)Eval("create_date")).ToString("yyyy-MM-dd") %></td>
                                  <td><%#Eval("sample_type") %></td>
                                  <td><%#Eval("disease") %></td>
                              </tr>
                          </ItemTemplate>
                      </asp:Repeater>
                  </tbody>
              </table>
          </div>
      </div>
    </div>

     <div class="content-box column-right">
        <div class="content-box-header">
          <h3>检验项目</h3>
          </div>
         
          <div class="content-box-content">
              <asp:TreeView ID="TreeViewOrderSub" runat="server" ShowCheckBoxes="All" ExpandDepth="0" CssClass="t" OnTreeNodeCheckChanged="TreeViewOrderSub_TreeNodeCheckChanged" ></asp:TreeView>
          </div>
      </div>
        </ContentTemplate>
    </asp:UpdatePanel>
    <div class="clear"></div>
</div>
            

</asp:Content>
