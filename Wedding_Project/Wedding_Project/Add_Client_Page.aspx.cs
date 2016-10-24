using System;
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
            "<script language='javascript'>alert('" + message + "');</script>");
    }

}


namespace Wedding_Project
{
    public partial class Add_Client_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncreate_Click(object sender, EventArgs e)
        {
            String name = txtname.Text;
            String surname = txtsurname.Text;
            String phonenumber = txtphonenumber.Text;
            String email = txtemail.Text;
            String username = txtusername.Text;
            String password = txtpassword.Text;
            String streetaddress = txtstreetaddress.Text;

            ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client();

            //validation checks
            proxy.addClient(name, surname, phonenumber, email, streetaddress, username, password);

            MessageBox.show(this, "Account has been created");
            
        }
    }
}