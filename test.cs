using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Test
    {
        static void Main(string[] args)
        {
            Tiger tiger = new Tiger("tiger, ", 100);
            Lion lion = new Lion("lion, ", 200);

            tiger.Show();
            lion.Show();
        }
    }
}