<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Page.Master" AutoEventWireup="true" CodeBehind="Invoice_Page.aspx.cs" Inherits="Wedding_Project.Invoice_Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 <asp:Table ID="myTable1" runat="server" Width="50%"> 
    <asp:TableRow>
        <asp:TableCell>Name of decor item</asp:TableCell>
        <asp:TableCell>Price</asp:TableCell>
        <asp:TableCell>Quantity</asp:TableCell>
        <asp:TableCell>Type of decor</asp:TableCell>
    </asp:TableRow>
</asp:Table>

    <br>

<asp:Table ID="myTable2" runat="server" Width="50%"> 
    <asp:TableRow>
        <asp:TableCell>Name of the venue</asp:TableCell>
        <asp:TableCell>Booked from</asp:TableCell>
        <asp:TableCell>Booked until</asp:TableCell>
        <asp:TableCell>Deposit</asp:TableCell>
    </asp:TableRow>
</asp:Table>
</asp:Content>
