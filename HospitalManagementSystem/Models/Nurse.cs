using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class Nurse
    {
        public virtual int Id { get; set; }
        public virtual string FullName { get; set; }
        public virtual Hospital Hospital { get; set; }
    }
}
