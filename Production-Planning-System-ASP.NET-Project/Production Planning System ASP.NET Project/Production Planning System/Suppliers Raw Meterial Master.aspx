<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Suppliers Raw Meterial Master.aspx.cs" Inherits="Suppliers_Raw_Meterial_Master" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>

<body bgColor="#ffffcc">
		<form id="Form1" method="post" runat="server">
			<asp:Label id="Label1" style="Z-INDEX: 107; LEFT: 48px; POSITION: absolute; TOP: 104px" runat="server"
				Width="96px">Suppliers ID</asp:Label>
			<asp:RequiredFieldValidator id="rfvdays" style="Z-INDEX: 111; LEFT: 368px; POSITION: absolute; TOP: 224px" runat="server"
				ErrorMessage="Enter the estimated supply days" ControlToValidate="txtdays" Width="240px"></asp:RequiredFieldValidator>
			<asp:RegularExpressionValidator id="revdays" style="Z-INDEX: 110; LEFT: 368px; POSITION: absolute; TOP: 184px" runat="server"
				ErrorMessage="Enter the days in Numbers" ControlToValidate="txtdays" ValidationExpression="\d+" Width="200px"></asp:RegularExpressionValidator>
			<asp:datagrid id="DataGrid1" style="Z-INDEX: 109; LEFT: 72px; POSITION: absolute; TOP: 296px"
				tabIndex="34" runat="server" Width="336px" BackColor="#C0FFC0" AllowPaging="True" AllowSorting="True"
				BorderWidth="2px" AutoGenerateColumns="False" OnDeleteCommand="DataGrid1_Delete" BorderColor="#C000C0"
				BorderStyle="Solid" PageSize="5">
				<HeaderStyle Wrap="False" BorderStyle="Solid" BorderColor="#8080FF" BackColor="#FFC080"></HeaderStyle>
				<Columns>
					<asp:BoundColumn DataField="sup_no" ReadOnly="True" HeaderText="sup noD">
						<ItemStyle Width="20px"></ItemStyle>
					</asp:BoundColumn>
					<asp:EditCommandColumn ButtonType="LinkButton" UpdateText="Update" CancelText="Undo" EditText="Change">
						<HeaderStyle Width="50px"></HeaderStyle>
					</asp:EditCommandColumn>
					<asp:ButtonColumn Text="Delete" CommandName="Delete"></asp:ButtonColumn>
					<asp:BoundColumn DataField="raw_material_id"  ReadOnly =True HeaderText="Raw meterial id">
						<ItemStyle Width="60px"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="Estimated_supply_days" HeaderText="estimated supply days">
						<ItemStyle Width="70px"></ItemStyle>
					</asp:BoundColumn>
				</Columns>
				<PagerStyle Mode="NumericPages"></PagerStyle>
			</asp:datagrid>
			<asp:Label id="Label4" style="Z-INDEX: 108; LEFT: 40px; POSITION: absolute; TOP: 32px" runat="server"
				ForeColor="Navy" Font-Underline="True" Font-Bold="True" Font-Size="Large" tabIndex="10">Suppliers Raw Meterial Master</asp:Label>
			<asp:DropDownList id="ddlsupid" style="Z-INDEX: 106; LEFT: 200px; POSITION: absolute; TOP: 104px"
				runat="server" Width="96px" tabIndex="30"></asp:DropDownList>
			<asp:DropDownList id="ddlrawid" style="Z-INDEX: 105; LEFT: 200px; POSITION: absolute; TOP: 144px"
				runat="server" Width="96px" tabIndex="31"></asp:DropDownList>
			<asp:TextBox id="txtdays" style="Z-INDEX: 104; LEFT: 200px; POSITION: absolute; TOP: 184px" runat="server"
				tabIndex="32" MaxLength="8"></asp:TextBox>
			<asp:Button id="Button1" style="Z-INDEX: 103; LEFT: 136px; POSITION: absolute; TOP: 240px" runat="server"
				Text="Create" Width="106px" BackColor="#00C000" tabIndex="33" OnClick="Button1_Click1"></asp:Button>
			<asp:Label id="Label3" style="Z-INDEX: 102; LEFT: 48px; POSITION: absolute; TOP: 184px" runat="server"
				Width="140px">Etimated Supply Days</asp:Label>
			<asp:Label id="Label2" style="Z-INDEX: 101; LEFT: 48px; POSITION: absolute; TOP: 144px" runat="server"
				Width="105px">Raw Meterial ID</asp:Label>
		</form>
	</body>
</html>
