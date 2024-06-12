<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SalesOffice.aspx.cs" Inherits="SalesOffice" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body bottomMargin="0" bgColor="#ffffcc" leftMargin="0" topMargin="0" rightMargin="0">
		<form id="Form1" method="post" runat="server">
			<asp:label id="lblmsg" style="Z-INDEX: 100; LEFT: 160px; POSITION: absolute; TOP: 296px" runat="server"
				Width="464px" Font-Bold="True" Font-Size="Large" ForeColor="Green" Font-Names="Trebuchet MS">You do not have any messages right now</asp:label>
            <img src="images/cooltext51040137.jpg" style="z-index: 108; left: 0px; width: 776px;
                position: absolute; top: 0px; height: 72px" />
            <asp:TextBox ID="TextBox1" runat="server" Style="left: 0px; position: relative; top: 136px; z-index: 102;" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
			<table cellSpacing="0" cellPadding="0" width="100%" border="0">
				<tr>
					<td style="HEIGHT: 62px" align="center"></td>
				</tr>
			</table>
			<table cellSpacing="0" cellPadding="0" width="100%" border="0">
				<tr>
					<td width="100%" height="5"></td>
				</tr>
			</table>
			<table cellSpacing="0" cellPadding="0" width="100%" border="1" frame="below">
				<tr>
					<td align="center" bgColor="#ffffff" style="height: 20px"><asp:hyperlink id="HyperLink1" runat="server" Font-Bold="True" Font-Size="Smaller" ForeColor="Black"
							Font-Names="Trebuchet MS">Home</asp:hyperlink></td>
					<td width="1" bgColor="#cccccc" style="height: 20px"></td>
					<td align="center" style="height: 20px"><asp:hyperlink id="HyperLink3" runat="server" Font-Bold="True" Font-Size="Smaller" ForeColor="Black"
							Font-Names="Trebuchet MS" NavigateUrl="Customer Master.aspx">Customer Details</asp:hyperlink></td>
					<td width="1" bgColor="#cccccc" style="height: 20px"></td>
					<TD align="center" style="height: 20px"><asp:hyperlink id="Hyperlink6" runat="server" Font-Bold="True" Font-Size="Smaller" ForeColor="Black"
							Font-Names="Trebuchet MS" NavigateUrl="IssueOrders.aspx">Issue Orders</asp:hyperlink></TD>
					<td width="1" bgColor="#cccccc" style="height: 20px"></td>
					<TD align="center" style="height: 20px"><asp:hyperlink id="HyperLink4" runat="server" Font-Bold="True" Font-Size="Smaller" ForeColor="Black"
							Font-Names="Trebuchet MS" NavigateUrl="StausOfOrders.aspx">Orders Status</asp:hyperlink></TD>
					<td width="1" bgColor="#cccccc" style="height: 20px"></td>
					<TD align="center" style="height: 20px"><asp:hyperlink id="Hyperlink2" runat="server" Font-Bold="True" Font-Size="Smaller" ForeColor="Black"
							Font-Names="Trebuchet MS" NavigateUrl="Submit Forecast Details.aspx">Submit Forecast</asp:hyperlink></TD>
					<td width="1" bgColor="#cccccc" style="height: 20px"></td>
					<TD align="center" style="height: 20px"><asp:hyperlink id="HyperLink5" runat="server" Font-Bold="True" Font-Size="Smaller" ForeColor="Black"
							Font-Names="Trebuchet MS" NavigateUrl="~/ChangePassword.aspx">Change Password</asp:hyperlink></TD>
					<td width="1" bgColor="#cccccc" style="height: 20px"></td>
					<TD align="center" style="height: 20px"><asp:linkbutton id="LinkButton1" runat="server" Font-Bold="True" Font-Size="Smaller" ForeColor="Black"
							Font-Names="Trebuchet MS" PostBackUrl="~/LogInForm.aspx">Logout</asp:linkbutton></TD>
				</tr>
			</table>
			<asp:button id="Button1" style="Z-INDEX: 103; LEFT: 416px; POSITION: absolute; TOP: 164px" tabIndex="21"
				runat="server" Width="136px" BackColor="#8080FF" BorderColor="#8080FF" Text="Delete All Message"
				Visible="False" BorderStyle="Solid" OnClick="Button1_Click1"></asp:button><asp:label id="lblmessage" style="Z-INDEX: 104; LEFT: 360px; POSITION: absolute; TOP: 232px"
				runat="server" Width="272px" Height="166px" Visible="False"></asp:label><asp:label id="Label3" style="Z-INDEX: 105; LEFT: 116px; POSITION: absolute; TOP: 160px" runat="server"
				Font-Bold="True" Font-Size="Large" ForeColor="Magenta" Visible="False">You Have Messages</asp:label><asp:datagrid id="DataGrid1" style="Z-INDEX: 106; LEFT: 432px; POSITION: absolute; TOP: 240px"
				tabIndex="20" runat="server" Width="176px" BackColor="#C0FFC0" BorderColor="#C000C0" Visible="False" BorderStyle="Solid" AllowSorting="True" BorderWidth="2px" AutoGenerateColumns="False">
				<HeaderStyle Wrap="False" BorderStyle="Solid" BorderColor="#8080FF" BackColor="#FFC080"></HeaderStyle>
				<Columns>
					<asp:BoundColumn DataField="alert_id" ReadOnly="True" HeaderText="Messange ID">
						<ItemStyle Width="20px"></ItemStyle>
					</asp:BoundColumn>
					<asp:ButtonColumn Text="Show Message" CommandName="Delete"></asp:ButtonColumn>
				</Columns>
				<PagerStyle Mode="NumericPages"></PagerStyle>
			</asp:datagrid>
            <asp:GridView ID="GridView1" runat="server" Style="left: 112px; position: relative;
                top: 120px; z-index: 107;" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None">
                <FooterStyle BackColor="Tan" />
                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                <HeaderStyle BackColor="Tan" Font-Bold="True" />
                <AlternatingRowStyle BackColor="PaleGoldenrod" />
            </asp:GridView>
        </form>
	</body>
</html>
