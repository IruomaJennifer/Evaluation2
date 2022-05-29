using FluentNHibernate.Mapping;
using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Mappings
{
    public class PharmacistMap:ClassMap<Pharmacist>
    {
        public PharmacistMap()
        {
            Id(x => x.Id);
            Map(x => x.FullName);
            References(x => x.Hospital);
            HasManyToMany(x => x.AvailableDrugs);

        }
    }
}
