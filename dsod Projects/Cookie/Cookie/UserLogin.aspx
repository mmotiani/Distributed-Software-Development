<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="Cookie.UserLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <p>
        <br />
    </p>
    <p>
        &nbsp;</p>
    <form id="form1" runat="server">
        <p>
&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" required="required" Width="158px"></asp:TextBox>
        </p>
        <p>
&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Email" type="email"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged" required="required" Width="158px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" Width="86px" />
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Label_User"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Label_Email"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p style="margin-left: 80px">
            &nbsp;</p>
    </form>
</body>
</html>
