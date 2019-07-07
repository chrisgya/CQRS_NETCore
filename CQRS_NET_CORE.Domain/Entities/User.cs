using CQRS_NETCore.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_NETCore.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }

        public AdAccount AdAccount { get; set; }
    }
}
