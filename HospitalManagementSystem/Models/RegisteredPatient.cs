using HospitalManagementSystem.DataStores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class RegisteredPatient:Patient
    {
        public virtual Guid RegNo { get; set; }
       
        

        public override Appointment BookAppointment( Doctor doctor, DateTime time)
        {
            Appointment = new Appointment(this, doctor, time);
            MyDataStore<Appointment>.Create(Appointment);
            return Appointment;

        }
    }
}
