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
            ServiceReference1.Person[] x;
            //var test = proxy.Test();
            //GridView1.DataSource = proxy.GetPerson();
            //GridView1.DataBind();
            string test = proxy.Test();
            x = proxy.GetPerson();
            //MessageBox.show(this, test.P_NAME);
            Testdiv.InnerHtml = x[0].P_EMAIL_ADDRESS;
            


            //MessageBox.show(this, "is this working?");

            //list = proxy.GetPerson("Ivan").ToList();
            // MessageBox.show(this, GetPerson.GetLe);

            for (int i = 0;i < 1;i++)
            {
               // MessageBox.show(this, GetPerson[i].P_NAME);
            }
           
        }
    }
}