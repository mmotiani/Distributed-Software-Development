<%@ Page Language="C#" AutoEventWireup="true" CodeFile="manager.aspx.cs" Inherits="Manager_manager" %>

<%@ Register TagPrefix = "home" TagName="managerPage" 
			src="dealOftheDayUserCOntrol.ascx" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p style="margin-left: 640px">
                <asp:Button ID="btnLogOut" runat="server"  Text="Logout" Width="101px" OnClick="btnLogOut_Click"   />
            </p>
    <div>
        <strong>
        <br />
            <asp:Label ID="lblWelcome" runat="server" Text="WELCOME MANAGER.. !!!!!!!!!!!!!!!!"></asp:Label> 
        <br />
        </strong>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="GetDealForTheDay" />
        <br />
        <br />
    <home:managerPage runat = "server" />
    </div>
    </form>
</body>
</html>