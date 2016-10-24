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

  


        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client();
            ServiceReference1.Venue[] venuelist;



            venuelist = proxy.GetAllVenues();

            for (int i = 0; i < venuelist.Length; i++)
            {
                MessageBox.show(this, venuelist[i].VN_IMAGE_PATH);
                test.InnerHtml = "<IMG SRC='App_Media\\Venue\\" +venuelist[i].VN_IMAGE_PATH+ "'/>";
                test.InnerHtml += "<br>" + "Name:" + venuelist[i].VN_NAME;
                test.InnerHtml += "<br>" + "Price:" + venuelist[i].VN_PRICE;
                test.InnerHtml += "<br>" + "Street Address:" + venuelist[i].VN_STREET_ADDRESS;

            }
            }
    }
}