﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_NETCore.Domain.Exceptions
{
    public class AdAccountInvalidException : Exception
    {
        public AdAccountInvalidException(string adAccount, Exception ex)
            : base($"AD Account \"{adAccount}\" is invalid.", ex)
        {
        }
    }
}
