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
            HasMany(x => x.Doctors).Inverse();
            HasMany(x => x.Nurses).Inverse();
            HasOne(x => x.Receptionist);
            HasOne(x => x.Accountant);
            HasMany(x => x.Patients);
        }
    }
}
