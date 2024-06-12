<%@ Page Language="C#" AutoEventWireup="true" CodeFile="IssueOrders.aspx.cs" Inherits="IssueOrders" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body bottomMargin="0" bgColor="#ffffcc" leftMargin="0" topMargin="0" rightMargin="0">
		<form id="Form1" method="post" runat="server">
			<table cellSpacing="0" cellPadding="0" width="100%" border="0">
				<tr>
					<td style="HEIGHT: 62px" align="center">
                        <img src="images/cooltext51040137.jpg" style="z-index: 121; left: 0px; width: 776px;
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
					<td align="center" style="height: 20px"><asp:hyperlink id="HyperLink1" runat="server" NavigateUrl="SalesOffice.aspx" Font-Names="Trebuchet MS"
							ForeColor="Black" Font-Size="Smaller" Font-Bold="True">Home</asp:hyperlink></td>
					<td width="1" bgColor="#cccccc" style="height: 20px"></td>
					<td align="center" style="height: 20px"><asp:hyperlink id="HyperLink3" runat="server" NavigateUrl="Customer Master.aspx" Font-Names="Trebuchet MS"
							ForeColor="Black" Font-Size="Smaller" Font-Bold="True">Customer Details</asp:hyperlink></td>
					<td width="1" bgColor="#cccccc" style="height: 20px"></td>
					<TD align="center" bgColor="#ffffff" style="height: 20px"><asp:hyperlink id="Hyperlink6" runat="server" Font-Names="Trebuchet MS" ForeColor="Black" Font-Size="Smaller"
							Font-Bold="True">Issue Orders</asp:hyperlink></TD>
					<td width="1" bgColor="#cccccc" style="height: 20px"></td>
					<TD align="center" style="height: 20px"><asp:hyperlink id="HyperLink4" runat="server" NavigateUrl="StausOfOrders.aspx" Font-Names="Trebuchet MS"
							ForeColor="Black" Font-Size="Smaller" Font-Bold="True">Orders Status</asp:hyperlink></TD>
					<td width="1" bgColor="#cccccc" style="height: 20px"></td>
					<TD align="center" style="height: 20px"><asp:hyperlink id="Hyperlink2" runat="server" NavigateUrl="Submit Forecast Details.aspx" Font-Names="Trebuchet MS"
							ForeColor="Black" Font-Size="Smaller" Font-Bold="True">Submit Forecast</asp:hyperlink></TD>
					<td width="1" bgColor="#cccccc" style="height: 20px"></td>
					<TD align="center" style="height: 20px"><asp:hyperlink id="HyperLink5" runat="server" NavigateUrl="~/ChangePassword.aspx" Font-Names="Trebuchet MS"
							ForeColor="Black" Font-Size="Smaller" Font-Bold="True">Change Password</asp:hyperlink></TD>
					<td width="1" bgColor="#cccccc" style="height: 20px"></td>
					<TD align="center" style="height: 20px"><asp:linkbutton id="LinkButton1" runat="server" Font-Names="Trebuchet MS" ForeColor="Black" Font-Size="Smaller"
							Font-Bold="True" PostBackUrl="~/LogInForm.aspx">Logout</asp:linkbutton></TD>
				</tr>
			</table>
			<asp:label id="Label2" style="Z-INDEX: 101; LEFT: 312px; POSITION: absolute; TOP: 128px" runat="server"
				Width="160px" ForeColor="Blue" Font-Size="X-Large" Font-Bold="True" Font-Underline="True">Issue of Orders</asp:label><asp:regularexpressionvalidator id="RegularExpressionValidator2" style="Z-INDEX: 102; LEFT: 688px; POSITION: absolute; TOP: 280px"
				runat="server" Width="72px" ControlToValidate="txtQty" ValidationExpression="\d+" ErrorMessage="Digits only"></asp:regularexpressionvalidator><asp:label id="Label1" style="Z-INDEX: 103; LEFT: 396px; POSITION: absolute; TOP: 376px" runat="server"
				Height="24px" Width="296px" ForeColor="Red"></asp:label><asp:regularexpressionvalidator id="RegularExpressionValidator1" style="Z-INDEX: 104; LEFT: 120px; POSITION: absolute; TOP: 316px"
				runat="server" Width="304px" ControlToValidate="txtExpDelvDate" ValidationExpression="\d{2}/\d{2}/\d{4}" ErrorMessage="Enter Date of Delivery in MM/DD/YYYY format"></asp:regularexpressionvalidator><asp:textbox id="txtModelName" style="Z-INDEX: 105; LEFT: 552px; POSITION: absolute; TOP: 232px"
				tabIndex="28" runat="server" Width="120px" Height="16px"></asp:textbox><asp:label id="Label10" style="Z-INDEX: 106; LEFT: 448px; POSITION: absolute; TOP: 180px" runat="server"
				Width="88px" ForeColor="#0000C0" Height="24px">ModelNo</asp:label>
            &nbsp;<asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                CellPadding="2" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="None"
                PageSize="4" Style="left: 112px; position: relative; top: 248px; z-index: 107;" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px">
                <FooterStyle BackColor="Tan" />
                <Columns>
                    <asp:BoundField DataField="sales_order_no" HeaderText="sales_order_no" InsertVisible="False"
                        ReadOnly="True" SortExpression="sales_order_no" />
                    <asp:BoundField DataField="model_no" HeaderText="model_no" SortExpression="model_no" />
                    <asp:BoundField DataField="sales_order_qty" HeaderText="sales_order_qty" SortExpression="sales_order_qty" />
                </Columns>
                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                <HeaderStyle BackColor="Tan" Font-Bold="True" />
                <AlternatingRowStyle BackColor="PaleGoldenrod" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:planningConnectionString %>"
                SelectCommand="SELECT * FROM [Sales_Order_Details]"></asp:SqlDataSource>
            <asp:button id="btnAddToOrder" style="Z-INDEX: 108; LEFT: 596px; POSITION: absolute; TOP: 332px"
				tabIndex="30" runat="server" Width="80px" BackColor="LightSteelBlue" BorderColor="DodgerBlue" BorderStyle="Solid"
				Text="Add to Order" OnClick="btnAddToOrder_Click1"></asp:button><asp:label id="Label9" style="Z-INDEX: 109; LEFT: 448px; POSITION: absolute; TOP: 280px" runat="server"
				Height="16px" Width="88px" ForeColor="#0000C0">Quantity</asp:label><asp:dropdownlist id="ddlModelNo" style="Z-INDEX: 110; LEFT: 552px; POSITION: absolute; TOP: 180px"
				tabIndex="27" runat="server" Height="24px" Width="128px" AutoPostBack="True" OnSelectedIndexChanged="ddlModelNo_SelectedIndexChanged1"></asp:dropdownlist><asp:textbox id="txtQty" style="Z-INDEX: 111; LEFT: 552px; POSITION: absolute; TOP: 280px" tabIndex="29"
				runat="server" Height="16px" Width="120px" MaxLength="4"></asp:textbox><asp:label id="Label5" style="Z-INDEX: 112; LEFT: 448px; POSITION: absolute; TOP: 232px" runat="server"
				Height="24px" Width="89px" ForeColor="#0000C0">Model Name</asp:label><asp:label id="Label3" style="Z-INDEX: 113; LEFT: 120px; POSITION: absolute; TOP: 232px" runat="server"
				Width="112px" ForeColor="#0000C0">Customer Name</asp:label><asp:button id="btnSubmit" style="Z-INDEX: 114; LEFT: 432px; POSITION: absolute; TOP: 432px"
				tabIndex="25" runat="server" Width="96px" BackColor="LightSteelBlue" BorderColor="DodgerBlue" BorderStyle="Solid" Text="Submit" OnClick="btnSubmit_Click1"></asp:button><asp:button id="Cancel" style="Z-INDEX: 115; LEFT: 432px; POSITION: absolute; TOP: 484px" tabIndex="26"
				runat="server" Width="101px" BackColor="LightSteelBlue" BorderColor="DodgerBlue" BorderStyle="Solid" Text="Cancel"></asp:button><asp:textbox id="txtCustName" style="Z-INDEX: 116; LEFT: 248px; POSITION: absolute; TOP: 232px"
				tabIndex="21" runat="server" Width="136px" OnTextChanged="txtCustName_TextChanged"></asp:textbox><asp:dropdownlist id="ddlCustNo" style="Z-INDEX: 117; LEFT: 248px; POSITION: absolute; TOP: 176px"
				tabIndex="20" runat="server" Width="136px" AutoPostBack="True" OnSelectedIndexChanged="ddlCustNo_SelectedIndexChanged1"></asp:dropdownlist><asp:textbox id="txtExpDelvDate" style="Z-INDEX: 118; LEFT: 248px; POSITION: absolute; TOP: 280px"
				runat="server" Width="136px" tabIndex="22" MaxLength="10"></asp:textbox><asp:label id="Label7" style="Z-INDEX: 119; LEFT: 120px; POSITION: absolute; TOP: 280px" runat="server"
				Width="112px" ForeColor="#0000C0">Date of Delivery</asp:label><asp:label id="Label6" style="Z-INDEX: 120; LEFT: 120px; POSITION: absolute; TOP: 176px" runat="server"
				Width="118px" ForeColor="#0000C0">CustomerNumber</asp:label></form>
	</body>
</html>
