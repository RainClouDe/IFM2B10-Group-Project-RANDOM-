<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Page.Master" AutoEventWireup="true" CodeBehind="Decor_Flower_Page.aspx.cs" Inherits="Wedding_Project.Decor_Flower_Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style11 {
            width: 218px;
            height: 201px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
      <div class ="container-pages">
                <div class ="row">
                    <asp:Repeater ID="Repeater1" runat="server">

                    </asp:Repeater>
                    <div class="col-lg-4 col-md-4 col-sm-8 col-xs-12" id="col1" runat="server">
                        
                    </div>      
                </div>
            </div>
    <!-- Bootstrap Styling-->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.3/jquery.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    
</asp:Content>
