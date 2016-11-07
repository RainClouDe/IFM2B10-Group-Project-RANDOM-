using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;





namespace Wedding_Project
{

  


    public partial class Venue_Booking_Page : System.Web.UI.Page
    {

        int VenueIDfrompage;
        int loggedInClientID;

        ServiceReference1.Service1Client proxy;
        

        protected void Page_Load(object sender, EventArgs e)
        {
            btnbookvenue.Enabled = false;
            proxy = new ServiceReference1.Service1Client();

            if (HttpContext.Current.Session["ClientLoggedIn"] != null)
            {
                if (Request.QueryString["VnID"] != null)
                {
                    VenueIDfrompage = Int32.Parse(Request.QueryString["VnID"]);

                    loggedInClientID = (int)HttpContext.Current.Session["ClientId"];
                }
            }
            else
            {
                Response.Redirect("Login_Page.aspx");
            }
        }
        protected void btncheckavavailability_Click(object sender, EventArgs e)
        {
            String startday = fromdrpday.SelectedValue;
            String startmonth = fromdrpmonth.SelectedValue;
            String startyear = fromdrpyear.SelectedValue;

            String startdate = startyear + "-" + startmonth + "-" + startday;

            DateTime parsestartdate = DateTime.ParseExact(startdate, "yyyy-MM-dd", null);

            String endday = todrpday.SelectedValue;
            String endmonth = todrpmonth.SelectedValue;
            String endyear = todrpyear.SelectedValue;

            String enddate = endyear + "-" + endmonth + "-" + endday;

            DateTime parseenddate = DateTime.ParseExact(enddate, "yyyy-MM-dd", null);

            if(proxy.Checkavailability(parsestartdate, parseenddate))
            {
                btnbookvenue.Enabled = true;
                testdiv.InnerHtml = "This venue is avavailable for booking";
            }
            else if(!(proxy.Checkavailability(parsestartdate, parseenddate)))
            {
                testdiv.InnerHtml = "This venue is not avavailable for booking";
            }
        }

        protected void btnbookvenue_Click(object sender, EventArgs e)
        {

            String startday = fromdrpday.SelectedValue;
            String startmonth = fromdrpmonth.SelectedValue;
            String startyear = fromdrpyear.SelectedValue;

            String startdate = startyear + "-" + startmonth + "-" + startday;

            DateTime parsestartdate = DateTime.ParseExact(startdate, "yyyy-MM-dd", null);

            String endday = todrpday.SelectedValue;
            String endmonth = todrpmonth.SelectedValue;
            String endyear = todrpyear.SelectedValue;

            String enddate = endyear + "-" + endmonth + "-" + endday;
            
            DateTime parseenddate = DateTime.ParseExact(enddate, "yyyy-MM-dd", null);

            proxy.addbooking(parsestartdate, parseenddate, VenueIDfrompage, loggedInClientID);

            proxy.addToCartTable(loggedInClientID, 0, VenueIDfrompage, 1, parsestartdate, parseenddate);

        }
    }
}