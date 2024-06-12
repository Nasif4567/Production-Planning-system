<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cridit_Card_Limit_Master.aspx.cs" Inherits="Cridit_Card_Limit_Master" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body bgColor="#ffffcc">
		<form id="Form1" method="post" runat="server">
			<asp:Label id="Label1" style="Z-INDEX: 100; LEFT: 88px; POSITION: absolute; TOP: 184px" runat="server"
				Width="121px" ForeColor="Blue">Credit_Rating_Description</asp:Label>
            <img src="images/cooltext51040137.jpg" style="z-index: 110; left: 0px; width: 760px;
                position: absolute; top: 0px" />
			<asp:RequiredFieldValidator id="rfvdesc" style="Z-INDEX: 102; LEFT: 440px; POSITION: absolute; TOP: 192px" runat="server"
				ErrorMessage="Enter credit rating description" ControlToValidate="txtdesc"></asp:RequiredFieldValidator>
			<asp:RequiredFieldValidator id="rfvlimit" style="Z-INDEX: 103; LEFT: 440px; POSITION: absolute; TOP: 152px"
				runat="server" ErrorMessage="Enter credit rating limit" ControlToValidate="txtlimit"></asp:RequiredFieldValidator>
            &nbsp;<asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2"
                DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="None" PageSize="5"
                Style="left: 80px; position: relative; top: 264px; z-index: 104;">
                <FooterStyle BackColor="Tan" />
                <Columns>
                    <asp:BoundField DataField="credit_limit_id" HeaderText="credit_limit_id" SortExpression="credit_limit_id" />
                    <asp:BoundField DataField="Credit_Limit_Master" HeaderText="Credit_Limit_Master"
                        SortExpression="Credit_Limit_Master" />
                    <asp:BoundField DataField="credit_rating_description" HeaderText="credit_rating_description"
                        SortExpression="credit_rating_description" />
                </Columns>
                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                <HeaderStyle BackColor="Tan" Font-Bold="True" />
                <AlternatingRowStyle BackColor="PaleGoldenrod" />
            </asp:GridView>
            &nbsp;<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:planningConnectionString6 %>"
                SelectCommand="SELECT credit_limit_id, Credit_Limit_Master, credit_rating_description FROM Credit_Limit_Master" OnSelecting="SqlDataSource1_Selecting">
            </asp:SqlDataSource>
			<asp:Label id="Label3" style="Z-INDEX: 105; LEFT: 168px; POSITION: absolute; TOP: 72px; text-align: center;" runat="server"
				Width="296px" ForeColor="Blue" Font-Bold="True" Font-Size="X-Large" Font-Underline="True" Height="40px">Credit Card Limit Details</asp:Label>
			<asp:Button id="Button1" style="Z-INDEX: 106; LEFT: 264px; POSITION: absolute; TOP: 232px" runat="server"
				Text="Create" Width="112px" tabIndex="23" OnClick="Button1_Click1" ></asp:Button>
			<asp:TextBox id="txtlimit" style="Z-INDEX: 107; LEFT: 264px; POSITION: absolute; TOP: 144px"
				runat="server" tabIndex="20"></asp:TextBox>
			<asp:TextBox id="txtdesc" style="Z-INDEX: 108; LEFT: 264px; POSITION: absolute; TOP: 184px" runat="server"
				tabIndex="22"></asp:TextBox>
			<asp:Label id="Label2" style="Z-INDEX: 109; LEFT: 88px; POSITION: absolute; TOP: 144px" runat="server"
				Width="160px" ForeColor="Blue" Height="16px">Credit Rating Limit</asp:Label>
		</form>
	</body></html>
