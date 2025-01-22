using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlikkerSpill
{
    internal class SuperUppgradeCommand : ICommand
    {
        public char Character { get; } = 's';
        private ClickerGame _game;

        public SuperUppgradeCommand(ClickerGame game)
        {
            _game = game;
        }
        public void Run()
        {
            _game.SuperUpgrade();
        }
    }
}
