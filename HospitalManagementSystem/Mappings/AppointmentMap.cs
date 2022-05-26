using FluentNHibernate.Mapping;
using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Mappings
{
    public class AppointmentMap:ClassMap<Appointment>
    {
        public AppointmentMap()
        {
            Id(x => x.Id);
            Map(x => x.AppointmentTime);
            Map(x => x.Prescription);
            References(x => x.Hospital);
            HasOne(x => x.Doctor);
            HasOne(x => x.Patient);
            HasMany(x => x.Drugs);
            HasOne(x => x.Bill);
        }
    }
}
