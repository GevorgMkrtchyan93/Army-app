using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyApp
{
    
    public interface IShoot
    {
        void ToShoot();
    }
    public interface ISpy
    {
        void ToShoot();
    }
    class GeneralStaff
    {
        
        private readonly IShoot _shoot;
        private readonly ISpy _spy;
        public GeneralStaff(IShoot shoot)
        {
            _shoot = shoot;
        }
        public GeneralStaff(ISpy spy)
        {
            _spy = spy;
        }

       public void DoCommand()
        {
            _shoot.ToShoot();
        }
        public void DoSearch()
        {
            _spy.ToShoot();
        }

    }
}
