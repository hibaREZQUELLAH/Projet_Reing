<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Categories.aspx.cs" Inherits="Categories" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Catégories dans notre base de données sql server :</h1>
            <asp:GridView ID="GridView1" AutoGenerateColumns="false" runat="server">
                <Columns>
                    <asp:BoundField ItemStyle-Width="150px" DataField="code_categorie" HeaderText="Code Catégorie" />
                    <asp:BoundField ItemStyle-Width="150px" DataField="libelle_categorie" HeaderText="Libellé Catégorie" />
                </Columns>

            </asp:GridView>
        </div>
    </form>
</body>
</html>
