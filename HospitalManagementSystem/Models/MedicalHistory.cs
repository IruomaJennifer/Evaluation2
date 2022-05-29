using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class MedicalHistory
    {
        public virtual int Id { get; set; }
        public virtual List<string> PastConditions{ get; set; }
        public virtual Patient Patient { get; set; }

    }
}
