using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Driver
    {
        private IVehicle vehicletodrive;
        public Driver(IVehicle vehicle)
        {
            this.vehicletodrive = vehicle;
        }
        public bool Manuveurvehicle( bool alertoffendingDriver)
        {
            bool success = false;
            if (alertoffendingDriver)
            {
              success =  this.vehicletodrive.ApplyBrakes() && this.vehicletodrive.HonkHorn();
            }
            else
            {
               success= this.vehicletodrive.ApplyBrakes();
            }

            return success;
        }
    }
}
