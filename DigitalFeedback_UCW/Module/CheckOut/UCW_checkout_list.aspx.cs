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
    public partial class UCW_checkout_list : System.Web.UI.Page
    {
        MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                func_table_nonstaff();
                func_table_staff();
            }
        }

        protected void func_table_nonstaff()
        {
            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = CommandType.Text;

                if (txt.Text != "") 
                {
                    cmd.CommandText = "SELECT * FROM nonstaff LEFT JOIN quiz_nonstaff_highscore ON nonstaff.ic_passport = quiz_nonstaff_highscore.quiz_nonstaff_highscore_icno WHERE nonstaff.checkout_dt IS NULL AND name LIKE '%" + txt.Text + "%'  ORDER BY nonstaff.checkout_dt";
                }
                else
                {
                    cmd.CommandText = "SELECT * FROM nonstaff LEFT JOIN quiz_nonstaff_highscore ON nonstaff.ic_passport = quiz_nonstaff_highscore.quiz_nonstaff_highscore_icno WHERE nonstaff.checkout_dt IS NULL ORDER BY nonstaff.checkout_dt";
                }
                
                cmd.Connection = conn;

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        TableRow tblrow = new TableRow();

                        bool score_pass = false;

                        for (int i = 1; i <= 4; i++)
                        {
                            TableCell tblcell = new TableCell();
                            if (i == 1) { tblcell.Text = dr["name"].ToString(); }
                            if (i == 2) { tblcell.Text = dr["ic_passport"].ToString(); }
                            if (i == 3) 
                            {
                                if (dr["quiz_nonstaff_highscore_score"].ToString() == "")
                                {
                                    tblcell.Text = "No Score"; 
                                }
                                else
                                {
                                    tblcell.Text = dr["quiz_nonstaff_highscore_score"].ToString() + "%";

                                    int score = 0;

                                    score = Convert.ToInt32(dr["quiz_nonstaff_highscore_score"].ToString());

                                    if (score >= 80)
                                    {
                                        score_pass = true;
                                    }
                                }                                
                            }
                            if (i == 4)
                            {
                                LinkButton lnkview = new LinkButton();
                                LinkButton lnkedit = new LinkButton();
                                Label lbl = new Label();

                                lnkview.Text = "VIEW";
                                lnkview.Attributes.Add("onclick", "windowOpen('UCW_checkout_view.aspx?id=" + dr["ic_passport"].ToString() + "');return false;");

                                lbl.Text = "&nbsp;&nbsp;";

                                lnkedit.Text = "CHECKOUT";
                                lnkedit.Attributes.Add("onclick", "updateItem('UCW_checkout_update.aspx?id=" + dr["ic_passport"].ToString() + "');return false;");

                                if (score_pass == true)
                                {
                                    tblcell.Controls.Add(lnkedit);
                                    tblcell.Controls.Add(lbl);
                                }
                                
                                tblcell.Controls.Add(lnkview);
                            }
                            tblrow.Cells.Add(tblcell);
                        }
                        tbllist_nonstaff.Rows.Add(tblrow);
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

        protected void func_table_staff()
        {
            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = CommandType.Text;

                if (txt.Text != "")
                {
                    cmd.CommandText = "SELECT * FROM staff LEFT JOIN quiz_staff_highscore ON staff.idstaff = quiz_staff_highscore.quiz_staff_highscore_idno WHERE staff.checkout_dt IS NULL AND name LIKE '%" + txt.Text + "%'  ORDER BY staff.checkout_dt DESC";
                }
                else
                {
                    cmd.CommandText = "SELECT * FROM staff LEFT JOIN quiz_staff_highscore ON staff.idstaff = quiz_staff_highscore.quiz_staff_highscore_idno WHERE staff.checkout_dt IS NULL ORDER BY staff.checkout_dt DESC";
                }

                cmd.Connection = conn;

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        TableRow tblrow = new TableRow();

                        bool score_pass = false;

                        for (int i = 1; i <= 4; i++)
                        {
                            TableCell tblcell = new TableCell();
                            if (i == 1) { tblcell.Text = dr["name"].ToString(); }
                            if (i == 2) { tblcell.Text = dr["idstaff"].ToString(); }
                            if (i == 3)
                            {
                                if (dr["quiz_staff_highscore_score"].ToString() == "")
                                {
                                    tblcell.Text = "No Score";
                                }
                                else
                                {
                                    tblcell.Text = dr["quiz_staff_highscore_score"].ToString() + "%";

                                    int score = 0;

                                    score = Convert.ToInt32(dr["quiz_staff_highscore_score"].ToString());

                                    if (score >= 80)
                                    {
                                        score_pass = true;
                                    }
                                }
                            }
                            if (i == 4)
                            {
                                LinkButton lnkviews = new LinkButton();
                                LinkButton lnkedit = new LinkButton();
                                Label lbl = new Label();

                                lnkviews.Text = "VIEW";
                                lnkviews.Attributes.Add("onclick", "windowOpen('UCW_checkout_view_staff.aspx?idno=" + dr["idstaff"].ToString() + "');return false;");

                                lbl.Text = "&nbsp;&nbsp;";

                                lnkedit.Text = "CHECKOUT";
                                lnkedit.Attributes.Add("onclick", "updateItem('UCW_checkout_update.aspx?idno=" + dr["idstaff"].ToString() + "');return false;");

                                if (score_pass == true)
                                {
                                    tblcell.Controls.Add(lnkedit);
                                    tblcell.Controls.Add(lbl);
                                }

                                tblcell.Controls.Add(lnkviews);
                            }
                            tblrow.Cells.Add(tblcell);
                        }
                        tbllist_staff.Rows.Add(tblrow);
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
            func_table_nonstaff();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            func_table_staff();
        }
    }
}