<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Suppliers Form.aspx.cs" Inherits="Suppliers_Form" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body bgColor="#ffffcc">
		<form id="Form1" method="post" runat="server">
			<asp:label id="Label1" style="Z-INDEX: 100; LEFT: 192px; POSITION: absolute; TOP: 16px" runat="server"
				Font-Underline="True" ForeColor="Blue" Width="168px" Height="24px" Font-Size="X-Large">Supplier Details</asp:label><asp:regularexpressionvalidator id="revfax" style="Z-INDEX: 101; LEFT: 456px; POSITION: absolute; TOP: 320px" runat="server"
				Width="210px" ErrorMessage="Enter the  fax number in 11 digits " ControlToValidate="txtfaxno" ValidationExpression="\d{11}"></asp:regularexpressionvalidator><asp:regularexpressionvalidator id="revmail" style="Z-INDEX: 102; LEFT: 456px; POSITION: absolute; TOP: 280px" runat="server"
				Width="162px" ErrorMessage="Enter valid E-Mail" ControlToValidate="txtemail" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:regularexpressionvalidator><asp:regularexpressionvalidator id="revphone" style="Z-INDEX: 103; LEFT: 608px; POSITION: absolute; TOP: 232px"
				runat="server" Width="218px" ErrorMessage="Enter the phone number in 11 digits" ControlToValidate="txtphone" ValidationExpression="\d{11}"></asp:regularexpressionvalidator><asp:regularexpressionvalidator id="revcontactphone" style="Z-INDEX: 104; LEFT: 456px; POSITION: absolute; TOP: 424px"
				runat="server" Width="250px" ErrorMessage="Enter contact person phone in 11 digits" ControlToValidate="txtcontactphone" ValidationExpression="\d{11}"></asp:regularexpressionvalidator><asp:requiredfieldvalidator id="rfvfullname" style="Z-INDEX: 105; LEFT: 456px; POSITION: absolute; TOP: 96px"
				runat="server" Width="106px" ErrorMessage="Enter full name" ControlToValidate="txtfull"></asp:requiredfieldvalidator><asp:requiredfieldvalidator id="rfvphone" style="Z-INDEX: 106; LEFT: 440px; POSITION: absolute; TOP: 232px"
				runat="server" Width="162px" ErrorMessage="Enter Phone Number" ControlToValidate="txtphone"></asp:requiredfieldvalidator><asp:requiredfieldvalidator id="rfvcontactname" style="Z-INDEX: 107; LEFT: 456px; POSITION: absolute; TOP: 360px"
				runat="server" Width="178px" ErrorMessage="Enter contact person name" ControlToValidate="txtcontactname"></asp:requiredfieldvalidator><asp:requiredfieldvalidator id="rfvcontactphone" style="Z-INDEX: 108; LEFT: 456px; POSITION: absolute; TOP: 392px"
				runat="server" Width="226px" ErrorMessage="Enter contact person phone number" ControlToValidate="txtcontactphone"></asp:requiredfieldvalidator><asp:datagrid id="DataGrid1" style="Z-INDEX: 109; LEFT: -22px; POSITION: absolute; TOP: 520px" tabIndex="30"
				runat="server" Width="336px" PageSize="5"  AutoGenerateColumns="False" BorderWidth="2px" AllowSorting="True" AllowPaging="True" BorderColor="#C000C0" BackColor="#C0FFC0" BorderStyle="Solid">
				<HeaderStyle Wrap="False" BorderStyle="Solid" BorderColor="#8080FF" BackColor="#FFC080"></HeaderStyle>
				<Columns>
					<asp:BoundColumn DataField="sup_no" ReadOnly="True" HeaderText="No">
						<ItemStyle Width="20px"></ItemStyle>
					</asp:BoundColumn>
					<asp:EditCommandColumn ButtonType="LinkButton" UpdateText="Update" CancelText="Undo" EditText="Change">
						<HeaderStyle Width="50px"></HeaderStyle>
					</asp:EditCommandColumn>
					<asp:ButtonColumn Text="Delete" CommandName="Delete"></asp:ButtonColumn>
					<asp:BoundColumn DataField="sup_name" HeaderText="Name">
						<ItemStyle Width="60px"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="sup_full_name" HeaderText="Full Name">
						<ItemStyle Width="70px"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="sup_address" HeaderText="Address">
						<ItemStyle Width="60px"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="sup_phone" HeaderText="Phone">
						<ItemStyle Width="70px"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="sup_email" HeaderText="Email">
						<ItemStyle Width="60px"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="sup_fax_no" HeaderText="Fax No">
						<ItemStyle Width="70px"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="sup_cont_person_name" HeaderText="Contact Person">
						<ItemStyle Width="60px"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="sup_cont_person_phoneno" HeaderText="Contact person Phone">
						<ItemStyle Width="70px"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="sup_crd_limit_id" HeaderText="Credit Limit ID">
						<ItemStyle Width="60px"></ItemStyle>
					</asp:BoundColumn>
				</Columns>
				<PagerStyle Mode="NumericPages"></PagerStyle>
			</asp:datagrid><asp:button id="btnAssignRole" style="Z-INDEX: 110; LEFT: 280px; POSITION: absolute; TOP: 488px"
				tabIndex="29" runat="server" Width="113px" BorderColor="DodgerBlue" BackColor="PaleTurquoise" BorderStyle="Solid"
				Text="Create New" OnClick="btnAssignRole_Click1"></asp:button><asp:dropdownlist id="ddlcredit" style="Z-INDEX: 111; LEFT: 272px; POSITION: absolute; TOP: 456px"
				tabIndex="28" runat="server" Width="144px" Height="16px"></asp:dropdownlist><asp:textbox id="txtcontactphone" style="Z-INDEX: 112; LEFT: 272px; POSITION: absolute; TOP: 416px"
				tabIndex="27" runat="server" Width="136px" BorderStyle="Ridge" MaxLength="11" Height="16px"></asp:textbox><asp:label id="Label11" style="Z-INDEX: 113; LEFT: 40px; POSITION: absolute; TOP: 456px" runat="server"
				ForeColor="#0000C0" Width="176px" Height="24px">Supplier Credit Limit Rating</asp:label><asp:label id="Label10" style="Z-INDEX: 114; LEFT: 64px; POSITION: absolute; TOP: 416px" runat="server"
				ForeColor="#0000C0" Width="144px" Height="16px">Contact Person Phno</asp:label><asp:textbox id="txtcontactname" style="Z-INDEX: 115; LEFT: 272px; POSITION: absolute; TOP: 368px"
				tabIndex="26" runat="server" Width="136px" BorderStyle="Ridge" MaxLength="50" Height="16px" OnTextChanged="txtcontactname_TextChanged"></asp:textbox><asp:textbox id="txtfaxno" style="Z-INDEX: 116; LEFT: 272px; POSITION: absolute; TOP: 320px"
				tabIndex="25" runat="server" Width="136px" BorderStyle="Ridge" MaxLength="11" Height="16px"></asp:textbox><asp:textbox id="txtemail" style="Z-INDEX: 117; LEFT: 272px; POSITION: absolute; TOP: 280px"
				tabIndex="24" runat="server" Width="136px" BorderStyle="Ridge" MaxLength="50" Height="8px"></asp:textbox><asp:textbox id="txtphone" style="Z-INDEX: 118; LEFT: 272px; POSITION: absolute; TOP: 240px"
				tabIndex="23" runat="server" Width="136px" BorderStyle="Ridge" MaxLength="11" Height="16px"></asp:textbox><asp:label id="Label9" style="Z-INDEX: 119; LEFT: 64px; POSITION: absolute; TOP: 88px" runat="server"
				ForeColor="#0000C0" Width="144px" Height="16px">Full Name</asp:label><asp:textbox id="txtname" style="Z-INDEX: 120; LEFT: 280px; POSITION: absolute; TOP: 56px" tabIndex="20"
				runat="server" Width="136px" BorderStyle="Ridge" MaxLength="50" Height="16px"></asp:textbox>
			<asp:label id="lblcontactname" style="Z-INDEX: 121; LEFT: 64px; POSITION: absolute; TOP: 368px"
				runat="server" Height="16px" Width="144px" ForeColor="#0000C0">Contact Person Name</asp:label>
			<asp:label id="txtfax" style="Z-INDEX: 122; LEFT: 56px; POSITION: absolute; TOP: 320px" runat="server"
				Height="8px" Width="144px" ForeColor="#0000C0">Fax No</asp:label>
			<asp:label id="txtmail" style="Z-INDEX: 123; LEFT: 56px; POSITION: absolute; TOP: 280px" runat="server"
				Height="16px" Width="144px" ForeColor="#0000C0"> Email</asp:label>
			<asp:label id="Label3" style="Z-INDEX: 124; LEFT: 64px; POSITION: absolute; TOP: 56px" runat="server"
				Height="16px" Width="144px" ForeColor="#0000C0">First Name</asp:label>
			<asp:label id="lbladdress" style="Z-INDEX: 125; LEFT: 48px; POSITION: absolute; TOP: 184px"
				runat="server" Height="16px" Width="144px" ForeColor="#0000C0">Address</asp:label>
			<asp:label id="lblphone" style="Z-INDEX: 126; LEFT: 64px; POSITION: absolute; TOP: 240px" runat="server"
				Height="16px" Width="144px" ForeColor="#0000C0"> Phone No</asp:label>
			<asp:textbox id="txtfull" style="Z-INDEX: 127; LEFT: 280px; POSITION: absolute; TOP: 88px" runat="server"
				Width="136px" BorderStyle="Ridge" MaxLength="50" tabIndex="21" Height="8px"></asp:textbox>
			<asp:textbox id="txtaddress" style="Z-INDEX: 128; LEFT: 272px; POSITION: absolute; TOP: 160px"
				runat="server" Height="48px" Width="136px" BorderStyle="Ridge" TextMode="MultiLine" MaxLength="200"
				tabIndex="22"></asp:textbox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtaddress"
                ErrorMessage="RequiredFieldValidator" Style="z-index: 129; left: 464px; position: absolute;
                top: 136px">enter address</asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtname"
                ErrorMessage="RequiredFieldValidator" Style="z-index: 131; left: 448px; position: absolute;
                top: 56px">enter first name</asp:RequiredFieldValidator>
        </form>
	</body>
</html>
