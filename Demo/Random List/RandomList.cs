using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_List
{
    internal class RandomList:List<String>
    {
        private Random rnd;
        public RandomList()
        {
            rnd = new Random();
        }
        public string RemoveRandomElement()
        {
            int index = rnd.Next(0, this.Count);
            string str = this[index];
            this.RemoveAt(index);
            return str;
        }
    }
}
