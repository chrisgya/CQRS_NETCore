using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_NETCore.Domain.Entities
{
    public class Shipper
    {
        public Shipper()
        {
            Orders = new HashSet<Order>();
        }

        public int ShipperId { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }

        public ICollection<Order> Orders { get; private set; }
    }
}
