using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Players_and_Monsters
{
    internal class Hero
    {
        public string username;
        public string level;
        public string Username { get; set; }
        public int Level { get; set; }
        public Hero() { }

        public Hero(string username, int level)
        {
            Username = username;
            Level = level;
        }

        public override string ToString()
        {
            return $"Username: {Username}, Level: {Level}";
        }
    }
}
