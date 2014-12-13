<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RegistrationPage.aspx.cs" Inherits="RegistrationPage" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server"> <title>Registration Page</title> 
    <style>
        h5 {
            text-align:center;
        }
    </style>
</head>
    
<body>
  
	<form id="form1" runat="server">
         
        <p>
          <h1 style="margin-left: 400px">  <strong>&nbsp; Registration Page&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button4" runat="server" Text="HOME" Width="102px" OnClick="Button4_Click" />
              <asp:Button ID="Button3" runat="server" Text="LOGOUT" Width="107px" OnClick="Button3_Click" style="height: 29px" />
              </strong></h1><p style="margin-left: 400px">
            &nbsp;<p style="margin-left: 400px">
            <strong>Username&nbsp;&nbsp;</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"  OnTextChanged="TextBox1_TextChanged1"></asp:TextBox>
        <p style="margin-left: 400px">
            <strong>First Name</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged1"></asp:TextBox>
        <p style="margin-left: 400px">
            <strong>Last Name</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; 
            <asp:TextBox ID="TextBox3" runat="server"  OnTextChanged="TextBox3_TextChanged1"></asp:TextBox>
        <p style="margin-left: 400px">
            <strong>Password</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="TextBox4" runat="server" TextMode="Password"  OnTextChanged="TextBox4_TextChanged1"></asp:TextBox>
        <p style="margin-left: 400px">
            <strong>Confirm Password</strong>&nbsp;&nbsp; &nbsp;
            &nbsp;&nbsp;<asp:TextBox ID="TextBox5" runat="server" TextMode="Password"  OnTextChanged="TextBox5_TextChanged1"></asp:TextBox>
&nbsp;<asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <asp:Button ID="Button2" runat="server" Text="Refresh" Visible="false" Width="88px" OnClick="Button2_Click" />
        <p style="margin-left: 400px">
            <strong>Role:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton1" runat="server" Text="Manager" OnCheckedChanged="RadioButton1_CheckedChanged"  GroupName="Radio" />
            </strong>
        <p style="margin-left: 520px">
            &nbsp;<asp:RadioButton ID="RadioButton2" runat="server" Text="Staff" GroupName="Radio"  OnCheckedChanged="RadioButton2_CheckedChanged" style="font-weight: 700" />
        <p style="margin-left: 440px">    
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;    
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="submit" Width="93px" />
        </p>
        <p style="margin-left: 440px">    
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        </p>
        </p>
         <%--<h3>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <time:page runat="server" /> </h3>--%>   
    </form>

<br/>
<br/>
<br/>
<br/>
<br/>
<br/>

	</body>

    
</html>

