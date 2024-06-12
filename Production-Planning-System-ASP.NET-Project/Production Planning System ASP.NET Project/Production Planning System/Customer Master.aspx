<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Customer Master.aspx.cs" Inherits="Customer_Master" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body bottomMargin="0" bgColor="#ffffcc" leftMargin="0" topMargin="0" rightMargin="0">
		<form id="Form1" method="post" runat="server">
            <asp:Label ID="Label1" runat="server" ForeColor="Blue" Height="24px" Style="left: 112px;
                position: relative; top: 288px; z-index: 100;" Text="Customer Phone" Width="128px"></asp:Label>
            <asp:Label ID="Label2" runat="server" ForeColor="Blue" Height="24px" Style="left: -22px;
                position: relative; top: 344px; z-index: 101;" Text="Customer Email" Width="128px"></asp:Label>
			<table cellSpacing="0" cellPadding="0" width="100%" border="0" style="z-index: 119; left: 0px; position: absolute; top: 72px">
				<tr>
					<td style="HEIGHT: 3px; width: 729px;" align="center">
                        <img src="images/cooltext51040137.jpg" style="z-index: 119; left: 0px; width: 800px;
                            position: absolute; top: -78px" />
                    </td>
				</tr>
			</table>
			<asp:textbox id="txtfax" style="Z-INDEX: 102; LEFT: 256px; POSITION: absolute; TOP: 392px" tabIndex="24"
				runat="server" Width="152px" MaxLength="11" BorderStyle="Ridge" Height="16px"></asp:textbox><asp:regularexpressionvalidator id="RegularExpressionValidator3" style="Z-INDEX: 103; LEFT: 432px; POSITION: absolute; TOP: 344px"
				runat="server" Width="120px" ControlToValidate="txtemail" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ErrorMessage="Enter valid Email"></asp:regularexpressionvalidator><asp:regularexpressionvalidator id="RegularExpressionValidator2" style="Z-INDEX: 104; LEFT: 432px; POSITION: absolute; TOP: 288px"
				runat="server" Width="264px" ControlToValidate="txtphone" ValidationExpression="\d{11}" ErrorMessage="The Phone Number must be in 11 digits"></asp:regularexpressionvalidator><asp:regularexpressionvalidator id="RegularExpressionValidator1" style="Z-INDEX: 105; LEFT: 432px; POSITION: absolute; TOP: 384px"
				runat="server" Width="176px" ControlToValidate="txtfax" ValidationExpression="\d{11}" ErrorMessage="Enter Fax No in 11 Digits"></asp:regularexpressionvalidator><asp:requiredfieldvalidator id="rfvname" style="Z-INDEX: 106; LEFT: 432px; POSITION: absolute; TOP: 208px" runat="server"
				ControlToValidate="txtname" ErrorMessage="Enter Name"></asp:requiredfieldvalidator><asp:requiredfieldvalidator id="rfvphone" style="Z-INDEX: 107; LEFT: 432px; POSITION: absolute; TOP: 312px"
				runat="server" ControlToValidate="txtphone" ErrorMessage="Enter Phone Numbe"></asp:requiredfieldvalidator><asp:button id="btnAssignRole" style="Z-INDEX: 108; LEFT: 268px; POSITION: absolute; TOP: 432px"
				tabIndex="25" runat="server" Width="113px" BorderStyle="Solid" Text="Create New" BorderColor="DodgerBlue" BackColor="PaleTurquoise" OnClick="btnAssignRole_Click1"></asp:button>
            &nbsp;&nbsp;
            <asp:label id="Label7" style="Z-INDEX: 109; LEFT: 112px; POSITION: absolute; TOP: 384px" runat="server"
				Height="24px" Width="128px" ForeColor="Blue">Fax No</asp:label><asp:label id="Label3" style="Z-INDEX: 110; LEFT: 112px; POSITION: absolute; TOP: 200px" runat="server"
				Height="24px" Width="128px" ForeColor="Blue">Customer Name</asp:label><asp:label id="Label4" style="Z-INDEX: 111; LEFT: 112px; POSITION: absolute; TOP: 240px" runat="server"
				Height="24px" Width="128px" ForeColor="Blue">Customer Addresss</asp:label>
			<table cellSpacing="0" cellPadding="0" border="1" frame="below" style="left: 0px; position: relative; top: 24px; z-index: 118; width: 103%;">
				<tr>
					<td align="center" style="height: 18px"><asp:hyperlink id="HyperLink1" runat="server" NavigateUrl="SalesOffice.aspx" Font-Names="Trebuchet MS"
							ForeColor="Black" Font-Size="Smaller" Font-Bold="True">Home</asp:hyperlink></td>
					<td width="1" bgColor="#cccccc" style="height: 18px"></td>
					<td align="center" bgColor="#ffffff" style="height: 18px"><asp:hyperlink id="HyperLink3" runat="server" Font-Names="Trebuchet MS" ForeColor="Black" Font-Size="Smaller"
							Font-Bold="True">Customer Details</asp:hyperlink></td>
					<td bgColor="#cccccc" style="width: 1px; height: 18px"></td>
					<TD align="center" style="height: 18px"><asp:hyperlink id="Hyperlink6" runat="server" NavigateUrl="IssueOrders.aspx" Font-Names="Trebuchet MS"
							ForeColor="Black" Font-Size="Smaller" Font-Bold="True">Issue Orders</asp:hyperlink></TD>
					<td width="1" bgColor="#cccccc" style="height: 18px"></td>
					<TD align="center" style="height: 18px"><asp:hyperlink id="HyperLink4" runat="server" NavigateUrl="StausOfOrders.aspx" Font-Names="Trebuchet MS"
							ForeColor="Black" Font-Size="Smaller" Font-Bold="True">Orders Status</asp:hyperlink></TD>
					<td bgColor="#cccccc" style="height: 18px"></td>
					<TD align="center" style="height: 18px; width: 137px;"><asp:hyperlink id="Hyperlink2" runat="server" NavigateUrl="Submit Forecast Details.aspx" Font-Names="Trebuchet MS"
							ForeColor="Black" Font-Size="Smaller" Font-Bold="True">Submit Forecast</asp:hyperlink></TD>
					<td bgColor="#cccccc" style="height: 18px"></td>
					<TD align="center" style="height: 18px"><asp:hyperlink id="HyperLink5" runat="server" NavigateUrl="Sales Change Password.aspx" Font-Names="Trebuchet MS"
							ForeColor="Black" Font-Size="Smaller" Font-Bold="True">Change Password</asp:hyperlink></TD>
					<td bgColor="#cccccc" style="height: 18px; width: 1px;"></td>
					<TD align="center" style="height: 18px"></TD>
				</tr>
			</table>
            <asp:TextBox ID="txtname" runat="server" OnTextChanged="TextBox1_TextChanged" Style="left: 256px;
                position: relative; top: 152px; z-index: 112;"></asp:TextBox>
            <asp:TextBox ID="txtemail" runat="server" Style="left: 96px; position: relative;
                top: 296px; z-index: 113;"></asp:TextBox>
            <asp:TextBox ID="txtphone" runat="server" Style="left: -62px; position: relative;
                top: 240px; z-index: 114;"></asp:TextBox>
            <asp:TextBox ID="txtaddress" runat="server" Style="left: -222px; position: relative;
                top: 192px; z-index: 115;"></asp:TextBox>
            <asp:linkbutton id="LinkButton1" runat="server" Font-Names="Trebuchet MS" ForeColor="Black" Font-Size="Smaller"
							Font-Bold="True" style="left: 112px; position: relative; top: 0px; z-index: 116;" OnClick="LinkButton1_Click1" PostBackUrl="~/LogInForm.aspx">Logout</asp:linkbutton>
			<table cellSpacing="0" cellPadding="0" width="100%" border="0" style="z-index: 120; left: 0px; position: absolute; top: 0px">
				<tr>
					<td width="100%" style="height: 1px"></td>
				</tr>
			</table>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtaddress"
                ErrorMessage="RequiredFieldValidator" Style="z-index: 121; left: 432px; position: absolute;
                top: 240px">enter address</asp:RequiredFieldValidator>
			</form>
	</body>
</html>
