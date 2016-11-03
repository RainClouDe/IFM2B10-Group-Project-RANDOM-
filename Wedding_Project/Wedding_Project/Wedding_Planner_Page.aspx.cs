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



            weddingplannerlist = proxy.GetAllWeddingPlanners();

            for (int i = 0; i < weddingplannerlist.Length; i++)
            {

                MessageBox.show(this, weddingplannerlist[i].WP_IMAGELOCATION);
                Testdiv.InnerHtml += "<br>" + weddingplannerlist[i].WP_HISTORYDESCRIPTION;
                Testdiv.InnerHtml += "<IMG SRC='App_Media\\" +weddingplannerlist[i].WP_IMAGELOCATION+"'/>";

            }
        }
    }
}