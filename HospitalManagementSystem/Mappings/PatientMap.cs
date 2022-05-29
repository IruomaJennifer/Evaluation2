using FluentNHibernate.Mapping;
using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Mappings
{
    public class PatientMap:ClassMap<Patient>
    {
        public PatientMap()
        {
            Id(x => x.HospitalNumber);
            Map(x => x.PatientName);
            Map(x => x.ContactNo);
            Map(x => x.Gender);
            Map(x => x.HasOutstanding);
            HasOne(x => x.MedicalHistory);
            HasOne(x => x.Appointment);
            References(x => x.Hospital);
        }
    }
}
