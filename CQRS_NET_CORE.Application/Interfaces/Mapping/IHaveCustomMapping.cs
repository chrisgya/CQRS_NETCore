﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_NETCore.Application.Interfaces.Mapping
{
    public interface IHaveCustomMapping
    {
        void CreateMappings(Profile configuration);
    }
}
