using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DemoWebApplication2.Service1;
using DemoWebApplication2.service2;


namespace DemoWebApplication2
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DemoWebServiceSoapClient cls1 = new DemoWebServiceSoapClient();
           Response.Write(Convert.ToString( cls1.mul2num(10, 20))+"<br/>");
            DemoWebService cls2 = new DemoWebService();
            Response.Write(Convert.ToString(cls2.mul2num(20, 2220)) + "<br/>");
        }
    }
}