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
    public partial class UCW_nonstaff_feedbackq2 : System.Web.UI.Page
    {
        public string icno = "";
        MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            icno = Request.QueryString["id"];

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT fb_ns_q2 FROM feedback_nonstaff WHERE fb_ns_icno = '" + icno + "'";
                cmd.Connection = conn;

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        int val = Convert.ToInt32(dr["fb_ns_q2"].ToString());

                        switch (val)
                        {
                            case 1:
                                btn1.ImageUrl = "~/img/feedback/fb_btn_set2_1b_selected.png";
                                break;
                            case 2:
                                btn2.ImageUrl = "~/img/feedback/fb_btn_set2_2b_selected.png";
                                break;
                            case 3:
                                btn3.ImageUrl = "~/img/feedback/fb_btn_set2_3b_selected.png";
                                break;
                            case 4:
                                btn4.ImageUrl = "~/img/feedback/fb_btn_set2_4b_selected.png";
                                break;
                            case 5:
                                btn5.ImageUrl = "~/img/feedback/fb_btn_set2_5b_selected.png";
                                break;
                            case 6:
                                btn6.ImageUrl = "~/img/feedback/fb_btn_set2_1b_selected.png";
                                break;
                            case 7:
                                btn7.ImageUrl = "~/img/feedback/fb_btn_set2_1b_selected.png";
                                break;
                            case 8:
                                btn8.ImageUrl = "~/img/feedback/fb_btn_set2_1b_selected.png";
                                break;
                            case 9:
                                btn9.ImageUrl = "~/img/feedback/fb_btn_set2_1b_selected.png";
                                break;
                            case 10:
                                btn10.ImageUrl = "~/img/feedback/fb_btn_set2_1b_selected.png";
                                break;
                        }
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

        protected void btn1_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                conn.Open();

                MySqlCommand cmd2 = new MySqlCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "UPDATE feedback_nonstaff SET fb_ns_q2=1, fb_ns_dtlatestupdt=NOW() WHERE fb_ns_icno = '" + icno + "'";
                cmd2.Connection = conn;

                cmd2.ExecuteNonQuery();

                Response.Redirect("UCW_nonstaff_feedbackq3.aspx?id=" + icno);
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
                cmd2.CommandText = "UPDATE feedback_nonstaff SET fb_ns_q2=2, fb_ns_dtlatestupdt=NOW() WHERE fb_ns_icno = '" + icno + "'";
                cmd2.Connection = conn;

                cmd2.ExecuteNonQuery();

                Response.Redirect("UCW_nonstaff_feedbackq3.aspx?id=" + icno);
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
                cmd2.CommandText = "UPDATE feedback_nonstaff SET fb_ns_q2=3, fb_ns_dtlatestupdt=NOW() WHERE fb_ns_icno = '" + icno + "'";
                cmd2.Connection = conn;

                cmd2.ExecuteNonQuery();

                Response.Redirect("UCW_nonstaff_feedbackq3.aspx?id=" + icno);
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
                cmd2.CommandText = "UPDATE feedback_nonstaff SET fb_ns_q2=4, fb_ns_dtlatestupdt=NOW() WHERE fb_ns_icno = '" + icno + "'";
                cmd2.Connection = conn;

                cmd2.ExecuteNonQuery();

                Response.Redirect("UCW_nonstaff_feedbackq3.aspx?id=" + icno);
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
                cmd2.CommandText = "UPDATE feedback_nonstaff SET fb_ns_q2=5, fb_ns_dtlatestupdt=NOW() WHERE fb_ns_icno = '" + icno + "'";
                cmd2.Connection = conn;

                cmd2.ExecuteNonQuery();

                Response.Redirect("UCW_nonstaff_feedbackq3.aspx?id=" + icno);
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
                cmd2.CommandText = "UPDATE feedback_nonstaff SET fb_ns_q2=6, fb_ns_dtlatestupdt=NOW() WHERE fb_ns_icno = '" + icno + "'";
                cmd2.Connection = conn;

                cmd2.ExecuteNonQuery();

                Response.Redirect("UCW_nonstaff_feedbackq3.aspx?id=" + icno);
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
                cmd2.CommandText = "UPDATE feedback_nonstaff SET fb_ns_q2=7, fb_ns_dtlatestupdt=NOW() WHERE fb_ns_icno = '" + icno + "'";
                cmd2.Connection = conn;

                cmd2.ExecuteNonQuery();

                Response.Redirect("UCW_nonstaff_feedbackq3.aspx?id=" + icno);
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
                cmd2.CommandText = "UPDATE feedback_nonstaff SET fb_ns_q2=8, fb_ns_dtlatestupdt=NOW() WHERE fb_ns_icno = '" + icno + "'";
                cmd2.Connection = conn;

                cmd2.ExecuteNonQuery();

                Response.Redirect("UCW_nonstaff_feedbackq3.aspx?id=" + icno);
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
                cmd2.CommandText = "UPDATE feedback_nonstaff SET fb_ns_q2=9, fb_ns_dtlatestupdt=NOW() WHERE fb_ns_icno = '" + icno + "'";
                cmd2.Connection = conn;

                cmd2.ExecuteNonQuery();

                Response.Redirect("UCW_nonstaff_feedbackq3.aspx?id=" + icno);
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
                cmd2.CommandText = "UPDATE feedback_nonstaff SET fb_ns_q2=10, fb_ns_dtlatestupdt=NOW() WHERE fb_ns_icno = '" + icno + "'";
                cmd2.Connection = conn;

                cmd2.ExecuteNonQuery();

                Response.Redirect("UCW_nonstaff_feedbackq3.aspx?id=" + icno);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

        }
    }
}