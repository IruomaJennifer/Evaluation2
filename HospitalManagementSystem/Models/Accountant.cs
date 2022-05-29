using HospitalManagementSystem.DataStores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class Accountant
    {
        public virtual int Id { get; set; }
        public virtual string FullName { get; set; }
        public virtual Hospital Hospital { get; set; }
        
        public virtual Bill ResolveBill(Bill bill)
        {
            bill.OutstandingAmount = bill.TotalAmount - bill.AmountPaid;

            if (bill.OutstandingAmount > 0)
            {
                bill.Patient.HasOutstanding = true;
                MyDataStore<Patient>.Update(bill.Patient);
            }
            
            return bill;
        }

    }
}
