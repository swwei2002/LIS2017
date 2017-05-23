<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FinalReport.aspx.cs" Inherits="LIS2017.Report.FinalReport" %>

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
    

<table width="90%" border="0" align="center" cellpadding="2" cellspacing="0" class="tabp">      
<tr>     
<td colspan="3" class="tdp"> </td>     
</tr>  
    <tr>    
<td align="right" colspan="3" class="tdp">
    <img src="../Images/CNAS.jpg" />&nbsp;&nbsp;</td>     
</tr>    
<tr>     
<td align="center" colspan="3" class="tdp"><p style="font-size:40pt;font-weight:bold">检 验 报 告</p></td> 
</tr>
     
    <tr>     
<td colspan="3" class="tdp">
</td>     
</tr>
        
<tr>
<td width="30%" class="tdp"> </td>        
<td colspan="2" class="tdp"><p style="font-size:20pt;font-weight:bold">编号： </p></td>     
</tr>     
<tr>     
<td colspan="3" class="tdp">&nbsp;
</td>     
</tr>  
    <tr>     
<td colspan="3" class="tdp">&nbsp;
</td>     
</tr> 
    <tr>     
<td colspan="3" class="tdp">&nbsp;
</td>     
</tr> 
    <tr>     
<td align="center" colspan="3" class="tdp">
    <img src="../Images/sccl.jpg" width="300" /></td> 
</tr>   
<tr>     
<td align="center" colspan="3" class="tdp"><p style="font-size:25pt;font-weight:bold">上海市临床检验中心</p></td> 
</tr>      
      
</table>     
<hr align="center" width="90%" size="1" noshade class="NOPRINT" >     
<!--分页-->     
<div class="PageNext"></div>     
<table width="90%" border="0" align="center" cellpadding="2" cellspacing="0" class="tabp">     
<tr>     
<td class="tdp">&nbsp;</td>     
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
<td class="tdp">声       明</td>     
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
