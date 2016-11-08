using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Wedding_Project
{


  


    public partial class Wedding_Planner_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client();
            ServiceReference1.Wedding_Planner[] weddingplannerlist;
            ServiceReference1.Person[] personlist;
            
            weddingplannerlist = proxy.GetAllWeddingPlanners();
            personlist = proxy.GetPerson();

            for (int i = 0; i < weddingplannerlist.Length; i++)
            {

                for(int j = 0; j < personlist.Length; j++)
                {
                    if(personlist[j].P_ID == weddingplannerlist[i].P_ID)
                    {
                        col1.InnerHtml += "<p>" + personlist[j].P_NAME +"</p>";
                        col1.InnerHtml += "<p>" + personlist[j].P_SURNAME +"</p>";
                        col1.InnerHtml += "<p>" + personlist[j].P_PHONE_NUMBER +"</p>";
                        col1.InnerHtml += "<p>" + personlist[j].P_EMAIL_ADDRESS +"</p>";
                        col1.InnerHtml += "<p>" + personlist[j].P_STREET_ADDRESS +"</p>";
                        col1.InnerHtml += "<p>" + weddingplannerlist[i].WP_HISTORYDESCRIPTION + "</p>";
                        col1.InnerHtml += "<IMG SRC='App_Media\\" + weddingplannerlist[i].WP_IMAGELOCATION + "' width=200 height=150 />";
                    }
                }
            }
        }
    }
}