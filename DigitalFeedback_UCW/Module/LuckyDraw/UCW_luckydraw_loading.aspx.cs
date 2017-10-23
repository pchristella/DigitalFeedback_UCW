using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DigitalFeedback_UCW.Module.LuckyDraw
{
    public partial class UCW_luckydraw_loading : System.Web.UI.Page
    {
        public int set = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            set = Convert.ToInt32(Request.QueryString["id"].ToString());
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            if (set == 1) { Response.Redirect("UCW_luckydraw_result_staff.aspx"); }
            if (set == 2) { Response.Redirect("UCW_luckydraw_result_nonstaff.aspx"); }
        }
    }
}