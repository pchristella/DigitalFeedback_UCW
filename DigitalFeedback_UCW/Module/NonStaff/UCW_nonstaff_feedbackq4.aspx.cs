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
    public partial class UCW_nonstaff_feedbackq4 : System.Web.UI.Page
    {
        public string icno = "";
        MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            icno = Request.QueryString["id"];
        }

        protected void btn1_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                conn.Open();

                MySqlCommand cmd2 = new MySqlCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "UPDATE feedback_nonstaff SET fb_ns_q4=1, fb_ns_dtlatestupdt=NOW() WHERE fb_ns_icno = '" + icno + "'";
                cmd2.Connection = conn;

                cmd2.ExecuteNonQuery();

                Response.Redirect("UCW_nonstaff_feedbackq5.aspx?id=" + icno);
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

                MySqlCommand cmd2 = new MySqlCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "UPDATE feedback_nonstaff SET fb_ns_q4=2, fb_ns_dtlatestupdt=NOW() WHERE fb_ns_icno = '" + icno + "'";
                cmd2.Connection = conn;

                cmd2.ExecuteNonQuery();

                Response.Redirect("UCW_nonstaff_feedbackq5.aspx?id=" + icno);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        protected void btn3_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                conn.Open();

                MySqlCommand cmd2 = new MySqlCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "UPDATE feedback_nonstaff SET fb_ns_q4=3, fb_ns_dtlatestupdt=NOW() WHERE fb_ns_icno = '" + icno + "'";
                cmd2.Connection = conn;

                cmd2.ExecuteNonQuery();

                Response.Redirect("UCW_nonstaff_feedbackq5.aspx?id=" + icno);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        protected void btn4_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                conn.Open();

                MySqlCommand cmd2 = new MySqlCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "UPDATE feedback_nonstaff SET fb_ns_q4=4, fb_ns_dtlatestupdt=NOW() WHERE fb_ns_icno = '" + icno + "'";
                cmd2.Connection = conn;

                cmd2.ExecuteNonQuery();

                Response.Redirect("UCW_nonstaff_feedbackq5.aspx?id=" + icno);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        protected void btn5_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                conn.Open();

                MySqlCommand cmd2 = new MySqlCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "UPDATE feedback_nonstaff SET fb_ns_q4=5, fb_ns_dtlatestupdt=NOW() WHERE fb_ns_icno = '" + icno + "'";
                cmd2.Connection = conn;

                cmd2.ExecuteNonQuery();

                Response.Redirect("UCW_nonstaff_feedbackq5.aspx?id=" + icno);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        protected void btn6_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                conn.Open();

                MySqlCommand cmd2 = new MySqlCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "UPDATE feedback_nonstaff SET fb_ns_q4=6, fb_ns_dtlatestupdt=NOW() WHERE fb_ns_icno = '" + icno + "'";
                cmd2.Connection = conn;

                cmd2.ExecuteNonQuery();

                Response.Redirect("UCW_nonstaff_feedbackq5.aspx?id=" + icno);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        protected void btn7_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                conn.Open();

                MySqlCommand cmd2 = new MySqlCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "UPDATE feedback_nonstaff SET fb_ns_q4=7, fb_ns_dtlatestupdt=NOW() WHERE fb_ns_icno = '" + icno + "'";
                cmd2.Connection = conn;

                cmd2.ExecuteNonQuery();

                Response.Redirect("UCW_nonstaff_feedbackq5.aspx?id=" + icno);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        protected void btn8_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                conn.Open();

                MySqlCommand cmd2 = new MySqlCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "UPDATE feedback_nonstaff SET fb_ns_q4=8, fb_ns_dtlatestupdt=NOW() WHERE fb_ns_icno = '" + icno + "'";
                cmd2.Connection = conn;

                cmd2.ExecuteNonQuery();

                Response.Redirect("UCW_nonstaff_feedbackq5.aspx?id=" + icno);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        protected void btn9_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                conn.Open();

                MySqlCommand cmd2 = new MySqlCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "UPDATE feedback_nonstaff SET fb_ns_q4=9, fb_ns_dtlatestupdt=NOW() WHERE fb_ns_icno = '" + icno + "'";
                cmd2.Connection = conn;

                cmd2.ExecuteNonQuery();

                Response.Redirect("UCW_nonstaff_feedbackq5.aspx?id=" + icno);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        protected void btn10_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                conn.Open();

                MySqlCommand cmd2 = new MySqlCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "UPDATE feedback_nonstaff SET fb_ns_q4=10, fb_ns_dtlatestupdt=NOW() WHERE fb_ns_icno = '" + icno + "'";
                cmd2.Connection = conn;

                cmd2.ExecuteNonQuery();

                Response.Redirect("UCW_nonstaff_feedbackq5.aspx?id=" + icno);
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