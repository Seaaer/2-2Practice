﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2_2Practice
{
    public partial class ReverseInt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string t = "1254", a = "";
            foreach (char i in t)
            {

                a = i + a;
            }
            Response.Write(a);
        }
    }
}