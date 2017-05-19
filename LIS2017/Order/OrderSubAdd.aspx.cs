using LIS2017.App_Code;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace LIS2017.Order
{
    public partial class OrderSubAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitOrderSub();
            }
        }

        private void InitOrderSub()
        {
            DataSet company = CompanyManage.GetCompany();
            foreach (DataRow c in company.Tables[0].Rows)
            {
                TreeNode n1 = new TreeNode(c["NAME"] as string);
                n1.SelectAction = TreeNodeSelectAction.None;
                n1.ShowCheckBox = false;
                DataSet item = OrderItemManage.GetOrderItem(c["CODE"] as string, "1", "");
                foreach (DataRow i in item.Tables[0].Rows)
                {
                    TreeNode n2 = new TreeNode(i["SERIES_NAME"] as string);
                    n2.SelectAction = TreeNodeSelectAction.None;
                    n2.ToolTip = "series";
                    //n2.Value = i["CODE"] as string;
                    DataSet sub = OrderItemSubManage.GetItemSub(i["CODE"] as string);
                    foreach (DataRow s in sub.Tables[0].Rows)
                    {
                        TreeNode n3 = new TreeNode(s["NAME"] as string, s["ITEM_CODE"] as string + ",1," + s["CODE"] as string + "," + s["SERIES_DEP_CODE"] + "," + s["SERIES_NAME"]);
                        n3.SelectAction = TreeNodeSelectAction.None;
                        //n3.ToolTip = n2.Value;
                        n2.ChildNodes.Add(n3);
                    }
                    n1.ChildNodes.Add(n2);
                }

                TreeViewOrderSub.Nodes.Add(n1);

            }

            TreeNode s_item = new TreeNode("单项");
            s_item.ShowCheckBox = false;
            s_item.SelectAction = TreeNodeSelectAction.None;

            DataSet type = CodeInfoManage.GetInfoByClassID(CodeInfoManage._TEST_TYPE);
            foreach (DataRow t in type.Tables[0].Rows)
            {
                TreeNode n1 = new TreeNode(t["NAME"] as string);
                n1.SelectAction = TreeNodeSelectAction.None;
                n1.ToolTip = "series";
                DataSet item = OrderItemManage.GetOrderItem("", "2", t["CODE"] as string);
                foreach (DataRow i in item.Tables[0].Rows)
                {
                    TreeNode n2 = new TreeNode(i["NAME"] as string, i["ITEM_LIST"] as string + ",2," + i["CODE"] as string + ",,");
                    n2.SelectAction = TreeNodeSelectAction.None;
                    n1.ChildNodes.Add(n2);
                }
                s_item.ChildNodes.Add(n1);
            }
            TreeViewOrderSub.Nodes.Add(s_item);

            TreeViewOrderSub.Attributes.Add("onclick", "postBackByObject()");
        }
        private void InitInfo()
        {
            string begin = TextBoxBegin.Text;
            string end = TextBoxEnd.Text;
            DataSet ds = TestInfoManage.GetTestInfoByDateRange(begin, end);

            RepeaterInfo.DataSource = ds;
            RepeaterInfo.DataBind();
        }
        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            InitInfo();
        }

        protected void TreeViewOrderSub_TreeNodeCheckChanged(object sender, TreeNodeEventArgs e)
        {
            TreeNode tn = e.Node;
            //TreeView tw = (TreeView)sender;
            //foreach(TreeNode tn in tw.Nodes)
            //{
            foreach (TreeNode n in tn.ChildNodes)
            {
                n.Checked = tn.Checked;
            }
            //}
        }

        protected void RepeaterInfo_DataBinding(object sender, EventArgs e)
        {

        }

        protected void RepeaterInfo_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            RepeaterItem ri = e.Item;
            //CheckBox cb = (CheckBox)ri.FindControl("CheckBoxCode");

        }

        protected void ButtonBind_Click(object sender, EventArgs e)
        {
            RepeaterItemCollection ric = RepeaterInfo.Items;
            List<string> sqls = new List<string>();
            foreach (RepeaterItem ri in ric)
            {

                HtmlInputCheckBox chb = (HtmlInputCheckBox)ri.FindControl("CheckCode");
                if (chb.Checked)
                {
                    string id = chb.Value;
                    sqls.Add(OrderSubManage.GetDelSql(id));
                    sqls.AddRange(GetAddSql(id));
                }
            }

            DbHelperSQL.ExecuteSqlTran(sqls);
            LTP.Common.MessageBox.Show(this, "项目绑定成功！");
        }

        private List<string> GetAddSql(string orderID)
        {
            List<string> sqls = new List<string>();
            foreach (TreeNode n3 in TreeViewOrderSub.CheckedNodes)
            {
                if (string.IsNullOrEmpty(n3.ToolTip))
                {
                    string[] args = n3.Value.Split(',');
                    sqls.Add(OrderSubManage.GetAddSql(orderID, args[0], args[1], args[2], args[3], args[4]));
                }
            }

            return sqls;
        }

        protected void CheckBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            RepeaterItemCollection ric = RepeaterInfo.Items;
            CheckBox cb = (CheckBox)sender;
            foreach (RepeaterItem ri in ric)
            {
                HtmlInputCheckBox chb = (HtmlInputCheckBox)ri.FindControl("CheckCode");
                chb.Checked = cb.Checked;
            }
        }

        protected void LinkButtonInfo_Click(object sender, EventArgs e)
        {
            LinkButton lb = (LinkButton)sender;
            string code = lb.CommandArgument;
            DataSet ds = OrderSubManage.GetOrderSubByCode(code);
            TreeViewOrderSub.CollapseAll();
            foreach (TreeNode n1 in TreeViewOrderSub.Nodes)
            {

                foreach (TreeNode n2 in n1.ChildNodes)
                {
                    n2.Checked = false;
                    foreach (TreeNode n3 in n2.ChildNodes)
                    {
                        string[] args = n3.Value.Split(',');
                        string sql = string.Format("ITEM_CODE='{0}' AND ITEM_TYPE='{1}' AND ORDER_ITEM_CODE='{2}'", args[0], args[1], args[2]);
                        DataRow[] result = ds.Tables[0].Select(sql);
                        if (result.Count() > 0)
                        {
                            n3.Checked = true;
                            //n3.Parent.Expand();
                            n3.Parent.Checked = true;
                            n1.Expand();
                        }
                        else
                        {
                            n3.Checked = false;
                        }
                    }
                }

            }
        }


    }
}