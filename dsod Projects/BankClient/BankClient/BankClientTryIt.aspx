<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BankClientTryIt.aspx.cs" Inherits="BankClient.TryIt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #TextArea1 {
            height: 64px;
            width: 528px;
            margin-left: 0px;
        }
    </style>
</head>
<body>
  <center>  <h1>Bank Service to validate the card</h1>
    <form id="form1" runat="server">
        <p
            <strong>&nbsp;</p>
        <p
            <strong><strong>Select card Type</strong></strong></p>
        <asp:Panel ID="Panel1" runat="server">
            <asp:RadioButton ID="RadioButton1" runat="server" name="radio" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Master Card" GroupName="Radio" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton2" runat="server" name="radio" OnCheckedChanged="RadioButton2_CheckedChanged" Text="Visa Card" GroupName="Radio" />
        </asp:Panel>
    <div>
    
        <br />
        <br />
        <strong>Enter Card Number</strong>&nbsp; <asp:TextBox ID="TextBox1" runat="server" Width="215px"></asp:TextBox>
    
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
    
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      <h3>  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  <asp:Label ID="Label1" runat="server" Text=""></asp:Label></h3>
        <p>  &nbsp;</p>
    
    </div>
    </form>
        </center>
    <strong>Note: </strong>For convinience of grader<strong><br />
    For master card:</strong> Card length should be 16 and first digit must be 5 and second digit should be between 1 and 5.<strong> For Visa card: </strong>Card length can be 13 or 16 and first digit must be 4
</body>
</html>
