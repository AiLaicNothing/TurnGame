using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBase
{
    internal class Location
    {
        //Please do copy this stuff to the real menu so it works, and replace the temp classes to the real ones.
        private bool Working = true;
        new List<TempSoldiers> Soldiers = new List<TempSoldiers>();
        new List<TempLocation> Locations = new List<TempLocation>();
        private void CurrentHabitans()
        {
            foreach(TempSoldiers Soldiers in this.Soldiers)
            {
                Soldiers.data();
            }
            foreach(TempLocation Locations  in this.Locations)
            {
                Locations.data();
            }
        }
    }
}
