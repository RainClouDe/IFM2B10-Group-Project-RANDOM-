using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Wedding_Project
{
    public partial class Photographer_Information_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
            ServiceReference1.Venue_Contractor[] contractors;

            contractors = service.GetAllContractors();

            int photographerIndex = Convert.ToInt32(Request.QueryString["PhotographerID"]) - 1;

            photographerInfo.InnerHtml += "<p>Name: " + contractors[photographerIndex].VNC_NAME + "</p>";
            photographerInfo.InnerHtml += "<p>Surname: " + contractors[photographerIndex].VNC_SURNAME + "</p>";
            photographerInfo.InnerHtml += "<p>E-mail: " + contractors[photographerIndex].VNC_EMAIL_ADDRESS + "</p>";
            photographerInfo.InnerHtml += "<p>Phone Number: 0" + contractors[photographerIndex].VNC_PHONE_NUMBER.ToString() + "</p>";
            photographerInfo.InnerHtml += "<p>Rate: " + contractors[photographerIndex].VNC_RATE.ToString() + "</p>";
        }
    }
}