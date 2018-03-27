using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
namespace DemoWebApplication2
{
    public partial class Imageuploaddisplay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            //    if (FileUpload1.PostedFile != null)
            if (FileUpload1.HasFile)
            {
                string FileName = Path.GetFileName(FileUpload1.PostedFile.FileName);
                //Save files to images folder
                FileUpload1.SaveAs(Server.MapPath("Images/" + FileName));
                this.imgDemo.ImageUrl = "Images/" + FileName;
            }
        }
}
}