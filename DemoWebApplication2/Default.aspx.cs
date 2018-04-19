using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWebApplication2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write(HttpContext.Current.Request.UserHostAddress + " " + Request.UserHostName + " " + Request.UserAgent);
            //Response.Write("<br>REMOTE_ADDR=" + Request.ServerVariables["REMOTE_ADDR"]);
            //string myExternalIP;
            //string strHostName = System.Net.Dns.GetHostName();
            //string clientIPAddress = System.Net.Dns.GetHostAddresses(strHostName).GetValue(0).ToString();
            //Response.Write("<br>strHostName=" + strHostName);
            //Response.Write("<br>clientIPAddress=" + clientIPAddress);
            //Response.Write("<script>  alert('"+ clientIPAddress+"'); </script>");
            //Guid gd = Guid.NewGuid();
            //Response.Write("<br>GUID=" + gd.ToString());
        }
    }
} 