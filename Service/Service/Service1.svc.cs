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
    }
}   
