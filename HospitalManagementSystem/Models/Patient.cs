using HospitalManagementSystem.DataStores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class Patient
    {
        public virtual int HospitalNumber { get; set; }
        public virtual string PatientName { get; set; }
        public virtual string ContactNo { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual bool HasOutstanding { get; set; }
        public virtual MedicalHistory MedicalHistory { get; set; }
        public virtual Appointment Appointment { get; set; }

        public virtual Appointment BookAppointment(Hospital hospital,Doctor doctor,DateTime time)
        {
            var appointment = new Appointment(this, doctor, time, hospital);
            IDataStore<Appointment>.Create(appointment);
            return appointment;
        }
    }
}
