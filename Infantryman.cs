using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyApp
{
    class Infantryman : IShoot
    {
        private bool enemy;
        public void ToShoot()
        {
            if (enemy)
            {
                Console.WriteLine("AK 74 psh-psh");
            }
            if (!enemy)
            {
                Console.WriteLine("Sit in the treanch");
            }
        }
    }
}
