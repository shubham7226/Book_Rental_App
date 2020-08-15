<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="WebApplication3.Edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 172px;
        }
        .auto-style3 {
            width: 100%;
            height: 83px;
        }
        .auto-style4 {
            width: 80px;
        }
        .auto-style5 {
            width: 83px;
            height: 33px;
        }
        .auto-style6 {
            width: 172px;
            height: 33px;
        }
        .auto-style7 {
            height: 33px;
        }
        .auto-style8 {
            width: 83px;
        }
        .auto-style9 {
            width: 80px;
            height: 29px;
        }
        .auto-style10 {
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style5">Enter ID:-</td>
                <td class="auto-style6">
                   <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    <asp:Button ID="Button1" runat="server" Text="Fetch Details " Width="132px" OnClick="Button1_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    <p>Details are:-</p>
    </div>
        <asp:Panel ID="Panel1" runat="server">
            <table class="auto-style3">
               <tr>
                <td class="auto-style4">Name:-</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Sem:-</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
                <tr>
                <td class="auto-style4">Mob_No:-</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">Email-Id</td>
                <td class="auto-style10">
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style10"></td>
            </tr>
            
            
                </table>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Update Details" OnClick="Button2_Click" />
        </asp:Panel>
        
    </form>
</body>
</html>
