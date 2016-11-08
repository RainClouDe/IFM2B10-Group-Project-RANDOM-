using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Wedding_Project
{
    public partial class Venue_Information_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
            ServiceReference1.Venue[] venues;
            ServiceReference1.Venue_Contractor[] contractors;
            ServiceReference1.Photographer[] photographers;
            ServiceReference1.Videoagrapher[] videographers;
            ServiceReference1.Disc_Jockey[] diskJockeys;
            ServiceReference1.Master_of_Ceremony[] masterOfCeremonies;

            venues = service.GetAllVenues();

            int venueIndex = Convert.ToInt32(Request.QueryString["VenueID"]) - 1;

            venueInfo.InnerHtml = "<img src='App_Media\\Venue\\" + venues[venueIndex].VN_IMAGE_PATH + "' width=1200 height=400 /> </ br>";
            venueInfo.InnerHtml += "<p>Venue: " + venues[venueIndex].VN_NAME + "</p>";
            venueInfo.InnerHtml += "<p>Address: " + venues[venueIndex].VN_STREET_ADDRESS + "</p>";
            venueInfo.InnerHtml += "<p>Capacity: " + venues[venueIndex].VN_CAPACITY.ToString() + "</p>";
            venueInfo.InnerHtml += "<p>Price: " + venues[venueIndex].VN_PRICE.ToString() + "</p>";
            venueInfo.InnerHtml += "<p>Location: " + venues[venueIndex].VN_COORDINATES + "</p>";
            venueInfo.InnerHtml += "<p>Table Capacity: " + venues[venueIndex].VN_TABLECAPACITY.ToString() + "</p>";
            venueInfo.InnerHtml += "<p>Table Description: " + venues[venueIndex].VN_TABLEDESCRIPTION + "</p>";
            
            contractors = service.GetAllContractors();
            photographers = service.GetAllPhotographers();
            videographers = service.GetAllVideoGraphers();
            diskJockeys = service.GetAllDiskJockeys();
            masterOfCeremonies = service.GetAllMasterOfCeremonies();

            for (int i = 0; i < contractors.Length; i++)
            {
                if (contractors[i].VN_ID == (venueIndex + 1) & contractors[i].VNC_TYPE == 1)
                {
                    photographerInfo.InnerHtml = "<br /> <br /> <br /> <br /> <br /> <h5>Photographers available</h5>";
                    photographerInfo.InnerHtml += "<ul>";
                    break;
                }

            }
            for (int i = 0; i < contractors.Length; i++)
            {
                if (contractors[i].VN_ID == venueIndex + 1 & contractors[i].VNC_TYPE == 1)
                {
                    photographerInfo.InnerHtml += "<li><a href='Photographer_Information_Page.aspx?PhotographerID=" + contractors[i].VNC_ID + "'>" + contractors[i].VNC_NAME + "</a></li>";
                    photographerInfo.InnerHtml += "<br />";
                }
            }
            photographerInfo.InnerHtml += "</ul>";

            for (int i = 0; i < contractors.Length; i++)
            {
                if (contractors[i].VN_ID == (venueIndex + 1) & contractors[i].VNC_TYPE == 2)
                {
                    photographerInfo.InnerHtml = "<br /> <br /> <br /> <br /> <br /> <h5>Photographers available</h5>";
                    photographerInfo.InnerHtml += "<ul>";
                    break;
                }

            }
            for (int i = 0; i < contractors.Length; i++)
            {
                if (contractors[i].VN_ID == venueIndex + 1 & contractors[i].VNC_TYPE == 2)
                {
                    videographerInfo.InnerHtml += "<li><a href='Videographer_Information_Page.aspx?VideographerID=" + contractors[i].VNC_ID + "'>" + contractors[i].VNC_NAME + "</a></li>";
                    videographerInfo.InnerHtml += "<br />";
                }
            }
            videographerInfo.InnerHtml += "</ul>";

            for (int i = 0; i < contractors.Length; i++)
            {
                if(contractors[i].VN_ID == (venueIndex + 1) & contractors[i].VNC_TYPE == 3)
                {
                    diskJockeyInfo.InnerHtml = "<br /> <br /> <br /> <br /> <br /> <h5>Disk Jockeys available</h5>";
                    diskJockeyInfo.InnerHtml += "<ul>";
                    break;
                }

            }
            for (int i = 0; i < contractors.Length; i++)
            {
                if (contractors[i].VN_ID == venueIndex + 1 & contractors[i].VNC_TYPE == 3)
                {
                    diskJockeyInfo.InnerHtml += "<li><a href='Disk_Jockey_Information_Page.aspx?DiskJockeyID=" + contractors[i].VNC_ID + "'>" + contractors[i].VNC_NAME + "</a></li>";
                    diskJockeyInfo.InnerHtml += "<br />";
                }
            }
            diskJockeyInfo.InnerHtml += "</ul>";

            for (int i = 0; i < contractors.Length; i++)
            {
                if (contractors[i].VN_ID == (venueIndex + 1) & contractors[i].VNC_TYPE == 4)
                {
                    diskJockeyInfo.InnerHtml = "<br /> <br /> <br /> <br /> <br /> <h5>Disk Jockeys available</h5>";
                    diskJockeyInfo.InnerHtml += "<ul>";
                    break;
                }

            }
            for (int i = 0; i < contractors.Length; i++)
            {
                if (contractors[i].VN_ID == venueIndex + 1 & contractors[i].VNC_TYPE == 4)
                {
                    masterOfCeremoniesInfo.InnerHtml += "<li><a href='Master_Of_Ceremonies_Information_Page.aspx?MasterOfCeremoniesID=" + contractors[i].VNC_ID + "'>" + contractors[i].VNC_NAME + "</a></li>";
                    masterOfCeremoniesInfo.InnerHtml += "<br />";
                }
            }
            masterOfCeremoniesInfo.InnerHtml += "</ul>";
        }
    }
}