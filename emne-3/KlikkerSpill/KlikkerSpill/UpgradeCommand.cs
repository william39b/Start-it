using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlikkerSpill
{
    internal class UpgradeCommand : ICommand
    {
        public char Character { get; } = 'k';
        private ClickerGame _game;
        public UpgradeCommand(ClickerGame game)
        {
            _game = game;
        }
        public void Run()
        {
            _game.Upgrade();
        }
    }
}
