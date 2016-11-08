using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Wedding_Project
{
    public partial class Cutlery_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client();
            ServiceReference1.Cutlery[] cutlerylist;
            ServiceReference1.Decor[] decorlist;

            cutlerylist = proxy.GetAllCutlery();
            decorlist = proxy.GetAllDecorItems();


            for (int i = 0; i < cutlerylist.Length; i++)
            {
                for (int k = 0; k < decorlist.Length; k++)
                {
                    if (decorlist[k].DEC_ITEM_ID == cutlerylist[i].DEC_ITEM_ID)
                    {
                        cutleryInfo.InnerHtml += "<IMG SRC='App_Media\\" + decorlist[k].DEC_IMAGE_PATH + "' width=250 height=200 />";
                        cutleryInfo.InnerHtml += "<p>" + "Name: " + decorlist[k].DEC_NAME + "</p>";
                        cutleryInfo.InnerHtml += "<p>" + "Make: " + decorlist[k].DEC_MAKE + "</p>";
                        cutleryInfo.InnerHtml += "<p>" + "Price: R" + decorlist[k].DEC_PRICE + "</p>";
                        cutleryInfo.InnerHtml += "<p>" + "Colour: " + decorlist[k].DEC_COLOUR + "</p>";
                        cutleryInfo.InnerHtml += "<p>" + "Design: " + cutlerylist[i].PL_DESIGN + "</p>";
                        cutleryInfo.InnerHtml += "<p>" + "Material: " + cutlerylist[i].PL_MATERIAL + "</p>";
                        cutleryInfo.InnerHtml += "<button type='button' class='btn btn-default btn-lg'> <span class='glyphicon glyphicon-shopping-cart' style='left: -41px; top: 0px; width: 44px; height: 34px'> <a href='Shopping_Cart_Page.aspx?DecID= " + decorlist[k].DEC_ITEM_ID.ToString() + " '>" + " Add to Cart " + "</a> </span></button>";
    }
                }
            }
        }
    }
}