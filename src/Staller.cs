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

namespace Winbuntu
{
    class Staller
    {
        /// <summary>
        /// Function to install a piece of software to the system and add it to the Winbuntu registry
        /// </summary>
        public static void Install()
        {
            string target = Program._args[Program._args.Count - 1];

            Console.WriteLine("Installing {0}", target);
        }

        /// <summary>
        /// Function to remove a piece of software from the system and Winbuntu registry
        /// </summary>
        public static void Uninstall()
        {
            string target = Program._args[Program._args.Count - 1];

            Console.WriteLine("Removing {0}", target);
        }
    }
}