using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace LIS2017.Report
{
    public partial class ReportList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
            }
        }

        public void BindData()
        {
            //读取样本号列表
            DataSet ds = new DataSet();
            ds = LIS2017.App_Code.Report.ReportList(1);
            rptCode.DataSource = ds;
            rptCode.DataBind();
        }

        protected void btnPrintSingle_Click(object sender, EventArgs e)
        {
            //新开页面打印
        }

        protected void btnDetail_Click(object sender, EventArgs e)
        {
            //显示该标本信息


            DataSet ds = new DataSet();
            //ds = LIS2017.App_Code.Report.ReportDetail();



        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            //模糊查询标本号
        }

        protected void btnPrint_Click(object sender, EventArgs e)
        {
            //打印
        }


    }
}