using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class ClassA
    {
        public int GetNumber()
        {
            Random rand = new Random();

            int i = rand.Next(0, 99);

            return i;
        }
    }
}
