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
using System.Collections.Generic;

namespace Winbuntu
{
    class Program
    {
        /// <summary>
        /// Main entry point for command line Winbuntu
        /// </summary>
        /// <param name="args"> The set of arguments that tell winbuntu what to do </param>
        public static List<string> _args = new List<string>();
        static void Main(string[] args)
        {
            // Double checks that arguments were actually passed
            if(args.Length != 0) 
            { 
                    // Check if command exists
                    string primaryCommand = args[0].ToLower().Trim();
                    bool commandExists = false;
                    _args.AddRange(args);
                    int commandIndex = -1;
                    for (int i = 0; i < Util.Commands.Count; i++)
                    {
                        // Checks if the flag is a valid argument
                        commandExists = primaryCommand == Util.Commands[i].Name      || 
                                        primaryCommand == Util.Commands[i].ShortName || 
                                        commandExists;
                        commandIndex = i;
                        if (commandExists) break;
                    }

                    // If the flag is valid, execute the command
                    if (commandExists) Util.Commands[commandIndex].Execute();
                    // Else exit the program
                    else 
                    {
                        Console.WriteLine("\"" + primaryCommand + "\" is not a valid command, try winbuntu help for more options.");
                        Environment.Exit(0);
                    }
            }   

            // If no args were passed, exit  
            else 
            {
                Console.Write("No command line arguments found, ");
                Util.Commands[2].Execute();
                Environment.Exit(0);
            } 
        }
    }
}
