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
    public partial class UCW_checkout_view : System.Web.UI.Page
    {
        MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        public string icno = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            icno = Request.QueryString["id"];

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT nonstaff.name as name,nonstaff.ic_passport as ic_passport,feedback_nonstaff.fb_ns_stat as feedback,quiz_nonstaff_highscore.quiz_nonstaff_highscore_score as quiz,nonstaff.checkout_dt as chkout FROM nonstaff LEFT JOIN feedback_nonstaff ON nonstaff.ic_passport = feedback_nonstaff.fb_ns_icno LEFT JOIN quiz_nonstaff_highscore ON nonstaff.ic_passport = quiz_nonstaff_highscore.quiz_nonstaff_highscore_icno WHERE nonstaff.ic_passport = '" + icno + "'";                

                cmd.Connection = conn;

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        Label1.Text = dr["name"].ToString();

                        Label2.Text = dr["ic_passport"].ToString();

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