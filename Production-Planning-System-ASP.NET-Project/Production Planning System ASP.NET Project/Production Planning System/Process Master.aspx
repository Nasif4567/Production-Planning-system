<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Process Master.aspx.cs" Inherits="Process_Master" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body bgColor="#ffffcc">
		<form id="Form1" method="post" runat="server">
			<asp:label id="Label2" style="Z-INDEX: 100; LEFT: 120px; POSITION: absolute; TOP: 96px" runat="server"
				Width="64px" Height="10px" ForeColor="Blue">Process_No</asp:label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Textbox1"
                ErrorMessage="RequiredFieldValidator" Style="z-index: 101; left: 408px; position: absolute;
                top: 128px">enter name</asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2"
                ErrorMessage="RequiredFieldValidator" Style="z-index: 102; left: 392px; position: absolute;
                top: 168px">enter desc</asp:RequiredFieldValidator>
			<asp:button id="Button5" style="Z-INDEX: 103; LEFT: 296px; POSITION: absolute; TOP: 336px" runat="server"
				Height="24" Width="49" BorderStyle="Groove" BorderColor="#E0E0E0" Text="modify" OnClick="Button5_Click1" CausesValidation="False"></asp:button>
			<asp:button id="Button4" style="Z-INDEX: 104; LEFT: 352px; POSITION: absolute; TOP: 336px" runat="server"
				Height="24" Width="49" BorderStyle="Groove" BorderColor="#E0E0E0" Text="close" CausesValidation="False"></asp:button>
			<asp:button id="Button3" style="Z-INDEX: 105; LEFT: 240px; POSITION: absolute; TOP: 336px" runat="server"
				Height="24" Width="49" BorderStyle="Groove" BorderColor="#E0E0E0" Text="Del" OnClick="Button3_Click" CausesValidation="False"></asp:button>
			<asp:button id="Button2" style="Z-INDEX: 106; LEFT: 184px; POSITION: absolute; TOP: 336px" runat="server"
				Height="24" Width="49" BorderStyle="Groove" BorderColor="#E0E0E0" Text="Insert" OnClick="Button2_Click1"></asp:button>
			<asp:button id="Button1" style="Z-INDEX: 107; LEFT: 128px; POSITION: absolute; TOP: 336px" runat="server"
				Height="24" Width="49" BorderStyle="Groove" BorderColor="#E0E0E0" Text="New" OnClick="Button1_Click1"></asp:button>
			<asp:label id="Label5" style="Z-INDEX: 108; LEFT: 120px; POSITION: absolute; TOP: 280px" runat="server"
				Height="24px" Width="128px" ForeColor="Blue">Process Batch Time</asp:label>
			<asp:textbox id="Textbox5" style="Z-INDEX: 109; LEFT: 256px; POSITION: absolute; TOP: 280px"
				runat="server" Width="104px" BorderStyle="Ridge"></asp:textbox>
			<asp:DropDownList id="DropDownList1" style="Z-INDEX: 110; LEFT: 256px; POSITION: absolute; TOP: 88px"
				runat="server" Height="24px" Width="112px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged1"></asp:DropDownList>
			<asp:textbox id="Textbox4" style="Z-INDEX: 111; LEFT: 256px; POSITION: absolute; TOP: 248px"
				runat="server" Width="104px" BorderStyle="Ridge"></asp:textbox>
			<asp:textbox id="Textbox3" style="Z-INDEX: 112; LEFT: 256px; POSITION: absolute; TOP: 208px"
				runat="server" Width="104px" BorderStyle="Ridge"></asp:textbox>
			<asp:textbox id="Textbox1" style="Z-INDEX: 113; LEFT: 256px; POSITION: absolute; TOP: 128px"
				runat="server" Width="104px" BorderStyle="Ridge"></asp:textbox>
			<asp:DataGrid id="DataGrid1" style="Z-INDEX: 114; LEFT: 152px; POSITION: absolute; TOP: 400px"
				runat="server" Height="32px" Width="168px" Font-Size="Smaller" Font-Bold="True" PageSize="5"
				HorizontalAlign="Left" Font-Names="Times New Roman" BackColor="#E0E0E0" BorderColor="Blue">
				<ItemStyle Font-Names="Verdana"></ItemStyle>
				<PagerStyle Visible="False" Mode="NumericPages"></PagerStyle>
			</asp:DataGrid>
			<asp:label id="Label8" style="Z-INDEX: 115; LEFT: 120px; POSITION: absolute; TOP: 248px" runat="server"
				Width="120px" Height="24px" ForeColor="Blue">Process Batch Cost</asp:label>
			<asp:label id="Label1" style="Z-INDEX: 116; LEFT: 160px; POSITION: absolute; TOP: 24px" runat="server"
				Width="168px" Height="32px" Font-Bold="True" Font-Size="X-Large" ForeColor="Blue"> Process Master</asp:label>
			<asp:label id="Label3" style="Z-INDEX: 117; LEFT: 120px; POSITION: absolute; TOP: 128px" runat="server"
				Width="112px" Height="24px" ForeColor="Blue">Process Name</asp:label>
			<asp:label id="Label4" style="Z-INDEX: 118; LEFT: 120px; POSITION: absolute; TOP: 168px" runat="server"
				Width="128px" Height="24px" ForeColor="Blue">Process_Description</asp:label>
			<asp:label id="Label6" style="Z-INDEX: 119; LEFT: 120px; POSITION: absolute; TOP: 208px" runat="server"
				Width="128px" Height="24px" ForeColor="Blue"> Batch quantity</asp:label>
			<asp:textbox id="TextBox2" style="Z-INDEX: 120; LEFT: 256px; POSITION: absolute; TOP: 168px"
				runat="server" Width="104px" BorderStyle="Ridge"></asp:textbox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="Textbox3"
                ErrorMessage="RequiredFieldValidator" Style="z-index: 121; left: 392px; position: absolute;
                top: 208px">enter quantity</asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="Textbox4"
                ErrorMessage="RequiredFieldValidator" Style="z-index: 122; left: 392px; position: absolute;
                top: 248px">enter cost</asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="Textbox5"
                ErrorMessage="RequiredFieldValidator" Style="z-index: 124; left: 392px; position: absolute;
                top: 280px">enter batch time</asp:RequiredFieldValidator>
		</form>
	</body>
</html>
