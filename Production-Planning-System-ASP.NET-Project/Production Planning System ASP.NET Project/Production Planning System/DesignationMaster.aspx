<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DesignationMaster.aspx.cs" Inherits="DesignationMaster" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
	<HEAD>
		<title>WebForm1</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body bgColor="#ffffcc">
		<form id="Form1" method="post" runat="server">
			<asp:textbox id="txtDesigabbr" style="Z-INDEX: 100; LEFT: 248px; POSITION: absolute; TOP: 120px"
				runat="server" Width="164px" Height="24px" tabIndex="22" OnTextChanged="txtDesigabbr_TextChanged"></asp:textbox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtDesigabbr"
                ErrorMessage="RequiredFieldValidator" Style="z-index: 101; left: 432px; position: absolute;
                top: 128px">enter abbr</asp:RequiredFieldValidator>
			<asp:RequiredFieldValidator id="rfvname" style="Z-INDEX: 102; LEFT: 424px; POSITION: absolute; TOP: 88px" runat="server"
				ErrorMessage="Enter designation name" ControlToValidate="txtDesigName" Width="146px"></asp:RequiredFieldValidator><asp:button id="btncreatDesig" style="Z-INDEX: 103; LEFT: 248px; POSITION: absolute; TOP: 216px"
				runat="server" Width="145px" Height="24px" Text="Create Designation" BorderStyle="Solid" BorderColor="DodgerBlue" BackColor="LightSteelBlue" tabIndex="24" OnClick="btncreatDesig_Click1"></asp:button>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2"
                DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="None" PageSize="5"
                Style="left: 128px; position: relative; top: 272px; z-index: 104;">
                <FooterStyle BackColor="Tan" />
                <Columns>
                    <asp:BoundField DataField="desig_id" HeaderText="desig_id" SortExpression="desig_id" />
                    <asp:BoundField DataField="desig_name" HeaderText="desig_name" SortExpression="desig_name" />
                    <asp:BoundField DataField="desig_abr" HeaderText="desig_abr" SortExpression="desig_abr" />
                    <asp:BoundField DataField="desig_desc" HeaderText="desig_desc" SortExpression="desig_desc" />
                </Columns>
                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                <HeaderStyle BackColor="Tan" Font-Bold="True" />
                <AlternatingRowStyle BackColor="PaleGoldenrod" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:planningConnectionString8 %>"
                SelectCommand="SELECT desig_id, desig_name, desig_abr, desig_desc FROM Designation_Master">
            </asp:SqlDataSource>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtDesigDesc"
                ErrorMessage="RequiredFieldValidator" Style="z-index: 112; left: 432px; position: absolute;
                top: 168px">enter desc</asp:RequiredFieldValidator>
            <asp:label id="Label5" style="Z-INDEX: 106; LEFT: 104px; POSITION: absolute; TOP: 160px" runat="server"
				Width="121px" Height="8px" ForeColor="Blue">Designation Desc</asp:label><asp:label id="Label4" style="Z-INDEX: 107; LEFT: 104px; POSITION: absolute; TOP: 120px" runat="server"
				Width="129px" Height="8px" ForeColor="Blue">Designation Abbr</asp:label><asp:label id="Label3" style="Z-INDEX: 108; LEFT: 104px; POSITION: absolute; TOP: 80px" runat="server"
				Width="130px" Height="8px" ForeColor="Blue">Desiganation Name</asp:label><asp:label id="Label2" style="Z-INDEX: 109; LEFT: 192px; POSITION: absolute; TOP: 24px" runat="server"
				Width="112px" Font-Bold="True" Font-Underline="True" Font-Size="X-Large" ForeColor="Blue" tabIndex="5">DESIGNATIONS</asp:label><asp:textbox id="txtDesigName" style="Z-INDEX: 110; LEFT: 248px; POSITION: absolute; TOP: 80px"
				runat="server" Width="164px" Height="24px" tabIndex="21"></asp:textbox><asp:textbox id="txtDesigDesc" style="Z-INDEX: 111; LEFT: 248px; POSITION: absolute; TOP: 160px"
				runat="server" Width="164px" Height="24px" tabIndex="23"></asp:textbox>&nbsp;
		</form>
	</body>
</html>
