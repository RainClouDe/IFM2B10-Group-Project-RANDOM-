using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace Service
{
    
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        private WeddingPlanningDataDataContext db = new WeddingPlanningDataDataContext();
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }






        /// <summary>
        /// start of chunk of code that returns lists of objects from the database
        /// </summary>
        /// <returns> List<Object> </returns>
        public List<Person> GetPerson()
        {
           
            var query = from s in db.Persons
                        select s;
            if(query != null)
            {
                return query.ToList();
            }
         
                return null;
        }

        public List<Wedding_Planner> GetAllWeddingPlanners()
        {

            var query = from s in db.Wedding_Planners
                        select s;
            if(query != null)
            {
                return query.ToList();
            }

                return null;
        }

        public List<Venue> GetAllVenues()
        {

            var query = from s in db.Venues
                        select s;
            if (query != null)
            {
                return query.ToList();
            }

            return null;
        }



        public string Test()
        {
            Person p = new Person();
            p.P_NAME = "Holly";

            var query = (from s in db.Persons select s).First();

            if(query != null)
            {
                return ((Person)query).P_STREET_ADDRESS;
            }

            return p.P_NAME;

        }

        public List<Decor> GetAllDecorItems()
        {
            var query = from s in db.Decors
                        select s;
            if (query != null)
            {
                return query.ToList();
            }

            return null;
        }

        public List<Flower_bouquet> GetAllFlowers()
        {
            var query = from s in db.Flower_bouquets
                        select s;
            if (query != null)
            {
                return query.ToList();
            }

            return null;
        }

        public List<Cutlery> GetAllCutlery()
        {
            var query = from s in db.Cutleries
                        select s;
            if (query != null)
            {
                return query.ToList();
            }

            return null;
        }


        public List<Cart_Table> GetListOfCartItems(int ClientID)
        {
            var query = from s in db.Cart_Tables
                        where s.CL_ID == ClientID 
                        select s;
            if (query != null)
            {
                return query.ToList();
            }

            return null;
        }

        public List<Plate> GetListOfPlates()
        {
            var query = from s in db.Plates
                        select s;
            if (query != null)
            {
                return query.ToList();
            }

            return null;
        }


        public List<Wedding_Welcome_Card> GetAllWelcomecards()
        {
            var query = from s in db.Wedding_Welcome_Cards
                        select s;
            if (query != null)
            {
                return query.ToList();
            }

            return null;
        }

        /// <summary>
        /// end of chunk of code that returns lists of objects from the database
        /// </summary>
        /// <returns> List<Object> </returns>









        public Boolean Authentication(String Username, String Password)
        {
            var query = from s in db.Login_Details
                        where s.LOG_LOGIN_USERNAME == Username && s.LOG_LOGIN_PASSWORD == Password select s;
            if (query != null)
            {
                return true;
            }

            return false;
        }








        /// <summary>
        /// Start of Funtions that add stuff to the database 
        /// </summary>
  
        public void addClient(String Name, String Surname, String Phonenumber, String Email, String Streetaddress, String Username, String Password)
        {
            Person objperson = new Person();

            objperson.P_NAME = Name;
            objperson.P_SURNAME = Surname;
            objperson.P_PHONE_NUMBER = Phonenumber;
            objperson.P_EMAIL_ADDRESS = Email;
            objperson.P_STREET_ADDRESS = Streetaddress;
            objperson.P_USERNAME = Username;

            db.Persons.InsertOnSubmit(objperson);
          

            Login_Detail objlogin = new Login_Detail();
            objlogin.LOG_LOGIN_USERNAME = Username;
            objlogin.LOG_LOGIN_PASSWORD = Password;

            db.Login_Details.InsertOnSubmit(objlogin);

            db.SubmitChanges();

            Client objclient = new Client();
            objclient.P_ID = objperson.P_ID;
            objclient.LOGIN_ID = objlogin.LOGIN_ID;

            db.Clients.InsertOnSubmit(objclient);

            db.SubmitChanges();
        }
        public void addToCartTable(int UserID, int DecorItemID, int VenueID, int quantity, DateTime? VenueBooking)// Date time example new Datetime(2015, 1, 18)
        {

            Cart_Table itemToAddToCart = new Cart_Table();
            itemToAddToCart.CL_ID = UserID;
            itemToAddToCart.DEC_ITEM_ID = DecorItemID;
            itemToAddToCart.VN_ID = VenueID;
            itemToAddToCart.Quantity = quantity;
            itemToAddToCart.Venue_Booking = VenueBooking;

            db.Cart_Tables.InsertOnSubmit(itemToAddToCart);
            db.SubmitChanges();

        }


        /// <summary>
        /// End of Funtions that add stuff to the database 
        /// </summary>





        /// <summary>
        /// Start of functions that return specific items from tables
        /// </summary>    
        public int returnLoginID(string Username)
        {
            
            var query = from s in db.Login_Details
                        where s.LOG_LOGIN_USERNAME == Username 
                        select s;
            if (query != null)
            {
                return query.First().LOGIN_ID;
            }
            
            return 0;
        }

        public Decor returnSpecificDecorItem(int DecorID)
        {
            var query = from s in db.Decors
                        where s.DEC_ITEM_ID == DecorID
                        select s;
            if (query != null)
            {
                return query.First();
            }

            return null;
        }

        public int returnClientId(int LoginID)
        {
            var query = from s in db.Clients
                        where s.LOGIN_ID == LoginID
                        select s;
            if (query != null)
            {
                return query.First().CL_ID;
            }

            return 0;
        }

        public int returnPersonID(string Username)
        {
       

            return 0;
        }

      

        /// <summary>
        /// End of functions that return specific items from tables
        /// </summary> 
    }
}   
