<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Page.Master" AutoEventWireup="true" CodeBehind="Login_Page.aspx.cs" Inherits="Wedding_Project.Login_Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
    <br>
    <asp:TextBox ID="txtusername" runat="server"></asp:TextBox>
    <br>
    <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
    <br>
    <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
    <br>
    <asp:Button ID="btnlogin" runat="server" Text="Button" OnClick="btnlogin_Click" />
     <div id="testdiv" runat="server">
   
    </div>

</asp:Content>
