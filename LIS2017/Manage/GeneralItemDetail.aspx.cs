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
    public partial class GeneralItemDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string item_code = this.Request.QueryString["item_code"];
            if(!IsPostBack)
            {
                if (!string.IsNullOrEmpty(item_code))
                {
                    TextBoxItemCode.Enabled = false;
                    DropDownListItemType.Enabled = false;
                    InitDetail(item_code);
                }
                else
                {
                    InitItemType(null);
                    InitTestType(null);
                    InitTestMethod(null);
                }
            }
        }

        private void InitItemType(string itemType)
        {
            DropDownListItemType.Items.Add(new ListItem("通用项目", "0"));
            DropDownListItemType.Items.Add(new ListItem("组合项目", "1"));
            DropDownListItemType.Items.Add(new ListItem("计算项目", "2"));

            DropDownListItemType.SelectedValue = itemType;
        }

        private void InitTestType(string testType)
        {
            DataSet ds = CodeInfoManage.GetInfoByClassID(CodeInfoManage._TEST_TYPE);
            DropDownListTestType.DataSource = ds;
            DropDownListTestType.DataTextField = "NAME";
            DropDownListTestType.DataValueField = "CODE";

            DropDownListTestType.SelectedValue = testType;
            DropDownListTestType.DataBind();
        }

        private void InitTestMethod(string testMethod)
        {
            DataSet ds = CodeInfoManage.GetInfoByClassID(CodeInfoManage._TEST_METHOD);
            DropDownListTestMethod.DataSource = ds;
            DropDownListTestMethod.DataTextField = "NAME";
            DropDownListTestMethod.DataValueField = "CODE";

            DropDownListTestMethod.SelectedValue = testMethod;
            DropDownListTestMethod.DataBind();
        }

        private void InitDetail(string code)
        {
            DataSet ds = GeneralItemManage.GetItemByItemCode(code);
            if(ds.Tables[0].Rows.Count >= 1)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                string itemType = dr["ITEM_TYPE"] as string;
                string testType = dr["TEST_TYPE"] as string;
                string testMethod = dr["TEST_METHOD"] as string;
                string name = dr["NAME"] as string;
                string shortName = dr["SHORTNAME"] as string;

                TextBoxItemCode.Text = dr["ITEM_CODE"] as string;
                InitItemType(itemType);
                InitTestType(testType);
                InitTestMethod(testMethod);
                TextBoxName.Text = name;
                TextBoxShortName.Text = shortName;
            }
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            string op = Request.Params["op"];
            string itemCode = TextBoxItemCode.Text;
            string itemType = DropDownListItemType.SelectedValue;
            string testType = DropDownListTestType.SelectedValue;
            string testMethod = DropDownListTestMethod.SelectedValue;
            string name = TextBoxName.Text;
            string shortName = TextBoxShortName.Text;

            
            if("add"==op)
            {
                GeneralItemManage.AddItem(itemCode, itemType, name, shortName, testMethod, testType);
            }
            else
            {
                GeneralItemManage.UpdateItem(itemCode, itemType, name, shortName, testMethod, testType);
            }

            Response.Redirect("GeneralItemList.aspx?op=success");
        }

    }
}