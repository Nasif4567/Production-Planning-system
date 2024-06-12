<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="ChangePassword" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body bgColor="#ffffcc">
		<form id="Form1" method="post" runat="server">
			<asp:label id="Label2" style="Z-INDEX: 100; LEFT: 224px; POSITION: absolute; TOP: 88px; text-align: center;" runat="server"
				ForeColor="Blue" Font-Size="X-Large" Font-Underline="True" Font-Bold="True" Width="192px">Change Password</asp:label>
            <img src="images/cooltext51040137.jpg" style="z-index: 112; left: 0px; width: 760px;
                position: absolute; top: 0px" />
			<asp:Label id="Label1" style="Z-INDEX: 101; LEFT: 152px; POSITION: absolute; TOP: 320px" runat="server"
				Width="280px" ForeColor="Red"></asp:Label>
			<asp:Label id="Label5" style="Z-INDEX: 102; LEFT: 168px; POSITION: absolute; TOP: 152px" runat="server"
				Width="120px" Font-Bold="False" Height="16px" ForeColor="Blue">User Name</asp:Label>
			<asp:Label id="Label4" style="Z-INDEX: 103; LEFT: 168px; POSITION: absolute; TOP: 192px" runat="server"
				Width="121px" Font-Bold="False" ForeColor="Blue">Current Password</asp:Label>
			<asp:Label id="Label3" style="Z-INDEX: 104; LEFT: 168px; POSITION: absolute; TOP: 232px" runat="server"
				Width="120px" Font-Bold="False" Height="16px" ForeColor="Blue">New Password</asp:Label>
			<asp:TextBox id="txtUserName" style="Z-INDEX: 105; LEFT: 328px; POSITION: absolute; TOP: 144px"
				runat="server" tabIndex="20"></asp:TextBox>
			<asp:TextBox id="txtPassword" style="Z-INDEX: 106; LEFT: 328px; POSITION: absolute; TOP: 184px"
				runat="server" tabIndex="21" Height="16px" Width="152px" ReadOnly="True" ToolTip="u r old password"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" PostBackUrl="~/LogInForm.aspx" Style="left: 384px;
                position: relative; top: 264px; z-index: 107;" Text="HOME" Width="88px" CausesValidation="False" />
			<asp:TextBox id="txtNewPassword" style="Z-INDEX: 108; LEFT: 328px; POSITION: absolute; TOP: 232px"
				runat="server" tabIndex="22" TextMode="Password" Height="16px" Width="152px"></asp:TextBox>
			<asp:Button id="btnCancel" style="Z-INDEX: 109; LEFT: 160px; POSITION: absolute; TOP: 280px"
				runat="server" Width="72px" Text="Cancel" Height="24px" BorderStyle="Solid" BorderColor="#C0C0FF"
				BackColor="Yellow" tabIndex="24" OnClick="btnCancel_Click1" CausesValidation="False"></asp:Button>
			<asp:Button id="btnChange" style="Z-INDEX: 110; LEFT: 272px; POSITION: absolute; TOP: 280px"
				runat="server" Width="80px" Text="Change" Height="24px" BorderStyle="Solid" BorderColor="#C0C0FF"
				BackColor="Lime" tabIndex="23" OnClick="btnChange_Click1"></asp:Button>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNewPassword"
                ErrorMessage="RequiredFieldValidator" Style="z-index: 113; left: 496px; position: absolute;
                top: 232px">enter new password</asp:RequiredFieldValidator>
		</form>
	</body>
</html>
