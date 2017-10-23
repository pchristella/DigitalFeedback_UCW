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
    public partial class UCW_staff_quizcheck : System.Web.UI.Page
    {
        public string idno = "";
        MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            idno = Request.QueryString["id"];
            if (!IsPostBack)
            {
                if (idno != "")
                {
                    txt_id.Text = idno;
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
                cmd.CommandText = "SELECT * FROM ucw_digitalfeedback.staff WHERE idstaff = '" + txt_id.Text + "'";
                cmd.Connection = conn;

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        idno = dr["idstaff"].ToString();
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

            if (idno != "")
            {
                try
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT fb_s_stat FROM feedback_staff WHERE fb_s_idno = '" + idno + "'";
                    cmd.Connection = conn;

                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr.HasRows == true)
                        {
                            feedback_stat = Convert.ToInt32(dr["fb_s_stat"].ToString());
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

            if (idno != "" && feedback_stat == 1)
            {
                int count = 0;

                try
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT quiz_staff_count FROM quiz_staff WHERE quiz_staff_idno = '" + idno + "' ORDER BY quiz_staff_count DESC LIMIT 1";
                    cmd.Connection = conn;

                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr.HasRows == true)
                        {
                            count = Convert.ToInt32(dr["quiz_staff_count"].ToString());
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
                    Response.Redirect("UCW_staff_quizselect.aspx?id=" + idno);
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