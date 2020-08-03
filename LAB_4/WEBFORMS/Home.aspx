<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication1.Home"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 37%;
            height: 95px;
        }
        .auto-style2 {
            width: 135px;
        }
        .auto-style3 {
            width: 37%;
        }
        .auto-style4 {
            width: 136px;
        }
        .auto-style6 {
            width: 130px;
        }
        .auto-style9 {
            width: 104px;
        }
        .auto-style11 {
            width: 164px;
        }
        .auto-style12 {
            width: 163px;
        }
        .auto-style13 {
            width: 198px;
        }
        .auto-style15 {
            width: 38%;
        }
        .auto-style16 {
            width: 150px;
        }
        
    </style>
  
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Full Name:</td>
                <td class="auto-style11">
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Display="Dynamic" ControlToValidate="TextBox1" Text="Fullname Required" ForeColor="Red" ></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Age:</td>
                <td class="auto-style11">
        <asp:TextBox ID="TextBox2" runat="server"  TextMode="Number"></asp:TextBox>
                </td>
                <td><asp:RangeValidator ID="RangeValidator1" runat="server"  Text="age between 18-50" Display="Dynamic" ForeColor="Red"
            ControlToValidate="TextBox2" MaximumValue="50" MinimumValue="18" Type="Integer"></asp:RangeValidator></td>
            </tr>
            <tr>
                <td class="auto-style2">Password:</td>
                <td class="auto-style11"><asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
&nbsp;<table class="auto-style3">
            <tr>
                <td class="auto-style4">Confirm Password:</td>
                <td class="auto-style12">
        <asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td><asp:CompareValidator ID="CompareValidator1" runat="server" Display="Dynamic" ForeColor="Red" ErrorMessage="Password is not same"  
        ControlToCompare="TextBox3" ControlToValidate="TextBox4"></asp:CompareValidator></td>
            </tr>
            <tr>
                <td class="auto-style4">Gender:</td>
                <td class="auto-style12"> <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem Selected="True">Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:RadioButtonList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Mobile No :</td>
                <td class="auto-style12"><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
                <td><asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" Display="Dynamic" ForeColor="Red"   
        ErrorMessage="10 digit number" ControlToValidate="TextBox5"   
        ValidationExpression="\d{10}"></asp:RegularExpressionValidator></td>
            </tr>
        </table>
        <table class="auto-style15">
            <tr>
                <td class="auto-style16">Hobbies:</td>
                <td class="auto-style13"> <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem>coding</asp:ListItem>
            <asp:ListItem>music</asp:ListItem>
            <asp:ListItem>reading</asp:ListItem>
            <asp:ListItem>gaming</asp:ListItem>
        </asp:CheckBoxList>
                </td>
                <td class="auto-style9">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style16">State:</td>
                <td class="auto-style13">
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
            
        <asp:ListItem Value="0">-- Select State--</asp:ListItem>
            <asp:ListItem>Gujrat</asp:ListItem>
            <asp:ListItem>Maharastra</asp:ListItem>
        </asp:DropDownList>
                </td>
                <td class="auto-style9">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style16">City:</td>
                <td class="auto-style13"><asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem Value="0">-- Select City--</asp:ListItem>
        </asp:DropDownList>
                </td>
                <td class="auto-style9">&nbsp;</td>
            </tr>
        </table>
        <table class="auto-style3">
            <tr>
                <td class="auto-style6">PAN number:</td>
                <td class="auto-style11"> <asp:TextBox ID="TextBox6" runat="server" OnTextChanged="TextBox6_TextChanged"></asp:TextBox>
                </td>
                <td><asp:CustomValidator ID="CustomValidator1" runat="server" ClientValidationFunction="UserCustomValidate"  
            ControlToValidate="TextBox6"   
            ErrorMessage="Should be 10 Digit and start with either letter ‘B” or ‘A’. "   
            Display="Dynamic" ForeColor="Red" SetFocusOnError="True" OnServerValidate="UserCustomValidate"></asp:CustomValidator></td>
            </tr>
            <tr>
                <td class="auto-style6">
        <asp:Button ID="Button1" runat="server" Text="submit" OnClick="Button1_Click" />
                </td>
                <td class="auto-style11">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">
                    &nbsp;</td>
                <td class="auto-style11"></td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label><br />
        <asp:Label ID="Label2" runat="server"></asp:Label><br />
        <asp:Label ID="Label3" runat="server"></asp:Label><br />
        <asp:Label ID="Label4" runat="server"></asp:Label><br />
        <asp:Label ID="Label5" runat="server"></asp:Label><br />
        <asp:Label ID="Label6" runat="server"></asp:Label><br />
        <asp:Label ID="Label7" runat="server"></asp:Label><br />
        <asp:Label ID="Label8" runat="server"></asp:Label><br />
        <asp:Label ID="Label9" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
