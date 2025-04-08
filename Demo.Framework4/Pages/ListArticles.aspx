<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListArticles.aspx.cs" Inherits="Demo.Framework4.Pages.ListArticles" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>List of Persons</title>
    <style>
        body {
            font-family: sans-serif;
        }

        table {
            border-collapse: collapse;
            width: 80%;
            margin-top: 20px;
        }

        th, td {
            border: 1px solid #ddd;
            padding: 8px;
            text-align: left;
        }

        th {
            background-color: #f2f2f2;
        }

        .no-data {
            color: #888;
            margin-top: 20px;
        }

        .nav-link {
            margin-top: 20px;
            display: inline-block;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <h1>Articles disponibles</h1>

        <asp:GridView ID="gvPersons" runat="server" AutoGenerateColumns="False" OnRowCommand="gvPersons_RowCommand" DataKeyNames="Id"
            CellPadding="4" ForeColor="#333333" GridLines="None" Width="80%" EnableViewState="true">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="ProductName" HeaderText="ProductName" SortExpression="ProductName" />
                <asp:BoundField DataField="Price" HeaderText="Prix" SortExpression="Price" DataFormatString="{0:C2}" ItemStyle-Width="100"/>
                <asp:BoundField DataField="Ean13" HeaderText="Ean13" SortExpression="Ean13" />
                <asp:BoundField DataField="ProductDescription" HeaderText="Description" SortExpression="ProductDescription" />
            </Columns>
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="Black" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>

    </form>
</body>
</html>
