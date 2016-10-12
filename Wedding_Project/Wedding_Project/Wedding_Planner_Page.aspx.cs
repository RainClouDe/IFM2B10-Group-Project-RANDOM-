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


    public partial class Wedding_Planner_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client();
            ServiceReference1.Wedding_Planner[] weddingplannerlist;



            weddingplannerlist = proxy.GetAllWeddingPlanners();
            
            for (int i = 0; i < weddingplannerlist.Length; i++)
            {

                
                MessageBox.show(this, weddingplannerlist[i].WP_IMAGELOCATION);
                Testdiv.InnerHtml = weddingplannerlist[i].WP_HISTORYDESCRIPTION + "<br>";
                Testdiv.InnerHtml += "<img src='App_Media/Wedding_Planner/"+weddingplannerlist[i].WP_IMAGELOCATION+"'>";
                
            }
        }
    }
}