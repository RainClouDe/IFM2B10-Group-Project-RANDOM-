using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Wedding_Project
{
    public partial class Master_Of_Ceremonies_Information_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
            ServiceReference1.Venue_Contractor[] contractors;
            ServiceReference1.Master_of_Ceremony[] masterOfCeremonies;

            contractors = service.GetAllContractors();
            masterOfCeremonies = service.GetAllMasterOfCeremonies();

            int masterOfCeremoniesIndex = Convert.ToInt32(Request.QueryString["MasterOfCeremoniesID"]) - 1;

            for (int i = 0; i < masterOfCeremonies.Length; i++)
            {
                if (contractors[masterOfCeremoniesIndex].VNC_ID == masterOfCeremonies[i].VNC_ID)
                {
                    masterOfCeremoniesInfo.InnerHtml += "<h4>Dj Name: " + masterOfCeremonies[i].MC_STAGENAME + "</h4>";
                }
            }

            masterOfCeremoniesInfo.InnerHtml += "<p>Name: " + contractors[masterOfCeremoniesIndex].VNC_NAME + "</p>";
            masterOfCeremoniesInfo.InnerHtml += "<p>Surname: " + contractors[masterOfCeremoniesIndex].VNC_SURNAME + "</p>";
            masterOfCeremoniesInfo.InnerHtml += "<p>E-mail: " + contractors[masterOfCeremoniesIndex].VNC_EMAIL_ADDRESS + "</p>";
            masterOfCeremoniesInfo.InnerHtml += "<p>Phone Number: 0" + contractors[masterOfCeremoniesIndex].VNC_PHONE_NUMBER.ToString() + "</p>";
            masterOfCeremoniesInfo.InnerHtml += "<p>Rate: " + contractors[masterOfCeremoniesIndex].VNC_RATE.ToString() + "</p>";
        }
    }
}