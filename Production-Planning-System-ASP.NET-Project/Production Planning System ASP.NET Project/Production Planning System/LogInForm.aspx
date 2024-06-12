<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LogInForm.aspx.cs" Inherits="LogInForm" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body bgColor="#ffffcc">
		<form id="Form1" method="post" runat="server">
			<asp:label id="Label2" style="Z-INDEX: 100; LEFT: 316px; POSITION: absolute; TOP: 124px" runat="server"
				ForeColor="Blue" Font-Size="X-Large" Font-Underline="True" Font-Bold="True" Width="120px">LogIn Area</asp:label>
			<asp:Label id="Label1" style="Z-INDEX: 101; LEFT: 184px; POSITION: absolute; TOP: 376px" runat="server"
				Width="384px" ForeColor="#C04000"></asp:Label>
			<asp:Button id="btnLogIn" style="Z-INDEX: 102; LEFT: 256px; POSITION: absolute; TOP: 320px"
				runat="server" Text="LogIn" BorderStyle="Solid" BorderColor="#0000C0" BackColor="LimeGreen"
				tabIndex="3" Width="104px" OnClick="btnLogIn_Click2"></asp:Button>
			<asp:Button id="btnCancel" style="Z-INDEX: 103; LEFT: 384px; POSITION: absolute; TOP: 320px"
				runat="server" Text="Cancel" BorderStyle="Solid" BorderColor="#0000C0" BackColor="LightCoral"
				tabIndex="4" Width="105px"></asp:Button>
			<asp:TextBox id="txtUserName" style="Z-INDEX: 104; LEFT: 344px; POSITION: absolute; TOP: 196px"
				runat="server" tabIndex="1"></asp:TextBox>
			<asp:TextBox id="txtPassword" style="Z-INDEX: 105; LEFT: 344px; POSITION: absolute; TOP: 244px"
				runat="server" TextMode="Password" tabIndex="2" Height="16px" Width="152px"></asp:TextBox>
			<asp:Label id="Label4" style="Z-INDEX: 106; LEFT: 240px; POSITION: absolute; TOP: 196px" runat="server"
				Font-Bold="True" Width="80px" ForeColor="Blue">UserName</asp:Label>
			<asp:Label id="Label3" style="Z-INDEX: 107; LEFT: 240px; POSITION: absolute; TOP: 244px" runat="server"
				Font-Bold="True" Width="80px" ForeColor="Blue">PassWord</asp:Label>
            &nbsp;
			<asp:CheckBox id="chkRemember" style="Z-INDEX: 108; LEFT: 340px; POSITION: absolute; TOP: 280px"
				runat="server" Text="Remember Me"></asp:CheckBox>
            <img src="images/cooltext51040137.jpg" style="z-index: 109; left: 0px; width: 728px;
                position: absolute; top: 0px; height: 48px" />
		</form>
	</body>
</html>
