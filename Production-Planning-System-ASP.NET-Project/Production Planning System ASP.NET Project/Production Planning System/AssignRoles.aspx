<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AssignRoles.aspx.cs" Inherits="AssignRoles" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<HEAD>
		<title>AssignRoles</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body bgColor="#ffffcc">
		<form id="Form1" method="post" runat="server">
            <img src="images/cooltext51040137.jpg" style="z-index: 108; left: 0px; width: 768px;
                position: absolute; top: 0px" />
            &nbsp;<asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2"
                DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
                PageSize="5" Style="left: 232px; position: relative; top: 296px; z-index: 101;" DataKeyNames="emp_name">
                <FooterStyle BackColor="Tan" />
                <Columns>
                    <asp:BoundField DataField="emp_name" HeaderText="emp_name" SortExpression="emp_name" />
                    <asp:BoundField DataField="user_name" HeaderText="user_name" SortExpression="user_name" />
                    <asp:BoundField DataField="role_desc" HeaderText="role_desc" SortExpression="role_desc" />
                </Columns>
                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                <HeaderStyle BackColor="Tan" Font-Bold="True" />
                <AlternatingRowStyle BackColor="PaleGoldenrod" />
            </asp:GridView>
            &nbsp;
			<asp:Button id="btnAssignRole" style="Z-INDEX: 102; LEFT: 264px; POSITION: absolute; TOP: 264px"
				runat="server" Width="113px" BorderStyle="Solid" BorderColor="DodgerBlue" BackColor="PaleTurquoise"
				Text="Assign Role" tabIndex="22" OnClick="btnAssignRole_Click1"></asp:Button>
			<asp:label id="Label2" style="Z-INDEX: 103; LEFT: 224px; POSITION: absolute; TOP: 80px" runat="server"
				Font-Bold="True" Font-Underline="True" Font-Size="X-Large" ForeColor="Blue" Width="184px"
				tabIndex="70">Roles Assignment</asp:label>
			<asp:DropDownList id="ddlLoginName" style="Z-INDEX: 104; LEFT: 320px; POSITION: absolute; TOP: 136px"
				runat="server" Width="144px" tabIndex="20"></asp:DropDownList>
			<asp:DropDownList id="ddlRoles" style="Z-INDEX: 105; LEFT: 320px; POSITION: absolute; TOP: 184px"
				runat="server" Width="144px" tabIndex="21"></asp:DropDownList>
			<asp:Label id="Label5" style="Z-INDEX: 106; LEFT: 160px; POSITION: absolute; TOP: 136px" runat="server"
				Width="88px" Height="24px" ForeColor="Blue">Login Name</asp:Label>
			<asp:Label id="Roles" style="Z-INDEX: 107; LEFT: 160px; POSITION: absolute; TOP: 184px" runat="server"
				Width="88px" ForeColor="Blue" Height="8px">Roles</asp:Label>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:planningConnectionString4 %>" SelectCommand="SELECT Employee_Master.emp_name, Login_Master.user_name, roles.role_desc FROM Employee_Master INNER JOIN Login_Master ON Employee_Master.emp_no = Login_Master.emp_id INNER JOIN User_Roles ON Login_Master.user_name = User_Roles.user_name INNER JOIN roles ON User_Roles.role_id = roles.role_id" 
            DeleteCommand="delete from User_Roles where user_name=@user_name">
            <DeleteParameters>
            <asp:Parameter Type="string" Name ="user_name" />
            </DeleteParameters> 
            </asp:SqlDataSource>
		</form>
	</body></html>
