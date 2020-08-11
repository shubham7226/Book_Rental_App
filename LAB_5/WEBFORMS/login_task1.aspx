<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login_task1.aspx.cs" Inherits="lab321.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat ="server">
        <div>
            username:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <p>
            password:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <br />
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Remeber me" OnCheckedChanged="CheckBox1_CheckedChanged" />
        <br />
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        &nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Delete" />
        </p>
    </form>
</body>
</html>
