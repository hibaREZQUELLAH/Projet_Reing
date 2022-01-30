<%@ Page Title="Catégories" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Categories.aspx.cs" Inherits="About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div id="content">
 		<div id="rightColumn">
		</div>
 
 		<div id="leftColumn">
			<h3>Catégories</h3>
            <asp:ListView ID="ListView1" runat="server">
                <EmptyDataTemplate>No Menu Items.</EmptyDataTemplate>
                <ItemSeparatorTemplate></ItemSeparatorTemplate>
                <ItemTemplate>
                    <li>
                       <a href='#'><%# Eval("libelle_categorie") %></a>
                    </li>
                </ItemTemplate>               

                <LayoutTemplate>
                    <ul ID="itemPlaceholderContainer" runat="server" style="font-family: Verdana, Arial, Helvetica, sans-serif;">
                        <li runat="server" id="itemPlaceholder" />
                    </ul>
                    <div style="text-align: left;background-color: #FFCC66;font-family: Verdana, Arial, Helvetica, sans-serif;color: #333333;"></div>
                </LayoutTemplate>
            </asp:ListView>
		</div>
		<div class="clear"></div>
	</div>
</asp:Content>