<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="lab5_task2.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large"></asp:Label>
        <br />
        <br />
        &nbsp;Select radio button:-<br />
            <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" AutoPostBack="True">
            <asp:ListItem>Electronics </asp:ListItem>
            <asp:ListItem>Books</asp:ListItem>
        </asp:RadioButtonList>
                &nbsp;&nbsp;
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <br />
                    Select Items<br />
                    <asp:ListBox ID="ListBox3" runat="server"   SelectionMode="Multiple" AutoPostBack="True" CssClass="auto-style2" OnSelectedIndexChanged="ListBox3_SelectedIndexChanged"></asp:ListBox>
                </td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Add Item" />
                    <br />
                    <br />
                    <br />
                    Your Selection:<br />
                    <asp:ListBox ID="ListBox4" runat="server" SelectionMode="Multiple"></asp:ListBox>
                    <br />
                    <br />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Remove" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="submit" OnClick="Button1_Click" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
