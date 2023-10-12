﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSolarSystem
{
    public struct Location
    {
        public int X { get; set; }
        public int Y { get; set; }
        public override string ToString()
        {
            return $"X= {X}, Y= {Y}";
        }
    }
}
