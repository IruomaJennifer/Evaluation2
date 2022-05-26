using FluentNHibernate.Mapping;
using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Mappings
{
    public class MedicalHistoryMap:ClassMap<MedicalHistory>
    {
        public MedicalHistoryMap()
        {
            Id(x => x.Id);
            Map(x => x.PastConditions);
            HasOne(x => x.Patient);
        }
    }
}
