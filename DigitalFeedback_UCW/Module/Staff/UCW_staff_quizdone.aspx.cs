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
    public partial class UCW_staff_quizdone : System.Web.UI.Page
    {
        public string idno = "";
        public string set = "";
        MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            idno = Request.QueryString["id"];
            set = Request.QueryString["set"];
            string qs_id = "";
            int count = 0;

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT quiz_staff_score FROM quiz_staff WHERE quiz_staff_idno = '" + idno + "' ORDER BY idquiz_staff DESC LIMIT 1";
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

            
            Label1.Text = count + " %";

            if (count >= 80)
            {
                Label2.Text = "Congratulation, You Pass the Quiz. Please Proceed to collect your UCW'17 goodies.";
            }
            else
            {
                Label2.Text = "Sorry, you didn't pass. Passing mark is 80%.";
                Label3.Visible = true;
                Label3.Text = "Want to retry? click the button";
                ImageButton1.Visible = true;
            }

            //Response.AppendHeader("Refresh", "30; url=~/Default.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("UCW_staff_quizselect.aspx?id=" + idno);
        }
    }
}