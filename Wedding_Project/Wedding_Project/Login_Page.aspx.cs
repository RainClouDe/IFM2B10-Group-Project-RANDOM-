using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Wedding_Project
{
    public partial class Login_Page : System.Web.UI.Page
    {
        public ServiceReference1.Service1Client proxy = null;
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            String username = txtusername.Text;
            String password = txtpassword.Text;
            ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client();

            if (proxy.Authentication(username, password))
            {
                HttpContext.Current.Session["ClientLoggedIn"] = true;
                Response.Redirect("Decor_Flower_Page.aspx");
                //Redirect 
            }
           /* else
            {
                testdiv.InnerHtml = "Incorrect password or username";
            }*/
        }
    }
}