using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Wedding_Project
{
    public partial class Home_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            testdiv.InnerHtml += "<a href='Login_Page.aspx'>" + " Login " + "</a>";
            testdiv.InnerHtml += "<br> <a href='Add_Client_Page.aspx'>" + " Register " + "</a>";
            testdiv.InnerHtml += "<br> <a href='Cutlery_Page.aspx'>" + " Cutlery " + "</a>";
            testdiv.InnerHtml += "<br> <a href='Decor_Flower_Page.aspx'>" + " Flower Bouquets " + "</a>";
            testdiv.InnerHtml += "<br> <a href='Shopping_Cart_Page.aspx'>" + " View  Shopping Cart " + "</a>";
            testdiv.InnerHtml += "<br> <a href='Venue_Page.aspx'>" + " Wedding Venues " + "</a>";
            testdiv.InnerHtml += "<br> <a href='Wedding_Planner_Page.aspx'>" + " Wedding Planners " + "</a>";
            testdiv.InnerHtml += "<br> <a href='Wedding_Welcome_Card.aspx'>" + " Table Welcome Cards " + "</a>";
        }
    }
}