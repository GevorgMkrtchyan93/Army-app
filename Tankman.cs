using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyApp
{
    class Tankman : IShoot
    {
        public void ToShoot()
        {
            Console.WriteLine("T 90 psh-psh");
        }
    }
}
