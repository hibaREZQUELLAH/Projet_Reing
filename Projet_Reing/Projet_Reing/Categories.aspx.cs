using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class About : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        string dbConnectionString = ConfigurationManager.ConnectionStrings["DataBaseConnectionString"].ConnectionString;
        var queryString = "SELECT * FROM categorie";
        var dbConnection = new SqlConnection(dbConnectionString);
        var dataAdapter = new SqlDataAdapter(queryString, dbConnection);
        var commandBuilder = new SqlCommandBuilder(dataAdapter);
        var ds = new DataSet();
        dataAdapter.Fill(ds);
        ListView1.DataSource = ds;
        ListView1.DataBind();
        ListView1.Visible = true;





    }

}