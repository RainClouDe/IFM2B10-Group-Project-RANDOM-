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

            for(int i = 0;i< flowerbouquetlist.Length;i++)
            {
                for(int k = 0;k<decorlist.Length;k++)
                {
                    if(decorlist[k].DEC_ITEM_ID == flowerbouquetlist[i].DEC_ITEM_ID)
                    {
                        testdiv.InnerHtml = "<IMG SRC='App_Media\\Flower_Decor\\" + decorlist[k].DEC_IMAGE_PATH + "'/>";
                        testdiv.InnerHtml += "<br>" + "Flower Name: " + decorlist[k].DEC_NAME;
                        testdiv.InnerHtml += "<br>" + "Flower Colour: " + decorlist[k].DEC_COLOUR;
                        testdiv.InnerHtml += "<br>" + "Price : R" + decorlist[k].DEC_PRICE;
                        testdiv.InnerHtml += "<br>" + "Type of Decor: " + decorlist[k].DEC_TYPE;
                        testdiv.InnerHtml += "<br>" + "Manufaturer: " + decorlist[k].DEC_MAKE;
                        testdiv.InnerHtml += "<br>" + "Type of Flower: " + flowerbouquetlist[i].FB_TYPE_OF_FLOWER;
                        testdiv.InnerHtml += "<br>" + "Estimated life span: " + flowerbouquetlist[i].FB_LIFE_SPAN + " days";
                    }
                }
            }
        }
    }
}