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
        public virtual Hospital Hospital { get; set; }
        

        public override Appointment BookAppointment(Hospital hospital, Doctor doctor, DateTime time)
        {
            Appointment = new Appointment(this, doctor, time, hospital);
            IDataStore<Appointment>.Create(Appointment);
            return Appointment;

        }
    }
}
