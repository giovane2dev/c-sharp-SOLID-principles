﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAbstractClass.Abstraction
{
    internal class Y : X
    {
        sealed protected override void Test()
        {
            Console.WriteLine("Sealed modifier test - Derived class");
        }
    }
}
