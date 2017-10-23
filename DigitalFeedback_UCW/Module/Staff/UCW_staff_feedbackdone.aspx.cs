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
    public partial class UCW_staff_feedbackdone : System.Web.UI.Page
    {
        MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        public string idno = "";
        public string fed = "";
        public string quiz = "";
        public string chkout = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            idno = Request.QueryString["id"];
            fed = Request.QueryString["fed"];
            quiz = Request.QueryString["quiz"];

            try
            {
                //conn.Open();
                if (fed == "True")
                {
                    Label1.Text = "1. Feedback ";
                    Label1.Visible = true;

                    if (quiz == "True")
                    {
                        if (qs_pass() == true)
                        {
                            Label5.Text = "2. Quiz ";
                            Label5.Visible = true;

                            Image2.Visible = true;

                            //Label2.Text = "You've answered the quiz and pass, thank you. ";
                            //Label2.Visible = true;

                            if (chkout_stat() == true)
                            {
                                Label6.Text = "3. Check Out Gift ";
                                Label6.Visible = true;

                                Image3.Visible = true;

                                //Label3.Text = "You've taken the checkout gift. Thank You.";
                                //Label3.Visible = true;
                            }
                            else
                            {
                                Label6.Text = "3. Check Out Gift ";
                                Label6.Visible = true;

                                Image3.Visible = true;
                                Image3.ImageUrl = "~/img/feedback/fd_wrong.png";

                                Image6.Visible = true;

                                Label3.Text = "<font color='red'>You are here</font>. You may proceed to claimed your checkout gift at the checkout counter. Thank You.";
                                Label3.Visible = true;
                            }
                        }
                        else
                        {
                            Label5.Text = "2. Quiz ";
                            Label5.Visible = true;

                            Image2.Visible = true;
                            Image2.ImageUrl = "~/img/feedback/fd_wrong.png";

                            Image5.Visible = true;

                            Label2.Text = "<font color='red'>You are here</font>. You've answered the quiz but not pass the requirement, your score is " + qs_score() + "%. You want to re-do? click the button ";
                            Label2.Visible = true;
                            //ImageButton2.Visible = true;
                            LinkButton1.Visible = true;
                        }
                    }
                    else
                    {
                        Label5.Text = "2. Quiz ";
                        Label5.Visible = true;

                        Image2.Visible = true;
                        Image2.ImageUrl = "~/img/feedback/fd_wrong.png";

                        Image5.Visible = true;

                        Label2.Text = "<font color='red'>You are here</font>. You've not answered the quiz yet, click the button to answer the quiz.";
                        Label2.Visible = true;
                        //ImageButton2.Visible = true;
                        LinkButton1.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                //conn.Close();
            }

        }

        public bool qs_pass()
        {
            bool stat = false;
            int count = 0;

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT quiz_staff_score FROM quiz_staff WHERE quiz_staff_idno = '" + idno + "' ORDER BY quiz_staff_score DESC LIMIT 1";
                cmd.Connection = conn;

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        count = Convert.ToInt32(dr["quiz_staff_score"].ToString());
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

            if (count >= 80)
            {
                stat = true;
            }

            return stat;
        }

        public string qs_score()
        {
            string score = "";

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT quiz_staff_score FROM quiz_staff WHERE quiz_staff_idno = '" + idno + "' ORDER BY quiz_staff_score DESC LIMIT 1";
                cmd.Connection = conn;

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        score = dr["quiz_staff_score"].ToString();
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

            return score;
        }

        public bool chkout_stat()
        {
            bool stat = false;
            string chkout_dt = "";

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT checkout_dt FROM staff WHERE ic_passport = '" + idno + "'";
                cmd.Connection = conn;

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        chkout_dt = dr["checkout_dt"].ToString();
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

            if (chkout_dt != "")
            {
                stat = true;
            }

            return stat;
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("UCW_staff_quizselect.aspx?id=" + idno);
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("UCW_staff_quizselect.aspx?id=" + idno);
        }
    }
}