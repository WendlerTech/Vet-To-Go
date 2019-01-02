using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vet_To_Go.Classes
{
    public class Invoice
    {
        public int InvoiceID { get; set; }
        public int CustomerID { get; set; }
        public int VisitID { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal Amount { get; set; }
        public Boolean IsPaid { get; set; }

        public Invoice()
        {

        }

        public Invoice(int invoiceID, int custID)
        {
            this.InvoiceID = invoiceID;
            this.CustomerID = custID;
        }
    }
}
