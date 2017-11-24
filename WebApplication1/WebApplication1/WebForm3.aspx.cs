using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            SqlConnection cn = new SqlConnection("data source= .\\SQLSERVER2014; database=MyInfo; Integrated Security=SSPI");
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["MicrosoftExpress"].ConnectionString);
            SqlCommand cm = new SqlCommand("Select * FROM tblInfo WHERE Name = 'Devin'",cn);
            cn.Open();
            GridView1.DataSource = cm.ExecuteReader();
            GridView1.DataBind();
            cn.Close();
        }
    }
}