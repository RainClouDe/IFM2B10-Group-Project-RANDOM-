using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Wedding_Project
{
    public partial class Add_Venue_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string address = txtAddress.Text;
            int capacity = int.Parse(txtCapacity.Text);
            int price = int.Parse(txtPrice.Text);
            string coordinates = txtCoordinates.Text;
            string image = txtImage.Text;
            int tableCapacity = int.Parse(txtTableCapacity.Text);
            string tableDescription = txtTableDescription.Text;
            int deposit = int.Parse(txtDeposit.Text);

            ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
            service.addVenue(name, capacity, coordinates, deposit, address, image, tableDescription, price, tableCapacity);
            Response.Redirect("Venue_Page.aspx");
        }
    }
}