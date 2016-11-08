using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Wedding_Project
{
    public partial class Invoice_Page : System.Web.UI.Page
    {
        ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
           
            ServiceReference1.Decor_Invoice[] listofdecorinvoicetobedisplayed;
            ServiceReference1.Venue_Invoice[] listofvenueinvoicetobedisplayed;
            if (HttpContext.Current.Session["ClientLoggedIn"] != null)
            {
               
                listofdecorinvoicetobedisplayed = proxy.GetListofDecorInvoice((int) HttpContext.Current.Session["ClientId"]);
               

                for (int i = 0; i< listofdecorinvoicetobedisplayed.Length;i++)
                {
                    TableRow row = new TableRow();
                    TableCell Name = new TableCell();
                    TableCell Price = new TableCell();
                    TableCell Quantity = new TableCell();
                    TableCell TypeofDecor = new TableCell();

                    Name.Text = listofdecorinvoicetobedisplayed[i].NAME;
                    Price.Text = (listofdecorinvoicetobedisplayed[i].PRICE * listofdecorinvoicetobedisplayed[i].QUANTITY).ToString();
                    Quantity.Text = listofdecorinvoicetobedisplayed[i].QUANTITY.ToString();
                    TypeofDecor.Text = listofdecorinvoicetobedisplayed[i].TYPE_OF_DECOR;
                   
                    row.Cells.Add(Name);
                    row.Cells.Add(Price);
                    row.Cells.Add(Quantity);
                    row.Cells.Add(TypeofDecor);

                    myTable1.Rows.Add(row);
                }

                listofvenueinvoicetobedisplayed = proxy.GetListofVenueInvoice((int)HttpContext.Current.Session["ClientId"]);

                for (int i = 0; i < listofvenueinvoicetobedisplayed.Length; i++)
                {
                    TableRow row = new TableRow();
                    TableCell Name = new TableCell();
                    TableCell startbook = new TableCell();
                    TableCell endbook = new TableCell();
                    TableCell deposit = new TableCell();

                    Name.Text = listofvenueinvoicetobedisplayed[i].VENUE_NAME;
                    startbook.Text = (listofvenueinvoicetobedisplayed[i].START_BOOKING_DATE).ToString();
                    endbook.Text = listofvenueinvoicetobedisplayed[i].END_BOOKING_DATE.ToString();
                    deposit.Text = listofvenueinvoicetobedisplayed[i].DEPOSIT.ToString();

                    row.Cells.Add(Name);
                    row.Cells.Add(startbook);
                    row.Cells.Add(endbook);
                    row.Cells.Add(deposit);

                    myTable2.Rows.Add(row);

                }
            }
            else
            {
                Response.Redirect("Login_Page.aspx");
            }
        }
    }
}