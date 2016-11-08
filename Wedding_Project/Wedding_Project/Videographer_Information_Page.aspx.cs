using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Wedding_Project
{
    public partial class Videographer_Information_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
            ServiceReference1.Venue_Contractor[] contractors;

            contractors = service.GetAllContractors();

            int videographerIndex = Convert.ToInt32(Request.QueryString["VideographerID"]) - 1;

            videographerInfo.InnerHtml += "<p>Name: " + contractors[videographerIndex].VNC_NAME + "</p>";
            videographerInfo.InnerHtml += "<p>Surname: " + contractors[videographerIndex].VNC_SURNAME + "</p>";
            videographerInfo.InnerHtml += "<p>E-mail: " + contractors[videographerIndex].VNC_EMAIL_ADDRESS + "</p>";
            videographerInfo.InnerHtml += "<p>Phone Number: 0" + contractors[videographerIndex].VNC_PHONE_NUMBER.ToString() + "</p>";
            videographerInfo.InnerHtml += "<p>Rate: " + contractors[videographerIndex].VNC_RATE.ToString() + "</p>";
        }
    }
}