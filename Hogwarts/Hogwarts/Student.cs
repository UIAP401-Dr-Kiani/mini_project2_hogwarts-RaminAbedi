﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    internal class Student : Authorized
    {
        public string PassedClasses { get; set; }
        public int Semester { get; set; }
    }
}
