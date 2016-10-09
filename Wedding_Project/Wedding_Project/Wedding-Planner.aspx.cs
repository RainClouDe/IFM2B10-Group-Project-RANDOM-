using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public static class MessageBox
{
    public static void show(this Page Page, String message)
    {
        Page.ClientScript.RegisterStartupScript(Page.GetType(),
            "MessageBox",
            "<script language='javascript'>alert('" +message+ "');</script>");
    }

}

namespace Wedding_Project
{
    
  
    public partial class Testing123 : System.Web.UI.Page
    {

      
    
        protected void Page_Load(object sender, EventArgs e)
        {

            ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client();
            ServiceReference1.Wedding_Planner[] weddingplannerlist;
         
 

            weddingplannerlist = proxy.GetAllWeddingPlanners();
        
            for (int i = 0; i < weddingplannerlist.Length; i++)
            {
                
                Testdiv.InnerHtml = "<IMG SRC='App_Media\\Wedding_Planner\\Test.jpg'/>";
                MessageBox.show(this, weddingplannerlist[i].WP_IMAGELOCATION);
                Testdiv.InnerHtml = "<br>" + weddingplannerlist[i].WP_HISTORYDESCRIPTION;
               

            }
          
   
           
        }
    }
}