﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DigitalFeedback_UCW.Module.NonStaff
{
    public partial class UCW_nonstaff_feedbackfinish : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("UCW_nonstaff_quizcheck.aspx");
        }
    }
}