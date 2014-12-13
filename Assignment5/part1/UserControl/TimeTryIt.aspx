<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TimeTryIt.aspx.cs" Inherits="TimeTryIt" %>
<%@ Register TagPrefix="time" TagName="page" 
			src="time.ascx" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server"> <title>User Control</title> 
    <style>
        h5 {
            text-align:center;
        }
    </style>
</head>
    
<body>
  
	<form id="form1" runat="server">
         
        <p>
          <h1 style="margin-left: 400px">  <strong>&nbsp; Registration Page</strong></h1><p style="margin-left: 400px">
         &nbsp;<p style="margin-left: 400px">
            <strong>Username&nbsp;&nbsp;</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" required="required" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <p style="margin-left: 400px">
            <strong>Email Id&nbsp;</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox2" type="email" required="required" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        <p style="margin-left: 400px">
            <strong>Password&nbsp;</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; <asp:TextBox ID="TextBox3" type="password" required="required" runat="server" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
        <p style="margin-left: 400px">
            <strong>Confirm Password</strong>&nbsp;&nbsp; <asp:TextBox ID="TextBox4" type="password" required="required" runat="server" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
        <p style="margin-left: 440px">    
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;    
            <asp:Button ID="Button1" runat="server" Text="Submit" Width="93px" OnClick="Button1_Click" />
        </p>
        </p>
          <h3>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <time:page runat="server" /> </h3>   
    </form>

<br/>
<br/>
<br/>
<br/>
<br/>
<br/>

<p><a href="http://webstrar5.fulton.asu.edu/ServiceDirectory.html"> CLICK HERE TO GO ON SERVICE DIRECTORY</a></p>

<p><b>Note:</b> Message displayed below the submit button will change dynamically according to system time.</p>
	</body><br/>
<p><b>For convinience of Graders:</b> <br/>(i)  Please click on the button instead of hitting enter.<br/>(ii) After successful registration, please go on the main service directory to test the user control page again instead of going back or refreshing the page because of security reasons. </p>
    
</html>

