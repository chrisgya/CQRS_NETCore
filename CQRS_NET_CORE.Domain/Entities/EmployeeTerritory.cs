using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_NETCore.Domain.Entities
{
    public class EmployeeTerritory
    {
        public int EmployeeId { get; set; }
        public string TerritoryId { get; set; }

        public Employee Employee { get; set; }
        public Territory Territory { get; set; }
    }
}
