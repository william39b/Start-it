using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlikkerSpill
{
    internal class ClickerGame
    {
        public int Points = 0;
        private int _pointsPerClick = 1;
        private int _pointsPerClickIncrease = 1;

        public void Click()
        {
            Points += _pointsPerClick;
        }

        public void Upgrade()
        {
            if (Points < 10) return;
            Points -= 10;
            _pointsPerClick += _pointsPerClickIncrease;
        }

        public void SuperUpgrade()
        {
            if (Points < 100) return;
            Points -= 100;
            _pointsPerClickIncrease++;
        }
    }
}
