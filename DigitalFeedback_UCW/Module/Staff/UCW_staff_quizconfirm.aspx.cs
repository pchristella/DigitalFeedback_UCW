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
    public partial class UCW_staff_quizconfirm : System.Web.UI.Page
    {
        public string idno = "";
        public string set = "";
        public string a, b, c, d, f = "";
        MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            idno = Request.QueryString["id"];
            set = Request.QueryString["set"];
            string qs_id = "";


            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM quiz_staff_temp WHERE quiz_staff_temp_idno = '" + idno + "'";
                cmd.Connection = conn;

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        a = dr["quiz_staff_temp_q1"].ToString();
                        b = dr["quiz_staff_temp_q2"].ToString();
                        c = dr["quiz_staff_temp_q3"].ToString();
                        d = dr["quiz_staff_temp_q4"].ToString();
                        f = dr["quiz_staff_temp_q5"].ToString();
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
                        switch (ans)
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
                            //case "4":
                            //    ans_desc = get_ans2(4) + ". " + dr["qsa_4"].ToString();
                            //    break;
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
                //case 4:
                //    ans = "D";
                //    break;
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

        public string get_usrquizans(string idno, int quiz_no)
        {
            string ans = "";

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM quiz_staff_temp WHERE quiz_staff_temp_idno = '" + idno + "'";
                cmd.Connection = conn;

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        switch (quiz_no)
                        {
                            case 1:
                                ans = dr["quiz_staff_temp_q1"].ToString();
                                break;
                            case 2:
                                ans = dr["quiz_staff_temp_q2"].ToString();
                                break;
                            case 3:
                                ans = dr["quiz_staff_temp_q3"].ToString();
                                break;
                            case 4:
                                ans = dr["quiz_staff_temp_q4"].ToString();
                                break;
                            case 5:
                                ans = dr["quiz_staff_temp_q5"].ToString();
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

            usr_ans1 = get_usrquizans(idno, 1);
            usr_ans2 = get_usrquizans(idno, 2);
            usr_ans3 = get_usrquizans(idno, 3);
            usr_ans4 = get_usrquizans(idno, 4);
            usr_ans5 = get_usrquizans(idno, 5);

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
                cmd4.CommandText = "INSERT INTO quiz_staff (quiz_staff_idno, quiz_staff_set, quiz_staff_count, quiz_staff_q1, quiz_staff_q2, quiz_staff_q3, quiz_staff_q4, quiz_staff_q5, quiz_staff_dt, quiz_staff_score) VALUES ('" + idno + "'," + set + ", 1, " + a + "," + b + "," + c + "," + d + "," + f + ", NOW()," + count + ")";
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
                cmd.CommandText = "SELECT * FROM quiz_staff_highscore WHERE quiz_staff_highscore_idno = '" + idno + "'";
                cmd.Connection = conn;

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        high_score = Convert.ToInt32(dr["quiz_staff_highscore_score"].ToString());
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
                        cmd2.CommandText = "UPDATE quiz_staff_highscore SET quiz_staff_highscore_score='" + count + "' WHERE quiz_staff_highscore_idno = '" + idno + "'";
                        cmd2.Connection = conn;

                        cmd2.ExecuteNonQuery();
                    }
                    else
                    {
                        MySqlCommand cmd4 = new MySqlCommand();
                        cmd4.CommandType = CommandType.Text;
                        cmd4.CommandText = "INSERT INTO quiz_staff_highscore (quiz_staff_highscore_idno, quiz_staff_highscore_score) VALUES ('" + idno + "'," + count + ")";
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
                cmd2.CommandText = "DELETE FROM quiz_staff_temp WHERE quiz_staff_temp_idno = '" + idno + "'";
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

            Response.Redirect("UCW_staff_quizdone.aspx?id=" + idno + "&set=" + set);
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("UCW_staff_quiz5.aspx?id=" + idno + "&set=" + set);
        }
    }
}