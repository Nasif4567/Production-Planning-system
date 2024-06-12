<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Power Tool Model Master.aspx.cs" Inherits="Power_Tool_Model_Master" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body bgColor="#ffffcc">
		<form id="Form1" method="post" runat="server">
			<asp:label id="Label2" style="Z-INDEX: 100; LEFT: 112px; POSITION: absolute; TOP: 104px" runat="server"
				Width="104px" Height="10px" ForeColor="Blue">Model No</asp:label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Textbox1"
                ErrorMessage="RequiredFieldValidator" Style="z-index: 114; left: 384px; position: absolute;
                top: 184px">enter quantity req</asp:RequiredFieldValidator>
            <asp:button id="Button5" style="Z-INDEX: 102; LEFT: 304px; POSITION: absolute; TOP: 232px" runat="server"
				Width="49" Height="24" BorderStyle="Groove" BorderColor="#E0E0E0" Text="modify" OnClick="Button5_Click1" CausesValidation="False"></asp:button><asp:button id="Button4" style="Z-INDEX: 103; LEFT: 368px; POSITION: absolute; TOP: 232px" runat="server"
				Width="49" Height="24" BorderStyle="Groove" BorderColor="#E0E0E0" Text="close" OnClick="Button4_Click" ></asp:button><asp:button id="Button3" style="Z-INDEX: 104; LEFT: 240px; POSITION: absolute; TOP: 232px" runat="server"
				Width="49" Height="24" BorderStyle="Groove" BorderColor="#E0E0E0" Text="Del" OnClick="Button3_Click" CausesValidation="False"></asp:button><asp:button id="Button2" style="Z-INDEX: 105; LEFT: 176px; POSITION: absolute; TOP: 232px" runat="server"
				Width="49" Height="24" BorderStyle="Groove" BorderColor="#E0E0E0" Text="Insert" OnClick="Button2_Click1"></asp:button><asp:button id="Button1" style="Z-INDEX: 106; LEFT: 112px; POSITION: absolute; TOP: 232px" runat="server"
				Width="49" Height="24" BorderStyle="Groove" BorderColor="#E0E0E0" Text="New" OnClick="Button1_Click1" Visible="False" ></asp:button><asp:textbox id="Textbox1" style="Z-INDEX: 107; LEFT: 232px; POSITION: absolute; TOP: 184px"
				runat="server" Width="104px" BorderStyle="Ridge"></asp:textbox><asp:dropdownlist id="DropDownList2" style="Z-INDEX: 108; LEFT: 232px; POSITION: absolute; TOP: 136px"
				runat="server" Width="104px" Height="24px" AutoPostBack="True"></asp:dropdownlist><asp:dropdownlist id="DropDownList1" style="Z-INDEX: 109; LEFT: 232px; POSITION: absolute; TOP: 104px"
				runat="server" Width="104px" Height="24px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged1"></asp:dropdownlist><asp:label id="Label1" style="Z-INDEX: 110; LEFT: 136px; POSITION: absolute; TOP: 24px; text-align: center;" runat="server"
				Width="304px" Height="32px" Font-Size="X-Large" Font-Bold="True" ForeColor="Blue"> Power Tool Model Master</asp:label><asp:label id="Label3" style="Z-INDEX: 111; LEFT: 112px; POSITION: absolute; TOP: 136px" runat="server"
				Width="104px" Height="24px" ForeColor="Blue">Raw Material Id</asp:label><asp:label id="Label4" style="Z-INDEX: 112; LEFT: 112px; POSITION: absolute; TOP: 176px" runat="server"
				Width="112px" Height="24px" ForeColor="Blue">Raw Material Quantity required</asp:label>
            <asp:GridView ID="GridView1" runat="server" Style="z-index: 113; left: 112px; position: absolute;
                top: 272px">
            </asp:GridView>
        </form>
	</body>
</html>
