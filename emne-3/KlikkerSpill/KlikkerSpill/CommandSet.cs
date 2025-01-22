using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlikkerSpill
{
    internal class CommandSet
    {
        private ICommand[] _commands;
        public CommandSet(ClickerGame game)     
        {
            _commands = new ICommand[]
            {
                new ClickCommand(game),
                new UpgradeCommand(game),
                new SuperUppgradeCommand(game),
                new ExitCommand(),
            };
        }

        public void RunCommand(char command)
        {
            foreach (var cmd in _commands)
            {
                if (cmd.Character == command)
                {
                    cmd.Run();
                }
            }
        }
    }
}
