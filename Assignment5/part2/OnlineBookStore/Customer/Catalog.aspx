<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Catalog.aspx.cs" Inherits="Customer_Catalog" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <strong>
                <br />
                <asp:Label ID="lblWelcome" runat="server" Text="WELCOME CUSTOMER "></asp:Label>
                <br />
            </strong>
            <p style="margin-left: 640px">
                <asp:Button ID="btnLogOut" runat="server"  Text="Logout" Width="101px" OnClick="btnLogOut_Click" />
            </p>
            
                <table>
                    <tr>
                        <td colspan="5">
                            <asp:Label ID="lblExplain" runat="server" Text="****This page is to test Session Concepts****"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="5"></td>
                    </tr>
                    <tr>
                        <td colspan="5">
                            <asp:ListBox ID="lstBooks" runat="server" Width="300px" Height="80px"></asp:ListBox>
                        </td>
                    </tr>
                    <tr>
                        <%--<td>
                        <asp:Button ID="btnView" runat="server" Text="View Book Detail" OnClick="btnView_Click" />
                    </td>
                    <td></td>--%>
                        <td>
                            <asp:Button ID="btnAdd" runat="server" Text="Add Book to Catalog" OnClick="btnAdd_Click" Visible="false" />
                        </td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td>
                            <asp:Button ID="btnAddCart" runat="server" Text="Add to Cart" OnClick="btnAddCart_Click" Visible="true" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="5">
                            <asp:Label ID="lblMessage" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="5">
                            <asp:Label ID="lblTitle" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="5">
                            <asp:Label ID="lblIsbn" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblPrice" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>
        </div>
    </form>
</body>
</html>
