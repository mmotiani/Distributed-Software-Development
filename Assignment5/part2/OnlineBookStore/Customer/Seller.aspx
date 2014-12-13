<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Seller.aspx.cs" Inherits="Customer_Seller" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td colspan="3">
                <asp:Label ID="lblExplain" runat="server" Text="****This page is to again to demontrate Session concepts****"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:Label ID="lblSession" runat="server" Text="****The book details entered here are stored in a session and retrived in the Default.aspx page****"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblTitle" runat="server" Text="Enter Title:"></asp:Label>
            </td>
            <td></td>
            <td>
                <asp:TextBox ID="txtTitle" runat="server" Width="214px"></asp:TextBox>
            </td>
        </tr>
       <%-- <tr>
            <td>
                <asp:Label ID="lblIsbn" runat="server" Text="Enter ISBN:"></asp:Label>
            </td>
            <td></td>
            <td>
                <asp:TextBox ID="txtIsbn" runat="server" Width="212px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblPrice" runat="server" Text="Enter Price:"></asp:Label>
            </td>
            <td></td>
            <td>
                <asp:TextBox ID="txtPrice" runat="server" Width="211px"></asp:TextBox>
            </td>
        </tr>--%>
        <tr>
            <td colspan="3">
                <asp:Button ID="btnSubmit" runat="server" Text="Add to Catalog" OnClick="btnSubmit_Click" />
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
