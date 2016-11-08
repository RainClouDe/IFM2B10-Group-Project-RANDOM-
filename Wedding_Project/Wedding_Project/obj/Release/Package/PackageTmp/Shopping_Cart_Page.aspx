<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Page.Master" AutoEventWireup="true" CodeBehind="Shopping_Cart_Page.aspx.cs" Inherits="Wedding_Project.Shopping_Cart_Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div id="testdiv" runat="server">

    </div>
    <br>
    <asp:Button ID="btncheckout" runat="server" Text="Check out" OnClick="btncheckout_Click" />
</asp:Content>
