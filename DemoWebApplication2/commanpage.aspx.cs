﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWebApplication2
{
    public partial class commanpage : System.Web.UI.Page
    {

        
        protected virtual void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["unmae"] == null)
                {
                    Response.Redirect("login.aspx");
                }
            }
        }
    }
}