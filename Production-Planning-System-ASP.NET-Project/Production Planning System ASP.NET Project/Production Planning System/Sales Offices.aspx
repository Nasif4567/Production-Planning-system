<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Sales Offices.aspx.cs" Inherits="Sales_Offices" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body bgColor="#ffffcc">
		<form id="Form1" method="post" runat="server">
			<asp:textbox id="txtfax" style="Z-INDEX: 100; LEFT: 216px; POSITION: absolute; TOP: 264px" runat="server"
				BorderStyle="Ridge" Width="152px" tabIndex="25" MaxLength="11" Height="16px"></asp:textbox>
            <img src="images/cooltext51040137.jpg" style="z-index: 122; left: 0px; width: 832px;
                position: absolute; top: 0px" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtaddress"
                ErrorMessage="RequiredFieldValidator" Style="z-index: 102; left: 416px; position: absolute;
                top: 144px">enter address</asp:RequiredFieldValidator>
			<asp:RegularExpressionValidator id="revfax" style="Z-INDEX: 103; LEFT: 416px; POSITION: absolute; TOP: 264px" runat="server"
				ErrorMessage="Fax number must be in 11 digits" ValidationExpression="\d{11}" ControlToValidate="txtfax" Width="248px"></asp:RegularExpressionValidator>
			<asp:RegularExpressionValidator id="revphone" style="Z-INDEX: 104; LEFT: 552px; POSITION: absolute; TOP: 192px"
				runat="server" ErrorMessage="Phone Number must be in 11 digits" ValidationExpression="\d{11}" ControlToValidate="txtphone"
				Width="288px"></asp:RegularExpressionValidator>
			<asp:RegularExpressionValidator id="revmail" style="Z-INDEX: 105; LEFT: 416px; POSITION: absolute; TOP: 232px" runat="server"
				Width="168px" Height="16px" ErrorMessage="Enter Valid E-Mail " ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
				ControlToValidate="txtemail"></asp:RegularExpressionValidator>
			<asp:RequiredFieldValidator id="rfvname" style="Z-INDEX: 106; LEFT: 416px; POSITION: absolute; TOP: 88px" runat="server"
				ErrorMessage="Enter sales officer name" ControlToValidate="txtname" Width="208px"></asp:RequiredFieldValidator>
			<asp:RequiredFieldValidator id="rfvphone" style="Z-INDEX: 107; LEFT: 416px; POSITION: absolute; TOP: 192px"
				runat="server" ErrorMessage="Enter Phone Number" ControlToValidate="txtphone"></asp:RequiredFieldValidator>
			<asp:datagrid id="DataGrid1" style="Z-INDEX: 108; LEFT: 72px; POSITION: absolute; TOP: 384px"
				tabIndex="28" runat="server" BorderStyle="Solid" Width="384px" BorderColor="#C000C0" BackColor="#C0FFC0"
				PageSize="5"  AutoGenerateColumns="False" BorderWidth="2px"
				AllowSorting="True">
				<HeaderStyle Wrap="False" BorderStyle="Solid" BorderColor="#8080FF" BackColor="#FFC080"></HeaderStyle>
				<Columns>
					<asp:BoundColumn DataField="Sales_office_ID" ReadOnly="True" HeaderText="ID">
						<ItemStyle Width="20px"></ItemStyle>
					</asp:BoundColumn>
					<asp:ButtonColumn Text="Delete" CommandName="Delete"></asp:ButtonColumn>
					<asp:BoundColumn DataField="Sales_Office_Name" HeaderText="Name">
						<ItemStyle Width="60px"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="sales_office_address" HeaderText="Address">
						<ItemStyle Width="120px"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="Sales_Office_Phoneno" HeaderText="Phone">
						<ItemStyle Width="70px"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="Sales_Office_Email" HeaderText="Email">
						<ItemStyle Width="100px"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="sales_office_fax_no" HeaderText="Fax No">
						<ItemStyle Width="70px"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="sales_office_incharge_id" HeaderText="Incharge ID">
						<ItemStyle Width="60px"></ItemStyle>
					</asp:BoundColumn>
				</Columns>
				<PagerStyle NextPageText="" Mode="NumericPages"></PagerStyle>
			</asp:datagrid>
			<asp:Button id="btnAssignRole" style="Z-INDEX: 109; LEFT: 152px; POSITION: absolute; TOP: 344px"
				runat="server" BorderStyle="Solid" Width="113px" BorderColor="DodgerBlue" BackColor="PaleTurquoise"
				Text="Create New" tabIndex="27" OnClick="btnAssignRole_Click1"></asp:Button>
			<asp:textbox id="txtname" style="Z-INDEX: 110; LEFT: 216px; POSITION: absolute; TOP: 88px" runat="server"
				BorderStyle="Ridge" Width="152px" tabIndex="20" MaxLength="50"></asp:textbox>
			<asp:DropDownList id="ddlincharge" style="Z-INDEX: 111; LEFT: 216px; POSITION: absolute; TOP: 304px"
				runat="server" Width="160px" Height="24px" tabIndex="26"></asp:DropDownList>
			<asp:label id="Label8" style="Z-INDEX: 112; LEFT: 64px; POSITION: absolute; TOP: 304px" runat="server"
				Width="97px" Height="24px" ForeColor="#0000C0">Incharge Name</asp:label>
			<asp:label id="Label7" style="Z-INDEX: 113; LEFT: 64px; POSITION: absolute; TOP: 272px" runat="server"
				Width="96px" Height="16px" ForeColor="#0000C0">Fax No</asp:label>
			<asp:label id="Label5" style="Z-INDEX: 114; LEFT: 64px; POSITION: absolute; TOP: 232px" runat="server"
				Width="96px" Height="24px" ForeColor="#0000C0"> Email</asp:label>
			<asp:textbox id="txtemail" style="Z-INDEX: 115; LEFT: 216px; POSITION: absolute; TOP: 232px"
				runat="server" BorderStyle="Ridge" Width="152px" tabIndex="24" MaxLength="50" Height="1px"></asp:textbox>
			<asp:label id="Label1" style="Z-INDEX: 116; LEFT: 128px; POSITION: absolute; TOP: 48px" runat="server"
				Width="200px" Height="32px" Font-Bold="True" Font-Size="X-Large" ForeColor="#0000C0" Font-Underline="True">Sales office Master</asp:label>
			<asp:label id="Label3" style="Z-INDEX: 117; LEFT: 64px; POSITION: absolute; TOP: 88px" runat="server"
				Width="96px" Height="24px" ForeColor="#0000C0"> Name</asp:label>
			<asp:label id="Label4" style="Z-INDEX: 118; LEFT: 64px; POSITION: absolute; TOP: 136px" runat="server"
				Width="96px" Height="24px" ForeColor="#0000C0">Address</asp:label>
			<asp:label id="Label6" style="Z-INDEX: 119; LEFT: 64px; POSITION: absolute; TOP: 200px" runat="server"
				Width="96px" Height="24px" ForeColor="#0000C0"> Phone No</asp:label>
			<asp:textbox id="txtaddress" style="Z-INDEX: 120; LEFT: 216px; POSITION: absolute; TOP: 120px"
				runat="server" BorderStyle="Ridge" Width="152px" Height="48px" TextMode="MultiLine" tabIndex="21"
				MaxLength="200"></asp:textbox>
			<asp:textbox id="txtphone" style="Z-INDEX: 121; LEFT: 216px; POSITION: absolute; TOP: 192px"
				runat="server" BorderStyle="Ridge" Width="152px" Height="16px" tabIndex="23" MaxLength="11"></asp:textbox>
		</form>
	</body>
</html>
