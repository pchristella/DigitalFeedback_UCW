using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace DigitalFeedback_UCW.Module.NonStaff
{

    public partial class UCW_nonstaff_quizselect : System.Web.UI.Page
    {
        MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        public string icno = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            icno = Request.QueryString["id"];
        }

        protected void Imgbtn1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("UCW_nonstaff_quiz1.aspx?id=" + icno + "&set=1");
        }

        protected void Imgbtn2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("UCW_nonstaff_quiz1.aspx?id=" + icno + "&set=2");
        }

        protected void Imgbtn3_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("UCW_nonstaff_quiz1.aspx?id=" + icno + "&set=3");
        }

        protected void Imgbtn4_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("UCW_nonstaff_quiz1.aspx?id=" + icno + "&set=4");
        }

        protected void Imgbtn5_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("UCW_nonstaff_quiz1.aspx?id=" + icno + "&set=5");
        }
    }
}