<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Marketing Home.aspx.cs" Inherits="Marketing_Home" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body bottomMargin="0" bgColor="#ffffcc" leftMargin="0" topMargin="0"
		rightMargin="0">
		<form id="Form1" method="post" runat="server">
			<asp:label id="Label3" style="Z-INDEX: 100; LEFT: 132px; POSITION: absolute; TOP: 164px" runat="server"
				ForeColor="Magenta" Font-Size="Large" Font-Bold="True" Visible="False">You Have Messages</asp:label>
            &nbsp;
			<asp:button id="Button1" style="Z-INDEX: 101; LEFT: 416px; POSITION: absolute; TOP: 164px" tabIndex="21"
				runat="server" Width="136px" Visible="False" BackColor="#8080FF" BorderColor="#8080FF" BorderStyle="Solid"
				Text="Delete All Message" OnClick="Button1_Click1"></asp:button>
            <img src="images/cooltext51040137.jpg" style="z-index: 106; left: 24px; width: 752px;
                position: absolute; top: 0px; height: 80px" />
			<asp:label id="lblmessage" style="Z-INDEX: 103; LEFT: 368px; POSITION: absolute; TOP: 236px"
				runat="server" Height="166px" Width="272px" Visible="False"></asp:label>
			<asp:label id="lblmsg" style="Z-INDEX: 104; LEFT: 156px; POSITION: absolute; TOP: 316px" runat="server"
				Width="464px" Font-Names="Trebuchet MS" ForeColor="Green" Font-Size="Large" Font-Bold="True">You do not have any messages right now</asp:label>
			<table border="0" cellpadding="0" cellspacing="0" width="100%">
				<tr>
					<td align="center" style="HEIGHT: 62px">
                        &nbsp;</td>
				</tr>
			</table>
			<table width="100%" border="0" cellpadding="0" cellspacing="0">
				<tr>
					<td width="100%" height="5">
					</td>
				</tr>
			</table>
			<table cellSpacing="0" cellPadding="0" width="100%" border="1" frame="below">
				<tr>
					<td align="center" bgcolor="#ffffff"><asp:hyperlink id="HyperLink1" runat="server" Font-Bold="True" Font-Size="Smaller" ForeColor="Black"
							Font-Names="Trebuchet MS">Home</asp:hyperlink></td>
					<td width="1" bgcolor="#cccccc"></td>
					<td align="center"><asp:hyperlink id="HyperLink3" runat="server" Font-Bold="True" Font-Size="Smaller" ForeColor="Black"
							Font-Names="Trebuchet MS" NavigateUrl="OrderTrends.aspx">Order Trends</asp:hyperlink></td>
					<td width="1" bgcolor="#cccccc"></td>
					<TD align="center"><asp:hyperlink id="Hyperlink6" runat="server" Font-Bold="True" Font-Size="Smaller" ForeColor="Black"
							Font-Names="Trebuchet MS" NavigateUrl="ProcessCustomersOrders.aspx">Process Oredrs</asp:hyperlink></TD>
					<td width="1" bgcolor="#cccccc"></td>
					<TD align="center"><asp:hyperlink id="Hyperlink2" runat="server" Font-Bold="True" Font-Size="Smaller" ForeColor="Black"
							Font-Names="Trebuchet MS" NavigateUrl="ForecastReport.aspx">Forecast Report</asp:hyperlink></TD>
					<td width="1" bgcolor="#cccccc"></td>
					<TD align="center"><asp:hyperlink id="HyperLink5" runat="server" Font-Bold="True" Font-Size="Smaller" ForeColor="Black"
							Font-Names="Trebuchet MS" NavigateUrl="~/ChangePassword.aspx">Change Password</asp:hyperlink></TD>
					<td width="1" bgcolor="#cccccc"></td>
					<TD align="center">
						<asp:LinkButton id="LinkButton1" runat="server" Font-Names="Trebuchet MS" ForeColor="Black" Font-Size="Smaller"
							Font-Bold="True" PostBackUrl="~/LogInForm.aspx">Logout</asp:LinkButton></TD>
				</tr>
			</table>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2"
                DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="None" PageSize="5"
                Style="left: 48px; position: relative; top: 200px; z-index: 105;">
                <FooterStyle BackColor="Tan" />
                <Columns>
                    <asp:BoundField DataField="alert_id" HeaderText="alert_id" InsertVisible="False"
                        ReadOnly="True" SortExpression="alert_id" />
                    <asp:BoundField DataField="sales_office_id" HeaderText="sales_office_id" SortExpression="sales_office_id" />
                    <asp:BoundField DataField="message_alerts" HeaderText="message_alerts" SortExpression="message_alerts" />
                    <asp:BoundField DataField="message_status" HeaderText="message_status" SortExpression="message_status" />
                </Columns>
                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                <HeaderStyle BackColor="Tan" Font-Bold="True" />
                <AlternatingRowStyle BackColor="PaleGoldenrod" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:planningConnectionString9 %>"
                SelectCommand="SELECT * FROM [Alerts]"></asp:SqlDataSource>
		</form>
	</body>
</html>
