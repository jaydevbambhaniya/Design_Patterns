﻿using Factory.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Model
{
    public abstract class BaseEmployee
    {
        public int Id;
        public string? Name;
        public EmployeeType Type;

    }
}
