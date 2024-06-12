<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DepartmentMaster.aspx.cs" Inherits="DepartmentMaster" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body bgColor="#ffffcc">
		<form id="Form1" method="post" runat="server">
			<asp:button id="btncreatDept" style="Z-INDEX: 100; LEFT: 232px; POSITION: absolute; TOP: 248px"
				tabIndex="24" runat="server" Text="Create Department" BorderColor="DodgerBlue" BackColor="LightSteelBlue"
				BorderStyle="Solid" Width="145px" Height="24px" OnClick="btncreatDept_Click1"></asp:button>
            <img src="images/cooltext51040137.jpg" style="z-index: 108; left: 0px; width: 784px;
                position: absolute; top: 0px" />
			<asp:RequiredFieldValidator id="rfvname" style="Z-INDEX: 101; LEFT: 552px; POSITION: absolute; TOP: 144px" runat="server"
				ErrorMessage="Enter Department Name" ControlToValidate="txtDeptName"></asp:RequiredFieldValidator>
            &nbsp;
			<asp:label id="Label3" style="Z-INDEX: 102; LEFT: 184px; POSITION: absolute; TOP: 144px" runat="server"
				Width="128px" Height="24px" ForeColor="Blue">Department Name</asp:label>
			<asp:label id="Label5" style="Z-INDEX: 103; LEFT: 184px; POSITION: absolute; TOP: 200px" runat="server"
				Width="128px" Height="24px" ForeColor="Blue"> Highest Designation </asp:label>
			<asp:DropDownList id="ddlDesignation" style="Z-INDEX: 104; LEFT: 352px; POSITION: absolute; TOP: 200px"
				runat="server" Width="176px" tabIndex="22" Height="24px" OnSelectedIndexChanged="ddlDesignation_SelectedIndexChanged"></asp:DropDownList>
			<asp:label id="Label2" style="Z-INDEX: 105; LEFT: 264px; POSITION: absolute; TOP: 88px" tabIndex="5"
				runat="server" Width="112px" Font-Underline="True" Font-Size="X-Large" ForeColor="Blue" Font-Bold="True">DEPARTMENTS</asp:label>
            &nbsp;
			<asp:textbox id="txtDeptName" style="Z-INDEX: 106; LEFT: 352px; POSITION: absolute; TOP: 144px"
				tabIndex="21" runat="server" Width="168px" Height="16px" MaxLength="20"></asp:textbox>
            &nbsp; &nbsp;
            <asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84"
                BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" Style="z-index: 109;
                left: 216px; position: absolute; top: 288px">
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            </asp:GridView>
			</form>
	</body>
</html>
