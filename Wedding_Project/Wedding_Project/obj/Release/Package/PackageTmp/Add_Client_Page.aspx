<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Page.Master" AutoEventWireup="true" CodeBehind="Add_Client_Page.aspx.cs" Inherits="Wedding_Project.Add_Client_Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
    <br />
    <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Surname"></asp:Label>
    <br />
    <asp:TextBox ID="txtsurname" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Phone Number"></asp:Label>
    <br />
    <asp:TextBox ID="txtphonenumber" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label6" runat="server" Text="Email address"></asp:Label>
    <br />
    <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label4" runat="server" Text="Choose your username"></asp:Label>
    <br />
    <asp:TextBox ID="txtusername" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label5" runat="server" Text="Create a password"></asp:Label>
    <br />
    <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btncreate" runat="server" Text="Create Account" OnClick="btncreate_Click" />
</asp:Content>
