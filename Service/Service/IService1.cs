using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    
    [ServiceContract]
    public interface IService1
    {
     
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
        [OperationContract]
        List<Person> GetPerson();

        [OperationContract]
        List<Wedding_Planner> GetAllWeddingPlanners();

        [OperationContract]
        string Test();

        [OperationContract]
        List<Venue> GetAllVenues();

        [OperationContract]
        List<Decor> GetAllDecorItems();

        [OperationContract]
        List<Flower_bouquet> GetAllFlowers();

        [OperationContract]
        List<Cutlery> GetAllCutlery();

        [OperationContract]
        Boolean Authentication(String Username, String Password);

        [OperationContract]
        void addClient(String Name, String Surname, String Phonenumber, String Email, String Streetaddress, String Username, String Password);

        [OperationContract]
        void addToCartTable(int UserID, int DecorItemID, int VenueID, int quantity, DateTime? VenueBooking);

        [OperationContract]
        int returnLoginID(string Username);
        

        [OperationContract]
        Decor returnSpecificDecorItem(int DecorID);

        [OperationContract]
        int returnClientId(int LoginID);

        [OperationContract]
        List<Cart_Table> GetListOfCartItems(int ClientID);
    }
   
  

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }

 
}
