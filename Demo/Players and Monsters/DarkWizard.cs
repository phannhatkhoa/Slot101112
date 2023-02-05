using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Players_and_Monsters
{
    internal class DarkWizard:Wizard
    {
        public DarkWizard() { }
        public DarkWizard(string username, int level) : base(username, level)
        {
        }
    }
}
