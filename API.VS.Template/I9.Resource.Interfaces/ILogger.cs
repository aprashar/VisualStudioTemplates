﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I9.$resource$.Interfaces
{
    public interface ILogger
    {
        void WriteCriticalLog(ILog message);
       
    }
}