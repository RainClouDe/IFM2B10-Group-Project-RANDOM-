using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Wedding_Project
{
    public partial class Plate_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client();
            ServiceReference1.Plate[] platelist;
            ServiceReference1.Decor[] decorlist;

            platelist = proxy.GetListOfPlates();
            decorlist = proxy.GetAllDecorItems();

            for (int i = 0; i < platelist.Length; i++)
            {
                for (int k = 0; k < decorlist.Length; k++)
                {
                    if (decorlist[k].DEC_ITEM_ID == platelist[i].DEC_ITEM_ID)
                    {
                        testdiv.InnerHtml += "<IMG SRC='App_Media\\" + decorlist[k].DEC_IMAGE_PATH + "'/>";
                        testdiv.InnerHtml += "<br>" + "Name: " + decorlist[k].DEC_NAME;
                        testdiv.InnerHtml += "<br>" + "Base Colour: " + decorlist[k].DEC_COLOUR;
                        testdiv.InnerHtml += "<br>" + "Price : R" + decorlist[k].DEC_PRICE;
                        testdiv.InnerHtml += "<br>" + "Manufaturer: " + decorlist[k].DEC_MAKE;
                        testdiv.InnerHtml += "<br>" + "Design: " + platelist[i].PL_DESIGN;
                        testdiv.InnerHtml += "<br>" + "Material: " + platelist[i].PL_MATERIAL;
                        testdiv.InnerHtml += "<br>" + "Shape: " + platelist[i].PL_SHAPE + "<br>";
                        testdiv.InnerHtml += "<a href='Shopping_Cart_Page.aspx?DecID= " + decorlist[k].DEC_ITEM_ID.ToString() + " '>" + " Shop now " + "</a>";
                    }
                }
            }
        }
    }
}