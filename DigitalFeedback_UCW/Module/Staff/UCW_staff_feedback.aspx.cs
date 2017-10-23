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
    public partial class UCW_staff_feedback : System.Web.UI.Page
    {
        public string idno = "";
        MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            idno = Request.QueryString["id"];
        }

        protected void btn3_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                conn.Open();

                MySqlCommand cmd4 = new MySqlCommand();
                cmd4.CommandType = CommandType.Text;
                cmd4.CommandText = "INSERT INTO feedback_staff (fb_s_idno, fb_s_q1, fb_s_dt, fb_s_dtlatestupdt,fb_s_stat) VALUES ('" + idno + "',3,NOW(),NOW(),0)";
                cmd4.Connection = conn;

                cmd4.ExecuteNonQuery();

                Response.Redirect("UCW_staff_feedbackq2.aspx?id=" + idno);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        protected void btn2_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                conn.Open();

                MySqlCommand cmd4 = new MySqlCommand();
                cmd4.CommandType = CommandType.Text;
                cmd4.CommandText = "INSERT INTO feedback_staff (fb_s_idno, fb_s_q1, fb_s_dt, fb_s_dtlatestupdt,fb_s_stat) VALUES ('" + idno + "',2,NOW(),NOW(),0)";
                cmd4.Connection = conn;

                cmd4.ExecuteNonQuery();

                Response.Redirect("UCW_staff_feedbackq2.aspx?id=" + idno);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        protected void btn1_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                conn.Open();

                MySqlCommand cmd4 = new MySqlCommand();
                cmd4.CommandType = CommandType.Text;
                cmd4.CommandText = "INSERT INTO feedback_staff (fb_s_idno, fb_s_q1, fb_s_dt, fb_s_dtlatestupdt,fb_s_stat) VALUES ('" + idno + "',1,NOW(),NOW(),0)";
                cmd4.Connection = conn;

                cmd4.ExecuteNonQuery();

                Response.Redirect("UCW_staff_feedbackq2.aspx?id=" + idno);
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