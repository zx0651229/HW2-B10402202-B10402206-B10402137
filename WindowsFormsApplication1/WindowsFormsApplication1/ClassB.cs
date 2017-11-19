using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class ClassB
    {
        public int Prime(int n)
        {
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n%i == 0) count++;
            }
            if (count == 2) return 1;//yes
            return 0;//no
        }
    }
}
