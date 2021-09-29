using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyApp
{
    class Sailor : ISpy,IShoot
    {
        public void ToShoot()
        {
            Console.WriteLine("Admiral Garshkov psh-psh");
        }
    }
}
