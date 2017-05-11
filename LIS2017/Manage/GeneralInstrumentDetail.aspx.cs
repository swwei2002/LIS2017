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
    public partial class GeneralInstrumentDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string type = Request.QueryString["TYPE"];
            if(!IsPostBack)
            {
                if (!string.IsNullOrEmpty(type))
                {
                    InitInst(type);
                    TextBoxType.Enabled = false;
                }
            }
        }

        private void InitInst(string type)
        {
            DataSet ds = GeneralInstrumentManage.GetInstrumentByType(type);
            if(ds.Tables[0].Rows.Count >= 1)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                TextBoxType.Text = dr["TYPE"] as string;
                TextBoxName.Text = dr["NAME"] as string;
                TextBoxInstID.Text = dr["INSTR_ID"] as string;
                TextBoxMaker.Text = dr["MAKER"] as string;
            }
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            string op = Request.QueryString["op"];
            string type = TextBoxType.Text;
            string name = TextBoxName.Text;
            string maker = TextBoxMaker.Text;
            string instrID = TextBoxInstID.Text;

            if("add"== op)
            {
                GeneralInstrumentManage.AddInstrument(type, name, maker, instrID);
            }
            else
            {
                GeneralInstrumentManage.UpdateInstrByType(type,name,maker,instrID);
            }

            Response.Redirect("GeneralInstrumentList.aspx");
        }
    }
}