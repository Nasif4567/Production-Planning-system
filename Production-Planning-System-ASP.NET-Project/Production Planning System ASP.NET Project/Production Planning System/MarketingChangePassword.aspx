<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MarketingChangePassword.aspx.cs" Inherits="MarketingChangePassword" %>

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
					<td align="center" style="height: 20px"><asp:hyperlink id="HyperLink1" runat="server" Font-Names="Trebuchet MS" ForeColor="Black" Font-Size="Smaller"
							Font-Bold="True" NavigateUrl="Marketing Home.aspx">Home</asp:hyperlink></td>
					<td width="1" bgColor="#cccccc" style="height: 20px"></td>
					<td align="center" style="height: 20px"><asp:hyperlink id="HyperLink3" runat="server" Font-Names="Trebuchet MS" ForeColor="Black" Font-Size="Smaller"
							Font-Bold="True" NavigateUrl="OrderTrends.aspx">Order Trends</asp:hyperlink></td>
					<td width="1" bgColor="#cccccc" style="height: 20px"></td>
					<TD align="center" style="height: 20px"><asp:hyperlink id="Hyperlink6" runat="server" Font-Names="Trebuchet MS" ForeColor="Black" Font-Size="Smaller"
							Font-Bold="True" NavigateUrl="ProcessCustomersOrders.aspx">Process Oredrs</asp:hyperlink></TD>
					<td width="1" bgColor="#cccccc" style="height: 20px"></td>
					<TD align="center" style="height: 20px"><asp:hyperlink id="Hyperlink2" runat="server" Font-Bold="True" Font-Size="Smaller" ForeColor="Black"
							Font-Names="Trebuchet MS" NavigateUrl="~/ForecastReport.aspx">Forecast Report</asp:hyperlink></TD>
					<td width="1" bgcolor="#cccccc" style="height: 20px"></td>
					<TD align="center" bgColor="#ffffff" style="height: 20px"><asp:hyperlink id="HyperLink5" runat="server" Font-Names="Trebuchet MS" ForeColor="Black" Font-Size="Smaller"
							Font-Bold="True" NavigateUrl="~/ChangePassword.aspx">Change Password</asp:hyperlink></TD>
					<td width="1" bgColor="#cccccc" style="height: 20px"></td>
					<TD align="center" style="height: 20px">
						<asp:LinkButton id="LinkButton1" runat="server" Font-Bold="True" Font-Size="Smaller" ForeColor="Black"
							Font-Names="Trebuchet MS">Logout</asp:LinkButton></TD>
				</tr>
			</table>
			<asp:label id="Label2" style="Z-INDEX: 101; LEFT: 272px; POSITION: absolute; TOP: 148px" runat="server"
				Width="192px" ForeColor="Blue" Font-Size="Large" Font-Bold="True" Font-Underline="True">Change Password</asp:label><asp:label id="Label1" style="Z-INDEX: 102; LEFT: 220px; POSITION: absolute; TOP: 404px" runat="server"
				Width="280px" ForeColor="Red"></asp:label><asp:label id="Label5" style="Z-INDEX: 103; LEFT: 176px; POSITION: absolute; TOP: 208px" runat="server"
				Width="120px" Font-Bold="False" ForeColor="Blue" Height="16px">User Name</asp:label>
			<asp:Label id="Label4" style="Z-INDEX: 104; LEFT: 172px; POSITION: absolute; TOP: 252px" runat="server"
				Width="121px" Font-Bold="False" ForeColor="Blue">Current Password</asp:Label>
			<asp:Label id="Label3" style="Z-INDEX: 105; LEFT: 176px; POSITION: absolute; TOP: 296px" runat="server"
				Width="120px" Font-Bold="False" ForeColor="Blue" Height="8px">New Password</asp:Label>
			<asp:TextBox id="txtUserName" style="Z-INDEX: 106; LEFT: 316px; POSITION: absolute; TOP: 212px"
				tabIndex="20" runat="server" Height="16px" Width="136px"></asp:TextBox>
			<asp:TextBox id="txtPassword" style="Z-INDEX: 107; LEFT: 316px; POSITION: absolute; TOP: 252px"
				tabIndex="21" runat="server" TextMode="Password"></asp:TextBox>
			<asp:TextBox id="txtNewPassword" style="Z-INDEX: 108; LEFT: 316px; POSITION: absolute; TOP: 300px"
				tabIndex="22" runat="server" TextMode="Password"></asp:TextBox>
			<asp:Button id="btnCancel" style="Z-INDEX: 109; LEFT: 292px; POSITION: absolute; TOP: 356px"
				tabIndex="24" runat="server" Height="24px" Width="72px" Text="Cancel" BorderStyle="Solid"
				BorderColor="#C0C0FF" BackColor="#FFC080"></asp:Button>
			<asp:Button id="btnChange" style="Z-INDEX: 110; LEFT: 388px; POSITION: absolute; TOP: 356px"
				tabIndex="23" runat="server" Height="24px" Width="80px" Text="Change" BorderStyle="Solid"
				BorderColor="#C0C0FF" BackColor="Lime" OnClick="btnChange_Click1"></asp:Button></form>
	</body>
</html>
