using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlong_02
{
    internal class RaceTrack
    {
        public RaceTrack(Car car) 
        {
            car.RandomSpeed();
            car.StartRace();
        }
    }
}
