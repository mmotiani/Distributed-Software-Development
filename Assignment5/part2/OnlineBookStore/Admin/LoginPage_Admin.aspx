<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoginPage_Admin.aspx.cs" Inherits="LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

<%--<script type="text/C#" runat="server">
      public void Button1_Click(object sender, EventArgs args)
        {
            if (FormsAuthentication.Authenticate(TextBox1.Text, TextBox2.Text))
            {
                Response.Cookies["AdminUser"].Value = TextBox1.Text;
                Response.Redirect("~/Admin/AdminHomePage.aspx");
                
  
                
            }
            else
                Label1.Text = "Denied";
        }
        </script>--%>

</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <p style="margin-left: 480px">
            &nbsp;</p>
        <p style="margin-left: 480px">
            &nbsp;</p>
        <p style="margin-left: 480px">
            <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <h1 style="margin-left: 520px">ADMIN LOGIN</h1>
        <p style="margin-left: 480px">
            <br />
            <br />
            Username:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <br />
            Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            </strong>
        </p>
        <p style="margin-left: 40px">
        </p>
        <p style="margin-left: 480px">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Submit" Width="69px" OnClick="Button1_Click" />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </p>
        <p style="margin-left: 480px">
            &nbsp;</p>
    
    </div>
    </form>
</body>
</html>
