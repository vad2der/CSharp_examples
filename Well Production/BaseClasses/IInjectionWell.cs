﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClasses
{
    public interface IInjectionWell : IWell
    {
        WaterType WaterType { get; set; }
    }
}
