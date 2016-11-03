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
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client();
            ServiceReference1.Cart_Table[] tableCartList;
            int loggedInClientID;

            if (HttpContext.Current.Session["ClientLoggedIn"] != null)
            {
                if (Request.QueryString["DecID"] != null)
                {
                    int decorID = Int32.Parse(Request.QueryString["DecID"]);

                    loggedInClientID = (int)HttpContext.Current.Session["ClientId"];

                    proxy.addToCartTable(loggedInClientID, decorID, 0, 5, null);

                }
                
                tableCartList = proxy.GetListOfCartItems((int)HttpContext.Current.Session["ClientId"]);

                for (int i = 0; i < tableCartList.Length; i++)
                {

                    ServiceReference1.Decor DecorItemFromCart = proxy.returnSpecificDecorItem((int) tableCartList[i].DEC_ITEM_ID);

                    testdiv.InnerHtml += "<IMG SRC='App_Media\\" + DecorItemFromCart.DEC_IMAGE_PATH + "'/>";
                   
                    testdiv.InnerHtml += "<br>" + "Name: " + DecorItemFromCart.DEC_NAME;
                    testdiv.InnerHtml += "<br>" + "Quantity: " + tableCartList[i].Quantity;
                    testdiv.InnerHtml += "<br>" + "Price: R" + DecorItemFromCart.DEC_PRICE;

                }
            }
            else
            {
                Response.Redirect("Login_Page.aspx");
            }
        }
    }
}