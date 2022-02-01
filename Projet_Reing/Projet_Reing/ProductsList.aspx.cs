using System;
using System.Web.UI;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.IO;


public partial class About : Page
{
  
    protected void Page_Load(object sender, EventArgs e)
    {
        string code_categorie = Request.QueryString["id"];
        string dbConnectionString = ConfigurationManager.ConnectionStrings["DataBaseConnectionString"].ConnectionString;
        var queryString = "SELECT libelle_categorie FROM categorie where code_categorie="+ code_categorie;
        var dbConnection = new SqlConnection(dbConnectionString);
        var dataAdapter = new SqlDataAdapter(queryString, dbConnection);
        var commandBuilder = new SqlCommandBuilder(dataAdapter);
        var ds = new DataTable();
        dataAdapter.Fill(ds);
        var libelle_cat= ds.Rows[0]["libelle_categorie"].ToString();

        System.Diagnostics.Debug.WriteLine(libelle_cat);
        string csvPath = Server.MapPath("~/Files/amazon_product.csv") ;
        DataTable dt = new DataTable();
        dt.Columns.AddRange(new DataColumn[5] { new DataColumn("product", typeof(string)),
            new DataColumn("price", typeof(string)),
            new DataColumn("rating", typeof(string)),
            new DataColumn("url", typeof(string)),
        new DataColumn("category",typeof(string)) });
        //Read the contents of CSV file.
        StreamReader sr = new StreamReader(csvPath);
        string line;
        string[] row = new string[5];
        while ((line = sr.ReadLine()) != null)
        {
            row = line.Split(';');
            string libelle_categorie = row[4];
            if (libelle_categorie.Equals(libelle_cat))
            {
                dt.Rows.Add();
                int i = 0;
                //Execute a loop over the columns.
                foreach (string cell in line.Split(';'))
                {
                    dt.Rows[dt.Rows.Count - 1][i] = cell;
                    i++;
                }

            }
        }
       
        //Bind the DataTable.
        productList.DataSource = dt;
        productList.DataBind();


    }
    



}