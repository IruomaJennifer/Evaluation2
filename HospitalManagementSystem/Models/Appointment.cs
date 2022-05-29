using HospitalManagementSystem.DataStores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class Appointment
    {
        public virtual int Id { get; set; }
        public virtual Hospital Hospital { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual List<string> Prescription { get; set; }
        public virtual List<Drug> Drugs { get; set; }
        public virtual DateTime AppointmentTime { get; set; }
        public virtual Bill Bill { get; set; }


        public Appointment()
        {
            Prescription = new List<string>();
        }
        public Appointment(Patient patient,Doctor doctor,DateTime time):this()
        {
       
            Doctor = doctor;
            Patient = patient;
            AppointmentTime = time;
        }

        public virtual void ReviewMedicalCondition()
        {
            foreach (var item in Patient.MedicalHistory.PastConditions)
            {
                Console.WriteLine($"{item} ");
            }
        }

        public virtual void AdministerDrugs(string drugName)
        {
            Prescription.Add(drugName);
            
            //then get a list of drugs from the pharmacist
        }
        public virtual IList<Drug> GetPatientDrugs(Pharmacist pharmacist)
        {
            Drugs= pharmacist.GetDrugs(Prescription);
            return Drugs;
        }

        public virtual Bill ManageBilling(Accountant accountant, decimal paymentMade=0)
        {
            decimal amtToPay = 0;
            foreach (var drug in Drugs)
            {
                amtToPay += drug.Price;
            }
            amtToPay += Doctor.ConsultationFee;
            Bill = new Bill(amtToPay,paymentMade);

            var recieptOfPayment = accountant.ResolveBill(Bill);
            MyDataStore<Bill>.Create(recieptOfPayment);
            return recieptOfPayment;
        }

    }
}
