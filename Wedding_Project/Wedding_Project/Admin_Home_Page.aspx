<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Page.Master" AutoEventWireup="true" CodeBehind="Admin_Home_Page.aspx.cs" Inherits="Wedding_Project.Admin_Home_Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <a href="Add_Decor_Item_Page.aspx" runat="server">Add decor item</a> <br>
    <a href="Add_Venue_Page.aspx" runat="server">Add Venue</a> <br>
    <a href="Remove_Decor_Item.aspx" runat="server">Remove decor item</a> <br>
    <a href="Remove_Venue_Page.aspx" runat="server">Remove Venue</a> <br>
    <a href="Update_Decor_Item.aspx" runat="server">Update decor item</a> <br>
    <a href="Update_Venue_Page.aspx" runat="server">Update Venue</a>
</asp:Content>
