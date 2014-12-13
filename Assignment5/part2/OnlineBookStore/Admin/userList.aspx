<%@ Page Language="C#" AutoEventWireup="true" CodeFile="userList.aspx.cs" Inherits="userList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin-left: 800px">
    
        <asp:Button ID="Button1" runat="server" Text="Home" Width="88px" OnClick="Button1_Click1" />
    
        <asp:Button ID="Button2" runat="server" Text="Logout" Width="81px" OnClick="Button2_Click" />
    
    </div>
        <p>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </p>
    </form>
</body>
</html>
