<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cart.aspx.cs" Inherits="Customer_Cart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <p style="margin-left: 640px">
                <asp:Button ID="btnLogOut" runat="server"  Text="Logout" Width="101px" OnClick="btnLogOut_Click"  />
            </p>
    <div>
    <table>
        <tr>
            <td colspan="4">
                <asp:ListBox ID="lstCart" runat="server" Width="300" Height="80"></asp:ListBox>
            </td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:Label ID="lblAmount" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnDelete" runat="server" Text="Remove from Cart" OnClick="btnDelete_Click" />
            </td>
            <td></td>
            <td></td>
            <td>
                <asp:Button ID="btnCheckout" runat="server" Text="Checkout" OnClick="btnCheckout_Click" />
            </td>
            <td>
                <asp:Button ID="btnGoBack" runat="server" Text="Go to Catalog" Visible="false" OnClick="btnGoBack_Click"  />
            </td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:Label ID="lblMessage" runat="server" ></asp:Label>
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
