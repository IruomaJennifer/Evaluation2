using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class Bill
    {
        public virtual int Id { get; set; }
        public virtual decimal TotalAmount { get; set; }
        public virtual decimal AmountPaid { get; set; }
        public virtual decimal OutstandingAmount { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Hospital Hospital { get; set; }

        public Bill()
        {

        }

        public Bill(Patient patient,decimal totalAmt,decimal amountPaid=0)
        {
            TotalAmount = totalAmt;//add a patient and a hospital
            AmountPaid = amountPaid;
            Patient = patient;
        }
    }
}
