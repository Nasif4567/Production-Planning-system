<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ForecastReport.aspx.cs" Inherits="ForecastReport" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=10.2.3600.0, Culture=neutral, PublicKeyToken=692fbea5521e1304"
    Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
</head>
<body bottomMargin="0" bgColor="#ffffcc" leftMargin="0" topMargin="0" rightMargin="0">
		<form id="Form1" method="post" runat="server">
			<table cellSpacing="0" cellPadding="0" width="100%" border="0">
				<tr>
					<td style="HEIGHT: 62px" align="center">
                        <img src="images/cooltext51040137.jpg" style="z-index: 102; left: 0px; width: 768px;
                            position: absolute; top: 0px" />
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
					<td align="center"><asp:hyperlink id="HyperLink1" runat="server" NavigateUrl="Marketing Home.aspx" Font-Bold="True"
							Font-Size="Smaller" ForeColor="Black" Font-Names="Trebuchet MS">Home</asp:hyperlink></td>
					<td width="1" bgColor="#cccccc"></td>
					<td align="center"><asp:hyperlink id="HyperLink3" runat="server" NavigateUrl="OrderTrends.aspx" Font-Bold="True" Font-Size="Smaller"
							ForeColor="Black" Font-Names="Trebuchet MS">Order Trends</asp:hyperlink></td>
					<td width="1" bgColor="#cccccc"></td>
					<TD align="center"><asp:hyperlink id="Hyperlink6" runat="server" NavigateUrl="ProcessCustomersOrders.aspx" Font-Bold="True"
							Font-Size="Smaller" ForeColor="Black" Font-Names="Trebuchet MS">Process Oredrs</asp:hyperlink></TD>
					<td width="1" bgColor="#cccccc"></td>
					<TD align="center" bgColor="#ffffff"><asp:hyperlink id="Hyperlink2" runat="server" NavigateUrl="ForecastReport.aspx" Font-Bold="True"
							Font-Size="Smaller" ForeColor="Black" Font-Names="Trebuchet MS">Forecast Report</asp:hyperlink></TD>
					<td width="1" bgColor="#cccccc"></td>
					<TD align="center"><asp:hyperlink id="HyperLink5" runat="server" NavigateUrl="MarketingChangePassword.aspx" Font-Bold="True"
							Font-Size="Smaller" ForeColor="Black" Font-Names="Trebuchet MS">Change Password</asp:hyperlink></TD>
					<td width="1" bgColor="#cccccc"></td>
					<TD align="center"><asp:linkbutton id="LinkButton1" runat="server" Font-Bold="True" Font-Size="Smaller" ForeColor="Black"
							Font-Names="Trebuchet MS">Logout</asp:linkbutton></TD>
				</tr>
			</table>
			<table height="40" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<tr>
					<td align="right" width="50%"><asp:label id="label1" Runat="server" Visible="False">Select Month and Year: &nbsp </asp:label></td>
					<td align="left" width="50%"><asp:dropdownlist id="ddlMonth" Runat="server" Visible="False">
							<asp:ListItem Value="0">Select Month</asp:ListItem>
							<asp:ListItem Value="1">January</asp:ListItem>
							<asp:ListItem Value="2">February</asp:ListItem>
							<asp:ListItem Value="3">March</asp:ListItem>
							<asp:ListItem Value="4">April</asp:ListItem>
							<asp:ListItem Value="5">May</asp:ListItem>
							<asp:ListItem Value="6">June</asp:ListItem>
							<asp:ListItem Value="7">July</asp:ListItem>
							<asp:ListItem Value="8">August</asp:ListItem>
							<asp:ListItem Value="9">September</asp:ListItem>
							<asp:ListItem Value="10">October</asp:ListItem>
							<asp:ListItem Value="11">November</asp:ListItem>
							<asp:ListItem Value="12">December</asp:ListItem>
						</asp:dropdownlist><asp:dropdownlist id="ddlYear" Runat="server" Visible="False"></asp:dropdownlist></td>
				</tr>
			</table>
			<table height="30" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<tr>
					<td align="center"><asp:button id="btnShow" runat="server" Width="92px" Text="Show Report" OnClick="btnShow_Click1" Visible="False"></asp:button></td>
				</tr>
			</table>
			<table cellSpacing="0" cellPadding="0" width="100%" border="0">
				<tr>
					<td width="40%"></td>
					<td width="5%" height="50"><asp:imagebutton id="First" ImageUrl="Images\first_page.gif" Runat="server" Visible="False"></asp:imagebutton></td>
					<td width="5%" height="50"><asp:imagebutton id="ext" ImageUrl="Images\next_page.gif" Runat="server" Visible="False"></asp:imagebutton></td>
					<td width="5%" height="50"><asp:imagebutton id="Prev" ImageUrl="Images\prev_page.gif" Runat="server" Visible="False"></asp:imagebutton></td>
					<td width="5%" height="50"><asp:imagebutton id="Last" ImageUrl="Images\last_page.gif" Runat="server" Visible="False"></asp:imagebutton></td>
					<td width="40%">
                        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White"
                            BorderWidth="1px" Font-Names="Verdana" Font-Size="X-Small" ForeColor="Black"
                            Height="112px" NextPrevFormat="FullMonth" OnSelectionChanged="Calendar1_SelectionChanged"
                            Width="350px">
                            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                            <TodayDayStyle BackColor="#CCCCCC" />
                            <OtherMonthDayStyle ForeColor="#999999" />
                            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True"
                                Font-Size="12pt" ForeColor="#333399" />
                        </asp:Calendar>
                    </td>
				</tr>
			</table>
			<table width="100%">
				<tr>
					<td align="center" width="100%"></td>
				</tr>
			</table>
            &nbsp;&nbsp;
            <asp:GridView ID="GridView1" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan"
                BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" Style="left: 184px;
                position: relative; top: 32px; z-index: 101;">
                <FooterStyle BackColor="Tan" />
                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                <HeaderStyle BackColor="Tan" Font-Bold="True" />
                <AlternatingRowStyle BackColor="PaleGoldenrod" />
            </asp:GridView>
		</form>
	</body>
</html>
