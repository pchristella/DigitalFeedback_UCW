using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace DigitalFeedback_UCW.Module.Staff
{
    public partial class UCW_staff_feedbackq5 : System.Web.UI.Page
    {
        public string idno = "";
        MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            idno = Request.QueryString["id"];
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                conn.Open();

                MySqlCommand cmd2 = new MySqlCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "UPDATE feedback_staff SET fb_s_q5='" + txt_5.Text + "', fb_s_dtlatestupdt=NOW() WHERE fb_s_idno = '" + idno + "'";
                cmd2.Connection = conn;

                cmd2.ExecuteNonQuery();

                Response.Redirect("UCW_staff_feedbackq6.aspx?id=" + idno);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }
    }
}