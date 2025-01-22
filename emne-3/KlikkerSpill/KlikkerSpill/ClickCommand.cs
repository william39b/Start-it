using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlikkerSpill
{
    internal class ClickCommand : ICommand
    {
        public char Character { get; } = ' ';
        private ClickerGame _game;

        public ClickCommand(ClickerGame game)
        {
            _game = game;      
        }

        public void Run()
        {
            _game.Click();
        }
    }
}
