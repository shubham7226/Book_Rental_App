<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 105px;
        }
        .auto-style2 {
            width: 185px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        &nbsp;<table style="width: 28%;">
            <tr>
                <td class="auto-style1">Username:</td>
                <td class="auto-style2">
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Password:</td>
                <td class="auto-style2">
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="submit" />
                </td>
                <td class="auto-style2">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
    
        <br />
        &nbsp;<br />
    
    </div>
    </form>
</body>
</html>
