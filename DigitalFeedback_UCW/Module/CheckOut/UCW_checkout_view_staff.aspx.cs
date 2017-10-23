using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace DigitalFeedback_UCW.Module.CheckOut
{
    public partial class UCW_checkout_view_staff : System.Web.UI.Page
    {
        MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        public string idno = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            idno = Request.QueryString["idno"];

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT staff.name as name,staff.idstaff as idstaff,feedback_staff.fb_s_stat as feedback,quiz_staff_highscore.quiz_staff_highscore_score as quiz,staff.checkout_dt as chkout FROM staff LEFT JOIN feedback_staff ON staff.idstaff = feedback_staff.fb_s_idno LEFT JOIN quiz_staff_highscore ON staff.idstaff = quiz_staff_highscore.quiz_staff_highscore_idno WHERE staff.idstaff = '" + idno + "'";

                cmd.Connection = conn;

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        Label1.Text = dr["name"].ToString();

                        Label2.Text = dr["idstaff"].ToString();

                        if (dr["feedback"].ToString() == "1")
                        {
                            Label3.Text = "Done";
                        }
                        else
                        {
                            Label3.Text = "Not Done";
                        }

                        if (dr["quiz"].ToString() == "")
                        {
                            Label4.Text = "Not Done";
                        }
                        else
                        {
                            Label4.Text = dr["quiz"].ToString() + "%";
                        }

                        if (dr["chkout"].ToString() == "")
                        {
                            Label5.Text = "Pending";
                        }
                        else
                        {
                            Label5.Text = dr["checkout_dt"].ToString();
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
    }
}