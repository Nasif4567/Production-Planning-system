<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderTrends.aspx.cs" Inherits="OrderTrends" %>

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
                        <img src="images/cooltext51040137.jpg" style="z-index: 112; left: 0px; width: 776px;
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
					<td align="center" style="height: 20px"><asp:hyperlink id="HyperLink1" runat="server" ForeColor="Black" Font-Bold="True" Font-Size="Smaller"
							Font-Names="Trebuchet MS" NavigateUrl="Marketing Home.aspx">Home</asp:hyperlink></td>
					<td width="1" bgColor="#cccccc" style="height: 20px"></td>
					<td align="center" bgColor="#ffffff" style="height: 20px"><asp:hyperlink id="HyperLink3" runat="server" ForeColor="Black" Font-Bold="True" Font-Size="Smaller"
							Font-Names="Trebuchet MS">Order Trends</asp:hyperlink></td>
					<td width="1" bgColor="#cccccc" style="height: 20px"></td>
					<TD align="center" style="height: 20px"><asp:hyperlink id="Hyperlink6" runat="server" ForeColor="Black" Font-Bold="True" Font-Size="Smaller"
							Font-Names="Trebuchet MS" NavigateUrl="ProcessCustomersOrders.aspx">Process Oredrs</asp:hyperlink></TD>
					<td width="1" bgColor="#cccccc" style="height: 20px"></td>
					<TD align="center" style="height: 20px"><asp:hyperlink id="Hyperlink2" runat="server" Font-Bold="True" Font-Size="Smaller" ForeColor="Black"
							Font-Names="Trebuchet MS" NavigateUrl="~/ForecastReport.aspx">Forecast Report</asp:hyperlink></TD>
					<td width="1" bgColor="#cccccc" style="height: 20px"></td>
					<TD align="center" style="height: 20px"><asp:hyperlink id="HyperLink5" runat="server" ForeColor="Black" Font-Bold="True" Font-Size="Smaller"
							Font-Names="Trebuchet MS" NavigateUrl="~/ChangePassword.aspx">Change Password</asp:hyperlink></TD>
					<td width="1" bgColor="#cccccc" style="height: 20px"></td>
					<TD align="center" style="height: 20px">
						<asp:LinkButton id="LinkButton1" runat="server" Font-Names="Trebuchet MS" Font-Size="Smaller" Font-Bold="True"
							ForeColor="Black" PostBackUrl="~/LogInForm.aspx">Logout</asp:LinkButton></TD>
				</tr>
			</table>
			<asp:label id="Label6" style="Z-INDEX: 101; LEFT: 272px; POSITION: absolute; TOP: 280px" runat="server">Total Orders</asp:label><asp:label id="Label5" style="Z-INDEX: 102; LEFT: 164px; POSITION: absolute; TOP: 376px" runat="server"
				ForeColor="Red" Width="441px"></asp:label><asp:label id="Label1" style="Z-INDEX: 103; LEFT: 80px; POSITION: absolute; TOP: 232px" runat="server" ForeColor="Blue" Height="16px" Width="96px">Model Name</asp:label><asp:label id="lblorderqty" style="Z-INDEX: 104; LEFT: 272px; POSITION: absolute; TOP: 312px"
				runat="server" Width="3px"></asp:label><asp:dropdownlist id="ddlmodel" style="Z-INDEX: 105; LEFT: 192px; POSITION: absolute; TOP: 232px"
				tabIndex="21" runat="server" Width="120px"></asp:dropdownlist><asp:label id="Label4" style="Z-INDEX: 106; LEFT: 416px; POSITION: absolute; TOP: 184px" runat="server"
				Width="72px" Font-Bold="True" BorderStyle="None">Alert Text</asp:label><asp:textbox id="txtraise" style="Z-INDEX: 107; LEFT: 408px; POSITION: absolute; TOP: 216px"
				tabIndex="23" runat="server" Width="273px" TextMode="MultiLine" Height="120px"></asp:textbox><asp:button id="btnRaiseAlerts" style="Z-INDEX: 108; LEFT: 584px; POSITION: absolute; TOP: 184px"
				tabIndex="24" runat="server" Width="80px" BorderStyle="Solid" Height="24px" BackColor="Crimson" Text="Raise Alerts" OnClick="btnRaiseAlerts_Click3"></asp:button><asp:button id="btnShowStatus" style="Z-INDEX: 109; LEFT: 112px; POSITION: absolute; TOP: 288px"
				tabIndex="22" runat="server" Width="112px" BorderStyle="Solid" Height="32px" BackColor="PaleTurquoise" Text="Show Status" OnClick="btnShowStatus_Click3" ></asp:button><asp:dropdownlist id="ddlSalesID" style="Z-INDEX: 110; LEFT: 192px; POSITION: absolute; TOP: 192px"
				tabIndex="20" runat="server" Width="128px"></asp:dropdownlist><asp:label id="Label3" style="Z-INDEX: 111; LEFT: 80px; POSITION: absolute; TOP: 192px" runat="server"
				Width="96px" ForeColor="Blue">Sales Office ID</asp:label></form>
	</body>
</html>
