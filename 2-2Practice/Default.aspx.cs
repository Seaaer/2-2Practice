﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2_2Practice {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
           
            int num = 1100;
            if(num % 4 == 0)
            {
                if (num % 100 == 0)
                {
                    if (num % 400 == 0)
                    {
                        Response.Write("Y");
                    }
                    else
                    {
                        Response.Write("N");
                    }
                }
                else
                {
                    Response.Write("Y");
                }
                
            }else
                Response.Write("N");





        }
    }
}