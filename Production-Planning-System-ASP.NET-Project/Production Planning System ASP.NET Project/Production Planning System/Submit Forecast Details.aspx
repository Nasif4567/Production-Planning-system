<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Submit Forecast Details.aspx.cs" Inherits="Submit_Forecast_Details" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body bottomMargin="0" bgColor="#ffffcc" leftMargin="0" topMargin="0"
		rightMargin="0">
		<form id="Form1" method="post" runat="server">
			<asp:RegularExpressionValidator id="RegularExpressionValidator2" style="Z-INDEX: 100; LEFT: 704px; POSITION: absolute; TOP: 264px"
				runat="server" Width="72px" ErrorMessage="Digits only" ValidationExpression="\d+" ControlToValidate="txtQty" Height="24px"></asp:RegularExpressionValidator>
			<asp:RegularExpressionValidator id="RegularExpressionValidator1" style="Z-INDEX: 101; LEFT: 704px; POSITION: absolute; TOP: 296px"
				runat="server" ControlToValidate="txtVarience" ValidationExpression="\d+" ErrorMessage="Digits only" Width="72px" Height="24px"></asp:RegularExpressionValidator>
			<asp:dropdownlist id="ddlMonth" style="Z-INDEX: 102; LEFT: 328px; POSITION: absolute; TOP: 160px"
				tabIndex="27" runat="server" Height="24px" Width="136px" AutoPostBack="True">
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
			</asp:dropdownlist>
			<asp:Label id="Label1" style="Z-INDEX: 103; LEFT: 472px; POSITION: absolute; TOP: 336px" runat="server"
				Height="16px" Width="268px" ForeColor="Red"></asp:Label>
			<asp:Label id="Label10" style="Z-INDEX: 104; LEFT: 464px; POSITION: absolute; TOP: 232px" runat="server"
				Width="112px" Height="24px">Model Name</asp:Label>
			<asp:button id="btnAddToOrder" style="Z-INDEX: 105; LEFT: 616px; POSITION: absolute; TOP: 368px"
				tabIndex="30" runat="server" Width="80px" Text="Add" BorderStyle="Solid" BorderColor="Aqua"
				BackColor="CornflowerBlue" Height="32px" OnClick="btnAddToOrder_Click1"></asp:button>
			<asp:label id="Label9" style="Z-INDEX: 106; LEFT: 456px; POSITION: absolute; TOP: 264px" runat="server"
				Height="24px" Width="113px">Predicted Quantity</asp:label>
			<asp:dropdownlist id="ddlModelNo" style="Z-INDEX: 107; LEFT: 584px; POSITION: absolute; TOP: 232px"
				tabIndex="27" runat="server" Height="32px" Width="112px" AutoPostBack="True"></asp:dropdownlist>
			<asp:textbox id="txtQty" style="Z-INDEX: 108; LEFT: 584px; POSITION: absolute; TOP: 264px" tabIndex="29"
				runat="server" Height="16px" Width="112px" MaxLength="4"></asp:textbox>
			<asp:label id="Label3" style="Z-INDEX: 109; LEFT: 240px; POSITION: absolute; TOP: 168px" runat="server"
				Width="69px">Month</asp:label>
			<asp:button id="btnSubmit" style="Z-INDEX: 110; LEFT: 240px; POSITION: absolute; TOP: 376px"
				tabIndex="25" runat="server" Width="96px" Text="Submit" BorderStyle="Solid" BorderColor="#00C000"
				BackColor="#C0FFC0" OnClick="btnSubmit_Click2"></asp:button>
			<asp:datagrid id="DataGrid1" style="Z-INDEX: 111; LEFT: 232px; POSITION: absolute; TOP: 440px"
				tabIndex="31" runat="server" BorderColor="Tan" BackColor="LightGoldenrodYellow" GridLines="None"
				CellPadding="2" BorderWidth="1px" AllowPaging="True" PageSize="5" Width="288px" ForeColor="Black">
				<SelectedItemStyle ForeColor="GhostWhite" BackColor="DarkSlateBlue"></SelectedItemStyle>
				<AlternatingItemStyle BackColor="PaleGoldenrod"></AlternatingItemStyle>
				<HeaderStyle Font-Bold="True" BackColor="Tan"></HeaderStyle>
				<FooterStyle BackColor="Tan"></FooterStyle>
				<PagerStyle NextPageText="Next " PrevPageText="Previous" HorizontalAlign="Center" ForeColor="DarkSlateBlue"
					BackColor="PaleGoldenrod"></PagerStyle>
			</asp:datagrid>
			<asp:button id="Cancel" style="Z-INDEX: 112; LEFT: 360px; POSITION: absolute; TOP: 376px" tabIndex="26"
				runat="server" Width="101px" Text="Cancel" BorderStyle="Solid" BorderColor="Red" BackColor="#FFC080"></asp:button>
			<asp:label id="Label2" style="Z-INDEX: 113; LEFT: 284px; POSITION: absolute; TOP: 120px" runat="server"
				Width="168px" ForeColor="DarkCyan" Font-Size="Large" Font-Bold="True" Font-Underline="True">Forecast Details</asp:label>
            <img src="images/cooltext51040137.jpg" style="z-index: 117; left: 0px; width: 784px;
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
							Font-Names="Trebuchet MS">Home</asp:hyperlink></td>
					<td width="1" bgColor="#cccccc"></td>
					<td align="center"><asp:hyperlink id="HyperLink3" runat="server" Font-Bold="True" Font-Size="Smaller" ForeColor="Black"
							Font-Names="Trebuchet MS" NavigateUrl="Customer Master.aspx">Customer Details</asp:hyperlink></td>
					<td width="1" bgColor="#cccccc"></td>
					<TD align="center"><asp:hyperlink id="Hyperlink6" runat="server" Font-Bold="True" Font-Size="Smaller" ForeColor="Black"
							Font-Names="Trebuchet MS" NavigateUrl="IssueOrders.aspx">Issue Orders</asp:hyperlink></TD>
					<td width="1" bgColor="#cccccc"></td>
					<TD align="center"><asp:hyperlink id="HyperLink4" runat="server" Font-Bold="True" Font-Size="Smaller" ForeColor="Black"
							Font-Names="Trebuchet MS" NavigateUrl="StausOfOrders.aspx">Orders Status</asp:hyperlink></TD>
					<td width="1" bgColor="#cccccc"></td>
					<TD align="center" bgcolor="#ffffff"><asp:hyperlink id="Hyperlink2" runat="server" Font-Bold="True" Font-Size="Smaller" ForeColor="Black"
							Font-Names="Trebuchet MS" NavigateUrl="IssueOrders.aspx">Submit Forecast</asp:hyperlink></TD>
				</tr>
			</table>
            <asp:TextBox ID="txtVarience" runat="server" Style="left: 584px; position: relative;
                top: 192px; z-index: 115;" Width="112px"></asp:TextBox>
            <asp:Label ID="Label4" runat="server" Style="left: 336px; position: relative; top: 192px; z-index: 116;"
                Text="Varience" Width="112px"></asp:Label>
		</form>
	</body>
</html>
