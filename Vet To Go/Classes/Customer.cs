using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vet_To_Go.Classes
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String HomePhone { get; set; }
        public String CellPhone { get; set; }
        public String EmailAddress { get; set; }
        public String Address1 { get; set; }
        public String Address2 { get; set; }
        public String City { get; set; }
        public String ZipCode { get; set; }
        public String State { get; set; }

        public Customer()
        {

        }

        public Customer(String firstName, String lastName, String email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EmailAddress = email;
        }
    }
}
