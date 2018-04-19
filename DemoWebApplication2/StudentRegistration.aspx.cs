using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DemoWebApplication2
{
    public partial class StudentRegistration : System.Web.UI.Page
    {
        public string photopath;

        private void FillGrid()
        {
            string connStr = ConfigurationManager.ConnectionStrings["PartitionTestConnectionString"].ToString();
            SqlConnection sqlConn = new SqlConnection(connStr);
            SqlDataAdapter da = new SqlDataAdapter("SELECT sno ,sname  ,course,fee,photo1  FROM student", sqlConn);
            DataSet ds = new DataSet();
            da.Fill(ds, "StudentDetails");
            //     ds.Tables["StudentDetails"].PrimaryKey = new DataColumn[] {ds.Tables["StudentDetails"].Columns["sno"] };
            Cache.Insert("Dataset", ds, null, DateTime.Now.AddHours(10), System.Web.Caching.Cache.NoSlidingExpiration);
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                FillGrid();
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
                txtphoto.Text = "Images/" + FileName;
                
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(Page.IsValid)
                { 
                string sql = " INSERT INTO[dbo].[student] ([sno] ,[sname] ,[course] ,[fee] ,[photo1]) VALUES(";
                sql = sql + txtcode.Text.ToString() + ", '" + txtname.Text.ToString() + "','" + txtCourse.Text.ToString() + "', " + txtfees.Text.ToString() + ",'" + txtphoto.Text + "')";
                string strConn = ConfigurationManager.ConnectionStrings["PartitionTestConnectionString"].ToString();
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();

                using (conn)
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandTimeout = 0;
                    int result=cmd.ExecuteNonQuery();
                    Response.Write("<script>alert('Wow data added successfully...')</script>");
                        FillGrid();
                    }
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GridView1.EditIndex = ((GridView)sender).SelectedIndex;
            }
            catch (Exception e1) {
                throw e1;
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {


            try
            {
                if (e.CommandName == "Edit")
                {
                    int index = Convert.ToInt32(e.CommandArgument);

                    //grab the values here
                    Label lbl;

                    lbl = (Label)GridView1.Rows[index].Cells[0].FindControl("lblId");
                    txtcode.Text = lbl.Text;

                    lbl = (Label)GridView1.Rows[index].Cells[1].FindControl("lblsname");
                    txtname.Text = lbl.Text;

                    lbl = (Label)GridView1.Rows[index].Cells[2].FindControl("lblcourse");
                    txtCourse.Text = lbl.Text;

                    lbl = (Label)GridView1.Rows[index].Cells[3].FindControl("lblfee");
                    txtfees.Text = lbl.Text;
                    Image img = (Image)GridView1.Rows[index].Cells[4].FindControl("imgPhoto");
                    imgDemo.ImageUrl = img.ImageUrl;
                    //if accessing TemplateFields then use FindControl method


                }
                else if (e.CommandName == "Delete" || e.CommandName == "Del")
                {
                    Label lbl;
                    //int iNodeId;
                    int index = Convert.ToInt32(e.CommandArgument);

                    lbl = (Label)GridView1.Rows[index].Cells[0].FindControl("lblId");
                    //iNodeId = Convert.ToInt32(lbl.Text);
                    string sql = "delete from student where sno=" + lbl.Text;

                    string strConn = ConfigurationManager.ConnectionStrings["PartitionTestConnectionString"].ToString();
                    SqlConnection conn = new SqlConnection(strConn);
                    conn.Open();

                    using (conn)
                    {
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandTimeout = 0;
                        int result = cmd.ExecuteNonQuery();
                        if(result>=1)
                        Response.Write("<script>alert('data Deleted successfully...')</script>");
                        else
                            Response.Write("<script>alert('There is some issue while deleting data . please contact admin...')</script>");
                            FillGrid();
                    }
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
               
            }
            catch (Exception e1)
            {
                throw e1;

                }


        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            try
            {
                GridView1.EditIndex = e.NewEditIndex;
            }
            catch (Exception e1)
            {
                throw e1;
            }
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
        }
    }
}