﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Players_and_Monsters
{
    internal class Wizard: Hero
    {
        public Wizard() { }
        public Wizard(string username, int level) : base(username, level)
        {
        }
    }
}
