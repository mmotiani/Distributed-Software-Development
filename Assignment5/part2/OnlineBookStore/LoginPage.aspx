<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoginPage.aspx.cs" Inherits="LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <p style="margin-left: 480px">
            &nbsp;</p>
        <p style="margin-left: 480px">
            &nbsp;</p>
        <p style="margin-left: 480px">
            <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <h1 style="margin-left: 520px">LOGIN</h1>
        <p style="margin-left: 480px">
            <br />
            <br />
            Username:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <br />
            Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            </strong>
        </p>
        <p style="margin-left: 40px">
        </p>
        <p style="margin-left: 480px">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Submit" Width="69px" OnClick="Button1_Click" />
        </p>
        <p style="margin-left: 480px">
            <asp:Button ID="Button2" runat="server" Text="New User Sign Up" Width="210px" OnClick="Button2_Click" />
            <asp:Label ID="Label1" runat="server" ></asp:Label>
        </p>
        <p style="margin-left: 480px">
            &nbsp;</p>
    
    </div>
    </form>
</body>
</html>
