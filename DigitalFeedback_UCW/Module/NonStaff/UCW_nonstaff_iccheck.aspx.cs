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
    public partial class UCW_nonstaff_iccheck : System.Web.UI.Page
    {
        MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            bool stat = false;

            lbl_error.Visible = false;

            try
            {
                if (txt_icno.Text != "")
                {
                    txt_name.Text = "";
                    txt_com.Text = "";
                    txt_telno.Text = "";

                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM ucw_digitalfeedback.nonstaff WHERE ic_passport = '" + txt_icno.Text + "'";
                    cmd.Connection = conn;

                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr.HasRows == true)
                        {
                            txt_name.Text = dr["name"].ToString();
                            txt_com.Text = dr["company"].ToString();
                            txt_telno.Text = dr["telno"].ToString();

                            stat = true;
                        }
                    }

                    if (stat == false)
                    {
                        txt_name.Enabled = true;
                        txt_com.Enabled = true;
                        txt_telno.Enabled = true;
                    }
                    else
                    {
                        txt_name.Enabled = false;
                        txt_com.Enabled = false;
                        txt_telno.Enabled = false;
                    }
                }
                else
                {
                    lbl_error.Text = "Please Insert IC Number / Passport!";
                    lbl_error.Visible = true;
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

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            bool stat = false;
            /*---------CHECK IC--------------*/
            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM ucw_digitalfeedback.nonstaff WHERE ic_passport = '" + txt_icno.Text + "'";
                cmd.Connection = conn;

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows)
                    {
                        stat = true;
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
            /*----------INSERT/UPDATE DETAILS-------------*/
            try
            {
                conn.Open();

                if (stat == false)
                {
                    if (txt_name.Text != "" && txt_telno.Text != "")
                    {
                        MySqlCommand cmd4 = new MySqlCommand();
                        cmd4.CommandType = CommandType.Text;
                        cmd4.CommandText = "INSERT INTO nonstaff (ic_passport, name, company, telno) VALUES ('" + txt_icno.Text + "','" + txt_name.Text + "','" + txt_com.Text + "','" + txt_telno.Text + "')";
                        cmd4.Connection = conn;

                        cmd4.ExecuteNonQuery();
                    }
                    else
                    {
                        if (txt_name.Text == "" && txt_telno.Text != "") { lbl_error.Text = "Please Insert Name!"; }
                        if (txt_name.Text != "" && txt_telno.Text == "") { lbl_error.Text = "Please Insert Phone Number!"; }
                        if (txt_name.Text == "" && txt_telno.Text == "") { lbl_error.Text = "Please Insert Name & Phone Number!"; }

                        lbl_error.Visible = true;
                    }
                }
                else
                {
                    MySqlCommand cmd2 = new MySqlCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "UPDATE nonstaff SET name='" + txt_name.Text + "', company='" + txt_com.Text + "', telno = '" + txt_telno.Text + "' WHERE ic_passport = '" + txt_icno.Text + "'";
                    cmd2.Connection = conn;

                    cmd2.ExecuteNonQuery();

                }


                //Response.Redirect("UCW_nonstaff_feedback.aspx?id=" + txt_icno.Text);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            /*---------------CHECK FEEDBACK------------*/

            bool stat_fed = false;

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM ucw_digitalfeedback.feedback_nonstaff WHERE fb_ns_icno = '" + txt_icno.Text + "' AND fb_ns_stat=1";
                cmd.Connection = conn;

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows)
                    {
                        stat_fed = true;
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
            /*----------------CHECK POP-QUIZ---------------*/
            bool stat_quiz = false;

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM ucw_digitalfeedback.quiz_nonstaff WHERE quiz_nonstaff_icno = '" + txt_icno.Text + "'";
                cmd.Connection = conn;

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows)
                    {
                        stat_quiz = true;
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

            /*---------REDIRECT TO NEXT PAGE-----------*/
            if (txt_icno.Text != "" && txt_name.Text != "" && txt_telno.Text != "")
            {

                if (stat_fed == true || stat_quiz == true)
                {
                    Response.Redirect("UCW_nonstaff_feedbackdone.aspx?id=" + txt_icno.Text + "&fed=" + stat_fed + "&quiz=" + stat_quiz);
                }
                else
                {
                    Response.Redirect("UCW_nonstaff_feedback.aspx?id=" + txt_icno.Text);
                }
            }
        }        
    }
}