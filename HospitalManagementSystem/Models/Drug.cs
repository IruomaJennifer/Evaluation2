using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class Drug
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual decimal Price { get; set; }
        public virtual int CountOfPurchase { get; set; } = 0;
        public virtual ISet<Pharmacist> Pharmacists { get; set; }

        public Drug()
        {
            Pharmacists = new HashSet<Pharmacist>();
        }

        public Drug(string name,decimal price):this()
        {
            Price = price;
            Name = name;
        }
    }
}
