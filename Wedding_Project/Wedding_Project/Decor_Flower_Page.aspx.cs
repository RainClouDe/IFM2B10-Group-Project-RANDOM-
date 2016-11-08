using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Wedding_Project
{
    public partial class Decor_Flower_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client();
            ServiceReference1.Flower_bouquet[] flowerbouquetlist;
            ServiceReference1.Decor[] decorlist;

            flowerbouquetlist = proxy.GetAllFlowers();
            decorlist = proxy.GetAllDecorItems();
            
            for (int i = 0; i < flowerbouquetlist.Length; i++)
            {
                for (int j = 0; j < decorlist.Length; j++)
                {
                    if (decorlist[j].DEC_ITEM_ID == flowerbouquetlist[i].DEC_ITEM_ID)
                    {
                        col1.InnerHtml += "<br /> <br />";
                        col1.InnerHtml += "<p>Flower Name: " + decorlist[j].DEC_NAME + "<p>";
                        col1.InnerHtml += "<p>Flower Colour: " + decorlist[j].DEC_COLOUR + "</p>";
                        col1.InnerHtml += "<p>Estimated life span: " + flowerbouquetlist[i].FB_LIFE_SPAN + " days</p> ";
                        col1.InnerHtml += "<p>" + "Manufaturer: " + decorlist[j].DEC_MAKE + "</p>";
                        col1.InnerHtml += "<p>" + "Type of Decor: " + decorlist[j].DEC_TYPE + "</p>";
                        col1.InnerHtml += "<p>" + "Type of Flower: " + flowerbouquetlist[i].FB_TYPE_OF_FLOWER + "</p>";
                        col1.InnerHtml += "<IMG class='auto - style11' SRC='App_Media\\" + decorlist[j].DEC_IMAGE_PATH + "' width=250 height=200 />";
                        col1.InnerHtml += "<p>Price : R" + decorlist[j].DEC_PRICE + "</p>";
                        col1.InnerHtml += "<a href='Shopping_Cart_Page.aspx?DecID= " + decorlist[j].DEC_ITEM_ID.ToString() + " '>" + " Add to Cart " + "</a>";
                    }
                }
            }
        }

      
    }
}