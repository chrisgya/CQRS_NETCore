using CQRS_NETCore.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_NETCore.Infrastructure
{
    public class MachineDateTime : IDateTime
    {
        public DateTime Now => DateTime.Now;

        public int CurrentYear => DateTime.Now.Year;
    }
}
