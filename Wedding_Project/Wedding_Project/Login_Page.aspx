<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Page.Master" AutoEventWireup="true" CodeBehind="Login_Page.aspx.cs" Inherits="Wedding_Project.Login_Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" /> <!-- Use latest version of rendering engine-->
    <meta name="viewport" content="width = device-width, initial-scale=1" /> <!-- allows web page size to change ccording to screen size-->

    <link href="css/bootstrap.css" rel="stylesheet" type="text/css"/>
    <link href="styles.css" rel="stylesheet" type="text/css"/>
  
 
  
</asp:Content>
 
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class="user_tables">
        <tr>
            <td class="table_header_row" colspan="3"> Login </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style9">Username:</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style9">
                <asp:TextBox ID="txtusername" runat="server" BorderColor="Blue" Width="150px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style9">Password:</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style9">
                <asp:TextBox ID="txtpassword" runat="server" BorderColor="Blue" Width="150px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style9">
                <asp:Button ID="btnlogin" runat="server" BackColor="White" BorderColor="Blue" Height="35px" Text="Login" Width="150px" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
   
    <div id="testdiv" runat="server">

    </div>

     <!--Bootstrap Links-->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.3/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>
  
</asp:Content>
