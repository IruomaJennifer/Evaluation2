using FluentNHibernate.Mapping;
using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Mappings
{
    public class RegisteredPatientMap:ClassMap<RegisteredPatient>
    {
        public RegisteredPatientMap()
        {
            Id(x => x.RegNo);
            Map(x => x.PatientName);
            Map(x => x.ContactNo);
            Map(x => x.Gender);
            HasOne(x => x.Appointment);
            

        }
    }
}
