using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class Hospital
    {
        public virtual int Id { get; set; }
        public virtual string HospitalName { get; set; }
        public virtual HashSet<Doctor> Doctors { get; set; }
        public virtual HashSet<Nurse> Nurses { get; set; }
        public virtual HashSet<Pharmacist> Pharmacists { get; set; }
        public virtual Receptionist Receptionist { get; set; }
        public virtual Accountant Accountant { get; set; }
        public virtual HashSet<Patient> Patients { get; set; }
    }
}
