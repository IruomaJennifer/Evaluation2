using FluentNHibernate.Mapping;
using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Mappings
{
    public class DoctorMap:ClassMap<Doctor>
    {
        public DoctorMap()
        {
            Id(x => x.Id);
            Map(x => x.FullName);
            Map(x => x.ConsultationFee);
            References(x => x.Hospital);
            HasMany(x => x.Appointments);
        }
    }
}
