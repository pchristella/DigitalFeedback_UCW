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
    public partial class UCW_nonstaff_quiz1 : System.Web.UI.Page
    {
        public string icno = "";
        public string set = "";
        public bool ans_stat = false;
        MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            icno = Request.QueryString["id"];
            set = Request.QueryString["set"];
            string qs_id = "";

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT quiz_nonstaff_temp_q1 FROM quiz_nonstaff_temp WHERE quiz_nonstaff_temp_icno = " + icno + "";
                cmd.Connection = conn;

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        int ans = 0;

                        ans = Convert.ToInt32(dr["quiz_nonstaff_temp_q1"].ToString());

                        switch (ans)
                        {
                            case 1:
                                //Button1.BackColor = System.Drawing.Color.Red;
                                break;
                            case 2:
                                //Button2.BackColor = System.Drawing.Color.Red;
                                break;
                            case 3:
                                //Button3.BackColor = System.Drawing.Color.Red;
                                break;
                            case 4:
                                //Button4.BackColor = System.Drawing.Color.Red;
                                break;
                        }

                        ans_stat = true;
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

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM quiz_set WHERE qs_typ = 1 AND qs_no = " + set + "";
                cmd.Connection = conn;

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        Label1.Text = dr["qs_1"].ToString();
                        qs_id = dr["qs_id"].ToString();
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

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM quiz_set_ans WHERE qsa_no = 1 AND qs_id = " + qs_id + "";
                cmd.Connection = conn;

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        Label2.Text = dr["qsa_1"].ToString();
                        Label3.Text = dr["qsa_2"].ToString();
                        Label4.Text = dr["qsa_3"].ToString();
                        //Label5.Text = dr["qsa_4"].ToString();
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

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                conn.Open();

                if (ans_stat == true)
                {
                    MySqlCommand cmd2 = new MySqlCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "UPDATE quiz_nonstaff_temp SET quiz_nonstaff_temp_q1=1 WHERE quiz_nonstaff_temp_icno = '" + icno + "'";
                    cmd2.Connection = conn;

                    cmd2.ExecuteNonQuery();
                }
                else
                {
                    MySqlCommand cmd4 = new MySqlCommand();
                    cmd4.CommandType = CommandType.Text;
                    cmd4.CommandText = "INSERT INTO quiz_nonstaff_temp (quiz_nonstaff_temp_icno, quiz_nonstaff_temp_q1) VALUES ('" + icno + "',1)";
                    cmd4.Connection = conn;

                    cmd4.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            Response.Redirect("UCW_nonstaff_quiz2.aspx?id=" + icno + "&set=" + set);
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                conn.Open();

                if (ans_stat == true)
                {
                    MySqlCommand cmd2 = new MySqlCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "UPDATE quiz_nonstaff_temp SET quiz_nonstaff_temp_q1=2 WHERE quiz_nonstaff_temp_icno = '" + icno + "'";
                    cmd2.Connection = conn;

                    cmd2.ExecuteNonQuery();
                }
                else
                {
                    MySqlCommand cmd4 = new MySqlCommand();
                    cmd4.CommandType = CommandType.Text;
                    cmd4.CommandText = "INSERT INTO quiz_nonstaff_temp (quiz_nonstaff_temp_icno, quiz_nonstaff_temp_q1) VALUES ('" + icno + "',2)";
                    cmd4.Connection = conn;

                    cmd4.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            Response.Redirect("UCW_nonstaff_quiz2.aspx?id=" + icno + "&set=" + set);
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                conn.Open();

                if (ans_stat == true)
                {
                    MySqlCommand cmd2 = new MySqlCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "UPDATE quiz_nonstaff_temp SET quiz_nonstaff_temp_q1=3 WHERE quiz_nonstaff_temp_icno = '" + icno + "'";
                    cmd2.Connection = conn;

                    cmd2.ExecuteNonQuery();
                }
                else
                {
                    MySqlCommand cmd4 = new MySqlCommand();
                    cmd4.CommandType = CommandType.Text;
                    cmd4.CommandText = "INSERT INTO quiz_nonstaff_temp (quiz_nonstaff_temp_icno, quiz_nonstaff_temp_q1) VALUES ('" + icno + "',3)";
                    cmd4.Connection = conn;

                    cmd4.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            Response.Redirect("UCW_nonstaff_quiz2.aspx?id=" + icno + "&set=" + set);
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                conn.Open();

                if (ans_stat == true)
                {
                    MySqlCommand cmd2 = new MySqlCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "UPDATE quiz_nonstaff_temp SET quiz_nonstaff_temp_q1=4 WHERE quiz_nonstaff_temp_icno = '" + icno + "'";
                    cmd2.Connection = conn;

                    cmd2.ExecuteNonQuery();
                }
                else
                {
                    MySqlCommand cmd4 = new MySqlCommand();
                    cmd4.CommandType = CommandType.Text;
                    cmd4.CommandText = "INSERT INTO quiz_nonstaff_temp (quiz_nonstaff_temp_icno, quiz_nonstaff_temp_q1) VALUES ('" + icno + "',4)";
                    cmd4.Connection = conn;

                    cmd4.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            Response.Redirect("UCW_nonstaff_quiz2.aspx?id=" + icno + "&set=" + set);
        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("UCW_nonstaff_quiz2.aspx?id=" + icno + "&set=" + set);
        }
    }
}