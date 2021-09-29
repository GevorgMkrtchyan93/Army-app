using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyApp
{
    class SpecialForces : ISpy, IShoot
    {
        private bool command;
        public void ToShoot()
        {
            if (command)
            {
                Console.WriteLine("AK 103 psh-psh");
            }
            if (!command)
            {
                Console.WriteLine("To search");
            }
        }
    }
}
