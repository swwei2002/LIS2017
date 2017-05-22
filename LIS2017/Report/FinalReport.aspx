﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FinalReport.aspx.cs" Inherits="LIS2017.Report.FinalReport" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <!--media=print 这个属性可以在打印时有效-->     
<style media="print">     
.Noprint{display:none;}     
.PageNext{page-break-after: always;}     
</style>     
   
<style>     
.tdp     
{     
border-bottom: 1 solid #000000;     
border-left: 1 solid #000000;     
border-right: 0 solid #ffffff;     
border-top: 0 solid #ffffff;     
}     
.tabp     
{     
border-color: #000000 #000000 #000000 #000000;     
border-style: solid;     
border-top-width: 2px;     
border-right-width: 2px;     
border-bottom-width: 1px;     
border-left-width: 1px;     
}     
.NOPRINT {     
font-family: "宋体";     
font-size: 9pt;     
}     
   
</style>     

</head>
<body>
    <form id="form1" runat="server">
    
        <center class="Noprint" >     
<p>     
<OBJECT id=WebBrowser classid=CLSID:8856F961-340A-11D0-A96B-00C04FD705A2 height=0 width=0>     
</OBJECT>     
<input type=button value=打印 onclick=document.all.WebBrowser.ExecWB(6,1)>     
<input type=button value=直接打印 onclick=document.all.WebBrowser.ExecWB(6,6)>     
<input type=button value=页面设置 onclick=document.all.WebBrowser.ExecWB(8,1)>     
</p>     
<p> <input type=button value=打印预览 onclick=document.all.WebBrowser.ExecWB(7,1)>     
<br/>     
</p>     
<hr align="center" width="90%" size="1" noshade>     
</center>     
<table width="90%" border="0" align="center" cellpadding="2" cellspacing="0" class="tabp">     
<tr>     
<td colspan="3" class="tdp">第1页</td>     
</tr>     
<tr>     
<td width="29%" class="tdp"> </td>     
<td width="28%" class="tdp"> </td>     
<td width="43%" class="tdp"> </td>     
</tr>     
<tr>     
<td colspan="3" class="tdp"> </td>     
</tr>     
<tr>     
<td colspan="3" class="tdp"><table width="100%" border="0" cellspacing="0" cellpadding="0">     
<tr>     
<td width="50%" class="tdp"><p>这样的报表</p>     
<p>对一般的要求就够了。</p></td>     
<td> </td>     
</tr>     
</table></td>     
</tr>     
</table>     
<hr align="center" width="90%" size="1" noshade class="NOPRINT" >     
<!--分页-->     
<div class="PageNext"></div>     
<table width="90%" border="0" align="center" cellpadding="2" cellspacing="0" class="tabp">     
<tr>     
<td class="tdp">第2页</td>     
</tr>     
<tr>     
<td class="tdp">看到分页了吧</td>     
</tr>     
<tr>     
<td class="tdp"> </td>     
</tr>     
<tr>     
<td class="tdp"> </td>     
</tr>     
<tr>     
<td class="tdp"><table width="100%" border="0" cellspacing="0" cellpadding="0">     
<tr>     
<td width="50%" class="tdp"><p>这样的报表</p>     
<p>对一般的要求就够了。</p></td>     
<td> </td>     
</tr>     
</table></td>     
</tr>     
</table>     
<hr align="center" width="90%" size="1" noshade class="NOPRINT" >     
<!--分页-->     
<div class="PageNext"></div>     
<table width="90%" border="0" align="center" cellpadding="2" cellspacing="0" class="tabp">     
<tr>     
<td colspan="3" class="tdp">第1页</td>     
</tr>     
<tr>     
<td width="29%" class="tdp"> </td>     
<td width="28%" class="tdp"> </td>     
<td width="43%" class="tdp"> </td>     
</tr>     
<tr>     
<td colspan="3" class="tdp"> </td>     
</tr>     
<tr>     
<td colspan="3" class="tdp"><table width="100%" border="0" cellspacing="0" cellpadding="0">     
<tr>     
<td width="50%" class="tdp"><p>这样的报表</p>     
<p>对一般的要求就够了。</p></td>     
<td> </td>     
</tr>     
</table></td>     
</tr>     
</table>     
<hr align="center" width="90%" size="1" noshade class="NOPRINT" >     
<!--分页-->     
<div class="PageNext"></div>     
<table width="90%" border="0" align="center" cellpadding="2" cellspacing="0" class="tabp">     
<tr>     
<td class="tdp">第2页</td>     
</tr>     
<tr>     
<td class="tdp">看到分页了吧</td>     
</tr>     
<tr>     
<td class="tdp"> </td>     
</tr>     
<tr>     
<td class="tdp"> </td>     
</tr>     
<tr>     
<td class="tdp"><table width="100%" border="0" cellspacing="0" cellpadding="0">     
<tr>     
<td width="50%" class="tdp"><p>这样的报表</p>     
<p>对一般的要求就够了。</p></td>     
<td> </td>     
</tr>     
</table></td>     
</tr>     
</table>   

    </form>
</body>
</html>
