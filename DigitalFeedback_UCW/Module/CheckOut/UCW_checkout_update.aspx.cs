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
    public partial class UCW_checkout_update : System.Web.UI.Page
    {
        public string icno = "";
        public string idno = "";
        MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            icno = Request.QueryString["id"];
            idno = Request.QueryString["idno"];

            try
            {
                conn.Open();

                MySqlCommand cmd2 = new MySqlCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "UPDATE nonstaff SET checkout_dt=NOW() WHERE ic_passport = '" + icno + "'";
                cmd2.Connection = conn;

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE staff SET checkout_dt=NOW() WHERE idstaff = '" + idno + "'";
                cmd.Connection = conn;

                cmd.ExecuteNonQuery();

                cmd2.ExecuteNonQuery();

                Response.Redirect("UCW_checkout_list.aspx");
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