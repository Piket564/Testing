using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cls_Master;
using System.Data.SqlClient;
using MainClass;

namespace info_test_2
{
    public partial class _Default : System.Web.UI.Page
    {
        private CodeClass cc;
        protected void Page_Load(object sender, EventArgs e)
        {
            /*on document*/
            cc = new CodeClass();
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            results.InnerText = "";
            results.InnerText = cc.getJson("LIST", "JFK", "departure");
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            results.InnerText = "";
            results.InnerText = cc.getJson("IATA", "JFK", "");
        }

        protected void btn3_Click(object sender, EventArgs e)
        {
            results.InnerText = "";
            results.InnerText = cc.getJson("LOCATION", "JFK", "departure");
        }

        protected void btn4_Click(object sender, EventArgs e)
        {
            results.InnerText = "";
            results.InnerText = cc.getJson("TRACKER", "", "");
        }
    }
}