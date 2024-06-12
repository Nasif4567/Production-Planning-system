<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CreateLogIn.aspx.cs" Inherits="CreateLogIn" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body bgColor="#ffffcc">
		<form id="Form1" method="post"  runat="server">
            <img src="images/cooltext51040137.jpg" style="z-index: 118; left: 0px; width: 760px;
                position: absolute; top: 0px" />
            &nbsp; &nbsp;&nbsp;
            <asp:label id="Label1" style="Z-INDEX: 100; LEFT: 432px; POSITION: absolute; TOP: 296px" runat="server"
				Height="56px" Width="296px" ForeColor="Red"></asp:label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtLoginName"
                ErrorMessage="RequiredFieldValidator" Style="z-index: 101; left: 384px; position: absolute;
                top: 184px">enter login name</asp:RequiredFieldValidator>
            <asp:comparevalidator id="CompareValidator1" style="Z-INDEX: 102; LEFT: 384px; POSITION: absolute; TOP: 248px"
				runat="server" Width="352px" ControlToCompare="txtPassword" Font-Size="Medium" ToolTip="Password must be same in confirm and  password boxes" ControlToValidate="txtConPassword" Height="24px">Password must be same in confirm and  password boxes</asp:comparevalidator><asp:label id="Label2" style="Z-INDEX: 103; LEFT: 160px; POSITION: absolute; TOP: 64px" runat="server"
				Width="152px" ForeColor="Blue" Font-Size="X-Large" Font-Underline="True" Font-Bold="True">Create LogIns</asp:label><asp:dropdownlist id="ddlEmpID" style="Z-INDEX: 104; LEFT: 216px; POSITION: absolute; TOP: 120px" tabIndex="20"
				runat="server" Width="160px" AutoPostBack="True" Height="24px" OnSelectedIndexChanged="ddlEmpID_SelectedIndexChanged2"></asp:dropdownlist><asp:textbox id="txtConPassword" style="Z-INDEX: 105; LEFT: 216px; POSITION: absolute; TOP: 248px"
				tabIndex="24" runat="server" TextMode="Password" Height="16px" Width="152px"></asp:textbox><asp:label id="Label6" style="Z-INDEX: 106; LEFT: 80px; POSITION: absolute; TOP: 248px" runat="server"
				Width="117px" ForeColor="Blue">Confirm Password</asp:label><asp:textbox id="txtPassword" style="Z-INDEX: 107; LEFT: 216px; POSITION: absolute; TOP: 216px"
				tabIndex="23" runat="server" TextMode="Password" Height="16px" Width="152px"></asp:textbox><asp:label id="Label5" style="Z-INDEX: 108; LEFT: 80px; POSITION: absolute; TOP: 216px" runat="server"
				Width="112px" ForeColor="Blue" Height="16px">Password</asp:label><asp:textbox id="txtEmpName" style="Z-INDEX: 109; LEFT: 216px; POSITION: absolute; TOP: 152px"
				tabIndex="21" runat="server" Width="152px"></asp:textbox><asp:textbox id="txtLoginName" style="Z-INDEX: 110; LEFT: 216px; POSITION: absolute; TOP: 184px"
				tabIndex="22" runat="server"></asp:textbox><asp:button id="btnCreateLogIn" style="Z-INDEX: 111; LEFT: 256px; POSITION: absolute; TOP: 288px"
				tabIndex="25" runat="server" BorderStyle="Solid" BorderColor="#8080FF" BackColor="Lime" Text="Create LogIn" OnClick="btnCreateLogIn_Click1" ></asp:button><asp:button id="btnClear" style="Z-INDEX: 112; LEFT: 128px; POSITION: absolute; TOP: 288px"
				tabIndex="26" runat="server" BorderStyle="Solid" BorderColor="#8080FF" BackColor="White" Width="111px" Text="Clear" OnClick="btnClear_Click1"></asp:button><asp:label id="lblUserName" style="Z-INDEX: 113; LEFT: 80px; POSITION: absolute; TOP: 152px"
				runat="server" Width="112px" ForeColor="Blue" Height="8px">EmpName</asp:label><asp:label id="Label4" style="Z-INDEX: 114; LEFT: 80px; POSITION: absolute; TOP: 120px" runat="server"
				Width="112px" ForeColor="Blue" Height="16px">Emp ID</asp:label><asp:label id="Label3" style="Z-INDEX: 115; LEFT: 80px; POSITION: absolute; TOP: 184px" runat="server"
				Width="112px" ForeColor="Blue" Height="16px">LogIn Name</asp:label>
            &nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword"
                ErrorMessage="RequiredFieldValidator" Style="z-index: 116; left: 400px; position: absolute;
                top: 216px">enter pwd</asp:RequiredFieldValidator>
            <asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84"
                BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" Style="z-index: 119;
                left: 152px; position: absolute; top: 320px">
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            </asp:GridView>
            </form>
	</body>
</html>
