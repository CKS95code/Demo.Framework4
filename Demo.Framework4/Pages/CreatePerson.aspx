<%-- CreatePerson.aspx --%>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreatePerson.aspx.cs" Inherits="Demo.Framework4.Pages.CreatePerson" %>

<%-- Make sure Inherits matches your namespace and class name --%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Create Person</title>
    <style>
        .form-group {
            margin-bottom: 15px;
        }

        label {
            display: block;
            margin-bottom: 5px;
        }

        .message {
            margin-top: 20px;
            font-weight: bold;
        }

        .success {
            color: green;
        }

        .error {
            color: red;
        }
    </style>
</head>
<body>

    <div>
        <asp:HyperLink NavigateUrl="~/pages/ListPersons.aspx" Text="Annuaire" runat="server" />
        <asp:HyperLink NavigateUrl="~/pages/MyContacts.aspx" Text="My Contacts" runat="server" />
    </div>

    <form id="form1" runat="server">
        <h1>Create Contact</h1>

        <div class="form-group">
            <label for="txtFirstName">First Name:</label>
            <asp:TextBox ID="txtFirstName" runat="server" Width="250px"></asp:TextBox>
            <%-- Add validation controls if needed --%>
            <asp:RequiredFieldValidator ID="rfvFirstName" runat="server"
                ControlToValidate="txtFirstName"
                ErrorMessage="First Name is required."
                ForeColor="Red" Display="Dynamic">*</asp:RequiredFieldValidator>
        </div>

        <div class="form-group">
            <label for="txtLastName">Last Name:</label>
            <asp:TextBox ID="txtLastName" runat="server" Width="250px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvLastName" runat="server"
                ControlToValidate="txtLastName"
                ErrorMessage="Last Name is required."
                ForeColor="Red" Display="Dynamic">*</asp:RequiredFieldValidator>
        </div>

        <div class="form-group">
            <label for="txtEmail">Email:</label>
            <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" Width="250px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvEmail" runat="server"
                ControlToValidate="txtEmail"
                ErrorMessage="Email is required."
                ForeColor="Red" Display="Dynamic">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="revEmail" runat="server"
                ControlToValidate="txtEmail"
                ErrorMessage="Please enter a valid email address."
                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                ForeColor="Red" Display="Dynamic">* Invalid Format</asp:RegularExpressionValidator>
        </div>

        <div class="form-group">
            <asp:Button ID="btnCreate" runat="server" Text="Add Contact" OnClick="btnCreate_Click" />
        </div>

        <div class="message">
            <asp:Label ID="lblMessage" runat="server" EnableViewState="false"></asp:Label>
        </div>

    </form>
</body>
</html>
