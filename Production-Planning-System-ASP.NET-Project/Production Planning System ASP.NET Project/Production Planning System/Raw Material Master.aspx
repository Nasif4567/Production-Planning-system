<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Raw Material Master.aspx.cs" Inherits="Raw_Material_Master" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body bgColor="#ffffcc">
		<form id="Form1" method="post" runat="server">
			<asp:label id="Label1" style="Z-INDEX: 102; LEFT: 160px; POSITION: absolute; TOP: 24px" runat="server"
				Font-Size="X-Large" Height="32px" Width="224px" ForeColor="Blue" Font-Underline="True">Raw Material Master</asp:label>
			<asp:RegularExpressionValidator id="revprice" style="Z-INDEX: 124; LEFT: 448px; POSITION: absolute; TOP: 208px"
				runat="server" ErrorMessage="Digits only" ControlToValidate="txtprice" ValidationExpression="\d+"></asp:RegularExpressionValidator>
			<asp:RegularExpressionValidator id="revreorder" style="Z-INDEX: 123; LEFT: 360px; POSITION: absolute; TOP: 304px"
				runat="server" ErrorMessage="Digits only" ControlToValidate="txtreorder" ValidationExpression="\d+"></asp:RegularExpressionValidator>
			<asp:RegularExpressionValidator id="revmin" style="Z-INDEX: 122; LEFT: 360px; POSITION: absolute; TOP: 272px" runat="server"
				ErrorMessage="Digits only" ControlToValidate="txtmin" ValidationExpression="\d+"></asp:RegularExpressionValidator>
			<asp:RegularExpressionValidator id="revquantity" style="Z-INDEX: 121; LEFT: 464px; POSITION: absolute; TOP: 240px"
				runat="server" ErrorMessage="Digits only" ControlToValidate="txtavail" ValidationExpression="\d+"></asp:RegularExpressionValidator>
			<asp:RequiredFieldValidator id="rfvreorder" style="Z-INDEX: 120; LEFT: 448px; POSITION: absolute; TOP: 304px"
				runat="server" ErrorMessage="Enter reorder level" ControlToValidate="txtreorder"></asp:RequiredFieldValidator>
			<asp:RequiredFieldValidator id="rfvprice" style="Z-INDEX: 119; LEFT: 360px; POSITION: absolute; TOP: 208px"
				runat="server" ErrorMessage="Enter price" ControlToValidate="txtprice"></asp:RequiredFieldValidator>
			<asp:RequiredFieldValidator id="rfvquantity" style="Z-INDEX: 118; LEFT: 360px; POSITION: absolute; TOP: 240px"
				runat="server" ErrorMessage="Enter quantity" ControlToValidate="txtavail"></asp:RequiredFieldValidator>
			<asp:RequiredFieldValidator id="rfvname" style="Z-INDEX: 116; LEFT: 360px; POSITION: absolute; TOP: 96px" runat="server"
				ErrorMessage="Enter raw material name" ControlToValidate="txtname"></asp:RequiredFieldValidator>
			<asp:datagrid id="DataGrid1" style="Z-INDEX: 115; LEFT: 80px; POSITION: absolute; TOP: 432px"
				tabIndex="27" runat="server" Width="336px" BackColor="#C0FFC0" BorderColor="#C000C0" BorderStyle="Solid"
				OnDeleteCommand="DataGrid1_Delete" AutoGenerateColumns="False" BorderWidth="2px" AllowSorting="True"
				AllowPaging="True" PageSize="5">
				<HeaderStyle Wrap="False" BorderStyle="Solid" BorderColor="#8080FF" BackColor="#FFC080"></HeaderStyle>
				<Columns>
					<asp:BoundColumn DataField="raw_material_id" ReadOnly="True" HeaderText="ID">
						<ItemStyle Width="20px"></ItemStyle>
					</asp:BoundColumn>
					<asp:EditCommandColumn ButtonType="LinkButton" UpdateText="Update" CancelText="Undo" EditText="Change">
						<HeaderStyle Width="50px"></HeaderStyle>
					</asp:EditCommandColumn>
					<asp:ButtonColumn Text="Delete" CommandName="Delete"></asp:ButtonColumn>
					<asp:BoundColumn DataField="raw_material_name" HeaderText="Name">
						<ItemStyle Width="60px"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="raw_material_description" HeaderText="Description">
						<ItemStyle Width="90px"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="raw_material_price_unit" HeaderText="price">
						<ItemStyle Width="60px"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="raw_material_quantity_avialable" HeaderText="Quatity Available">
						<ItemStyle Width="90px"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="raw_material_min_stock_level" HeaderText="Min Stock Level">
						<ItemStyle Width="60px"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="raw_material_reorder_level" HeaderText="Reorder Level">
						<ItemStyle Width="90px"></ItemStyle>
					</asp:BoundColumn>
				</Columns>
				<PagerStyle Mode="NumericPages"></PagerStyle>
			</asp:datagrid>
			<asp:button id="btncreatDesig" style="Z-INDEX: 114; LEFT: 192px; POSITION: absolute; TOP: 368px"
				tabIndex="26" runat="server" Width="145px" Height="24px" BorderStyle="Solid" BorderColor="DodgerBlue"
				BackColor="LightSteelBlue" Text="Create Designation" OnClick="btncreatDesig_Click1"></asp:button>
			<asp:TextBox id="txtname" style="Z-INDEX: 113; LEFT: 200px; POSITION: absolute; TOP: 96px" runat="server"
				tabIndex="20"></asp:TextBox>
			<asp:TextBox id="txtdesc" style="Z-INDEX: 112; LEFT: 200px; POSITION: absolute; TOP: 128px" runat="server"
				Width="224px" Height="64px" TextMode="MultiLine" tabIndex="21"></asp:TextBox>
			<asp:TextBox id="txtprice" style="Z-INDEX: 111; LEFT: 200px; POSITION: absolute; TOP: 200px"
				runat="server" tabIndex="22"></asp:TextBox>
			<asp:TextBox id="txtavail" style="Z-INDEX: 110; LEFT: 200px; POSITION: absolute; TOP: 232px"
				runat="server" MaxLength="9" tabIndex="23"></asp:TextBox>
			<asp:TextBox id="txtmin" style="Z-INDEX: 109; LEFT: 200px; POSITION: absolute; TOP: 264px" runat="server"
				MaxLength="9" tabIndex="24"></asp:TextBox>
			<asp:TextBox id="txtreorder" style="Z-INDEX: 108; LEFT: 200px; POSITION: absolute; TOP: 296px"
				runat="server" MaxLength="9" tabIndex="25"></asp:TextBox><asp:label id="Label8" style="Z-INDEX: 107; LEFT: 24px; POSITION: absolute; TOP: 296px" runat="server"
				Height="16px" Width="120px" ForeColor="Blue">Reorder Level</asp:label><asp:label id="Label7" style="Z-INDEX: 106; LEFT: 24px; POSITION: absolute; TOP: 264px" runat="server"
				Height="24px" Width="120px" ForeColor="Blue">Min Stock Level</asp:label><asp:label id="Label5" style="Z-INDEX: 105; LEFT: 24px; POSITION: absolute; TOP: 232px" runat="server"
				Height="24px" Width="120px" ForeColor="Blue">Quantity Avialabale</asp:label><asp:label id="Label3" style="Z-INDEX: 101; LEFT: 24px; POSITION: absolute; TOP: 96px" runat="server"
				Height="24px" Width="120px" ForeColor="Blue"> Name</asp:label><asp:label id="Label4" style="Z-INDEX: 103; LEFT: 24px; POSITION: absolute; TOP: 128px" runat="server"
				Height="24px" Width="120px" ForeColor="Blue">Description</asp:label><asp:label id="Label6" style="Z-INDEX: 104; LEFT: 24px; POSITION: absolute; TOP: 200px" runat="server"
				Height="16px" Width="120px" ForeColor="Blue">Unit Price</asp:label>&nbsp;
			<asp:RequiredFieldValidator id="rfvmin" style="Z-INDEX: 125; LEFT: 456px; POSITION: absolute; TOP: 272px" runat="server"
				Width="144px" ErrorMessage="Enter min stock level" ControlToValidate="txtmin"></asp:RequiredFieldValidator>
		</form>
	</body>
</html>
