<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WorkInfo.aspx.cs" Inherits="LIS2017.Order.WorkInfo" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
    .split{
         page-break-after:always;
      }
    @media print{
INPUT {display:none}
}
    </style>
</head>
<body>
    <form id="form1" runat="server">


<table border="0" style="font-size:9pt;" width="300px" align="center">
<thead style="display:table-header-group;font-weight:bold">
<tr><td colspan="2" align="center" style="font-weight:bold;border:3px double red">每页都有的表头</td></tr>
</thead>
<tbody style="text-align:center"">
<tr><td>表格内容</td><td>表格内容</td></tr>
<tr><td>表格内容</td><td>表格内容</td></tr>
<tr><td>表格内容</td><td>表格内容</td></tr>
<tr><td>表格内容</td><td>表格内容</td></tr>
<tr><td>表格内容</td><td>表格内容</td></tr>
<tr><td>表格内容</td><td>表格内容</td></tr>
<tr style="page-break-after:always;"><td>表格内容</td><td>表格内容</td></tr>
<tr><td>表格内容</td><td>表格内容</td></tr>
<tr><td>表格内容</td><td>表格内容</td></tr>
<tr><td>表格内容</td><td>表格内容</td></tr>
<tr><td>表格内容</td><td>表格内容</td></tr>
<tr><td>表格内容</td><td>表格内容</td></tr>
<tr><td>表格内容</td><td>表格内容</td></tr>
<tr style="page-break-after:always;"><td>表格内容</td><td>表格内容</td></tr>
<tr><td>表格内容</td><td>表格内容</td></tr>
<tr><td>表格内容</td><td>表格内容</td></tr>
<tr><td>表格内容</td><td>表格内容</td></tr>
<tr><td>表格内容</td><td>表格内容</td></tr>
<tr><td>表格内容</td><td>表格内容</td></tr>
<tr><td>表格内容</td><td>表格内容</td></tr>
<tr style="page-break-after:always;"><td>表格内容</td><td>表格内容</td></tr>
</tbody>
<tfoot style="display:table-footer-group;font-weight:bold">
<tr>
<td colspan="2" align="center" style="font-weight:bold;border:3px double blue">每页都有的表尾</td>
</tr>
</tfoot>
</table>
<input type="button" value=" 打 印 " onclick="window.print()"/>



    </form>
</body>
</html>
