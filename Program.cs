using System;
using System.Collections.Generic;

namespace ArmyApp
{
    class Program
    {

        static void Main(string[] args)
        {
            GeneralStaff generalStaffInfantryman = new GeneralStaff(new Infantryman());
            GeneralStaff generalStaffTankman = new GeneralStaff(new Tankman());
            GeneralStaff generalStaffPilot = new GeneralStaff((IShoot)new Pilot());
            GeneralStaff generalStaffSailor = new GeneralStaff((IShoot)new Sailor());
            GeneralStaff generalStaffSpecialForces = new GeneralStaff((IShoot)new SpecialForces());

            List<GeneralStaff> generals = new List<GeneralStaff>();
           
            generals.Add(generalStaffInfantryman);
            generals.Add(generalStaffTankman);
            generals.Add(generalStaffPilot);
            generals.Add(generalStaffSailor);
            generals.Add(generalStaffSpecialForces);

            for (int i = 0; i < generals.Count; i++)
            {
                generals[i].DoCommand();
            }

            GeneralStaff generalStaffSapper = new GeneralStaff(new Sapper());
            GeneralStaff generalStaffPilot1 = new GeneralStaff((ISpy)new Pilot());
            GeneralStaff generalStaffSailor1 = new GeneralStaff((ISpy)new Sailor());
            GeneralStaff generalStaffSpecialForces1 = new GeneralStaff((ISpy)new SpecialForces());

            List<GeneralStaff> generals1 = new List<GeneralStaff>();
           
            generals1.Add(generalStaffSapper);
            generals1.Add(generalStaffPilot1);
            generals1.Add(generalStaffSailor1);
            generals1.Add(generalStaffSpecialForces1);

            for (int i = 0; i < generals1.Count; i++)
            {
                generals1[i].DoSearch();
            }
        }
    }
}
