<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EmployeeMaster.aspx.cs" Inherits="EmployeeMaster" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body bgColor="#ffffcc">
		<form id="Form1" method="post" runat="server">
			<asp:label id="Label1" style="Z-INDEX: 107; LEFT: 184px; POSITION: absolute; TOP: 16px; text-align: center;" runat="server"
				Height="32px" Width="192px" Font-Size="X-Large" Font-Bold="True" ForeColor="Blue" tabIndex="7">Employee Master</asp:label>
			<asp:RegularExpressionValidator id="revjoining" style="Z-INDEX: 121; LEFT: 472px; POSITION: absolute; TOP: 216px"
				runat="server" ErrorMessage="Enter date of Joining in MM/DD/YYYY format" ControlToValidate="txtDateofJoining"
				Width="352px" ValidationExpression="\d{2}/\d{2}/\d{4}"></asp:RegularExpressionValidator>
			<asp:RequiredFieldValidator id="rfvjoining" style="Z-INDEX: 120; LEFT: 472px; POSITION: absolute; TOP: 184px"
				runat="server" ErrorMessage="Enter date of joining" ControlToValidate="txtDateofJoining" Width="272px"></asp:RequiredFieldValidator>
			<asp:RegularExpressionValidator id="revbirth" style="Z-INDEX: 119; LEFT: 472px; POSITION: absolute; TOP: 152px"
				runat="server" ErrorMessage="Enter date of birth in MM/DD/YYYY format" ControlToValidate="txtDateofBirth" Width="328px"
				ValidationExpression="\d{2}/\d{2}/\d{4}"></asp:RegularExpressionValidator>
			<asp:RequiredFieldValidator id="rfvbirth" style="Z-INDEX: 118; LEFT: 472px; POSITION: absolute; TOP: 128px"
				runat="server" ErrorMessage="Enter date of birth" ControlToValidate="txtDateofBirth" Width="296px"></asp:RequiredFieldValidator>
			<asp:RequiredFieldValidator id="rfvname" style="Z-INDEX: 117; LEFT: 472px; POSITION: absolute; TOP: 88px" runat="server"
				ErrorMessage="Enter employee name" ControlToValidate="txtEmpName"></asp:RequiredFieldValidator>
			<asp:Label id="Label8" style="Z-INDEX: 114; LEFT: 288px; POSITION: absolute; TOP: 120px" tabIndex="7"
				runat="server" Width="128px" Height="24px">MM/DD/YYYYY</asp:Label>
			<asp:datagrid id="DataGrid1" style="Z-INDEX: 113; LEFT: 32px; POSITION: absolute; TOP: 400px"
				tabIndex="27" runat="server" Width="336px" BorderColor="#C000C0" BackColor="#C0FFC0"
				BorderStyle="Solid" BorderWidth="2px" AutoGenerateColumns="False" OnDeleteCommand="DataGrid1_Delete"
				PageSize="5">
				<HeaderStyle Wrap="False" BorderStyle="Solid" BorderColor="#8080FF" BackColor="#FFC080"></HeaderStyle>
				<Columns>
					<asp:BoundColumn DataField="Emp_Name" HeaderText="Name">
						<ItemStyle Width="60px"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="emp_dob" HeaderText="Date of Birth">
						<ItemStyle Width="90px"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="emp_doj" HeaderText="Date of Joining">
						<ItemStyle Width="60px"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="Desig_ID" HeaderText="Desig ID">
						<ItemStyle Width="90px"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="Dept_ID" HeaderText="Dept ID">
						<ItemStyle Width="90px"></ItemStyle>
					</asp:BoundColumn>
				</Columns>
				<PagerStyle Mode="NumericPages"></PagerStyle>
			</asp:datagrid><asp:dropdownlist id="ddldept" style="Z-INDEX: 112; LEFT: 288px; POSITION: absolute; TOP: 280px" runat="server"
				Height="24px" Width="136px" tabIndex="24"></asp:dropdownlist><asp:textbox id="txtDateofBirth" style="Z-INDEX: 111; LEFT: 288px; POSITION: absolute; TOP: 152px"
				runat="server" Height="24px" Width="128px" BorderStyle="Ridge" tabIndex="21" MaxLength="10"></asp:textbox><asp:textbox id="txtEmpName" style="Z-INDEX: 110; LEFT: 288px; POSITION: absolute; TOP: 80px"
				runat="server" Height="24px" Width="128px" BorderStyle="Ridge" MaxLength="30" tabIndex="20"></asp:textbox><asp:button id="btncremp" style="Z-INDEX: 106; LEFT: 216px; POSITION: absolute; TOP: 368px"
				runat="server" Height="24" Width="144px" BorderColor="DodgerBlue" BorderStyle="Solid" Text="Create New Employee" BackColor="LightSteelBlue" tabIndex="26" OnClick="btncremp_Click1"></asp:button>
            &nbsp;&nbsp;
            <asp:dropdownlist id="ddlDesig" style="Z-INDEX: 109; LEFT: 288px; POSITION: absolute; TOP: 240px"
				runat="server" Height="40px" Width="136px" tabIndex="23"></asp:dropdownlist><asp:label id="Label7" style="Z-INDEX: 108; LEFT: 112px; POSITION: absolute; TOP: 280px" runat="server"
				Height="24px" Width="128px" ForeColor="#0000C0" tabIndex="7">Dept ID</asp:label><asp:label id="Label3" style="Z-INDEX: 101; LEFT: 112px; POSITION: absolute; TOP: 80px" runat="server"
				Height="24px" Width="128px" ForeColor="#0000C0" tabIndex="7">EmpName</asp:label><asp:label id="Label4" style="Z-INDEX: 102; LEFT: 112px; POSITION: absolute; TOP: 152px" runat="server"
				Height="24px" Width="128px" ForeColor="#0000C0" tabIndex="7">Emp Dob</asp:label><asp:label id="Label5" style="Z-INDEX: 103; LEFT: 112px; POSITION: absolute; TOP: 240px" runat="server"
				Height="24px" Width="128px" ForeColor="#0000C0" tabIndex="7">Designation ID</asp:label><asp:label id="Label6" style="Z-INDEX: 104; LEFT: 112px; POSITION: absolute; TOP: 192px" runat="server"
				Height="24px" Width="128px" ForeColor="#0000C0" tabIndex="7">Date Of Joining</asp:label><asp:textbox id="txtDateofJoining" style="Z-INDEX: 105; LEFT: 288px; POSITION: absolute; TOP: 192px"
				runat="server" Height="24px" Width="128px" BorderStyle="Ridge" tabIndex="22" MaxLength="10" OnTextChanged="txtDateofJoining_TextChanged"></asp:textbox></form>
	</body>
</html>
