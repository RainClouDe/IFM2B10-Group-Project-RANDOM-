using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Wedding_Project
{
    public partial class Admin_Home_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(HttpContext.Current.Session["AdminLoggedIn"] != null)
            {
                Master_Page mymasterpage = (Master_Page)Page.Master;

                HtmlAnchor MyLnk = (HtmlAnchor)this.Master.FindControl("login");
                HtmlAnchor MyLnk1 = (HtmlAnchor)this.Master.FindControl("registration");
                HtmlAnchor MyLnk2 = (HtmlAnchor)this.Master.FindControl("cart");
                HtmlAnchor MyLnk3 = (HtmlAnchor)this.Master.FindControl("basket");
                HtmlAnchor MyLnk4 = (HtmlAnchor)this.Master.FindControl("home");

                MyLnk.Visible = false;
                MyLnk1.Visible = false;
                MyLnk2.Visible = false;
                MyLnk3.Visible = false;

                MyLnk4.HRef = "Admin_Home_Page.aspx";
            }
            else
            {
                Response.Redirect("Login_Page.aspx");
            }

        }
    }
}