/*
This file is part of Winbuntu by Matt Wollam.

Winbuntu is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

Winbuntu is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with Winbuntu.  If not, see <https://www.gnu.org/licenses/>.
*/

using System;
using Newtonsoft.Json;

namespace Winbuntu
{
    // Below is a list of Winbuntu commands, for a better explination on what everything means,
    // see Utils.Command().


    /// <summary>
    /// Installs a piece of software from a local source
    /// </summary>
    public class Install : Command
    {
        public override void Execute() { Staller.Install(); }
        public override string Name => "install";
        public override string ShortName => "i";
        public override string Description => "Installs a piece of software from an installer on the system and adds is to the Winbuntu registry";
    }

    /// <summary>
    /// Uninstalls a piece of software from the machine and Winbuntu registry
    /// </summary>
    public class Uninstall : Command
    {
        public override void Execute() { Staller.Uninstall(); }
        public override string Name => "uninstall";
        public override string ShortName => "u";
        public override string Description => "Removes a piece of software from the system and removes it from the Winbuntu registry";
    }

    /// <summary>
    /// Adds a program file to Winbuntu's registry
    /// </summary>
    public class Add : Command
    {
        public override void Execute() { RegEdit.Add(); }
        public override string Name => "add";
        public override string ShortName => "a";
        public override string Description => "Adds a piece of software already installed on the system to Winbuntu's registry";
    }

    /// <summary>
    /// Removes a program file to Winbuntu's registry
    /// </summary>
    public class Remove : Command
    {
        public override void Execute() { RegEdit.Remove(); }
        public override string Name => "remove";
        public override string ShortName => "r";
        public override string Description => "Removes a piece of software from the Winbuntu registry without removing it from the system";
    }

    public class Version : Command
    {
        public override void Execute() { Console.WriteLine("Winbuntu Version: " + Util.Version); }
        public override string Name => "version";
        public override string ShortName => "v";
        public override string Description => "Prints the current Winbuntu version to the console";
    }

    /// <summary>
    /// Prints out the entire Winbuntu registry to the console
    /// </summary>
    public class Registry : Command
    {
        public override void Execute()
        {
            foreach(var entry in UseData.DataReader())
            {
                Console.WriteLine($"{entry.Title}\n\t{entry.ShortName}\n\t{entry.Execute}\n\t{entry.Target}\n\t{entry.Path}");
            }
        }
        public override string Name => "registry";
        public override string ShortName => "s";
        public override string Description => "Prints the entire Winbuntu registry to the console";
    }

    public class Run : Command
    {
        public override void Execute() { Console.WriteLine("Running software"); }
        public override string Name => "run";
        public override string ShortName => "e";
        public override string Description => "Runs a piece of software through Winbuntu";
    }

    /// <summary>
    /// Displays a help message explaining each argument in the console
    /// </summary>
    public class Help : Command
    {
        public override void Execute()
        {
            // Get spacing for tabination
            int tabination = 0;
            foreach (Command command in Util.Commands)
                tabination = command.Name.Length > tabination
                    ? command.Name.Length
                    : tabination;

            // Print help message
            Console.WriteLine("Below is a list of all commands, their shortnames, and descriptions:", ConsoleColor.Yellow);
            foreach (Command command in Util.Commands)
            {
                Console.Write("   " + command.Name, ConsoleColor.Yellow);
                for (int i = 0; i < tabination - command.Name.Length; i++)
                    Console.Write(' ');
                Console.Write(" -> " + command.ShortName, ConsoleColor.Yellow);
                Console.WriteLine(" -> " + command.Description, ConsoleColor.Yellow);
            }
        }

        public override string Name => "help";
        public override string ShortName => "h";
        public override string Description => "Displays this message";
    }
}