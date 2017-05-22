<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderSubAudit.aspx.cs" Inherits="LIS2017.Order.OrderSubAudit" %>
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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div id="main-content">
            <div class="content-box-header">
                    <h3>样本核收</h3>
                    <div class="clear"></div>
            </div>
            <div class="content-box-content">
                <div>
                    <asp:Button ID="ButtonAudit" runat="server" Text="确认核收" CssClass="button" OnClick="ButtonAudit_Click" />
                    <asp:Button ID="ButtonSkip" runat="server" Text="跳过" CssClass="button" OnClick="ButtonSkip_Click" />
                </div>
            </div>
    <div class="content-box column-left">
      <div class="content-box-header">
        <h3>未核收样本</h3>
      </div>
        <div class="content-box-content">
            <asp:TreeView ID="TreeViewOrderSub" runat="server" ExpandDepth="0" CssClass="t" ></asp:TreeView>
        </div>
    </div>
            <div class="clear"></div>
</div>
</asp:Content>
