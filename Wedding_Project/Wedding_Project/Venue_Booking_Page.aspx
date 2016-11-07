<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Page.Master" AutoEventWireup="true" CodeBehind="Venue_Booking_Page.aspx.cs" Inherits="Wedding_Project.Venue_Booking_Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>

       
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="Label1" runat="server" Text="Book From:"></asp:Label>
    </br>
    <asp:Label ID="Label2" runat="server" Text="Day "></asp:Label>
    
    <asp:DropDownList id="fromdrpday" 
        runat="server"
        AutoPostBack="True">

        <asp:ListItem Value="01"> 01 </asp:ListItem>
        <asp:ListItem Value="02"> 02 </asp:ListItem>
        <asp:ListItem Value="03"> 03 </asp:ListItem>
        <asp:ListItem Value="04"> 04 </asp:ListItem>
        <asp:ListItem Value="05"> 05 </asp:ListItem>
        <asp:ListItem Value="06"> 06 </asp:ListItem>
        <asp:ListItem Value="07"> 07 </asp:ListItem>
        <asp:ListItem Value="08"> 08 </asp:ListItem>
        <asp:ListItem Value="09"> 09 </asp:ListItem>
        <asp:ListItem Value="10"> 10 </asp:ListItem>
        <asp:ListItem Value="11"> 11 </asp:ListItem>
        <asp:ListItem Value="12"> 12 </asp:ListItem>
        <asp:ListItem Value="13"> 13 </asp:ListItem>
        <asp:ListItem Value="14"> 14 </asp:ListItem>
        <asp:ListItem Value="15"> 15 </asp:ListItem>
        <asp:ListItem Value="16"> 16 </asp:ListItem>
        <asp:ListItem Value="17"> 17 </asp:ListItem>
        <asp:ListItem Value="18"> 18 </asp:ListItem>
        <asp:ListItem Value="19"> 19 </asp:ListItem>
        <asp:ListItem Value="20"> 20 </asp:ListItem>
        <asp:ListItem Value="21"> 21 </asp:ListItem>
        <asp:ListItem Value="22"> 22 </asp:ListItem>
        <asp:ListItem Value="23"> 23 </asp:ListItem>
        <asp:ListItem Value="24"> 24 </asp:ListItem>
        <asp:ListItem Value="25"> 25 </asp:ListItem>
        <asp:ListItem Value="26"> 26 </asp:ListItem>
        <asp:ListItem Value="27"> 27 </asp:ListItem>
        <asp:ListItem Value="28"> 28 </asp:ListItem>
        <asp:ListItem Value="29"> 29 </asp:ListItem>
        <asp:ListItem Value="30"> 30 </asp:ListItem>
        <asp:ListItem Value="31"> 31 </asp:ListItem>

    </asp:DropDownList>
    
    
    <asp:Label ID="Label3" runat="server" Text="Month "></asp:Label>
    <asp:DropDownList ID="fromdrpmonth" runat="server">

        <asp:ListItem Value="01"> 01 </asp:ListItem>
        <asp:ListItem Value="02"> 02 </asp:ListItem>
        <asp:ListItem Value="03"> 03 </asp:ListItem>
        <asp:ListItem Value="04"> 04 </asp:ListItem>
        <asp:ListItem Value="05"> 05 </asp:ListItem>
        <asp:ListItem Value="06"> 06 </asp:ListItem>
        <asp:ListItem Value="07"> 07 </asp:ListItem>
        <asp:ListItem Value="08"> 08 </asp:ListItem>
        <asp:ListItem Value="09"> 09 </asp:ListItem>
        <asp:ListItem Value="10"> 10 </asp:ListItem>
        <asp:ListItem Value="11"> 11 </asp:ListItem>
        <asp:ListItem Value="12"> 12 </asp:ListItem>


    </asp:DropDownList>
    <asp:Label ID="Label4" runat="server" Text="Year "></asp:Label>
    <asp:DropDownList ID="fromdrpyear" runat="server">
        
        <asp:ListItem Value="2016"> 2016 </asp:ListItem>
        <asp:ListItem Value="2017"> 2017 </asp:ListItem>
        <asp:ListItem Value="2018"> 2018 </asp:ListItem>
        <asp:ListItem Value="2019"> 2019 </asp:ListItem>
        <asp:ListItem Value="2018"> 2018 </asp:ListItem>
     
    </asp:DropDownList>

    <br>
    <br>

    <asp:Label ID="Label5" runat="server" Text="To: "></asp:Label>
    </br>
    <asp:Label ID="Label6" runat="server" Text="Day "></asp:Label>
    
    <asp:DropDownList id="todrpday" 
        runat="server"
        AutoPostBack="True">

        <asp:ListItem Value="01"> 01 </asp:ListItem>
        <asp:ListItem Value="02"> 02 </asp:ListItem>
        <asp:ListItem Value="03"> 03 </asp:ListItem>
        <asp:ListItem Value="04"> 04 </asp:ListItem>
        <asp:ListItem Value="05"> 05 </asp:ListItem>
        <asp:ListItem Value="06"> 06 </asp:ListItem>
        <asp:ListItem Value="07"> 07 </asp:ListItem>
        <asp:ListItem Value="08"> 08 </asp:ListItem>
        <asp:ListItem Value="09"> 09 </asp:ListItem>
        <asp:ListItem Value="10"> 10 </asp:ListItem>
        <asp:ListItem Value="11"> 11 </asp:ListItem>
        <asp:ListItem Value="12"> 12 </asp:ListItem>
        <asp:ListItem Value="13"> 13 </asp:ListItem>
        <asp:ListItem Value="14"> 14 </asp:ListItem>
        <asp:ListItem Value="15"> 15 </asp:ListItem>
        <asp:ListItem Value="16"> 16 </asp:ListItem>
        <asp:ListItem Value="17"> 17 </asp:ListItem>
        <asp:ListItem Value="18"> 18 </asp:ListItem>
        <asp:ListItem Value="19"> 19 </asp:ListItem>
        <asp:ListItem Value="20"> 20 </asp:ListItem>
        <asp:ListItem Value="21"> 21 </asp:ListItem>
        <asp:ListItem Value="22"> 22 </asp:ListItem>
        <asp:ListItem Value="23"> 23 </asp:ListItem>
        <asp:ListItem Value="24"> 24 </asp:ListItem>
        <asp:ListItem Value="25"> 25 </asp:ListItem>
        <asp:ListItem Value="26"> 26 </asp:ListItem>
        <asp:ListItem Value="27"> 27 </asp:ListItem>
        <asp:ListItem Value="28"> 28 </asp:ListItem>
        <asp:ListItem Value="29"> 29 </asp:ListItem>
        <asp:ListItem Value="30"> 30 </asp:ListItem>
        <asp:ListItem Value="31"> 31 </asp:ListItem>

    </asp:DropDownList>
    
    
    <asp:Label ID="Label7" runat="server" Text="Month "></asp:Label>
    <asp:DropDownList ID="todrpmonth" runat="server">

        <asp:ListItem Value="01"> 01 </asp:ListItem>
        <asp:ListItem Value="02"> 02 </asp:ListItem>
        <asp:ListItem Value="03"> 03 </asp:ListItem>
        <asp:ListItem Value="04"> 04 </asp:ListItem>
        <asp:ListItem Value="05"> 05 </asp:ListItem>
        <asp:ListItem Value="06"> 06 </asp:ListItem>
        <asp:ListItem Value="07"> 07 </asp:ListItem>
        <asp:ListItem Value="08"> 08 </asp:ListItem>
        <asp:ListItem Value="09"> 09 </asp:ListItem>
        <asp:ListItem Value="10"> 10 </asp:ListItem>
        <asp:ListItem Value="11"> 11 </asp:ListItem>
        <asp:ListItem Value="12"> 12 </asp:ListItem>


    </asp:DropDownList>
    <asp:Label ID="Label8" runat="server" Text="Year "></asp:Label>
    <asp:DropDownList ID="todrpyear" runat="server">
        
        <asp:ListItem Value="2016"> 2016 </asp:ListItem>
        <asp:ListItem Value="2017"> 2017 </asp:ListItem>
        <asp:ListItem Value="2018"> 2018 </asp:ListItem>
        <asp:ListItem Value="2019"> 2019 </asp:ListItem>
        <asp:ListItem Value="2018"> 2018 </asp:ListItem>
     
    </asp:DropDownList>
    <br>
    <asp:Button ID="btncheckavavailability" runat="server" Text="Check Availability" OnClick="btncheckavavailability_Click" />
    <br>
        <div id="testdiv" runat="server">

        </div>
    <br>
    <asp:Button ID="btnbookvenue" runat="server" Text="Book Venue" OnClick="btnbookvenue_Click" />

</asp:Content>

