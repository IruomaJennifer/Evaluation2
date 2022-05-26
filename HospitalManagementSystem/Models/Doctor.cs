using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class Doctor
    {
        public virtual int Id { get; set; }
        public virtual string FullName { get; set; }
        public virtual decimal ConsultationFee { get; set; }
        public virtual Hospital Hospital { get; set; }
        public virtual Queue<Appointment> Appointments { get; set; }

        public Appointment SeePatient()
        {
            var current = Appointments.Dequeue();
            return current;
            
        }

    }
}
