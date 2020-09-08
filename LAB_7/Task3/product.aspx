<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="product.aspx.cs" Inherits="lab__7.product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<form id="form1" runat="server">
    <div>
    
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" CellPadding="3" DataKeyNames="pid" DataSourceID="SqlDataSource2" GridLines="Vertical" Height="183px" Width="231px" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <EditRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <Fields>
                <asp:BoundField DataField="pid" HeaderText="pid" InsertVisible="False" ReadOnly="True" SortExpression="pid" />
                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                <asp:BoundField DataField="description" HeaderText="description" SortExpression="description" />
                <asp:BoundField DataField="category" HeaderText="category" SortExpression="category" />
                <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
            </Fields>
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
        </asp:DetailsView>
        <br />
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:PRODUCTConnectionString %>" DeleteCommand="DELETE FROM [product] WHERE [pid] = @pid" InsertCommand="INSERT INTO [product] ([pid], [name], [description], [category], [price]) VALUES (@pid, @name, @description, @category, @price)" SelectCommand="SELECT * FROM [product] WHERE ([pid] = @pid)" UpdateCommand="UPDATE [product] SET [name] = @name, [description] = @description, [category] = @category, [price] = @price WHERE [pid] = @pid">
            <DeleteParameters>
                <asp:Parameter Name="pid" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="pid" Type="Int32" />
                <asp:Parameter Name="name" Type="String" />
                <asp:Parameter Name="description" Type="String" />
                <asp:Parameter Name="category" Type="String" />
                <asp:Parameter Name="price" Type="String" />
            </InsertParameters>
            <SelectParameters>
                <asp:QueryStringParameter Name="pid" QueryStringField="pid" Type="Int32" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="name" Type="String" />
                <asp:Parameter Name="description" Type="String" />
                <asp:Parameter Name="category" Type="String" />
                <asp:Parameter Name="price" Type="String" />
                <asp:Parameter Name="pid" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
