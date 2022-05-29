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
        public virtual IList<Appointment> Appointments { get; set; }

        public Doctor()
        {
            Appointments = new List<Appointment>();
       
        }

        public virtual Appointment SeePatient()
        {
            var current = Appointments[0];
            Appointments.Remove(current);
            return current;
            
        }

    }
}
