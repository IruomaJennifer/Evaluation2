using FluentNHibernate.Mapping;
using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Mappings
{
    public class HospitalMap:ClassMap<Hospital>
    {
        public HospitalMap()
        {
            Id(x => x.Id);
            Map(x => x.HospitalName);
            HasMany(x => x.Doctors);
            HasMany(x => x.Nurses);
            HasMany(x => x.Pharmacists);
            HasOne(x => x.Receptionist);
            HasOne(x => x.Accountant);
            HasMany(x => x.Patients);
            
        }
    }
}
