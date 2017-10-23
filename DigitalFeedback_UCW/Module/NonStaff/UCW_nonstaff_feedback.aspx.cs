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
    public partial class UCW_nonstaff_feedback : System.Web.UI.Page
    {
        public string icno = "";
        public bool fb_stat = false;

        MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            icno = Request.QueryString["id"];

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM feedback_nonstaff WHERE fb_ns_icno = '" + icno + "'";
                cmd.Connection = conn;

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        fb_stat = true;
                    }
                }

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

                if (fb_stat == true)
                {
                    MySqlCommand cmd2 = new MySqlCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "UPDATE feedback_nonstaff SET fb_ns_q1=3, fb_ns_dt=NOW(), fb_ns_dtlatestupdt=NOW() WHERE fb_ns_icno = '" + icno + "'";
                    cmd2.Connection = conn;

                    cmd2.ExecuteNonQuery();
                }
                else
                {
                    MySqlCommand cmd4 = new MySqlCommand();
                    cmd4.CommandType = CommandType.Text;
                    cmd4.CommandText = "INSERT INTO feedback_nonstaff (fb_ns_icno, fb_ns_q1, fb_ns_dt, fb_ns_dtlatestupdt,fb_ns_stat) VALUES ('" + icno + "',3,NOW(),NOW(),0)";
                    cmd4.Connection = conn;

                    cmd4.ExecuteNonQuery();
                }                

                Response.Redirect("UCW_nonstaff_feedbackq2.aspx?id=" + icno);
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

                if (fb_stat == true)
                {
                    MySqlCommand cmd2 = new MySqlCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "UPDATE feedback_nonstaff SET fb_ns_q1=2, fb_ns_dt=NOW(), fb_ns_dtlatestupdt=NOW() WHERE fb_ns_icno = '" + icno + "'";
                    cmd2.Connection = conn;

                    cmd2.ExecuteNonQuery();
                }
                else
                {
                    MySqlCommand cmd4 = new MySqlCommand();
                    cmd4.CommandType = CommandType.Text;
                    cmd4.CommandText = "INSERT INTO feedback_nonstaff (fb_ns_icno, fb_ns_q1, fb_ns_dt, fb_ns_dtlatestupdt,fb_ns_stat) VALUES ('" + icno + "',2,NOW(),NOW(),0)";
                    cmd4.Connection = conn;

                    cmd4.ExecuteNonQuery();
                }                

                Response.Redirect("UCW_nonstaff_feedbackq2.aspx?id=" + icno);
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

                if (fb_stat == true)
                {
                    MySqlCommand cmd2 = new MySqlCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "UPDATE feedback_nonstaff SET fb_ns_q1=1, fb_ns_dt=NOW(), fb_ns_dtlatestupdt=NOW() WHERE fb_ns_icno = '" + icno + "'";
                    cmd2.Connection = conn;

                    cmd2.ExecuteNonQuery();
                }
                else
                {
                    MySqlCommand cmd4 = new MySqlCommand();
                    cmd4.CommandType = CommandType.Text;
                    cmd4.CommandText = "INSERT INTO feedback_nonstaff (fb_ns_icno, fb_ns_q1, fb_ns_dt, fb_ns_dtlatestupdt,fb_ns_stat) VALUES ('" + icno + "',1,NOW(),NOW(),0)";
                    cmd4.Connection = conn;

                    cmd4.ExecuteNonQuery();
                }

                Response.Redirect("UCW_nonstaff_feedbackq2.aspx?id=" + icno);
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