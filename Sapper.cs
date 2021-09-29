using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyApp
{
    class Sapper : ISpy
    {
        public void ToShoot()
        {
            Console.WriteLine("Explore and remove mines");
        }
    }
}
