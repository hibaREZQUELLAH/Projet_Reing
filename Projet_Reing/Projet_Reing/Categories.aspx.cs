using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class Categories : System.Web.UI.Page
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
        GridView1.DataSource = ds;
        GridView1.DataBind();
        GridView1.Visible = true;


    }
}