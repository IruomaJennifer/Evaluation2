using FluentNHibernate.Mapping;
using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Mappings
{
    public class BillMap:ClassMap<Bill>
    {
        public BillMap()
        {
            Id(x => x.Id);
            Map(x => x.TotalAmount);
            Map(x => x.AmountPaid);
            Map(x => x.OutstandingAmount);
            HasOne(x => x.Patient);
            HasOne(x => x.Hospital);
        }
    }
}
