using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Wedding_Project
{
    public partial class Wedding_Welcome_Card : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client();
            ServiceReference1.Wedding_Welcome_Card[] welcomecardslist;
            ServiceReference1.Decor[] decorlist;

            welcomecardslist = proxy.GetAllWelcomecards();
            decorlist = proxy.GetAllDecorItems();

            for (int i = 0; i < welcomecardslist.Length; i++)
            {
                for (int k = 0; k < decorlist.Length; k++)
                {
                    if (decorlist[k].DEC_ITEM_ID == welcomecardslist[i].DEC_ITEM_ID)
                    {
                        testdiv.InnerHtml += "<IMG SRC='App_Media\\" + decorlist[k].DEC_IMAGE_PATH + "'/>";
                        testdiv.InnerHtml += "<br>" + "Name: " + decorlist[k].DEC_NAME;
                        testdiv.InnerHtml += "<br>" + "Colour: " + decorlist[k].DEC_COLOUR;
                        testdiv.InnerHtml += "<br>" + "Price : R" + decorlist[k].DEC_PRICE;
                        testdiv.InnerHtml += "<br>" + "Type of Decor: " + decorlist[k].DEC_TYPE;
                        testdiv.InnerHtml += "<br>" + "Manufaturer: " + decorlist[k].DEC_MAKE;
                        testdiv.InnerHtml += "<br>" + "Type of material: " + welcomecardslist[i].PC_TYPE_OF_MATERIAL;
                        testdiv.InnerHtml += "<br>" + "Pattern: " + welcomecardslist[i].PC_TYPE_OF_MATERIAL + " days" + "<br>";
                        testdiv.InnerHtml += "<a href='Shopping_Cart_Page.aspx?DecID= " + decorlist[k].DEC_ITEM_ID.ToString() + " '>" + " Shop now " + "</a>";
                    }
                }
            }
        }
    }
}