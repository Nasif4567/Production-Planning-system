<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Production Request.aspx.cs" Inherits="Production_Request" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body bgColor="#ffffcc">
		<form id="Form1" method="post" runat="server">
			<asp:Label id="Label1" style="Z-INDEX: 101; LEFT: 112px; POSITION: absolute; TOP: 104px" runat="server"
				ForeColor="Blue">Product Request No</asp:Label>
			<asp:Label id="Label5" style="Z-INDEX: 109; LEFT: 116px; POSITION: absolute; TOP: 24px; text-align: center;" runat="server"
				Font-Bold="True" Font-Size="X-Large" ForeColor="Blue" Font-Underline="True" Width="317px">Production Processing</asp:Label>
			<asp:DropDownList id="ddlprno" style="Z-INDEX: 108; LEFT: 248px; POSITION: absolute; TOP: 104px" runat="server"
				Width="152px" tabIndex="20" Height="24px"></asp:DropDownList>
			<asp:DropDownList id="ddlmno" style="Z-INDEX: 107; LEFT: 248px; POSITION: absolute; TOP: 136px" runat="server"
				Height="88px" Width="152px" tabIndex="21"></asp:DropDownList>
			<asp:TextBox id="TextBox2" style="Z-INDEX: 106; LEFT: 248px; POSITION: absolute; TOP: 168px"
				runat="server" tabIndex="22"></asp:TextBox>
			<asp:TextBox id="TextBox1" style="Z-INDEX: 105; LEFT: 248px; POSITION: absolute; TOP: 200px"
				runat="server" tabIndex="23"></asp:TextBox>
			<asp:Label id="Label4" style="Z-INDEX: 104; LEFT: 112px; POSITION: absolute; TOP: 200px" runat="server"
				Width="120px" ForeColor="Blue" Height="16px">Process End Date</asp:Label>
			<asp:Label id="Label3" style="Z-INDEX: 103; LEFT: 112px; POSITION: absolute; TOP: 168px" runat="server"
				ForeColor="Blue" Height="16px" Width="120px">Process Start Date</asp:Label>
			<asp:Label id="label2" style="Z-INDEX: 102; LEFT: 112px; POSITION: absolute; TOP: 136px" runat="server"
				ForeColor="Blue" Height="8px" Width="120px">Machine ID</asp:Label>
		</form>
	</body>
</html>
