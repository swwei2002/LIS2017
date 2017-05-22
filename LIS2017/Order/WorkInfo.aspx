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
    <div style="text-align:center">
        <input type="button" value=" 打 印 " onclick="window.print()"/>
    </div>
    <%=_html %>
    </form>
</body>
</html>
