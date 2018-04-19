using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Reporting.WebForms;

namespace DemoWebApplication2
{
    public partial class Reportdemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {

            try
            {
                DataSet ds = new DataSet();
                //if (!Page.IsPostBack)
                //{


                    ReportViewer1.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Local;
                    LocalReport lr = ReportViewer1.LocalReport;
                    ReportViewer1.LocalReport.ReportPath = "Report2.rdlc";
                    string strConn = ConfigurationManager.ConnectionStrings["PartitionTestConnectionString"].ToString();
                    using (SqlConnection conn = new SqlConnection(strConn))
                    {
                        SqlCommand sqlcmd = new SqlCommand("SELECT  [EmpID]       ,[Ename]      ,[DOB]      ,[DOJ]      ,[Gender],      [salary]      ,[bonus]      ,[DeptID]      ,[ManagerID]      ,[status]  FROM[PartitionTest].[dbo].[tblEmployee] where Gender='" + ddGender.SelectedValue + "'", conn);
                        using (SqlDataAdapter da = new SqlDataAdapter(sqlcmd))
                        {


                            da.Fill(ds, "Employees");

                        }
                    }

                    ReportDataSource dsReport = new ReportDataSource();
                    dsReport.Name = "DataSet1";
                    dsReport.Value = ds.Tables["Employees"];
                    lr.DataSources.Add(dsReport);
                    ReportParameter rp = new ReportParameter();
                    rp.Name = "Gender";
                    rp.Values.Add(ddGender.SelectedValue.ToString());
                    lr.SetParameters(new ReportParameter[] { rp });
                lr.Refresh();
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
    }
}