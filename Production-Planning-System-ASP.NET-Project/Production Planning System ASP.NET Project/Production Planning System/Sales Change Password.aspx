<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Sales Change Password.aspx.cs" Inherits="Sales_Change_Password" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body bottomMargin="0" bgColor="#ffffcc" leftMargin="0" topMargin="0" rightMargin="0">
		<form id="Form1" method="post" runat="server">
			<table cellSpacing="0" cellPadding="0" width="100%" border="0">
				<tr>
					<td style="HEIGHT: 62px" align="center">
                        <img src="images/cooltext51040137.jpg" style="z-index: 111; left: 0px; width: 768px;
                            position: absolute; top: 0px; height: 64px" />
                    </td>
				</tr>
			</table>
			<table cellSpacing="0" cellPadding="0" width="100%" border="0">
				<tr>
					<td width="100%" height="5"></td>
				</tr>
			</table>
			<table cellSpacing="0" cellPadding="0" width="100%" border="1" frame="below">
				<tr>
					<td align="center" style="height: 20px"><asp:hyperlink id="HyperLink1" runat="server" NavigateUrl="SalesOffice.aspx" Font-Names="Trebuchet MS"
							ForeColor="Black" Font-Size="Smaller" Font-Bold="True">Home</asp:hyperlink></td>
					<td width="1" bgColor="#cccccc" style="height: 20px"></td>
					<td align="center" style="height: 20px"><asp:hyperlink id="HyperLink3" runat="server" NavigateUrl="Customer Master.aspx" Font-Names="Trebuchet MS"
							ForeColor="Black" Font-Size="Smaller" Font-Bold="True">Customer Details</asp:hyperlink></td>
					<td width="1" bgColor="#cccccc" style="height: 20px"></td>
					<TD align="center" style="height: 20px"><asp:hyperlink id="Hyperlink6" runat="server" NavigateUrl="IssueOrders.aspx" Font-Names="Trebuchet MS"
							ForeColor="Black" Font-Size="Smaller" Font-Bold="True">Issue Orders</asp:hyperlink></TD>
					<td width="1" bgColor="#cccccc" style="height: 20px"></td>
					<TD align="center" style="height: 20px"><asp:hyperlink id="HyperLink4" runat="server" NavigateUrl="StausOfOrders.aspx" Font-Names="Trebuchet MS"
							ForeColor="Black" Font-Size="Smaller" Font-Bold="True">Orders Status</asp:hyperlink></TD>
					<td width="1" bgColor="#cccccc" style="height: 20px"></td>
					<TD align="center" style="height: 20px"><asp:hyperlink id="Hyperlink2" runat="server" NavigateUrl="Submit Forecast Details.aspx" Font-Names="Trebuchet MS"
							ForeColor="Black" Font-Size="Smaller" Font-Bold="True">Submit Forecast</asp:hyperlink></TD>
					<td width="1" bgColor="#cccccc" style="height: 20px"></td>
					<TD align="center" bgColor="#ffffff" style="height: 20px"><asp:hyperlink id="HyperLink5" runat="server" Font-Names="Trebuchet MS" ForeColor="Black" Font-Size="Smaller"
							Font-Bold="True" NavigateUrl="~/ChangePassword.aspx">Change Password</asp:hyperlink></TD>
					<td width="1" bgColor="#cccccc" style="height: 20px"></td>
					<TD align="center" style="height: 20px"><asp:linkbutton id="LinkButton1" runat="server" Font-Names="Trebuchet MS" ForeColor="Black" Font-Size="Smaller"
							Font-Bold="True">Logout</asp:linkbutton></TD>
				</tr>
			</table>
			<asp:label id="Label2" style="Z-INDEX: 101; LEFT: 232px; POSITION: absolute; TOP: 136px; text-align: center;" runat="server"
				Width="192px" ForeColor="Blue" Font-Size="Large" Font-Bold="True" Font-Underline="True">Change Password</asp:label><asp:label id="Label1" style="Z-INDEX: 102; LEFT: 224px; POSITION: absolute; TOP: 404px" runat="server"
				Width="280px" ForeColor="Red"></asp:label><asp:label id="Label5" style="Z-INDEX: 103; LEFT: 128px; POSITION: absolute; TOP: 192px" runat="server"
				Width="120px" Font-Bold="False" ForeColor="Blue" Height="16px">User Name</asp:label><asp:label id="Label4" style="Z-INDEX: 104; LEFT: 128px; POSITION: absolute; TOP: 236px" runat="server"
				Width="121px" Font-Bold="False" ForeColor="Blue">Current Password</asp:label><asp:label id="Label3" style="Z-INDEX: 105; LEFT: 128px; POSITION: absolute; TOP: 280px" runat="server"
				Width="120px" Font-Bold="False" ForeColor="Blue" Height="16px">New Password</asp:label><asp:textbox id="txtUserName" style="Z-INDEX: 106; LEFT: 272px; POSITION: absolute; TOP: 188px"
				tabIndex="20" runat="server"></asp:textbox><asp:textbox id="txtPassword" style="Z-INDEX: 107; LEFT: 272px; POSITION: absolute; TOP: 236px"
				tabIndex="21" runat="server" TextMode="Password"></asp:textbox>
			<asp:TextBox id="txtNewPassword" style="Z-INDEX: 108; LEFT: 272px; POSITION: absolute; TOP: 284px"
				tabIndex="22" runat="server" TextMode="Password"></asp:TextBox>
			<asp:Button id="btnCancel" style="Z-INDEX: 109; LEFT: 248px; POSITION: absolute; TOP: 340px"
				tabIndex="24" runat="server" Width="72px" Text="Cancel" Height="24px" BorderStyle="Solid"
				BorderColor="#C0C0FF" BackColor="#FFC080"></asp:Button>
			<asp:Button id="btnChange" style="Z-INDEX: 110; LEFT: 344px; POSITION: absolute; TOP: 340px"
				tabIndex="23" runat="server" Width="80px" Text="Change" Height="24px" BorderStyle="Solid"
				BorderColor="#C0C0FF" BackColor="Lime" OnClick="btnChange_Click1"></asp:Button></form>
	</body>
</html>
