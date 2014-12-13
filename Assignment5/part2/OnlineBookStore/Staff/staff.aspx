<%@ Page Language="C#" AutoEventWireup="true" CodeFile="staff.aspx.cs" Inherits="Staff_staff" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <strong>
        <br />
            <asp:Label ID="lblWelcome" runat="server" Text="WELCOME Staff"></asp:Label> 
        <br />
        </strong>
    <p>
        <br />
    </p>
    <form id="form1" runat="server">
    <p style="margin-left: 640px">
        
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click1" Text="Logout" />
        
        </p>
    <p>
        ADD BOOKS TO CATALOG:</p>
        <p>
            Books:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Value="10">Software Engineering</asp:ListItem>
                <asp:ListItem Value="20">Service-Oriented Software Development</asp:ListItem>
                <asp:ListItem Value="30">Mobile Computing</asp:ListItem>
                <asp:ListItem Value="40">Database</asp:ListItem>
                <asp:ListItem Value="50">Data Mining</asp:ListItem>
                <asp:ListItem Value="10">Software Design</asp:ListItem>
                <asp:ListItem Value="25">BOOK7</asp:ListItem>
                <asp:ListItem Value="35">BOOK8</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            Quantity:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Add to catalog" OnClick="Button1_Click" />
        </p>
    <%--<div>
    <home:staffPage runat = "server" />
    </div>--%>
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </form>
</body>
</html>
