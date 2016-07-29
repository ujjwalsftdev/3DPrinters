<%@ Page Title="" Language="C#" MasterPageFile="~/3D.Master" AutoEventWireup="true" Codefile="Printers.aspx.cs" Inherits="_3D_printers.Printers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    Select a Printer:
    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDB" DataTextField="name" DataValueField="name" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
    </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDB" runat="server" ConnectionString="<%$ ConnectionStrings:PrintersConnection %>" SelectCommand="SELECT [name] FROM [Printers] ORDER BY [name]"></asp:SqlDataSource>
    
</p>
    <p>
        <asp:Label ID="labelOp" runat="server" Text="Label"></asp:Label>
</p>
</asp:Content>
