using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;






namespace Wedding_Project
{



    public partial class Venue_Page : System.Web.UI.Page
    {
        ServiceReference1.Service1Client service;



        protected void Page_Load(object sender, EventArgs e)
        {
            service = new ServiceReference1.Service1Client();
            ServiceReference1.Venue[] venues;
            

            venues = service.GetAllVenues();
            

            for (int i = 0; i < venues.Length; i++)
            {
                col1.InnerHtml += "<br /> <br />";
                col1.InnerHtml += "<a href='Venue_Information_Page.aspx?VenueID=" + venues[i].VN_ID + "'><img src='App_Media\\Venue\\" + venues[i].VN_IMAGE_PATH + "' width=500 height=400 /></a>";
                col1.InnerHtml += "<h3>Venue: <a href='Venue_Information_Page.aspx?VenueID=" + venues[i].VN_ID + "'>" + venues[i].VN_NAME + "</a></h3>";
                col1.InnerHtml += "<p>Address: " + venues[i].VN_STREET_ADDRESS + "</p>";
                col1.InnerHtml += "<p>Capacity: " + venues[i].VN_CAPACITY.ToString() + "</p>";
                col1.InnerHtml += "<p>Price: " + venues[i].VN_PRICE.ToString() + "</p>";
                col1.InnerHtml += "<a href='Shopping_Cart_Page.aspx?VenID= " + venues[i].VN_ID.ToString() + " '>" + " Add to Cart " + "</a>";
            }
            //if user is an administrator. They can add a venue to the database
            col1.InnerHtml += "<br /><a href='Add_Venue_Page.aspx'>Add Venue</a>";
        }

        protected void btnSort_Click(object sender, EventArgs e)
        {
            service = new ServiceReference1.Service1Client();
            ServiceReference1.Venue[] sortedVenues;
            sortedVenues = service.SortVenues();
            col1.InnerHtml = "<br>";
            for (int i = 0; i < sortedVenues.Length; i++)
            {
                col1.InnerHtml += "<br /> <br />";
                col1.InnerHtml += "<a href='Venue_Information_Page.aspx?VenueID=" + sortedVenues[i].VN_ID + "'><img src='App_Media\\Venue\\" + sortedVenues[i].VN_IMAGE_PATH + "' width=500 height=400 /></a>";
                col1.InnerHtml += "<h3>Venue: <a href='Venue_Information_Page.aspx?VenueID=" + sortedVenues[i].VN_ID + "'>" + sortedVenues[i].VN_NAME + "</a></h3>";
                col1.InnerHtml += "<p>Address: " + sortedVenues[i].VN_STREET_ADDRESS + "</p>";
                col1.InnerHtml += "<p>Capacity: " + sortedVenues[i].VN_CAPACITY.ToString() + "</p>";
                col1.InnerHtml += "<p>Price: " + sortedVenues[i].VN_PRICE.ToString() + "</p>";
                col1.InnerHtml += "<a href='Shopping_Cart_Page.aspx?VenID= " + sortedVenues[i].VN_ID.ToString() + " '>" + " Add to Cart " + "</a>";
            }
        }
    }
}