<%@ Page Title="Welcome" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1><%: Title %>.</h1>
        <h2>TechBargains have the best deals on cheap electronics.</h2>
        <p class="lead"></p>
        <asp:Label ID="label1" runat="server" />
            <asp:Button ID="bouton1" Text="CSV_2_XML" OnClick="CSV_2_XML" runat="server" />
          <br /> <br />
    <asp:Label ID="label2" runat="server" />
    <asp:Button ID="Button1" runat="server" Text="XML_2_JSON" OnClick="XML_2_JSON"/>
</asp:Content>