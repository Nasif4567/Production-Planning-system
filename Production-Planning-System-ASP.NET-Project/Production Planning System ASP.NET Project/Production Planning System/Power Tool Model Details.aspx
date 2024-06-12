<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Power Tool Model Details.aspx.cs" Inherits="Power_Tool_Model_Details" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <script language ="javascript">
    function close()
    {
     window.closed ; 
    window.close();
    }
    </script> 
</head>
<body bgColor="#ffffcc">
		<form id="Form1" method="post" runat="server">
			<asp:label id="Label2" style="Z-INDEX: 100; LEFT: 88px; POSITION: absolute; TOP: 88px" runat="server"
				Width="128px" Height="8px" ForeColor="Blue">Model No</asp:label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Textbox1"
                ErrorMessage="RequiredFieldValidator" Style="z-index: 101; left: 440px; position: absolute;
                top: 120px">enter model name</asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2"
                ErrorMessage="RequiredFieldValidator" Style="z-index: 102; left: 440px; position: absolute;
                top: 160px">enter code</asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3"
                ErrorMessage="RequiredFieldValidator" Style="z-index: 103; left: 440px; position: absolute;
                top: 200px">enter selling price</asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="Textbox4"
                ErrorMessage="RequiredFieldValidator" Style="z-index: 121; left: 432px; position: absolute;
                top: 248px">enter other details</asp:RequiredFieldValidator>
            &nbsp;
			<asp:DataGrid id="DataGrid1" style="Z-INDEX: 105; LEFT: 56px; POSITION: absolute; TOP: 384px"
				runat="server" Height="32px" Width="344px" Font-Size="Smaller" Font-Bold="True" BorderColor="Blue"
				AllowCustomPaging="True" PageSize="2" HorizontalAlign="Left" Font-Names="Times New Roman"
				BackColor="#E0E0E0" AllowPaging="True">
				<ItemStyle Font-Names="Verdana"></ItemStyle>
				<PagerStyle Position="Top"></PagerStyle>
			</asp:DataGrid>
			<asp:textbox id="Textbox1" style="Z-INDEX: 106; LEFT: 224px; POSITION: absolute; TOP: 120px"
				runat="server" Width="184px" BorderStyle="Ridge" Height="16px"></asp:textbox>
			<asp:button id="Button5" style="Z-INDEX: 107; LEFT: 288px; POSITION: absolute; TOP: 320px" runat="server"
				Height="24" Width="49" BorderStyle="Groove" Text="modify" BorderColor="#E0E0E0" OnClick="Button5_Click1" CausesValidation="False"></asp:button>
            &nbsp;
			<asp:button id="Button3" style="Z-INDEX: 108; LEFT: 224px; POSITION: absolute; TOP: 320px" runat="server"
				Height="24" Width="49" BorderStyle="Groove" Text="Del" BorderColor="#E0E0E0" OnClick="Button3_Click" CausesValidation="False"></asp:button>
			<asp:button id="Button2" style="Z-INDEX: 109; LEFT: 152px; POSITION: absolute; TOP: 320px" runat="server"
				Height="24" Width="49" BorderStyle="Groove" Text="Insert" BorderColor="#E0E0E0" OnClick="Button2_Click"></asp:button>
			<asp:button id="Button1" style="Z-INDEX: 110; LEFT: 88px; POSITION: absolute; TOP: 320px" runat="server"
				Height="24" Width="49" BorderStyle="Groove" Text="New" BorderColor="#E0E0E0" OnClick="Button1_Click1"></asp:button>
			<asp:label id="Label5" style="Z-INDEX: 111; LEFT: 88px; POSITION: absolute; TOP: 240px" runat="server"
				Width="128px" Height="24px" ForeColor="Blue"> Model Other Details</asp:label>
			<asp:textbox id="Textbox4" style="Z-INDEX: 112; LEFT: 224px; POSITION: absolute; TOP: 240px"
				runat="server" Width="184px" BorderStyle="Ridge" Height="48px" TextMode="MultiLine"></asp:textbox>
			<asp:label id="Label1" style="Z-INDEX: 113; LEFT: 152px; POSITION: absolute; TOP: 16px" runat="server"
				Width="272px" Height="32px" Font-Bold="True" Font-Size="Large">Power Tool Model Details</asp:label>
			<asp:label id="Label3" style="Z-INDEX: 114; LEFT: 88px; POSITION: absolute; TOP: 120px" runat="server"
				Width="128px" Height="16px" ForeColor="Blue"> Model Name</asp:label>
			<asp:label id="Label4" style="Z-INDEX: 115; LEFT: 88px; POSITION: absolute; TOP: 160px" runat="server"
				Width="128px" Height="24px" ForeColor="Blue">Industrial Area Code</asp:label>
			<asp:label id="Label6" style="Z-INDEX: 116; LEFT: 88px; POSITION: absolute; TOP: 200px" runat="server"
				Width="128px" Height="24px" ForeColor="Blue"> Min Selling Price</asp:label>
			<asp:textbox id="TextBox2" style="Z-INDEX: 117; LEFT: 224px; POSITION: absolute; TOP: 160px"
				runat="server" Width="184px" BorderStyle="Ridge" Height="16px"></asp:textbox>
			<asp:textbox id="TextBox3" style="Z-INDEX: 118; LEFT: 224px; POSITION: absolute; TOP: 200px"
				runat="server" Width="184px" Height="16px" BorderStyle="Ridge"></asp:textbox>
			<asp:DropDownList id="DropDownList1" style="Z-INDEX: 119; LEFT: 224px; POSITION: absolute; TOP: 88px"
				runat="server" Height="16px" Width="192px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged1"></asp:DropDownList>
		</form>
	</body>
</html>
