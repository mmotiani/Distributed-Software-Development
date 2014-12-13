<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TemperatureConversionWebForm.aspx.cs" Inherits="TemperatureConversionWebApplication.TemperatureConversionWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
   <h2><center>Temperature Conversion</center></h2>
        <center>
         
            
    <table>
        <tr>
            <td>
                Enter temperature in Celsius
            </td>
            <td>
                <asp:TextBox ID="TextC" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Button ID="ButtonC2f" runat="server" Text="Convert to F" OnClick="ButtonC2f_Click" />
            </td>
            <td class="auto-style4">
                <asp:Label ID="LabelC2F" runat="server" Text="Result"></asp:Label>
            </td>
        </tr>
    </table>
            <br />
            <br />
            <br />
            <br />

        <table>
        <tr>
            <td class="auto-style1">
                Enter temperature in Farenheit
            </td>
            <td class="auto-style2">
                <asp:TextBox ID="TextF" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Button ID="ButtonF2C" runat="server" Text="Convert to C" OnClick="ButtonF2C_Click" />
            </td>
            <td class="auto-style2">
                <asp:Label ID="LabelF2C" runat="server" Text="Result"></asp:Label>
            </td>
        </tr>
    </table>
        
            </center>
    </form>
</body>
</html>
