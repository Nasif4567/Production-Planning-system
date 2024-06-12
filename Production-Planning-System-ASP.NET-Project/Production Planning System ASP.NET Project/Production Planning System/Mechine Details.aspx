<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Mechine Details.aspx.cs" Inherits="Mechine_Details" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body bgColor="#ffffcc">
		<form id="Form1" method="post" runat="server">
			<asp:label id="Label2" style="Z-INDEX: 100; LEFT: 128px; POSITION: absolute; TOP: 96px" runat="server"
				Width="152px" Height="8px" ForeColor="Blue">Machine Id</asp:label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Textbox1"
                ErrorMessage="RequiredFieldValidator" Style="z-index: 101; left: 432px; position: absolute;
                top: 128px">enter machine no</asp:RequiredFieldValidator>
            <asp:button id="Button5" style="Z-INDEX: 102; LEFT: 344px; POSITION: absolute; TOP: 280px" runat="server"
				Width="49" Height="24" BorderStyle="Groove" BorderColor="#E0E0E0" Text="modify" OnClick="Button5_Click1"></asp:button><asp:button id="Button2" style="Z-INDEX: 103; LEFT: 280px; POSITION: absolute; TOP: 280px" runat="server"
				Width="49" Height="24" BorderStyle="Groove" BorderColor="#E0E0E0" Text="Insert" OnClick="Button2_Click1"></asp:button><asp:button id="Button1" style="Z-INDEX: 104; LEFT: 216px; POSITION: absolute; TOP: 280px" runat="server"
				Width="49" Height="24" BorderStyle="Groove" BorderColor="#E0E0E0" Text="New" OnClick="Button1_Click1"></asp:button><asp:label id="Label6" style="Z-INDEX: 105; LEFT: 128px; POSITION: absolute; TOP: 224px" runat="server"
				Width="152px" Height="16px" ForeColor="Blue">Machine warenty period</asp:label><asp:label id="Label5" style="Z-INDEX: 106; LEFT: 128px; POSITION: absolute; TOP: 192px" runat="server"
				Width="152px" Height="24px" ForeColor="Blue">Machine Instalation Date</asp:label><asp:textbox id="Textbox4" style="Z-INDEX: 107; LEFT: 304px; POSITION: absolute; TOP: 224px"
				runat="server" Width="104px" BorderStyle="Ridge"></asp:textbox>
			<asp:textbox id="Textbox1" style="Z-INDEX: 108; LEFT: 304px; POSITION: absolute; TOP: 128px"
				runat="server" Width="104px" BorderStyle="Ridge"></asp:textbox>
			<asp:DropDownList id="DropDownList1" style="Z-INDEX: 109; LEFT: 304px; POSITION: absolute; TOP: 96px"
				runat="server" Width="104px" Height="24px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged2"></asp:DropDownList>
			<asp:label id="Label1" style="Z-INDEX: 110; LEFT: 168px; POSITION: absolute; TOP: 32px" runat="server"
				Height="32px" Width="208px" Font-Size="X-Large" Font-Bold="True" ForeColor="Blue"> Machine Details</asp:label>
			<asp:label id="Label3" style="Z-INDEX: 111; LEFT: 128px; POSITION: absolute; TOP: 128px" runat="server"
				Height="8px" Width="152px" ForeColor="Blue">Machine No</asp:label>
			<asp:label id="Label4" style="Z-INDEX: 112; LEFT: 128px; POSITION: absolute; TOP: 160px" runat="server"
				Height="24px" Width="152px" ForeColor="Blue">Machine Purchase Date</asp:label>
			<asp:textbox id="TextBox2" style="Z-INDEX: 113; LEFT: 304px; POSITION: absolute; TOP: 160px"
				runat="server" Width="104px" BorderStyle="Ridge"></asp:textbox>
			<asp:textbox id="TextBox3" style="Z-INDEX: 114; LEFT: 304px; POSITION: absolute; TOP: 192px"
				runat="server" Height="24px" Width="104px" BorderStyle="Ridge"></asp:textbox>
			<asp:DataGrid id="DataGrid1" style="Z-INDEX: 115; LEFT: 232px; POSITION: absolute; TOP: 352px"
				runat="server" Height="32px" Width="168px" Font-Bold="True" Font-Size="Smaller" BackColor="#E0E0E0"
				Font-Names="Times New Roman" HorizontalAlign="Left" AllowPaging="True" PageSize="2"
				BorderColor="Blue" AllowCustomPaging="True">
				<ItemStyle Font-Names="Verdana"></ItemStyle>
				<PagerStyle Position="Top"></PagerStyle>
			</asp:DataGrid>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2"
                ErrorMessage="RequiredFieldValidator" Style="z-index: 116; left: 432px; position: absolute;
                top: 160px">enter purchase date</asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3"
                ErrorMessage="RequiredFieldValidator" Style="z-index: 117; left: 432px; position: absolute;
                top: 192px">enter machine installation date</asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="Textbox4"
                ErrorMessage="RequiredFieldValidator" Style="z-index: 119; left: 440px; position: absolute;
                top: 224px">enter warranty period</asp:RequiredFieldValidator>
        </form>
	</body>
</html>
