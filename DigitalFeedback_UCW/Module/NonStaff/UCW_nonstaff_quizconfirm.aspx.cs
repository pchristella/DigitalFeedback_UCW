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
    public partial class UCW_nonstaff_quizconfirm : System.Web.UI.Page
    {
        public string icno = "";
        public string set = "";
        public string a, b, c, d, f = "";
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
                cmd.CommandText = "SELECT * FROM quiz_nonstaff_temp WHERE quiz_nonstaff_temp_icno = " + icno + "";
                cmd.Connection = conn;

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        a = dr["quiz_nonstaff_temp_q1"].ToString();
                        b = dr["quiz_nonstaff_temp_q2"].ToString();
                        c = dr["quiz_nonstaff_temp_q3"].ToString();
                        d = dr["quiz_nonstaff_temp_q4"].ToString();
                        f = dr["quiz_nonstaff_temp_q5"].ToString();
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

            Label1.Text = get_ansdesc(a, 1);
            Label2.Text = get_ansdesc(b, 2);
            Label3.Text = get_ansdesc(c, 3);
            Label4.Text = get_ansdesc(d, 4);
            Label5.Text = get_ansdesc(f, 5);

            lbl_qs1.Text = get_qs(1);
            lbl_qs2.Text = get_qs(2);
            lbl_qs3.Text = get_qs(3);
            lbl_qs4.Text = get_qs(4);
            lbl_qs5.Text = get_qs(5);

            

            bool g = true;

            if (a == "") { g = false; }
            if (b == "") { g = false; }
            if (c == "") { g = false; }
            if (d == "") { g = false; }
            if (f == "") { g = false; }

            if (g == false)
            {
                lbl_1.Text = "You have not answered all the question, please complete the quiz first before submit!";
                ImageButton1.Enabled = false;
            }
            else
            {
                lbl_1.Text = "";
            }
        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            
        }
        
        public string get_ansdesc(string ans, int q)
        {
            string ans_desc = "";
            string qs_id = "";

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
                cmd.CommandText = "SELECT * FROM quiz_set_ans WHERE qsa_no = " + q + " AND qs_id = " + qs_id + "";
                cmd.Connection = conn;

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        switch(ans)
                        {
                            case "1":
                                ans_desc = get_ans2(1) + ". " + dr["qsa_1"].ToString();
                                break;
                            case "2":
                                ans_desc = get_ans2(2) + ". " + dr["qsa_2"].ToString();
                                break;
                            case "3":
                                ans_desc = get_ans2(3) + ". " + dr["qsa_3"].ToString();
                                break;
                            case "4":
                                ans_desc = get_ans2(4) + ". " + dr["qsa_4"].ToString();
                                break;
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

            if (ans_desc == "") { ans_desc = "No Answer."; }

            return ans_desc;
        }

        public string get_qs(int qs_no)
        {
            string qs = "";

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
                        switch (qs_no)
                        {
                            case 1:
                                qs = dr["qs_1"].ToString();
                                break;
                            case 2:
                                qs = dr["qs_2"].ToString();
                                break;
                            case 3:
                                qs = dr["qs_3"].ToString();
                                break;
                            case 4:
                                qs = dr["qs_4"].ToString();
                                break;
                            case 5:
                                qs = dr["qs_5"].ToString();
                                break;
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

            return qs;
        }

        public string get_ans2(int qs_no)
        {
            string ans = "";

            switch (qs_no)
            {
                case 1:
                    ans = "A";
                    break;
                case 2:
                    ans = "B";
                    break;
                case 3:
                    ans = "C";
                    break;
                case 4:
                    ans = "D";
                    break;
            }

            return ans;
        }

        public string get_quizans(string qs_id, int quiz_no)
        {
            string ans = "";

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM quiz_set_ans WHERE qsa_no = " + quiz_no + " AND qs_id = " + qs_id + "";
                cmd.Connection = conn;

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        ans = dr["qsa_ans"].ToString();
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

            return ans;
        }

        public string get_usrquizans(string icno, int quiz_no)
        {
            string ans = "";

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM quiz_nonstaff_temp WHERE quiz_nonstaff_temp_icno = '" + icno + "'";
                cmd.Connection = conn;

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        switch (quiz_no)
                        {
                            case 1:
                                ans = dr["quiz_nonstaff_temp_q1"].ToString();
                                break;
                            case 2:
                                ans = dr["quiz_nonstaff_temp_q2"].ToString();
                                break;
                            case 3:
                                ans = dr["quiz_nonstaff_temp_q3"].ToString();
                                break;
                            case 4:
                                ans = dr["quiz_nonstaff_temp_q4"].ToString();
                                break;
                            case 5:
                                ans = dr["quiz_nonstaff_temp_q5"].ToString();
                                break;
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

            return ans;
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            string qs_id = "";

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
                        Label1.Text = dr["qs_5"].ToString();
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

            string usr_ans1, usr_ans2, usr_ans3, usr_ans4, usr_ans5 = "";
            string qz_ans1, qz_ans2, qz_ans3, qz_ans4, qz_ans5 = "";

            qz_ans1 = get_quizans(qs_id, 1);
            qz_ans2 = get_quizans(qs_id, 2);
            qz_ans3 = get_quizans(qs_id, 3);
            qz_ans4 = get_quizans(qs_id, 4);
            qz_ans5 = get_quizans(qs_id, 5);

            usr_ans1 = get_usrquizans(icno, 1);
            usr_ans2 = get_usrquizans(icno, 2);
            usr_ans3 = get_usrquizans(icno, 3);
            usr_ans4 = get_usrquizans(icno, 4);
            usr_ans5 = get_usrquizans(icno, 5);

            int count = 0;

            if (usr_ans1 == qz_ans1) { count += 20; }
            if (usr_ans2 == qz_ans2) { count += 20; }
            if (usr_ans3 == qz_ans3) { count += 20; }
            if (usr_ans4 == qz_ans4) { count += 20; }
            if (usr_ans5 == qz_ans5) { count += 20; }


            try
            {
                conn.Open();

                MySqlCommand cmd4 = new MySqlCommand();
                cmd4.CommandType = CommandType.Text;
                cmd4.CommandText = "INSERT INTO quiz_nonstaff (quiz_nonstaff_icno, quiz_nonstaff_set, quiz_nonstaff_count, quiz_nonstaff_q1, quiz_nonstaff_q2, quiz_nonstaff_q3, quiz_nonstaff_q4, quiz_nonstaff_q5, quiz_nonstaff_date, quiz_nonstaff_score) VALUES ('" + icno + "'," + set + ", 1, " + a + "," + b + "," + c + "," + d + "," + f + ", NOW()," + count + ")";
                cmd4.Connection = conn;

                cmd4.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            /*---------INSERT INTO HIGH SCORE TABLE------------------*/
            int high_score = 0;
            bool high_score_st = false;

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM quiz_nonstaff_highscore WHERE quiz_nonstaff_highscore_icno = '" + icno + "'";
                cmd.Connection = conn;

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        high_score = Convert.ToInt32(dr["quiz_nonstaff_highscore_score"].ToString());
                        high_score_st = true;
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

                if (count > high_score)
                {
                    if (high_score_st == true)
                    {
                        MySqlCommand cmd2 = new MySqlCommand();
                        cmd2.CommandType = CommandType.Text;
                        cmd2.CommandText = "UPDATE quiz_nonstaff_highscore SET quiz_nonstaff_highscore_score='" + count + "' WHERE quiz_nonstaff_highscore_icno = '" + icno + "'";
                        cmd2.Connection = conn;

                        cmd2.ExecuteNonQuery();
                    }
                    else
                    {
                        MySqlCommand cmd4 = new MySqlCommand();
                        cmd4.CommandType = CommandType.Text;
                        cmd4.CommandText = "INSERT INTO quiz_nonstaff_highscore (quiz_nonstaff_highscore_icno, quiz_nonstaff_highscore_score) VALUES ('" + icno + "'," + count + ")";
                        cmd4.Connection = conn;

                        cmd4.ExecuteNonQuery();
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

            /*--------DELETE TEMPORARY ANSWER-----------------*/
            try
            {
                conn.Open();

                MySqlCommand cmd2 = new MySqlCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "DELETE FROM quiz_nonstaff_temp WHERE quiz_nonstaff_temp_icno = '" + icno + "'";
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

            Response.Redirect("UCW_nonstaff_quizdone.aspx?id=" + icno + "&set=" + set);
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("UCW_nonstaff_quiz5.aspx?id=" + icno + "&set=" + set);
        }
    }
}