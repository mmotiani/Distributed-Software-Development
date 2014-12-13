<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ImageVerifier.aspx.cs" Inherits="ImageVerifier" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <p style="margin-left: 240px">
            <br />
            <asp:Button ID="Button2" runat="server" Text="Go to Login Page" OnClick="Button2_Click" />
            <br />
        </p>
    
    </div>
        <asp:Image ID="Image1" runat="server"  style="height: 36px" />
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="SUBMIT" Width="92px" OnClick="Button1_Click" />
    </form>
</body>
</html>
  