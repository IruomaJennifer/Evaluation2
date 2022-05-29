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
            HasOne(x => x.Patient);
            Map(x => x.PastConditions);
                //.Table("PastConditionsTable")
                //.Element("PastConditionId", m => { m.Type<string>(); });
        }
    }
}
