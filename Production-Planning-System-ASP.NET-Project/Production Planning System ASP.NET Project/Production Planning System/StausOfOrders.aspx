<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StausOfOrders.aspx.cs" Inherits="StausOfOrders" %>

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
                        <img src="images/cooltext51040137.jpg" style="z-index: 105; left: 0px; width: 744px;
                            position: absolute; top: 0px; height: 64px" />
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
					<td align="center"><asp:hyperlink id="HyperLink1" runat="server" NavigateUrl="SalesOffice.aspx" Font-Names="Trebuchet MS"
							ForeColor="Black" Font-Size="Smaller" Font-Bold="True">Home</asp:hyperlink></td>
					<td width="1" bgColor="#cccccc"></td>
					<td align="center"><asp:hyperlink id="HyperLink3" runat="server" NavigateUrl="Customer Master.aspx" Font-Names="Trebuchet MS"
							ForeColor="Black" Font-Size="Smaller" Font-Bold="True">Customer Details</asp:hyperlink></td>
					<td width="1" bgColor="#cccccc"></td>
					<TD align="center"><asp:hyperlink id="Hyperlink6" runat="server" NavigateUrl="IssueOrders.aspx" Font-Names="Trebuchet MS"
							ForeColor="Black" Font-Size="Smaller" Font-Bold="True">Issue Orders</asp:hyperlink></TD>
					<td width="1" bgColor="#cccccc"></td>
					<TD align="center" bgColor="#ffffff"><asp:hyperlink id="HyperLink4" runat="server" Font-Names="Trebuchet MS" ForeColor="Black" Font-Size="Smaller"
							Font-Bold="True">Orders Status</asp:hyperlink></TD>
					<td bgColor="#cccccc" style="width: 1px"></td>
					<TD align="center"><asp:hyperlink id="Hyperlink2" runat="server" NavigateUrl="Submit Forecast Details.aspx" Font-Names="Trebuchet MS"
							ForeColor="Black" Font-Size="Smaller" Font-Bold="True">Submit Forecast</asp:hyperlink></TD>
					<td width="1" bgColor="#cccccc"></td>
					<TD align="center"><asp:hyperlink id="HyperLink5" runat="server" NavigateUrl="~/ChangePassword.aspx" Font-Names="Trebuchet MS"
							ForeColor="Black" Font-Size="Smaller" Font-Bold="True">Change Password</asp:hyperlink></TD>
					<td width="1" bgColor="#cccccc"></td>
					<TD align="center"><asp:linkbutton id="LinkButton1" runat="server" Font-Names="Trebuchet MS" ForeColor="Black" Font-Size="Smaller"
							Font-Bold="True" PostBackUrl="~/LogInForm.aspx">Logout</asp:linkbutton></TD>
				</tr>
			</table>
			<asp:label id="Label2" style="Z-INDEX: 100; LEFT: 240px; POSITION: absolute; TOP: 152px" runat="server"
				Width="240px" ForeColor="DarkCyan" Font-Size="Large" Font-Bold="True" BorderStyle="Solid"
				Font-Underline="True">Status of Your Orders</asp:label>
			<asp:Label id="Label1" style="Z-INDEX: 101; LEFT: 184px; POSITION: absolute; TOP: 248px" runat="server"
				ForeColor="#00C000" Font-Bold="True" Width="357px"></asp:Label>
            &nbsp;&nbsp;
           <%-- <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:planningConnectionString2 %>"
                SelectCommand="SELECT * FROM [Sales_Order_Master] Where sales_exec_no =@sales_exec_no">
                <SelectParameters>
                <asp:Parameter Type ="string" Name ="sales_exec_no" />
                </SelectParameters> 
                </asp:SqlDataSource>--%>
            <asp:button id="btnShowStatus" style="Z-INDEX: 102; LEFT: 284px; POSITION: absolute; TOP: 204px"
				tabIndex="5" runat="server" Width="137px" BorderStyle="Solid" Text="Show Oredrs Status" BorderColor="#0000C0"
				BackColor="#C0C0FF" OnClick="btnShowStatus_Click3"></asp:button>
            &nbsp;
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:planningConnectionString3 %>"
                SelectCommand="SELECT * FROM [Sales_Order_Master] WHERE ([sales_exec_no] = @sales_exec_no)">
                <SelectParameters>
                    <asp:SessionParameter Name="sales_exec_no" SessionField="empno" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
            &nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Style="left: 0px; position: relative;
                top: -174px; z-index: 103;" OnTextChanged="TextBox1_TextChanged1"></asp:TextBox>
            <asp:GridView ID="GridView1" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan"
                BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" Style="z-index: 106;
                left: 24px; position: absolute; top: 296px">
                <FooterStyle BackColor="Tan" />
                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                <HeaderStyle BackColor="Tan" Font-Bold="True" />
                <AlternatingRowStyle BackColor="PaleGoldenrod" />
            </asp:GridView>
        </form>
	</body>
</html>
