using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Wedding_Project
{

    public static class MessageBox
    {
        public static void show(this Page Page, String message)
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(),
                "MessageBox",
                "<script language='javascript'>alert('" + message + "');</script>");
        }

    }
    

    public partial class Shopping_Cart_Page : System.Web.UI.Page
    {

        ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client();
        int loggedInClientID;
        protected void Page_Load(object sender, EventArgs e)
        {
    
            ServiceReference1.Cart_Table[] tableCartList;
           

            if (HttpContext.Current.Session["ClientLoggedIn"] != null)
            {
                if (Request.QueryString["DecID"] != null)
                {
                    int decorID = Int32.Parse(Request.QueryString["DecID"]);

                    loggedInClientID = (int) HttpContext.Current.Session["ClientId"];

                    proxy.addToCartTable(loggedInClientID, decorID, 0, 5, null, null);

                }
                
                tableCartList = proxy.GetListOfCartItems((int)HttpContext.Current.Session["ClientId"]);

                for (int i = 0; i < tableCartList.Length; i++)
                {
                    if(tableCartList[i].DEC_ITEM_ID != 0)
                    {
                        ServiceReference1.Decor DecorItemFromCart = proxy.returnSpecificDecorItem((int)tableCartList[i].DEC_ITEM_ID);


                        testdiv.InnerHtml += "<IMG SRC='App_Media\\" + DecorItemFromCart.DEC_IMAGE_PATH + "'/>";

                        testdiv.InnerHtml += "<br>" + "Name: " + DecorItemFromCart.DEC_NAME;
                        testdiv.InnerHtml += "<br>" + "Quantity: " + tableCartList[i].Quantity;
                        testdiv.InnerHtml += "<br>" + "Price: R" + DecorItemFromCart.DEC_PRICE * tableCartList[i].Quantity;
                    }
                    else if (tableCartList[i].DEC_ITEM_ID == 0)
                    {
                        ServiceReference1.Venue VenueItemFromCart = proxy.returnSpecificVenueItem((int) tableCartList[i].VN_ID);

                        testdiv.InnerHtml += "<IMG SRC='App_Media\\" + VenueItemFromCart.VN_IMAGE_PATH + "'/>";

                        testdiv.InnerHtml += "<br>" + "Name of the venue: " + VenueItemFromCart.VN_NAME;
                        testdiv.InnerHtml += "<br>" + "From: " + tableCartList[i].Venue_Booking_Start;
                        testdiv.InnerHtml += "<br>" + "To: " + tableCartList[i].Venue_Booking_End;
                        testdiv.InnerHtml += "<br>" + "Deposit: R" + VenueItemFromCart.VN_DEPOSIT;

                    }
                }
            }
            else
            {
                Response.Redirect("Login_Page.aspx");
            }
        }

        protected void btncheckout_Click(object sender, EventArgs e)
        {

            ServiceReference1.Cart_Table[] carttablelist;

            carttablelist = proxy.GetListOfCartItems((int)HttpContext.Current.Session["ClientId"]);

            for(int i=0;i<carttablelist.Length;i++)
            {

                MessageBox.show(this, carttablelist[i].Quantity.ToString());
                if (carttablelist[i].DEC_ITEM_ID != 0) // if the decor item id is not equal to 0 add it to the database
                {
                    
                    ServiceReference1.Decor decoritemtoaddtoinvoice = proxy.returnSpecificDecorItem((int) carttablelist[i].DEC_ITEM_ID);

                    proxy.addDecorInvoice((int)HttpContext.Current.Session["ClientId"], decoritemtoaddtoinvoice.DEC_NAME, (decimal)decoritemtoaddtoinvoice.DEC_PRICE, (int)carttablelist[i].Quantity, decoritemtoaddtoinvoice.DEC_TYPE);

                }
                else if(carttablelist[i].DEC_ITEM_ID == 0)
                {
                    ServiceReference1.Venue venueitemtoaddtoinvoice = proxy.returnSpecificVenueItem((int) carttablelist[i].VN_ID);
                    
                    proxy.addVenueInvoice((int)HttpContext.Current.Session["ClientId"], (int) carttablelist[i].VN_ID, venueitemtoaddtoinvoice.VN_NAME, carttablelist[i].Venue_Booking_Start, carttablelist[i].Venue_Booking_End, (decimal) venueitemtoaddtoinvoice.VN_DEPOSIT);

                }

                
            }
            proxy.removeFromCartable((int)HttpContext.Current.Session["ClientId"]);
            Response.Redirect("Invoice_Page.aspx");
        }
    }
}