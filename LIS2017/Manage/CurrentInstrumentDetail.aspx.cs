using LIS2017.App_Code;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LIS2017.Manage
{
    public partial class CurrentInstrumentDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string instrID = Request.QueryString["instrumentID"];
            //if(!string.IsNullOrEmpty(instrID))
            //{
            //    InitInstrDetial(instrID);
            //}


            if(!IsPostBack)
            {
                InitInstrDetial(instrID);
            }
        }

        private void InitItem(string instrID)
        {
            if(!string.IsNullOrEmpty(instrID))
            {
                DataSet ds = InstrumentItemManage.GetItemByInstrID(instrID);
                RepeaterItem.DataSource = ds;
                RepeaterItem.DataBind();
            }
        }
        private void InitInstrDetial(string instrID)
        {
            string type = "";
            string groupID = "";
            string testType = "";
            string validFlg = "";
            if (!string.IsNullOrEmpty(instrID))
            {

                DataSet ds = CurrentInstrumentManage.GetInstrByInstrID(instrID);
                if (ds.Tables[0].Rows.Count >= 1)
                {
                    DataRow dr = ds.Tables[0].Rows[0];
                    type = dr["TYPE"] as string;
                    groupID = dr["GROUP_ID"] as string;
                    testType = dr["TEST_TYPE"] as string;
                    validFlg = dr["VALID_FLG"] as string;
                    TextBoxName.Text = dr["NAME"] as string;
                    TextBoxRegment.Text = dr["REGMENT"] as string;
                }
            }
            InitItem(instrID);
            InitType(type);
            InitGroupID(groupID);
            InitTestType(testType);
            InitValidFlg(validFlg);

            InitItemCheckList();
        }

        private void InitValidFlg(string validFlg)
        {
            DropDownListValidFlg.Items.Add(new ListItem("有效", "0"));
            DropDownListValidFlg.Items.Add(new ListItem("不使用", "2"));

            if (!string.IsNullOrEmpty(validFlg)) DropDownListValidFlg.SelectedValue = validFlg;
        }

        private void InitTestType(string testType)
        {
            DataSet ds = CodeInfoManage.GetInfoByClassID(CodeInfoManage._TEST_TYPE);
            DropDownListTestType.DataSource = ds;
            DropDownListTestType.DataTextField = "NAME";
            DropDownListTestType.DataValueField = "CODE";
            DropDownListTestType.DataBind();

            if (!string.IsNullOrEmpty(testType)) DropDownListTestType.SelectedValue = testType;
        }

        private void InitGroupID(string groupID)
        {
            DataSet ds = TestGroupManage.GetTestGroupByType("1");
            DropDownListGroupID.DataSource = ds;
            DropDownListGroupID.DataTextField = "NAME";
            DropDownListGroupID.DataValueField = "GROUP_ID";
            DropDownListGroupID.DataBind();

            if (!string.IsNullOrEmpty(groupID)) DropDownListGroupID.SelectedValue = groupID;
        }

        private void InitType(string type)
        {
            DataSet ds = GeneralInstrumentManage.GetInstrument();
            DropDownListType.DataSource = ds;
            DropDownListType.DataTextField = "NAME";
            DropDownListType.DataValueField = "TYPE";
            DropDownListType.DataBind();

            if (!string.IsNullOrEmpty(type)) DropDownListType.SelectedValue = type;

        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            string op = Request.QueryString["op"];
            string instrID = Request.QueryString["instrumentID"];
            string type = DropDownListType.SelectedValue;
            string groupID = DropDownListGroupID.SelectedValue;
            string testType = DropDownListTestType.SelectedValue;
            string validFlg = DropDownListValidFlg.SelectedValue;
            string name = TextBoxName.Text;
            string regment = TextBoxRegment.Text;

            if("add"==op)
            {
                int seq = 1;
                int maxID = CurrentInstrumentManage.GetMaxInstrID();
                string instrumentID = (maxID + 1).ToString();
                DataSet ds = GeneralInstrumentItem.GetItemByType(type);
                List<string> sqls = new List<string>();
                
                string sqlInstr = CurrentInstrumentManage.GetAddSql(int.Parse(instrumentID), groupID, type, name, testType, validFlg, regment);
                sqls.Add(sqlInstr);
                
                foreach(DataRow dr in ds.Tables[0].Rows)
                {
                    string s = InstrumentItemManage.GetAddSql(instrumentID, dr["ITEM_CODE"] as string, type,seq,seq);
                    sqls.Add(s);
                    seq++;
                }

                CurrentInstrumentManage.AddInstrument(sqls);
                LTP.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "CurrentInstrumentDetail.aspx?instrumentID=" + instrumentID);
            }
            else
            {
                CurrentInstrumentManage.UpdateInstrByInstrID(instrID, groupID, type, name, testType, validFlg, regment);
                LTP.Common.MessageBox.Show(this, "保存成功！");
            }
        }

        protected void ImageButtonDelete_Click(object sender, ImageClickEventArgs e)
        {
            string itemCode = ((ImageButton)sender).CommandArgument;
            string instrID = Request.QueryString["instrumentID"];
            InstrumentItemManage.DeleteItemByItemCode(instrID, itemCode);
            InitItem(instrID);
            InitItemCheckList();
        }

        private void InitItemCheckList()
        {
            DataSet ds = CodeInfoManage.GetInfoByClassID(CodeInfoManage._TEST_TYPE);
            string instrID = Request.QueryString["instrumentID"];
            TreeViewItemList.Nodes.Clear();
            foreach(DataRow dr in ds.Tables[0].Rows)
            {
                TreeNode tn = new TreeNode(dr["Name"] as string);
                tn.SelectAction = TreeNodeSelectAction.None;
                DataSet items = GeneralItemManage.GetItemListExculdeInstrItem(dr["CODE"] as string, instrID);
                foreach(DataRow drItem in items.Tables[0].Rows)
                {
                    string name = drItem["NAME"] as string;
                    string code = drItem["ITEM_CODE"] as string;
                    TreeNode trItem = new TreeNode(code + name, code);
                    trItem.SelectAction = TreeNodeSelectAction.None;
                    tn.ChildNodes.Add(trItem);
                }
                TreeViewItemList.Nodes.Add(tn);
            }
        }

        protected void ButtonAddItem_Click(object sender, EventArgs e)
        {
            string instrID = Request.QueryString["instrumentID"];
            int dispSeq = InstrumentItemManage.GetMaxDispSeq(instrID) + 1;
            int printSeq = InstrumentItemManage.GetMaxPrintSeq(instrID) + 1;
            List<string> sqls = new List<string>();
            
            foreach(TreeNode tns in TreeViewItemList.Nodes)
            {
               foreach(TreeNode tn in tns.ChildNodes)
               {
                   if(tn.Checked)
                   {
                       string itemCode = tn.Value;
                       string s = InstrumentItemManage.GetAddSql(instrID, itemCode, dispSeq, printSeq);
                       sqls.Add(s);

                       dispSeq++;
                       printSeq++;
                   }
               }
            }

            InstrumentItemManage.AddItem(sqls);
            InitItem(instrID);
            InitItemCheckList();
        }
    }
}