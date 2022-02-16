using System;
using System.Web.UI;
using System.Data;
using System.IO;
using System.Xml;
using Newtonsoft.Json;
using System.Web.Script.Serialization;


public partial class _Default : Page
{
    private static JavaScriptSerializer json;
    private static JavaScriptSerializer JSON { get { return json ?? (json = new JavaScriptSerializer()); } }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    // By using this method we can convert csv to xml
    protected void CSV_2_XML(object sender, EventArgs e)
    {
        string csvPath = Server.MapPath("~/Files/amazon_product.csv");
        DataTable dt = new DataTable { TableName = "product" };
        dt.Columns.AddRange(new DataColumn[5] { new DataColumn("product_name", typeof(string)),
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
            dt.Rows.Add();
            int i = 0;
            //Execute a loop over the columns.
            foreach (string cell in line.Split(';'))
            {
                dt.Rows[dt.Rows.Count - 1][i] = cell;
                i++;
            }

        }
        //delete header
        DataRow dr = dt.Rows[0];
        dr.Delete();
        dt.WriteXml("C:\\Users\\rezqu\\source\\repos\\Projet_Reing\\Projet_Reing\\Projet_Reing\\Files\\amazon_product.xml");
        label1.Text = "XML file generated";
    }
    protected void XML_2_JSON(object sender, EventArgs e)
    {
        // contenu de fichier XML dans la chaîne des caractères xml
        string xml = File.ReadAllText("C:\\Users\\rezqu\\source\\repos\\Projet_Reing\\Projet_Reing\\Projet_Reing\\Files\\amazon_product.xml");
        XmlDocument doc = new XmlDocument();
        // charger la chaîne dans un fichier de type XmlDocument
        doc.LoadXml(xml);
        // sérialisation du contenu XML de doc en format json
        string json = JsonConvert.SerializeXmlNode(doc);
        // chemin d'accès au  fichier json
        string path = @"C:\Users\rezqu\source\repos\Projet_Reing\Projet_Reing\Projet_Reing\Files\amazon_product.json";
        //exporter les données vers un fichier  json en utilisant TexWriter. 
        using (TextWriter tw = new StreamWriter(path))
        {
            tw.WriteLine(json);
        };
        label2.Text = "JSON file generated";

    }
}