<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OptQuantityModel.aspx.cs" Inherits="OptQuantityModel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body bgColor="#ffffcc">
		<form id="Form1" method="post" runat="server">
			<asp:label id="Label2" style="Z-INDEX: 101; LEFT: 136px; POSITION: absolute; TOP: 16px" runat="server"
				ForeColor="Blue" Font-Size="X-Large" Font-Underline="True" Font-Bold="True" Width="272px">Optimised Batch Quantity </asp:label>
            &nbsp;
			<asp:RequiredFieldValidator id="rfvqty" style="Z-INDEX: 108; LEFT: 464px; POSITION: absolute; TOP: 128px" runat="server"
				ErrorMessage="Enter model optimum quantity" ControlToValidate="txtOptimumQty"></asp:RequiredFieldValidator>
			<asp:DropDownList id="ddlModelName" style="Z-INDEX: 107; LEFT: 256px; POSITION: absolute; TOP: 80px"
				runat="server" Width="112px" tabIndex="20"></asp:DropDownList>
			<asp:Button id="btnCreateNew" style="Z-INDEX: 106; LEFT: 192px; POSITION: absolute; TOP: 184px"
				runat="server" Width="88px" Text="Create New" BorderStyle="Solid" BackColor="CornflowerBlue"
				BorderColor="#C04000" tabIndex="22" OnClick="btnCreateNew_Click1"></asp:Button>
			<asp:TextBox id="txtOptimumQty" style="Z-INDEX: 105; LEFT: 248px; POSITION: absolute; TOP: 128px"
				runat="server" Width="112px" tabIndex="21"></asp:TextBox>
			<asp:Label id="Label4" style="Z-INDEX: 104; LEFT: 112px; POSITION: absolute; TOP: 128px" runat="server"
				Width="88px" ForeColor="Blue">Optimum Qty</asp:Label>
			<asp:Label id="Label3" style="Z-INDEX: 103; LEFT: 112px; POSITION: absolute; TOP: 80px" runat="server"
				Width="88px" ForeColor="Blue">Model Name</asp:Label>
			<asp:DataGrid id="DataGrid1" style="Z-INDEX: 102; LEFT: 64px; POSITION: absolute; TOP: 248px"
				runat="server" AutoGenerateColumns="False" BackColor="Thistle"
				AllowPaging="True" tabIndex="23" PageSize="5">
				<AlternatingItemStyle BorderWidth="2px" BorderStyle="Solid" BorderColor="DarkViolet" BackColor="DeepSkyBlue"></AlternatingItemStyle>
				<HeaderStyle Font-Bold="True" ForeColor="DeepPink"></HeaderStyle>
				<Columns>
					<asp:EditCommandColumn ButtonType="LinkButton" UpdateText="Update" CancelText="Undo" EditText="Edit">
						<ItemStyle Wrap="False"></ItemStyle>
					</asp:EditCommandColumn>
					<asp:ButtonColumn Text="Delete" CommandName="Delete"></asp:ButtonColumn>
					<asp:BoundColumn DataField="model_no" ReadOnly="True" HeaderText="Model No"></asp:BoundColumn>
					<asp:BoundColumn DataField="model_name" ReadOnly="True" HeaderText="Model Name"></asp:BoundColumn>
					<asp:BoundColumn DataField="opt_qty_of_batch" HeaderText="Optimum Qty"></asp:BoundColumn>
				</Columns>
				<PagerStyle Mode="NumericPages"></PagerStyle>
			</asp:DataGrid>
		</form>
	</body>
</html>
