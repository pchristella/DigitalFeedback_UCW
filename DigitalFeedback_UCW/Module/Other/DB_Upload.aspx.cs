using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using System.Collections;

namespace DigitalFeedback_UCW.Module.Other
{
    public partial class DB_Upload : System.Web.UI.Page
    {
        MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT COUNT(*) as cnt FROM staff";
                cmd.Connection = conn;

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        lblall.Text = dr["cnt"].ToString();
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
                cmd.CommandText = "SELECT COUNT(*) as cnt FROM staff_dump";
                cmd.Connection = conn;

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        lblmlng.Text = dr["cnt"].ToString();
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
                cmd.CommandText = "SELECT COUNT(*) as cnt FROM staff_dumbskg";
                cmd.Connection = conn;

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        lblskg.Text = dr["cnt"].ToString();
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
                cmd.CommandText = "SELECT COUNT(*) as cnt FROM staff_dumbcom";
                cmd.Connection = conn;

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        lblcom.Text = dr["cnt"].ToString();
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
                cmd.CommandText = "SELECT COUNT(*) as cnt FROM staff_dumbext";
                cmd.Connection = conn;

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        lblext.Text = dr["cnt"].ToString();
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();

            try
            {
                conn.Open();                

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM staff_dump";
                cmd.Connection = conn;

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        ArrayList lst = new ArrayList();
                        lst.Add(dr["staffID"].ToString());
                        lst.Add(dr["Name"].ToString());
                        lst.Add(dr["Dept"].ToString());
                        list.Add(lst);
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

                foreach (ArrayList l in list)
                {
                    string id = l[0].ToString();
                    string name = l[1].ToString();
                    string dept = l[2].ToString().Replace("?","").Replace("&","and");

                    MySqlCommand cmd4 = new MySqlCommand();
                    cmd4.CommandType = CommandType.Text;
                    cmd4.CommandText = "INSERT INTO staff (staffid, name, dept, OPU) VALUES ('" + id + "','" + name.Replace("'", "`") + "','" + dept.Replace("'", "`") + "','MLNG')";
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
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM staff_dumbskg";
                cmd.Connection = conn;

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        ArrayList lst = new ArrayList();
                        lst.Add(dr["staffid"].ToString());
                        lst.Add(dr["name"].ToString().Replace("?", "").Replace("&", "and").Replace("'", "`"));
                        lst.Add(dr["dept"].ToString().Replace("?","").Replace("&","and").Replace("'", "`"));
                        list.Add(lst);
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

                foreach (ArrayList l in list)
                {
                    string id = l[0].ToString();
                    string name = l[1].ToString();
                    string dept = l[2].ToString();

                    MySqlCommand cmd4 = new MySqlCommand();
                    cmd4.CommandType = CommandType.Text;
                    cmd4.CommandText = "INSERT INTO staff (staffid, name, dept, OPU) VALUES ('" + id + "','" + name + "','" + dept + "','SKG')";
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
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM staff_dumbcom";
                cmd.Connection = conn;

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        ArrayList lst = new ArrayList();
                        lst.Add(dr["staffid"].ToString());
                        lst.Add(dr["name"].ToString().Replace("?", "").Replace("&", "and").Replace("'", "`"));
                        lst.Add(dr["opu"].ToString().Replace("?", "").Replace("&", "and").Replace("'", "`"));
                        lst.Add(dr["tel"].ToString());
                        list.Add(lst);
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

                foreach (ArrayList l in list)
                {
                    string id = l[0].ToString();
                    string name = l[1].ToString();
                    string opu = l[2].ToString();
                    string tel = l[3].ToString();

                    MySqlCommand cmd4 = new MySqlCommand();
                    cmd4.CommandType = CommandType.Text;
                    cmd4.CommandText = "INSERT INTO staff (staffid, name, OPU, telno) VALUES ('" + id + "','" + name + "','" + opu + "','" + tel + "')";
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
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM staff_dumbext";
                cmd.Connection = conn;

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        ArrayList lst = new ArrayList();
                        lst.Add(dr["staffid"].ToString());
                        lst.Add(dr["name"].ToString().Replace("?", "").Replace("&", "and").Replace("'", "`"));
                        lst.Add(dr["opu"].ToString().Replace("?", "").Replace("&", "and").Replace("'", "`"));
                        lst.Add(dr["phone"].ToString());
                        list.Add(lst);
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

                foreach (ArrayList l in list)
                {
                    string id = l[0].ToString();
                    string name = l[1].ToString();
                    string opu = l[2].ToString();
                    string tel = l[3].ToString();

                    MySqlCommand cmd4 = new MySqlCommand();
                    cmd4.CommandType = CommandType.Text;
                    cmd4.CommandText = "INSERT INTO staff (staffid, name, OPU, telno) VALUES ('" + id + "','" + name + "','" + opu + "','" + tel + "')";
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
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("DB_Upload.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                MySqlCommand cmd2 = new MySqlCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "DELETE FROM staff";
                cmd2.Connection = conn;

                cmd2.ExecuteNonQuery();
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