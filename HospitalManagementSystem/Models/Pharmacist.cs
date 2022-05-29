using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class Pharmacist
    {
        public virtual int Id { get; set; }
        public virtual string FullName { get; set; }
        public virtual Hospital Hospital { get; set; }
        public virtual HashSet<Drug> AvailableDrugs { get; set; }

        public Pharmacist()
        {
            //Hospital=new Hospital();
            //AvailableDrugs=new HashSet<Drug>();
        }

        public virtual List<Drug> GetDrugs(List<string> prescription)
        {
            
            var patientDrugList = new List<Drug>();
            for (int i = 0; i < prescription.Count; i++)
            {
                foreach (var drug in AvailableDrugs)
                {
                    if (drug.Name.Equals(prescription[i]))
                    {
                        drug.CountOfPurchase++;
                        patientDrugList.Add(drug);
                        
                    }
                }
               
            }
            return patientDrugList;
        }
    }
}
