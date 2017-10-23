using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DigitalFeedback_UCW.Module.LuckyDraw
{
    public partial class UCW_luckydraw_main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("UCW_luckydraw_loading.aspx?id=1");
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("UCW_luckydraw_loading.aspx?id=2");
        }
    }
}