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
    public partial class UCW_nonstaff_quizcheck : System.Web.UI.Page
    {
        public string icno = "";
        MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            icno = Request.QueryString["id"];
            if (!IsPostBack)
            {
                if (icno != "")
                {
                    txt_id.Text = icno;
                }
            }            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int feedback_stat = 0;

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM ucw_digitalfeedback.nonstaff WHERE ic_passport = '" + txt_id.Text + "'";
                cmd.Connection = conn;

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        icno = dr["ic_passport"].ToString();
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

            if (icno != "")
            {
                try
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT fb_ns_stat FROM feedback_nonstaff WHERE fb_ns_icno = '" + icno + "'";
                    cmd.Connection = conn;

                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr.HasRows == true)
                        {
                            feedback_stat = Convert.ToInt32(dr["fb_ns_stat"].ToString());
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

            if (icno != "" && feedback_stat == 1)
            {
                int count = 0;

                try
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT quiz_nonstaff_count FROM quiz_nonstaff WHERE quiz_nonstaff_icno = '" + icno + "' ORDER BY quiz_nonstaff_count DESC LIMIT 1";
                    cmd.Connection = conn;

                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr.HasRows == true)
                        {
                            count = Convert.ToInt32(dr["quiz_nonstaff_count"].ToString());
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

                if (count <= 2)
                {
                    Response.Redirect("UCW_nonstaff_quizselect.aspx?id=" + icno);
                }
                else
                {
                    Label1.Text = "You've submitted quiz twice already, please proceed to check out.";
                    Label1.Visible = true;
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}