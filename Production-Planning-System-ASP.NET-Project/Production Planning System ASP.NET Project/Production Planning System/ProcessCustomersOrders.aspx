<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProcessCustomersOrders.aspx.cs" Inherits="ProcessCustomersOrders" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body bottomMargin="0" bgColor="#ffffcc" leftMargin="0" topMargin="0" rightMargin="0">
		<form id="Form1" method="post" runat="server">
            <img src="images/cooltext51040137.jpg" style="z-index: 110; left: 0px; width: 768px;
                position: absolute; top: 0px; height: 64px" />
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
					<td align="center"><asp:hyperlink id="HyperLink1" runat="server" Font-Bold="True" Font-Size="Smaller" ForeColor="Black"
							Font-Names="Trebuchet MS" NavigateUrl="Marketing Home.aspx">Home</asp:hyperlink></td>
					<td width="1" bgcolor="#cccccc"></td>
					<td align="center"><asp:hyperlink id="HyperLink3" runat="server" Font-Bold="True" Font-Size="Smaller" ForeColor="Black"
							Font-Names="Trebuchet MS" NavigateUrl="OrderTrends.aspx">Order Trends</asp:hyperlink></td>
					<td width="1" bgcolor="#cccccc"></td>
					<TD align="center" bgcolor="#ffffff"><asp:hyperlink id="Hyperlink6" runat="server" Font-Bold="True" Font-Size="Smaller" ForeColor="Black"
							Font-Names="Trebuchet MS" NavigateUrl="ProcessCustomersOrders.aspx">Process Oredrs</asp:hyperlink></TD>
					<td width="1" bgColor="#cccccc"></td>
					<TD align="center"><asp:hyperlink id="Hyperlink2" runat="server" Font-Bold="True" Font-Size="Smaller" ForeColor="Black"
							Font-Names="Trebuchet MS" NavigateUrl="ForecastReport.aspx">Forecast Report</asp:hyperlink></TD>
					<td width="1" bgcolor="#cccccc"></td>
					<TD align="center"><asp:hyperlink id="HyperLink5" runat="server" Font-Bold="True" Font-Size="Smaller" ForeColor="Black"
							Font-Names="Trebuchet MS" NavigateUrl="MarketingChangePassword.aspx">Change Password</asp:hyperlink></TD>
					<td width="1" bgcolor="#cccccc"></td>
					<TD align="center">
						<asp:LinkButton id="LinkButton1" runat="server" Font-Names="Trebuchet MS" ForeColor="Black" Font-Size="Smaller"
							Font-Bold="True">Logout</asp:LinkButton></TD>
				</tr>
			</table>
			<asp:label id="Label2" style="Z-INDEX: 101; LEFT: 200px; POSITION: absolute; TOP: 132px; text-align: center;" runat="server"
				ForeColor="Blue" Font-Size="Large" Font-Underline="True" Font-Bold="True" Width="280px">Process Customer's Orders</asp:label><asp:label id="Label1" style="Z-INDEX: 102; LEFT: 208px; POSITION: absolute; TOP: 192px" runat="server" ForeColor="Blue" Height="16px" Width="88px">Model Name</asp:label><asp:dropdownlist id="ddlModel" style="Z-INDEX: 103; LEFT: 312px; POSITION: absolute; TOP: 192px"
				tabIndex="20" runat="server" Width="120px"></asp:dropdownlist><asp:button id="btnRejectLast" style="Z-INDEX: 104; LEFT: 328px; POSITION: absolute; TOP: 432px"
				tabIndex="22" runat="server" Width="120px" Text="Reject Last Order" BorderColor="Navy" BorderStyle="Solid" BackColor="DodgerBlue" OnClick="btnRejectLast_Click1"></asp:button>
            &nbsp; &nbsp;&nbsp;
            <asp:datagrid id="DataGrid1" style="Z-INDEX: 105; LEFT: 408px; POSITION: absolute; TOP: 256px"
				runat="server" BackColor="Thistle" AutoGenerateColumns="true" Visible="False" >
				<AlternatingItemStyle BorderWidth="2px" BorderStyle="Solid" BorderColor="DarkViolet" BackColor="DeepSkyBlue"></AlternatingItemStyle>
				<HeaderStyle Font-Bold="True" ForeColor="DeepPink"></HeaderStyle>
			</asp:datagrid><asp:button id="Button5" style="Z-INDEX: 106; LEFT: 480px; POSITION: absolute; TOP: 432px" tabIndex="23"
				runat="server" Width="120px" Text="Reject All Orders" BorderColor="Navy" BorderStyle="Groove" BackColor="#FFC0FF" OnClick="Button5_Click1"></asp:button><asp:button id="Button4" style="Z-INDEX: 107; LEFT: 120px; POSITION: absolute; TOP: 432px" tabIndex="21"
				runat="server" Width="184px" Text="process production" BorderColor="Navy" BorderStyle="Groove" BackColor="MediumSeaGreen" OnClick="Button4_Click1"></asp:button><asp:label id="Label6" style="Z-INDEX: 108; LEFT: -240px; POSITION: absolute; TOP: 232px" runat="server"
				Width="88px">Label</asp:label>
            &nbsp;<asp:GridView ID="GridView1" runat="server" BackColor="LightGoldenrodYellow"
                BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None"
                Style="left: 136px; position: relative; top: 128px; z-index: 109;">
                <FooterStyle BackColor="Tan" />
                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                <HeaderStyle BackColor="Tan" Font-Bold="True" />
                <AlternatingRowStyle BackColor="PaleGoldenrod" />
            </asp:GridView>
            </form>
	</body>
</html>
