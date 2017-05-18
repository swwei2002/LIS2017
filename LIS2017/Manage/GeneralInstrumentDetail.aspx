<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GeneralInstrumentDetail.aspx.cs" Inherits="LIS2017.Manage.GeneralInstrumentDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
            <script type="text/javascript">
		window.onload=function(){
		    changeSideBar("admin", "admin-instrlist");
		}		
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
        <div id="main-content">
            
            <div class="content-box">
                    <div class="content-box-header"> <h3>仪器库管理</h3>
                        <div class="clear"></div>

                    </div>
   
            
            <div class="content-box-content">
                <p>
                    <label style="color:blue">基本属性</label>
                </p>
                <p>
                    <label>仪器类型</label>
                    <asp:TextBox ID="TextBoxType" runat="server" class="text-input small-input"></asp:TextBox>
                </p>
                <p>
                    <label>仪器代码</label>
                    <asp:TextBox ID="TextBoxInstID" runat="server" class="text-input small-input"></asp:TextBox>
                </p>
                 <p>
                    <label>仪器名称</label>
                    <asp:TextBox ID="TextBoxName" runat="server" class="text-input small-input"></asp:TextBox>
                </p>
                <p>
                    <label>厂家名称</label>
                    <asp:TextBox ID="TextBoxMaker" runat="server" class="text-input small-input"></asp:TextBox>
                </p>
            <p>
                <asp:Button ID="ButtonSave" runat="server" Text="保存" class="button" OnClick="ButtonSave_Click"/>
            </p>
            </div>
         </div>
        </div>
</asp:Content>
