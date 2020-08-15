<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 39%;
        }
        .auto-style2 {
            width: 121px;
        }
        .auto-style3 {
            width: 151px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table class="auto-style1">
            <tr>
                <td class="auto-style2">Username:- </td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Password:-</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Height="20px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <br />
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click"  Text="Login" />
                </td>
                <td class="auto-style3">
                    <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
