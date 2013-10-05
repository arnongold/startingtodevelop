<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Conditions.aspx.cs" Inherits="UsingVariables.Conditions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="Label1" runat="server" Text="Number to check"></asp:Label>
        <br />
        <asp:TextBox ID="txtNumberToCheck" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="checkNumber" runat="server" OnClick="checkNumber_Click" Text="Check" />
        <br />
        <br />
        <asp:Label ID="lblResult" runat="server"></asp:Label>
    </form>
</body>
</html>

