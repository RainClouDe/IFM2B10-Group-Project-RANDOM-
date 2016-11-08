using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Wedding_Project
{
    public partial class Disk_Jockey_Information_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
            ServiceReference1.Venue_Contractor[] contractors;
            ServiceReference1.Disc_Jockey[] diskJockeys;

            contractors = service.GetAllContractors();
            diskJockeys = service.GetAllDiskJockeys();

            int diskJockeyIndex = Convert.ToInt32(Request.QueryString["DiskJockeyID"]) - 1;

            for(int i = 0; i < diskJockeys.Length; i++)
            {
                if (contractors[diskJockeyIndex].VNC_ID == diskJockeys[i].VNC_ID)
                {
                    diskJockeyInfo.InnerHtml += "<h4>Dj Name: " + diskJockeys[i].DJ_STAGENAME + "</h4>";
                    diskJockeyInfo.InnerHtml += "<p>Name: " + contractors[diskJockeyIndex].VNC_NAME + "</p>";
                    diskJockeyInfo.InnerHtml += "<p>Surname: " + contractors[diskJockeyIndex].VNC_SURNAME + "</p>";
                    diskJockeyInfo.InnerHtml += "<p>E-mail: " + contractors[diskJockeyIndex].VNC_EMAIL_ADDRESS + "</p>";
                    diskJockeyInfo.InnerHtml += "<p>Phone Number: 0" + contractors[diskJockeyIndex].VNC_PHONE_NUMBER.ToString() + "</p>";
                    diskJockeyInfo.InnerHtml += "<p>Rate: " + contractors[diskJockeyIndex].VNC_RATE.ToString() + "</p>";
                }
            }
        }
    }
}