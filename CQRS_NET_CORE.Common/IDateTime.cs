using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_NETCore.Common
{
    public interface IDateTime
    {
        DateTime Now { get; }
    }
}
