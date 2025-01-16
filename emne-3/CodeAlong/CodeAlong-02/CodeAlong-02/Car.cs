using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlong_02
{
    internal class Car
    {
        public int Id { get; private set; }
        public int Speed { get; private set; }
        public int StartSpeed { get; private set; }
        public int TopSpeed { get; private set; }
        public int Distance { get; private set; }

        public Car(int id, int startSpeed)
        {
            Id = id;
            Speed = 0;
            StartSpeed = startSpeed;
            TopSpeed = 0;
            Distance = 0;
        }

        public void RandomSpeed()
        {
            var random = new Random();
            var newSpeed = random.Next(60, 200);
            TopSpeed = newSpeed;
        }

        public void StartRace()
        {
            int distance = 10000;
            int sec = 0;

            while (true)
            {
                sec++;
                if (Distance < (distance / 2))
                {
                    SpeedUp();
                }
                else
                {
                    SlowDown();
                }
                //Console.WriteLine($"Car{Id} speed: {Speed} distance: {Distance}");

                if (Distance >= distance)
                {
                    Console.WriteLine($"Car{Id} finished the race in {sec} seconds");
                    break;
                }
            }

        }

        private void SpeedUp()
        {
            if (Speed <= TopSpeed)
            {
                Speed += StartSpeed;
            }
            Distance += Speed;
        }

        private void SlowDown()
        {
            if (Speed > StartSpeed)
            {
                Speed -= StartSpeed;
            }
            Distance += Speed;
        }

    }
}

