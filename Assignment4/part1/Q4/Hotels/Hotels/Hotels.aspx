<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Hotels.aspx.cs" Inherits="Hotels.Hotels" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <strong>Enter the URL of XML document:</strong></p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" Width="511px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="SUBMIT" Width="104px" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="TextBox2" runat="server" Height="330px" TextMode="MultiLine" Width="559px"></asp:TextBox>
        </p>
        <p style="font-weight: 700">
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <strong>Note: Default: </strong><a href="http://www.public.asu.edu/~mmotiani/Hotels.xml">http://www.public.asu.edu/~mmotiani/Hotels.xml</a></p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
