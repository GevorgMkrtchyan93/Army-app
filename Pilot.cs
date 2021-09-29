using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyApp
{
    class Pilot:IShoot,ISpy
    {
        public void ToShoot()
        {
            Console.WriteLine("SU 57 psh-psh");
        }
    }
}
