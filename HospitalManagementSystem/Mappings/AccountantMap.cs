using FluentNHibernate.Mapping;
using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Mappings
{
    public class AccountantMap:ClassMap<Accountant>
    {
        public AccountantMap()
        {
            Id(x => x.Id);
            Map(x => x.FullName);
            HasOne(x => x.Hospital);
        }
    }
}
